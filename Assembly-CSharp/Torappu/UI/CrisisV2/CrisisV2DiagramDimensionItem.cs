using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200591C RID: 22812
	[Token(Token = "0x200591C")]
	public class CrisisV2DiagramDimensionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060213E7 RID: 136167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E7")]
		[Address(RVA = "0x1B8E480", Offset = "0x1B8D080", VA = "0x181B8E480")]
		public void SetStyleConfig(CrisisV2DiagramInput.StyleConfig config)
		{
		}

		// Token: 0x060213E8 RID: 136168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E8")]
		[Address(RVA = "0x1B8E300", Offset = "0x1B8CF00", VA = "0x181B8E300")]
		public void RenderScore(CrisisV2DiagramDimensionItem.DimensionInput input)
		{
		}

		// Token: 0x060213E9 RID: 136169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213E9")]
		[Address(RVA = "0x1B8E800", Offset = "0x1B8D400", VA = "0x181B8E800")]
		private void _RenderScoreSlider(Slider slider, float endVal, bool needTween, ref Tween tween, CrisisV2DiagramInput.TweenInput tweenInput)
		{
		}

		// Token: 0x060213EA RID: 136170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213EA")]
		[Address(RVA = "0x1B8E760", Offset = "0x1B8D360", VA = "0x181B8E760")]
		private void _CorrectBorderWidth()
		{
		}

		// Token: 0x060213EB RID: 136171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213EB")]
		[Address(RVA = "0x1B8EAD0", Offset = "0x1B8D6D0", VA = "0x181B8EAD0")]
		public CrisisV2DiagramDimensionItem()
		{
		}

		// Token: 0x0402D464 RID: 185444
		[Token(Token = "0x402D464")]
		private const float BORDER_WIDTH = 1.8f;

		// Token: 0x0402D465 RID: 185445
		[Token(Token = "0x402D465")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Highest Total")]
		private Slider _highestTotal;

		// Token: 0x0402D466 RID: 185446
		[Token(Token = "0x402D466")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Highest Total")]
		private UIAtlasImage _totalColor;

		// Token: 0x0402D467 RID: 185447
		[Token(Token = "0x402D467")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Highest Total")]
		private GameObject _totalGo;

		// Token: 0x0402D468 RID: 185448
		[Token(Token = "0x402D468")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Highest Single")]
		private Slider _highestSingle;

		// Token: 0x0402D469 RID: 185449
		[Token(Token = "0x402D469")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Highest Single")]
		private GameObject _singleGo;

		// Token: 0x0402D46A RID: 185450
		[Token(Token = "0x402D46A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Current")]
		private Slider _current;

		// Token: 0x0402D46B RID: 185451
		[Token(Token = "0x402D46B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Current")]
		private UIAtlasImage _currentColor;

		// Token: 0x0402D46C RID: 185452
		[Token(Token = "0x402D46C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Current")]
		private GameObject _currentGo;

		// Token: 0x0402D46D RID: 185453
		[Token(Token = "0x402D46D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Border")]
		private RectTransform _currentScoreBorder;

		// Token: 0x0402D46E RID: 185454
		[Token(Token = "0x402D46E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Border")]
		private RectTransform _highestTotalScoreBorder;

		// Token: 0x0402D46F RID: 185455
		[Token(Token = "0x402D46F")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_highestTotalTween;

		// Token: 0x0402D470 RID: 185456
		[Token(Token = "0x402D470")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_highestSingleTween;

		// Token: 0x0402D471 RID: 185457
		[Token(Token = "0x402D471")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_currentTween;

		// Token: 0x0402D472 RID: 185458
		[Token(Token = "0x402D472")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetStyleConfig;

		// Token: 0x0402D473 RID: 185459
		[Token(Token = "0x402D473")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderScore;

		// Token: 0x0402D474 RID: 185460
		[Token(Token = "0x402D474")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderScoreSlider;

		// Token: 0x0402D475 RID: 185461
		[Token(Token = "0x402D475")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CorrectBorderWidth;

		// Token: 0x0402D476 RID: 185462
		[Token(Token = "0x402D476")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200591D RID: 22813
		[Token(Token = "0x200591D")]
		public struct DimensionInput
		{
			// Token: 0x0402D477 RID: 185463
			[Token(Token = "0x402D477")]
			[FieldOffset(Offset = "0x0")]
			public float totalEndVal;

			// Token: 0x0402D478 RID: 185464
			[Token(Token = "0x402D478")]
			[FieldOffset(Offset = "0x4")]
			public float singleEndVal;

			// Token: 0x0402D479 RID: 185465
			[Token(Token = "0x402D479")]
			[FieldOffset(Offset = "0x8")]
			public float currentEndVal;

			// Token: 0x0402D47A RID: 185466
			[Token(Token = "0x402D47A")]
			[FieldOffset(Offset = "0xC")]
			public bool needTween;

			// Token: 0x0402D47B RID: 185467
			[Token(Token = "0x402D47B")]
			[FieldOffset(Offset = "0x10")]
			public CrisisV2DiagramInput.TweenInput tweenInput;

			// Token: 0x0402D47C RID: 185468
			[Token(Token = "0x402D47C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CrisisV2DiagramDimensionItem.DimensionInput EMPTY;
		}
	}
}
