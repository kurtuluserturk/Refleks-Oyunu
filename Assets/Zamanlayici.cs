using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zamanlayici : MonoBehaviour {
    public float ilkBekleme = 3.0f;
    public float ikinciBekleme;
    public float toplamBekleme;
    public float oyunIcindeGecenSure;
    public float baslangicZamani = 0;
    public bool oyunBasladi = false;
		
	void Update () {
        oyunIcindeGecenSure = Time.time;
        if (oyunBasladi)
        {
            if ((oyunIcindeGecenSure - baslangicZamani) > toplamBekleme)
            {
                print("butona bas");
                GameObject.Find("yesilKutu").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("Simdi").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("kirmiziKutu").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Bekle").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Scriptler").GetComponent<Klavye_kontrolleri>().tumButonlarBasilabilir = true;
            }
        }
    }
    public void zamanBelirle()
    {
        ikinciBekleme = Random.Range(3.0f, 10.0f);
        toplamBekleme = (ilkBekleme + ikinciBekleme);
    }
}
