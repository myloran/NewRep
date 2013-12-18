using UnityEngine;
using System.Collections;

public class GenerationBlock : MonoBehaviour {
	private int n;
	public GameObject Block,Block1,Block2,Block3;
	public int a,b;
	public float x,y,z,x1,y1,z1,x2,y2,z2,x3,y3,z3;

	void OnTriggerEnter (Collider other) {
		n = Random.Range(a, b);
		if(n==0) 
		{
		Instantiate(Block, new Vector3(x,y,transform.position.z +z),Quaternion.identity);	
		}
		if(n==1) 
		{
		Instantiate(Block1, new Vector3(x1,y1,transform.position.z +z1), Quaternion.identity);	
		}
		if(n==2) 
		{
		Instantiate(Block2, new Vector3(x2,y2,transform.position.z +z2), Quaternion.identity);	
		}
		if(n==3) 
		{
		Instantiate(Block3, new Vector3(x3,y3,transform.position.z +z3), Quaternion.identity);	
		}	
	}  
	 
}
