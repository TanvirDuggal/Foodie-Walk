using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Decider_Place : MonoBehaviour {

	public List<int> Decider = new List<int>{1,2,3};
	public int nu;

	public static Decider_Place inst_decider;

	void Awake()
	{
		inst_decider = this;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Cust") 
		{
			nu = Random.Range (0, Decider.Count);
		}
	}
}
