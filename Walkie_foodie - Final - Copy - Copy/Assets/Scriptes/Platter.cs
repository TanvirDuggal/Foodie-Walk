using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Platter : MonoBehaviour {

	public int numm;
	public int numm_2;
	public int numm_3;

	public Text txtCh_1;
	public Text txtCh_2;
	public Text txtCh_3;

	public Text points;
	public LayerMask ll;
	float dis = 10;
	public string tag;
	public string tras;
	public GameObject ObjDrag;
	public static Platter ints_platt;
	public bool Plater;
	public string ch;
	public GameObject ob1;
	public GameObject ob2;
	public GameObject ob3;
	void Awake()
	{
		ints_platt = this;
		Plater = false;
	}

	void Start () 
	{
	
	}

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			numm = Cust_Stop_Middle_2.inst_CustMiddle_2.nu;
			numm_2 = Cust_Stop_Middle.inst_CustMiddle.nu;
			numm_3 = Cust_Stop_Middle_3.inst_custMiddle_3.nu;

				if(Physics.Raycast(ray,out hit,100f,ll.value))
				{
					tras = hit.transform.name;
				}

				if (Physics.Raycast (ray, out hit,100f,ll.value)&& hit.transform.tag == "Asteroid_Pl") 
				{
					tag = "Asteroid_Pl";
					Obj_Pick.inst_Pkp.counter_click++;
				} 
				
				else if (Physics.Raycast (ray, out hit,100f,ll.value) && hit.transform.tag == "Ball_Pl") 
				{
					tag = "Ball_Pl";
					Obj_Pick.inst_Pkp.counter_click++;	
				} 

				else if (Physics.Raycast (ray, out hit,100f,ll.value) && hit.transform.tag == "Bomb_Pl") 
				{
					tag = "Bomb_Pl";
					Obj_Pick.inst_Pkp.counter_click++;
				} 
				
				else if (Physics.Raycast (ray, out hit,100f,ll.value) && hit.transform.tag == "Bowling Ball_Pl") 
				{
					tag = "Bowling Ball_Pl";
				} 
				else if (Physics.Raycast (ray, out hit,100f,ll.value) && hit.transform.tag == "Coin_Pl") 
				{
					tag = "Coin_Pl";
					Obj_Pick.inst_Pkp.counter_click++;
				} 
			Char_Choice ();
		}
	}

	public void Char_Choice()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Cust_1") 
			{
				if (numm == 0) 
				{
					
					if (tag != "Asteroid_Pl") 
					{
						txtCh_2.text = "No, I want Asteroid";
						ch = "No";
					} 
					else 
					{
						txtCh_2.text = "Thx, for Asteroid";
						Custm.inst_Custm.speed_1 = 3f;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm == 1 ) 
				{
					
					if (tag != "Ball_Pl") 
					{
						txtCh_2.text = "No, I want Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_2.text = "Thx, for Ball";
						Custm.inst_Custm.speed_1 = 3f;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm == 2 ) 
				{
					
					if (tag != "Bomb_Pl") 
					{
						txtCh_2.text = "No, I want Bomb";
						ch = "No";
					} 
					else 
					{
						txtCh_2.text = "Thx, for Bomb";
						Custm.inst_Custm.speed_1= 3f;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm == 3 ) 
				{
					
					if (tag != "Bowling Ball_Pl") 
					{
						txtCh_2.text = "No, I want Bowling Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_2.text = "Thx, for Bowling Ball";
						Custm.inst_Custm.speed_1 = 3f;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm == 4) 
				{
					
					if (tag != "Coin_Pl") 
					{
						txtCh_2.text = "No, I want Coin";
						ch = "No";
					} 
					else 
					{
						txtCh_2.text = "Thx, for Coin";
						Custm.inst_Custm.speed_1 = 3f;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_dec = 10;
						Cust_Stop_Middle_2.inst_CustMiddle_2.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				Obj_Pick.inst_Pkp.counter_click = 0;

				ob1.GetComponent<Platter> ().enabled = true;
				ob2.GetComponent<Platter> ().enabled = true;
				ob3.GetComponent<Platter> ().enabled = true;

				if (ch == "No") 
				{
					ob1.GetComponent<SphereCollider> ().radius = 0.5f;
					ob2.GetComponent<SphereCollider> ().radius = 0.5f;
					ob3.GetComponent<SphereCollider> ().radius = 0.5f;
					ch = "";
				} 
				else 
				{
					if (tras == "Plate_1_GO") 
					{
						ob1.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_2_GO")
					{
						ob2.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_3_GO")
					{
						ob3.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					ch = "";
				}
			}









			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Cust_2") 
			{
				if (numm_3 == 0) 
				{

					if (tag != "Asteroid_Pl") 
					{
						txtCh_3.text = "No, I want Asteroid";
						ch = "No";
					} 
					else 
					{
						txtCh_3.text = "Thx, for Asteroid";
						Custm.inst_Custm.speed_2 = 3f;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_3 == 1 ) 
				{

					if (tag != "Ball_Pl") 
					{
						txtCh_3.text = "No, I want Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_3.text = "Thx, for Ball";
						Custm.inst_Custm.speed_2 = 3f;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_3 == 2 ) 
				{

					if (tag != "Bomb_Pl") 
					{
						txtCh_3.text = "No, I want Bomb";
						ch = "No";
					} 
					else 
					{
						txtCh_3.text = "Thx, for Bomb";
						Custm.inst_Custm.speed_2 = 3f;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_3 == 3 ) 
				{

					if (tag != "Bowling Ball_Pl") 
					{
						txtCh_3.text = "No, I want Bowling Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_3.text = "Thx, for Bowling Ball";
						Custm.inst_Custm.speed_2 = 3f;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_3 == 4) 
				{

					if (tag != "Coin_Pl") 
					{
						txtCh_3.text = "No, I want Coin";
						ch = "No";
					} 
					else 
					{
						txtCh_3.text = "Thx, for Coin";
						Custm.inst_Custm.speed_2 = 3f;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_dec = 10;
						Cust_Stop_Middle_3.inst_custMiddle_3.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				Obj_Pick.inst_Pkp.counter_click = 0;

				ob1.GetComponent<Platter> ().enabled = true;
				ob2.GetComponent<Platter> ().enabled = true;
				ob3.GetComponent<Platter> ().enabled = true;

				if (ch == "No") 
				{
					ob1.GetComponent<SphereCollider> ().radius = 0.5f;
					ob2.GetComponent<SphereCollider> ().radius = 0.5f;
					ob3.GetComponent<SphereCollider> ().radius = 0.5f;
					ch = "";
				} 
				else 
				{
					if (tras == "Plate_1_GO") 
					{
						ob1.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_2_GO")
					{
						ob2.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_3_GO")
					{
						ob3.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					ch = "";
				}
			}














			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Cust_3") 
			{
				if (numm_2 == 0) 
				{

					if (tag != "Asteroid_Pl") 
					{
						txtCh_1.text = "No, I want Asteroid";
						ch = "No";
					} 
					else 
					{
						txtCh_1.text = "Thx, for Asteroid";
						Custm.inst_Custm.speed_3 = 3f;
						Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;
						Cust_Stop_Middle.inst_CustMiddle.time_stp = false;
						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_2 == 1 ) 
				{

					if (tag != "Ball_Pl") 
					{
						txtCh_1.text = "No, I want Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_1.text = "Thx, for Ball";
						Custm.inst_Custm.speed_3 = 3f;
						Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;
						Cust_Stop_Middle.inst_CustMiddle.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_2 == 2 ) 
				{

					if (tag != "Bomb_Pl") 
					{
						txtCh_1.text = "No, I want Bomb";
						ch = "No";
					} 
					else 
					{
						txtCh_1.text = "Thx, for Bomb";
						Custm.inst_Custm.speed_3 = 3f;
						Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;
						Cust_Stop_Middle.inst_CustMiddle.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_2 == 3 ) 
				{

					if (tag != "Bowling Ball_Pl") 
					{
						txtCh_1.text = "No, I want Bowling Ball";
						ch = "No";
					} 
					else 
					{
						txtCh_1.text = "Thx, for Bowling Ball";
						Custm.inst_Custm.speed_3 = 3f;
						Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;
						Cust_Stop_Middle.inst_CustMiddle.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				if (numm_2 == 4) 
				{

					if (tag != "Coin_Pl") 
					{
						txtCh_1.text = "No, I want Coin";
						ch = "No";
					} 
					else 
					{
						txtCh_1.text = "Thx, for Coin";
						Custm.inst_Custm.speed_3 = 3f;
						Cust_Stop_Middle.inst_CustMiddle.time_dec = 10;
						Cust_Stop_Middle.inst_CustMiddle.time_stp = false;

						if (tras == "Plate_1_GO") 
						{
							Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_2_GO")
						{
							Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
						else if(tras == "Plate_3_GO")
						{
							Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
							Obj_Pick.inst_Pkp.PlaterName = "";
							tag = "";
						}
					}
				}

				Obj_Pick.inst_Pkp.counter_click = 0;

				ob1.GetComponent<Platter> ().enabled = true;
				ob2.GetComponent<Platter> ().enabled = true;
				ob3.GetComponent<Platter> ().enabled = true;

				if (ch == "No") 
				{
					ob1.GetComponent<SphereCollider> ().radius = 0.5f;
					ob2.GetComponent<SphereCollider> ().radius = 0.5f;
					ob3.GetComponent<SphereCollider> ().radius = 0.5f;
					ch = "";
				} 
				else 
				{
					if (tras == "Plate_1_GO") 
					{
						ob1.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_2_GO")
					{
						ob2.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					else if(tras == "Plate_3_GO")
					{
						ob3.GetComponent<SphereCollider> ().radius = 0.01f;
					}
					ch = "";
				}
			}




			else if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Trash") 
			{
				if (tras == "Plate_1_GO") 
				{
					
					ob2.GetComponent<Platter> ().enabled = false;
					ob3.GetComponent<Platter> ().enabled = false;

					Obj_Pick.inst_Pkp.Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
					Obj_Pick.inst_Pkp.Plater_1_GM.tag="none";
					Obj_Pick.inst_Pkp.PlaterName = "";
					tag = "";
					ob1.GetComponent<SphereCollider> ().radius = 0.01f;

					Cust_Stop_End.inst_end.count -= 2;
					points.text = "Points " + Cust_Stop_End.inst_end.count;
					 
				}
				else if(tras == "Plate_2_GO")
				{

					ob1.GetComponent<Platter> ().enabled = false;
					ob3.GetComponent<Platter> ().enabled = false;

					Obj_Pick.inst_Pkp.Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
					Obj_Pick.inst_Pkp.Plater_2_GM.tag="none";
					Obj_Pick.inst_Pkp.PlaterName = "";
					tag = "";
					ob2.GetComponent<SphereCollider> ().radius = 0.01f;

					Cust_Stop_End.inst_end.count -= 2;
					points.text = "Points " + Cust_Stop_End.inst_end.count;
				}
				else if(tras == "Plate_3_GO")
				{
					ob1.GetComponent<Platter> ().enabled = false;
					ob2.GetComponent<Platter> ().enabled = false;

					Obj_Pick.inst_Pkp.Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> (null);
					Obj_Pick.inst_Pkp.Plater_3_GM.tag="none";
					Obj_Pick.inst_Pkp.PlaterName = "";
					tag = "";
					ob3.GetComponent<SphereCollider> ().radius = 0.01f;

					Cust_Stop_End.inst_end.count -= 2;
					points.text = "Points " + Cust_Stop_End.inst_end.count;
				}

				ob1.GetComponent<Platter> ().enabled = true;
				ob2.GetComponent<Platter> ().enabled = true;
				ob3.GetComponent<Platter> ().enabled = true;

				if (Cust_Stop_End.inst_end.count < 0) 
				{
					Cust_Stop_End.inst_end.count = 0;
					points.text = "Points " + Cust_Stop_End.inst_end.count;
				}

			}
		}
	}
}
