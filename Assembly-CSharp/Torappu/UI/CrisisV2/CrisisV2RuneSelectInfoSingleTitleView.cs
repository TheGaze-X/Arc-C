using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E6 RID: 23014
	[Token(Token = "0x20059E6")]
	public class CrisisV2RuneSelectInfoSingleTitleView : CrisisV2RuneSelectInfoBaseView
	{
		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x0602188A RID: 137354 RVA: 0x000BA9C0 File Offset: 0x000B8BC0
		[Token(Token = "0x17004ECA")]
		public override float preferredWidth
		{
			[Token(Token = "0x602188A")]
			[Address(RVA = "0x1BDF960", Offset = "0x1BDE560", VA = "0x181BDF960", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x0602188B RID: 137355 RVA: 0x000BA9D8 File Offset: 0x000B8BD8
		[Token(Token = "0x17004ECB")]
		public override float preferredHeight
		{
			[Token(Token = "0x602188B")]
			[Address(RVA = "0x1BDF900", Offset = "0x1BDE500", VA = "0x181BDF900", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x0602188C RID: 137356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ECC")]
		public override CanvasGroup alphaHandler
		{
			[Token(Token = "0x602188C")]
			[Address(RVA = "0x1BDF8A0", Offset = "0x1BDE4A0", VA = "0x181BDF8A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602188D RID: 137357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602188D")]
		[Address(RVA = "0x1BDEA10", Offset = "0x1BDD610", VA = "0x181BDEA10", Slot = "16")]
		protected override void OnDataUpdated(CrisisV2RuneBaseViewModel viewModel)
		{
		}

		// Token: 0x0602188E RID: 137358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602188E")]
		[Address(RVA = "0x1BDEE70", Offset = "0x1BDDA70", VA = "0x181BDEE70", Slot = "17")]
		protected override void OnFocusStatusChanged(bool isFocused)
		{
		}

		// Token: 0x0602188F RID: 137359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602188F")]
		[Address(RVA = "0x1BDED40", Offset = "0x1BDD940", VA = "0x181BDED40", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06021890 RID: 137360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021890")]
		[Address(RVA = "0x1BDF0F0", Offset = "0x1BDDCF0", VA = "0x181BDF0F0")]
		private void _InitFocusStatusIfNot()
		{
		}

		// Token: 0x06021891 RID: 137361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021891")]
		[Address(RVA = "0x1BDF460", Offset = "0x1BDE060", VA = "0x181BDF460")]
		private void _TweenFocusState()
		{
		}

		// Token: 0x06021892 RID: 137362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021892")]
		[Address(RVA = "0x1BDF750", Offset = "0x1BDE350", VA = "0x181BDF750")]
		private void _TweenUnFocusState()
		{
		}

		// Token: 0x06021893 RID: 137363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021893")]
		[Address(RVA = "0x1BDF2C0", Offset = "0x1BDDEC0", VA = "0x181BDF2C0")]
		private void _ShowOuterGlow(bool show)
		{
		}

		// Token: 0x06021894 RID: 137364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021894")]
		[Address(RVA = "0x1BDF390", Offset = "0x1BDDF90", VA = "0x181BDF390")]
		private void _ShowTitleHightLight(bool hightLight)
		{
		}

		// Token: 0x06021895 RID: 137365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021895")]
		[Address(RVA = "0x1BDF050", Offset = "0x1BDDC50", VA = "0x181BDF050")]
		private void _ClearFocusTween()
		{
		}

		// Token: 0x06021896 RID: 137366 RVA: 0x000BA9F0 File Offset: 0x000B8BF0
		[Token(Token = "0x6021896")]
		[Address(RVA = "0x1BDEFB0", Offset = "0x1BDDBB0", VA = "0x181BDEFB0")]
		private float _CalcTextHeight(string desc)
		{
			return 0f;
		}

		// Token: 0x06021897 RID: 137367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021897")]
		[Address(RVA = "0x1BDF7D0", Offset = "0x1BDE3D0", VA = "0x181BDF7D0")]
		public CrisisV2RuneSelectInfoSingleTitleView()
		{
		}

		// Token: 0x06021898 RID: 137368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021898")]
		[Address(RVA = "0x1BDB670", Offset = "0x1BDA270", VA = "0x181BDB670")]
		private void <>xLuaBaseProxy_OnFocusStatusChanged(bool P0)
		{
		}

		// Token: 0x06021899 RID: 137369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021899")]
		[Address(RVA = "0x1BDB610", Offset = "0x1BDA210", VA = "0x181BDB610")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402DD34 RID: 187700
		[Token(Token = "0x402DD34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402DD35 RID: 187701
		[Token(Token = "0x402DD35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitleNormal;

		// Token: 0x0402DD36 RID: 187702
		[Token(Token = "0x402DD36")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitleHighLight;

		// Token: 0x0402DD37 RID: 187703
		[Token(Token = "0x402DD37")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _paddingHeight;

		// Token: 0x0402DD38 RID: 187704
		[Token(Token = "0x402DD38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _panelFocus;

		// Token: 0x0402DD39 RID: 187705
		[Token(Token = "0x402DD39")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgDimensionNormal;

		// Token: 0x0402DD3A RID: 187706
		[Token(Token = "0x402DD3A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgDimensionHighlight;

		// Token: 0x0402DD3B RID: 187707
		[Token(Token = "0x402DD3B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _dimensionAtlas;

		// Token: 0x0402DD3C RID: 187708
		[Token(Token = "0x402DD3C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _titleNormal;

		// Token: 0x0402DD3D RID: 187709
		[Token(Token = "0x402DD3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _titleHighlight;

		// Token: 0x0402DD3E RID: 187710
		[Token(Token = "0x402DD3E")]
		[FieldOffset(Offset = "0x70")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402DD3F RID: 187711
		[Token(Token = "0x402DD3F")]
		[FieldOffset(Offset = "0x78")]
		private float m_titleHeight;

		// Token: 0x0402DD40 RID: 187712
		[Token(Token = "0x402DD40")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isFocusInited;

		// Token: 0x0402DD41 RID: 187713
		[Token(Token = "0x402DD41")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_focusTween;

		// Token: 0x0402DD42 RID: 187714
		[Token(Token = "0x402DD42")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_focusOuterGlowTween;

		// Token: 0x0402DD43 RID: 187715
		[Token(Token = "0x402DD43")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_titleNormalTween;

		// Token: 0x0402DD44 RID: 187716
		[Token(Token = "0x402DD44")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_titleHighLightTween;

		// Token: 0x0402DD45 RID: 187717
		[Token(Token = "0x402DD45")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedGlobalId;

		// Token: 0x0402DD46 RID: 187718
		[Token(Token = "0x402DD46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0402DD47 RID: 187719
		[Token(Token = "0x402DD47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402DD48 RID: 187720
		[Token(Token = "0x402DD48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402DD49 RID: 187721
		[Token(Token = "0x402DD49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0402DD4A RID: 187722
		[Token(Token = "0x402DD4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFocusStatusChanged;

		// Token: 0x0402DD4B RID: 187723
		[Token(Token = "0x402DD4B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DD4C RID: 187724
		[Token(Token = "0x402DD4C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitFocusStatusIfNot;

		// Token: 0x0402DD4D RID: 187725
		[Token(Token = "0x402DD4D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TweenFocusState;

		// Token: 0x0402DD4E RID: 187726
		[Token(Token = "0x402DD4E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TweenUnFocusState;

		// Token: 0x0402DD4F RID: 187727
		[Token(Token = "0x402DD4F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowOuterGlow;

		// Token: 0x0402DD50 RID: 187728
		[Token(Token = "0x402DD50")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowTitleHightLight;

		// Token: 0x0402DD51 RID: 187729
		[Token(Token = "0x402DD51")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearFocusTween;

		// Token: 0x0402DD52 RID: 187730
		[Token(Token = "0x402DD52")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalcTextHeight;

		// Token: 0x0402DD53 RID: 187731
		[Token(Token = "0x402DD53")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
