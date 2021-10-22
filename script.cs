// Ejemplo de uno de los scripts
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{   
    const int ID = 1
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ID + ": " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + "-counter: " + contador);
        contador++;
    }
}
