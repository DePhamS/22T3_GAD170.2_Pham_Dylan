using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class FishStats : MonoBehaviour
    {
        public string species;
        public float length = 0f;
        public int value;

        public FishStats(string newSpecies, float newLength, int newValue)
        {
            species = newSpecies;
            length = newLength;
            value = newValue;
        }
        
        void Start()
        {
            Stats();
        }
        private void Stats()
        {
            // The code below will randomly select a fish species from the list

            string[] species = new string[] { "Bass", "Tuna", "Trout", "Perch", "Snapper", "Cod", "Shark" };
            string randomSpecies = species[Random.Range(0, species.Length)];
            Debug.Log(randomSpecies);


            
            length += Random.Range(10f, 50f);

            value += Random.Range(10, 100);
        }
    }
}
