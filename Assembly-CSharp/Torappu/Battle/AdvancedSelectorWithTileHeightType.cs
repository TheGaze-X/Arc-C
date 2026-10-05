using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F9 RID: 9465
	[Token(Token = "0x20024F9")]
	public class AdvancedSelectorWithTileHeightType : AdvancedSelector
	{
		// Token: 0x0600F3CA RID: 62410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3CA")]
		[Address(RVA = "0x6A1900", Offset = "0x6A0500", VA = "0x1806A1900", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3CB")]
		[Address(RVA = "0x6A1AB0", Offset = "0x6A06B0", VA = "0x1806A1AB0")]
		public AdvancedSelectorWithTileHeightType()
		{
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3CC")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DF9 RID: 69113
		[Token(Token = "0x4010DF9")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TileData.HeightType _heightType;

		// Token: 0x04010DFA RID: 69114
		[Token(Token = "0x4010DFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DFB RID: 69115
		[Token(Token = "0x4010DFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
