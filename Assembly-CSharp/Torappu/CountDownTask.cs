using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	public class CountDownTask
	{
		// Token: 0x06005A44 RID: 23108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CountDownTask()
		{
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06005A45 RID: 23109 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		[Token(Token = "0x17000C8D")]
		public CountDownTask.TickValue latestTickValue
		{
			[Token(Token = "0x6005A45")]
			[Address(RVA = "0x1AEB260", Offset = "0x1AE9E60", VA = "0x181AEB260")]
			get
			{
				return default(CountDownTask.TickValue);
			}
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x1AEAE70", Offset = "0x1AE9A70", VA = "0x181AEAE70")]
		public void SetCountDown(long remainSeconds)
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x1AEAE20", Offset = "0x1AE9A20", VA = "0x181AEAE20")]
		public void Interrupt()
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x1AEB100", Offset = "0x1AE9D00", VA = "0x181AEB100")]
		public void Tick()
		{
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A49")]
		[Address(RVA = "0xEEE3F0", Offset = "0xEECFF0", VA = "0x180EEE3F0")]
		private void _OnTaskEnd(TaskTimer<CountDownTask.TickValue>.Context context)
		{
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0x1AEB150", Offset = "0x1AE9D50", VA = "0x181AEB150")]
		private void _OnValueChanged(TaskTimer<CountDownTask.TickValue>.Context context)
		{
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x1AEB180", Offset = "0x1AE9D80", VA = "0x181AEB180")]
		private CountDownTask.TickValue _UpdateValue(TaskTimer<CountDownTask.TickValue>.Context context)
		{
			return default(CountDownTask.TickValue);
		}

		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		private const long DEFAULT_INTERVAL = 200L;

		// Token: 0x0400201D RID: 8221
		[Token(Token = "0x400201D")]
		[FieldOffset(Offset = "0x10")]
		private TaskTimer<CountDownTask.TickValue> m_timer;

		// Token: 0x0400201E RID: 8222
		[Token(Token = "0x400201E")]
		[FieldOffset(Offset = "0x18")]
		public Func<TaskTimer<CountDownTask.TickValue>.Context, CountDownTask.TickValue> overrideUpdateTickValue;

		// Token: 0x0400201F RID: 8223
		[Token(Token = "0x400201F")]
		[FieldOffset(Offset = "0x20")]
		public Action<CountDownTask.TickValue> onTimeTick;

		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x28")]
		public Action onTimeout;

		// Token: 0x02000545 RID: 1349
		[Token(Token = "0x2000545")]
		public struct TickValue
		{
			// Token: 0x04002021 RID: 8225
			[Token(Token = "0x4002021")]
			[FieldOffset(Offset = "0x0")]
			public long remainSeconds;
		}
	}
}
