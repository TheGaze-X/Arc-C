using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB8 RID: 31416
	[Token(Token = "0x2007AB8")]
	public class Act12sideMissionMiniView : DataBinder<Act12sideMissionProperty>
	{
		// Token: 0x0602C012 RID: 180242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C012")]
		[Address(RVA = "0x27FE4E0", Offset = "0x27FD0E0", VA = "0x1827FE4E0", Slot = "7")]
		public override void OnValueChanged(Act12sideMissionProperty property)
		{
		}

		// Token: 0x0602C013 RID: 180243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C013")]
		[Address(RVA = "0x27FE5A0", Offset = "0x27FD1A0", VA = "0x1827FE5A0")]
		public Act12sideMissionMiniView()
		{
		}

		// Token: 0x0403FC27 RID: 261159
		[Token(Token = "0x403FC27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act12sideMissionListAdapter _listAdapter;

		// Token: 0x0403FC28 RID: 261160
		[Token(Token = "0x403FC28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FC29 RID: 261161
		[Token(Token = "0x403FC29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
