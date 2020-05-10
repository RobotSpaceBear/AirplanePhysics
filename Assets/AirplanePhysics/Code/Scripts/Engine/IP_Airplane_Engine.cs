using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Airplane_Engine : MonoBehaviour
    {
        [Header("Engine Properties")]
        public float maxForce = 200f;
        public float maxRPM = 2550f;

        public AnimationCurve powerCurve = AnimationCurve.Linear(0,0,1f,1f);

        [Header("Propellers")]
        public IP_Airplane_Propeller propeller;

        public Vector3 CalculateForce(float throttle)
        {
            // calculate power
            float finalThrottle = Mathf.Clamp01(throttle);
            finalThrottle = powerCurve.Evaluate(finalThrottle);

            //calculate RPM
            float currentRPM = finalThrottle * maxRPM;
            if (propeller)
            {
                propeller.HandlePropeller(currentRPM);
            }

            //create force
            float finalPower = finalThrottle * maxForce;
            Vector3 finalForce = transform.forward * finalPower;

            return finalForce;
        }
    } 
}
