using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F12 RID: 20242
	[Token(Token = "0x2004F12")]
	public class FifthAnnivExploreSideValueView : FifthAnnivExploreValueAbstractView
	{
		// Token: 0x0601E2AD RID: 123565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2AD")]
		[Address(RVA = "0x17D8CB0", Offset = "0x17D78B0", VA = "0x1817D8CB0", Slot = "4")]
		public override void Render(FifthAnnivExploreValueViewConfig config, FifthAnnivExploreValueViewModel viewModel, bool showNum)
		{
		}

		// Token: 0x0601E2AE RID: 123566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E2AE")]
		[Address(RVA = "0x17D8F60", Offset = "0x17D7B60", VA = "0x1817D8F60")]
		private string _GetDeltaText(bool isPositiveDelta, int deltaValue)
		{
			return null;
		}

		// Token: 0x0601E2AF RID: 123567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2AF")]
		[Address(RVA = "0x17D9040", Offset = "0x17D7C40", VA = "0x1817D9040")]
		private void _ShowDeltaAnim(float oriScale, float finScale, int currentValue, int deltaValue)
		{
		}

		// Token: 0x0601E2B0 RID: 123568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2B0")]
		[Address(RVA = "0x17D9510", Offset = "0x17D8110", VA = "0x1817D9510")]
		public FifthAnnivExploreSideValueView()
		{
		}

		// Token: 0x040282AE RID: 164526
		[Token(Token = "0x40282AE")]
		private const string NEGATIVE_DELTA_NUM_FORMAT = "({0})";

		// Token: 0x040282AF RID: 164527
		[Token(Token = "0x40282AF")]
		private const string POSITIVE_DELTA_NUM_FORMAT = "(+{0})";

		// Token: 0x040282B0 RID: 164528
		[Token(Token = "0x40282B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTransformCurrent;

		// Token: 0x040282B1 RID: 164529
		[Token(Token = "0x40282B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectTransformDelta;

		// Token: 0x040282B2 RID: 164530
		[Token(Token = "0x40282B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroupTextDelta;

		// Token: 0x040282B3 RID: 164531
		[Token(Token = "0x40282B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtCurrent;

		// Token: 0x040282B4 RID: 164532
		[Token(Token = "0x40282B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtDelta;

		// Token: 0x040282B5 RID: 164533
		[Token(Token = "0x40282B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x040282B6 RID: 164534
		[Token(Token = "0x40282B6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _tweenDelay;

		// Token: 0x040282B7 RID: 164535
		[Token(Token = "0x40282B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _txtFadeDuration;

		// Token: 0x040282B8 RID: 164536
		[Token(Token = "0x40282B8")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_deltaTween;

		// Token: 0x040282B9 RID: 164537
		[Token(Token = "0x40282B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040282BA RID: 164538
		[Token(Token = "0x40282BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetDeltaText;

		// Token: 0x040282BB RID: 164539
		[Token(Token = "0x40282BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowDeltaAnim;

		// Token: 0x040282BC RID: 164540
		[Token(Token = "0x40282BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
