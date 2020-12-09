using UnityEngine;

namespace Michsky.UI.ModernUIPack
{
    public class ModalWindowManager : MonoBehaviour
    {
        public bool IsStartOpen = false;
        private Animator mwAnimator;

        void Start()
        {
            mwAnimator = gameObject.GetComponent<Animator>();
            if (IsStartOpen)
            {
                OpenWindow();
            }
        }

        public void OpenWindow()
        {
            mwAnimator.Play("Fade-in");
        }

        public void CloseWindow()
        {
            mwAnimator.Play("Fade-out");
        }
    }
}