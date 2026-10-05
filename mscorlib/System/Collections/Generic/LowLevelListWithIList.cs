using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000621 RID: 1569
	[Token(Token = "0x2000621")]
	internal sealed class LowLevelListWithIList<T> : LowLevelList<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06002F57 RID: 12119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F57")]
		public LowLevelListWithIList()
		{
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F58")]
		public LowLevelListWithIList(int capacity)
		{
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00019980 File Offset: 0x00017B80
		[Token(Token = "0x170007B4")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002F59")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F5A")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F5B")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x02000622 RID: 1570
		[Token(Token = "0x2000622")]
		private struct Enumerator : IEnumerator<T>, System.IDisposable, IEnumerator
		{
			// Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F5C")]
			internal Enumerator(LowLevelListWithIList<T> list)
			{
			}

			// Token: 0x06002F5D RID: 12125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F5D")]
			public void Dispose()
			{
			}

			// Token: 0x06002F5E RID: 12126 RVA: 0x00019998 File Offset: 0x00017B98
			[Token(Token = "0x6002F5E")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06002F5F RID: 12127 RVA: 0x000199B0 File Offset: 0x00017BB0
			[Token(Token = "0x6002F5F")]
			private bool MoveNextRare()
			{
				return default(bool);
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007B5")]
			public T Current
			{
				[Token(Token = "0x6002F60")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170007B6")]
			private object Current
			{
				[Token(Token = "0x6002F61")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002F62 RID: 12130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F62")]
			private void Reset()
			{
			}

			// Token: 0x04001A7E RID: 6782
			[Token(Token = "0x4001A7E")]
			[FieldOffset(Offset = "0x0")]
			private LowLevelListWithIList<T> _list;

			// Token: 0x04001A7F RID: 6783
			[Token(Token = "0x4001A7F")]
			[FieldOffset(Offset = "0x0")]
			private int _index;

			// Token: 0x04001A80 RID: 6784
			[Token(Token = "0x4001A80")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04001A81 RID: 6785
			[Token(Token = "0x4001A81")]
			[FieldOffset(Offset = "0x0")]
			private T _current;
		}
	}
}
