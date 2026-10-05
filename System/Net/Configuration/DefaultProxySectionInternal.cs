using System;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	internal sealed class DefaultProxySectionInternal
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x509D360", Offset = "0x509BF60", VA = "0x18509D360")]
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			return null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x509D360", Offset = "0x509BF60", VA = "0x18509D360")]
		private static IWebProxy GetSystemWebProxy()
		{
			return null;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056C")]
		internal static object ClassSyncObject
		{
			[Token(Token = "0x60018A7")]
			[Address(RVA = "0x509D4F0", Offset = "0x509C0F0", VA = "0x18509D4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x509D370", Offset = "0x509BF70", VA = "0x18509D370")]
		internal static DefaultProxySectionInternal GetSection()
		{
			return null;
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056D")]
		internal IWebProxy WebProxy
		{
			[Token(Token = "0x60018A9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultProxySectionInternal()
		{
		}

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x10")]
		private IWebProxy webProxy;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x0")]
		private static object classSyncObject;
	}
}
