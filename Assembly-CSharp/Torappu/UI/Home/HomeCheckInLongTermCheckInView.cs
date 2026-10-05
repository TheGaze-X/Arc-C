using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BE8 RID: 19432
	[Token(Token = "0x2004BE8")]
	public class HomeCheckInLongTermCheckInView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D33F RID: 119615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D33F")]
		[Address(RVA = "0x16C3760", Offset = "0x16C2360", VA = "0x1816C3760", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D340 RID: 119616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D340")]
		[Address(RVA = "0x16C36D0", Offset = "0x16C22D0", VA = "0x1816C36D0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x0601D341 RID: 119617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D341")]
		[Address(RVA = "0x16C3840", Offset = "0x16C2440", VA = "0x1816C3840")]
		public HomeCheckInLongTermCheckInView()
		{
		}

		// Token: 0x0402659A RID: 157082
		[Token(Token = "0x402659A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelCheckIn;

		// Token: 0x0402659B RID: 157083
		[Token(Token = "0x402659B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBtnNormal;

		// Token: 0x0402659C RID: 157084
		[Token(Token = "0x402659C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0402659D RID: 157085
		[Token(Token = "0x402659D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBtnNew;

		// Token: 0x0402659E RID: 157086
		[Token(Token = "0x402659E")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402659F RID: 157087
		[Token(Token = "0x402659F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040265A0 RID: 157088
		[Token(Token = "0x40265A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x040265A1 RID: 157089
		[Token(Token = "0x40265A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
