using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F9 RID: 26361
	[Token(Token = "0x20066F9")]
	public class HandBookV2MapFocusView : DataBinder<HandBookV2MapFocusProperty>
	{
		// Token: 0x06025D62 RID: 154978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D62")]
		[Address(RVA = "0x20C5120", Offset = "0x20C3D20", VA = "0x1820C5120", Slot = "7")]
		public override void OnValueChanged(HandBookV2MapFocusProperty property)
		{
		}

		// Token: 0x06025D63 RID: 154979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D63")]
		[Address(RVA = "0x20C51D0", Offset = "0x20C3DD0", VA = "0x1820C51D0")]
		public HandBookV2MapFocusView()
		{
		}

		// Token: 0x0403530C RID: 217868
		[Token(Token = "0x403530C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _contentRt;

		// Token: 0x0403530D RID: 217869
		[Token(Token = "0x403530D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403530E RID: 217870
		[Token(Token = "0x403530E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
