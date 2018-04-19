using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Mover hacia adelante 
		this.transform.Translate(0.0f, 0.0f, 0.7f);
	}
	void OnCollisionEnter(Collision collision)  { 

		//Cargamos el prefab de la explosion 
		GameObject explosion = GameObject.Instantiate (
			Resources.Load ("Prefabs/Explosion") as GameObject); 

		//Muevo la explosion hacia la nave que fue impactada
		explosion.transform.position = collision.collider.gameObject.transform.position;

		//(gameobject con TAG MarsAlien)
		if (collision.collider.gameObject.tag == "MarsAlien") { //Los {} Son importsntes porque la instruccion IF necesita saber qué tiene que hacer. 
			                                                //Lo que esta adentro de los corchetes será lo  que hará la instruccion. 
		
			//Destruimos el objeto impactado por el misil 
			Destroy (collision.collider.gameObject);

			//Destruimos el misil
			Destroy (this.gameObject);
	

		
}
		//(gameobject con TAG MarsAlien)
		if (collision.collider.gameObject.tag == "JupiterAlien") { //Los {} Son importsntes porque la instruccion IF necesita saber qué tiene que hacer. 
			//Lo que esta adentro de los corchetes será lo  que hará la instruccion. 

			//Destruimos el objeto impactado por el misil 
			Destroy (collision.collider.gameObject);

			//Destruimos el misil
			Destroy (this.gameObject);

	}
}
}