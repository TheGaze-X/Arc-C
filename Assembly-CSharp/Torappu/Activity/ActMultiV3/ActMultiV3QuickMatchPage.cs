using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F99 RID: 28569
	[Token(Token = "0x2006F99")]
	public class ActMultiV3QuickMatchPage : StateEnginePage
	{
		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x060288C0 RID: 166080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060288C1 RID: 166081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F97")]
		public string actId
		{
			[Token(Token = "0x60288C0")]
			[Address(RVA = "0x23E5A20", Offset = "0x23E4620", VA = "0x1823E5A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60288C1")]
			[Address(RVA = "0x23E5AE0", Offset = "0x23E46E0", VA = "0x1823E5AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x060288C2 RID: 166082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F98")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x60288C2")]
			[Address(RVA = "0x23E5A80", Offset = "0x23E4680", VA = "0x1823E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060288C3 RID: 166083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288C3")]
		[Address(RVA = "0x23E5890", Offset = "0x23E4490", VA = "0x1823E5890", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060288C4 RID: 166084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288C4")]
		[Address(RVA = "0x23E57D0", Offset = "0x23E43D0", VA = "0x1823E57D0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060288C5 RID: 166085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288C5")]
		[Address(RVA = "0x23E56F0", Offset = "0x23E42F0", VA = "0x1823E56F0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isFromStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060288C6 RID: 166086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288C6")]
		[Address(RVA = "0x23E59C0", Offset = "0x23E45C0", VA = "0x1823E59C0")]
		public ActMultiV3QuickMatchPage()
		{
		}

		// Token: 0x060288C7 RID: 166087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288C7")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x060288C8 RID: 166088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288C8")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x060288C9 RID: 166089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288C9")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04039BFD RID: 236541
		[Token(Token = "0x4039BFD")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x04039BFE RID: 236542
		[Token(Token = "0x4039BFE")]
		[FieldOffset(Offset = "0xF8")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x04039C00 RID: 236544
		[Token(Token = "0x4039C00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039C01 RID: 236545
		[Token(Token = "0x4039C01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039C02 RID: 236546
		[Token(Token = "0x4039C02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x04039C03 RID: 236547
		[Token(Token = "0x4039C03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04039C04 RID: 236548
		[Token(Token = "0x4039C04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04039C05 RID: 236549
		[Token(Token = "0x4039C05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04039C06 RID: 236550
		[Token(Token = "0x4039C06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F9A RID: 28570
		[Token(Token = "0x2006F9A")]
		public class Params
		{
			// Token: 0x060288CA RID: 166090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04039C07 RID: 236551
			[Token(Token = "0x4039C07")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
