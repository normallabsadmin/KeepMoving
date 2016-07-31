using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour {

    public float _timeScale = 60f;

	// Update is called once per frame
	void Update () {

        float angleThisFrame = Time.deltaTime / 360 * _timeScale;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);

    }
}
