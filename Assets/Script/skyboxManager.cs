using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxManager : MonoBehaviour
{
    public void skyboxChanger(Material material){
        RenderSettings.skybox = material;
    }
}
