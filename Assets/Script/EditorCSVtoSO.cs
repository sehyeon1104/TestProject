using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class EditorCSVtoSO : MonoBehaviour
{
    static string csvFilePath = "/Resources/monsterCSV.csv";

    [MenuItem("Util/CSVtoSO")]
    public static void SetMonster()
    {
        string[] strData = File.ReadAllLines(Application.dataPath+csvFilePath);

        foreach(string sDat in strData)
        {
            string[] data = sDat.Split(',');
            MonsterSO monster = ScriptableObject. CreateInstance<MonsterSO>();  
            monster.monsterName = data[0];
            monster.attack=int.Parse(data[1]);h
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
