using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C88 RID: 7304
	[Token(Token = "0x2001C88")]
	public class BuildingStationSelectCharList : DataBinder<StationCharGroupProperty>
	{
		// Token: 0x0600B56A RID: 46442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56A")]
		[Address(RVA = "0x32F1DD0", Offset = "0x32F09D0", VA = "0x1832F1DD0")]
		public void InjectPlugin(BuildingStationSelectState.IPlugin statePlugin)
		{
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56B")]
		[Address(RVA = "0x32F1E50", Offset = "0x32F0A50", VA = "0x1832F1E50")]
		public void MarkRebuildListNextTime()
		{
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56C")]
		[Address(RVA = "0x32F1EB0", Offset = "0x32F0AB0", VA = "0x1832F1EB0", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56D")]
		[Address(RVA = "0x32F2280", Offset = "0x32F0E80", VA = "0x1832F2280")]
		public BuildingStationSelectCharList()
		{
		}

		// Token: 0x0400B1AF RID: 45487
		[Token(Token = "0x400B1AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingStationSelectCharAdapter _adapter;

		// Token: 0x0400B1B0 RID: 45488
		[Token(Token = "0x400B1B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400B1B1 RID: 45489
		[Token(Token = "0x400B1B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEmpty;

		// Token: 0x0400B1B2 RID: 45490
		[Token(Token = "0x400B1B2")]
		[FieldOffset(Offset = "0x38")]
		private bool m_rebuildListNextTime;

		// Token: 0x0400B1B3 RID: 45491
		[Token(Token = "0x400B1B3")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<StationCharViewModel> onCharClicked;

		// Token: 0x0400B1B4 RID: 45492
		[Token(Token = "0x400B1B4")]
		[FieldOffset(Offset = "0x48")]
		private BuildingStationSelectState.IPlugin m_statePlugin;

		// Token: 0x0400B1B5 RID: 45493
		[Token(Token = "0x400B1B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0400B1B6 RID: 45494
		[Token(Token = "0x400B1B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MarkRebuildListNextTime;

		// Token: 0x0400B1B7 RID: 45495
		[Token(Token = "0x400B1B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B1B8 RID: 45496
		[Token(Token = "0x400B1B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
