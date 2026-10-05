using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public sealed class OidEnumerator : IEnumerator
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x4CA8B10", Offset = "0x4CA7710", VA = "0x184CA8B10")]
		internal OidEnumerator(OidCollection oids)
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public Oid Current
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x51245F0", Offset = "0x51231F0", VA = "0x1851245F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		private object Current
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x51245F0", Offset = "0x51231F0", VA = "0x1851245F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x5124570", Offset = "0x5123170", VA = "0x185124570", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x10")]
		private readonly OidCollection _oids;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x18")]
		private int _current;
	}
}
