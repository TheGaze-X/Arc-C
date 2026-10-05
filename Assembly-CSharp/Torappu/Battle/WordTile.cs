using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023B3 RID: 9139
	[Token(Token = "0x20023B3")]
	public class WordTile : Tile
	{
		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600E854 RID: 59476 RVA: 0x00054C78 File Offset: 0x00052E78
		[Token(Token = "0x17001D4E")]
		public bool isNonebuildableLike
		{
			[Token(Token = "0x600E854")]
			[Address(RVA = "0x5E9F40", Offset = "0x5E8B40", VA = "0x1805E9F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E855 RID: 59477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E855")]
		[Address(RVA = "0x5E9E60", Offset = "0x5E8A60", VA = "0x1805E9E60")]
		public void SetManager(Act49SidePrintingManager manager)
		{
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x00054C90 File Offset: 0x00052E90
		[Token(Token = "0x17001D4F")]
		public override int moveCost
		{
			[Token(Token = "0x600E856")]
			[Address(RVA = "0x5E9FA0", Offset = "0x5E8BA0", VA = "0x1805E9FA0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E857 RID: 59479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E857")]
		[Address(RVA = "0x5E9EE0", Offset = "0x5E8AE0", VA = "0x1805E9EE0")]
		public WordTile()
		{
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x00054CA8 File Offset: 0x00052EA8
		[Token(Token = "0x600E858")]
		[Address(RVA = "0x5D2B60", Offset = "0x5D1760", VA = "0x1805D2B60")]
		private int <>xLuaBaseProxy_get_moveCost()
		{
			return 0;
		}

		// Token: 0x0400FFEE RID: 65518
		[Token(Token = "0x400FFEE")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private bool _isNonebuildableLike;

		// Token: 0x0400FFEF RID: 65519
		[Token(Token = "0x400FFEF")]
		[FieldOffset(Offset = "0x130")]
		private Act49SidePrintingManager m_manager;

		// Token: 0x0400FFF0 RID: 65520
		[Token(Token = "0x400FFF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isNonebuildableLike;

		// Token: 0x0400FFF1 RID: 65521
		[Token(Token = "0x400FFF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetManager;

		// Token: 0x0400FFF2 RID: 65522
		[Token(Token = "0x400FFF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_moveCost;

		// Token: 0x0400FFF3 RID: 65523
		[Token(Token = "0x400FFF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
