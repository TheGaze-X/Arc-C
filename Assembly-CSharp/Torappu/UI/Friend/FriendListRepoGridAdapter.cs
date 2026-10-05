using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DAF RID: 19887
	[Token(Token = "0x2004DAF")]
	public class FriendListRepoGridAdapter : RecycleLoopScrollAdapter<FriendListItemHolder, KeyValuePair<FriendData, string>>
	{
		// Token: 0x0601DBE1 RID: 121825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBE1")]
		[Address(RVA = "0x1750AB0", Offset = "0x174F6B0", VA = "0x181750AB0", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x0601DBE2 RID: 121826 RVA: 0x000AC698 File Offset: 0x000AA898
		// (set) Token: 0x0601DBE3 RID: 121827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045B4")]
		public bool isInEditStarMode
		{
			[Token(Token = "0x601DBE2")]
			[Address(RVA = "0x1751060", Offset = "0x174FC60", VA = "0x181751060")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DBE3")]
			[Address(RVA = "0x17511C0", Offset = "0x174FDC0", VA = "0x1817511C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x0601DBE4 RID: 121828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DBE5 RID: 121829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045B5")]
		public List<string> editStarList
		{
			[Token(Token = "0x601DBE4")]
			[Address(RVA = "0x1751000", Offset = "0x174FC00", VA = "0x181751000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DBE5")]
			[Address(RVA = "0x1751140", Offset = "0x174FD40", VA = "0x181751140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x0601DBE6 RID: 121830 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DBE7 RID: 121831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045B6")]
		public List<string> currStarList
		{
			[Token(Token = "0x601DBE6")]
			[Address(RVA = "0x1750FA0", Offset = "0x174FBA0", VA = "0x181750FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DBE7")]
			[Address(RVA = "0x17510C0", Offset = "0x174FCC0", VA = "0x1817510C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601DBE8 RID: 121832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBE8")]
		[Address(RVA = "0x1750A40", Offset = "0x174F640", VA = "0x181750A40")]
		public void HideViewList(int index)
		{
		}

		// Token: 0x0601DBE9 RID: 121833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DBE9")]
		[Address(RVA = "0x1750E10", Offset = "0x174FA10", VA = "0x181750E10", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601DBEA RID: 121834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBEA")]
		[Address(RVA = "0x1750B10", Offset = "0x174F710", VA = "0x181750B10", Slot = "13")]
		public override void UpdateView(int position, GameObject view, FriendListItemHolder holder, KeyValuePair<FriendData, string> data)
		{
		}

		// Token: 0x0601DBEB RID: 121835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBEB")]
		[Address(RVA = "0x1750F20", Offset = "0x174FB20", VA = "0x181750F20")]
		public FriendListRepoGridAdapter()
		{
		}

		// Token: 0x04027569 RID: 161129
		[Token(Token = "0x4027569")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _friendItem;

		// Token: 0x0402756A RID: 161130
		[Token(Token = "0x402756A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FriendListState _state;

		// Token: 0x0402756B RID: 161131
		[Token(Token = "0x402756B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FriendListView _view;

		// Token: 0x0402756C RID: 161132
		[Token(Token = "0x402756C")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public int indexFlag;

		// Token: 0x04027570 RID: 161136
		[Token(Token = "0x4027570")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x04027571 RID: 161137
		[Token(Token = "0x4027571")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isInEditStarMode;

		// Token: 0x04027572 RID: 161138
		[Token(Token = "0x4027572")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isInEditStarMode;

		// Token: 0x04027573 RID: 161139
		[Token(Token = "0x4027573")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_editStarList;

		// Token: 0x04027574 RID: 161140
		[Token(Token = "0x4027574")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_editStarList;

		// Token: 0x04027575 RID: 161141
		[Token(Token = "0x4027575")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currStarList;

		// Token: 0x04027576 RID: 161142
		[Token(Token = "0x4027576")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_currStarList;

		// Token: 0x04027577 RID: 161143
		[Token(Token = "0x4027577")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideViewList;

		// Token: 0x04027578 RID: 161144
		[Token(Token = "0x4027578")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04027579 RID: 161145
		[Token(Token = "0x4027579")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402757A RID: 161146
		[Token(Token = "0x402757A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DB0 RID: 19888
		[Token(Token = "0x2004DB0")]
		public struct ViewHolder
		{
			// Token: 0x0402757B RID: 161147
			[Token(Token = "0x402757B")]
			[FieldOffset(Offset = "0x0")]
			public FriendListItem panel;
		}
	}
}
