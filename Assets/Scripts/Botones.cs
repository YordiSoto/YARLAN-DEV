using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    Button botonIniciar;
    void Start()
    {
        botonIniciar = GetComponent<Button>();
        botonIniciar.onClick.AddListener(siguiente);
    }

    void siguiente()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
