using IndiePixel;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace IndePixel
{

    public class IP_Airplane_Menus
    {
        [MenuItem("Airplane Tools/Create New Airplane")]
        public static void CreateNewAirplane()
        {
            Debug.Log("Creating new airplane.");

            GameObject curSelected = Selection.activeGameObject;
            if (curSelected)
            {
                IP_Airplane_Controller curController = curSelected.AddComponent<IP_Airplane_Controller>();
                GameObject curCOG = new GameObject("COG");
                curCOG.transform.SetParent(curSelected.transform);

                curController.centerOfGravity = curCOG.transform;
            }


            Debug.Log("Done creating new airplane.");
        }
    }

}
