using UnityEngine;
using System.Collections;

public class Twist_Joints : MonoBehaviour {

	protected float fDistance = 1;
    protected float fSpeed = 1;
    public GameObject Tower;
	public GameObject rightfoot;
	public GameObject leftfoot;
	public GameObject rightleg;
	public GameObject leftleg;
	public GameObject rightarm;
	public GameObject leftarm;
	public GameObject righthand;
	public GameObject lefthand;
	public GameObject hip;
	public GameObject neck;
	public GameObject rightshoulder;
	public GameObject leftshoulder;
	public GameObject hipright;
	public GameObject hipleft;
	
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
	
	void OnGUI()
	{
		string[] selectionStrings = {"Right Foot", "Left Foot", "Right Leg", "Left Leg", "Right Arm", "Left Arm", "Center","Neck" , "Right Shoulder", "Left Shoulder", "Hip Right", "Hip Left"};
		
		if(HUD.visible){
		if(selectionGridInt == 0){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			rightfoot.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			rightfoot.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			rightfoot.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			rightfoot.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			rightfoot.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			rightfoot.transform.Rotate(0,0,-1);
		}
		}
		
		else if(selectionGridInt == 1){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			leftfoot.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			leftfoot.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			leftfoot.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			leftfoot.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			leftfoot.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			leftfoot.transform.Rotate(0,0,-1);
		}
		}
		
		else if(selectionGridInt == 2){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			rightleg.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			rightleg.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			rightleg.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			rightleg.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			rightleg.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			rightleg.transform.Rotate(0,0,-1);
		}
		}
		
		
		else if(selectionGridInt == 3){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			leftleg.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			leftleg.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			leftleg.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			leftleg.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			leftleg.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			leftleg.transform.Rotate(0,0,-1);
		}
		}
		
		else if(selectionGridInt == 4){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			rightarm.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			rightarm.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			rightarm.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			rightarm.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			rightarm.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			rightarm.transform.Rotate(0,0,-1);
		}
		}
		
			else if(selectionGridInt == 5){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			leftarm.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			leftarm.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			leftarm.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			leftarm.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			leftarm.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			leftarm.transform.Rotate(0,0,-1);
		}
		}
		
			else if(selectionGridInt == 6){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			hip.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			hip.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			hip.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			hip.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			hip.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			hip.transform.Rotate(0,0,-1);
		}
		}
		
			else if(selectionGridInt == 7){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			neck.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			neck.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			neck.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			neck.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			neck.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			neck.transform.Rotate(0,0,-1);
		}
		}
		
			else if(selectionGridInt == 8){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			rightshoulder.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			rightshoulder.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			rightshoulder.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			rightshoulder.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			rightshoulder.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			rightshoulder.transform.Rotate(0,0,-1);
		}
		}
		
			else if(selectionGridInt == 9){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			leftshoulder.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			leftshoulder.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			leftshoulder.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			leftshoulder.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			leftshoulder.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			leftshoulder.transform.Rotate(0,0,-1);
		}
		}
		
		else if(selectionGridInt == 10){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			hipright.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			hipright.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			hipright.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			hipright.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			hipright.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			hipright.transform.Rotate(0,0,-1);
		}
		}
		
		else if(selectionGridInt == 11){
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 250, 70, 50), "UP"))
		{
			hipleft.transform.Rotate(1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 250, 70, 50), "UP"))
		{
			hipleft.transform.Rotate(0,1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 250, 70, 50), "UP"))
		{
			hipleft.transform.Rotate(0,0,1);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 280, 350, 70, 50), "DOWN"))
		{
			hipleft.transform.Rotate(-1,0,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 180, 350, 70, 50), "DOWN"))
		{
			hipleft.transform.Rotate(0,-1,0);
		}
		if(GUI.RepeatButton (new Rect (Screen.width - 80, 350, 70, 50), "DOWN"))
		{
			hipleft.transform.Rotate(0,0,-1);
		}
		}
		
		selectionGridInt = GUI.SelectionGrid (new Rect (Screen.width - 300, 50 , 300, 150), selectionGridInt, selectionStrings, 2);
		
		}
	}
	
	
	
   
	      
}
	

