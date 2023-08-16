using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altinHizala : MonoBehaviour
{
    altinBilgisi a = new altinBilgisi();
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(7.5F* Screen.width / 10, 9.6f * Screen.height / 10);
    }

    // Update is called once per frame
    void Update()
    {
        a.altin = kaydetAltin.yukle().altin;
        kaydetAltin.kayit(a);
        transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = a.altin.ToString();
    }
}
