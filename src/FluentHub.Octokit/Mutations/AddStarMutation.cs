namespace FluentHub.Octokit.Mutations
{
	public class AddStarMutation
	{
		public Task<AddStarPayload> ExecuteAsync(ID starrableRepoId)
		{
			var mutation = new Mutation()
				.AddStar(new(new OctokitGraphQLModel.AddStarInput
				{
					StarrableId = starrableRepoId,
				}))
				.Select(x => new AddStarPayload
				{
					ClientMutationId = x.ClientMutationId,
				})
				.Compile();

			return MutationExecutor.RunAsync(mutation);
		}
	}
}
