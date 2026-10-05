using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class ActivateBasedOnFlipDirection : MonoBehaviour
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x4E8D230", Offset = "0x4E8BE30", VA = "0x184E8D230")]
		private void Start()
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4E8CEA0", Offset = "0x4E8BAA0", VA = "0x184E8CEA0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4E8CF20", Offset = "0x4E8BB20", VA = "0x184E8CF20")]
		private void HandleFlip(bool isFlippedX)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x4E8D100", Offset = "0x4E8BD00", VA = "0x184E8D100")]
		private void ResetJointPositions(HingeJoint2D[] joints)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4E8CD60", Offset = "0x4E8B960", VA = "0x184E8CD60")]
		private void CompensateMovementAfterFlipX(Transform toActivate, Transform toDeactivate)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ActivateBasedOnFlipDirection()
		{
		}

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x18")]
		public SkeletonRenderer skeletonRenderer;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x20")]
		public SkeletonGraphic skeletonGraphic;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject activeOnNormalX;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject activeOnFlippedX;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x38")]
		private HingeJoint2D[] jointsNormalX;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x40")]
		private HingeJoint2D[] jointsFlippedX;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x48")]
		private ISkeletonComponent skeletonComponent;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x50")]
		private bool wasFlippedXBefore;
	}
}
