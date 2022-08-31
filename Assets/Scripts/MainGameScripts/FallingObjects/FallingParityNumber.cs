using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace FallingObject { 
    public class FallingParityNumber : FallingObject
    {
        private int _value;
        public TMP_Text valueText;
        
        void Start()
        {
            setValues();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public override bool IsCorrect(GameMode gameMode) {

            int parity = gameMode.CurrentGameMode[0];
            return _value % 2 == parity ? true : false;
        }

        void setValues()
        {
            //valueText = this.gameObject.GetComponent < TextMeshPro>();
            _value = Random.Range(1, 10);
            valueText.text = _value.ToString();
        }


        public override void Destroy()
        {
           // Destroy(GameObject);
        
        }
    }
}