using UnityEngine;
using System.Collections;

public class Torch : MonoBehaviour {

    private Light _light;

	// Use this for initialization
	void Start () {
        _light = GetComponentInChildren<Light>();

        _light.enabled = false;

        
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp(KeyCode.T))
        {
            _light.enabled = !_light.enabled;
            
        }
	}
}
