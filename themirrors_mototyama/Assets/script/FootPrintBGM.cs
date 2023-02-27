using System;
using UnityEngine;

namespace script
{
    [RequireComponent(typeof(AudioSource))]
    public class FootPrintBGM : MonoBehaviour
    {
        private AudioSource source;

        private void Start()
        {
            source = GetComponent<AudioSource>();
        }

        public void PlayFootstepSE()
        {
            source.PlayOneShot(source.clip);
        }
    }
}