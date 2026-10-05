using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049CF RID: 18895
	[Token(Token = "0x20049CF")]
	public class LoginLoadingState : State
	{
		// Token: 0x0601C743 RID: 116547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C743")]
		[Address(RVA = "0x15DFCF0", Offset = "0x15DE8F0", VA = "0x1815DFCF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C744 RID: 116548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C744")]
		[Address(RVA = "0x15DFD50", Offset = "0x15DE950", VA = "0x1815DFD50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C745 RID: 116549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C745")]
		[Address(RVA = "0x15DFDF0", Offset = "0x15DE9F0", VA = "0x1815DFDF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C746 RID: 116550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C746")]
		[Address(RVA = "0x15DFEF0", Offset = "0x15DEAF0", VA = "0x1815DFEF0")]
		private IEnumerator _DoTrackProgress()
		{
			return null;
		}

		// Token: 0x0601C747 RID: 116551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C747")]
		[Address(RVA = "0x15DFFA0", Offset = "0x15DEBA0", VA = "0x1815DFFA0")]
		private void _OnAlmostCompleted()
		{
		}

		// Token: 0x0601C748 RID: 116552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C748")]
		[Address(RVA = "0x15E0000", Offset = "0x15DEC00", VA = "0x1815E0000")]
		private void _OnCompleted()
		{
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C749")]
		[Address(RVA = "0x15E0070", Offset = "0x15DEC70", VA = "0x1815E0070")]
		private void _OnFailed()
		{
		}

		// Token: 0x0601C74A RID: 116554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C74A")]
		[Address(RVA = "0x15E00E0", Offset = "0x15DECE0", VA = "0x1815E00E0")]
		private void _SetProgress(float progress)
		{
		}

		// Token: 0x0601C74B RID: 116555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C74B")]
		[Address(RVA = "0x15E0180", Offset = "0x15DED80", VA = "0x1815E0180")]
		public LoginLoadingState()
		{
		}

		// Token: 0x0601C74C RID: 116556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C74C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C74D RID: 116557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C74D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04025489 RID: 152713
		[Token(Token = "0x4025489")]
		private const float COMPLETED_HOLD_ON_TIME = 0.2f;

		// Token: 0x0402548A RID: 152714
		[Token(Token = "0x402548A")]
		private const float LOADING_PROG_SPEED = 0.5f;

		// Token: 0x0402548B RID: 152715
		[Token(Token = "0x402548B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _onCompleted;

		// Token: 0x0402548C RID: 152716
		[Token(Token = "0x402548C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UITextSlider _leftSlider;

		// Token: 0x0402548D RID: 152717
		[Token(Token = "0x402548D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UITextSlider _rightSlider;

		// Token: 0x0402548E RID: 152718
		[Token(Token = "0x402548E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402548F RID: 152719
		[Token(Token = "0x402548F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025490 RID: 152720
		[Token(Token = "0x4025490")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025491 RID: 152721
		[Token(Token = "0x4025491")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoTrackProgress;

		// Token: 0x04025492 RID: 152722
		[Token(Token = "0x4025492")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAlmostCompleted;

		// Token: 0x04025493 RID: 152723
		[Token(Token = "0x4025493")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCompleted;

		// Token: 0x04025494 RID: 152724
		[Token(Token = "0x4025494")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFailed;

		// Token: 0x04025495 RID: 152725
		[Token(Token = "0x4025495")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetProgress;

		// Token: 0x04025496 RID: 152726
		[Token(Token = "0x4025496")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
