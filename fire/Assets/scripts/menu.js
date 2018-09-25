//#pragma strict

function OnGUI() {
    if (GUI.Button(Rect(650, 750, 100, 50), "Begin")) {
        Application.LoadLevel("fire");
    }
    if (GUI.Button(Rect(750, 750, 100, 50), "Quit")) {
        Application.Quit();
    }
    
}