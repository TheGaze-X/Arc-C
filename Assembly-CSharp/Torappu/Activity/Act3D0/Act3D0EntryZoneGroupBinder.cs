using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F7 RID: 29687
	[Token(Token = "0x20073F7")]
	public class Act3D0EntryZoneGroupBinder : DataBinder<Act3D0ZoneDescGroupViewProperty>
	{
		// Token: 0x06029EF1 RID: 171761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF1")]
		[Address(RVA = "0x2587F00", Offset = "0x2586B00", VA = "0x182587F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029EF2 RID: 171762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF2")]
		[Address(RVA = "0x2587CD0", Offset = "0x25868D0", VA = "0x182587CD0", Slot = "7")]
		public override void OnValueChanged(Act3D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x06029EF3 RID: 171763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF3")]
		[Address(RVA = "0x2588040", Offset = "0x2586C40", VA = "0x182588040")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06029EF4 RID: 171764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF4")]
		[Address(RVA = "0x25880E0", Offset = "0x2586CE0", VA = "0x1825880E0")]
		public Act3D0EntryZoneGroupBinder()
		{
		}

		// Token: 0x0403C166 RID: 246118
		[Token(Token = "0x403C166")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act3D0EntryZoneView> _zoneViews;

		// Token: 0x0403C167 RID: 246119
		[Token(Token = "0x403C167")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403C168 RID: 246120
		[Token(Token = "0x403C168")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C169 RID: 246121
		[Token(Token = "0x403C169")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C16A RID: 246122
		[Token(Token = "0x403C16A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x0403C16B RID: 246123
		[Token(Token = "0x403C16B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
