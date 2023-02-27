using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace script
{
    public class LimitTimeUI : MonoBehaviour
    {
        private int limitTime;
        private TextMeshProUGUI _limittimeTextMeshProUGUI;

        private void Start()
        {
            _limittimeTextMeshProUGUI = this.GetComponent<TextMeshProUGUI>();
            StartCoroutine(limitTimeUI());
        }

        IEnumerator limitTimeUI()
        {
            for (;;)
            {
                GameObject _gameObject = GameObject.Find("GameManager");
                GameManager _gameManager = _gameObject.GetComponent<GameManager>();
                _limittimeTextMeshProUGUI.text = $"Limit time:{360 - (int)_gameManager.time}";
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}