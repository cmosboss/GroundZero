using UnityEngine;
using System.Collections;

public class FadeAway : MonoBehaviour {

    public Renderer rend;
    private float fadePerSecond = 0.05f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Standard");
    }
    void Update()
    {
        float Gloss = rend.material.GetFloat("_Glossiness");
        if (Gloss > 0)
        {
            rend.material.SetFloat("_Glossiness", Gloss - 0.001f);
        }
        else
        {
            Material material = GetComponent<Renderer>().material;
            Color color = material.color;
            material.color = new Color(color.r, color.g, color.b, color.a - (fadePerSecond * Time.deltaTime));
            if (color.a < 0.5f) {
                Destroy(gameObject);
            }
        }
    
    }

}
