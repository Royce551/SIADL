using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SIADL.Avalonia.Tester.Views
{
    public partial class Window1 : Window
    {
        public Window1()
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
