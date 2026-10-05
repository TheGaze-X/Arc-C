using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ECD RID: 20173
	[Token(Token = "0x2004ECD")]
	public class FifthAnnivExploreValueView : FifthAnnivExploreValueAbstractView
	{
		// Token: 0x0601E190 RID: 123280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E190")]
		[Address(RVA = "0x17DB410", Offset = "0x17DA010", VA = "0x1817DB410", Slot = "4")]
		public override void Render(FifthAnnivExploreValueViewConfig config, FifthAnnivExploreValueViewModel viewModel, bool showNum)
		{
		}

		// Token: 0x0601E191 RID: 123281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E191")]
		[Address(RVA = "0x17DBA50", Offset = "0x17DA650", VA = "0x1817DBA50")]
		private void _SetScaleWithTween(float contentScale, float deltaScale)
		{
		}

		// Token: 0x0601E192 RID: 123282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E192")]
		[Address(RVA = "0x17DB900", Offset = "0x17DA500", VA = "0x1817DB900")]
		private void _RefreshScale()
		{
		}

		// Token: 0x0601E193 RID: 123283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E193")]
		[Address(RVA = "0x17DBD20", Offset = "0x17DA920", VA = "0x1817DBD20")]
		public FifthAnnivExploreValueView()
		{
		}

		// Token: 0x040280A7 RID: 164007
		[Token(Token = "0x40280A7")]
		private const string NEGATIVE_DELTA_NUM_FORMAT = "({0})";

		// Token: 0x040280A8 RID: 164008
		[Token(Token = "0x40280A8")]
		private const string POSITIVE_DELTA_NUM_FORMAT = "(+{0})";

		// Token: 0x040280A9 RID: 164009
		[Token(Token = "0x40280A9")]
		private const float TWEEN_DURATION = 0.17f;

		// Token: 0x040280AA RID: 164010
		[Token(Token = "0x40280AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _contentImg;

		// Token: 0x040280AB RID: 164011
		[Token(Token = "0x40280AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _deltaImg;

		// Token: 0x040280AC RID: 164012
		[Token(Token = "0x40280AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _contentTransform;

		// Token: 0x040280AD RID: 164013
		[Token(Token = "0x40280AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _deltaTransform;

		// Token: 0x040280AE RID: 164014
		[Token(Token = "0x40280AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _contentNumText;

		// Token: 0x040280AF RID: 164015
		[Token(Token = "0x40280AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _deltaNumText;

		// Token: 0x040280B0 RID: 164016
		[Token(Token = "0x40280B0")]
		[FieldOffset(Offset = "0x48")]
		private float m_contentScale;

		// Token: 0x040280B1 RID: 164017
		[Token(Token = "0x40280B1")]
		[FieldOffset(Offset = "0x4C")]
		private float m_deltaScale;

		// Token: 0x040280B2 RID: 164018
		[Token(Token = "0x40280B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040280B3 RID: 164019
		[Token(Token = "0x40280B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetScaleWithTween;

		// Token: 0x040280B4 RID: 164020
		[Token(Token = "0x40280B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshScale;

		// Token: 0x040280B5 RID: 164021
		[Token(Token = "0x40280B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
