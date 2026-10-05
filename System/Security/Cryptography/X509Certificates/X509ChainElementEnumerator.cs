using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public sealed class X509ChainElementEnumerator : IEnumerator
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x512EE90", Offset = "0x512DA90", VA = "0x18512EE90")]
		internal X509ChainElementEnumerator(IEnumerable enumerable)
		{
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018B")]
		public X509ChainElement Current
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x512EF00", Offset = "0x512DB00", VA = "0x18512EF00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018C")]
		private object Current
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x512EE40", Offset = "0x512DA40", VA = "0x18512EE40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x512EDA0", Offset = "0x512D9A0", VA = "0x18512EDA0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x512EDF0", Offset = "0x512D9F0", VA = "0x18512EDF0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
