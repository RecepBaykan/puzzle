using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesneHareketi : MonoBehaviour
{
    bool tiklandi;
    bool surukleniyor;
    bool surukle;
    bool parcaSinifi;
   public static RaycastHit2D ray;
    public static bool oldu;
    Vector3 gecici;
    Vector3 geciciBoyut;
    private int oneAl;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        
        if (!durdur.sureyiDurdur && !resmiGoster.goster)
        {
            
            if (!kontrol.Kazandin)
            {
                if (dusenParcalar.sureBaslat)
                {
                    //----T�kla----//
                    if (Input.GetMouseButtonDown(0) && !tiklandi)
                    {
                        Debug.Log("t�klad�n");

                        tiklandi = true;
                        surukleniyor = true;

                        ray = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
                        if (ray)
                        {
                            gecici = ray.collider.gameObject.transform.position;
                            geciciBoyut = ray.collider.gameObject.transform.localScale;
                            ray.collider.gameObject.transform.localScale = new Vector2(
                                ray.collider.gameObject.transform.localScale.x / 2,
                                ray.collider.gameObject.transform.localScale.y / 2);
                            foreach (var var in GameObject.FindGameObjectsWithTag("parca"))
                            {
                                var.GetComponent<SpriteRenderer>().sortingOrder = 2;
                                GameObject.Find("cerceve").GetComponent<SpriteRenderer>().sortingOrder = 3;
                            }

                        }


                    }


                    if (ray)
                    {
                        //---S�r�kle---//
                        if (Input.GetMouseButton(0) && surukleniyor)
                        {
                            objeHareketi(ray.collider.gameObject);

                        }
                        //----B�rak---//
                        if (Input.GetMouseButtonUp(0))
                        {


                          
                            surukleniyor = false;
                            tiklandi = false;
                            objeyiBirak();
                            surukle = true;
                            ray.collider.gameObject.transform.localScale = geciciBoyut;
                        }

                    }
                    else
                    {

                        surukleniyor = false;
                        tiklandi = false;
                    }

                }
              


             
            }

        }




    }

    //---T�klama metotlar�-----//
    void objeTespiti()
    {



    }


    //----S�r�kleme metotlar�---//
    void objeHareketi(GameObject parca)
    {
        if (parca == null)
        {
            Debug.Log("Bo� nesne");

        }
        else
        {
           
            ray.collider.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
            GameObject.Find("cerceve").GetComponent<SpriteRenderer>().sortingOrder = 4;
            Vector3 fareKonumu = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            fareKonumu.z = 0f;
            parca.transform.position = fareKonumu;
            


        }
    }


    //----B�rakma metotlar�---//

    void objeyiBirak()
    {

       
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("kutu").Length; i++)
        {
            if (Vector2.Distance(GameObject.FindGameObjectsWithTag("kutu")[i].transform.position,
                ray.collider.gameObject.transform.position) <= 
               sirala.enBoyKutu*1.4)
            {

                for (int j = 0; j < GameObject.FindGameObjectsWithTag("parca").Length; j++)
                {
                    if (GameObject.FindGameObjectsWithTag("kutu")[i].transform.position == GameObject.FindGameObjectsWithTag("parca")[j].transform.position)
                    {
                        GameObject.FindGameObjectsWithTag("parca")[j].transform.position = gecici;
                        ray.collider.gameObject.transform.position = GameObject.FindGameObjectsWithTag("kutu")[i].transform.position;
                        
                       

                    }
                    else
                    {

                        ray.collider.gameObject.transform.position = GameObject.FindGameObjectsWithTag("kutu")[i].transform.position;
                        
                    }
                }
            }
            else
            {
              
            }

            
         
          
        }
        int a = 0;
        for (int b = 0; b < GameObject.FindGameObjectsWithTag("kutu").Length; b++)
        {
            if (ray.collider.gameObject.transform.position != GameObject.FindGameObjectsWithTag("kutu")[b].transform.position)
            {
                a++;
            }
        }
        if (a == GameObject.FindGameObjectsWithTag("kutu").Length)
        {
            ray.collider.gameObject.transform.position = gecici;
        }

        /*Instantiate(ray.collider.gameObject).name = ray.collider.gameObject.name;
         for (int i = 0; i <= GameObject.FindGameObjectsWithTag("parca").Length; i++)
         {
             if (ray.collider.gameObject.name == GameObject.FindGameObjectsWithTag("parca")[i].name)
             {
                 Destroy(GameObject.FindGameObjectsWithTag("parca")[i]);
                 break;
             }
             else
             {

             }
         }*/
    }







    /* for(int i = 0; i < GameObject.FindGameObjectsWithTag("parca").Length; i++)
     {
         for(int j = 0; j < GameObject.FindGameObjectsWithTag("kutu").Length; j++)
         {
             if(parcaDizisi[i] == null)
             {

             }
             else
             {
                 if (parcaDizisi[i].transform.position == GameObject.FindGameObjectsWithTag("kutu")[j].transform.position)
                 {
                     kilit[j] = true;

                 }
                 else
                 {
                     kilit[j] = false;


                 }
             }

             if (kilit[i])
             {
                 Debug.Log("kutu " + i +" kiliti");
             }
             else
             {
                 Debug.Log("kutu " + i + " kiliti de�il");
             }
         }

     }*/
    // Destroy(GameObject.FindGameObjectsWithTag("parca")[int.Parse(ray.collider.gameObject.name)]); //Bu sat�r, �u anl�k indisleri de�i�tiriyor. Kullan�lmamas� gerekir.




    //---Kutu ve par�a konumlar�n� e�itle--///


    //�ndis Kontrol�
    /* for (int i = 0; i < GameObject.FindGameObjectsWithTag("parca").Length; i++)
     {
         if(parcaDizisi[i] == null)
         {
             continue;
         }
         Debug.Log("parca " + i + " " + GameObject.FindGameObjectsWithTag("parca")[i].name);
     }*/
}


