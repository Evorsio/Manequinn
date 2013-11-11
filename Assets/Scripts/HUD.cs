using UnityEngine;
using System.Collections;

public class HUD: MonoBehaviour {

	protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Tower;

    // Update is called once per frame
    void Update()
    {
		
    }
 
	 protected void OrbitTower(bool bLeft)
    {
       
     //   if (GUI.RepeatButton (new Rect (0,Screen.height - 50,100,50), "Bottom-left"))
    //    {
    //        transform.RotateAround(Tower.transform.position, Vector3.up, -fDistanceRadians);
    //    }
    //    else
    //        transform.RotateAround(Tower.transform.position, Vector3.up, fDistanceRadians);
    }
 
	int selectionGridInt = 0;
	public static bool visible = true;
	string[] selectionStrings = {"Right Foot", "Left Foot", "Right Leg", "Left Leg", "Right Arm", "Left Arm", "Center","Neck" , "Right Shoulder", "Left Shoulder", "Hip Right", "Hip Left"};
	
	void OnGUI()
	{
		float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
		float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
	
		
		if (GUI.Button (new Rect (Screen.width/2,Screen.height - 50,100,50), "HideM"))
		{
            visible^= true;
        }
		
		if (visible){
		
		if (GUI.RepeatButton (new Rect (0,Screen.height - 50,100,50), "Turn Left"))
		{
            transform.RotateAround(Tower.transform.position, Vector3.up, fDistanceRadians);
        }
		if (GUI.RepeatButton (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Turn Right"))
		{
			transform.RotateAround(Tower.transform.position, Vector3.up, -fDistanceRadians);
		}
		if (GUI.RepeatButton (new Rect (0,Screen.height - 160,100,50), "Zoom Out"))
		{
            transform.Translate(0, 0, -fSpeed/6, Space.Self);
        }
		if (GUI.RepeatButton (new Rect (0,Screen.height - 220,100,50), "Zoom in"))
		{
            transform.Translate(0, 0, fSpeed/6, Space.Self);
        }
		
		//Pan Buttons
		
		if (GUI.RepeatButton (new Rect (0,50,100,50), "Up"))
		{
            transform.Translate (0,-fSpeed/10,0);
        }
		if (GUI.RepeatButton (new Rect (0,100,100,50), "Down"))
		{
			transform.Translate(0,	fSpeed/10,0);
		}
		if (GUI.RepeatButton (new Rect (0,150,100,50), "Left"))
		{
            transform.Translate(fSpeed/10, 0, 0);
        }
		if (GUI.RepeatButton (new Rect (0,200,100,50), "Right"))
		{
            transform.Translate(-fSpeed/10, 0, 0);
        }
		
		if (Input.GetKey("d"))
		{
            transform.Translate(-fSpeed/10, 0, 0);
		}
		 if (Input.GetKey("a"))
		{
    		transform.Translate(fSpeed/10, 0, 0);
		}
		
		 if (Input.GetKey("w"))
		{
			transform.Translate (0,-fSpeed/10,0);
		}
		 if (Input.GetKey("s"))
		{
			transform.Translate(0,	fSpeed/10,0);
		}
		
		if(Input.GetKey("q"))
		{
			transform.RotateAround(Tower.transform.position, Vector3.up, -fDistanceRadians);;	
		}
		if(Input.GetKey("e"))
		{
			transform.RotateAround(Tower.transform.position, Vector3.up, fDistanceRadians);;			
		}

		GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP");
		GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP");
		GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP");
		GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN");
		GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN");
		GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN");
		
		GUI.Label (new Rect (Screen.width - 265, 310, 40, 30), "X", "box");
		GUI.Label (new Rect (Screen.width - 165, 310, 40, 30), "Y", "box");
		GUI.Label (new Rect (Screen.width - 65, 310, 40, 30), "Z", "box");
		selectionGridInt = GUI.SelectionGrid (new Rect (Screen.width - 300, 50 , 300, 150), selectionGridInt, selectionStrings, 2);
		

	}
	}
	

	
   
	      
}
	

