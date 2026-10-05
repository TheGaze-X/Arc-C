using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public struct InputEventBuffer : IEnumerable<InputEventPtr>, IEnumerable, IDisposable, ICloneable
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x17000481")]
		public int eventCount
		{
			[Token(Token = "0x6000FEF")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x17000482")]
		public long sizeInBytes
		{
			[Token(Token = "0x6000FF0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x17000483")]
		public long capacityInBytes
		{
			[Token(Token = "0x6000FF1")]
			[Address(RVA = "0x56DA740", Offset = "0x56D9340", VA = "0x1856DA740")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x17000484")]
		public NativeArray<byte> data
		{
			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
			get
			{
				return default(NativeArray<byte>);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x17000485")]
		public InputEventPtr bufferPtr
		{
			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0x56DA6F0", Offset = "0x56D92F0", VA = "0x1856DA6F0")]
			get
			{
				return default(InputEventPtr);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x56DA3C0", Offset = "0x56D8FC0", VA = "0x1856DA3C0")]
		public unsafe InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x56DA5B0", Offset = "0x56D91B0", VA = "0x1856DA5B0")]
		public InputEventBuffer(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = false)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x56DA010", Offset = "0x56D8C10", VA = "0x1856DA010")]
		public unsafe void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048, Allocator allocator = Allocator.Persistent)
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x56D9D10", Offset = "0x56D8910", VA = "0x1856D9D10")]
		public unsafe InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, Allocator allocator = Allocator.Persistent)
		{
			return null;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x56DA170", Offset = "0x56D8D70", VA = "0x1856DA170")]
		public unsafe bool Contains(InputEvent* eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x56DA330", Offset = "0x56D8F30", VA = "0x1856DA330")]
		public void Reset()
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x56D9C70", Offset = "0x56D8870", VA = "0x1856D9C70")]
		internal unsafe void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer)
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x56DA250", Offset = "0x56D8E50", VA = "0x1856DA250", Slot = "4")]
		public IEnumerator<InputEventPtr> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x56DA350", Offset = "0x56D8F50", VA = "0x1856DA350", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x56DA200", Offset = "0x56D8E00", VA = "0x1856DA200", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x56DA0B0", Offset = "0x56D8CB0", VA = "0x1856DA0B0")]
		public InputEventBuffer Clone()
		{
			return default(InputEventBuffer);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x56DA360", Offset = "0x56D8F60", VA = "0x1856DA360", Slot = "7")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		public const long BufferSizeUnknown = -1L;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<byte> m_Buffer;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x10")]
		private long m_SizeInBytes;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x18")]
		private int m_EventCount;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_WeOwnTheBuffer;

		// Token: 0x020001AF RID: 431
		[Token(Token = "0x20001AF")]
		private struct Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
		{
			// Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001000")]
			[Address(RVA = "0x56D40F0", Offset = "0x56D2CF0", VA = "0x1856D40F0")]
			public Enumerator(InputEventBuffer buffer)
			{
			}

			// Token: 0x06001001 RID: 4097 RVA: 0x00008538 File Offset: 0x00006738
			[Token(Token = "0x6001001")]
			[Address(RVA = "0x56D3E80", Offset = "0x56D2A80", VA = "0x1856D3E80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x56D3F00", Offset = "0x56D2B00", VA = "0x1856D3F00", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001003")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06001004 RID: 4100 RVA: 0x00008550 File Offset: 0x00006750
			[Token(Token = "0x17000486")]
			public InputEventPtr Current
			{
				[Token(Token = "0x6001004")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
				get
				{
					return default(InputEventPtr);
				}
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06001005 RID: 4101 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000487")]
			private object Current
			{
				[Token(Token = "0x6001005")]
				[Address(RVA = "0x56D3F20", Offset = "0x56D2B20", VA = "0x1856D3F20", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040009BD RID: 2493
			[Token(Token = "0x40009BD")]
			[FieldOffset(Offset = "0x0")]
			private unsafe readonly InputEvent* m_Buffer;

			// Token: 0x040009BE RID: 2494
			[Token(Token = "0x40009BE")]
			[FieldOffset(Offset = "0x8")]
			private readonly int m_EventCount;

			// Token: 0x040009BF RID: 2495
			[Token(Token = "0x40009BF")]
			[FieldOffset(Offset = "0x10")]
			private unsafe InputEvent* m_CurrentEvent;

			// Token: 0x040009C0 RID: 2496
			[Token(Token = "0x40009C0")]
			[FieldOffset(Offset = "0x18")]
			private int m_CurrentIndex;
		}
	}
}
