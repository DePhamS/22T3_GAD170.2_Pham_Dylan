using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace DylanPham
{
    public class Aquarium : MonoBehaviour
    {
        [SerializeField] List<Fish> fish = new List<Fish>();
        public float totalValue;

        [SerializeField] private GameObject fishPrefab;
        private GameObject newFishStart;
        public bool fishRemove = false;
        public Fish newFish;
        public GameObject activeGameUI;
        public GameObject gameOverUI;
        public int counter;

        

        private void Start()
        {
            AddFish();
        }

        public void KeepFishButton() //Coded myself
        {
            fishRemove = false;
            for (int i = 0; i < fish.Count; i++)
            {
                // Checking if the newFish length is 2x bigger than any fish in the list 

                if (newFish.length >= fish[i].length * 2 && fishRemove == false) 
                {
                    Destroy(newFish.gameObject);
                    Debug.Log("Fish has been EATEN!");
                    totalValue -= fish[i].value;
                    fish.Remove(fish[i]);

                    fishRemove = true;
                }
            }
            fish.Add(newFish); // adds the fish into the list
            totalValue += newFish.value;

            AddFish();
            counter++;
            Debug.Log(counter);

            RoundCounter();
        }

        public void ReleaseButton() // Luka coded this
        {
            Destroy(newFish.gameObject); // this would remove the instantiated stats

            AddFish();
            counter++;
            Debug.Log(counter);

            RoundCounter();
        }
        public void AddFish() //Coded myself
        {
            // This would create an instantiated fish prefrab and be assigned to newFish

            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();
        }

        private void RoundCounter() // Yovan coded this
        {
            if (counter == 10) // if the counter reaches 10, it'll overlay the gameOverUI
            {
                activeGameUI.SetActive(false);
                gameOverUI.SetActive(true);
                Debug.Log("Game Over");
            }
        }
    }
}
