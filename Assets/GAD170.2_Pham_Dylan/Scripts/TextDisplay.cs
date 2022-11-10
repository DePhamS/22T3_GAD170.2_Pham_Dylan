using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DylanPham
{
    public class TextDisplay : MonoBehaviour
    {
        //Luka coded the script for the text

        public GameObject textDisplaySpecies;
        public GameObject textDisplayLength;
        public GameObject textDisplayValue;
        public GameObject textDisplayTotalAmount;
        public Aquarium AQ; // This code allows the script Aquarium to become a variable

        void Update() // Adjusted the code so it works for me
        {
            textDisplaySpecies.GetComponent<TextMeshProUGUI>().text = "SPECIES: " + AQ.newFish.species; // Allows the text to display the variable of the newFish species that in the Aquarium script
            textDisplayLength.GetComponent<TextMeshProUGUI>().text = "LENGTH OF FISH: " + AQ.newFish.length + " cm";
            textDisplayValue.GetComponent<TextMeshProUGUI>().text = "VALUE: $" + AQ.newFish.value;
            textDisplayTotalAmount.GetComponent<TextMeshProUGUI>().text = "TOTAL AMOUNT = $" + AQ.totalValue;
        }
    }
}
