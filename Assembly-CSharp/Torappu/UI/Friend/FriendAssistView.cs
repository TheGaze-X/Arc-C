using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DA6 RID: 19878
	[Token(Token = "0x2004DA6")]
	public class FriendAssistView : DataBinder<FriendListProperty>
	{
		// Token: 0x0601DBAF RID: 121775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAF")]
		[Address(RVA = "0x173E8C0", Offset = "0x173D4C0", VA = "0x18173E8C0", Slot = "7")]
		public override void OnValueChanged(FriendListProperty property)
		{
		}

		// Token: 0x0601DBB0 RID: 121776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB0")]
		[Address(RVA = "0x173E990", Offset = "0x173D590", VA = "0x18173E990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DBB1 RID: 121777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB1")]
		[Address(RVA = "0x173F0E0", Offset = "0x173DCE0", VA = "0x18173F0E0")]
		private void _ShowView(FriendListViewModel viewModel)
		{
		}

		// Token: 0x0601DBB2 RID: 121778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB2")]
		[Address(RVA = "0x173EDD0", Offset = "0x173D9D0", VA = "0x18173EDD0")]
		private void _RenderFloatPanel(FriendListViewModel viewModel)
		{
		}

		// Token: 0x0601DBB3 RID: 121779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB3")]
		[Address(RVA = "0x173ED00", Offset = "0x173D900", VA = "0x18173ED00")]
		private void _OnTabItemClick(int index, string id, GameObject item, FriendAssistItemFloatPanel.ItemType itemType)
		{
		}

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB4")]
		[Address(RVA = "0x173EC40", Offset = "0x173D840", VA = "0x18173EC40")]
		private void _OnPanelItemClick(int index, string id, FriendAssistItemFloatPanel.ItemType itemType)
		{
		}

		// Token: 0x0601DBB5 RID: 121781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBB5")]
		[Address(RVA = "0x173F440", Offset = "0x173E040", VA = "0x18173F440")]
		public FriendAssistView()
		{
		}

		// Token: 0x0402750A RID: 161034
		[Token(Token = "0x402750A")]
		private const int MAX_ASSIST_TAB_COUNT = 3;

		// Token: 0x0402750B RID: 161035
		[Token(Token = "0x402750B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _assistTabContainer;

		// Token: 0x0402750C RID: 161036
		[Token(Token = "0x402750C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FriendAssistItemFloatPanel _assistFloatPanel;

		// Token: 0x0402750D RID: 161037
		[Token(Token = "0x402750D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descUp;

		// Token: 0x0402750E RID: 161038
		[Token(Token = "0x402750E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _descDown;

		// Token: 0x0402750F RID: 161039
		[Token(Token = "0x402750F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FriendAssistView.FriendAssistSelectEvent _onApplySelect;

		// Token: 0x04027510 RID: 161040
		[Token(Token = "0x4027510")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FriendAssistView.FriendAssistSelectEvent _onFloatSelect;

		// Token: 0x04027511 RID: 161041
		[Token(Token = "0x4027511")]
		[FieldOffset(Offset = "0x50")]
		private List<FriendAssistTab> m_friendAssistTabs;

		// Token: 0x04027512 RID: 161042
		[Token(Token = "0x4027512")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04027513 RID: 161043
		[Token(Token = "0x4027513")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_cachedItemObject;

		// Token: 0x04027514 RID: 161044
		[Token(Token = "0x4027514")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027515 RID: 161045
		[Token(Token = "0x4027515")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027516 RID: 161046
		[Token(Token = "0x4027516")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowView;

		// Token: 0x04027517 RID: 161047
		[Token(Token = "0x4027517")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderFloatPanel;

		// Token: 0x04027518 RID: 161048
		[Token(Token = "0x4027518")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTabItemClick;

		// Token: 0x04027519 RID: 161049
		[Token(Token = "0x4027519")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPanelItemClick;

		// Token: 0x0402751A RID: 161050
		[Token(Token = "0x402751A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DA7 RID: 19879
		[Token(Token = "0x2004DA7")]
		[Serializable]
		public class FriendAssistSelectEvent : UnityEvent<int, string, FriendAssistItemFloatPanel.ItemType>
		{
			// Token: 0x0601DBB6 RID: 121782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DBB6")]
			[Address(RVA = "0x173D200", Offset = "0x173BE00", VA = "0x18173D200")]
			public FriendAssistSelectEvent()
			{
			}
		}
	}
}
