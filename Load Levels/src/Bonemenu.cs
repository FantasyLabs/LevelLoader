using BoneLib.BoneMenu.Elements;
using BoneLib.BoneMenu;
using UnityEngine;
using LevelLoader;

namespace LoadLevels
{
    public static class LoaderBonemenu
    {
        public static MenuCategory mainCategory;
        public static void CreateBonemenu()
        {
            mainCategory = MenuManager.CreateCategory("<color=#ff0000>L<color=#ffa500>e<color=#300000>v<color=#ffff00>e<color=#008000>l<color=#ff0000> L<color=#ffa500>o<color=#300000>a<color=#ffff00>d<color=#008000>e<color=#0000ff>r", Color.yellow);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level1.Value, Color.red, LoadLevelsMain.LoadLevel1);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level2.Value, Color.yellow, LoadLevelsMain.LoadLevel2);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level3.Value, Color.green, LoadLevelsMain.LoadLevel3);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level4.Value, Color.blue, LoadLevelsMain.LoadLevel4);

            mainCategory.CreateFunctionElement(LoadLevelsMain.level5.Value, Color.black, LoadLevelsMain.LoadLevel5);
        }
    }
}