using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDrop : Drop {
    public GameObject nextHop;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (nextHop != null) {
            Debug.DrawLine(this.transform.position, nextHop.transform.position);
        }
	}

    public override void getInstruction(Agent agent) {
        float distance = Vector3.Distance(agent.transform.position, this.transform.position );
        agent.transform.Translate(((nextHop == null ? this.transform.position : nextHop.transform.position) - agent.transform.position) * Time.deltaTime  * (1/(1+(distance))) * .3f   );
    }
}
