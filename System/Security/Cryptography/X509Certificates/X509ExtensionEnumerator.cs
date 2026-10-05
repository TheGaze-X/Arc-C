using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public sealed class X509ExtensionEnumerator : IEnumerator
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x5136440", Offset = "0x5135040", VA = "0x185136440")]
		internal X509ExtensionEnumerator(ArrayList list)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A6")]
		public X509Extension Current
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x51364B0", Offset = "0x51350B0", VA = "0x1851364B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A7")]
		private object Current
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x51363F0", Offset = "0x5134FF0", VA = "0x1851363F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x5136350", Offset = "0x5134F50", VA = "0x185136350", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x51363A0", Offset = "0x5134FA0", VA = "0x1851363A0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
