using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Membre : ScriptableObject
{
    Vector3[] PolygonCoords;
    Vector2[] TexCoord;
    Vector3[] vertices;
    Vector3[] triangles;

    
    public Membre(Vector3 [] pos, Vector2 [] tex)
    {
        PolygonCoords = new Vector3[pos.Length];
        PolygonCoords = pos;

        TexCoord = new Vector2[TexCoord.Length];
        TexCoord = tex;
    }
}
