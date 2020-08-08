using System.Collections.Generic;
using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class Deck : MonoBehaviour
    {
        #region VARIABLES

        public Sprite[] PlaycardSprites;
        public Playcard PlaycardPrefab;
        private List<Playcard> playcards = new List<Playcard>();
        private Transform cardContainer;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            cardContainer = transform.GetChild(0);
        }

        private void Start()
        {
            CreateCards();
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        private void CreateCards()
        {
            Playcard playcard = null;

            for(int i = 0; i < PlaycardSprites.Length; i++)
            {
                playcard = Instantiate(PlaycardPrefab, transform.position, Quaternion.identity, cardContainer);
                playcard.Initialize(PlaycardSprites[i]);
                playcards.Add(playcard);
            }
        }

        #endregion CUSTOM_FUNCTIONS
    }
}
