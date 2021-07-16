using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SIADL.Avalonia.Common.Views
{
    public partial class TextEntryBox : Window
    {
        public TextEntryBox()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
