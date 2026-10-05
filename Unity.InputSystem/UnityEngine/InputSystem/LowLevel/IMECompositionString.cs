using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	[StructLayout(2)]
	public struct IMECompositionString : IEnumerable<char>, IEnumerable
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x17000476")]
		public int Count
		{
			[Token(Token = "0x6000FD0")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000477 RID: 1143
		[Token(Token = "0x17000477")]
		public char this[int index]
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x56D99C0", Offset = "0x56D85C0", VA = "0x1856D99C0")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x56D9930", Offset = "0x56D8530", VA = "0x1856D9930")]
		public IMECompositionString(string characters)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x56D9900", Offset = "0x56D8500", VA = "0x1856D9900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x56D9810", Offset = "0x56D8410", VA = "0x1856D9810", Slot = "4")]
		public IEnumerator<char> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x56D98F0", Offset = "0x56D84F0", VA = "0x1856D98F0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int size;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[FixedBuffer(typeof(char), 64)]
		private IMECompositionString.<buffer>e__FixedBuffer buffer;

		// Token: 0x020001AB RID: 427
		[Token(Token = "0x20001AB")]
		internal struct Enumerator : IEnumerator<char>, IEnumerator, IDisposable
		{
			// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x56D4040", Offset = "0x56D2C40", VA = "0x1856D4040")]
			public Enumerator(IMECompositionString compositionString)
			{
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x000083A0 File Offset: 0x000065A0
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x56D3ED0", Offset = "0x56D2AD0", VA = "0x1856D3ED0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x56D3F10", Offset = "0x56D2B10", VA = "0x1856D3F10", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000083B8 File Offset: 0x000065B8
			[Token(Token = "0x17000478")]
			public char Current
			{
				[Token(Token = "0x6000FDA")]
				[Address(RVA = "0x400A190", Offset = "0x4008D90", VA = "0x18400A190", Slot = "4")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000479")]
			private object Current
			{
				[Token(Token = "0x6000FDB")]
				[Address(RVA = "0x56D3FF0", Offset = "0x56D2BF0", VA = "0x1856D3FF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040009AE RID: 2478
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IMECompositionString m_CompositionString;

			// Token: 0x040009AF RID: 2479
			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private char m_CurrentCharacter;

			// Token: 0x040009B0 RID: 2480
			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int m_CurrentIndex;
		}

		// Token: 0x020001AC RID: 428
		[Token(Token = "0x20001AC")]
		[UnsafeValueType]
		[CompilerGenerated]
		public struct <buffer>e__FixedBuffer
		{
			// Token: 0x040009B1 RID: 2481
			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char FixedElementField;
		}
	}
}
