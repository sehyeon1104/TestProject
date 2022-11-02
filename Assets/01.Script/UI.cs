using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    int a = 1;
    TextMeshProUGUI textMeshPro;
   
    [Range(0f, 100f)]
   public int fontSize;
    [TextArea(9,10)]
    public string text;
    [ColorUsage(true)]
    public Color32 color;
    [ContextMenuItem("Changs", "Ohs")]
    [ContextMenuItem("Reset", "Haeul")]
    public string context;
    private void Start()
    {
        textMeshPro.color = color;
        textMeshPro = GetComponent<TextMeshProUGUI>();

    }   
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            a -= 4;
        }    
        textMeshPro.text= $"���� �� :{a}" ;

        
        textMeshPro.fontSize = fontSize;
    }
    void Ohs()
    {
        context = "��â������";
        text = context;
    }
    void Haeul()
    {
        context = "";
        text = context; 
    }

}
