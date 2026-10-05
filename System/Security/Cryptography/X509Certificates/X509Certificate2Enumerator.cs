using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	public sealed class X509Certificate2Enumerator : IEnumerator
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x51290F0", Offset = "0x5127CF0", VA = "0x1851290F0")]
		internal X509Certificate2Enumerator(X509Certificate2Collection collection)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		public X509Certificate2 Current
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x5129160", Offset = "0x5127D60", VA = "0x185129160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x5128FB0", Offset = "0x5127BB0", VA = "0x185128FB0")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		private object Current
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x51290A0", Offset = "0x5127CA0", VA = "0x1851290A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x5129000", Offset = "0x5127C00", VA = "0x185129000", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5129050", Offset = "0x5127C50", VA = "0x185129050", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
