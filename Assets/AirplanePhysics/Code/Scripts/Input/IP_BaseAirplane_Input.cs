using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_BaseAirplane_Input : MonoBehaviour
    {
        public float pitch = 0f;
        public float roll = 0f;
        public float yaw = 0f;
        public float throttle = 0f;
        public int flaps = 0;
        public float brake = 0f;

        public float Pitch { get { return pitch; } }
        public float Roll { get { return roll; } }
        public float Yaw { get { return yaw; } }
        public float Throttle { get { return throttle; } }
        public int Flaps { get { return flaps; } }
        public float Brake { get { return brake; } }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Inputs started");
        }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
        }

        void HandleInput()
        {
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");

            Debug.Log(string.Format("pitch: {0}    Roll : {1}", pitch, roll));
        }
    }
}
