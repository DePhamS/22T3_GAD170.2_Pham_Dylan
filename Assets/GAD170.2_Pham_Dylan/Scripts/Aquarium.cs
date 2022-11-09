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
        private Fish smallestLength;
        private float totalValue;

        [SerializeField] private GameObject fishPrefab;
        private GameObject newFishStart;
        public Fish newFish;

        public int counter;

        //public TextMeshProUGUI counterText;

       // public void FixUpdate()
            //counterText.text = counter.ToString();

        private void Start()
        {
            AddFish();
        }

        public void KeepFishButton()
        {
            fish.Add(newFish);
            totalValue += newFish.value;

            AddFish();
            counter++;
            Debug.Log(counter);

            RoundCounter();
        }

        public void ReleaseButton()
        {
            Destroy(newFish.gameObject);

            AddFish();
            counter++;

            RoundCounter();
        }
        public void AddFish()
        {
            newFishStart = Instantiate(fishPrefab, transform);
            newFish = newFishStart.GetComponent<Fish>();
        }

        private void RoundCounter()
        {
            if (counter == 10)
            {
                SceneManager.LoadScene(2);
                Debug.Log("Game Over");
            }
        }
    }
}
