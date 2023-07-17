using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int index;
    public Mark mark;
    public bool IsMarked;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        index=transform.GetSiblingIndex();
        mark=Mark.None;
        IsMarked = false;
    }
    public void MarkBox(Sprite sprite,Mark mark,Color color)
    {
        IsMarked=true;
        this.mark = mark;
        spriteRenderer.color = color;
        spriteRenderer.sprite=sprite;

        GetComponent<CircleCollider2D>().enabled=false;//to avoid marking it again.
    }
    
}
