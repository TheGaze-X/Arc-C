using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A15 RID: 18965
	[Token(Token = "0x2004A15")]
	public class InformantInsightBarSliderItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C88D RID: 116877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C88D")]
		[Address(RVA = "0x15FC990", Offset = "0x15FB590", VA = "0x1815FC990")]
		public void Render(InformantInsightBarSliderItemView.Input input)
		{
		}

		// Token: 0x0601C88E RID: 116878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C88E")]
		[Address(RVA = "0x15FD180", Offset = "0x15FBD80", VA = "0x1815FD180")]
		private void _RenderFillAmount(InformantInsightBarSliderItemView.Input input)
		{
		}

		// Token: 0x0601C88F RID: 116879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C88F")]
		[Address(RVA = "0x15FCE30", Offset = "0x15FBA30", VA = "0x1815FCE30")]
		private void _ImgFillAmountSetter(float value)
		{
		}

		// Token: 0x0601C890 RID: 116880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C890")]
		[Address(RVA = "0x15FD030", Offset = "0x15FBC30", VA = "0x1815FD030")]
		private void _RenderDivLine(InformantInsightBarModel.SliderItemModel model)
		{
		}

		// Token: 0x0601C891 RID: 116881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C891")]
		[Address(RVA = "0x15FD470", Offset = "0x15FC070", VA = "0x1815FD470")]
		private void _RenderSingleDivLine(float value, RectTransform blackLine, Image blackLineImg, RectTransform whiteLine, Image whiteLineImg)
		{
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C892")]
		[Address(RVA = "0x15FCEC0", Offset = "0x15FBAC0", VA = "0x1815FCEC0")]
		private void _RenderChoiceDiff(InformantInsightBarModel.SliderItemModel model)
		{
		}

		// Token: 0x0601C893 RID: 116883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C893")]
		[Address(RVA = "0x15FD820", Offset = "0x15FC420", VA = "0x1815FD820")]
		private void _SetImgAlpha(Image img, float alpha)
		{
		}

		// Token: 0x0601C894 RID: 116884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C894")]
		[Address(RVA = "0x15FD940", Offset = "0x15FC540", VA = "0x1815FD940")]
		public InformantInsightBarSliderItemView()
		{
		}

		// Token: 0x04025698 RID: 153240
		[Token(Token = "0x4025698")]
		private const float NORMALIZED_UNIT = 1f;

		// Token: 0x04025699 RID: 153241
		[Token(Token = "0x4025699")]
		private const float DEFAULT_FILL_IMG_ALPHA = 1f;

		// Token: 0x0402569A RID: 153242
		[Token(Token = "0x402569A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _fillImg;

		// Token: 0x0402569B RID: 153243
		[Token(Token = "0x402569B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Div Line")]
		private GameObject[] _divLinePanels;

		// Token: 0x0402569C RID: 153244
		[Token(Token = "0x402569C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Div Line")]
		private float _radius;

		// Token: 0x0402569D RID: 153245
		[Token(Token = "0x402569D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Div Line")]
		private float _tabLineTotalWidth;

		// Token: 0x0402569E RID: 153246
		[Token(Token = "0x402569E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Div Line")]
		private RectTransform _rcWhiteDivLineRect;

		// Token: 0x0402569F RID: 153247
		[Token(Token = "0x402569F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Div Line")]
		private Image _rcWhiteDivLine;

		// Token: 0x040256A0 RID: 153248
		[Token(Token = "0x40256A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Div Line")]
		private RectTransform _rcBlackDivLineRect;

		// Token: 0x040256A1 RID: 153249
		[Token(Token = "0x40256A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Div Line")]
		private Image _rcBlackDivLine;

		// Token: 0x040256A2 RID: 153250
		[Token(Token = "0x40256A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Div Line")]
		private TwoStateToggle _rcReachToggle;

		// Token: 0x040256A3 RID: 153251
		[Token(Token = "0x40256A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Div Line")]
		private RectTransform _maxWhiteDivLineRect;

		// Token: 0x040256A4 RID: 153252
		[Token(Token = "0x40256A4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Div Line")]
		private Image _maxWhiteDivLine;

		// Token: 0x040256A5 RID: 153253
		[Token(Token = "0x40256A5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Div Line")]
		private RectTransform _maxBlackDivLineRect;

		// Token: 0x040256A6 RID: 153254
		[Token(Token = "0x40256A6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Div Line")]
		private Image _maxBlackDivLine;

		// Token: 0x040256A7 RID: 153255
		[Token(Token = "0x40256A7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Div Line")]
		private TwoStateToggle _maxReachToggle;

		// Token: 0x040256A8 RID: 153256
		[Token(Token = "0x40256A8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Choice Diff")]
		private GameObject[] _choiceDiffPanels;

		// Token: 0x040256A9 RID: 153257
		[Token(Token = "0x40256A9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Choice Diff")]
		private InformantArrowComponent _choiceArrow;

		// Token: 0x040256AA RID: 153258
		[Token(Token = "0x40256AA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Choice Diff")]
		private Image _choiceFillImg;

		// Token: 0x040256AB RID: 153259
		[Token(Token = "0x40256AB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Choice Diff")]
		private float _choiceHigherImgAlpha;

		// Token: 0x040256AC RID: 153260
		[Token(Token = "0x40256AC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Choice Diff")]
		private UITweenColor _fillImgTweenColor;

		// Token: 0x040256AD RID: 153261
		[Token(Token = "0x40256AD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Choice Diff")]
		private UITweenColor _choiceFillImgTweenColor;

		// Token: 0x040256AE RID: 153262
		[Token(Token = "0x40256AE")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_fillImgTween;

		// Token: 0x040256AF RID: 153263
		[Token(Token = "0x40256AF")]
		[FieldOffset(Offset = "0xB8")]
		private float m_cacheFillImgAmount;

		// Token: 0x040256B0 RID: 153264
		[Token(Token = "0x40256B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040256B1 RID: 153265
		[Token(Token = "0x40256B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderFillAmount;

		// Token: 0x040256B2 RID: 153266
		[Token(Token = "0x40256B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ImgFillAmountSetter;

		// Token: 0x040256B3 RID: 153267
		[Token(Token = "0x40256B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDivLine;

		// Token: 0x040256B4 RID: 153268
		[Token(Token = "0x40256B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSingleDivLine;

		// Token: 0x040256B5 RID: 153269
		[Token(Token = "0x40256B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderChoiceDiff;

		// Token: 0x040256B6 RID: 153270
		[Token(Token = "0x40256B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetImgAlpha;

		// Token: 0x040256B7 RID: 153271
		[Token(Token = "0x40256B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A16 RID: 18966
		[Token(Token = "0x2004A16")]
		public struct Input
		{
			// Token: 0x040256B8 RID: 153272
			[Token(Token = "0x40256B8")]
			[FieldOffset(Offset = "0x0")]
			public InformantInsightBarModel.SliderItemModel model;

			// Token: 0x040256B9 RID: 153273
			[Token(Token = "0x40256B9")]
			[FieldOffset(Offset = "0x8")]
			public bool showDivLine;

			// Token: 0x040256BA RID: 153274
			[Token(Token = "0x40256BA")]
			[FieldOffset(Offset = "0x9")]
			public bool showChoiceDiff;

			// Token: 0x040256BB RID: 153275
			[Token(Token = "0x40256BB")]
			[FieldOffset(Offset = "0xA")]
			public bool isFastMode;

			// Token: 0x040256BC RID: 153276
			[Token(Token = "0x40256BC")]
			[FieldOffset(Offset = "0xC")]
			public float duration;

			// Token: 0x040256BD RID: 153277
			[Token(Token = "0x40256BD")]
			[FieldOffset(Offset = "0x10")]
			public float delay;
		}
	}
}
