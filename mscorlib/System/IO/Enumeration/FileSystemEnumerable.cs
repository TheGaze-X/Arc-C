using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.IO.Enumeration
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	public class FileSystemEnumerable<TResult> : System.Collections.Generic.IEnumerable<TResult>, System.Collections.IEnumerable
	{
		// Token: 0x0600334F RID: 13135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334F")]
		public FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, [System.Runtime.InteropServices.Optional] EnumerationOptions options)
		{
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082F")]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate
		{
			[Token(Token = "0x6003350")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003351")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000830")]
		public FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate
		{
			[Token(Token = "0x6003352")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003353")]
		public System.Collections.Generic.IEnumerator<TResult> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003354")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04001BFB RID: 7163
		[Token(Token = "0x4001BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator;

		// Token: 0x04001BFC RID: 7164
		[Token(Token = "0x4001BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly FileSystemEnumerable<TResult>.FindTransform _transform;

		// Token: 0x04001BFD RID: 7165
		[Token(Token = "0x4001BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EnumerationOptions _options;

		// Token: 0x04001BFE RID: 7166
		[Token(Token = "0x4001BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _directory;

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x06003356 RID: 13142
		[Token(Token = "0x2000691")]
		public delegate bool FindPredicate(ref FileSystemEntry entry);

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x06003358 RID: 13144
		[Token(Token = "0x2000692")]
		public delegate TResult FindTransform(ref FileSystemEntry entry);

		// Token: 0x02000693 RID: 1683
		[Token(Token = "0x2000693")]
		private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x06003359 RID: 13145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003359")]
			public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
			{
			}

			// Token: 0x0600335A RID: 13146 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600335A")]
			protected override TResult TransformEntry(ref FileSystemEntry entry)
			{
				return null;
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x0001B5A0 File Offset: 0x000197A0
			[Token(Token = "0x600335B")]
			protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
			{
				return default(bool);
			}

			// Token: 0x0600335C RID: 13148 RVA: 0x0001B5B8 File Offset: 0x000197B8
			[Token(Token = "0x600335C")]
			protected override bool ShouldIncludeEntry(ref FileSystemEntry entry)
			{
				return default(bool);
			}

			// Token: 0x04001C01 RID: 7169
			[Token(Token = "0x4001C01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly FileSystemEnumerable<TResult> _enumerable;
		}
	}
}
