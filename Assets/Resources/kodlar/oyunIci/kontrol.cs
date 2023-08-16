using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public static altinBilgisi  a = new altinBilgisi();
    public static int tempAltin;
  
    public static bool Kazandin;
    // Start is called before the first frame update
    void Start()
    {
        Kazandin = false;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        kontrolEt();
    }

    void kontrolEt()
    {
     
        int i = 0;
        foreach (GameObject kutu in GameObject.FindGameObjectsWithTag("kutu"))
        {
            foreach (GameObject parca in GameObject.FindGameObjectsWithTag("parca"))
            {
                if (parca.name == kutu.name && parca.transform.position == kutu.transform.position)
                {
                    i++;
                   
                }
            }
        }

        if (i == GameObject.FindGameObjectsWithTag("kutu").Length)
        {
            sonucEkrani.kazandinParayi = false;
        }
        if (i == GameObject.FindGameObjectsWithTag("kutu").Length && !Kazandin)
        {

         
            a.altin = kaydetAltin.yukle().altin;
            tempAltin = a.altin;
            
            if(kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)]== 3)
            {

             
            }
            if (kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)] == 2)
            {
                if (sure.zaman >= 60)
                {
                    a.altin += 1;
                }
            }
            if (kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)] == 1)
            {

                if (sure.zaman >= 60)
                {
                    a.altin += 1;
                }

                if (sure.zaman >= 30)
                {
                    a.altin += 1;
                }
            }
            if (kaydet.yukle().seviye[int.Parse(butonBilgileri.resim)] == 0)
            {
                if (int.Parse(butonBilgileri.resim) < 24)
                {
                    a.altin += (int)(resimIsimleri.resim.Length / 24);
                }
                else
                {
                    a.altin += (int)(resimIsimleri.resim.Length / 24 + int.Parse(butonBilgileri.resim) / 2);

                }
                
                if (sure.zaman >= 60)
                {
                   
                    a.altin += 1;
                }

                if (sure.zaman >= 30)
                {
                    a.altin += 1;
                }
              

                if (sure.zaman <= 30)
                {
                    a.altin += 1;
                }
            }

            
            Kazandin = true;
            parent.SetActive(false);

            cerceve.SetActive(false);



        }


    }

    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject cerceve;
}
