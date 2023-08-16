using System.IO;
using UnityEngine;

public  static class kaydetAltin
{



    public static string klasor = "/kayitBigisi/";
    public static string dosya = "altin.txt";

    public static void kayit(altinBilgisi a)
    {
        string yol = Application.persistentDataPath + klasor;
        if (!Directory.Exists(yol))
        {
            Directory.CreateDirectory(yol);
        }

        string json = JsonUtility.ToJson(a);
        File.WriteAllText(yol + dosya, json);
    }

    public static altinBilgisi yukle()
    {
        altinBilgisi a = new altinBilgisi();
        string tamYol = Application.persistentDataPath + klasor + dosya;
        if (File.Exists(tamYol))
        {
            string json = File.ReadAllText(tamYol);
            a = JsonUtility.FromJson<altinBilgisi>(json);
        }


        return a;

    }




}
