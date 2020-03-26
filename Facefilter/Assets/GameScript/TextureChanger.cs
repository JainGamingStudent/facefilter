using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Texture[] alltexture;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.mainTexture = alltexture[PlayerPrefs.GetInt("id")];
    }
}
