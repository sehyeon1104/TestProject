using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour
{
    public void Register()
    {
        SceneManager.LoadScene("RegisterUser");
    }
    
}
