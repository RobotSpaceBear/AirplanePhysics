using IndiePixel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_XboxAirplane_Input : IP_BaseAirplane_Input
    {
        protected override void HandleInput()
        {
            //controls
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw = Input.GetAxis("X_RH_Stick");
            throttle = Input.GetAxis("X_RV_Stick");

            //brake
            brake = Input.GetAxis("Fire1");

            //flaps
            if (Input.GetButtonDown("X_R_Bumper"))
            {
                flaps += 1;
            }
            if (Input.GetButtonDown("X_L_Bumper"))
            {
                flaps -= 1;
            }

            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
        }
    }
}
