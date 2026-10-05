using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007404 RID: 29700
	[Token(Token = "0x2007404")]
	public class Act3D0MapZoneGroupBinder : DataBinder<Act3D0ZoneDescGroupViewProperty>, IHotfixable
	{
		// Token: 0x06029F21 RID: 171809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F21")]
		[Address(RVA = "0x258DC20", Offset = "0x258C820", VA = "0x18258DC20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029F22 RID: 171810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F22")]
		[Address(RVA = "0x258D830", Offset = "0x258C430", VA = "0x18258D830", Slot = "7")]
		public override void OnValueChanged(Act3D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x06029F23 RID: 171811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F23")]
		[Address(RVA = "0x258DD60", Offset = "0x258C960", VA = "0x18258DD60")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06029F24 RID: 171812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F24")]
		[Address(RVA = "0x258DEB0", Offset = "0x258CAB0", VA = "0x18258DEB0")]
		public Act3D0MapZoneGroupBinder()
		{
		}

		// Token: 0x0403C1E0 RID: 246240
		[Token(Token = "0x403C1E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act3D0MapZoneView> _zoneViews;

		// Token: 0x0403C1E1 RID: 246241
		[Token(Token = "0x403C1E1")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403C1E2 RID: 246242
		[Token(Token = "0x403C1E2")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectZoneId;

		// Token: 0x0403C1E3 RID: 246243
		[Token(Token = "0x403C1E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C1E4 RID: 246244
		[Token(Token = "0x403C1E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C1E5 RID: 246245
		[Token(Token = "0x403C1E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x0403C1E6 RID: 246246
		[Token(Token = "0x403C1E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
