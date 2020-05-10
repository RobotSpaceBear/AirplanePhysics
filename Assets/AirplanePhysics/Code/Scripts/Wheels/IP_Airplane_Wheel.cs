using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    [RequireComponent(typeof(WheelCollider))]
    public class IP_Airplane_Wheel : MonoBehaviour
    {
        private WheelCollider WheelCol;

        private void Start()
        {
            WheelCol = GetComponent<WheelCollider>();
        }
        public void InitWheel()
        {
            if (WheelCol)
            {
                WheelCol.motorTorque = 0.000000001f;
            }
        }

    } 
}
