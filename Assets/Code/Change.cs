using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Change : MonoBehaviour {

	public GameObject fox, trump;
	int v = 1;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public void ChangeP(){
		v = v==0 ? 1 : 0;
		//fox.active = v==0 ? false : true;
		//trump.active = v==0 ? true : false;
		fox.SetActive(v==0 ? false : true);
		trump.SetActive(v==0 ? true : false);
	}
}
