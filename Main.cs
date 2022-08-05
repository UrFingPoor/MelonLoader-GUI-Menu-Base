using MelonLoader;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace SpacewareCheats
{
    class MainUI
    {
	    public static bool showMenu = false;
	    private static object selectedPlayer;
	    private static int selectedTab, yOffset = 0;
	    private static GUIStyle MainBox, Header, MainTabs = null;
	     
        public static void ToggleMenu() => showMenu = !showMenu;
		
        private static Texture2D MakeTex(int width, int height, Color col)
        {
            Color[] pix = new Color[width * height]; for (int i = 0; i < pix.Length; ++i) pix[i] = col;

            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }
		
		  public static void DisplayHud()
        {
            GUI.BeginGroup(new Rect(10, 2, 328, 25));
            Header = new GUIStyle(GUI.skin.box);
            Header.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.75f));
            Header.normal.textColor = Color.black;
            GUI.Box(new Rect(10, 0, 328, 25), $"▼ Area 51 | Owner | User: Josh | Ur Mad kid!  ", Header);
            GUI.EndGroup(); 
        }
		
        public static void InitMenu()
        {
			DisplayHud(); // Will show even if the menu isn't open
           
 		    if (!showMenu) return; 
			
			// Menu Background Setup
            GUI.BeginGroup(new Rect(10, 10, 330, 500));
            MainBox = new GUIStyle(GUI.skin.box);
            MainBox.normal.background = MakeTex(2, 2, new Color(0f, 0f, 0f, 1.0f));
            GUI.Box(new Rect(10, 12, 330, 500), $"Area 51 | Developer | Ver 0.5.1 | Build A51", MainBox);
            GUI.contentColor = Color.yellow;
            GUI.Label(new Rect(50, 16.5f, 400, 42), $"___________________________________");
            GUI.contentColor = Color.green;
            MainTabs = new GUIStyle(GUI.skin.button);
            MainTabs.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.75f));
            MainTabs.normal.textColor = Color.black;
           
			// This should be updated as this is ghetto!
			// This draws the buttons to a fixed location.
		    if (GUI.Button(new Rect(20, 40, 60, 27), (selectedTab == 0) ? "► Main" : "Main", MainTabs)) { selectedTab = 0; }
            if (GUI.Button(new Rect(80, 40, 60, 27), (selectedTab == 1) ? "► Fun" : "Fun", MainTabs)) { selectedTab = 1; }
            if (GUI.Button(new Rect(140, 40, 60, 27), (selectedTab == 2) ? "► World" : "World", MainTabs)) { selectedTab = 2; }
            if (GUI.Button(new Rect(200, 40, 60, 27), (selectedTab == 3) ? "► Misc" : "Misc", MainTabs)) { selectedTab = 3; }
            if (GUI.Button(new Rect(260, 40, 60, 27), (selectedTab == 4) ? "► Users" : "Users", MainTabs)) { selectedTab = 4; }
         
            // Choose the tab to render when selected.
            switch (selectedTab)
            {
                case 0: break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
            }
            GUI.EndGroup();
        }
    }
}
