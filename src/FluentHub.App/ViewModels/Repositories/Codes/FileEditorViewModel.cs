using FluentHub.Octokit.Queries.Repositories;
using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.Utils;
using FluentHub.App.ViewModels.Repositories;
using FluentHub.Octokit.Models.v4;

namespace FluentHub.App.ViewModels.Repositories.Codes
{
	public class FileEditorViewModel : BaseViewModel
	{
		private RepoContextViewModel _contextViewModel = default!;
		public RepoContextViewModel ContextViewModel { get => _contextViewModel; set => SetProperty(ref _contextViewModel, value); }

		private string _filePath = default!;
		public string FilePath { get => _filePath; set => SetProperty(ref _filePath, value); }

		private string _fileContent = default!;
		public string FileContent { get => _fileContent; set => SetProperty(ref _fileContent, value); }

		private string _originalContent = default!;
		public string OriginalContent { get => _originalContent; set => SetProperty(ref _originalContent, value); }

		private string _commitMessage = default!;
		public string CommitMessage { get => _commitMessage; set => SetProperty(ref _commitMessage, value); }

		private string _commitDescription = default!;
		public string CommitDescription { get => _commitDescription; set => SetProperty(ref _commitDescription, value); }

		private string _fileSha = default!;
		public string FileSha { get => _fileSha; set => SetProperty(ref _fileSha, value); }

		private bool _isNewFile;
		public bool IsNewFile { get => _isNewFile; set => SetProperty(ref _isNewFile, value); }

		private bool _isEditing;
		public bool IsEditing { get => _isEditing; set => SetProperty(ref _isEditing, value); }

		private bool _isDirty;
		public bool IsDirty { get => _isDirty; set => SetProperty(ref _isDirty, value); }

		private string _statusMessage = default!;
		public string StatusMessage { get => _statusMessage; set => SetProperty(ref _statusMessage, value); }

		private bool _hasStatusMessage;
		public bool HasStatusMessage { get => _hasStatusMessage; set => SetProperty(ref _hasStatusMessage, value); }

		private bool _isSaveSuccessful;
		public bool IsSaveSuccessful { get => _isSaveSuccessful; set => SetProperty(ref _isSaveSuccessful, value); }

		public IAsyncRelayCommand LoadFileCommand { get; }
		public IAsyncRelayCommand SaveFileCommand { get; }
		public IAsyncRelayCommand CreateNewFileCommand { get; }
		public IAsyncRelayCommand DeleteFileCommand { get; }

		public FileEditorViewModel() : base()
		{
			LoadFileCommand = new AsyncRelayCommand(LoadFileAsync);
			SaveFileCommand = new AsyncRelayCommand(SaveFileAsync);
			CreateNewFileCommand = new AsyncRelayCommand(CreateNewFileAsync);
			DeleteFileCommand = new AsyncRelayCommand(DeleteFileAsync);
		}

		private async Task LoadFileAsync()
		{
			SetTabInformation("File Editor", "File Editor", "Repositories");
			SetLoadingProgress(true);

			try
			{
				if (string.IsNullOrEmpty(FilePath))
					return;

				RepositoryFileService fileService = new();
				var fileDetail = await fileService.GetFileAsync(
					ContextViewModel.Repository.Owner.Login,
					ContextViewModel.Repository.Name,
					FilePath,
					ContextViewModel.BranchName);

				FileSha = fileDetail.Sha;
				OriginalContent = fileDetail.Content ?? string.Empty;
				FileContent = OriginalContent;
				IsDirty = false;

				SetTabInformation($"Editing: {FilePath}", $"Editing: {FilePath}");
			}
			catch (Exception ex)
			{
				TaskException = ex;
				IsTaskFaulted = true;
				_logger?.Error(nameof(LoadFileAsync), ex);
			}
			finally
			{
				SetLoadingProgress(false);
			}
		}

