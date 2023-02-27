using System;
using Photon.Pun;
using TMPro;
using UnityEngine;

namespace script
{
    public class ConnenctingPlayerNumUI : MonoBehaviour
    {
        
        private TextMeshProUGUI _connenctingTextMeshProUGUI;
        private void OnEnable()
        {
            _connenctingTextMeshProUGUI = this.GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _connenctingTextMeshProUGUI.text = $"{PhotonNetwork.CurrentRoom.PlayerCount} players waiting";
        }
    }
}