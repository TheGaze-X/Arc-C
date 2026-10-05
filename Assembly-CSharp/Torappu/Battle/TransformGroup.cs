using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200266C RID: 9836
	[Token(Token = "0x200266C")]
	public class TransformGroup : MonoBehaviour
	{
		// Token: 0x06010165 RID: 65893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010165")]
		[Address(RVA = "0x7D32C0", Offset = "0x7D1EC0", VA = "0x1807D32C0")]
		public Transform PickTransform()
		{
			return null;
		}

		// Token: 0x06010166 RID: 65894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010166")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public TransformGroup()
		{
		}

		// Token: 0x04011E50 RID: 73296
		[Token(Token = "0x4011E50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] _transforms;
	}
}
