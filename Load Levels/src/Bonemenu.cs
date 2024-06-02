using BoneLib.BoneMenu.Elements;
using BoneLib.BoneMenu;
using UnityEngine;
using LevelLoader;
using BoneLib.Notifications;
using MelonLoader;

namespace LoadLevels
{
    public static class LoaderBonemenu
    {
        public static MenuCategory mainCategory;
        public static Notification invalidNotification;

        public static void CreateBonemenu()
        {
            mainCategory = MenuManager.CreateCategory("LevelLoader", Color.blue);

            mainCategory.CreateFunctionElement("`Default` will load Void G114.", Color.red, () => { });
            mainCategory.CreateFunctionElement("Reload Preferences", Color.yellow, ReloadPrefs);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level1.Value, Color.gray, LoadLevelsMain.LoadLevel1, "Are you sure?");

            mainCategory.CreateFunctionElement(LoadLevelsMain.level2.Value, Color.gray, LoadLevelsMain.LoadLevel2, "Are you sure?");

            mainCategory.CreateFunctionElement(LoadLevelsMain.level3.Value, Color.gray, LoadLevelsMain.LoadLevel3, "Are you sure?");

            mainCategory.CreateFunctionElement(LoadLevelsMain.level4.Value, Color.gray, LoadLevelsMain.LoadLevel4, "Are you sure?");

            mainCategory.CreateFunctionElement(LoadLevelsMain.level5.Value, Color.gray, LoadLevelsMain.LoadLevel5, "Are you sure?");
        }

        public static void ReloadPrefs()
        {
            mainCategory.Elements.Clear();
            LoadLevelsMain.barcode1 = LoadLevelsMain.level1.Value;
            LoadLevelsMain.barcode2 = LoadLevelsMain.level2.Value;
            LoadLevelsMain.barcode3 = LoadLevelsMain.level3.Value;
            LoadLevelsMain.barcode4 = LoadLevelsMain.level4.Value;
            LoadLevelsMain.barcode5 = LoadLevelsMain.level5.Value;
            CreateBonemenu();
        }

        public static void InvalidBarcode()
        {
            MelonLogger.Warning("Invalid Barcode!");

            invalidNotification = new Notification();
            invalidNotification.Title = "Level Loader";
            invalidNotification.Message = "Invalid Barcode!";
            invalidNotification.Type = NotificationType.Error;
            invalidNotification.PopupLength = 3;

            Notifier.Send(invalidNotification);
        }
    }
}