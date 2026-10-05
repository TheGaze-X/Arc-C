using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[RequireComponent(typeof(Rigidbody2D))]
	public class FollowLocationRigidbody2D : MonoBehaviour
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x4E8E000", Offset = "0x4E8CC00", VA = "0x184E8E000")]
		private void Awake()
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4E8E050", Offset = "0x4E8CC50", VA = "0x184E8E050")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FollowLocationRigidbody2D()
		{
		}

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x18")]
		public Transform reference;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x20")]
		public bool followFlippedX;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody2D ownRigidbody;
	}
}
