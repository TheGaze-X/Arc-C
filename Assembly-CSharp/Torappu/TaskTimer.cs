using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	public class TaskTimer<Value> where Value : struct
	{
		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06005BEE RID: 23534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB5")]
		public Value latestValue
		{
			[Token(Token = "0x6005BEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEF")]
		public TaskTimer(long startTime, long endTime, TaskTimer<Value>.Options options)
		{
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF0")]
		public void ResetTime(long startTime, long endTime)
		{
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06005BF1 RID: 23537 RVA: 0x0002F088 File Offset: 0x0002D288
		[Token(Token = "0x17000CB6")]
		public bool isTaskEnd
		{
			[Token(Token = "0x6005BF1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF2")]
		public void Interrupt()
		{
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF3")]
		public void Tick()
		{
		}

		// Token: 0x04002184 RID: 8580
		[Token(Token = "0x4002184")]
		[FieldOffset(Offset = "0x0")]
		private long m_startTime;

		// Token: 0x04002185 RID: 8581
		[Token(Token = "0x4002185")]
		[FieldOffset(Offset = "0x0")]
		private long m_endTime;

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		[FieldOffset(Offset = "0x0")]
		protected TaskTimer<Value>.Options options;

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x0")]
		protected long startTime;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x0")]
		protected long endTime;

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isInited;

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x0")]
		private long m_lastUpdateTime;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x0")]
		private Value m_lastValue;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isTaskEnd;

		// Token: 0x02000585 RID: 1413
		[Token(Token = "0x2000585")]
		public struct Options
		{
			// Token: 0x0400218D RID: 8589
			[Token(Token = "0x400218D")]
			[FieldOffset(Offset = "0x0")]
			public long interval;

			// Token: 0x0400218E RID: 8590
			[Token(Token = "0x400218E")]
			[FieldOffset(Offset = "0x0")]
			public Func<TaskTimer<Value>.Context, Value> updateValue;

			// Token: 0x0400218F RID: 8591
			[Token(Token = "0x400218F")]
			[FieldOffset(Offset = "0x0")]
			public Action<TaskTimer<Value>.Context> onValueChanged;

			// Token: 0x04002190 RID: 8592
			[Token(Token = "0x4002190")]
			[FieldOffset(Offset = "0x0")]
			public Action<TaskTimer<Value>.Context> onTaskEnd;
		}

		// Token: 0x02000586 RID: 1414
		[Token(Token = "0x2000586")]
		public struct Context
		{
			// Token: 0x04002191 RID: 8593
			[Token(Token = "0x4002191")]
			[FieldOffset(Offset = "0x0")]
			public long curTime;

			// Token: 0x04002192 RID: 8594
			[Token(Token = "0x4002192")]
			[FieldOffset(Offset = "0x0")]
			public long startTime;

			// Token: 0x04002193 RID: 8595
			[Token(Token = "0x4002193")]
			[FieldOffset(Offset = "0x0")]
			public long endTime;

			// Token: 0x04002194 RID: 8596
			[Token(Token = "0x4002194")]
			[FieldOffset(Offset = "0x0")]
			public Value value;

			// Token: 0x04002195 RID: 8597
			[Token(Token = "0x4002195")]
			[FieldOffset(Offset = "0x0")]
			public TaskTimer<Value> timer;
		}
	}
}
