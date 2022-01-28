using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SIADL.Avalonia.Tester.Views
{
    public partial class Window2 : Window
    {
        public Window2()
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
