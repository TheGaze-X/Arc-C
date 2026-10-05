using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200481A RID: 18458
	[Token(Token = "0x200481A")]
	public class MonopolyTopBuffBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BE88 RID: 114312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE88")]
		[Address(RVA = "0x1547A10", Offset = "0x1546610", VA = "0x181547A10")]
		public void Render(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BE89 RID: 114313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BE89")]
		[Address(RVA = "0x1547BE0", Offset = "0x15467E0", VA = "0x181547BE0")]
		private Tween _SampleProgWithTween(int value, int target, bool isFastMode)
		{
			return null;
		}

		// Token: 0x0601BE8A RID: 114314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE8A")]
		[Address(RVA = "0x15478E0", Offset = "0x15464E0", VA = "0x1815478E0")]
		public void OnClickBuffWindowBtn()
		{
		}

		// Token: 0x0601BE8B RID: 114315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE8B")]
		[Address(RVA = "0x1547970", Offset = "0x1546570", VA = "0x181547970")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601BE8C RID: 114316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE8C")]
		[Address(RVA = "0x1548330", Offset = "0x1546F30", VA = "0x181548330")]
		public MonopolyTopBuffBar()
		{
		}

		// Token: 0x04024618 RID: 149016
		[Token(Token = "0x4024618")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _progObj;

		// Token: 0x04024619 RID: 149017
		[Token(Token = "0x4024619")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _progSampleAnimLocation;

		// Token: 0x0402461A RID: 149018
		[Token(Token = "0x402461A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _buffActiveAnimLocation;

		// Token: 0x0402461B RID: 149019
		[Token(Token = "0x402461B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _progSampleDuration;

		// Token: 0x0402461C RID: 149020
		[Token(Token = "0x402461C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _buffImgIcon;

		// Token: 0x0402461D RID: 149021
		[Token(Token = "0x402461D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _resetZeroInterval;

		// Token: 0x0402461E RID: 149022
		[Token(Token = "0x402461E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _activeTweenDelay;

		// Token: 0x0402461F RID: 149023
		[Token(Token = "0x402461F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _resetZeroSecondTweenInterval;

		// Token: 0x04024620 RID: 149024
		[Token(Token = "0x4024620")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _buffPanelTutorialGo;

		// Token: 0x04024621 RID: 149025
		[Token(Token = "0x4024621")]
		[FieldOffset(Offset = "0x68")]
		private float m_curProgValue;

		// Token: 0x04024622 RID: 149026
		[Token(Token = "0x4024622")]
		[FieldOffset(Offset = "0x6C")]
		private int m_enterSequenceNum;

		// Token: 0x04024623 RID: 149027
		[Token(Token = "0x4024623")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_progSampleTween;

		// Token: 0x04024624 RID: 149028
		[Token(Token = "0x4024624")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024625 RID: 149029
		[Token(Token = "0x4024625")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_buffActiveTween;

		// Token: 0x04024626 RID: 149030
		[Token(Token = "0x4024626")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024627 RID: 149031
		[Token(Token = "0x4024627")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SampleProgWithTween;

		// Token: 0x04024628 RID: 149032
		[Token(Token = "0x4024628")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickBuffWindowBtn;

		// Token: 0x04024629 RID: 149033
		[Token(Token = "0x4024629")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402462A RID: 149034
		[Token(Token = "0x402462A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
