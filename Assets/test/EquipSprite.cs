using Spine;
using Spine.Unity;
using UnityEngine;

public class EquipSprite : MonoBehaviour
{
    public SkeletonAnimation skeletonAnimation; // Reference to the SkeletonAnimation component.
    public string slotName; // The name of the slot where you want to change the attachment.
    public string attachmentName; // The name of the attachment you want to set.

    void Start()
    {
        Equip();
    }

    public void Equip()
    {
        // Get the skeleton from the SkeletonAnimation component.
        var skeleton = skeletonAnimation.skeleton;

        // Find the slot in the skeleton.
        var slot = skeleton.FindSlot(slotName);

        // Assuming the attachment is a region attachment and is already in the atlas.
        var attachment = skeleton.GetAttachment(slotName, attachmentName) as RegionAttachment;

        // Set the attachment for the slot.
        if (attachment != null)
        {
            slot.Attachment = attachment;
        }
        else
        {
            Debug.LogError("Attachment not found: " + attachmentName);
        }
    }
}
