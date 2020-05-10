using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(AudioSource))]
    public class IP_BaseRigidbody_Controller : MonoBehaviour
    {

        protected Rigidbody rb;
        protected AudioSource aSource;


        // Start is called before the first frame update
        public virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();
            if (aSource)
            {
                aSource.playOnAwake = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void FixedUpdate() {
            if (rb)
            {
                HandlePhysics();
            }
        }

        protected virtual void HandlePhysics(){
            
        }
    }
}
