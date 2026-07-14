using FluentHub.App.Services;
using FluentHub.App.ViewModels.Repositories;
using FluentHub.App.ViewModels.Repositories.Codes;
using FluentHub.App.Data.Parameters;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace FluentHub.App.Views.Repositories.Code
{
	public sealed partial class FileEditorPage : LocatablePage
	{
		public FileEditorViewModel ViewModel { get; }
		private readonly INavigationService _navigation;

		public FileEditorPage()
			: base(NavigationPageKind.Repository, NavigationPageKey.Code)
		{
			InitializeComponent();

			ViewModel = Ioc.Default.GetRequiredService<FileEditorViewModel>();
			_navigation = Ioc.Default.GetRequiredService<INavigationService>();
			_pageLoadCommand = ViewModel.LoadFileCommand;
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			if (e.Parameter is FrameNavigationParameter param)
			{
				ViewModel.ContextViewModel = param.Parameters as RepoContextViewModel;

				// The file path should be passed as PrimaryText or in Parameters
				if (param.Parameters is string filePath)
				{
					ViewModel.FilePath = filePath;
				}
			}

			var command = ViewModel.LoadFileCommand;
			if (command.CanExecute(null))
				command.Execute(null);
		}

		private async void OnSaveFileClick(object sender, RoutedEventArgs e)
		{
			var dialog = new ContentDialog
			{
				Title = "Save Changes",
				Content = $"Are you sure you want to save changes to {ViewModel.FilePath}?",
				PrimaryButtonText = "Save",
				SecondaryButtonText = "Cancel",
				DefaultButton = ContentDialogButton.Primary,
				XamlRoot = this.Content.XamlRoot,
			};

			var result = await dialog.ShowAsync();
			if (result == ContentDialogResult.Primary)
			{
				var command = ViewModel.SaveFileCommand;
				if (command.CanExecute(null))
					command.Execute(null);
			}
		}

		private async void OnDeleteFileClick(object sender, RoutedEventArgs e)
		{
			var dialog = new ContentDialog
			{
				Title = "Delete File",
				Content = $"Are you sure you want to delete {ViewModel.FilePath}? This action cannot be undone.",
				PrimaryButtonText = "Delete",
				SecondaryButtonText = "Cancel",
				DefaultButton = ContentDialogButton.Secondary,
				XamlRoot = this.Content.XamlRoot,
			};

			var result = await dialog.ShowAsync();
			if (result == ContentDialogResult.Primary)
			{
				var command = ViewModel.DeleteFileCommand;
				if (command.CanExecute(null))
					command.Execute(null);
			}
		}
	}
}
