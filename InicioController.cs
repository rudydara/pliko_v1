using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    public void ingresar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
