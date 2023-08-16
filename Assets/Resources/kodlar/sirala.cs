using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sirala : MonoBehaviour
{

    [SerializeField] private GameObject parent;
   [SerializeField] public static int yuk;    //child(0)[0] parse(ismi)
   [SerializeField] public static int gen;   //child(0)[1] parse(ismi)

    [SerializeField] public static Texture2D resim;    //Şimdilik sürükle resmi, sonra Load("/Asessest/butonIsmi)
    public static Texture2D bgText;
    public Texture2D kutuResmi; //Şimdilik sürükle resmi, sonra Load("/Asessest/kutuResmi)
    public GameObject cerceve;
    private GameObject[] parca;
    private GameObject[] kutu;

    //public static GameObject parent;
    private GameObject[] parentChild;
    private GameObject[] childChild;

    public static GameObject[] kilitliKutudakiNesne;
    [SerializeField] public static float enBoyParcaX;
    [SerializeField] public static float enBoyParcaY;
    [SerializeField] public static float enBoyKutu;
    public static bool colliderSirasi;
    public static float x, y;

    [SerializeField] private GameObject bg;
    [SerializeField] private GameObject cam;


    void Start()
    {
        
        if(resim == null)
        {
           
        }
        else
        {
          
        }
        // Parçaları ve kutular oluştur
        parca = new GameObject[yuk * gen];
        kutu = new GameObject[yuk * gen];
        for (int i = 0; i < parca.Length; i++)
        {
            parca[i] = new GameObject();
            parca[i].name = i.ToString();
            parca[i].AddComponent<BoxCollider2D>();
            parca[i].transform.localScale = new Vector2(enBoyParcaX, enBoyParcaY);
            parca[i].tag = "parca";
            parca[i].transform.position = new Vector2(Screen.width * 4, Screen.height * 5);
            


            kutu[i] = new GameObject();
            kutu[i].name = i.ToString();
            kutu[i].transform.localScale = new Vector2(enBoyKutu, enBoyKutu);
            kutu[i].tag = "kutu";
        }
        int a = 0;
        // Parçalara ve kutulara resim parçası ekle
        for(int y = 1; y <= yuk; y++)
        {
            for(int x = gen; x>0; x--)
            {
                var sprite = Sprite.Create(resim, new Rect(resim.width - x * resim.width / gen, resim.height - y * resim.height / yuk, resim.width / gen, resim.height / yuk), new Vector2(0.5f, 0.5f));
                parca[a].AddComponent<SpriteRenderer>().sprite = sprite;
                Vector2 kutucuk = parca[a].GetComponent<SpriteRenderer>().sprite.bounds.size;
                parca[a].GetComponent<BoxCollider2D>().size = kutucuk;
                var kutuSprite = Sprite.Create(kutuResmi, new Rect(0, 0, kutuResmi.width, kutuResmi.height), new Vector2(0.5f, 0.5f));

                //Kutuya resim
                kutu[a].AddComponent<SpriteRenderer>().sprite = kutuSprite;
                kutu[a].GetComponent<SpriteRenderer>().sortingOrder = -2;

                a++;
            }
        }
        a = 0;
       




       




        //Parçaları sırala
       for (int y = 0; y < yuk; y++)
        {
            for(int x = 0; x < gen; x++)
            {
                Vector2 kutucuk = parca[a].GetComponent<SpriteRenderer>().sprite.bounds.size;




                parca[a].transform.position = new Vector2( x* parca[a].GetComponent<BoxCollider2D>().size.x*enBoyParcaX, -( y * parca[a].GetComponent<BoxCollider2D>().size.y)*enBoyParcaY);
                    kutu[a].transform.position = parca[a].transform.position;
           

                a++;
            }
        }
        a = 0;

        //Parca Kutuları*/

        parentGrid();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void parentGrid()
    {
        //parent = new GameObject();
        parent.name = "parent";
        parentChild = new GameObject[yuk * gen];
        childChild = new GameObject[yuk * gen];

        for(int i = 0; i < yuk * gen; i++)
        {
            parca[i].transform.parent = parent.transform;
           
        }

        parent.AddComponent<BoxCollider2D>();
        parent.GetComponent<BoxCollider2D>().size = new Vector2(gen * parca[0].GetComponent<BoxCollider2D>().size.x * enBoyParcaX, yuk * parca[0].GetComponent<BoxCollider2D>().size.y * enBoyParcaY);

        
       
        parent.transform.position = new Vector2(-10, 0);

        parent.GetComponent<BoxCollider2D>().enabled = false;
      
        if (gen % 2 == 0)
        {
            x = (kutu[(gen / 2)-1].transform.position.x + kutu[(gen / 2) ].transform.position.x) / 2;
            
        }
        else
        {
            x = kutu[(gen) / 2].transform.position.x;
        }
        if (yuk % 2 == 0)
        {
            y = (kutu[(yuk / 2)-1].transform.position.y + kutu[(yuk / 2)].transform.position.y) / 2;

        }
        else
        {
            y = kutu[(yuk) / 2].transform.position.y;
        }
        Camera.main.orthographicSize = 2.5f;//(gen) * parca[0].GetComponent<BoxCollider2D>().size.x/0.5F;
        Camera.main.transform.position = new Vector3(x, kutu[gen * yuk - gen].transform.position.y / 2, -10);
        GameObject.Find("cerceve").transform.position = new Vector2(x, kutu[gen*yuk -gen].transform.position.y / 2);

        bg.transform.position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);
        bg.transform.localScale = new Vector2(0.4f, 0.4f);
        
        bg.GetComponent<SpriteRenderer>().sprite = 
        Sprite.Create(bgText, new Rect(0,0, bgText.width, bgText.height),Vector2.one*0.5f);
        bg.GetComponent<SpriteRenderer>().sortingOrder = -1;    





    }

}
