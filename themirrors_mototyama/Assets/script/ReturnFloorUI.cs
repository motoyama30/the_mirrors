using System;
using TMPro;
using UnityEngine;

namespace script
{
    public class ReturnFloorUI : MonoBehaviour
    {
        private int floor;
        private TextMeshProUGUI _floorTextMeshProUGUI;
        private void Start()
        {
            _floorTextMeshProUGUI = this.GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            
            float positionY = Camera.allCameras[0].transform.position.y;
            switch (positionY)
            {
                case float _ when positionY < 15:
                    floor = 1;
                    break;
                case float _ when 15 <= positionY && positionY < 35:
                    floor = 2;
                    break;
                case float _ when 35 <= positionY && positionY < 55:
                    floor = 3;
                    break;
                case float _ when 55 <= positionY && positionY < 75:
                    floor = 4;
                    break;
                case float _ when 75 <= positionY:
                    floor = 5;
                    break;
            }

            _floorTextMeshProUGUI.text = $"{floor}F";
        }
    }
}