using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class X509Chain : IDisposable
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000181")]
		internal X509ChainImpl Impl
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x5134B50", Offset = "0x5133750", VA = "0x185134B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x51349C0", Offset = "0x51335C0", VA = "0x1851349C0")]
		public X509Chain()
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x5134A30", Offset = "0x5133630", VA = "0x185134A30")]
		public X509Chain(bool useMachineContext)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x5134930", Offset = "0x5133530", VA = "0x185134930")]
		internal X509Chain(X509ChainImpl impl)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x51348E0", Offset = "0x51334E0", VA = "0x1851348E0")]
		[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
		public X509Chain(IntPtr chainContext)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public X509ChainElementCollection ChainElements
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x5134AB0", Offset = "0x51336B0", VA = "0x185134AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public X509ChainPolicy ChainPolicy
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x5134B00", Offset = "0x5133700", VA = "0x185134B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x5134670", Offset = "0x5133270", VA = "0x185134670")]
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public bool Build(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x5134890", Offset = "0x5133490", VA = "0x185134890")]
		public void Reset()
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x51346D0", Offset = "0x51332D0", VA = "0x1851346D0")]
		public static X509Chain Create()
		{
			return null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x5134820", Offset = "0x5133420", VA = "0x185134820", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x5134780", Offset = "0x5133380", VA = "0x185134780", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x10")]
		private X509ChainImpl impl;
	}
}
