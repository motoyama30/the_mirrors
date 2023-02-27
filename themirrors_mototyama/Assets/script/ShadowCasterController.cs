using System;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace script
{
    public class ShadowCasterController : MonoBehaviour
    {
        private void Start()
        {
            ShadowCaster2D _shadowCaster2D = GetComponent<ShadowCaster2D>();
            _shadowCaster2D.GetShadowCasters();
            this.gameObject.transform.localScale = new Vector3(-1,1,1);
        }
    }
}