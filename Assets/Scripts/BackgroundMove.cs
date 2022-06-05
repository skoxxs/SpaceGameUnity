using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 5.0f;
    
    private Renderer quadRenderer;
    void Start()
    {
        quadRenderer = this.GetComponent<Renderer>();
    }

    private Vector2 textureOffset;
    void Update()
    {
        textureOffset = new Vector2(0 , Time.time * -scrollSpeed);
        quadRenderer.material.mainTextureOffset = textureOffset;
    }
}
