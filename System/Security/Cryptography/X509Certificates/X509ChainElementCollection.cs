using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public sealed class X509ChainElementCollection : ICollection, IEnumerable
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x512EC40", Offset = "0x512D840", VA = "0x18512EC40")]
		internal X509ChainElementCollection()
		{
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x17000187")]
		public int Count
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x17000188")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x4C5BA30", Offset = "0x4C5A630", VA = "0x184C5BA30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000189 RID: 393
		[Token(Token = "0x17000189")]
		public X509ChainElement this[int index]
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x512ECB0", Offset = "0x512D8B0", VA = "0x18512ECB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public object SyncRoot
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x4C5BA80", Offset = "0x4C5A680", VA = "0x184C5BA80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x4C5B9D0", Offset = "0x4C5A5D0", VA = "0x184C5B9D0", Slot = "4")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x512EB00", Offset = "0x512D700", VA = "0x18512EB00")]
		public X509ChainElementEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x512EBA0", Offset = "0x512D7A0", VA = "0x18512EBA0", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x512E7F0", Offset = "0x512D3F0", VA = "0x18512E7F0")]
		internal void Add(X509Certificate2 certificate)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x512E8E0", Offset = "0x512D4E0", VA = "0x18512E8E0")]
		internal void Clear()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x512E920", Offset = "0x512D520", VA = "0x18512E920")]
		internal bool Contains(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
