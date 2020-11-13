using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterScript : MonoBehaviour
{

    public Texture[] textures;
    public Material posterMat;
    public int currentImage;

    void Start()
    {
      getNewImage();
      InvokeRepeating("getNewImage", 0.0f, 10.0f);

    }


    void getNewImage()
    {
      currentImage = (int)Random.Range(0.0f, 7.0f);
      posterMat.SetTexture("_MainTex", textures[currentImage]);
      posterMat.SetTexture("_EmissionMap", textures[currentImage]);
    }
}
