using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D3E RID: 15678
	[Token(Token = "0x2003D3E")]
	public class TemplateShopEmptyState : State
	{
		// Token: 0x060186C5 RID: 100037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186C5")]
		[Address(RVA = "0x10F1E10", Offset = "0x10F0A10", VA = "0x1810F1E10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060186C6 RID: 100038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186C6")]
		[Address(RVA = "0x10F20F0", Offset = "0x10F0CF0", VA = "0x1810F20F0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060186C7 RID: 100039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C7")]
		[Address(RVA = "0x10F2450", Offset = "0x10F1050", VA = "0x1810F2450")]
		private void _ToListState(IStateBean stateBean)
		{
		}

		// Token: 0x060186C8 RID: 100040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C8")]
		[Address(RVA = "0x10F2540", Offset = "0x10F1140", VA = "0x1810F2540")]
		private void _ToRarityState(IStateBean stateBean)
		{
		}

		// Token: 0x060186C9 RID: 100041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186C9")]
		[Address(RVA = "0x10F1E70", Offset = "0x10F0A70", VA = "0x1810F1E70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060186CA RID: 100042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186CA")]
		[Address(RVA = "0x10F2630", Offset = "0x10F1230", VA = "0x1810F2630")]
		public TemplateShopEmptyState()
		{
		}

		// Token: 0x060186CC RID: 100044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186CC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060186CD RID: 100045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186CD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DE16 RID: 122390
		[Token(Token = "0x401DE16")]
		[FieldOffset(Offset = "0x50")]
		private TemplateCommonShopStateBean m_stateBean;

		// Token: 0x0401DE17 RID: 122391
		[Token(Token = "0x401DE17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DE18 RID: 122392
		[Token(Token = "0x401DE18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401DE19 RID: 122393
		[Token(Token = "0x401DE19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ToListState;

		// Token: 0x0401DE1A RID: 122394
		[Token(Token = "0x401DE1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ToRarityState;

		// Token: 0x0401DE1B RID: 122395
		[Token(Token = "0x401DE1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DE1C RID: 122396
		[Token(Token = "0x401DE1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
