using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	internal class X509ChainImplBtls : X509ChainImpl
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x50E5D20", Offset = "0x50E4920", VA = "0x1850E5D20")]
		internal X509ChainImplBtls(MonoBtlsX509Chain chain)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x50E56B0", Offset = "0x50E42B0", VA = "0x1850E56B0")]
		internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x17000087")]
		public override bool IsValid
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x50E61D0", Offset = "0x50E4DD0", VA = "0x1850E61D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		internal MonoBtlsX509StoreCtx StoreCtx
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x50E61F0", Offset = "0x50E4DF0", VA = "0x1850E61F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public override X509ChainElementCollection ChainElements
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x50E5F00", Offset = "0x50E4B00", VA = "0x1850E5F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public override X509ChainPolicy ChainPolicy
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x50E5360", Offset = "0x50E3F60", VA = "0x1850E5360", Slot = "9")]
		public override void AddStatus(X509ChainStatusFlags errorCode)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool Build(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x50E5610", Offset = "0x50E4210", VA = "0x1850E5610", Slot = "10")]
		public override void Reset()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x50E54B0", Offset = "0x50E40B0", VA = "0x1850E54B0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		private MonoBtlsX509StoreCtx storeCtx;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		private MonoBtlsX509Chain chain;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		private MonoBtlsX509Chain untrustedChain;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		private X509ChainElementCollection elements;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		private X509Certificate2Collection untrusted;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x38")]
		private X509Certificate2[] certificates;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x40")]
		private X509ChainPolicy policy;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x48")]
		private List<X509ChainStatus> chainStatusList;
	}
}
