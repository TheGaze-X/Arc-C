using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class GarbageFreeIterators
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000011")]
		public static GarbageFreeIterators.ListIterator<T> GFIterator<T>(this List<T> list)
		{
			return default(GarbageFreeIterators.ListIterator<T>);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000012")]
		public static GarbageFreeIterators.DictionaryIterator<T1, T2> GFIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			return default(GarbageFreeIterators.DictionaryIterator<T1, T2>);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000013")]
		public static GarbageFreeIterators.DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			return default(GarbageFreeIterators.DictionaryValueIterator<T1, T2>);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000014")]
		public static GarbageFreeIterators.HashsetIterator<T> GFIterator<T>(this HashSet<T> hashset)
		{
			return default(GarbageFreeIterators.HashsetIterator<T>);
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public struct ListIterator<T> : IDisposable
		{
			// Token: 0x06000015 RID: 21 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000015")]
			public ListIterator(List<T> list)
			{
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00002144 File Offset: 0x00000344
			[Token(Token = "0x6000016")]
			public GarbageFreeIterators.ListIterator<T> GetEnumerator()
			{
				return default(GarbageFreeIterators.ListIterator<T>);
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000001")]
			public T Current
			{
				[Token(Token = "0x6000017")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000018 RID: 24 RVA: 0x0000215C File Offset: 0x0000035C
			[Token(Token = "0x6000018")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000019 RID: 25 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000019")]
			public void Dispose()
			{
			}

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x0")]
			private bool isNull;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x0")]
			private List<T> list;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x0")]
			private List<T>.Enumerator enumerator;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public struct HashsetIterator<T> : IDisposable
		{
			// Token: 0x0600001A RID: 26 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600001A")]
			public HashsetIterator(HashSet<T> hashset)
			{
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002174 File Offset: 0x00000374
			[Token(Token = "0x600001B")]
			public GarbageFreeIterators.HashsetIterator<T> GetEnumerator()
			{
				return default(GarbageFreeIterators.HashsetIterator<T>);
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600001C RID: 28 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000002")]
			public T Current
			{
				[Token(Token = "0x600001C")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600001D RID: 29 RVA: 0x0000218C File Offset: 0x0000038C
			[Token(Token = "0x600001D")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600001E")]
			public void Dispose()
			{
			}

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x0")]
			private bool isNull;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x0")]
			private HashSet<T> hashset;

			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x0")]
			private HashSet<T>.Enumerator enumerator;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public struct DictionaryIterator<T1, T2> : IDisposable
		{
			// Token: 0x0600001F RID: 31 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600001F")]
			public DictionaryIterator(Dictionary<T1, T2> dictionary)
			{
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000021A4 File Offset: 0x000003A4
			[Token(Token = "0x6000020")]
			public GarbageFreeIterators.DictionaryIterator<T1, T2> GetEnumerator()
			{
				return default(GarbageFreeIterators.DictionaryIterator<T1, T2>);
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000021 RID: 33 RVA: 0x000021BC File Offset: 0x000003BC
			[Token(Token = "0x17000003")]
			public KeyValuePair<T1, T2> Current
			{
				[Token(Token = "0x6000021")]
				get
				{
					return default(KeyValuePair<T1, T2>);
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000021D4 File Offset: 0x000003D4
			[Token(Token = "0x6000022")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000023")]
			public void Dispose()
			{
			}

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<T1, T2> dictionary;

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<T1, T2>.Enumerator enumerator;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x0")]
			private bool isNull;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public struct DictionaryValueIterator<T1, T2> : IDisposable
		{
			// Token: 0x06000024 RID: 36 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000024")]
			public DictionaryValueIterator(Dictionary<T1, T2> dictionary)
			{
			}

			// Token: 0x06000025 RID: 37 RVA: 0x000021EC File Offset: 0x000003EC
			[Token(Token = "0x6000025")]
			public GarbageFreeIterators.DictionaryValueIterator<T1, T2> GetEnumerator()
			{
				return default(GarbageFreeIterators.DictionaryValueIterator<T1, T2>);
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000004")]
			public T2 Current
			{
				[Token(Token = "0x6000026")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00002204 File Offset: 0x00000404
			[Token(Token = "0x6000027")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000028")]
			public void Dispose()
			{
			}

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<T1, T2> dictionary;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<T1, T2>.Enumerator enumerator;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x0")]
			private bool isNull;
		}
	}
}
