using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[RequireComponent(typeof(Rigidbody))]
	public class FollowLocationRigidbody : MonoBehaviour
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4E8E240", Offset = "0x4E8CE40", VA = "0x184E8E240")]
		private void Awake()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x4E8E290", Offset = "0x4E8CE90", VA = "0x184E8E290")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FollowLocationRigidbody()
		{
		}

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x18")]
		public Transform reference;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x20")]
		private Rigidbody ownRigidbody;
	}
}
