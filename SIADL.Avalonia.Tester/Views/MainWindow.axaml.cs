using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Themes.Fluent;

namespace SIADL.Avalonia.Tester.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var themes = this.Find<ComboBox>("Themes");
            themes.SelectionChanged += (sender, e) =>
            {
                switch (themes.SelectedIndex)
                {
                    case 0:
                        Styles[0] = new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
                        {
                            Source = new System.Uri("avares://SIADL.Avalonia/LightTheme.axaml")
                        };
                        Styles[1] = new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
                        {
                            Source = new System.Uri("resm:Avalonia.Themes.Default.Accents.BaseLight.xaml?assembly=Avalonia.Themes.Default")
                        };
                        break;
                    case 1:
                        Styles[0] = new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
                        {
                            Source = new System.Uri("avares://SIADL.Avalonia/DarkTheme.axaml")
                        };
                        Styles[1] = new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
                        {
                            Source = new System.Uri("resm:Avalonia.Themes.Default.Accents.BaseDark.xaml?assembly=Avalonia.Themes.Default")
                        };
                        break;
                }
            };
            Styles.Add(new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
            {
                Source = new System.Uri("avares://SIADL.Avalonia/LightTheme.axaml")
            });
            Styles.Add(new StyleInclude(new System.Uri("avares://SIADL.Avalonia"))
            {
                Source = new System.Uri("resm:Avalonia.Themes.Default.Accents.BaseLight.xaml?assembly=Avalonia.Themes.Default")
            });
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
