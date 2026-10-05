using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherEvolve
{
	// Token: 0x02003B9A RID: 15258
	[Token(Token = "0x2003B9A")]
	public class VoucherEvolvePage : StateEnginePage
	{
		// Token: 0x06017E72 RID: 97906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E72")]
		[Address(RVA = "0x10769A0", Offset = "0x10755A0", VA = "0x1810769A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E73")]
		[Address(RVA = "0x1076BE0", Offset = "0x10757E0", VA = "0x181076BE0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06017E74 RID: 97908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E74")]
		[Address(RVA = "0x1076A80", Offset = "0x1075680", VA = "0x181076A80")]
		private void _ReturnPage()
		{
		}

		// Token: 0x06017E75 RID: 97909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E75")]
		[Address(RVA = "0x1076D10", Offset = "0x1075910", VA = "0x181076D10")]
		public VoucherEvolvePage()
		{
		}

		// Token: 0x06017E77 RID: 97911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E77")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401CE96 RID: 118422
		[Token(Token = "0x401CE96")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401CE97 RID: 118423
		[Token(Token = "0x401CE97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401CE98 RID: 118424
		[Token(Token = "0x401CE98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401CE99 RID: 118425
		[Token(Token = "0x401CE99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x0401CE9A RID: 118426
		[Token(Token = "0x401CE9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B9B RID: 15259
		[Token(Token = "0x2003B9B")]
		public class Params
		{
			// Token: 0x06017E78 RID: 97912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017E78")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0401CE9B RID: 118427
			[Token(Token = "0x401CE9B")]
			[FieldOffset(Offset = "0x10")]
			public CharacterCardViewModel charViewModel;

			// Token: 0x0401CE9C RID: 118428
			[Token(Token = "0x401CE9C")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel itemViewModel;

			// Token: 0x0401CE9D RID: 118429
			[Token(Token = "0x401CE9D")]
			[FieldOffset(Offset = "0x20")]
			public EvolvePhase targetEvolvePhase;
		}
	}
}
