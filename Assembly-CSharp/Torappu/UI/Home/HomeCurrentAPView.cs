using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C06 RID: 19462
	[Token(Token = "0x2004C06")]
	public class HomeCurrentAPView : DataBinder<IntProperty>
	{
		// Token: 0x0601D3C2 RID: 119746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C2")]
		[Address(RVA = "0x16C9E80", Offset = "0x16C8A80", VA = "0x1816C9E80", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x0601D3C3 RID: 119747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C3")]
		[Address(RVA = "0x16C9FF0", Offset = "0x16C8BF0", VA = "0x1816C9FF0")]
		public HomeCurrentAPView()
		{
		}

		// Token: 0x040266C3 RID: 157379
		[Token(Token = "0x40266C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _apValue;

		// Token: 0x040266C4 RID: 157380
		[Token(Token = "0x40266C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _apShadow;

		// Token: 0x040266C5 RID: 157381
		[Token(Token = "0x40266C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040266C6 RID: 157382
		[Token(Token = "0x40266C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
