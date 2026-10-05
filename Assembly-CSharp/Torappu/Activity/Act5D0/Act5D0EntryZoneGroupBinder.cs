using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071ED RID: 29165
	[Token(Token = "0x20071ED")]
	public class Act5D0EntryZoneGroupBinder : DataBinder<Act5D0ZoneDescGroupViewProperty>
	{
		// Token: 0x060295F6 RID: 169462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F6")]
		[Address(RVA = "0x24A8ED0", Offset = "0x24A7AD0", VA = "0x1824A8ED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060295F7 RID: 169463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F7")]
		[Address(RVA = "0x24A8CA0", Offset = "0x24A78A0", VA = "0x1824A8CA0", Slot = "7")]
		public override void OnValueChanged(Act5D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x060295F8 RID: 169464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F8")]
		[Address(RVA = "0x24A9010", Offset = "0x24A7C10", VA = "0x1824A9010")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x060295F9 RID: 169465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295F9")]
		[Address(RVA = "0x24A9140", Offset = "0x24A7D40", VA = "0x1824A9140")]
		public Act5D0EntryZoneGroupBinder()
		{
		}

		// Token: 0x0403B157 RID: 242007
		[Token(Token = "0x403B157")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act5D0EntryZoneView> _zoneViews;

		// Token: 0x0403B158 RID: 242008
		[Token(Token = "0x403B158")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403B159 RID: 242009
		[Token(Token = "0x403B159")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B15A RID: 242010
		[Token(Token = "0x403B15A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B15B RID: 242011
		[Token(Token = "0x403B15B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x0403B15C RID: 242012
		[Token(Token = "0x403B15C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
