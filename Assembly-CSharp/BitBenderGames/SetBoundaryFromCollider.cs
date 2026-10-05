using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	[RequireComponent(typeof(MobileTouchCamera))]
	public class SetBoundaryFromCollider : MonoBehaviour
	{
		// Token: 0x06004B2D RID: 19245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x1693E20", Offset = "0x1692A20", VA = "0x181693E20")]
		public void Start()
		{
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SetBoundaryFromCollider()
		{
		}

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BoxCollider boxCollider;
	}
}
