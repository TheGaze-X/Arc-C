using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200670D RID: 26381
	[Token(Token = "0x200670D")]
	public class HandBookV2MapView : DataBinder<HandBookV2MapRenderProperty>, IHotfixable
	{
		// Token: 0x06025DBA RID: 155066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBA")]
		[Address(RVA = "0x20E2C40", Offset = "0x20E1840", VA = "0x1820E2C40", Slot = "7")]
		public override void OnValueChanged(HandBookV2MapRenderProperty property)
		{
		}

		// Token: 0x06025DBB RID: 155067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBB")]
		[Address(RVA = "0x20E2CD0", Offset = "0x20E18D0", VA = "0x1820E2CD0")]
		public void PlayFadeOutAnim(bool isFadeOut)
		{
		}

		// Token: 0x06025DBC RID: 155068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBC")]
		[Address(RVA = "0x20E3A80", Offset = "0x20E2680", VA = "0x1820E3A80")]
		private void _Render(HandBookV2MapRenderViewModel mapViewModel)
		{
		}

		// Token: 0x06025DBD RID: 155069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBD")]
		[Address(RVA = "0x20E38F0", Offset = "0x20E24F0", VA = "0x1820E38F0")]
		private void _RenderShadow(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025DBE RID: 155070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBE")]
		[Address(RVA = "0x20E2F90", Offset = "0x20E1B90", VA = "0x1820E2F90")]
		private void _RenderBg(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025DBF RID: 155071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DBF")]
		[Address(RVA = "0x20E3140", Offset = "0x20E1D40", VA = "0x1820E3140")]
		private void _RenderBorder(HandBookV2ForceViewModel viewModel, Dictionary<int, string> pointIndex2ForceIdMap)
		{
		}

		// Token: 0x06025DC0 RID: 155072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC0")]
		[Address(RVA = "0x20E3600", Offset = "0x20E2200", VA = "0x1820E3600")]
		private void _RenderLogo(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025DC1 RID: 155073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC1")]
		[Address(RVA = "0x20E32F0", Offset = "0x20E1EF0", VA = "0x1820E32F0")]
		private void _RenderCard(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025DC2 RID: 155074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC2")]
		[Address(RVA = "0x20E34A0", Offset = "0x20E20A0", VA = "0x1820E34A0")]
		private void _RenderForceLine(HandBookV2ForceLineViewModel lineModel)
		{
		}

		// Token: 0x06025DC3 RID: 155075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC3")]
		[Address(RVA = "0x20E3790", Offset = "0x20E2390", VA = "0x1820E3790")]
		private void _RenderPointLine(HandBookV2PointLineViewModel pointLineModel)
		{
		}

		// Token: 0x06025DC4 RID: 155076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC4")]
		[Address(RVA = "0x20E40C0", Offset = "0x20E2CC0", VA = "0x1820E40C0")]
		public HandBookV2MapView()
		{
		}

		// Token: 0x040353BB RID: 218043
		[Token(Token = "0x40353BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2MapForceShadowView _shadowView;

		// Token: 0x040353BC RID: 218044
		[Token(Token = "0x40353BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _shadowContainer;

		// Token: 0x040353BD RID: 218045
		[Token(Token = "0x40353BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookV2MapPointLineView _pointLineView;

		// Token: 0x040353BE RID: 218046
		[Token(Token = "0x40353BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _pointLineContainer;

		// Token: 0x040353BF RID: 218047
		[Token(Token = "0x40353BF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandBookV2MapForceView _bgView;

		// Token: 0x040353C0 RID: 218048
		[Token(Token = "0x40353C0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _bgContainer;

		// Token: 0x040353C1 RID: 218049
		[Token(Token = "0x40353C1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HandBookV2MapBorderView _borderView;

		// Token: 0x040353C2 RID: 218050
		[Token(Token = "0x40353C2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _borderContainer;

		// Token: 0x040353C3 RID: 218051
		[Token(Token = "0x40353C3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private HandBookV2MapLogoView _logoView;

		// Token: 0x040353C4 RID: 218052
		[Token(Token = "0x40353C4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _logoContainer;

		// Token: 0x040353C5 RID: 218053
		[Token(Token = "0x40353C5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HandBookV2MapForceCardView _cardView;

		// Token: 0x040353C6 RID: 218054
		[Token(Token = "0x40353C6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x040353C7 RID: 218055
		[Token(Token = "0x40353C7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HandBookV2MapForceLineView _forceLineView;

		// Token: 0x040353C8 RID: 218056
		[Token(Token = "0x40353C8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _forcelineContainer;

		// Token: 0x040353C9 RID: 218057
		[Token(Token = "0x40353C9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationWrapper _lineAnimWrapper;

		// Token: 0x040353CA RID: 218058
		[Token(Token = "0x40353CA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIStringEvent _onForceClick;

		// Token: 0x040353CB RID: 218059
		[Token(Token = "0x40353CB")]
		private const string LINE_FADE_OUT = "line_fade_out";

		// Token: 0x040353CC RID: 218060
		[Token(Token = "0x40353CC")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isPlayAnim;

		// Token: 0x040353CD RID: 218061
		[Token(Token = "0x40353CD")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_isCardAndLineVisible;

		// Token: 0x040353CE RID: 218062
		[Token(Token = "0x40353CE")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<int, HandBookV2MapPointLineView> m_pointLineViewMap;

		// Token: 0x040353CF RID: 218063
		[Token(Token = "0x40353CF")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<int, HandBookV2MapForceView> m_forceIdx2BgViewMap;

		// Token: 0x040353D0 RID: 218064
		[Token(Token = "0x40353D0")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<int, HandBookV2MapForceShadowView> m_forceIdx2ShadowViewMap;

		// Token: 0x040353D1 RID: 218065
		[Token(Token = "0x40353D1")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<int, HandBookV2MapBorderView> m_forceIdx2BorderViewMap;

		// Token: 0x040353D2 RID: 218066
		[Token(Token = "0x40353D2")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<int, HandBookV2MapLogoView> m_forceIdx2LogoViewMap;

		// Token: 0x040353D3 RID: 218067
		[Token(Token = "0x40353D3")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<int, HandBookV2MapForceCardView> m_forceIdx2CardViewMap;

		// Token: 0x040353D4 RID: 218068
		[Token(Token = "0x40353D4")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<int, HandBookV2MapForceLineView> m_forceLineViewMap;

		// Token: 0x040353D5 RID: 218069
		[Token(Token = "0x40353D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040353D6 RID: 218070
		[Token(Token = "0x40353D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayFadeOutAnim;

		// Token: 0x040353D7 RID: 218071
		[Token(Token = "0x40353D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040353D8 RID: 218072
		[Token(Token = "0x40353D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderShadow;

		// Token: 0x040353D9 RID: 218073
		[Token(Token = "0x40353D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBg;

		// Token: 0x040353DA RID: 218074
		[Token(Token = "0x40353DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBorder;

		// Token: 0x040353DB RID: 218075
		[Token(Token = "0x40353DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderLogo;

		// Token: 0x040353DC RID: 218076
		[Token(Token = "0x40353DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderCard;

		// Token: 0x040353DD RID: 218077
		[Token(Token = "0x40353DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderForceLine;

		// Token: 0x040353DE RID: 218078
		[Token(Token = "0x40353DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderPointLine;

		// Token: 0x040353DF RID: 218079
		[Token(Token = "0x40353DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
