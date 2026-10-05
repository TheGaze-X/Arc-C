using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021B6 RID: 8630
	[Token(Token = "0x20021B6")]
	public class ConstructPageMsg
	{
		// Token: 0x0600D777 RID: 55159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D777")]
		[Address(RVA = "0x35CC1D0", Offset = "0x35CADD0", VA = "0x1835CC1D0")]
		public void Trigger(ConstructPageMsg.EventFromPage @event)
		{
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D778")]
		[Address(RVA = "0x35CC170", Offset = "0x35CAD70", VA = "0x1835CC170")]
		public void Trigger(ConstructPageMsg.EventFromScene @event)
		{
		}

		// Token: 0x0600D779 RID: 55161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D779")]
		[Address(RVA = "0x35CC2A0", Offset = "0x35CAEA0", VA = "0x1835CC2A0")]
		public ConstructPageMsg()
		{
		}

		// Token: 0x0400E7FF RID: 59391
		[Token(Token = "0x400E7FF")]
		[FieldOffset(Offset = "0x10")]
		public List<ConstructPageMsg.EventFromPage> eventsFromPage;

		// Token: 0x0400E800 RID: 59392
		[Token(Token = "0x400E800")]
		[FieldOffset(Offset = "0x18")]
		public EventPool<ConstructPageMsg.EventFromScene> eventsFromScene;

		// Token: 0x020021B7 RID: 8631
		[Token(Token = "0x20021B7")]
		public enum EventFromPage
		{
			// Token: 0x0400E802 RID: 59394
			[Token(Token = "0x400E802")]
			NONE,
			// Token: 0x0400E803 RID: 59395
			[Token(Token = "0x400E803")]
			REPAIR_ALL_CONFIRMED,
			// Token: 0x0400E804 RID: 59396
			[Token(Token = "0x400E804")]
			RESET_MAP_CONFIRMED,
			// Token: 0x0400E805 RID: 59397
			[Token(Token = "0x400E805")]
			SAVE_MAP_CONFIRMED,
			// Token: 0x0400E806 RID: 59398
			[Token(Token = "0x400E806")]
			LEAVE_PAGE_CANCELED,
			// Token: 0x0400E807 RID: 59399
			[Token(Token = "0x400E807")]
			BEFORE_SAVE_MAP,
			// Token: 0x0400E808 RID: 59400
			[Token(Token = "0x400E808")]
			PAGE_RESUME,
			// Token: 0x0400E809 RID: 59401
			[Token(Token = "0x400E809")]
			PAGE_STOP
		}

		// Token: 0x020021B8 RID: 8632
		[Token(Token = "0x20021B8")]
		public enum EventFromScene
		{
			// Token: 0x0400E80B RID: 59403
			[Token(Token = "0x400E80B")]
			SAVE_CLICKED,
			// Token: 0x0400E80C RID: 59404
			[Token(Token = "0x400E80C")]
			RESET_CLICKED,
			// Token: 0x0400E80D RID: 59405
			[Token(Token = "0x400E80D")]
			TO_CRAFT_CLICKED,
			// Token: 0x0400E80E RID: 59406
			[Token(Token = "0x400E80E")]
			LEAVE_PAGE_CLICKED
		}
	}
}
