using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : MonoBehaviour
{
    WaitForSeconds wait = new WaitForSeconds(0.3f);
    [SerializeField]
    string ss = "���� �輼���Դϴ�";
    void Start()
    {
       StartCoroutine(Stringtoint(ss));
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   
   IEnumerator Stringtoint(string chatting)
    {
        char[] dd = { };
        dd = chatting.ToCharArray();
        foreach (char c in dd)
        {
            print(c);
            yield return wait;
        }
    }
}
