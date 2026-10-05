using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200481F RID: 18463
	[Token(Token = "0x200481F")]
	public class MonopolyEntryPage : StateEnginePage
	{
		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x0601BE9F RID: 114335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004251")]
		public string actId
		{
			[Token(Token = "0x601BE9F")]
			[Address(RVA = "0x1539410", Offset = "0x1538010", VA = "0x181539410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x0601BEA0 RID: 114336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004252")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601BEA0")]
			[Address(RVA = "0x1539470", Offset = "0x1538070", VA = "0x181539470")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BEA1 RID: 114337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEA1")]
		[Address(RVA = "0x15392A0", Offset = "0x1537EA0", VA = "0x1815392A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601BEA2 RID: 114338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEA2")]
		[Address(RVA = "0x15393B0", Offset = "0x1537FB0", VA = "0x1815393B0")]
		public MonopolyEntryPage()
		{
		}

		// Token: 0x0601BEA3 RID: 114339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEA3")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04024646 RID: 149062
		[Token(Token = "0x4024646")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04024647 RID: 149063
		[Token(Token = "0x4024647")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x04024648 RID: 149064
		[Token(Token = "0x4024648")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04024649 RID: 149065
		[Token(Token = "0x4024649")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0402464A RID: 149066
		[Token(Token = "0x402464A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0402464B RID: 149067
		[Token(Token = "0x402464B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402464C RID: 149068
		[Token(Token = "0x402464C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004820 RID: 18464
		[Token(Token = "0x2004820")]
		public class Input
		{
			// Token: 0x0601BEA4 RID: 114340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEA4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402464D RID: 149069
			[Token(Token = "0x402464D")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
