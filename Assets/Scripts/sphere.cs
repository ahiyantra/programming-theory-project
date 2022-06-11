using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : shape
{
    public override string Name { get { return "sphere"; } set { } }
    public Material Original { get; set; }
    public Material changed;

    // Start is called before the first frame update
    void Start()
    {
        Original = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        gameObject.GetComponent<MeshRenderer>().material = changed;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = Original;
    }
}
