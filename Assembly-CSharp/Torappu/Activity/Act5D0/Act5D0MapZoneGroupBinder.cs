using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071EF RID: 29167
	[Token(Token = "0x20071EF")]
	public class Act5D0MapZoneGroupBinder : DataBinder<Act5D0ZoneDescGroupViewProperty>
	{
		// Token: 0x060295FD RID: 169469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FD")]
		[Address(RVA = "0x24A9810", Offset = "0x24A8410", VA = "0x1824A9810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060295FE RID: 169470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FE")]
		[Address(RVA = "0x24A95D0", Offset = "0x24A81D0", VA = "0x1824A95D0", Slot = "7")]
		public override void OnValueChanged(Act5D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x060295FF RID: 169471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FF")]
		[Address(RVA = "0x24A9950", Offset = "0x24A8550", VA = "0x1824A9950")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06029600 RID: 169472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029600")]
		[Address(RVA = "0x24A9AA0", Offset = "0x24A86A0", VA = "0x1824A9AA0")]
		public Act5D0MapZoneGroupBinder()
		{
		}

		// Token: 0x0403B169 RID: 242025
		[Token(Token = "0x403B169")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act5D0MapZoneView> _zoneViews;

		// Token: 0x0403B16A RID: 242026
		[Token(Token = "0x403B16A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403B16B RID: 242027
		[Token(Token = "0x403B16B")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectZoneId;

		// Token: 0x0403B16C RID: 242028
		[Token(Token = "0x403B16C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B16D RID: 242029
		[Token(Token = "0x403B16D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B16E RID: 242030
		[Token(Token = "0x403B16E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x0403B16F RID: 242031
		[Token(Token = "0x403B16F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
