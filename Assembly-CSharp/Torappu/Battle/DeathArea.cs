using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002263 RID: 8803
	[Token(Token = "0x2002263")]
	public class DeathArea : MonoBehaviour
	{
		// Token: 0x0600DD57 RID: 56663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD57")]
		[Address(RVA = "0x3630220", Offset = "0x362EE20", VA = "0x183630220")]
		public void UpdateToMatch(Map map)
		{
		}

		// Token: 0x0600DD58 RID: 56664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD58")]
		[Address(RVA = "0x36301B0", Offset = "0x362EDB0", VA = "0x1836301B0")]
		[Inspect]
		public void RecalculateSize()
		{
		}

		// Token: 0x0600DD59 RID: 56665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD59")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DeathArea()
		{
		}

		// Token: 0x0400EFC7 RID: 61383
		[Token(Token = "0x400EFC7")]
		private const int EXTEND_LENGTH = 2;

		// Token: 0x0400EFC8 RID: 61384
		[Token(Token = "0x400EFC8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BoxCollider2D _up;

		// Token: 0x0400EFC9 RID: 61385
		[Token(Token = "0x400EFC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoxCollider2D _down;

		// Token: 0x0400EFCA RID: 61386
		[Token(Token = "0x400EFCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BoxCollider2D _left;

		// Token: 0x0400EFCB RID: 61387
		[Token(Token = "0x400EFCB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BoxCollider2D _right;
	}
}
