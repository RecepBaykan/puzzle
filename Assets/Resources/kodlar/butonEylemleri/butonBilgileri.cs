using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonBilgileri: MonoBehaviour
{
    //Parþomen Bilgileri
    public static bool parsomenKilidi;
    public static Vector2 parsomeninGeciciKonumu = new Vector2(-Screen.width * 2, -Screen.height * 2);


    public static int ulkeDegeri = 1;
    public static string resim = "0";

    //Resimlere eriþim
    public static Texture2D ulkeResmi;
    public static Texture2D bayrakResmi;

   public void butonIs()
    {
        Debug.Log(ulkeDegeri + " ulke" );
        Debug.Log(kaydet.yukle().kaldigin_yer + " kayit");
    }
}

