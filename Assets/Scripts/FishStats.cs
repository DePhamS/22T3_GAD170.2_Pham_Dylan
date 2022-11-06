using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class FishStats : MonoBehaviour
    {
        public string species;
        public float lenght;
        public int cost;

        public FishStats(string newSpecies, float newLenght, int newCost)
        {
            species = newSpecies;
            lenght = newLenght;
            cost = newCost;
        }
    }
}
