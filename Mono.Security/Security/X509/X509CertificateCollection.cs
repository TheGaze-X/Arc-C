using System;
using System.Collections;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4A887E0", Offset = "0x4A873E0", VA = "0x184A887E0")]
		public X509CertificateCollection()
		{
		}

		// Token: 0x1700003A RID: 58
		[Token(Token = "0x1700003A")]
		public X509Certificate this[int index]
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x4A887F0", Offset = "0x4A873F0", VA = "0x184A887F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4A88390", Offset = "0x4A86F90", VA = "0x184A88390")]
		public int Add(X509Certificate value)
		{
			return 0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4A88260", Offset = "0x4A86E60", VA = "0x184A88260")]
		public void AddRange(X509CertificateCollection value)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4A884B0", Offset = "0x4A870B0", VA = "0x184A884B0")]
		public bool Contains(X509Certificate value)
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4A884D0", Offset = "0x4A870D0", VA = "0x184A884D0")]
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4A88790", Offset = "0x4A87390", VA = "0x184A88790", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4A88570", Offset = "0x4A87170", VA = "0x184A88570")]
		public int IndexOf(X509Certificate value)
		{
			return 0;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4A88440", Offset = "0x4A87040", VA = "0x184A88440")]
		private bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public class X509CertificateEnumerator : IEnumerator
		{
			// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4A88A20", Offset = "0x4A87620", VA = "0x184A88A20")]
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003B")]
			public X509Certificate Current
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0x4A88A90", Offset = "0x4A87690", VA = "0x184A88A90")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003C")]
			private object Current
			{
				[Token(Token = "0x60000B7")]
				[Address(RVA = "0x4A889D0", Offset = "0x4A875D0", VA = "0x184A889D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00002418 File Offset: 0x00000618
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x4A88930", Offset = "0x4A87530", VA = "0x184A88930", Slot = "4")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x4A88980", Offset = "0x4A87580", VA = "0x184A88980", Slot = "6")]
			private void Reset()
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002430 File Offset: 0x00000630
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4A888E0", Offset = "0x4A874E0", VA = "0x184A888E0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x10")]
			private IEnumerator enumerator;
		}
	}
}
