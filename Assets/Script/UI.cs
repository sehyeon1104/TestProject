using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    int a = 1;
    TextMeshProUGUI textMeshPro;
   
    [Range(0f, 100f)]
   public int tmpFontsize;
    [TextArea(9,10)]
    public string text;
    [ContextMenuItem("Chang", "Oh")]
    [ContextMenuItem("Reset", "Haeul")]
    public string context;
    private void Start()
    {
       textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            a *= 2;
        }    
        textMeshPro.text= $"지금 수 :{a}" ;


        textMeshPro.fontSize = tmpFontsize;
    }
    void Oh()
    {
        context = "오창현병신";
        text = context;
    }
    void Haeul()
    {
        context = "";
        text = context; 
    }

}
