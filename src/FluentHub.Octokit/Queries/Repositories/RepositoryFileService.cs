namespace FluentHub.Octokit.Queries.Repositories
{
	public class RepositoryFileService
	{
		public async Task<RepositoryFileChangeResult> CreateFileAsync(
			string owner,
			string name,
			string path,
			string message,
			string content,
			string branch,
			string? committerName = null,
			string? committerEmail = null)
		{
			var client = App.Client
				?? throw new InvalidOperationException("Octokit GitHub client has not been initialized.");

			var committer = new OctokitV3.Committer
			{
				Name = committerName ?? "FluentHub",
				Email = committerEmail ?? "fluenthub@users.noreply.github.com",
			};

			var createRequest = new OctokitV3.CreateFileRequest(message, content, branch)
			{
				Committer = committer,
			};

			var result = await client.Repository.Content.CreateFile(
				owner, name, path, createRequest);

			return new RepositoryFileChangeResult
			{
				Commit = new RepositoryFileCommit
				{
					Sha = result.Commit.Sha,
					Message = result.Commit.Message,
					Author = result.Commit.Author?.Name ?? "Unknown",
					Date = result.Commit.Author?.Date ?? DateTimeOffset.UtcNow,
				},
				Content = new RepositoryFileContent
				{
					Name = result.Content.Name,
					Path = result.Content.Path,
					Sha = result.Content.Sha,
					Size = result.Content.Size,
				},
			};
		}

		public async Task<RepositoryFileChangeResult> UpdateFileAsync(
			string owner,
			string name,
			string path,
			string message,
			string content,
			string fileSha,
			string branch,
			string? committerName = null,
			string? committerEmail = null)
		{
			var client = App.Client
				?? throw new InvalidOperationException("Octokit GitHub client has not been initialized.");

			var committer = new OctokitV3.Committer
			{
				Name = committerName ?? "FluentHub",
				Email = committerEmail ?? "fluenthub@users.noreply.github.com",
			};

			var updateRequest = new OctokitV3.UpdateFileRequest(message, content, fileSha, branch)
			{
				Committer = committer,
			};

			var result = await client.Repository.Content.UpdateFile(
				owner, name, path, updateRequest);

			return new RepositoryFileChangeResult
			{
				Commit = new RepositoryFileCommit
				{
					Sha = result.Commit.Sha,
					Message = result.Commit.Message,
					Author = result.Commit.Author?.Name ?? "Unknown",
					Date = result.Commit.Author?.Date ?? DateTimeOffset.UtcNow,
				},
				Content = new RepositoryFileContent
				{
					Name = result.Content.Name,
					Path = result.Content.Path,
					Sha = result.Content.Sha,
					Size = result.Content.Size,
				},
			};
		}

		public async Task<RepositoryFileChangeResult> DeleteFileAsync(
			string owner,
			string name,
			string path,
			string message,
			string fileSha,
			string branch,
			string? committerName = null,
			string? committerEmail = null)
		{
			var client = App.Client
				?? throw new InvalidOperationException("Octokit GitHub client has not been initialized.");

			var committer = new OctokitV3.Committer
			{
				Name = committerName ?? "FluentHub",
				Email = committerEmail ?? "fluenthub@users.noreply.github.com",
			};

			var deleteRequest = new OctokitV3.DeleteFileRequest(message, fileSha, branch)
			{
				Committer = committer,
			};

			await client.Repository.Content.DeleteFile(
				owner, name, path, deleteRequest);

			return new RepositoryFileChangeResult
			{
				Commit = new RepositoryFileCommit
				{
					Sha = fileSha,
					Message = message,
					Author = committerName ?? "FluentHub",
					Date = DateTimeOffset.UtcNow,
				},
			};
		}

		public async Task<RepositoryFileDetail> GetFileAsync(
			string owner,
			string name,
			string path,
			string branch)
		{
			var client = App.Client
				?? throw new InvalidOperationException("Octokit GitHub client has not been initialized.");

			var contents = await client.Repository.Content.GetAllContentsByRef(
				owner, name, path, branch);

			var file = contents.FirstOrDefault()
				?? throw new OctokitV3.NotFoundException($"File not found: {path}", System.Net.HttpStatusCode.NotFound);

			return new RepositoryFileDetail
			{
				Name = file.Name,
				Path = file.Path,
				Sha = file.Sha,
				Size = file.Size,
				Content = file.Content,
				Encoding = file.Encoding,
				DownloadUrl = file.DownloadUrl,
				HtmlUrl = file.HtmlUrl,
			};
		}
	}

	public class RepositoryFileChangeResult
	{
		public RepositoryFileCommit Commit { get; set; } = default!;
		public RepositoryFileContent? Content { get; set; }
	}

	public class RepositoryFileCommit
	{
		public string Sha { get; set; } = default!;
		public string Message { get; set; } = default!;
		public string Author { get; set; } = default!;
		public DateTimeOffset Date { get; set; }
	}

	public class RepositoryFileContent
	{
		public string Name { get; set; } = default!;
		public string Path { get; set; } = default!;
		public string Sha { get; set; } = default!;
		public long Size { get; set; }
	}

	public class RepositoryFileDetail
	{
		public string Name { get; set; } = default!;
		public string Path { get; set; } = default!;
		public string Sha { get; set; } = default!;
		public long Size { get; set; }
		public string? Content { get; set; }
		public string? Encoding { get; set; }
		public string? DownloadUrl { get; set; }
		public string? HtmlUrl { get; set; }
	}
}
