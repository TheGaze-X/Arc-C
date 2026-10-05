using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB3 RID: 19891
	[Token(Token = "0x2004DB3")]
	public class FriendListView : DataBinder<FriendListProperty>
	{
		// Token: 0x0601DBF4 RID: 121844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF4")]
		[Address(RVA = "0x1751670", Offset = "0x1750270", VA = "0x181751670")]
		public void DealWithDrag(Vector2 offset)
		{
		}

		// Token: 0x0601DBF5 RID: 121845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF5")]
		[Address(RVA = "0x1751790", Offset = "0x1750390", VA = "0x181751790")]
		public void HideViewList(int index)
		{
		}

		// Token: 0x0601DBF6 RID: 121846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF6")]
		[Address(RVA = "0x1751860", Offset = "0x1750460", VA = "0x181751860", Slot = "7")]
		public override void OnValueChanged(FriendListProperty property)
		{
		}

		// Token: 0x0601DBF7 RID: 121847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBF7")]
		[Address(RVA = "0x1751EF0", Offset = "0x1750AF0", VA = "0x181751EF0")]
		public FriendListView()
		{
		}

		// Token: 0x0402758A RID: 161162
		[Token(Token = "0x402758A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FriendListRepoGridAdapter _adapter;

		// Token: 0x0402758B RID: 161163
		[Token(Token = "0x402758B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FriendListState _state;

		// Token: 0x0402758C RID: 161164
		[Token(Token = "0x402758C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402758D RID: 161165
		[Token(Token = "0x402758D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectMask2D _mask;

		// Token: 0x0402758E RID: 161166
		[Token(Token = "0x402758E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _noFriendTab;

		// Token: 0x0402758F RID: 161167
		[Token(Token = "0x402758F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _editStarBgGO;

		// Token: 0x04027590 RID: 161168
		[Token(Token = "0x4027590")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _starFriendEditGO;

		// Token: 0x04027591 RID: 161169
		[Token(Token = "0x4027591")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textEditStarCnt;

		// Token: 0x04027592 RID: 161170
		[Token(Token = "0x4027592")]
		[FieldOffset(Offset = "0x60")]
		private int m_count;

		// Token: 0x04027593 RID: 161171
		[Token(Token = "0x4027593")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealWithDrag;

		// Token: 0x04027594 RID: 161172
		[Token(Token = "0x4027594")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideViewList;

		// Token: 0x04027595 RID: 161173
		[Token(Token = "0x4027595")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027596 RID: 161174
		[Token(Token = "0x4027596")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
