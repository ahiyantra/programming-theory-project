using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cube : shape // INHERITANCE
{
    public TextMeshProUGUI mouseTracker;
    public override string Name { get { return "cube"; } set { } } // POLYMORPHISM
    public Material Original { get; set; } // ENCAPSULATION
    public Material changed;

    // Start is called before the first frame update
    void Start()
    {
        Assigner(); // ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        mouseTracker.text = "mouse over " + gameObject.name;
        gameObject.GetComponent<MeshRenderer>().material = changed;
    }

    private void OnMouseExit()
    {
        mouseTracker.text = "mouse over none";
        gameObject.GetComponent<MeshRenderer>().material = Original;
    }

    public void Assigner()
    {
        Original = gameObject.GetComponent<MeshRenderer>().material;
    }
}
