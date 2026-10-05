using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB8 RID: 6840
	[Token(Token = "0x2001AB8")]
	public class BPowerRoom : BOutputRoom
	{
		// Token: 0x0600ACB6 RID: 44214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB6")]
		[Address(RVA = "0x32739E0", Offset = "0x32725E0", VA = "0x1832739E0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB7")]
		[Address(RVA = "0x3273CD0", Offset = "0x32728D0", VA = "0x183273CD0", Slot = "8")]
		protected override void OnRoomDestroy()
		{
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x000429C0 File Offset: 0x00040BC0
		[Token(Token = "0x17001474")]
		protected override bool isWorking
		{
			[Token(Token = "0x600ACB8")]
			[Address(RVA = "0x3273E00", Offset = "0x3272A00", VA = "0x183273E00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB9")]
		[Address(RVA = "0x3273950", Offset = "0x3272550", VA = "0x183273950")]
		private void OnEnable()
		{
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBA")]
		[Address(RVA = "0x32738C0", Offset = "0x32724C0", VA = "0x1832738C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBB")]
		[Address(RVA = "0x3273DA0", Offset = "0x32729A0", VA = "0x183273DA0")]
		public BPowerRoom()
		{
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBD")]
		[Address(RVA = "0x32711E0", Offset = "0x326FDE0", VA = "0x1832711E0")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBE")]
		[Address(RVA = "0x3273D90", Offset = "0x3272990", VA = "0x183273D90")]
		private void <>xLuaBaseProxy_OnRoomDestroy()
		{
		}

		// Token: 0x0400A4EB RID: 42219
		[Token(Token = "0x400A4EB")]
		private const float TWEEN_DURATION = 4f;

		// Token: 0x0400A4EC RID: 42220
		[Token(Token = "0x400A4EC")]
		[FieldOffset(Offset = "0xF8")]
		private Tweener m_progressTween;

		// Token: 0x0400A4ED RID: 42221
		[Token(Token = "0x400A4ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4EE RID: 42222
		[Token(Token = "0x400A4EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRoomDestroy;

		// Token: 0x0400A4EF RID: 42223
		[Token(Token = "0x400A4EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0400A4F0 RID: 42224
		[Token(Token = "0x400A4F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400A4F1 RID: 42225
		[Token(Token = "0x400A4F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400A4F2 RID: 42226
		[Token(Token = "0x400A4F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
