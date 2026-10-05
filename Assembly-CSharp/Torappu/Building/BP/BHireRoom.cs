using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Hire;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB3 RID: 6835
	[Token(Token = "0x2001AB3")]
	public class BHireRoom : BFunctionRoom
	{
		// Token: 0x0600AC73 RID: 44147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC73")]
		[Address(RVA = "0x326DAA0", Offset = "0x326C6A0", VA = "0x18326DAA0")]
		private void _InitData(object _object)
		{
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC74")]
		[Address(RVA = "0x326D980", Offset = "0x326C580", VA = "0x18326D980", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC75")]
		[Address(RVA = "0x326D8D0", Offset = "0x326C4D0", VA = "0x18326D8D0", Slot = "4")]
		public override Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC76")]
		[Address(RVA = "0x326DA30", Offset = "0x326C630", VA = "0x18326DA30")]
		private void Update()
		{
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC77")]
		[Address(RVA = "0x326DC20", Offset = "0x326C820", VA = "0x18326DC20")]
		private void _OnCountDownTick(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC78")]
		[Address(RVA = "0x326DCE0", Offset = "0x326C8E0", VA = "0x18326DCE0")]
		private void _UpdateCountDownStatus()
		{
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC79")]
		[Address(RVA = "0x326DF90", Offset = "0x326CB90", VA = "0x18326DF90")]
		public BHireRoom()
		{
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7A")]
		[Address(RVA = "0x326DA20", Offset = "0x326C620", VA = "0x18326DA20")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC7B")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700")]
		private Action<object> <>xLuaBaseProxy_ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0400A49C RID: 42140
		[Token(Token = "0x400A49C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textState;

		// Token: 0x0400A49D RID: 42141
		[Token(Token = "0x400A49D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private PiecewiseProgressBar _progressBar;

		// Token: 0x0400A49E RID: 42142
		[Token(Token = "0x400A49E")]
		[FieldOffset(Offset = "0x98")]
		private PlayerBuildingHire m_hiringViewModel;

		// Token: 0x0400A49F RID: 42143
		[Token(Token = "0x400A49F")]
		[FieldOffset(Offset = "0xA0")]
		private HiringSnapshot m_hireSnapshot;

		// Token: 0x0400A4A0 RID: 42144
		[Token(Token = "0x400A4A0")]
		[FieldOffset(Offset = "0xD0")]
		private CountDownTask m_countDown;

		// Token: 0x0400A4A1 RID: 42145
		[Token(Token = "0x400A4A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0400A4A2 RID: 42146
		[Token(Token = "0x400A4A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4A3 RID: 42147
		[Token(Token = "0x400A4A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A4A4 RID: 42148
		[Token(Token = "0x400A4A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A4A5 RID: 42149
		[Token(Token = "0x400A4A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCountDownTick;

		// Token: 0x0400A4A6 RID: 42150
		[Token(Token = "0x400A4A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateCountDownStatus;

		// Token: 0x0400A4A7 RID: 42151
		[Token(Token = "0x400A4A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
