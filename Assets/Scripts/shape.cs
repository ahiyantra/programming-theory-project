using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class shape : MonoBehaviour
{
    public TextMeshProUGUI textToChange;
    public abstract string Name { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        textToChange.text = "clicked on " + Name;
    }
}
