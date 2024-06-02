using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(LevelLoader.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(LevelLoader.BuildInfo.Company)]
[assembly: AssemblyProduct(LevelLoader.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + LevelLoader.BuildInfo.Author)]
[assembly: AssemblyTrademark(LevelLoader.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(LevelLoader.BuildInfo.Version)]
[assembly: AssemblyFileVersion(LevelLoader.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(LevelLoader.LoadLevelsMain), LevelLoader.BuildInfo.Name, LevelLoader.BuildInfo.Version, LevelLoader.BuildInfo.Author, LevelLoader.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]