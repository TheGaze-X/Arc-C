using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200251B RID: 9499
	[Token(Token = "0x200251B")]
	public class NextTargetsInSameMagicCircuitSelector : TargetSelector
	{
		// Token: 0x0600F516 RID: 62742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F516")]
		[Address(RVA = "0x6CB7F0", Offset = "0x6CA3F0", VA = "0x1806CB7F0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F517")]
		[Address(RVA = "0x6CBBB0", Offset = "0x6CA7B0", VA = "0x1806CBBB0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F518 RID: 62744 RVA: 0x0005AF18 File Offset: 0x00059118
		[Token(Token = "0x600F518")]
		[Address(RVA = "0x6CB780", Offset = "0x6CA380", VA = "0x1806CB780", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F519 RID: 62745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F519")]
		[Address(RVA = "0x6CBC20", Offset = "0x6CA820", VA = "0x1806CBC20")]
		public NextTargetsInSameMagicCircuitSelector()
		{
		}

		// Token: 0x04010FAA RID: 69546
		[Token(Token = "0x4010FAA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxTargetNum;

		// Token: 0x04010FAB RID: 69547
		[Token(Token = "0x4010FAB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _isBackward;

		// Token: 0x04010FAC RID: 69548
		[Token(Token = "0x4010FAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010FAD RID: 69549
		[Token(Token = "0x4010FAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010FAE RID: 69550
		[Token(Token = "0x4010FAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010FAF RID: 69551
		[Token(Token = "0x4010FAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
