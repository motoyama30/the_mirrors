using System;
using System.Collections;
using Photon.Pun;
using TMPro;
using UnityEngine;

namespace script
{
    public class ConnenctingUIScr : MonoBehaviour
    {
        private TextMeshProUGUI _connectTextMeshProUGUI;

        private void OnEnable()
        {
            _connectTextMeshProUGUI = this.GetComponent<TextMeshProUGUI>();
            StartCoroutine(UpdateConnectProgressUI());
        }

        private void Start()
        {
        }

        IEnumerator UpdateConnectProgressUI()
        {
            for (;;)
            {
                _connectTextMeshProUGUI.text = "Connecting";
                yield return new WaitForSeconds(0.5f);
                _connectTextMeshProUGUI.text = "Connecting.";
                yield return new WaitForSeconds(0.5f);
                _connectTextMeshProUGUI.text = "Connecting..";
                yield return new WaitForSeconds(0.5f);
                _connectTextMeshProUGUI.text = "Connecting...";
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}