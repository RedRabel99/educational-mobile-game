using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace FallingObject { 
    public class FallingParityNumber : FallingGameObject
    {
        [SerializeField] TMP_Text valueText;
        
        public override bool IsCorrect(GameMode gameMode) {

            int parity = gameMode.CurrentGameMode[0];
            return value % 2 == parity ? true : false;
        }

        void setValues()
        {
            value = Random.Range(1, 10);
            valueText.text = value.ToString();
        }

        protected override void InitializeObjectSettings()
        {
            setValues();
        }
    }
}