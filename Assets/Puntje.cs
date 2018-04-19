using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntje : MonoBehaviour {
    public int puntje;
    public Text puntjeText;
	// Use this for initialization
	void Start () {
        puntje = 0;		
	}

    public void addPuntje()
    {
        puntje++;
        puntjeText.text = "Puntje: " + puntje.ToString();
    }

}
