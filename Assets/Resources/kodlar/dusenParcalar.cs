using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dusenParcalar : MonoBehaviour
{

  public static  bool sayim;
    private bool[] kilit;
    private int[] indis;
    private int[] kutuIndis;
    Vector3[] sonDurak;
    List<GameObject> firlatilmisParca;
    List<GameObject> kutuBeyleri;
    int sayac = 0;
    public static bool sureBaslat;
    int say = 0;
    float timer = 5;
   
    [SerializeField] private TextMeshProUGUI sure;
    private void Start()
    {
        kilit = new bool[4];
        indis = new int[kilit.Length];
        kutuIndis = new int[kilit.Length];
        kutuBeyleri = new List<GameObject>();
        firlatilmisParca = new List<GameObject>();
        sonDurak = new Vector3[kilit.Length];
        sureBaslat = false; 

    
       
    }

    public void gucKapat()
    {
        timer = -1;
    }

    
    private void Update()
    {
        if(!kontrol.Kazandin && int.Parse(sure.text)>0)
        {
            for (int i = 0; i < kilit.Length; i++)
        {
            if (!kilit[i])
            {
                indis[i] = Random.Range(0, GameObject.FindGameObjectsWithTag("parca").Length);
                if (firlatilmisParca.Contains(GameObject.FindGameObjectsWithTag("parca")[indis[i]]))
                {
                    kilit[i] = false;

                }
                else
                {

                    kutuIndis[i] = Random.Range(0, GameObject.FindGameObjectsWithTag("kutu").Length);
                    if (kutuBeyleri.Contains(GameObject.FindGameObjectsWithTag("kutu")[kutuIndis[i]]))
                    {
                        kilit[i] = false;

                    }
                    else
                    {
                        sonDurak[i] = GameObject.FindGameObjectsWithTag("kutu")[kutuIndis[i]].transform.position;
                        GameObject.FindGameObjectsWithTag("parca")[indis[i]].transform.position = GameObject.FindGameObjectsWithTag("yol")[Random.Range(0, GameObject.FindGameObjectsWithTag("yol").Length)].transform.position;
                        kutuBeyleri.Add(GameObject.FindGameObjectsWithTag("kutu")[kutuIndis[i]]);
                        firlatilmisParca.Add(GameObject.FindGameObjectsWithTag("parca")[indis[i]]);
                        kilit[i] = true;



                    }
                }
            }
            else
            {
                if (Vector3.Distance(GameObject.FindGameObjectsWithTag("parca")[indis[i]].transform.position, sonDurak[i]) <= 0.7f)
                {
                    GameObject.FindGameObjectsWithTag("parca")[indis[i]].transform.position = sonDurak[i];
                    kilit[i] = false;
                    say++;
                }
                else
                {
                    GameObject.FindGameObjectsWithTag("parca")[indis[i]].transform.position = Vector3.Lerp(GameObject.FindGameObjectsWithTag("parca")[indis[i]].transform.position, sonDurak[i], Time.deltaTime * sirala.gen*sirala.yuk/3);
                }
            }



        }
        }
        if(say == GameObject.FindGameObjectsWithTag("kutu").Length)
        {
            GameObject.Find("guclendirmeMarketi").transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
           if(timer >= 0)
            {
                timer -= Time.deltaTime;

            }
            else
            {

                say = 0;
                timer = 5;
                sureBaslat = true;
                guclendir.parcaKilidi = false;
                guclendir.saatKilidi = false;
            }
        }
        
        
    }
}
