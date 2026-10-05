using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F71 RID: 8049
	[Token(Token = "0x2001F71")]
	[RequireComponent(typeof(CanvasGroup))]
	public class AVGTimerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C800 RID: 51200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C800")]
		[Address(RVA = "0x3492530", Offset = "0x3491130", VA = "0x183492530")]
		public void RenderTimer(Vector2 pos, Vector2 size, int fontSize, long totalTimeSec, float aFrom, float aTo, float duration)
		{
		}

		// Token: 0x0600C801 RID: 51201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C801")]
		[Address(RVA = "0x3492840", Offset = "0x3491440", VA = "0x183492840")]
		public void StopTimer(float duration)
		{
		}

		// Token: 0x0600C802 RID: 51202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C802")]
		[Address(RVA = "0x3492990", Offset = "0x3491590", VA = "0x183492990")]
		private void Update()
		{
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C803")]
		[Address(RVA = "0x3492CA0", Offset = "0x34918A0", VA = "0x183492CA0")]
		private void _StartCountTimer(long totalTimeSec)
		{
		}

		// Token: 0x0600C804 RID: 51204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C804")]
		[Address(RVA = "0x3492AE0", Offset = "0x34916E0", VA = "0x183492AE0")]
		private void _ShowTimer(float aFrom, float aTo, float duration)
		{
		}

		// Token: 0x0600C805 RID: 51205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C805")]
		[Address(RVA = "0x3492FE0", Offset = "0x3491BE0", VA = "0x183492FE0")]
		private void _TimerEnd()
		{
		}

		// Token: 0x0600C806 RID: 51206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C806")]
		[Address(RVA = "0x3493050", Offset = "0x3491C50", VA = "0x183493050")]
		private void _TimerTick(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0600C807 RID: 51207 RVA: 0x00048C90 File Offset: 0x00046E90
		[Token(Token = "0x600C807")]
		[Address(RVA = "0x3492A00", Offset = "0x3491600", VA = "0x183492A00")]
		private CountDownTask.TickValue _OverrideTimerTaskTick(TaskTimer<CountDownTask.TickValue>.Context context)
		{
			return default(CountDownTask.TickValue);
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C808")]
		[Address(RVA = "0x34931E0", Offset = "0x3491DE0", VA = "0x1834931E0")]
		public AVGTimerView()
		{
		}

		// Token: 0x0400CE58 RID: 52824
		[Token(Token = "0x400CE58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _message;

		// Token: 0x0400CE59 RID: 52825
		[Token(Token = "0x400CE59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _textTransform;

		// Token: 0x0400CE5A RID: 52826
		[Token(Token = "0x400CE5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0400CE5B RID: 52827
		[Token(Token = "0x400CE5B")]
		private const float DEFAULT_DURATION = 0.13f;

		// Token: 0x0400CE5C RID: 52828
		[Token(Token = "0x400CE5C")]
		[FieldOffset(Offset = "0x30")]
		private CountDownTask m_countTimerTask;

		// Token: 0x0400CE5D RID: 52829
		[Token(Token = "0x400CE5D")]
		[FieldOffset(Offset = "0x38")]
		private Tweener m_timerTween;

		// Token: 0x0400CE5E RID: 52830
		[Token(Token = "0x400CE5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTimer;

		// Token: 0x0400CE5F RID: 52831
		[Token(Token = "0x400CE5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StopTimer;

		// Token: 0x0400CE60 RID: 52832
		[Token(Token = "0x400CE60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400CE61 RID: 52833
		[Token(Token = "0x400CE61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartCountTimer;

		// Token: 0x0400CE62 RID: 52834
		[Token(Token = "0x400CE62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowTimer;

		// Token: 0x0400CE63 RID: 52835
		[Token(Token = "0x400CE63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TimerEnd;

		// Token: 0x0400CE64 RID: 52836
		[Token(Token = "0x400CE64")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TimerTick;

		// Token: 0x0400CE65 RID: 52837
		[Token(Token = "0x400CE65")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OverrideTimerTaskTick;

		// Token: 0x0400CE66 RID: 52838
		[Token(Token = "0x400CE66")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
