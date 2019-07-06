using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKazanma : MonoBehaviour {
    public int oyunSkorUstLimit = 3;

	void Update () {
        if (GameObject.Find("skor1").GetComponent<Oyuncu1Skor>().skor1 >= oyunSkorUstLimit)
        {
            GameObject.Find("birinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = true;
        }
        if (GameObject.Find("skor2").GetComponent<Oyuncu2Skor>().skor2 >= oyunSkorUstLimit)
        {
            GameObject.Find("ikinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
