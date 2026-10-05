using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBA RID: 19898
	[Token(Token = "0x2004DBA")]
	public class FriendSearchView : DataBinder<FriendListProperty>
	{
		// Token: 0x0601DC07 RID: 121863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC07")]
		[Address(RVA = "0x1754B30", Offset = "0x1753730", VA = "0x181754B30")]
		public void DealWithDrag(Vector2 offset)
		{
		}

		// Token: 0x0601DC08 RID: 121864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC08")]
		[Address(RVA = "0x1754A40", Offset = "0x1753640", VA = "0x181754A40")]
		public void CleanView()
		{
		}

		// Token: 0x0601DC09 RID: 121865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC09")]
		[Address(RVA = "0x1754C50", Offset = "0x1753850", VA = "0x181754C50")]
		public void OnSearchRequest()
		{
		}

		// Token: 0x0601DC0A RID: 121866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0A")]
		[Address(RVA = "0x1754CD0", Offset = "0x17538D0", VA = "0x181754CD0", Slot = "7")]
		public override void OnValueChanged(FriendListProperty property)
		{
		}

		// Token: 0x0601DC0B RID: 121867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC0B")]
		[Address(RVA = "0x17550C0", Offset = "0x1753CC0", VA = "0x1817550C0")]
		public FriendSearchView()
		{
		}

		// Token: 0x040275AF RID: 161199
		[Token(Token = "0x40275AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _searchContain;

		// Token: 0x040275B0 RID: 161200
		[Token(Token = "0x40275B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FriendListSearchItem _searchItem;

		// Token: 0x040275B1 RID: 161201
		[Token(Token = "0x40275B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FriendSearchState _state;

		// Token: 0x040275B2 RID: 161202
		[Token(Token = "0x40275B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FriendSearchGridAdapter _adapter;

		// Token: 0x040275B3 RID: 161203
		[Token(Token = "0x40275B3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x040275B4 RID: 161204
		[Token(Token = "0x40275B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField _inputField;

		// Token: 0x040275B5 RID: 161205
		[Token(Token = "0x40275B5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _noResultTab;

		// Token: 0x040275B6 RID: 161206
		[Token(Token = "0x40275B6")]
		[FieldOffset(Offset = "0x58")]
		private int m_count;

		// Token: 0x040275B7 RID: 161207
		[Token(Token = "0x40275B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealWithDrag;

		// Token: 0x040275B8 RID: 161208
		[Token(Token = "0x40275B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CleanView;

		// Token: 0x040275B9 RID: 161209
		[Token(Token = "0x40275B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSearchRequest;

		// Token: 0x040275BA RID: 161210
		[Token(Token = "0x40275BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040275BB RID: 161211
		[Token(Token = "0x40275BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
