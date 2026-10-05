using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C11 RID: 19473
	[Token(Token = "0x2004C11")]
	public class HomeMaxAPView : DataBinder<IntProperty>
	{
		// Token: 0x0601D41D RID: 119837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41D")]
		[Address(RVA = "0x16D57A0", Offset = "0x16D43A0", VA = "0x1816D57A0", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x0601D41E RID: 119838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D41E")]
		[Address(RVA = "0x16D5920", Offset = "0x16D4520", VA = "0x1816D5920")]
		public HomeMaxAPView()
		{
		}

		// Token: 0x04026756 RID: 157526
		[Token(Token = "0x4026756")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _apValue;

		// Token: 0x04026757 RID: 157527
		[Token(Token = "0x4026757")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _apShadow;

		// Token: 0x04026758 RID: 157528
		[Token(Token = "0x4026758")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026759 RID: 157529
		[Token(Token = "0x4026759")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
