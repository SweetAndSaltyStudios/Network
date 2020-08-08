using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sweet_And_Salty_Studios
{
    public class Playcard : Interactable
    {
        #region VARIABLES

        private Vector2 dragOffset;
        private Vector2 defaultScale;
        private Vector2 activeScale = new Vector2(1.1f, 1.1f);

        private Image cardImage;

        //public Sprite CardFront, CardBack;

        //private Transform model;

        //private Image modelImage;
        //private Transform modelContent;
        //private TextMeshProUGUI titleText;
        //private TextMeshProUGUI typeText;
        //private TextMeshProUGUI additionalInfoText;
        //private TMP_InputField abilitiesTextBox;
        //private RectTransform placeholder;

        #endregion VARIABLES

        #region PROPERTIES

        //public Transform OriginalParent
        //{
        //    get; set;
        //}
        //public Transform PlaceholderParent
        //{
        //    get; set;
        //}

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            cardImage = GetComponentInChildren<Image>();
        }

        private void Start()
        {
            defaultScale = transform.localScale;
            //defaultColor = modelImage.color;
            //titleText.text = gameObject.name;
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        public void Initialize(Sprite cardSprite)
        {
            cardImage.sprite = cardSprite;

            //model = transform.Find("Model");
            //modelImage = model.GetComponent<Image>();
            //modelContent = model.Find("ModelContent");
            //titleText = modelContent.Find("TitleText").GetComponentInChildren<TextMeshProUGUI>();
            //typeText = modelContent.Find("TypeText").GetComponentInChildren<TextMeshProUGUI>();
            //additionalInfoText = modelContent.Find("AdditionalInfoText").GetComponentInChildren<TextMeshProUGUI>();
            //abilitiesTextBox = modelContent.Find("AbilitiesTextBox").GetComponentInChildren<TMP_InputField>();
        }

        private void ToggleFace()
        {
            //if(modelImage.sprite == CardFront)
            //{
            //    modelContent.gameObject.SetActive(false);
            //    modelImage.sprite = CardBack;


            //}
            //else
            //{
            //    modelContent.gameObject.SetActive(true);
            //    modelImage.sprite = CardFront;
            //}
        }

        public override void OnBeginDrag(PointerEventData eventData)
        {
            //modelImage.raycastTarget = false;

            dragOffset = (Vector2)transform.position - eventData.position;

            //placeholder = Instantiate(LevelManager.Instance.CardPlaceholderPrefab, transform.parent).GetComponent<RectTransform>();
            //placeholder.name = "Placeholder";
            //placeholder.SetParent(transform.parent);

            //placeholder.SetSiblingIndex(transform.GetSiblingIndex());

            //OriginalParent = transform.parent;

            //PlaceholderParent = OriginalParent;

            //transform.SetParent(transform.parent.parent);
        }

        public override void OnCancel(BaseEventData eventData)
        {

        }

        public override void OnDeselect(BaseEventData eventData)
        {

        }

        public override void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position + dragOffset;

            //if(placeholder.transform.parent != PlaceholderParent)
            //    placeholder.transform.SetParent(PlaceholderParent);

            //var newSiblingIndex = PlaceholderParent.childCount;

            //for(int i = 0; i < PlaceholderParent.childCount; i++)
            //{
            //    if(transform.position.x < PlaceholderParent.GetChild(i).position.x)
            //    {
            //        newSiblingIndex = i;

            //        if(placeholder.transform.GetSiblingIndex() < newSiblingIndex)
            //            newSiblingIndex--;

            //        break;
            //    }
            //}

            //placeholder.SetSiblingIndex(newSiblingIndex);
        }

        public override void OnDrop(PointerEventData eventData)
        {

        }

        public override void OnEndDrag(PointerEventData eventData)
        {
            //modelImage.raycastTarget = true;

            //transform.SetParent(OriginalParent);
            //transform.SetSiblingIndex(placeholder.GetSiblingIndex());

            //Destroy(placeholder.gameObject);
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);

            transform.localScale = activeScale;
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);

            transform.localScale = defaultScale;
        }
    }
    #endregion CUSTOM_FUNCTIONS
}
