using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    GameObject a;

    // Start is called before the first frame update
    void Start()
    {
        a = new GameObject();
        a.name = "cerceve";
        a.transform.position = new Vector2(Screen.width * 2, Screen.height / 2);
        var s = (Texture2D)Resources.Load("cerceve");
        s.width = 300;
        s.height = 400;
        var d = Sprite.Create(s, new Rect(0, 0, s.width, s.height), new Vector2(0.5f, 0.5f));
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