		private async Task SaveFileAsync()
		{
			SetLoadingProgress(true);
			HasStatusMessage = false;

			try
			{
				if (string.IsNullOrEmpty(CommitMessage))
				{
					StatusMessage = "Commit message is required.";
					HasStatusMessage = true;
					IsSaveSuccessful = false;
					return;
				}

				RepositoryFileService fileService = new();

				if (IsNewFile)
				{
					var result = await fileService.CreateFileAsync(
						ContextViewModel.Repository.Owner.Login,
						ContextViewModel.Repository.Name,
						FilePath,
						CommitMessage,
						FileContent,
						ContextViewModel.BranchName);

					FileSha = result.Content?.Sha ?? result.Commit.Sha;
					IsNewFile = false;
				}
				else
				{
					var result = await fileService.UpdateFileAsync(
						ContextViewModel.Repository.Owner.Login,
						ContextViewModel.Repository.Name,
						FilePath,
						CommitMessage,
						FileContent,
						FileSha,
						ContextViewModel.BranchName);

					FileSha = result.Content?.Sha ?? result.Commit.Sha;
				}

				OriginalContent = FileContent;
				IsDirty = false;
				StatusMessage = "File saved successfully!";
				HasStatusMessage = true;
				IsSaveSuccessful = true;

				SetTabInformation($"Editing: {FilePath}", $"Editing: {FilePath}");
			}
			catch (Exception ex)
			{
				TaskException = ex;
				IsTaskFaulted = true;
				StatusMessage = $"Error saving file: {ex.Message}";
				HasStatusMessage = true;
				IsSaveSuccessful = false;
				_logger?.Error(nameof(SaveFileAsync), ex);
			}
			finally
			{
				SetLoadingProgress(false);
			}
		}

		private async Task CreateNewFileAsync()
		{
			SetLoadingProgress(true);
			HasStatusMessage = false;

			try
			{
				if (string.IsNullOrEmpty(CommitMessage))
				{
					StatusMessage = "Commit message is required.";
					HasStatusMessage = true;
					IsSaveSuccessful = false;
					return;
				}

				RepositoryFileService fileService = new();
				var result = await fileService.CreateFileAsync(
					ContextViewModel.Repository.Owner.Login,
					ContextViewModel.Repository.Name,
					FilePath,
					CommitMessage,
					FileContent,
					ContextViewModel.BranchName);

				FileSha = result.Content?.Sha ?? result.Commit.Sha;
				IsNewFile = false;
				OriginalContent = FileContent;
				IsDirty = false;
				StatusMessage = "File created successfully!";
				HasStatusMessage = true;
				IsSaveSuccessful = true;

				SetTabInformation($"Editing: {FilePath}", $"Editing: {FilePath}");
			}
			catch (Exception ex)
			{
				TaskException = ex;
				IsTaskFaulted = true;
				StatusMessage = $"Error creating file: {ex.Message}";
				HasStatusMessage = true;
				IsSaveSuccessful = false;
				_logger?.Error(nameof(CreateNewFileAsync), ex);
			}
			finally
			{
				SetLoadingProgress(false);
			}
		}

		private async Task DeleteFileAsync()
		{
			SetLoadingProgress(true);
			HasStatusMessage = false;

			try
			{
				if (string.IsNullOrEmpty(CommitMessage))
				{
					StatusMessage = "Commit message is required for deletion.";
					HasStatusMessage = true;
					IsSaveSuccessful = false;
					return;
				}

				RepositoryFileService fileService = new();
				await fileService.DeleteFileAsync(
					ContextViewModel.Repository.Owner.Login,
					ContextViewModel.Repository.Name,
					FilePath,
					CommitMessage,
					FileSha,
					ContextViewModel.BranchName);

				StatusMessage = "File deleted successfully!";
				HasStatusMessage = true;
				IsSaveSuccessful = true;
			}
			catch (Exception ex)
			{
				TaskException = ex;
				IsTaskFaulted = true;
				StatusMessage = $"Error deleting file: {ex.Message}";
				HasStatusMessage = true;
				IsSaveSuccessful = false;
				_logger?.Error(nameof(DeleteFileAsync), ex);
			}
			finally
			{
				SetLoadingProgress(false);
			}
		}

		public void OnContentChanged(string newContent)
		{
			FileContent = newContent;
			IsDirty = FileContent != OriginalContent;
		}
	}
}
