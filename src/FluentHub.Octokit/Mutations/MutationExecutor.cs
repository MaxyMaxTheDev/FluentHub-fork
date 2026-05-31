using System.Threading;

namespace FluentHub.Octokit.Mutations
{
	internal static class MutationExecutor
	{
		public static Task<TPayload> RunAsync<TPayload>(
			ICompiledQuery<TPayload> mutation,
			CancellationToken cancellationToken = default)
		{
			ArgumentNullException.ThrowIfNull(mutation);

			if (!mutation.IsMutation)
				throw new ArgumentException("Expected a GraphQL mutation.", nameof(mutation));

			var connection = App.Connection
				?? throw new InvalidOperationException("Octokit GraphQL connection has not been initialized.");

			return connection.Run(mutation, cancellationToken: cancellationToken);
		}
	}
}
