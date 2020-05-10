using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel{

    public class IP_Airplane_Controller : IP_BaseRigidbody_Controller
    {
        #region Variable
        [Header("Base Airplane Properties")]
        public IP_XboxAirplane_Input input;
        public Transform centerOfGravity;
        
        [Tooltip("Weight is in pounds (lbs)")]
        public float airplaneWeight = 800f;

        [Header("Engines")]
        public List<IP_Airplane_Engine> engines = new List<IP_Airplane_Engine>();

        [Header("Wheels")]
        public List<IP_Airplane_Wheel> wheels = new List<IP_Airplane_Wheel>();


        const float poundsToKilos = 0.453592f;

        #endregion

        public override void Start()
        {
            base.Start();

            // weight
            float finalMass = airplaneWeight * poundsToKilos;
            if (rb)
            {
                rb.mass = finalMass;

                if (centerOfGravity)
                {
                    rb.centerOfMass = centerOfGravity.localPosition;
                }
            }

            //wheels
            if (wheels!=null)
            {
                foreach (IP_Airplane_Wheel wheel in wheels)
                {
                    wheel.InitWheel();
                }
            }

        }

        #region Custom Methods
        protected override void HandlePhysics()
        {
            if (input)
            {
                HandleEngines();
                HandleAerodynamics();
                HandleSteering();
                HandleBrakes();
                HandleAltitude(); 
            }
        }

        void HandleEngines()
        {
            if (engines != null)
            {
                foreach (IP_Airplane_Engine engine in engines)
                {
                    rb.AddForce(engine.CalculateForce(input.Throttle * -1));
                }
            }
        }
        void HandleAerodynamics()
        {

        }

        void HandleSteering()
        {

        }

        void HandleBrakes()
        {

        }

        void HandleAltitude()
        {

        }

        #endregion


    }
}
