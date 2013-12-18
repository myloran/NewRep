using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public GameObject mycar;
	public float Speed = 1;
	public float addSpeed = 0;
	public float SpeedMax = 0;
	public float SideSpeed = 0;
	public int MaxXLeft = -2;
	public int MaxXRight = 2;
	void Update () {
		Vector3 CarPos = mycar.transform.position;
		mycar.transform.Translate(0,0,1*Speed*Time.deltaTime);
		if( Speed <= SpeedMax)
		{
			Speed += addSpeed * Time.deltaTime;
		}
		if(Input.GetKeyDown(KeyCode.D) && CarPos.x <=MaxXRight)
		{
			CarPos.x += SideSpeed;
			mycar.transform.position = CarPos;
		}	
		if(Input.GetKeyDown(KeyCode.A) && CarPos.x >=MaxXLeft)
		{
			CarPos.x -= SideSpeed;
			mycar.transform.position = CarPos;
		}
	}
}
