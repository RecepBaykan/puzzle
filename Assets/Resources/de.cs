using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var tex = (Texture2D)Resources.Load("cerceve");
        var tex2 = sirala.resim;
        var tex3 = Resize(tex, tex2.width, tex2.height);
       
        var sprite = Sprite.Create(tex3, new Rect(0, 0, tex3.width, tex3.height),new Vector2(0.5f,0.5f));
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
        gameObject.transform.localScale = new Vector2(sirala.enBoyParcaX, sirala.enBoyParcaY);
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Texture2D Resize(Texture2D texture2D, int targetX, int targetY)
    {
        RenderTexture rt = new RenderTexture(targetX, targetY, 24);
        RenderTexture.active = rt;
        Graphics.Blit(texture2D, rt);
        Texture2D result = new Texture2D(targetX, targetY);
        result.ReadPixels(new Rect(0, 0, targetX, targetY), 0, 0);
        result.Apply();
        return result;
    }
}
