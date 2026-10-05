using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E9D RID: 16029
	[Token(Token = "0x2003E9D")]
	public class SpecialOperatorBoardContentViewContainer : DataBinder<SpecialOperatorBoardProp>, IHotfixable
	{
		// Token: 0x06018E35 RID: 101941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E35")]
		[Address(RVA = "0x11849E0", Offset = "0x11835E0", VA = "0x1811849E0", Slot = "7")]
		public override void OnValueChanged(SpecialOperatorBoardProp property)
		{
		}

		// Token: 0x06018E36 RID: 101942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E36")]
		[Address(RVA = "0x1184F20", Offset = "0x1183B20", VA = "0x181184F20")]
		private void _LoadEffectIfNeed(SpecialOperatorBoardMainModel model)
		{
		}

		// Token: 0x06018E37 RID: 101943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E37")]
		[Address(RVA = "0x1185130", Offset = "0x1183D30", VA = "0x181185130")]
		private void _RenderCharIllust(SpecialOperatorBoardSummaryModel summaryModel, bool isShowSummary)
		{
		}

		// Token: 0x06018E38 RID: 101944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E38")]
		[Address(RVA = "0x1184DF0", Offset = "0x11839F0", VA = "0x181184DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E39 RID: 101945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E39")]
		[Address(RVA = "0x11853C0", Offset = "0x1183FC0", VA = "0x1811853C0")]
		private void _RenderContentViews(SpecialOperatorBoardMainModel model, bool isFirstRender)
		{
		}

		// Token: 0x06018E3A RID: 101946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E3A")]
		[Address(RVA = "0x1184CF0", Offset = "0x11838F0", VA = "0x181184CF0")]
		private SpecialOperatorBoardLvlupContentView _FindContentViewPrefab(SpecialOperatorDetailNodeType nodeType)
		{
			return null;
		}

		// Token: 0x06018E3B RID: 101947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E3B")]
		[Address(RVA = "0x1184950", Offset = "0x1183550", VA = "0x181184950")]
		public void EventOnBtnNavCharInfo()
		{
		}

		// Token: 0x06018E3C RID: 101948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E3C")]
		[Address(RVA = "0x1185710", Offset = "0x1184310", VA = "0x181185710")]
		public SpecialOperatorBoardContentViewContainer()
		{
		}

		// Token: 0x0401EAE4 RID: 125668
		[Token(Token = "0x401EAE4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x0401EAE5 RID: 125669
		[Token(Token = "0x401EAE5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _gradientAlphaHolder;

		// Token: 0x0401EAE6 RID: 125670
		[Token(Token = "0x401EAE6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401EAE7 RID: 125671
		[Token(Token = "0x401EAE7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SpecialOperatorBoardSummaryContentView _summaryViewPrefab;

		// Token: 0x0401EAE8 RID: 125672
		[Token(Token = "0x401EAE8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _summaryViewContainer;

		// Token: 0x0401EAE9 RID: 125673
		[Token(Token = "0x401EAE9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _viewRoot;

		// Token: 0x0401EAEA RID: 125674
		[Token(Token = "0x401EAEA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpecialOperatorBoardContentViewContainer.LvlupContentConfig[] _contentConfigs;

		// Token: 0x0401EAEB RID: 125675
		[Token(Token = "0x401EAEB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SpecialOperatorBoardNodeDetailPanel _nodeDetailPanel;

		// Token: 0x0401EAEC RID: 125676
		[Token(Token = "0x401EAEC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x0401EAED RID: 125677
		[Token(Token = "0x401EAED")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _illustColor;

		// Token: 0x0401EAEE RID: 125678
		[Token(Token = "0x401EAEE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bgEffectContainer;

		// Token: 0x0401EAEF RID: 125679
		[Token(Token = "0x401EAEF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _charEffectContainer;

		// Token: 0x0401EAF0 RID: 125680
		[Token(Token = "0x401EAF0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0401EAF1 RID: 125681
		[Token(Token = "0x401EAF1")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EAF2 RID: 125682
		[Token(Token = "0x401EAF2")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EAF3 RID: 125683
		[Token(Token = "0x401EAF3")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedEnterSeqNum;

		// Token: 0x0401EAF4 RID: 125684
		[Token(Token = "0x401EAF4")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedBgId;

		// Token: 0x0401EAF5 RID: 125685
		[Token(Token = "0x401EAF5")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedBgEffectId;

		// Token: 0x0401EAF6 RID: 125686
		[Token(Token = "0x401EAF6")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedCharEffectId;

		// Token: 0x0401EAF7 RID: 125687
		[Token(Token = "0x401EAF7")]
		[FieldOffset(Offset = "0xD0")]
		private SpecialOperatorDetailNodeType m_contentType;

		// Token: 0x0401EAF8 RID: 125688
		[Token(Token = "0x401EAF8")]
		[FieldOffset(Offset = "0xD8")]
		private SpecialOperatorBoardSummaryContentView m_summaryView;

		// Token: 0x0401EAF9 RID: 125689
		[Token(Token = "0x401EAF9")]
		[FieldOffset(Offset = "0xE0")]
		private EnumIntDictionary<SpecialOperatorDetailNodeType, SpecialOperatorBoardLvlupContentView> m_contentDict;

		// Token: 0x0401EAFA RID: 125690
		[Token(Token = "0x401EAFA")]
		[FieldOffset(Offset = "0xE8")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401EAFB RID: 125691
		[Token(Token = "0x401EAFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EAFC RID: 125692
		[Token(Token = "0x401EAFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadEffectIfNeed;

		// Token: 0x0401EAFD RID: 125693
		[Token(Token = "0x401EAFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCharIllust;

		// Token: 0x0401EAFE RID: 125694
		[Token(Token = "0x401EAFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EAFF RID: 125695
		[Token(Token = "0x401EAFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderContentViews;

		// Token: 0x0401EB00 RID: 125696
		[Token(Token = "0x401EB00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindContentViewPrefab;

		// Token: 0x0401EB01 RID: 125697
		[Token(Token = "0x401EB01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnNavCharInfo;

		// Token: 0x0401EB02 RID: 125698
		[Token(Token = "0x401EB02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E9E RID: 16030
		[Token(Token = "0x2003E9E")]
		[Serializable]
		public struct LvlupContentConfig
		{
			// Token: 0x0401EB03 RID: 125699
			[Token(Token = "0x401EB03")]
			[FieldOffset(Offset = "0x0")]
			public SpecialOperatorDetailNodeType nodeType;

			// Token: 0x0401EB04 RID: 125700
			[Token(Token = "0x401EB04")]
			[FieldOffset(Offset = "0x8")]
			public SpecialOperatorBoardLvlupContentView viewPrefab;
		}
	}
}
