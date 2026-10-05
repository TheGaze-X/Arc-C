using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	internal struct InputEventStream
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x17000494")]
		public bool isOpen
		{
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x17000495")]
		public int remainingEventCount
		{
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x56DBAD0", Offset = "0x56DA6D0", VA = "0x1856DBAD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x17000496")]
		public int numEventsRetainedInBuffer
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x4A55A00", Offset = "0x4A54600", VA = "0x184A55A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000497")]
		public unsafe InputEvent* currentEventPtr
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x56DBA50", Offset = "0x56DA650", VA = "0x1856DBA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x17000498")]
		public uint numBytesRetainedInBuffer
		{
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x56DBA70", Offset = "0x56DA670", VA = "0x1856DBA70")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x56DB9B0", Offset = "0x56DA5B0", VA = "0x1856DB9B0")]
		public InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents)
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x56DB5A0", Offset = "0x56DA1A0", VA = "0x1856DB5A0")]
		public void Close(ref InputEventBuffer eventBuffer)
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x56DB500", Offset = "0x56DA100", VA = "0x1856DB500")]
		public void CleanUpAfterException()
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x56DB750", Offset = "0x56DA350", VA = "0x1856DB750")]
		public unsafe void Write(InputEvent* eventPtr)
		{
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x56DB450", Offset = "0x56DA050", VA = "0x1856DB450")]
		public unsafe InputEvent* Advance(bool leaveEventInBuffer)
		{
			return null;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x56DB710", Offset = "0x56DA310", VA = "0x1856DB710")]
		public unsafe InputEvent* Peek()
		{
			return null;
		}

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x0")]
		private InputEventBuffer m_NativeBuffer;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x20")]
		private unsafe InputEvent* m_CurrentNativeEventReadPtr;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x28")]
		private unsafe InputEvent* m_CurrentNativeEventWritePtr;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x30")]
		private int m_RemainingNativeEventCount;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x34")]
		private readonly int m_MaxAppendedEvents;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x38")]
		private InputEventBuffer m_AppendBuffer;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x58")]
		private unsafe InputEvent* m_CurrentAppendEventReadPtr;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x60")]
		private unsafe InputEvent* m_CurrentAppendEventWritePtr;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x68")]
		private int m_RemainingAppendEventCount;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x6C")]
		private int m_NumEventsRetainedInBuffer;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsOpen;
	}
}
