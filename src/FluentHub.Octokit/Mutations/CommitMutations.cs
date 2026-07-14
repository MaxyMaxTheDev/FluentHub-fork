namespace FluentHub.Octokit.Mutations
{
	public class CommitMutations
	{
		public async Task<CreateCommitOnBranchPayload> CreateCommitOnBranchAsync(CreateCommitOnBranchInput input)
		{
			ArgumentNullException.ThrowIfNull(input);

			var connection = App.Connection
				?? throw new InvalidOperationException("Octokit GraphQL connection has not been initialized.");

			var graphInput = ToGraphQLInput(input);

			var query = new Mutation()
				.CreateCommitOnBranch(graphInput)
				.Select(x => new CreateCommitOnBranchPayload
				{
					ClientMutationId = x.ClientMutationId,
					Commit = x.Commit.Select(commit => new Commit
					{
						Oid = commit.Oid,
						Message = commit.Message,
						MessageHeadline = commit.MessageHeadline,
						CommittedDate = commit.CommittedDate,
						Additions = commit.Additions,
						Deletions = commit.Deletions,
						ChangedFiles = commit.ChangedFiles,
						Author = commit.Author.Select(author => new GitActor
						{
							AvatarUrl = author.AvatarUrl(500),
							Name = author.Name,
							Date = author.Date,
							User = author.User.Select(user => new User
							{
								Login = user.Login,
								AvatarUrl = user.AvatarUrl(500),
							}).SingleOrDefault(),
						}).SingleOrDefault(),
					}).SingleOrDefault(),
					Ref = x.Ref.Select(r => new Ref
					{
						Name = r.Name,
						Prefix = r.Prefix,
					}).SingleOrDefault(),
				})
				.Compile();

			var result = await connection.Run(query);

			return result;
		}

		private static OctokitGraphQLModel.CreateCommitOnBranchInput ToGraphQLInput(CreateCommitOnBranchInput input)
		{
			var graphInput = new OctokitGraphQLModel.CreateCommitOnBranchInput
			{
				ExpectedHeadOid = input.ExpectedHeadOid,
			};

			if (input.Branch is not null)
			{
				graphInput.Branch = new OctokitGraphQLModel.CommittableBranch
				{
					Id = input.Branch.Id?.Value,
					RepositoryNameWithOwner = input.Branch.RepositoryNameWithOwner,
					BranchName = input.Branch.BranchName,
				};
			}

			if (input.Message is not null)
			{
				graphInput.Message = new OctokitGraphQLModel.CommitMessage
				{
					Headline = input.Message.Headline,
					Body = input.Message.Body,
				};
			}

			if (input.FileChanges is not null)
			{
				graphInput.FileChanges = new OctokitGraphQLModel.FileChanges();

				if (input.FileChanges.Additions is not null)
				{
					graphInput.FileChanges.Additions = input.FileChanges.Additions
						.Select(a => new OctokitGraphQLModel.FileAddition
						{
							Path = a.Path,
							Contents = a.Contents,
						})
						.ToList();
				}

				if (input.FileChanges.Deletions is not null)
				{
					graphInput.FileChanges.Deletions = input.FileChanges.Deletions
						.Select(d => new OctokitGraphQLModel.FileDeletion
						{
							Path = d.Path,
						})
						.ToList();
				}
			}

			return graphInput;
		}
	}
}
