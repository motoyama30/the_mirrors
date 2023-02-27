using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering.Universal;
using Random = UnityEngine.Random;

public class animLight : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Vector3 Lightpos;
    private float LightposRadiusx = 0f;
    private float LightposRadiusy = 0f;
    private Light2D LightSet;
    private float baseLihtOuterRadius;
    private float LightRangeRadius = 0f;

    void Start()
    {
        Lightpos = this.transform.position;
        LightSet = this.GetComponent<Light2D>();
        baseLihtOuterRadius = LightSet.pointLightOuterRadius;
    }

    // Update is called once per frame
    void Update()
    {
        LightposRadiusx += Random.Range(-0.1f, 0.1f);
        LightposRadiusy += Random.Range(-0.1f, 0.1f);
        this.transform.position = Lightpos + new Vector3(Mathf.Sin(LightposRadiusx), Mathf.Sin(LightposRadiusy), 0);
        LightRangeRadius += Random.Range(-0.1f, 0.1f);
        LightSet.pointLightOuterRadius = baseLihtOuterRadius + Mathf.Sin(LightRangeRadius)*2.0f;
    }
}
