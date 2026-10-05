using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch>
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x56DFFC0", Offset = "0x56DEBC0", VA = "0x1856DFFC0")]
		internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1)
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x56DFF20", Offset = "0x56DEB20", VA = "0x1856DFF20", Slot = "6")]
		public IEnumerator<Touch> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x56DFFB0", Offset = "0x56DEBB0", VA = "0x1856DFFB0", Slot = "7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x170003E9")]
		public int Count
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EA RID: 1002
		[Token(Token = "0x170003EA")]
		public Touch this[int index]
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x56E0040", Offset = "0x56DEC40", VA = "0x1856E0040", Slot = "4")]
			get
			{
				return default(Touch);
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x56DFE50", Offset = "0x56DEA50", VA = "0x1856DFE50")]
		internal void CheckValid()
		{
		}

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x0")]
		private readonly InputStateHistory<TouchState> m_History;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x8")]
		private readonly Finger m_Finger;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_Count;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x14")]
		private readonly int m_StartIndex;

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x18")]
		private readonly uint m_Version;

		// Token: 0x0200014E RID: 334
		[Token(Token = "0x200014E")]
		private class Enumerator : IEnumerator<Touch>, IEnumerator, IDisposable
		{
			// Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x56D40A0", Offset = "0x56D2CA0", VA = "0x1856D40A0")]
			internal Enumerator(TouchHistory owner)
			{
			}

			// Token: 0x06000E96 RID: 3734 RVA: 0x00007488 File Offset: 0x00005688
			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x56D3E50", Offset = "0x56D2A50", VA = "0x1856D3E50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000E97 RID: 3735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E97")]
			[Address(RVA = "0x53C6610", Offset = "0x53C5210", VA = "0x1853C6610", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000E98 RID: 3736 RVA: 0x000074A0 File Offset: 0x000056A0
			[Token(Token = "0x170003EB")]
			public Touch Current
			{
				[Token(Token = "0x6000E98")]
				[Address(RVA = "0x56D4160", Offset = "0x56D2D60", VA = "0x1856D4160", Slot = "4")]
				get
				{
					return default(Touch);
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003EC")]
			private object Current
			{
				[Token(Token = "0x6000E99")]
				[Address(RVA = "0x56D3F70", Offset = "0x56D2B70", VA = "0x1856D3F70", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x0400083C RID: 2108
			[Token(Token = "0x400083C")]
			[FieldOffset(Offset = "0x10")]
			private readonly TouchHistory m_Owner;

			// Token: 0x0400083D RID: 2109
			[Token(Token = "0x400083D")]
			[FieldOffset(Offset = "0x30")]
			private int m_Index;
		}
	}
}
