using UnityEngine;
using System.Collections;

public class SandStorm : MonoBehaviour {

    private bool toggleBool = true;

	public void ChangeStormColor (Color color)
    {
       foreach (Transform child in transform)
        {
            if(child.gameObject.GetComponent<ParticleSystem>() != null) { 
                var alpaNewColor = new Color(color.r/5, color.g/5, color.b/5, .1f);
                child.gameObject.GetComponent<ParticleSystem>().startColor = alpaNewColor;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            toggleBool = !toggleBool;

            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(toggleBool);
            }
        }
    }
}
