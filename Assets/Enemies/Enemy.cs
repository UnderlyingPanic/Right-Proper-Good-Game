using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy: MonoBehaviour {

    [SerializeField]
    float maxHealthPoints=100f;
    [SerializeField][Range(0,100)]
    float currentHealthPoints = 100f;

    public float healthAsPercentage
    {
        get { return currentHealthPoints / (float)maxHealthPoints; }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
