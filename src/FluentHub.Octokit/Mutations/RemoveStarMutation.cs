namespace FluentHub.Octokit.Mutations
{
	public class RemoveStarMutation
	{
		public Task<RemoveStarPayload> ExecuteAsync(ID starrableRepoId)
		{
			var mutation = new Mutation()
				.RemoveStar(new(new OctokitGraphQLModel.RemoveStarInput
				{
					StarrableId = starrableRepoId,
				}))
				.Select(x => new RemoveStarPayload
				{
					ClientMutationId = x.ClientMutationId,
				})
				.Compile();

			return MutationExecutor.RunAsync(mutation);
		}
	}
}
