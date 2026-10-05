using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.HandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EBC RID: 24252
	[Token(Token = "0x2005EBC")]
	public class CharacterInfoPage : StateEnginePage
	{
		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x060231DF RID: 143839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060231E0 RID: 143840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005327")]
		public HandBookJumpParam jumpParam
		{
			[Token(Token = "0x60231DF")]
			[Address(RVA = "0x1DAC9F0", Offset = "0x1DAB5F0", VA = "0x181DAC9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60231E0")]
			[Address(RVA = "0x1DACA50", Offset = "0x1DAB650", VA = "0x181DACA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x060231E1 RID: 143841 RVA: 0x000BFF58 File Offset: 0x000BE158
		[Token(Token = "0x17005328")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x60231E1")]
			[Address(RVA = "0x1DAC990", Offset = "0x1DAB590", VA = "0x181DAC990", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x060231E2 RID: 143842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E2")]
		[Address(RVA = "0x1DAC320", Offset = "0x1DAAF20", VA = "0x181DAC320")]
		public void SetTopMenuActive(bool value)
		{
		}

		// Token: 0x060231E3 RID: 143843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231E3")]
		[Address(RVA = "0x1DABEA0", Offset = "0x1DAAAA0", VA = "0x181DABEA0")]
		public ICharInfoHomeInitParam GetCharInitHomeParam()
		{
			return null;
		}

		// Token: 0x060231E4 RID: 143844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E4")]
		[Address(RVA = "0x1DAC3B0", Offset = "0x1DAAFB0", VA = "0x181DAC3B0")]
		public void ShowTokenInfoPanel(CharTokenViewModel charTokenViewModel)
		{
		}

		// Token: 0x060231E5 RID: 143845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E5")]
		[Address(RVA = "0x1DAC590", Offset = "0x1DAB190", VA = "0x181DAC590")]
		private void _ReturnPage()
		{
		}

		// Token: 0x060231E6 RID: 143846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E6")]
		[Address(RVA = "0x1DABFB0", Offset = "0x1DAABB0", VA = "0x181DABFB0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060231E7 RID: 143847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231E7")]
		[Address(RVA = "0x1DABF00", Offset = "0x1DAAB00", VA = "0x181DABF00", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060231E8 RID: 143848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E8")]
		[Address(RVA = "0x1DAC2B0", Offset = "0x1DAAEB0", VA = "0x181DAC2B0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x060231E9 RID: 143849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231E9")]
		[Address(RVA = "0x1DAC800", Offset = "0x1DAB400", VA = "0x181DAC800")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x060231EA RID: 143850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231EA")]
		[Address(RVA = "0x1DAC6F0", Offset = "0x1DAB2F0", VA = "0x181DAC6F0")]
		private void _InitTokenPanelIfNot()
		{
		}

		// Token: 0x060231EB RID: 143851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231EB")]
		[Address(RVA = "0x1DAC930", Offset = "0x1DAB530", VA = "0x181DAC930")]
		public CharacterInfoPage()
		{
		}

		// Token: 0x060231EE RID: 143854 RVA: 0x000BFF70 File Offset: 0x000BE170
		[Token(Token = "0x60231EE")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x060231EF RID: 143855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231EF")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x060231F0 RID: 143856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231F0")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231F1")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x04030696 RID: 198294
		[Token(Token = "0x4030696")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04030697 RID: 198295
		[Token(Token = "0x4030697")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CharacterTokenDetailView _tokenDetailView;

		// Token: 0x04030698 RID: 198296
		[Token(Token = "0x4030698")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _tokenViewContainer;

		// Token: 0x04030699 RID: 198297
		[Token(Token = "0x4030699")]
		[FieldOffset(Offset = "0x108")]
		private CharacterTokenDetailView m_tokenDetailView;

		// Token: 0x0403069A RID: 198298
		[Token(Token = "0x403069A")]
		[FieldOffset(Offset = "0x110")]
		private ICharInfoHomeInitParam m_initHomeParamCache;

		// Token: 0x0403069B RID: 198299
		[Token(Token = "0x403069B")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isTokenPanelInited;

		// Token: 0x0403069D RID: 198301
		[Token(Token = "0x403069D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpParam;

		// Token: 0x0403069E RID: 198302
		[Token(Token = "0x403069E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_jumpParam;

		// Token: 0x0403069F RID: 198303
		[Token(Token = "0x403069F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x040306A0 RID: 198304
		[Token(Token = "0x40306A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetTopMenuActive;

		// Token: 0x040306A1 RID: 198305
		[Token(Token = "0x40306A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCharInitHomeParam;

		// Token: 0x040306A2 RID: 198306
		[Token(Token = "0x40306A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowTokenInfoPanel;

		// Token: 0x040306A3 RID: 198307
		[Token(Token = "0x40306A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x040306A4 RID: 198308
		[Token(Token = "0x40306A4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040306A5 RID: 198309
		[Token(Token = "0x40306A5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040306A6 RID: 198310
		[Token(Token = "0x40306A6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x040306A7 RID: 198311
		[Token(Token = "0x40306A7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040306A8 RID: 198312
		[Token(Token = "0x40306A8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitTokenPanelIfNot;

		// Token: 0x040306A9 RID: 198313
		[Token(Token = "0x40306A9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EBD RID: 24253
		[Token(Token = "0x2005EBD")]
		public enum RouteTarget
		{
			// Token: 0x040306AB RID: 198315
			[Token(Token = "0x40306AB")]
			NONE,
			// Token: 0x040306AC RID: 198316
			[Token(Token = "0x40306AC")]
			POTENTIAL,
			// Token: 0x040306AD RID: 198317
			[Token(Token = "0x40306AD")]
			UNIEQUIP
		}

		// Token: 0x02005EBE RID: 24254
		[Token(Token = "0x2005EBE")]
		public struct Params : ICharInfoHomeInitParam, IHotfixable
		{
			// Token: 0x060231F2 RID: 143858 RVA: 0x000BFF88 File Offset: 0x000BE188
			[Token(Token = "0x60231F2")]
			[Address(RVA = "0x1DB8A00", Offset = "0x1DB7600", VA = "0x181DB8A00", Slot = "4")]
			public int GetCharInstId()
			{
				return 0;
			}

			// Token: 0x060231F3 RID: 143859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60231F3")]
			[Address(RVA = "0x1DB8A70", Offset = "0x1DB7670", VA = "0x181DB8A70", Slot = "5")]
			public List<int> GetCharList()
			{
				return null;
			}

			// Token: 0x060231F4 RID: 143860 RVA: 0x000BFFA0 File Offset: 0x000BE1A0
			[Token(Token = "0x60231F4")]
			[Address(RVA = "0x1DB8C00", Offset = "0x1DB7800", VA = "0x181DB8C00", Slot = "6")]
			public bool IsFromHandbook()
			{
				return default(bool);
			}

			// Token: 0x060231F5 RID: 143861 RVA: 0x000BFFB8 File Offset: 0x000BE1B8
			[Token(Token = "0x60231F5")]
			[Address(RVA = "0x1DB8B90", Offset = "0x1DB7790", VA = "0x181DB8B90", Slot = "7")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040306AE RID: 198318
			[Token(Token = "0x40306AE")]
			[FieldOffset(Offset = "0x0")]
			public int charInstId;

			// Token: 0x040306AF RID: 198319
			[Token(Token = "0x40306AF")]
			[FieldOffset(Offset = "0x8")]
			public List<int> charList;

			// Token: 0x040306B0 RID: 198320
			[Token(Token = "0x40306B0")]
			[FieldOffset(Offset = "0x10")]
			public CharacterInfoPage.RouteTarget routeTarget;

			// Token: 0x040306B1 RID: 198321
			[Token(Token = "0x40306B1")]
			[FieldOffset(Offset = "0x14")]
			public bool isFromHandbook;

			// Token: 0x040306B2 RID: 198322
			[Token(Token = "0x40306B2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetCharInstId;

			// Token: 0x040306B3 RID: 198323
			[Token(Token = "0x40306B3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCharList;

			// Token: 0x040306B4 RID: 198324
			[Token(Token = "0x40306B4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsFromHandbook;

			// Token: 0x040306B5 RID: 198325
			[Token(Token = "0x40306B5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}
	}
}
