using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botondecerrar : MonoBehaviour
{
    Button botoncerrar;
    // Start is called before the first frame update
    void Start()
    {
        botoncerrar = GetComponent<Button>();
        botoncerrar.onClick.AddListener(cerrar);
    }

    void cerrar()
    {
        Application.Quit();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
