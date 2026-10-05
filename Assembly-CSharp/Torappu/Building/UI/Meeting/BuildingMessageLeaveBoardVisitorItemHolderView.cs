using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D27 RID: 7463
	[Token(Token = "0x2001D27")]
	public class BuildingMessageLeaveBoardVisitorItemHolderView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B83A RID: 47162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83A")]
		[Address(RVA = "0x335EB10", Offset = "0x335D710", VA = "0x18335EB10")]
		private void _LoadPrefabIfNot()
		{
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83B")]
		[Address(RVA = "0x335E940", Offset = "0x335D540", VA = "0x18335E940")]
		public void Render(IMessageBoardVisitorData visitorData, long lastVisitBoardTs = 0L, [Optional] Action<IMessageBoardVisitorData> onClickAvatar)
		{
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83C")]
		[Address(RVA = "0x335E880", Offset = "0x335D480", VA = "0x18335E880")]
		public void Hide()
		{
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83D")]
		[Address(RVA = "0x335EC10", Offset = "0x335D810", VA = "0x18335EC10")]
		public BuildingMessageLeaveBoardVisitorItemHolderView()
		{
		}

		// Token: 0x0400B650 RID: 46672
		[Token(Token = "0x400B650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingMessageLeaveBoardVisitorItemView _visitorItemPrefab;

		// Token: 0x0400B651 RID: 46673
		[Token(Token = "0x400B651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BuildingMessageLeaveBoardVisitorItemView m_visitorItem;

		// Token: 0x0400B652 RID: 46674
		[Token(Token = "0x400B652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadPrefabIfNot;

		// Token: 0x0400B653 RID: 46675
		[Token(Token = "0x400B653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B654 RID: 46676
		[Token(Token = "0x400B654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400B655 RID: 46677
		[Token(Token = "0x400B655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
