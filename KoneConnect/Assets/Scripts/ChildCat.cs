using UnityEngine;
using System.Collections;

public class ChildCat : MonoBehaviour {

	iTweenEvent ite ;

	bool isFall ;

	// Use this for initialization
	void Start () {
		ite = GetComponent<iTweenEvent> ();
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(!Physics.SphereCast(transform.position + new Vector3( 0.0f, 0.0f, 0.0f ),1.0f,new Vector3( 0.0f, -1.0f, 0.0f ),out hit, 10.0f)){
			//Destroy( gameObject ) ;
			ite.Stop() ;
			isFall = true ;

			Destroy( gameObject, 3.0f ) ;
		}

		if( isFall ) {
			transform.position -= new Vector3( 0.0f, 0.8f, 0.0f ) ;
			transform.Rotate( new Vector3( 0.0f, 20.0f, 0.0f ) ) ;
		}

	}
}
