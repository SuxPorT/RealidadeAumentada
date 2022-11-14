using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFire : MonoBehaviour
{
    public ParticleSystem fireParticleSystem;
    public bool showFire = false;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetKey(KeyCode.Space) && this.showFire) {
            var emission = this.fireParticleSystem.emission;
            emission.enabled = false;
            this.showFire = false;
        }
        else if (Input.GetKey(KeyCode.Space) && !this.showFire) {
            var emission = this.fireParticleSystem.emission;
            emission.enabled = true;
            this.showFire = true;
        }
    }
}
