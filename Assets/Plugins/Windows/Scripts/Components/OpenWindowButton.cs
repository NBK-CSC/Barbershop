﻿using Windows.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Windows.Windows.Scripts.Components
{
    [RequireComponent(typeof(Button))]
    public class OpenWindowButton : MonoBehaviour
    {
        [SerializeField] private WindowAsset window;
        [SerializeField] private bool isClosePrev;
        
        private Button _button;

        private void Awake() => _button = GetComponent<Button>();
        private void OnEnable() => _button.onClick.AddListener(OpenWindow);
        private void OnDisable() => _button.onClick.RemoveListener(OpenWindow);
        private void OpenWindow() => WindowsAggregator.SetWindow(window.ID, isClosePrev);
    }
}