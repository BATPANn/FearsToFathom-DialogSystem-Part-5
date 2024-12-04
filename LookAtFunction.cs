using UnityEngine;

public class LookAtFunction : MonoBehaviour
{
    

    public Animator animator;

    public Animator RedManeqAnimator;

    public bool IKActive = false;

    public Transform LookAtObj = null;

    public float LookWeight = 0f;


    public CamInteractFearsToFathom CamInteract;


    private void OnAnimatorIK(int layerIndex)
    {


        if (this.gameObject.GetComponent<Animator>())
        {


            if(IKActive)
            {


                if (LookAtObj != null)
                {

                    LookWeight = Mathf.Lerp(LookWeight, 1, Time.deltaTime * 2);

                    


                }



            }
            else
            {

                LookWeight = Mathf.Lerp(LookWeight, 0, Time.deltaTime * 2);

                


            }



            if(CamInteract.TalkToActualManeq == true)
            {

                animator.SetLookAtWeight(LookWeight);
                animator.SetLookAtPosition(LookAtObj.position);


            }
            else if(CamInteract.TalkToRedManeq == true)
            {

                RedManeqAnimator.SetLookAtWeight(LookWeight);
                RedManeqAnimator.SetLookAtPosition(LookAtObj.position);


            }

            



        }

        



    }




}
