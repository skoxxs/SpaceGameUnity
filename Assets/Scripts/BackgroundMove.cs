using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 5.0f;
    
    private Renderer quadRenderer;
    // Start is called before the first frame update
    void Start()
    {
        quadRenderer = this.GetComponent<Renderer>();
    }

    private Vector2 textureOffset;
    // Update is called once per frame
    void Update()
    {
        textureOffset = new Vector2(0 , Time.time * -scrollSpeed);
        quadRenderer.material.mainTextureOffset = textureOffset;
    }
}
