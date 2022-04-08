using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace FallingObject { 
    public class FallingNumber : FallingObject
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

        public override bool IsCorrect(int parity) { 
            
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

        void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name);
            Debug.Log("XD");
        }

        void OnTriggerStay(Collider other)
        {
            Debug.Log(other.gameObject.name);
            Debug.Log("XD");
        }
    }
}