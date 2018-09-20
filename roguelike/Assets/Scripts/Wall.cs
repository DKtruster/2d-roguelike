using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    //Dette er den sprite der viser spilleren han har angrebet muren
    public Sprite dmgSprite;
    public int hp = 4;


    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
    //Dette herunder giver spilleren noget visuelt om han har skadet muren
    public void DamageWall (int loss)
    {
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
