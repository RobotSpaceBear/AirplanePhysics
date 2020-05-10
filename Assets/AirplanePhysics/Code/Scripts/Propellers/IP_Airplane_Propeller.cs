using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Airplane_Propeller : MonoBehaviour
    {


        public void HandlePropeller(float currentRPM)
        {
            // dps = degrees per second
            float dps = ((currentRPM * 360) / 60 )* Time.deltaTime;
            transform.Rotate(Vector3.forward, dps);
        }
    } 
}
