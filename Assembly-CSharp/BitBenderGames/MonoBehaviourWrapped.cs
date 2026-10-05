using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public class MonoBehaviourWrapped : MonoBehaviour
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public Transform Transform
		{
			[Token(Token = "0x6004B11")]
			[Address(RVA = "0x1692FC0", Offset = "0x1691BC0", VA = "0x181692FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06004B12 RID: 19218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B6")]
		public GameObject GameObject
		{
			[Token(Token = "0x6004B12")]
			[Address(RVA = "0x1692F30", Offset = "0x1691B30", VA = "0x181692F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B13")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MonoBehaviourWrapped()
		{
		}

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x18")]
		protected Transform cachedTransform;

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x20")]
		protected GameObject cachedGO;
	}
}
