using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{
    void Start()
    {
    Cat sehyeon = new Cat("세현", "18");
    Cat minyeong = new Cat("민영", "17");
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
        print($"{name} 잘가요");
    }
    public void Ache()
    {
        print($"고양이의 이름은 {name} 이고 나이는 {age}이다");
    }
}
