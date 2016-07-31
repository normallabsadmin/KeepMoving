using UnityEngine;
using System.Collections;

public class NightLight : MonoBehaviour {

    Light moonLight;

	// Use this for initialization
	void Start () {
        moonLight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
