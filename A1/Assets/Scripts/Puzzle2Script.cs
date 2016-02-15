using UnityEngine;
using System.Collections;

public class Puzzle2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collider)
    {

        gameObject.GetComponent<SpriteRenderer>().color = Color.red;

    }
}
