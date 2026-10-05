using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006715 RID: 26389
	[Token(Token = "0x2006715")]
	public class HandBookV2MissionListView : DataBinder<HandBookV2FavorMissionProperty>
	{
		// Token: 0x06025DDE RID: 155102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DDE")]
		[Address(RVA = "0x20E5D20", Offset = "0x20E4920", VA = "0x1820E5D20", Slot = "7")]
		public override void OnValueChanged(HandBookV2FavorMissionProperty property)
		{
		}

		// Token: 0x06025DDF RID: 155103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DDF")]
		[Address(RVA = "0x20E5DD0", Offset = "0x20E49D0", VA = "0x1820E5DD0")]
		public HandBookV2MissionListView()
		{
		}

		// Token: 0x0403541F RID: 218143
		[Token(Token = "0x403541F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2MissionListAdapter _listAdapter;

		// Token: 0x04035420 RID: 218144
		[Token(Token = "0x4035420")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035421 RID: 218145
		[Token(Token = "0x4035421")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
