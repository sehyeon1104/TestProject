using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{
    void Start()
    {
    Cat sehyeon = new Cat("����", "18");
    Cat minyeong = new Cat("�ο�", "17");
        sehyeon.Ache();
        minyeong.Ache();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class Cat : MonoBehaviour
    {
     //string name;
    string age;
  public Cat(string _name, string _age)
    {
        name = _name;
        age = _age; 
    }
    ~Cat()
    {
        print($"{name} �߰���");
    }
    public void Ache()
    {
        print($"������� �̸��� {name} �̰� ���̴� {age}�̴�");
    }
}
