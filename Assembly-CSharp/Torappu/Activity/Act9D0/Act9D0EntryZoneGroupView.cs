using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007164 RID: 29028
	[Token(Token = "0x2007164")]
	public class Act9D0EntryZoneGroupView : DataBinder<Act9D0ZoneDescGroupViewProperty>
	{
		// Token: 0x06029378 RID: 168824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029378")]
		[Address(RVA = "0x2494BB0", Offset = "0x24937B0", VA = "0x182494BB0")]
		public void InitAndBindView(Act9D0StageController controller)
		{
		}

		// Token: 0x06029379 RID: 168825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029379")]
		[Address(RVA = "0x2494C90", Offset = "0x2493890", VA = "0x182494C90", Slot = "7")]
		public override void OnValueChanged(Act9D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602937A RID: 168826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602937A")]
		[Address(RVA = "0x2494F10", Offset = "0x2493B10", VA = "0x182494F10")]
		private void _OnZoneViewClicked(string zoneId)
		{
		}

		// Token: 0x0602937B RID: 168827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602937B")]
		[Address(RVA = "0x2494FD0", Offset = "0x2493BD0", VA = "0x182494FD0")]
		public Act9D0EntryZoneGroupView()
		{
		}

		// Token: 0x0403AD8E RID: 241038
		[Token(Token = "0x403AD8E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAllTimeout;

		// Token: 0x0403AD8F RID: 241039
		[Token(Token = "0x403AD8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _disableAllTimeout;

		// Token: 0x0403AD90 RID: 241040
		[Token(Token = "0x403AD90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Act9D0EntryZoneView> _zoneViewList;

		// Token: 0x0403AD91 RID: 241041
		[Token(Token = "0x403AD91")]
		[FieldOffset(Offset = "0x38")]
		private Act9D0StageController m_actController;

		// Token: 0x0403AD92 RID: 241042
		[Token(Token = "0x403AD92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAndBindView;

		// Token: 0x0403AD93 RID: 241043
		[Token(Token = "0x403AD93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403AD94 RID: 241044
		[Token(Token = "0x403AD94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneViewClicked;

		// Token: 0x0403AD95 RID: 241045
		[Token(Token = "0x403AD95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
