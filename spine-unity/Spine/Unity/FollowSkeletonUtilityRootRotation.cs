using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class FollowSkeletonUtilityRootRotation : MonoBehaviour
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x4E8E920", Offset = "0x4E8D520", VA = "0x184E8E920")]
		private void Start()
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x4E8E5B0", Offset = "0x4E8D1B0", VA = "0x184E8E5B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x4E8E470", Offset = "0x4E8D070", VA = "0x184E8E470")]
		private void CompensatePositionToYRotation()
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x4E8E330", Offset = "0x4E8CF30", VA = "0x184E8E330")]
		private void CompensatePositionToXRotation()
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FollowSkeletonUtilityRootRotation()
		{
		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		private const float FLIP_ANGLE_THRESHOLD = 100f;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x18")]
		public Transform reference;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 prevLocalEulerAngles;
	}
}
