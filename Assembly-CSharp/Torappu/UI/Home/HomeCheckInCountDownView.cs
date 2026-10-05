using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE2 RID: 19426
	[Token(Token = "0x2004BE2")]
	public class HomeCheckInCountDownView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D322 RID: 119586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D322")]
		[Address(RVA = "0x16C22A0", Offset = "0x16C0EA0", VA = "0x1816C22A0", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D323 RID: 119587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D323")]
		[Address(RVA = "0x16C2680", Offset = "0x16C1280", VA = "0x1816C2680")]
		private void _ProcessCountDown()
		{
		}

		// Token: 0x0601D324 RID: 119588 RVA: 0x000AADA8 File Offset: 0x000A8FA8
		[Token(Token = "0x601D324")]
		[Address(RVA = "0x16C2420", Offset = "0x16C1020", VA = "0x1816C2420")]
		private long _GetRemainSeconds()
		{
			return 0L;
		}

		// Token: 0x0601D325 RID: 119589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D325")]
		[Address(RVA = "0x16C24D0", Offset = "0x16C10D0", VA = "0x1816C24D0")]
		private void _OnTimeTick(CountDownTask.TickValue value)
		{
		}

		// Token: 0x0601D326 RID: 119590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D326")]
		[Address(RVA = "0x16C23B0", Offset = "0x16C0FB0", VA = "0x1816C23B0")]
		private void Update()
		{
		}

		// Token: 0x0601D327 RID: 119591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D327")]
		[Address(RVA = "0x16C28D0", Offset = "0x16C14D0", VA = "0x1816C28D0")]
		public HomeCheckInCountDownView()
		{
		}

		// Token: 0x0402655B RID: 157019
		[Token(Token = "0x402655B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x0402655C RID: 157020
		[Token(Token = "0x402655C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBtnNormal;

		// Token: 0x0402655D RID: 157021
		[Token(Token = "0x402655D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBtnAlreadyCheckIn;

		// Token: 0x0402655E RID: 157022
		[Token(Token = "0x402655E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBtnUnclickable;

		// Token: 0x0402655F RID: 157023
		[Token(Token = "0x402655F")]
		[FieldOffset(Offset = "0x40")]
		private CountDownTask m_countDownTask;

		// Token: 0x04026560 RID: 157024
		[Token(Token = "0x4026560")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026561 RID: 157025
		[Token(Token = "0x4026561")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ProcessCountDown;

		// Token: 0x04026562 RID: 157026
		[Token(Token = "0x4026562")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetRemainSeconds;

		// Token: 0x04026563 RID: 157027
		[Token(Token = "0x4026563")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTimeTick;

		// Token: 0x04026564 RID: 157028
		[Token(Token = "0x4026564")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04026565 RID: 157029
		[Token(Token = "0x4026565")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
