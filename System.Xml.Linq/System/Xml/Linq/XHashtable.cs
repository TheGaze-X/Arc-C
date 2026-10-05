using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	internal sealed class XHashtable<TValue>
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000073")]
		public XHashtable(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000074")]
		public bool TryGetValue(string key, int index, int count, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		public TValue Add(TValue value)
		{
			return null;
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		private XHashtable<TValue>.XHashtableState _state;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000077 RID: 119
		[Token(Token = "0x200000E")]
		public delegate string ExtractKeyDelegate(TValue value);

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		private sealed class XHashtableState
		{
			// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000078")]
			public XHashtableState(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
			{
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000079")]
			public XHashtable<TValue>.XHashtableState Resize()
			{
				return null;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002178 File Offset: 0x00000378
			[Token(Token = "0x600007A")]
			public bool TryGetValue(string key, int index, int count, out TValue value)
			{
				return default(bool);
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002190 File Offset: 0x00000390
			[Token(Token = "0x600007B")]
			public bool TryAdd(TValue value, out TValue newValue)
			{
				return default(bool);
			}

			// Token: 0x0600007C RID: 124 RVA: 0x000021A8 File Offset: 0x000003A8
			[Token(Token = "0x600007C")]
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
			{
				return default(bool);
			}

			// Token: 0x0600007D RID: 125 RVA: 0x000021C0 File Offset: 0x000003C0
			[Token(Token = "0x600007D")]
			private static int ComputeHashCode(string key, int index, int count)
			{
				return 0;
			}

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x0")]
			private int[] _buckets;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.XHashtableState.Entry[] _entries;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			private int _numEntries;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x0")]
			private XHashtable<TValue>.ExtractKeyDelegate _extractKey;

			// Token: 0x02000010 RID: 16
			[Token(Token = "0x2000010")]
			private struct Entry
			{
				// Token: 0x04000021 RID: 33
				[Token(Token = "0x4000021")]
				[FieldOffset(Offset = "0x0")]
				public TValue Value;

				// Token: 0x04000022 RID: 34
				[Token(Token = "0x4000022")]
				[FieldOffset(Offset = "0x0")]
				public int HashCode;

				// Token: 0x04000023 RID: 35
				[Token(Token = "0x4000023")]
				[FieldOffset(Offset = "0x0")]
				public int Next;
			}
		}
	}
}
