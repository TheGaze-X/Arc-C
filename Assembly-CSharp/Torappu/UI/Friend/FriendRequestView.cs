using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DB7 RID: 19895
	[Token(Token = "0x2004DB7")]
	public class FriendRequestView : DataBinder<FriendListProperty>
	{
		// Token: 0x0601DBFF RID: 121855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBFF")]
		[Address(RVA = "0x1754030", Offset = "0x1752C30", VA = "0x181754030")]
		public void DealWithDrag(Vector2 offset)
		{
		}

		// Token: 0x0601DC00 RID: 121856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC00")]
		[Address(RVA = "0x1754150", Offset = "0x1752D50", VA = "0x181754150", Slot = "7")]
		public override void OnValueChanged(FriendListProperty property)
		{
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC01")]
		[Address(RVA = "0x17545A0", Offset = "0x17531A0", VA = "0x1817545A0")]
		public FriendRequestView()
		{
		}

		// Token: 0x0402759F RID: 161183
		[Token(Token = "0x402759F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FriendRequestGridAdapter _adapter;

		// Token: 0x040275A0 RID: 161184
		[Token(Token = "0x40275A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x040275A1 RID: 161185
		[Token(Token = "0x40275A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FriendRequestState _state;

		// Token: 0x040275A2 RID: 161186
		[Token(Token = "0x40275A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noRequestTab;

		// Token: 0x040275A3 RID: 161187
		[Token(Token = "0x40275A3")]
		[FieldOffset(Offset = "0x40")]
		private List<FriendListRequestItem> m_requestItemList;

		// Token: 0x040275A4 RID: 161188
		[Token(Token = "0x40275A4")]
		[FieldOffset(Offset = "0x48")]
		private int m_count;

		// Token: 0x040275A5 RID: 161189
		[Token(Token = "0x40275A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealWithDrag;

		// Token: 0x040275A6 RID: 161190
		[Token(Token = "0x40275A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040275A7 RID: 161191
		[Token(Token = "0x40275A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
