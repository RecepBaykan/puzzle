using System.IO;
using UnityEngine;

public  static class kaydetSure
{



    public static string klasor = "/kayitBigisi/";
    public static string dosya = "sure.txt";

    public static void kayit(sureBilgisi s)
    {
        string yol = Application.persistentDataPath + klasor;
        if (!Directory.Exists(yol))
        {
            Directory.CreateDirectory(yol);
        }

        string json = JsonUtility.ToJson(s);
        File.WriteAllText(yol + dosya, json);
    }

    public static sureBilgisi yukle()
    {
        sureBilgisi s = new sureBilgisi();
        string tamYol = Application.persistentDataPath + klasor + dosya;
        if (File.Exists(tamYol))
        {
            string json = File.ReadAllText(tamYol);
            s = JsonUtility.FromJson<sureBilgisi>(json);
        }


        return s;

    }




}
