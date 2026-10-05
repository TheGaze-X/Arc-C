using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002274 RID: 8820
	[Token(Token = "0x2002274")]
	public class RandomTileWithExtraRangeGlobalBuff : RandomTileGlobalBuff
	{
		// Token: 0x0600DDDD RID: 56797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDDD")]
		[Address(RVA = "0x363DC90", Offset = "0x363C890", VA = "0x18363DC90", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDDE RID: 56798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDDE")]
		[Address(RVA = "0x363DDA0", Offset = "0x363C9A0", VA = "0x18363DDA0", Slot = "17")]
		protected override List<GridPosition> SelectTiles(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DDDF RID: 56799 RVA: 0x00050E68 File Offset: 0x0004F068
		[Token(Token = "0x600DDDF")]
		[Address(RVA = "0x363DFB0", Offset = "0x363CBB0", VA = "0x18363DFB0")]
		private bool _CheckExtraPosValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600DDE0 RID: 56800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE0")]
		[Address(RVA = "0x363E0A0", Offset = "0x363CCA0", VA = "0x18363E0A0")]
		public RandomTileWithExtraRangeGlobalBuff()
		{
		}

		// Token: 0x0600DDE1 RID: 56801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE1")]
		[Address(RVA = "0x362D9B0", Offset = "0x362C5B0", VA = "0x18362D9B0")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DDE2 RID: 56802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDE2")]
		[Address(RVA = "0x363DFA0", Offset = "0x363CBA0", VA = "0x18363DFA0")]
		private List<GridPosition> <>xLuaBaseProxy_SelectTiles(bool P0)
		{
			return null;
		}

		// Token: 0x0400F091 RID: 61585
		[Token(Token = "0x400F091")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("BindingTile")]
		private RandomTileWithExtraRangeGlobalBuff.ExtraRangeID _extraRangeID;

		// Token: 0x0400F092 RID: 61586
		[Token(Token = "0x400F092")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("BindingTile")]
		private string _centerTileEffect;

		// Token: 0x0400F093 RID: 61587
		[Token(Token = "0x400F093")]
		[FieldOffset(Offset = "0x180")]
		private GridPosition m_Center;

		// Token: 0x0400F094 RID: 61588
		[Token(Token = "0x400F094")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F095 RID: 61589
		[Token(Token = "0x400F095")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectTiles;

		// Token: 0x0400F096 RID: 61590
		[Token(Token = "0x400F096")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckExtraPosValid;

		// Token: 0x0400F097 RID: 61591
		[Token(Token = "0x400F097")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002275 RID: 8821
		[Token(Token = "0x2002275")]
		private enum ExtraRangeID
		{
			// Token: 0x0400F099 RID: 61593
			[Token(Token = "0x400F099")]
			X_4
		}
	}
}
