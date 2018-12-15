using System;

namespace ObservableMvvmExt
{
    /// <summary>
    /// Base view model ext.
    /// </summary>
    public class BaseViewModelExt : ObservableObjectExt
    {
        string title = string.Empty;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string TitleExt
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        string subtitle = string.Empty;

        /// <summary>
        /// Gets or sets the subtitle.
        /// </summary>
        /// <value>The subtitle.</value>
        public string SubtitleExt
        {
            get => subtitle;
            set => SetProperty(ref subtitle, value);
        }

        string icon = string.Empty;

        /// <summary>
        /// Gets or sets the icon ext.
        /// </summary>
        /// <value>The icon ext.</value>
        public string IconExt
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }

        bool isBusy;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ObservableMvvmExt.BaseViewModelExt"/> is busy ext.
        /// </summary>
        /// <value><c>true</c> if is busy ext; otherwise, <c>false</c>.</value>
        public bool IsBusyExt
        {
            get => isBusy;
            set
            {
                if (SetProperty(ref isBusy, value))
                    IsNotBusyExt = !isBusy;
            }
        }

        bool isNotBusy;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ObservableMvvmExt.BaseViewModelExt"/> is not busy ext.
        /// </summary>
        /// <value><c>true</c> if is not busy ext; otherwise, <c>false</c>.</value>
        public bool IsNotBusyExt
        {
            get => isNotBusy;
            set
            {
                if (SetProperty(ref isNotBusy, value))
                    IsBusyExt = !isNotBusy;
            }
        }

        bool canLoadMore = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:ObservableMvvmExt.BaseViewModelExt"/> can load more.
        /// </summary>
        /// <value><c>true</c> if can load more; otherwise, <c>false</c>.</value>
        public bool CanLoadMore
        {
            get => canLoadMore;
            set => SetProperty(ref canLoadMore, value);
        }

        string header = string.Empty;

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>The header.</value>
        public string Header
        {
            get => header;
            set => SetProperty(ref header, value);
        }

        string footer = string.Empty;

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>The footer.</value>
        public string Footer
        {
            get => footer;
            set => SetProperty(ref footer, value);
        }
    }
}
