using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033D1 RID: 13265
	[Token(Token = "0x20033D1")]
	public class UICooperateBattlePauseConfirmPanel : MonoBehaviour
	{
		// Token: 0x060152BC RID: 86716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BC")]
		[Address(RVA = "0xD9FD90", Offset = "0xD9E990", VA = "0x180D9FD90")]
		public void Init(PeriodicTimer timer)
		{
		}

		// Token: 0x060152BD RID: 86717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BD")]
		[Address(RVA = "0xD9FE90", Offset = "0xD9EA90", VA = "0x180D9FE90")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060152BE RID: 86718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICooperateBattlePauseConfirmPanel()
		{
		}

		// Token: 0x0401942F RID: 103471
		[Token(Token = "0x401942F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04019430 RID: 103472
		[Token(Token = "0x4019430")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04019431 RID: 103473
		[Token(Token = "0x4019431")]
		[FieldOffset(Offset = "0x30")]
		private PeriodicTimer m_waitingTimer;

		// Token: 0x04019432 RID: 103474
		[Token(Token = "0x4019432")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;
	}
}
