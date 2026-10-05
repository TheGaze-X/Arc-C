using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200476A RID: 18282
	[Token(Token = "0x200476A")]
	public class RecruitSpecialGachaNormalView : DataBinder<RecruitSpecialGachaProperty>, IHotfixable
	{
		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x0601BAE7 RID: 113383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BAE8 RID: 113384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C6")]
		public Action onDetailBtnClicked
		{
			[Token(Token = "0x601BAE7")]
			[Address(RVA = "0x151DCB0", Offset = "0x151C8B0", VA = "0x18151DCB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BAE8")]
			[Address(RVA = "0x151DDD0", Offset = "0x151C9D0", VA = "0x18151DDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x0601BAE9 RID: 113385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BAEA RID: 113386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C7")]
		public Action onRecruitTenBtnClicked
		{
			[Token(Token = "0x601BAE9")]
			[Address(RVA = "0x151DD70", Offset = "0x151C970", VA = "0x18151DD70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BAEA")]
			[Address(RVA = "0x151DED0", Offset = "0x151CAD0", VA = "0x18151DED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x0601BAEB RID: 113387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BAEC RID: 113388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041C8")]
		public Action onRecruitOnceBtnClicked
		{
			[Token(Token = "0x601BAEB")]
			[Address(RVA = "0x151DD10", Offset = "0x151C910", VA = "0x18151DD10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BAEC")]
			[Address(RVA = "0x151DE50", Offset = "0x151CA50", VA = "0x18151DE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BAED RID: 113389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAED")]
		[Address(RVA = "0x151C6F0", Offset = "0x151B2F0", VA = "0x18151C6F0", Slot = "7")]
		public override void OnValueChanged(RecruitSpecialGachaProperty property)
		{
		}

		// Token: 0x0601BAEE RID: 113390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAEE")]
		[Address(RVA = "0x151C3C0", Offset = "0x151AFC0", VA = "0x18151C3C0")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x0601BAEF RID: 113391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAEF")]
		[Address(RVA = "0x151C5E0", Offset = "0x151B1E0", VA = "0x18151C5E0")]
		public void EventOnRecruitTenBtnClicked()
		{
		}

		// Token: 0x0601BAF0 RID: 113392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF0")]
		[Address(RVA = "0x151C4D0", Offset = "0x151B0D0", VA = "0x18151C4D0")]
		public void EventOnRecruitOnceBtnClicked()
		{
		}

		// Token: 0x0601BAF1 RID: 113393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF1")]
		[Address(RVA = "0x151CBA0", Offset = "0x151B7A0", VA = "0x18151CBA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BAF2 RID: 113394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF2")]
		[Address(RVA = "0x151D340", Offset = "0x151BF40", VA = "0x18151D340")]
		private void _RenderGachaPolicy(RecruitSpecialGachaViewModel model)
		{
		}

		// Token: 0x0601BAF3 RID: 113395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF3")]
		[Address(RVA = "0x151D6E0", Offset = "0x151C2E0", VA = "0x18151D6E0")]
		private void _RenderInfo(RecruitSpecialGachaViewModel model)
		{
		}

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF4")]
		[Address(RVA = "0x151D460", Offset = "0x151C060", VA = "0x18151D460")]
		private void _RenderIllustChar(RecruitSpecialGachaViewModel model)
		{
		}

		// Token: 0x0601BAF5 RID: 113397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF5")]
		[Address(RVA = "0x151D8C0", Offset = "0x151C4C0", VA = "0x18151D8C0")]
		private void _RenderPortraitChar(RecruitSpecialGachaViewModel model)
		{
		}

		// Token: 0x0601BAF6 RID: 113398 RVA: 0x000A5D20 File Offset: 0x000A3F20
		[Token(Token = "0x601BAF6")]
		[Address(RVA = "0x151C9C0", Offset = "0x151B5C0", VA = "0x18151C9C0")]
		private static CharUISkinStruct _GetSkinStruct(string charId, out CharacterData characterData)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0601BAF7 RID: 113399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF7")]
		[Address(RVA = "0x151D050", Offset = "0x151BC50", VA = "0x18151D050")]
		private void _LoadAndSetIllusts(CharUISkinStruct skinStruct, RecruitSpecialGachaNormalView.IllustInfo info)
		{
		}

		// Token: 0x0601BAF8 RID: 113400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF8")]
		[Address(RVA = "0x151C8F0", Offset = "0x151B4F0", VA = "0x18151C8F0")]
		private static void _ClearIllusts(ref UICharacterIllust charIllust)
		{
		}

		// Token: 0x0601BAF9 RID: 113401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAF9")]
		[Address(RVA = "0x151DB90", Offset = "0x151C790", VA = "0x18151DB90")]
		public RecruitSpecialGachaNormalView()
		{
		}

		// Token: 0x04023F59 RID: 147289
		[Token(Token = "0x4023F59")]
		private const string CRYSTAL_PRICE_FORMAT = "x{0}";

		// Token: 0x04023F5A RID: 147290
		[Token(Token = "0x4023F5A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Info")]
		private Text _recruitName;

		// Token: 0x04023F5B RID: 147291
		[Token(Token = "0x4023F5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Info")]
		private Text _recruitSummary;

		// Token: 0x04023F5C RID: 147292
		[Token(Token = "0x4023F5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Recruit")]
		private Text _singleCrystalPrice;

		// Token: 0x04023F5D RID: 147293
		[Token(Token = "0x4023F5D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Recruit")]
		private Text _multiCrystalPrice;

		// Token: 0x04023F5E RID: 147294
		[Token(Token = "0x4023F5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _diamondShObj;

		// Token: 0x04023F5F RID: 147295
		[Token(Token = "0x4023F5F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaObj;

		// Token: 0x04023F60 RID: 147296
		[Token(Token = "0x4023F60")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _diamondShTenObj;

		// Token: 0x04023F61 RID: 147297
		[Token(Token = "0x4023F61")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaTenObj;

		// Token: 0x04023F62 RID: 147298
		[Token(Token = "0x4023F62")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Recruit")]
		private GameObject _gachaBatchedTenObj;

		// Token: 0x04023F63 RID: 147299
		[Token(Token = "0x4023F63")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Recruit")]
		protected GameObject _panelProtect;

		// Token: 0x04023F64 RID: 147300
		[Token(Token = "0x4023F64")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Recruit")]
		private Text _textRemainTimes;

		// Token: 0x04023F65 RID: 147301
		[Token(Token = "0x4023F65")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Character")]
		private RectTransform[] _rectTransformIllustList;

		// Token: 0x04023F66 RID: 147302
		[Token(Token = "0x4023F66")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Character")]
		private Image[] _imgIllustProfessionList;

		// Token: 0x04023F67 RID: 147303
		[Token(Token = "0x4023F67")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Character")]
		private Text[] _textIlluestNameList;

		// Token: 0x04023F68 RID: 147304
		[Token(Token = "0x4023F68")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Character")]
		private RecruitGachaCharButton[] _illustCharButtonList;

		// Token: 0x04023F69 RID: 147305
		[Token(Token = "0x4023F69")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Character")]
		private UIAtlasImage[] _imgCharPortraitList;

		// Token: 0x04023F6A RID: 147306
		[Token(Token = "0x4023F6A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Character")]
		private Image[] _imgCharProfessionList;

		// Token: 0x04023F6B RID: 147307
		[Token(Token = "0x4023F6B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Character")]
		private Text[] _textCharNameList;

		// Token: 0x04023F6C RID: 147308
		[Token(Token = "0x4023F6C")]
		[FieldOffset(Offset = "0xB0")]
		private List<RecruitSpecialGachaNormalView.IllustInfo> m_illustList;

		// Token: 0x04023F6D RID: 147309
		[Token(Token = "0x4023F6D")]
		[FieldOffset(Offset = "0xB8")]
		private List<RecruitSpecialGachaNormalView.PortraitCharInfo> m_portraitCharList;

		// Token: 0x04023F6E RID: 147310
		[Token(Token = "0x4023F6E")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x04023F6F RID: 147311
		[Token(Token = "0x4023F6F")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023F73 RID: 147315
		[Token(Token = "0x4023F73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDetailBtnClicked;

		// Token: 0x04023F74 RID: 147316
		[Token(Token = "0x4023F74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDetailBtnClicked;

		// Token: 0x04023F75 RID: 147317
		[Token(Token = "0x4023F75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onRecruitTenBtnClicked;

		// Token: 0x04023F76 RID: 147318
		[Token(Token = "0x4023F76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onRecruitTenBtnClicked;

		// Token: 0x04023F77 RID: 147319
		[Token(Token = "0x4023F77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onRecruitOnceBtnClicked;

		// Token: 0x04023F78 RID: 147320
		[Token(Token = "0x4023F78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onRecruitOnceBtnClicked;

		// Token: 0x04023F79 RID: 147321
		[Token(Token = "0x4023F79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023F7A RID: 147322
		[Token(Token = "0x4023F7A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x04023F7B RID: 147323
		[Token(Token = "0x4023F7B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRecruitTenBtnClicked;

		// Token: 0x04023F7C RID: 147324
		[Token(Token = "0x4023F7C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnRecruitOnceBtnClicked;

		// Token: 0x04023F7D RID: 147325
		[Token(Token = "0x4023F7D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023F7E RID: 147326
		[Token(Token = "0x4023F7E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderGachaPolicy;

		// Token: 0x04023F7F RID: 147327
		[Token(Token = "0x4023F7F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderInfo;

		// Token: 0x04023F80 RID: 147328
		[Token(Token = "0x4023F80")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderIllustChar;

		// Token: 0x04023F81 RID: 147329
		[Token(Token = "0x4023F81")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderPortraitChar;

		// Token: 0x04023F82 RID: 147330
		[Token(Token = "0x4023F82")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetSkinStruct;

		// Token: 0x04023F83 RID: 147331
		[Token(Token = "0x4023F83")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadAndSetIllusts;

		// Token: 0x04023F84 RID: 147332
		[Token(Token = "0x4023F84")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ClearIllusts;

		// Token: 0x04023F85 RID: 147333
		[Token(Token = "0x4023F85")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200476B RID: 18283
		[Token(Token = "0x200476B")]
		private class IllustInfo
		{
			// Token: 0x0601BAFA RID: 113402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAFA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IllustInfo()
			{
			}

			// Token: 0x04023F86 RID: 147334
			[Token(Token = "0x4023F86")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform container;

			// Token: 0x04023F87 RID: 147335
			[Token(Token = "0x4023F87")]
			[FieldOffset(Offset = "0x18")]
			public Image imgProfession;

			// Token: 0x04023F88 RID: 147336
			[Token(Token = "0x4023F88")]
			[FieldOffset(Offset = "0x20")]
			public Text textName;

			// Token: 0x04023F89 RID: 147337
			[Token(Token = "0x4023F89")]
			[FieldOffset(Offset = "0x28")]
			public RecruitGachaCharButton button;

			// Token: 0x04023F8A RID: 147338
			[Token(Token = "0x4023F8A")]
			[FieldOffset(Offset = "0x30")]
			public UICharacterIllust charIllust;

			// Token: 0x04023F8B RID: 147339
			[Token(Token = "0x4023F8B")]
			[FieldOffset(Offset = "0x38")]
			public CharUISkinStruct cachedSkinStruct;
		}

		// Token: 0x0200476C RID: 18284
		[Token(Token = "0x200476C")]
		private class PortraitCharInfo
		{
			// Token: 0x0601BAFB RID: 113403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BAFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PortraitCharInfo()
			{
			}

			// Token: 0x04023F8C RID: 147340
			[Token(Token = "0x4023F8C")]
			[FieldOffset(Offset = "0x10")]
			public UIAtlasImage imgPortrait;

			// Token: 0x04023F8D RID: 147341
			[Token(Token = "0x4023F8D")]
			[FieldOffset(Offset = "0x18")]
			public Image imgProfession;

			// Token: 0x04023F8E RID: 147342
			[Token(Token = "0x4023F8E")]
			[FieldOffset(Offset = "0x20")]
			public Text textCharName;
		}
	}
}
