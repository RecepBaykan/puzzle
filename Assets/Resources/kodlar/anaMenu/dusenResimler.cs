using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusenResimler : MonoBehaviour
{
    private bool[] kilit;
    private int[] indis;
    private int[] kutuIndis;
    GameObject[] resimler;
    private float[] hiz;
    

    private void Start()
    {
        kilit = new bool[4];
        indis = new int[4];
        resimler = new GameObject[4];
        hiz = new float[4];
      
    }

    private void Update()
    {
        for(int i = 0; i < 4; i++)
        {
            if (!kilit[i])
            {
                int resRan = Random.Range(1, 121);
                var res = (Texture2D)Resources.Load("resimler/"+ resRan.ToString());
                var resSp = Sprite.Create(res, new Rect(0, 0, res.width, res.height), new Vector2(0.5f, 0.5f));
                resimler[i] = Instantiate(GameObject.Find("parso"));
                resimler[i].transform.parent =  GameObject.Find("parsomen").transform;
                resimler[i].transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = resSp;
                
                int rast = Random.Range(3, 8);
                resimler[i].transform.position = new Vector2((i+rast)*Screen.width /14, Screen.height+600);
                hiz[i] = Random.Range(0.1f, 0.4f);
                kilit[i] = true;

            }
            else
            {
                float a = (i + 0.7f) * 5;
                if(Vector3.Distance(resimler[i].transform.position, new Vector3((a) * Screen.width / 14, -Screen.height/2)) <= 200f)
                {
                    resimler[i].transform.position = new Vector3((a) * Screen.width / 14, -Screen.height/2);
                    kilit[i] = false;
                    Destroy(resimler[i]);
                }else
                {
                    resimler[i].transform.position = Vector3.Lerp(
                   resimler[i].transform.position, new Vector2((a) * Screen.width / 14, -Screen.height/2),
                   Time.deltaTime * hiz[i]
                   );
                }
               
             

            }
        }
       
    }
}
