using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColor : MonoBehaviour
{

    Color[] colors = new Color[5];



    void Start()
    {

      colors[0] = new Color(0.3098039f, 0.6901961f, 0.4941177f);
      colors[1] = new Color(0.9843138f, 0.5137255f, 0.4235294f);
      colors[2] = new Color(0.1294118f, 0.6980392f, 0.3294118f);
      colors[3] = new Color(0.03921569f, 0.572549f, 0.2980392f);
      colors[4] = new Color(0.9803922f, 0.3333333f, 0.2117647f);

      transform.GetComponent<Light>().color = colors[Random.Range(0, colors.Length)];
    }

}
