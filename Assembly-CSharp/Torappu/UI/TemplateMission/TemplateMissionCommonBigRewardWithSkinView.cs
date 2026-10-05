using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D93 RID: 15763
	[Token(Token = "0x2003D93")]
	public class TemplateMissionCommonBigRewardWithSkinView : TemplateMissionCommonBigRewardIllustView, IHotfixable
	{
		// Token: 0x0601884D RID: 100429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601884D")]
		[Address(RVA = "0x110B5C0", Offset = "0x110A1C0", VA = "0x18110B5C0", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x0601884E RID: 100430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601884E")]
		[Address(RVA = "0x110B680", Offset = "0x110A280", VA = "0x18110B680", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x0601884F RID: 100431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601884F")]
		[Address(RVA = "0x110B940", Offset = "0x110A540", VA = "0x18110B940")]
		private static string _GetSkinId(List<string> paramList)
		{
			return null;
		}

		// Token: 0x06018850 RID: 100432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018850")]
		[Address(RVA = "0x110B9B0", Offset = "0x110A5B0", VA = "0x18110B9B0")]
		private void _RenderCharSkinPart(CharSkinData skinData, string mainColor)
		{
		}

		// Token: 0x06018851 RID: 100433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018851")]
		[Address(RVA = "0x110BC70", Offset = "0x110A870", VA = "0x18110BC70")]
		private void _RenderTipsPart(List<string> paramList)
		{
		}

		// Token: 0x06018852 RID: 100434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018852")]
		[Address(RVA = "0x110B470", Offset = "0x110A070", VA = "0x18110B470")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x06018853 RID: 100435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018853")]
		[Address(RVA = "0x110BD40", Offset = "0x110A940", VA = "0x18110BD40")]
		public TemplateMissionCommonBigRewardWithSkinView()
		{
		}

		// Token: 0x06018854 RID: 100436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018854")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E0E9 RID: 123113
		[Token(Token = "0x401E0E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _skinContainer;

		// Token: 0x0401E0EA RID: 123114
		[Token(Token = "0x401E0EA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgSkinGroupIcon;

		// Token: 0x0401E0EB RID: 123115
		[Token(Token = "0x401E0EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textSkinName;

		// Token: 0x0401E0EC RID: 123116
		[Token(Token = "0x401E0EC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MaskableGraphic _imgSkinNameBkg;

		// Token: 0x0401E0ED RID: 123117
		[Token(Token = "0x401E0ED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textRewardTip;

		// Token: 0x0401E0EE RID: 123118
		[Token(Token = "0x401E0EE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E0EF RID: 123119
		[Token(Token = "0x401E0EF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isRendered;

		// Token: 0x0401E0F0 RID: 123120
		[Token(Token = "0x401E0F0")]
		[FieldOffset(Offset = "0x88")]
		private CharSkinData m_cachedSkinData;

		// Token: 0x0401E0F1 RID: 123121
		[Token(Token = "0x401E0F1")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E0F2 RID: 123122
		[Token(Token = "0x401E0F2")]
		[FieldOffset(Offset = "0xA0")]
		private UICharacterIllust m_illust;

		// Token: 0x0401E0F3 RID: 123123
		[Token(Token = "0x401E0F3")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E0F4 RID: 123124
		[Token(Token = "0x401E0F4")]
		[FieldOffset(Offset = "0xB8")]
		private CharUISkinStruct m_cachedSkinStruct;

		// Token: 0x0401E0F5 RID: 123125
		[Token(Token = "0x401E0F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E0F6 RID: 123126
		[Token(Token = "0x401E0F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E0F7 RID: 123127
		[Token(Token = "0x401E0F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSkinId;

		// Token: 0x0401E0F8 RID: 123128
		[Token(Token = "0x401E0F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCharSkinPart;

		// Token: 0x0401E0F9 RID: 123129
		[Token(Token = "0x401E0F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTipsPart;

		// Token: 0x0401E0FA RID: 123130
		[Token(Token = "0x401E0FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x0401E0FB RID: 123131
		[Token(Token = "0x401E0FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
