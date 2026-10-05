using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.UI.Meeting;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB5 RID: 6837
	[Token(Token = "0x2001AB5")]
	public class BMeetingRoom : BFunctionRoom
	{
		// Token: 0x0600AC90 RID: 44176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC90")]
		[Address(RVA = "0x3272020", Offset = "0x3270C20", VA = "0x183272020")]
		private void _UpdateClueHintMark(bool architecture)
		{
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC91")]
		[Address(RVA = "0x3271F80", Offset = "0x3270B80", VA = "0x183271F80", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC92")]
		[Address(RVA = "0x3271ED0", Offset = "0x3270AD0", VA = "0x183271ED0", Slot = "10")]
		protected override void OnActiveArchitecture(bool active, [Optional] Func<RoomSlotModel, bool> validPred)
		{
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC93")]
		[Address(RVA = "0x3272160", Offset = "0x3270D60", VA = "0x183272160")]
		public BMeetingRoom()
		{
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC94")]
		[Address(RVA = "0x326DA20", Offset = "0x326C620", VA = "0x18326DA20")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC95")]
		[Address(RVA = "0x326D1C0", Offset = "0x326BDC0", VA = "0x18326D1C0")]
		private void <>xLuaBaseProxy_OnActiveArchitecture(bool P0, Func<RoomSlotModel, bool> P1)
		{
		}

		// Token: 0x0400A4B9 RID: 42169
		[Token(Token = "0x400A4B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _clueHintMark;

		// Token: 0x0400A4BA RID: 42170
		[Token(Token = "0x400A4BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _messageBoardMark;

		// Token: 0x0400A4BB RID: 42171
		[Token(Token = "0x400A4BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BuildingMeetingSession m_session;

		// Token: 0x0400A4BC RID: 42172
		[Token(Token = "0x400A4BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateClueHintMark;

		// Token: 0x0400A4BD RID: 42173
		[Token(Token = "0x400A4BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4BE RID: 42174
		[Token(Token = "0x400A4BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnActiveArchitecture;

		// Token: 0x0400A4BF RID: 42175
		[Token(Token = "0x400A4BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
