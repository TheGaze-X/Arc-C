using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI.ChooseChar;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200471A RID: 18202
	[Token(Token = "0x200471A")]
	public class RecruitSpecialGachaUpCharListDialog : UICompDialog<RecruitSpecialGachaUpCharListDialog.Options>, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x0601B96E RID: 113006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B96E")]
		[Address(RVA = "0x14E7EB0", Offset = "0x14E6AB0", VA = "0x1814E7EB0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B96F RID: 113007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B96F")]
		[Address(RVA = "0x14E7CD0", Offset = "0x14E68D0", VA = "0x1814E7CD0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B970")]
		[Address(RVA = "0x14E8250", Offset = "0x14E6E50", VA = "0x1814E8250", Slot = "18")]
		protected override void OnRender(RecruitSpecialGachaUpCharListDialog.Options input)
		{
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B971")]
		[Address(RVA = "0x14E8080", Offset = "0x14E6C80", VA = "0x1814E8080", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B972")]
		[Address(RVA = "0x14E7D30", Offset = "0x14E6930", VA = "0x1814E7D30", Slot = "20")]
		public void HandleCallBack(int instId, ValueBundle outputBundle)
		{
		}

		// Token: 0x0601B973 RID: 113011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B973")]
		[Address(RVA = "0x14E9690", Offset = "0x14E8290", VA = "0x1814E9690")]
		private void _OnCharCardClicked(RarityRank rank)
		{
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B974")]
		[Address(RVA = "0x14E8890", Offset = "0x14E7490", VA = "0x1814E8890")]
		private void _EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B975")]
		[Address(RVA = "0x14E87D0", Offset = "0x14E73D0", VA = "0x1814E87D0")]
		private void _EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601B976 RID: 113014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B976")]
		[Address(RVA = "0x14E8C40", Offset = "0x14E7840", VA = "0x1814E8C40")]
		private void _EventOnIntroBtnClicked()
		{
		}

		// Token: 0x0601B977 RID: 113015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B977")]
		[Address(RVA = "0x14E9980", Offset = "0x14E8580", VA = "0x1814E9980")]
		private void _SendChoosePoolUpRequest()
		{
		}

		// Token: 0x0601B978 RID: 113016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B978")]
		[Address(RVA = "0x14E8E60", Offset = "0x14E7A60", VA = "0x1814E8E60")]
		private static void _FormatToastCharName(StringBuilder builder, List<string> charIdList, int rarity)
		{
		}

		// Token: 0x0601B979 RID: 113017 RVA: 0x000A59D8 File Offset: 0x000A3BD8
		[Token(Token = "0x601B979")]
		[Address(RVA = "0x14E9050", Offset = "0x14E7C50", VA = "0x1814E9050")]
		private bool _LoadCharModelList(RarityRank rank, Dictionary<string, List<string>> selectCharIdDict, Dictionary<string, List<RecruitSpecialGachaUpCharCardViewModel>> charModelDict, Color colorTheme, out List<UIPortraitChooseCharCardViewModel> chooseModelList, out int selectCount, out string titleText, out List<string> selectCharIdList)
		{
			return default(bool);
		}

		// Token: 0x0601B97A RID: 113018 RVA: 0x000A59F0 File Offset: 0x000A3BF0
		[Token(Token = "0x601B97A")]
		[Address(RVA = "0x14E86C0", Offset = "0x14E72C0", VA = "0x1814E86C0")]
		private static int _CompareCharModel(UIPortraitChooseCharCardViewModel left, UIPortraitChooseCharCardViewModel right)
		{
			return 0;
		}

		// Token: 0x0601B97B RID: 113019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B97B")]
		[Address(RVA = "0x14E9C60", Offset = "0x14E8860", VA = "0x1814E9C60")]
		public RecruitSpecialGachaUpCharListDialog()
		{
		}

		// Token: 0x0601B97D RID: 113021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B97D")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601B97E RID: 113022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B97E")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04023BE2 RID: 146402
		[Token(Token = "0x4023BE2")]
		private const int STAR_6_CHAR_COUNT = 3;

		// Token: 0x04023BE3 RID: 146403
		[Token(Token = "0x4023BE3")]
		private const int STAR_5_CHAR_COUNT = 3;

		// Token: 0x04023BE4 RID: 146404
		[Token(Token = "0x4023BE4")]
		[NonSerialized]
		public const int ON_CHAR_CARD_CLICKED = 0;

		// Token: 0x04023BE5 RID: 146405
		[Token(Token = "0x4023BE5")]
		[NonSerialized]
		public const int ON_CONFIRM_BTN_CLICKED = 1;

		// Token: 0x04023BE6 RID: 146406
		[Token(Token = "0x4023BE6")]
		[NonSerialized]
		public const int ON_CANCEL_BTN_CLICKED = 2;

		// Token: 0x04023BE7 RID: 146407
		[Token(Token = "0x4023BE7")]
		[NonSerialized]
		public const int ON_INTRO_BTN_CLICKED = 3;

		// Token: 0x04023BE8 RID: 146408
		[Token(Token = "0x4023BE8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04023BE9 RID: 146409
		[Token(Token = "0x4023BE9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RecruitSpecialGachaUpCharListGroupView[] _groupViewList;

		// Token: 0x04023BEA RID: 146410
		[Token(Token = "0x4023BEA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RecruitSpecialGachaUpCharListButtonView _buttonView;

		// Token: 0x04023BEB RID: 146411
		[Token(Token = "0x4023BEB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04023BEC RID: 146412
		[Token(Token = "0x4023BEC")]
		[FieldOffset(Offset = "0x90")]
		private RecruitSpecialGachaUpCharListProperty m_property;

		// Token: 0x04023BED RID: 146413
		[Token(Token = "0x4023BED")]
		[FieldOffset(Offset = "0x98")]
		private int m_dialogInstId;

		// Token: 0x04023BEE RID: 146414
		[Token(Token = "0x4023BEE")]
		[FieldOffset(Offset = "0x9C")]
		private int m_introDialogInstId;

		// Token: 0x04023BEF RID: 146415
		[Token(Token = "0x4023BEF")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023BF0 RID: 146416
		[Token(Token = "0x4023BF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04023BF1 RID: 146417
		[Token(Token = "0x4023BF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04023BF2 RID: 146418
		[Token(Token = "0x4023BF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023BF3 RID: 146419
		[Token(Token = "0x4023BF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04023BF4 RID: 146420
		[Token(Token = "0x4023BF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04023BF5 RID: 146421
		[Token(Token = "0x4023BF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x04023BF6 RID: 146422
		[Token(Token = "0x4023BF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnConfirmBtnClicked;

		// Token: 0x04023BF7 RID: 146423
		[Token(Token = "0x4023BF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnBackBtnClicked;

		// Token: 0x04023BF8 RID: 146424
		[Token(Token = "0x4023BF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnIntroBtnClicked;

		// Token: 0x04023BF9 RID: 146425
		[Token(Token = "0x4023BF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendChoosePoolUpRequest;

		// Token: 0x04023BFA RID: 146426
		[Token(Token = "0x4023BFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FormatToastCharName;

		// Token: 0x04023BFB RID: 146427
		[Token(Token = "0x4023BFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadCharModelList;

		// Token: 0x04023BFC RID: 146428
		[Token(Token = "0x4023BFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CompareCharModel;

		// Token: 0x04023BFD RID: 146429
		[Token(Token = "0x4023BFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200471B RID: 18203
		[Token(Token = "0x200471B")]
		public class Options
		{
			// Token: 0x0601B97F RID: 113023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B97F")]
			[Address(RVA = "0x14DB7C0", Offset = "0x14DA3C0", VA = "0x1814DB7C0")]
			public Options()
			{
			}

			// Token: 0x04023BFE RID: 146430
			[Token(Token = "0x4023BFE")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x04023BFF RID: 146431
			[Token(Token = "0x4023BFF")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, List<string>> selectCharIdDict;

			// Token: 0x04023C00 RID: 146432
			[Token(Token = "0x4023C00")]
			[FieldOffset(Offset = "0x20")]
			public string detailTitle;

			// Token: 0x04023C01 RID: 146433
			[Token(Token = "0x4023C01")]
			[FieldOffset(Offset = "0x28")]
			public string detailInfo;

			// Token: 0x04023C02 RID: 146434
			[Token(Token = "0x4023C02")]
			[FieldOffset(Offset = "0x30")]
			public Color colorTheme;

			// Token: 0x04023C03 RID: 146435
			[Token(Token = "0x4023C03")]
			[FieldOffset(Offset = "0x40")]
			public string selectJudgeText;
		}
	}
}
