using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Airplane_Propeller : MonoBehaviour
    {

        [Header("Propeller Properties")]
        public float minQuadRPM = 300f;
        public float minTextureSwap = 600;
        public GameObject mainProp;
        public GameObject blurredProp;

        [Header("Material Properties")]
        public Material blurredPropMat;
        public Texture2D blurLevel1;
        public Texture2D blurLevel2;


        private void Start()
        {
            if (mainProp && blurredProp)
            {
                HandleSwapping(0f);
            }
        }
        public void HandlePropeller(float currentRPM)
        {
            // dps = degrees per second
            float dps = ((currentRPM * 360) / 60) * Time.deltaTime;
            transform.Rotate(Vector3.forward, dps);

            if (mainProp && blurredProp)
            {
                HandleSwapping(currentRPM);
            }
        }

        /// <summary>
        /// Swapping materials and textures of the prop depending on the RPM
        /// </summary>
        /// <param name="currentRPM"></param>
        void HandleSwapping(float currentRPM)
        {
            if (currentRPM > minQuadRPM)
            {
                blurredProp.gameObject.SetActive(true);
                mainProp.gameObject.SetActive(false);

                if (blurredPropMat && blurLevel1 && blurLevel2)
                {
                    if (currentRPM > minTextureSwap)
                    {
                        /* got "_MainTex" by inspecting the properties of the MAT used for the blur prop Quad. 
                         * Click the cog on top right of material and see shader. Texture is on Albedo channel.*/
                        blurredPropMat.SetTexture("_MainTex", blurLevel2);
                    }
                    else
                    {
                        blurredPropMat.SetTexture("_MainTex", blurLevel1);
                    }
                }
            }
            else
            {
                blurredProp.gameObject.SetActive(false);
                mainProp.gameObject.SetActive(true);
            }
        }
    }
}
