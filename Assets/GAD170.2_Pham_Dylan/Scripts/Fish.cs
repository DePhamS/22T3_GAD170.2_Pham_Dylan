using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class Fish : MonoBehaviour
    {
        public string species;
        public float length = 0f;
        public int value;

        [SerializeField] private string[] speciesArray = new string[7]; //{ "Bass", "Tuna", "Trout", "Perch", "Snapper", "Cod", "Shark" };
 
        public Fish(string newSpecies, float newLength, int newValue)
        {
            species = newSpecies;
            length = newLength;
            value = newValue;
        }
        
        void Start()
        {
            Stats();

            speciesArray[0] = "Bass";
            speciesArray[1] = "Tuna";
            speciesArray[2] = "Trout";
            speciesArray[3] = "Perch";
            speciesArray[4] = "Snapper";
            speciesArray[5] = "Cod";
            speciesArray[6] = "Shark";
        }
        private void Stats()
        {
            // The code below will randomly select a fish species from the list
            
            string randomSpecies = speciesArray[Random.Range(0, speciesArray.Length)];
            
            species = randomSpecies;
            
            length += Random.Range(1f, 100f);

            value += Random.Range(10, 100);
        }
    }
}
