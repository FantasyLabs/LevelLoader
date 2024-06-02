using MelonLoader;
using SLZ.Marrow.SceneStreaming;
using LoadLevels;
using SLZ.Marrow.Warehouse;

namespace LevelLoader
{
    public static class BuildInfo
    {
        public const string Name = "LevelLoader";
        public const string Author = "Son of Forehead";
        public const string Version = "1.0.0";
        public const string Company = null;
        public const string DownloadLink = null;
    }

    public class LoadLevelsMain : MelonMod
    {
        // Melon Prefs
        public static MelonPreferences_Category mainPrefCategory;
        public static MelonPreferences_Entry<string> level1;
        public static MelonPreferences_Entry<string> level2;
        public static MelonPreferences_Entry<string> level3;
        public static MelonPreferences_Entry<string> level4;
        public static MelonPreferences_Entry<string> level5;

        // Barcodes
        public static string barcode1;
        public static string barcode2;
        public static string barcode3;
        public static string barcode4;
        public static string barcode5;

        public override void OnInitializeMelon()
        {
            CreateMelonPrefs();
            LoaderBonemenu.CreateBonemenu();
            barcode1 = level1.Value;
            barcode2 = level2.Value;
            barcode3 = level3.Value;
            barcode4 = level4.Value;
            barcode5 = level5.Value;
        }

        public static void CreateMelonPrefs() // melon prefs aint... preferencing...???
        {
            mainPrefCategory = MelonPreferences.CreateCategory("LevelLoader");
            level1 = mainPrefCategory.CreateEntry<string>("LVL_1:", "VoidG114");
            level2 = mainPrefCategory.CreateEntry<string>("LVL_2:", "VoidG114");
            level3 = mainPrefCategory.CreateEntry<string>("LVL_3:", "VoidG114");
            level4 = mainPrefCategory.CreateEntry<string>("LVL_4:", "VoidG114");
            level5 = mainPrefCategory.CreateEntry<string>("LVL_5:", "VoidG114");
        }

        public static void LoadLevel1()
        {
            if(barcode1.Contains("." + "." + ".")) // pls make work
            {
                MelonLogger.Msg("Valid Level Barcode!");
            }
            else
            {
                MelonLogger.Warning("Invalid Level Barcode!");
            }

            SceneStreamer.Load(barcode1);
            MelonLogger.Msg("Loading: " + barcode1 + "...");
        }

        public static void LoadLevel2()
        {
            SceneStreamer.Load(barcode2);
            MelonLogger.Msg("Loading: " + barcode1 + "...");
        }

        public static void LoadLevel3()
        {
            SceneStreamer.Load(barcode3);
            MelonLogger.Msg("Loading: " + barcode1 + "...");
        }

        public static void LoadLevel4()
        {
            SceneStreamer.Load(barcode4);
            MelonLogger.Msg("Loading: " + barcode1 + "...");
        }

        public static void LoadLevel5()
        {
            SceneStreamer.Load(barcode5);
            MelonLogger.Msg("Loading: " + barcode1 + "...");
        }
    }
}