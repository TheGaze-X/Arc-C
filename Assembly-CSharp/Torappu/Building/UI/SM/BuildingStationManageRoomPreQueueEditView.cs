using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD0 RID: 7376
	[Token(Token = "0x2001CD0")]
	public class BuildingStationManageRoomPreQueueEditView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B698 RID: 46744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B698")]
		[Address(RVA = "0x33471F0", Offset = "0x3345DF0", VA = "0x1833471F0")]
		public void Render(StationManageEditRoomQueueStructModel queueStructModel, int indexInList)
		{
		}

		// Token: 0x0600B699 RID: 46745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B699")]
		[Address(RVA = "0x3347110", Offset = "0x3345D10", VA = "0x183347110")]
		public void EventOnClickApplyQueue()
		{
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B69A")]
		[Address(RVA = "0x3347180", Offset = "0x3345D80", VA = "0x183347180")]
		public void EventOnClickDeleteQueue()
		{
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B69B")]
		[Address(RVA = "0x33473B0", Offset = "0x3345FB0", VA = "0x1833473B0")]
		public BuildingStationManageRoomPreQueueEditView()
		{
		}

		// Token: 0x0400B3F4 RID: 46068
		[Token(Token = "0x400B3F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingStationManagePreQueueView _queueView;

		// Token: 0x0400B3F5 RID: 46069
		[Token(Token = "0x400B3F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textQueueName;

		// Token: 0x0400B3F6 RID: 46070
		[Token(Token = "0x400B3F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("apply pre queue")]
		private GameObject _applyPreQueueAvail;

		// Token: 0x0400B3F7 RID: 46071
		[Token(Token = "0x400B3F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("apply pre queue")]
		private GameObject _applyPreQueueLocked;

		// Token: 0x0400B3F8 RID: 46072
		[Token(Token = "0x400B3F8")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onApplyQueueClicked;

		// Token: 0x0400B3F9 RID: 46073
		[Token(Token = "0x400B3F9")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<int> onDeleteQueueClicked;

		// Token: 0x0400B3FA RID: 46074
		[Token(Token = "0x400B3FA")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onPreQueueCharClicked;

		// Token: 0x0400B3FB RID: 46075
		[Token(Token = "0x400B3FB")]
		[FieldOffset(Offset = "0x50")]
		private int m_indexInQueueList;

		// Token: 0x0400B3FC RID: 46076
		[Token(Token = "0x400B3FC")]
		[FieldOffset(Offset = "0x54")]
		private bool m_isQueueAvail;

		// Token: 0x0400B3FD RID: 46077
		[Token(Token = "0x400B3FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B3FE RID: 46078
		[Token(Token = "0x400B3FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClickApplyQueue;

		// Token: 0x0400B3FF RID: 46079
		[Token(Token = "0x400B3FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClickDeleteQueue;

		// Token: 0x0400B400 RID: 46080
		[Token(Token = "0x400B400")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
