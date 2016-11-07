using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Cust_Stop_End : MonoBehaviour {

	public int count;
	public Text CountTxt;

	public Text wantt_1;
	public Text wantt_2;
	public Text wantt_3;

	public GameObject objDes;
	public GameObject ObjMove;

	public static Cust_Stop_End inst_end;

	public string level;

	public string MoveOn;

	public int rn;
	void Awake()
	{
		inst_end = this;
	}

	void Start () 
	{
		
	}

	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		level = PlayerPrefs.GetString ("Level");

		if (level == "Easy") 
		{
			if (col.gameObject.tag == "Cust_1") 
			{
				if (Cust_Stop_Middle_2.inst_CustMiddle_2.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_1;
				ObjMove = Custm.inst_Custm.ObjParent_1;
				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				Custm.inst_Custm.Char_random ();
				//Custm.inst_Custm.Start_Tran_1 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_2.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;

				Cust_Stop_Middle_2.inst_CustMiddle_2.pointer = "";

			}


			if (col.gameObject.tag == "Cust_2") 
			{

				if (Cust_Stop_Middle_3.inst_custMiddle_3.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_2;
				ObjMove = Custm.inst_Custm.ObjParent_2;
				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				Custm.inst_Custm.Char_random ();
				//Custm.inst_Custm.Start_Tran_2 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_3.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;

				Cust_Stop_Middle_3.inst_custMiddle_3.pointer = "";

			}

			if (col.gameObject.tag == "Cust_3") 
			{
				if (Cust_Stop_Middle.inst_CustMiddle.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_3;
				ObjMove = Custm.inst_Custm.ObjParent_3;

				Destroy (objDes);

				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				Custm.inst_Custm.level_1 = 0;
				Custm.inst_Custm.Char_random ();
				//Custm.inst_Custm.Start_Tran_3 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_1.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;

				Cust_Stop_Middle.inst_CustMiddle.pointer = "";
			}


		}
		else if(level == "Medium")
		{
			Debug.Log ("+++++++++++++++++++++  " + Custm.inst_Custm.MoveOn_1);
			Debug.Log ("+++++++++++++++++++++  " + Custm.inst_Custm.MoveOn_2);
			Debug.Log ("+++++++++++++++++++++  " + Custm.inst_Custm.MoveOn_3);

			if (col.gameObject.tag == "Cust_1") 
			{
				
				
				if (Cust_Stop_Middle_2.inst_CustMiddle_2.pointer != "NO") 
				{
					count += 5;
				} 

				rn = Random.Range (0, 2);
				objDes = Custm.inst_Custm.ObjIns_1;
				Debug.Log ("Random ------------------>>>>>>>>>>>" + rn);


				if (Custm.inst_Custm.MoveOn_2 == null) 
				{
					print ("3 ON MOVE");

					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_2;
						Custm.inst_Custm.Start_Tran_2 ();

					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_1;
						Custm.inst_Custm.Start_Tran_1 ();
					}

				} 
				else 
				{
					print ("2 ON MOVE");

					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_3;
						Custm.inst_Custm.Start_Tran_3 ();
					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_1;
						Custm.inst_Custm.Start_Tran_1 ();
					}

				}
				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_2.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;

				Cust_Stop_Middle_2.inst_CustMiddle_2.pointer = "";

			}


			if (col.gameObject.tag == "Cust_2") 
			{



				if (Cust_Stop_Middle_3.inst_custMiddle_3.pointer != "NO") 
				{
					count += 5;
				} 
					
				rn = Random.Range (0, 2);
				objDes = Custm.inst_Custm.ObjIns_2;
				Debug.Log ("Random ------------------>>>>>>>>>>>" + rn);


				if (Custm.inst_Custm.MoveOn_3 == null) 
				{
					print ("1 ON MOVE");
			
					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_3;
						Custm.inst_Custm.Start_Tran_3 ();
					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_2;
						Custm.inst_Custm.Start_Tran_2 ();
					}
				} 
				else 
				{
					print ("3 ON MOVE");

					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_1;
						Custm.inst_Custm.Start_Tran_1 ();
					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_2;
						Custm.inst_Custm.Start_Tran_2 ();
					}

				}
					

				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				//Custm.inst_Custm.Char_random ();
				//Custm.inst_Custm.Start_Tran_2 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_3.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;

				Cust_Stop_Middle_3.inst_custMiddle_3.pointer = "";

			}

			if (col.gameObject.tag == "Cust_3") 
			{



				if (Cust_Stop_Middle.inst_CustMiddle.pointer != "NO") 
				{
					count += 5;
				} 
					
				rn = Random.Range (0,2);
				objDes = Custm.inst_Custm.ObjIns_3;

				Debug.Log ("Random ------------------>>>>>>>>>>>" + rn);

				if (Custm.inst_Custm.MoveOn_2 == null) 
				{
					print ("1 ON MOVE");

					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_3;
						Custm.inst_Custm.Start_Tran_3 ();
					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_2;
						Custm.inst_Custm.Start_Tran_2 ();

					}
				} 
				else 
				{
					print ("2 ON MOVE");

					if (rn == 0) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_3;
						Custm.inst_Custm.Start_Tran_3 ();
					}
					else if(rn == 1) 
					{
						ObjMove = Custm.inst_Custm.ObjParent_1;
						Custm.inst_Custm.Start_Tran_1 ();
					}
				}
					

				Destroy (objDes);

				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				Custm.inst_Custm.level_1 = 0;
				//Custm.inst_Custm.Char_random ();
				//Custm.inst_Custm.Start_Tran_3 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_1.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;

				Cust_Stop_Middle.inst_CustMiddle.pointer = "";
			}

			//Custm.inst_Custm.MoveOn_1 = null;
			//Custm.inst_Custm.MoveOn_2 = null;
			//Custm.inst_Custm.MoveOn_3 = null;
		}

		else if(level == "Hard")
		{
			if (col.gameObject.tag == "Cust_1") 
			{
				if (Cust_Stop_Middle_2.inst_CustMiddle_2.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_1;
				ObjMove = Custm.inst_Custm.ObjParent_1;
				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				//Custm.inst_Custm.Char_random ();
				Custm.inst_Custm.Start_Tran_1 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_2.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;

				Cust_Stop_Middle_2.inst_CustMiddle_2.pointer = "";

			}


			if (col.gameObject.tag == "Cust_2") 
			{

				if (Cust_Stop_Middle_3.inst_custMiddle_3.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_2;
				ObjMove = Custm.inst_Custm.ObjParent_2;
				Destroy (objDes);
				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				//Custm.inst_Custm.Char_random ();
				Custm.inst_Custm.Start_Tran_2 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_3.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;

				Cust_Stop_Middle_3.inst_custMiddle_3.pointer = "";

			}

			if (col.gameObject.tag == "Cust_3") 
			{
				if (Cust_Stop_Middle.inst_CustMiddle.pointer != "NO") 
				{
					count += 5;
				} 

				objDes = Custm.inst_Custm.ObjIns_3;
				ObjMove = Custm.inst_Custm.ObjParent_3;

				Destroy (objDes);

				ObjMove.transform.position = new Vector3 (-13f,0.81f,0);
				Custm.inst_Custm.level_1 = 0;
				//Custm.inst_Custm.Char_random ();
				Custm.inst_Custm.Start_Tran_3 ();

				Obj_Pick.inst_Pkp.Plate = true;
				Obj_Pick.inst_Pkp.PlaterName = "";
				Obj_Pick.inst_Pkp.count = 0;

				wantt_1.text = "I want";

				CountTxt.text = "Points : " + count; 

				Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;

				Cust_Stop_Middle.inst_CustMiddle.pointer = "";
			}
		}
		

	}
}
