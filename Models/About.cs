namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://zakitworld.netlify.app";
    public string Message => "This app is written by Abdul-Razak of Zak IT World in XAML and C# with .NET MAUI.";
}