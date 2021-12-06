using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Linq;
using System.Xml;

public class XMLparser : MonoBehaviour
{
    [SerializeField] private string filePath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Load Data from a GML document
    public void LoadData()
    {
        XDocument doc = XDocument.Load(filePath);
        XmlReader reader = doc.CreateReader();


    }



}
