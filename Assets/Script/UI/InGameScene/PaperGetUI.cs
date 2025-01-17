﻿using System.Collections;
using UnityEngine;

namespace NHD.UI.InGameScene
{
    public class PaperGetUI : MonoBehaviour
    {
        [SerializeField]
        private Animator anim;
        [SerializeField]
        private float animationTime;
        WaitForSeconds seconds;

        private void Start()
        {
            seconds = new WaitForSeconds(animationTime);
        }

        public void PaperGet()
        {
            anim.SetTrigger("Get");
            StartCoroutine(AfterPopup());
        }

        IEnumerator AfterPopup()
        {
            yield return seconds;

            anim.SetTrigger("Close");

        }
    }
}