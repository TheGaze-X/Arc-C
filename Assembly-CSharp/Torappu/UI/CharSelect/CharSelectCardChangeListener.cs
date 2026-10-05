using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E19 RID: 24089
	[Token(Token = "0x2005E19")]
	public class CharSelectCardChangeListener : DataBinder<CharAttrViewProperty>
	{
		// Token: 0x06022E91 RID: 142993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E91")]
		[Address(RVA = "0x1D65080", Offset = "0x1D63C80", VA = "0x181D65080", Slot = "7")]
		public override void OnValueChanged(CharAttrViewProperty property)
		{
		}

		// Token: 0x06022E92 RID: 142994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E92")]
		[Address(RVA = "0x1D65260", Offset = "0x1D63E60", VA = "0x181D65260")]
		public CharSelectCardChangeListener()
		{
		}

		// Token: 0x04030150 RID: 196944
		[Token(Token = "0x4030150")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharSelectCardListAdapter _adapter;

		// Token: 0x04030151 RID: 196945
		[Token(Token = "0x4030151")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030152 RID: 196946
		[Token(Token = "0x4030152")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
