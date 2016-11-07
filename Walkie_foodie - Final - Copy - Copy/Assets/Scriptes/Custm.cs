using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Custm : MonoBehaviour {

	public List<int> Cust_Rand = new List<int>{1,2,3};
	int num_1;
	int num_2;
	int num_3;

	public int level_1;
	public int level_2;

	public Text tx1;
	public Text tx2;
	public Text tx3;

	public GameObject ObjIns_1;
	public GameObject ObjIns_2;
	public GameObject ObjIns_3;

	public GameObject ObjParent_1;
	public GameObject ObjParent_2;
	public GameObject ObjParent_3;

	public bool walk_1;
	public bool walk_2;
	public bool walk_3;

	float xx;
	float yy;

	public float speed_1;
	public float speed_2;
	public float speed_3;

	public string level;

	public static Custm inst_Custm;

	public string MoveOn_1;
	public string MoveOn_2;
	public string MoveOn_3;

	void Awake()
	{
		inst_Custm = this;
	}
	void Start () 
	{
		level = PlayerPrefs.GetString ("Level");
		Char_random ();
	}

	public void Char_random()
	{
		if (level == "Easy") 
		{
			level_1 = Random.Range (0, Cust_Rand.Count);

			//Debug.Log (level_1);

			if (level_1 == 0) 
			{
				Start_Tran_1 ();
			}
			else if(level_1 == 1)
			{
				Start_Tran_2 ();
			}
			else if(level_1 == 2)
			{
				Start_Tran_3 ();
			}


			tx1.text = "";
			tx2.text = "";
			tx3.text = "";
		}

		if (level == "Hard") 
		{
			Start_Tran_1 ();
			Start_Tran_2 ();
			Start_Tran_3 ();
		}

		if (level == "Medium") 
		{
			level_2 = Random.Range (0, Cust_Rand.Count);
			Debug.Log (level_2);


			if (level_2 == 0) 
			{
				Start_Tran_1 ();
				Start_Tran_3 ();
			}
			else if(level_2 == 1)
			{
				Start_Tran_2 ();
				Start_Tran_3 ();
			}
			else if(level_2 == 2)
			{
				Start_Tran_3 ();
				Start_Tran_1 ();
			}

			tx1.text = "";
			tx2.text = "";
			tx3.text = "";
		}
	}

	void Update () 
	{

		if (walk_1 == true) 
		{
			ObjParent_1.transform.Translate (new Vector3 (xx * speed_1 * Time.deltaTime, yy * speed_1 * Time.deltaTime, 0));
		}else if (walk_1 == false) 
		{
			speed_1 = 0f;
		}


		if (walk_2 == true) 
		{
			ObjParent_2.transform.Translate (new Vector3 (xx * speed_2 * Time.deltaTime, yy * speed_2 * Time.deltaTime, 0));
		}else if (walk_2 == false) 
		{
			speed_2 = 0f;
		}


		if (walk_3 == true) 
		{
			ObjParent_3.transform.Translate (new Vector3 (xx * speed_3 * Time.deltaTime, yy * speed_3 * Time.deltaTime, 0));
		}else if (walk_3 == false) 
		{
			speed_3 = 0f;
		}
	}

	public void Start_Tran_1()
	{
		MoveOn_1 = null;
		Debug.Log (">>>>>>>>>>>>>>>>>>>>> " + MoveOn_1);
		num_1 = Random.Range (0, Cust_Rand.Count);

		if (num_1 == 0) 
		{
			ObjIns_1 = Instantiate (Resources.Load ("I1"), ObjParent_1.transform.position,Quaternion.identity) as GameObject;
			ObjIns_1.transform.parent = ObjParent_1.transform;
			ObjIns_1.SetActive (true);
			ObjIns_1.transform.tag = "Cust_1";
		} 
		else if (num_1 == 1) 
		{
			ObjIns_1 = Instantiate (Resources.Load ("I2"), ObjParent_1.transform.position,Quaternion.identity) as GameObject;
			ObjIns_1.transform.parent = ObjParent_1.transform;
			ObjIns_1.SetActive (true);
			ObjIns_1.transform.tag = "Cust_1";
		} 
		else if (num_1 == 2) 
		{
			ObjIns_1 = Instantiate (Resources.Load ("I3"), ObjParent_1.transform.position,Quaternion.identity) as GameObject;
			ObjIns_1.transform.parent = ObjParent_1.transform;
			ObjIns_1.SetActive (true);
			ObjIns_1.transform.tag = "Cust_1";
		}
			
		walk_1 = true;
		speed_1 = 3f;
		xx = 2.5f;

		MoveOn_1 = "Cust1";
	}

	public void Start_Tran_2()
	{
		MoveOn_2 = null;
		Debug.Log (">>>>>>>>>>>>>>>>>>>>> " + MoveOn_2);
		num_2 = Random.Range (0, Cust_Rand.Count);

		if (num_2 == 0) 
		{
			ObjIns_2 = Instantiate (Resources.Load ("I1"), ObjParent_2.transform.position,Quaternion.identity) as GameObject;
			ObjIns_2.transform.parent = ObjParent_2.transform;
			ObjIns_2.SetActive (true);
			ObjIns_2.transform.tag = "Cust_2";
		} 
		else if (num_2 == 1) 
		{
			ObjIns_2 = Instantiate (Resources.Load ("I2"), ObjParent_2.transform.position,Quaternion.identity) as GameObject;
			ObjIns_2.transform.parent = ObjParent_2.transform;
			ObjIns_2.SetActive (true);
			ObjIns_2.transform.tag = "Cust_2";
		} 
		else if (num_2 == 2) 
		{
			ObjIns_2 = Instantiate (Resources.Load ("I3"), ObjParent_2.transform.position,Quaternion.identity) as GameObject;
			ObjIns_2.transform.parent = ObjParent_2.transform;
			ObjIns_2.SetActive (true);
			ObjIns_2.transform.tag = "Cust_2";
		}

		walk_2 = true;
		speed_2 = 3f;
		xx = 2.5f;

		MoveOn_2 = "Cust2";
	}

	public void Start_Tran_3()
	{
		MoveOn_3 = null;
		Debug.Log (">>>>>>>>>>>>>>>>>>>>> " + MoveOn_3);
		num_3 = Random.Range (0, Cust_Rand.Count);

		if (num_3 == 0) 
		{
			ObjIns_3 = Instantiate (Resources.Load ("I1"), ObjParent_3.transform.position,Quaternion.identity) as GameObject;
			ObjIns_3.transform.parent = ObjParent_3.transform;
			ObjIns_3.SetActive (true);
			ObjIns_3.transform.tag = "Cust_3";
		} 
		else if (num_3 == 1) 
		{
			ObjIns_3 = Instantiate (Resources.Load ("I2"), ObjParent_3.transform.position,Quaternion.identity) as GameObject;
			ObjIns_3.transform.parent = ObjParent_3.transform;
			ObjIns_3.SetActive (true);
			ObjIns_3.transform.tag = "Cust_3";
		} 
		else if (num_3 == 2) 
		{
			ObjIns_3 = Instantiate (Resources.Load ("I3"), ObjParent_3.transform.position,Quaternion.identity) as GameObject;
			ObjIns_3.transform.parent = ObjParent_3.transform;
			ObjIns_3.SetActive (true);
			ObjIns_3.transform.tag = "Cust_3";
		}

		walk_3 = true;
		speed_3 = 3f;
		xx = 2.5f;

		MoveOn_3 = "Cust3";
	}


}