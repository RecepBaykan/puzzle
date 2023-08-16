using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sure : MonoBehaviour
{
    // Start is called before the first frame update
   public static float zaman = oyunBilgiler.Sure;
    private void Start()
    {
        GameObject.Find("sure").GetComponent<TextMeshProUGUI>().text = oyunBilgiler.Sure.ToString();
    }
    private void Update()
    {
        kalanZaman();
    }



   void kalanZaman()
    {
        if (!durdur.sureyiDurdur)
        {
            if (dusenParcalar.sureBaslat && !kontrol.Kazandin)
            {
                zaman -= Time.deltaTime;
                GameObject.Find("sure").GetComponent<TextMeshProUGUI>().text = ((int)(zaman)).ToString();
            }
        }
       
       
    }
}
