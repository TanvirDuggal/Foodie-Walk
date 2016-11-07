using UnityEngine;
using System.Collections;

public class Obj_Pick : MonoBehaviour {

	public string PlaterName;
	public GameObject Plater_1_GM;
	public GameObject Plater_2_GM;
	public GameObject Plater_3_GM;
	public int count;
	public int counter_click;
	int count_no;
	public bool Plate;
	public bool Plate_2;
	public string goo;
	public string goo_p1;
	public string goo_p2;
	public string goo_p3;
	public static Obj_Pick inst_Pkp;
	public string comp;
	void Awake()
	{
		inst_Pkp = this;
	}

	void Start () 
	{
		Plate = false;
	}

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Asteroid") 
			{
				PlaterName = "Asteroid";
				Plate = true;
				counter_click++;
			}

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Ball") 
			{
				PlaterName = "Ball";
				Plate = true;
				counter_click++;
			}

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Bomb") 
			{
				PlaterName = "Bomb";
				Plate = true;
				counter_click++;
			}

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Bowling Ball") 
			{
				PlaterName = "Bowling Ball";
				Plate = true;
				counter_click++;
			}

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Coin") 
			{
				PlaterName = "Coin";
				Plate = true;
				counter_click++;
			}
			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Trash") 
			{
			}

			if (Plate = true) 
			{
				PlaterChange ();
			}
		}
	}


	public void PlaterChange()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Plater_1_GM.GetComponent<SpriteRenderer> ().sprite ==  null) 
			{
				goo_p1 = "Yes";
			} 
			if (Plater_2_GM.GetComponent<SpriteRenderer> ().sprite == null) 
			{
				goo_p2 = "Yes";
			} 
			if (Plater_3_GM.GetComponent<SpriteRenderer> ().sprite == null) 
			{
				goo_p3 = "Yes";
			}
			else 
			{
				goo = "No";			
			}

			if (Plate == true && goo_p1 =="Yes") 
			{
				if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Plate_1") 
				{
					if (PlaterName == "Asteroid") 
					{
						Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("AsteroidSprite");
						Plater_1_GM.tag = "Asteroid_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Ball")
					{
						Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BallSprite");
						Plater_1_GM.tag = "Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bomb")
					{
						Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BombSprite");
						Plater_1_GM.tag = "Bomb_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bowling Ball")
					{
						Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BowlingBallSprite");
						Plater_1_GM.tag = "Bowling Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Coin")
					{
						Plater_1_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("CoinSprite");
						Plater_1_GM.tag = "Coin_Pl";
						count++;
						PlaterName = "";
					}
					Plate = false;
					goo_p1 = "";

					Platter.ints_platt.ob1.GetComponent<SphereCollider> ().radius = 0.5f;
				}
			}

			if (Plate == true && goo_p2 == "Yes") 
			{
				if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Plate_2") 
				{
					if (PlaterName == "Asteroid") 
					{
						Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("AsteroidSprite");
						Plater_2_GM.tag = "Asteroid_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Ball")
					{
						Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BallSprite");
						Plater_2_GM.tag = "Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bomb")
					{
						Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BombSprite");
						Plater_2_GM.tag = "Bomb_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bowling Ball")
					{
						Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BowlingBallSprite");
						Plater_2_GM.tag = "Bowling Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Coin")
					{
						Plater_2_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("CoinSprite");
						Plater_2_GM.tag = "Coin_Pl";
						count++;
						PlaterName = "";
					}

					Plate = false;	
					goo_p2 = "";
					Platter.ints_platt.ob2.GetComponent<SphereCollider> ().radius = 0.5f;
				}
			}

			if (Physics.Raycast (ray, out hit) && hit.transform.tag == "Plate_3") 
			{
				if (Plate == true && goo_p3 == "Yes") 
				{
					if (PlaterName == "Asteroid") 
					{
						Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("AsteroidSprite");
						Plater_3_GM.tag = "Asteroid_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Ball")
					{
						Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BallSprite");
						Plater_3_GM.tag = "Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bomb")
					{
						Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BombSprite");
						Plater_3_GM.tag = "Bomb_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Bowling Ball")
					{
						Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("BowlingBallSprite");
						Plater_3_GM.tag = "Bowling Ball_Pl";
						count++;
						PlaterName = "";
					}
					else if(PlaterName == "Coin")
					{
						Plater_3_GM.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("CoinSprite");
						Plater_3_GM.tag = "Coin_Pl";
						count++;
						PlaterName = "";
					}

					Plate = false;
					goo_p3 = "";
					Platter.ints_platt.ob3.GetComponent<SphereCollider> ().radius = 0.5f;
				}
			}
		}
	}
}
