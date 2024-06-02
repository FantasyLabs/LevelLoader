using MelonLoader;
using SLZ.Marrow.SceneStreaming;
using LoadLevels;
using SLZ.Marrow.Warehouse;
using SLZ.Bonelab;

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

        public static void CreateMelonPrefs()
        {
            mainPrefCategory = MelonPreferences.CreateCategory("LevelLoader");
            level1 = mainPrefCategory.CreateEntry<string>("LVL_1:", "default");
            level2 = mainPrefCategory.CreateEntry<string>("LVL_2:", "default");
            level3 = mainPrefCategory.CreateEntry<string>("LVL_3:", "default");
            level4 = mainPrefCategory.CreateEntry<string>("LVL_4:", "default");
            level5 = mainPrefCategory.CreateEntry<string>("LVL_5:", "default");
        }

        public static void LoadLevel1()
        {
            if(barcode1.Contains(".Level."))
            {
                MelonLogger.Msg("Valid Level Barcode!");
                SceneStreamer.Load(barcode1);
                MelonLogger.Msg("Loading: " + barcode1 + "...");
            }
            else
            {
                LoaderBonemenu.InvalidBarcode();
            }
        }

        public static void LoadLevel2()
        {
            if (barcode2.Contains(".Level."))
            {
                MelonLogger.Msg("Valid Level Barcode!");
                SceneStreamer.Load(barcode2);
                MelonLogger.Msg("Loading: " + barcode2 + "...");
            }
            else
            {
                LoaderBonemenu.InvalidBarcode();
            }
        }

        public static void LoadLevel3()
        {
            if (barcode3.Contains(".Level."))
            {
                MelonLogger.Msg("Valid Level Barcode!");
                SceneStreamer.Load(barcode3);
                MelonLogger.Msg("Loading: " + barcode3 + "...");
            }
            else
            {
                LoaderBonemenu.InvalidBarcode();
            }
        }

        public static void LoadLevel4()
        {
            if (barcode4.Contains(".Level."))
            {
                MelonLogger.Msg("Valid Level Barcode!");
                SceneStreamer.Load(barcode4);
                MelonLogger.Msg("Loading: " + barcode4 + "...");
            }
            else
            {
                LoaderBonemenu.InvalidBarcode();
            }
        }

        public static void LoadLevel5()
        {
            if (barcode5.Contains(".Level."))
            {
                MelonLogger.Msg("Valid Level Barcode!");
                SceneStreamer.Load(barcode5);
                MelonLogger.Msg("Loading: " + barcode5 + "...");
            }
            else
            {
                LoaderBonemenu.InvalidBarcode();
            }
        }
    }
}