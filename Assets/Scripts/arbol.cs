using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbol : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite hitSprite;
    public Vector2 hitSpriteScale = new Vector2(10f, 10f);

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = normalSprite;
    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = hitSprite;
        transform.localScale = hitSpriteScale;
    }
}
