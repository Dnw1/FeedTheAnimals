using UnityEngine;
using System.Collections;
using Spine.Unity;

public class GController : MonoBehaviour
{
    // [SpineAnimation] attribute allows an Inspector dropdown of Spine animation names coming form SkeletonAnimation.
    [SpineAnimation]
    public string idleAnimationName;

    [SpineAnimation]
    public string walkAnimationName;

    SkeletonAnimation skeletonAnimation;

    // Spine.AnimationState and Spine.Skeleton are not Unity-serialized objects. You will not see them as fields in the inspector.
    public Spine.AnimationState spineAnimationState;
    public Spine.Skeleton skeleton;

    void Start()
    {
        // Make sure you get these AnimationState and Skeleton references in Start or Later. Getting and using them in Awake is not guaranteed by default execution order.
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        spineAnimationState = skeletonAnimation.AnimationState;
        skeleton = skeletonAnimation.Skeleton;

        //StartCoroutine(Demo());
    }

    /*
    IEnumerator Demo()
    {
        spineAnimationState.SetAnimation(0, walkAnimationName, true);
        yield return new WaitForSeconds(1.5f);

        //spineAnimationState.SetAnimation(0, runAnimationName, true);
        //yield return new WaitForSeconds(1.5f);
    }*/
}
