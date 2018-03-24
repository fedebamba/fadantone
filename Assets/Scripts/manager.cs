using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
    public GameObject path;

    int[] xs = { 1, 3, 4, 6, 8, 9, 7, 6, 3, 5,8 };
    int[] ys = { 1, 2, 5, 7, 7, 9, 11, 12, 12, 10, 9 };

	// Use this for initialization
	void Start () {
        for (int i = 0; i < xs.Length; i++) {
            path.GetComponent<Path>().addDrop(new Vector3(xs[i], 0, ys[i]));
        }        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
