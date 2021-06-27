using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPropagator : MonoBehaviour
{
    public string name = "";
    public Color color = Color.white;
    public List<SpriteRenderer> srs;

    public void propogate()
    {
        srs.ForEach(sr => sr.color = color);
    }
}
