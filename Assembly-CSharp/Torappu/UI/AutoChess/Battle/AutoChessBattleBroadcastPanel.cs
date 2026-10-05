using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006491 RID: 25745
	[Token(Token = "0x2006491")]
	public class AutoChessBattleBroadcastPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602506D RID: 151661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602506D")]
		[Address(RVA = "0x1FDD310", Offset = "0x1FDBF10", VA = "0x181FDD310")]
		public void OnRevMsg(AutoChessBroadcastMsg msg)
		{
		}

		// Token: 0x0602506E RID: 151662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602506E")]
		[Address(RVA = "0x1FDD5A0", Offset = "0x1FDC1A0", VA = "0x181FDD5A0")]
		private void _TryPlayMsg()
		{
		}

		// Token: 0x0602506F RID: 151663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602506F")]
		[Address(RVA = "0x1FDD3B0", Offset = "0x1FDBFB0", VA = "0x181FDD3B0")]
		private void _OnFillMsg()
		{
		}

		// Token: 0x06025070 RID: 151664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025070")]
		[Address(RVA = "0x1FDD510", Offset = "0x1FDC110", VA = "0x181FDD510")]
		private void _OnPlayComplete()
		{
		}

		// Token: 0x06025071 RID: 151665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025071")]
		[Address(RVA = "0x1FDD960", Offset = "0x1FDC560", VA = "0x181FDD960")]
		public AutoChessBattleBroadcastPanel()
		{
		}

		// Token: 0x04033D52 RID: 212306
		[Token(Token = "0x4033D52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _msgItemAnim;

		// Token: 0x04033D53 RID: 212307
		[Token(Token = "0x4033D53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _msgLabel;

		// Token: 0x04033D54 RID: 212308
		[Token(Token = "0x4033D54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _firstDelay;

		// Token: 0x04033D55 RID: 212309
		[Token(Token = "0x4033D55")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessBroadcastMsg m_waitingMsg;

		// Token: 0x04033D56 RID: 212310
		[Token(Token = "0x4033D56")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_playTween;

		// Token: 0x04033D57 RID: 212311
		[Token(Token = "0x4033D57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRevMsg;

		// Token: 0x04033D58 RID: 212312
		[Token(Token = "0x4033D58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryPlayMsg;

		// Token: 0x04033D59 RID: 212313
		[Token(Token = "0x4033D59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFillMsg;

		// Token: 0x04033D5A RID: 212314
		[Token(Token = "0x4033D5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPlayComplete;

		// Token: 0x04033D5B RID: 212315
		[Token(Token = "0x4033D5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
