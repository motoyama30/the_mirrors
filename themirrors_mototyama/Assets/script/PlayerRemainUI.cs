using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace script
{
    public class PlayerRemainUI : MonoBehaviour
    {
        private GameObject[] survivors;
        private int _surviverNum;
        private TextMeshProUGUI _surviverRemainTextMeshProUGUI;
        public GameManager _gameManager;
        private GameObject _gameObject;

        void Start()
        {
            survivors = GameObject.FindGameObjectsWithTag("Player");
            _surviverNum = survivors.Length;
            _surviverRemainTextMeshProUGUI = GetComponent<TextMeshProUGUI>();
            StartCoroutine(UpdateRemainSurviverUI());
        }
        IEnumerator UpdateRemainSurviverUI()
        {
            for (;;)
            {
                GameObject _gameObject = GameObject.Find("GameManager");
                _gameManager = _gameObject.GetComponent<GameManager>();
                survivors = GameObject.FindGameObjectsWithTag("Player");
                _surviverRemainTextMeshProUGUI.text = $"{survivors.Length}/{_gameManager.playercounter-1} Survivers Remain";
                yield return new WaitForSeconds(10f);
            }
        }
    }
}