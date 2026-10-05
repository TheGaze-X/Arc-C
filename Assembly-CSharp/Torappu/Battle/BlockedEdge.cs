using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200238C RID: 9100
	[Token(Token = "0x200238C")]
	public class BlockedEdge : VisualObject, IHotfixable
	{
		// Token: 0x0600E6CB RID: 59083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6CB")]
		[Address(RVA = "0x5B7480", Offset = "0x5B6080", VA = "0x1805B7480")]
		public void SetData(MapData.Edge data)
		{
		}

		// Token: 0x0600E6CC RID: 59084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6CC")]
		[Address(RVA = "0x5B7700", Offset = "0x5B6300", VA = "0x1805B7700")]
		private void _InitCollider()
		{
		}

		// Token: 0x0600E6CD RID: 59085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6CD")]
		[Address(RVA = "0x5B73B0", Offset = "0x5B5FB0", VA = "0x1805B73B0")]
		public void ClearGraphic()
		{
		}

		// Token: 0x0600E6CE RID: 59086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6CE")]
		[Address(RVA = "0x5B77C0", Offset = "0x5B63C0", VA = "0x1805B77C0")]
		public BlockedEdge()
		{
		}

		// Token: 0x0400FE23 RID: 65059
		[Token(Token = "0x400FE23")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MapData.Edge _data;

		// Token: 0x0400FE24 RID: 65060
		[Token(Token = "0x400FE24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteRenderer _sprite;

		// Token: 0x0400FE25 RID: 65061
		[Token(Token = "0x400FE25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400FE26 RID: 65062
		[Token(Token = "0x400FE26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitCollider;

		// Token: 0x0400FE27 RID: 65063
		[Token(Token = "0x400FE27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearGraphic;

		// Token: 0x0400FE28 RID: 65064
		[Token(Token = "0x400FE28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
