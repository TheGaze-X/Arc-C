using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4A887E0", Offset = "0x4A873E0", VA = "0x184A887E0")]
		public X509CertificateCollection()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x512DE70", Offset = "0x512CA70", VA = "0x18512DE70")]
		public X509CertificateCollection(X509CertificateCollection value)
		{
		}

		// Token: 0x1700017C RID: 380
		[Token(Token = "0x1700017C")]
		public X509Certificate this[int index]
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x512DEA0", Offset = "0x512CAA0", VA = "0x18512DEA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x512DD20", Offset = "0x512C920", VA = "0x18512DD20")]
		public int Add(X509Certificate value)
		{
			return 0;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x512DB40", Offset = "0x512C740", VA = "0x18512DB40")]
		public void AddRange(X509CertificateCollection value)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x512DDD0", Offset = "0x512C9D0", VA = "0x18512DDD0")]
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x2000140")]
		public class X509CertificateEnumerator : IEnumerator
		{
			// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x512E0D0", Offset = "0x512CCD0", VA = "0x18512E0D0")]
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700017D")]
			public X509Certificate Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x512E140", Offset = "0x512CD40", VA = "0x18512E140")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700017E")]
			private object Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x512E080", Offset = "0x512CC80", VA = "0x18512E080", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x00004FF8 File Offset: 0x000031F8
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x512DFE0", Offset = "0x512CBE0", VA = "0x18512DFE0", Slot = "4")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x512E030", Offset = "0x512CC30", VA = "0x18512E030", Slot = "6")]
			private void Reset()
			{
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x00005010 File Offset: 0x00003210
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x512DF90", Offset = "0x512CB90", VA = "0x18512DF90")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			[FieldOffset(Offset = "0x10")]
			private IEnumerator enumerator;
		}
	}
}
