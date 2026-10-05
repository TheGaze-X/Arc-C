using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005294 RID: 21140
	[Token(Token = "0x2005294")]
	public class RoguelikeClassicEndingNormalScoreGpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F314 RID: 127764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F314")]
		[Address(RVA = "0x18E2400", Offset = "0x18E1000", VA = "0x1818E2400")]
		public void Render(RoguelikeClassicEndingNormalViewModel viewModel, bool fastMode)
		{
		}

		// Token: 0x0601F315 RID: 127765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F315")]
		[Address(RVA = "0x18E2770", Offset = "0x18E1370", VA = "0x1818E2770")]
		private void _GetGpRank(int gp, int gpRatio, out int rank, out int remainder)
		{
		}

		// Token: 0x0601F316 RID: 127766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F316")]
		[Address(RVA = "0x18E2820", Offset = "0x18E1420", VA = "0x1818E2820")]
		private void _SetGpText(int gp, int accumulation, int maxAccumulation)
		{
		}

		// Token: 0x0601F317 RID: 127767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F317")]
		[Address(RVA = "0x18E2950", Offset = "0x18E1550", VA = "0x1818E2950")]
		private void _SetProgress(int gpScore, int gpRatio, int accumulation, int maxAccumulation)
		{
		}

		// Token: 0x0601F318 RID: 127768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F318")]
		[Address(RVA = "0x18E26C0", Offset = "0x18E12C0", VA = "0x1818E26C0")]
		public IEnumerator TweenToTarget()
		{
			return null;
		}

		// Token: 0x0601F319 RID: 127769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F319")]
		[Address(RVA = "0x18E2A40", Offset = "0x18E1640", VA = "0x1818E2A40")]
		public RoguelikeClassicEndingNormalScoreGpView()
		{
		}

		// Token: 0x04029DE2 RID: 171490
		[Token(Token = "0x4029DE2")]
		private const string GP_SCORE_PREFIX = "+{0}";

		// Token: 0x04029DE3 RID: 171491
		[Token(Token = "0x4029DE3")]
		private const float GP_SCORE_PROGRESS_DURATION = 0.5f;

		// Token: 0x04029DE4 RID: 171492
		[Token(Token = "0x4029DE4")]
		private const float GP_SCORE_PROGRESS_INTERVAL = 0.3f;

		// Token: 0x04029DE5 RID: 171493
		[Token(Token = "0x4029DE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textGpNum;

		// Token: 0x04029DE6 RID: 171494
		[Token(Token = "0x4029DE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _gpProgressBar;

		// Token: 0x04029DE7 RID: 171495
		[Token(Token = "0x4029DE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _progressBarSize;

		// Token: 0x04029DE8 RID: 171496
		[Token(Token = "0x4029DE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x04029DE9 RID: 171497
		[Token(Token = "0x4029DE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _maxPart;

		// Token: 0x04029DEA RID: 171498
		[Token(Token = "0x4029DEA")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeClassicEndingNormalViewModel m_cachedModel;

		// Token: 0x04029DEB RID: 171499
		[Token(Token = "0x4029DEB")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_cachedTween;

		// Token: 0x04029DEC RID: 171500
		[Token(Token = "0x4029DEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029DED RID: 171501
		[Token(Token = "0x4029DED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetGpRank;

		// Token: 0x04029DEE RID: 171502
		[Token(Token = "0x4029DEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetGpText;

		// Token: 0x04029DEF RID: 171503
		[Token(Token = "0x4029DEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetProgress;

		// Token: 0x04029DF0 RID: 171504
		[Token(Token = "0x4029DF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TweenToTarget;

		// Token: 0x04029DF1 RID: 171505
		[Token(Token = "0x4029DF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
