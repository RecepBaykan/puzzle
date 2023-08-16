using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guclendir : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool saatKilidi;
    public static bool parcaKilidi;
    Texture2D deAktif;
    Sprite deAktifSprite;
    
    private void Start()
    {
        deAktif = (Texture2D)Resources.Load("deAktif");
        deAktifSprite = Sprite.Create(deAktif, new Rect(0, 0, deAktif.width, deAktif.height), new Vector2(0.5f, 0.5f));


    }
    public void sureBir()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("a").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            if (!saatKilidi)
            {
                sure.zaman += 10;
                GameObject.Find("sure").GetComponent<TMPro.TextMeshProUGUI>().text = sure.zaman.ToString();
                saatKilidi = true;
                a.altin -= int.Parse(GameObject.Find("a").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(a);
                deAktifEt(GameObject.FindGameObjectsWithTag("zaman"));
            }
            else
            {

            }
        }
      
        
    }
    public void sureIki()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("b").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {
            if (!saatKilidi)
            {
                sure.zaman += 20;
                GameObject.Find("sure").GetComponent<TMPro.TextMeshProUGUI>().text = sure.zaman.ToString();
                saatKilidi = true;
                a.altin -= int.Parse(GameObject.Find("b").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(a);
                deAktifEt(GameObject.FindGameObjectsWithTag("zaman"));
            }
            else
            {

            }

        }
    
    }

    public void sureUc()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("c").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            if (!saatKilidi)
            {
                sure.zaman += 44;
                GameObject.Find("sure").GetComponent<TMPro.TextMeshProUGUI>().text = sure.zaman.ToString();
                saatKilidi = true;
                a.altin -= int.Parse(GameObject.Find("c").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(a);
                deAktifEt(GameObject.FindGameObjectsWithTag("zaman"));
            }
            else
            {

            }
        }
       
    }

    public void parcaBir()
    {
        altinBilgisi d = new altinBilgisi();
        d.altin = kaydetAltin.yukle().altin;

        if (d.altin - int.Parse(GameObject.Find("d").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            if (!parcaKilidi)
            {

                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < GameObject.FindGameObjectsWithTag("parca").Length; j++)
                    {
                        if (GameObject.FindGameObjectsWithTag("kutu")[i].name == GameObject.FindGameObjectsWithTag("parca")[j].name)
                        {
                            for (int a = 0; a < GameObject.FindGameObjectsWithTag("kutu").Length; a++)
                            {
                                if (GameObject.FindGameObjectsWithTag("parca")[j].transform.position == GameObject.FindGameObjectsWithTag("kutu")[a].transform.position)
                                {
                                    for (int b = 0; b < GameObject.FindGameObjectsWithTag("parca").Length; b++)
                                    {
                                        if (GameObject.FindGameObjectsWithTag("parca")[b].transform.position == GameObject.FindGameObjectsWithTag("kutu")[i].transform.position)
                                        {
                                            GameObject.FindGameObjectsWithTag("parca")[b].transform.position = GameObject.FindGameObjectsWithTag("kutu")[a].transform.position;
                                            GameObject.FindGameObjectsWithTag("parca")[j].transform.position = GameObject.FindGameObjectsWithTag("kutu")[i].transform.position;


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                deAktifEt(GameObject.FindGameObjectsWithTag("par"));
                d.altin -= int.Parse(GameObject.Find("d").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(d);
                parcaKilidi = true;
            }
            else
            {

            }

        }

           
    }

    public void parcaIki()
    {
        altinBilgisi d = new altinBilgisi();
        d.altin = kaydetAltin.yukle().altin;

        if (d.altin - int.Parse(GameObject.Find("e").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {
            if (!parcaKilidi)
            {

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < GameObject.FindGameObjectsWithTag("parca").Length; j++)
                    {
                        if (GameObject.FindGameObjectsWithTag("kutu")[i].name == GameObject.FindGameObjectsWithTag("parca")[j].name)
                        {
                            for (int a = 0; a < GameObject.FindGameObjectsWithTag("kutu").Length; a++)
                            {
                                if (GameObject.FindGameObjectsWithTag("parca")[j].transform.position == GameObject.FindGameObjectsWithTag("kutu")[a].transform.position)
                                {
                                    for (int b = 0; b < GameObject.FindGameObjectsWithTag("parca").Length; b++)
                                    {
                                        if (GameObject.FindGameObjectsWithTag("parca")[b].transform.position == GameObject.FindGameObjectsWithTag("kutu")[i].transform.position)
                                        {
                                            GameObject.FindGameObjectsWithTag("parca")[b].transform.position = GameObject.FindGameObjectsWithTag("kutu")[a].transform.position;
                                            GameObject.FindGameObjectsWithTag("parca")[j].transform.position = GameObject.FindGameObjectsWithTag("kutu")[i].transform.position;


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                deAktifEt(GameObject.FindGameObjectsWithTag("par"));
                d.altin -= int.Parse(GameObject.Find("e").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(d);
                parcaKilidi = true;

            }
            else
            {

            }

        }
        
    }

    public void parcaUc()
    {
        altinBilgisi d = new altinBilgisi();
        d.altin = kaydetAltin.yukle().altin;

        if (d.altin - int.Parse(GameObject.Find("f").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            if (!parcaKilidi)
            {

                for (int i = 0; i < GameObject.FindGameObjectsWithTag("parca").Length / 2; i++)
                {
                    for (int j = 0; j < GameObject.FindGameObjectsWithTag("parca").Length; j++)
                    {
                        if (GameObject.FindGameObjectsWithTag("kutu")[i].name == GameObject.FindGameObjectsWithTag("parca")[j].name)
                        {
                            for (int a = 0; a < GameObject.FindGameObjectsWithTag("kutu").Length; a++)
                            {
                                if (GameObject.FindGameObjectsWithTag("parca")[j].transform.position == GameObject.FindGameObjectsWithTag("kutu")[a].transform.position)
                                {
                                    for (int b = 0; b < GameObject.FindGameObjectsWithTag("parca").Length; b++)
                                    {
                                        if (GameObject.FindGameObjectsWithTag("parca")[b].transform.position == GameObject.FindGameObjectsWithTag("kutu")[i].transform.position)
                                        {
                                            GameObject.FindGameObjectsWithTag("parca")[b].transform.position = GameObject.FindGameObjectsWithTag("kutu")[a].transform.position;
                                            GameObject.FindGameObjectsWithTag("parca")[j].transform.position = GameObject.FindGameObjectsWithTag("kutu")[i].transform.position;


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                deAktifEt(GameObject.FindGameObjectsWithTag("par"));
                d.altin -= int.Parse(GameObject.Find("f").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
                kaydetAltin.kayit(d);
                parcaKilidi = true;
            }
            else
            {

            }
        }
       
    }

    public void canBir()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("g").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            canBilgisi c = new canBilgisi();
            c.can = kaydetCan.yukle().can;
            c.can += 1;
            kaydetCan.kayit(c);
            a.altin -= int.Parse(GameObject.Find("g").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
            kaydetAltin.kayit(a);
        }
       
    }
    public void canIki()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("h").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            canBilgisi c = new canBilgisi();
            c.can = kaydetCan.yukle().can;
            c.can += 3;
            kaydetCan.kayit(c);
            a.altin -= int.Parse(GameObject.Find("h").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
            kaydetAltin.kayit(a);
        }
       
    }
    public void canUc()
    {
        altinBilgisi a = new altinBilgisi();
        a.altin = kaydetAltin.yukle().altin;

        if (a.altin - int.Parse(GameObject.Find("i").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text) >= 0)
        {

            canBilgisi c = new canBilgisi();
            c.can = kaydetCan.yukle().can;
            c.can += 5;
            kaydetCan.kayit(c);
            a.altin -= int.Parse(GameObject.Find("i").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text);
            kaydetAltin.kayit(a);

        }

    }
    public void deAktifEt(GameObject[] game)
    {
      
        foreach (GameObject g in game)
        {
            g.GetComponent<UnityEngine.UI.Image>().sprite = deAktifSprite;
        }
        

    }
}
