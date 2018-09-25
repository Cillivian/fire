#pragma strict

function OnGUI(){
		if(GUI.Button(Rect(580,750,100,50),"Quit")){
		Application.Quit();				
		}
		if(GUI.Button(Rect(380,750,100,50),"Restart")){
		Application.LoadLevel("fire");
		}
	 
		
				
}
