using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Utils;

namespace FluentHub.App.ViewModels.UserControls.BlockButtons
{
	public class NotificationBlockButtonViewModel : ObservableObject
	{
		private Notification _item = default!;
		public Notification Item { get => _item; set => SetProperty(ref _item, value); }
	}
}
