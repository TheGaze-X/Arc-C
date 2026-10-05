using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB1 RID: 6833
	[Token(Token = "0x2001AB1")]
	public class BEmptyRoom : BRoom
	{
		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x0600AC63 RID: 44131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001466")]
		protected override string roomName
		{
			[Token(Token = "0x600AC63")]
			[Address(RVA = "0x326D370", Offset = "0x326BF70", VA = "0x18326D370", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC64")]
		[Address(RVA = "0x326CF50", Offset = "0x326BB50", VA = "0x18326CF50", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC65")]
		[Address(RVA = "0x326D1E0", Offset = "0x326BDE0", VA = "0x18326D1E0")]
		private void _OnBuildAble(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC66")]
		[Address(RVA = "0x326D010", Offset = "0x326BC10", VA = "0x18326D010", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC67")]
		[Address(RVA = "0x326CE30", Offset = "0x326BA30", VA = "0x18326CE30", Slot = "10")]
		protected override void OnActiveArchitecture(bool active, [Optional] Func<RoomSlotModel, bool> validPred)
		{
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC68")]
		[Address(RVA = "0x326D2D0", Offset = "0x326BED0", VA = "0x18326D2D0")]
		public BEmptyRoom()
		{
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC69")]
		[Address(RVA = "0x326D1D0", Offset = "0x326BDD0", VA = "0x18326D1D0")]
		private string <>xLuaBaseProxy_get_roomName()
		{
			return null;
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6A")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6B")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6C")]
		[Address(RVA = "0x326D1C0", Offset = "0x326BDC0", VA = "0x18326D1C0")]
		private void <>xLuaBaseProxy_OnActiveArchitecture(bool P0, Func<RoomSlotModel, bool> P1)
		{
		}

		// Token: 0x0400A488 RID: 42120
		[Token(Token = "0x400A488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x0400A489 RID: 42121
		[Token(Token = "0x400A489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _categoryLabel;

		// Token: 0x0400A48A RID: 42122
		[Token(Token = "0x400A48A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _icon;

		// Token: 0x0400A48B RID: 42123
		[Token(Token = "0x400A48B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_canBuild;

		// Token: 0x0400A48C RID: 42124
		[Token(Token = "0x400A48C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomName;

		// Token: 0x0400A48D RID: 42125
		[Token(Token = "0x400A48D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A48E RID: 42126
		[Token(Token = "0x400A48E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBuildAble;

		// Token: 0x0400A48F RID: 42127
		[Token(Token = "0x400A48F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A490 RID: 42128
		[Token(Token = "0x400A490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnActiveArchitecture;

		// Token: 0x0400A491 RID: 42129
		[Token(Token = "0x400A491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
