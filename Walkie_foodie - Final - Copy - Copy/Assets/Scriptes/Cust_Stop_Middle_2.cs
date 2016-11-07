using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Cust_Stop_Middle_2 : MonoBehaviour {

	public List<int> ObjRand = new List<int>{1,2,3,4,5};
	public int nu;
	public Text want;
	public Text time_sp;
	string ObjItem;
	public float time_dec;
	public int time_dec_f;
	public bool time_stp;
	public int decider;
	public Text count;
	public Text insult;
	public string pointer;

	public static Cust_Stop_Middle_2 inst_CustMiddle_2;

	void Awake()
	{
		inst_CustMiddle_2 = this;
	}


	void Start()
	{
		time_stp = false;
		time_dec = 10;
	}

	void Update()
	{
		if (time_stp == true) 
		{
			time_dec -= Time.deltaTime;
			time_dec_f = Mathf.RoundToInt (time_dec);
			time_sp.text = "Time : " + time_dec_f;

			if (time_dec <= 0) 
			{
				time_stp = false;
				Custm.inst_Custm.speed_1 = 3f;

				Cust_Stop_End.inst_end.count -= 3;

				count.text = "Points : " + Cust_Stop_End.inst_end.count;

				pointer = "NO";

				insult.text = "You are useless, I'm going";
			}
		}
	}


	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Cust_1") 
		{
			decider = Decider_Place.inst_decider.nu;
			Custm.inst_Custm.speed_1 = 0f;
			time_stp = true;

			nu = Random.Range (0, ObjRand.Count);
			if (nu == 0) 
			{
				ObjItem = "Asteroid";
			} 
			else if (nu == 1) 
			{
				ObjItem = "Ball";
			}
			else if (nu == 2) 
			{
				ObjItem = "Bomb";
			} 
			else if (nu == 3) 
			{
				ObjItem = "Bowling Ball";
			} 
			else if (nu == 4) 
			{
				ObjItem = "Coin";
			}

			want.text = "I want " + ObjItem;
		}
	}
}
