namespace HelloApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new DynamicXamlLoadPage();
		//MainPage = new SimpleClassPage();
	}
}
