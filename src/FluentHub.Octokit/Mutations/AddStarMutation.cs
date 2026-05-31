namespace FluentHub.Octokit.Mutations
{
	public class AddStarMutation
	{
		public async Task Execute(ID starrableRepoId)
		{
			var payload = new Mutation()
			.AddStar(new(new() { StarrableId = starrableRepoId }))
			.Select(x => new RemoveStarPayload
			{
				ClientMutationId = x.ClientMutationId,
			})
			.Compile();

			var response = await App.Connection.Run(payload);
		}
	}
}
