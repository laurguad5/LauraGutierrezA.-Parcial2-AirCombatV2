﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Mover el avion
		if(Input.GetKey(KeyCode.UpArrow)) {  //continuo
			this.transform.Translate (0.0f, 0.5f, 0.0f);
		}
		if(Input.GetKey(KeyCode.DownArrow)) {  //continuo
			this.transform.Translate (0.0f, -0.5f, 0.0f);
		}
		if(Input.GetKey(KeyCode.RightArrow)) {  //continuo
			this.transform.Translate (0.5f, 0.0f, 0.0f);
		}
		if(Input.GetKey(KeyCode.LeftArrow)) {  //continuo
			this.transform.Translate (-0.5f, 0.0f, 0.0f);
		}

		//Si el usuario presioan la tecla espacio
		if (Input.GetKeyDown (KeyCode.Space)) { //one shot (una vez) 

			//Creo un game object a partir de la informacion gurdada 
			//en un prefab
		
			GameObject missile = GameObject.Instantiate (
				                   Resources.Load ("Prefabs/Missile") as GameObject); 
			
			//Hago que el misil sea hijo del aviion y se salgan de ahi)
			missile.transform.SetParent(this.transform);

			//Muevo el misil a la posicion (x,y,z debajo del ala)
			missile.transform.localPosition = new Vector3 (0, 0, 0);

			//Saco al misil del avion 
			missile.transform.SetParent (null);
		}
	}
}
