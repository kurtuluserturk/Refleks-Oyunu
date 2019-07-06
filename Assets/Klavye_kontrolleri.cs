using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klavye_kontrolleri : MonoBehaviour {

    public bool oyuncu1Kazan = false;
    public bool oyuncu2Kazan = false;
    public bool tumButonlarBasilabilir = false;
        
    void Start () {
        GameObject.Find("yesilKutu").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Simdi").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("kirmiziKutu").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("Bekle").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("sariKutu").GetComponent<MeshRenderer>().enabled = true;
        GameObject.Find("Hazir").GetComponent<MeshRenderer>().enabled = true;
    }	
	
	void Update () {
        // 1.Oyuncu
        if (Input.GetKeyDown(KeyCode.Z) && (oyuncu2Kazan == false) && (oyuncu1Kazan == false) && (tumButonlarBasilabilir))
        {
            print("Z basıldı");
            GameObject.Find("skor1").GetComponent<Oyuncu1Skor>().skor1 += 1;
            GameObject.Find("skor1").GetComponent<Oyuncu1Skor>().Skor1Guncelle();
            GameObject.Find("birinciKazandi").GetComponent<MeshRenderer>().enabled = true;
            oyuncu1Kazan = true;            
        }
        // 2.Oyuncu
        if (Input.GetKeyDown(KeyCode.M) && (oyuncu1Kazan == false) && (oyuncu2Kazan == false) && (tumButonlarBasilabilir))
        {
            print("M basıldı");
            GameObject.Find("skor2").GetComponent<Oyuncu2Skor>().skor2 += 1;
            GameObject.Find("skor2").GetComponent<Oyuncu2Skor>().Skor2Guncelle();
            GameObject.Find("ikinciKazandi").GetComponent<MeshRenderer>().enabled = true;
            oyuncu2Kazan = true;            
        }
        // reset
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject.Find("skor1").GetComponent<Oyuncu1Skor>().skor1 = 0;
            GameObject.Find("skor1").GetComponent<Oyuncu1Skor>().Skor1Guncelle();
            GameObject.Find("skor2").GetComponent<Oyuncu2Skor>().skor2 = 0;
            GameObject.Find("skor2").GetComponent<Oyuncu2Skor>().Skor2Guncelle();
            GameObject.Find("sariKutu").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("Hazir").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("yesilKutu").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Simdi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("birinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("ikinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("birinciKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("ikinciKazandi").GetComponent<MeshRenderer>().enabled = false;
            oyuncu1Kazan = false;
            oyuncu2Kazan = false;
            GetComponent<Zamanlayici>().baslangicZamani = GetComponent<Zamanlayici>().oyunIcindeGecenSure;
            tumButonlarBasilabilir = false;
            print("R basıldı");
        }
        // oyunu başlat
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject.Find("yesilKutu").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Simdi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("kirmiziKutu").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("Bekle").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("sariKutu").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Hazir").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("birinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("ikinciOyunuKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("birinciKazandi").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("ikinciKazandi").GetComponent<MeshRenderer>().enabled = false;
            oyuncu1Kazan = false;
            oyuncu2Kazan = false;
            GetComponent<Zamanlayici>().ilkBekleme = 3.0f;
            GetComponent<Zamanlayici>().ikinciBekleme = 0.0f;
            GetComponent<Zamanlayici>().toplamBekleme = 0.0f;
            GetComponent<Zamanlayici>().zamanBelirle();
            GetComponent<Zamanlayici>().baslangicZamani = GetComponent<Zamanlayici>().oyunIcindeGecenSure;
            GetComponent<Zamanlayici>().oyunBasladi = true;
            tumButonlarBasilabilir = false;
            print("S basıldı");
        }
    }
}
