using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004848 RID: 18504
	[Token(Token = "0x2004848")]
	public class MissionArchiveHintView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BF38 RID: 114488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF38")]
		[Address(RVA = "0x1550150", Offset = "0x154ED50", VA = "0x181550150")]
		public void Reset()
		{
		}

		// Token: 0x0601BF39 RID: 114489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF39")]
		[Address(RVA = "0x15501E0", Offset = "0x154EDE0", VA = "0x1815501E0")]
		public void ShowHint(string hint)
		{
		}

		// Token: 0x0601BF3A RID: 114490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF3A")]
		[Address(RVA = "0x15500A0", Offset = "0x154ECA0", VA = "0x1815500A0")]
		public void HideHint()
		{
		}

		// Token: 0x0601BF3B RID: 114491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF3B")]
		[Address(RVA = "0x15502E0", Offset = "0x154EEE0", VA = "0x1815502E0")]
		private Sequence _SequenceOfShowHint(string hint)
		{
			return null;
		}

		// Token: 0x0601BF3C RID: 114492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF3C")]
		[Address(RVA = "0x1550500", Offset = "0x154F100", VA = "0x181550500")]
		public MissionArchiveHintView()
		{
		}

		// Token: 0x0402472B RID: 149291
		[Token(Token = "0x402472B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _hintGroup;

		// Token: 0x0402472C RID: 149292
		[Token(Token = "0x402472C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _hintText;

		// Token: 0x0402472D RID: 149293
		[Token(Token = "0x402472D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _hintDuration;

		// Token: 0x0402472E RID: 149294
		[Token(Token = "0x402472E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _hintFadeDuration;

		// Token: 0x0402472F RID: 149295
		[Token(Token = "0x402472F")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedHint;

		// Token: 0x04024730 RID: 149296
		[Token(Token = "0x4024730")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_hintTween;

		// Token: 0x04024731 RID: 149297
		[Token(Token = "0x4024731")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04024732 RID: 149298
		[Token(Token = "0x4024732")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowHint;

		// Token: 0x04024733 RID: 149299
		[Token(Token = "0x4024733")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideHint;

		// Token: 0x04024734 RID: 149300
		[Token(Token = "0x4024734")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SequenceOfShowHint;

		// Token: 0x04024735 RID: 149301
		[Token(Token = "0x4024735")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
