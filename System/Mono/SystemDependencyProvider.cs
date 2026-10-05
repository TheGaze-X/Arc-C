using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal class SystemDependencyProvider : ISystemDependencyProvider
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public static SystemDependencyProvider Instance
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x4F5F4A0", Offset = "0x4F5E0A0", VA = "0x184F5F4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F5F180", Offset = "0x4F5DD80", VA = "0x184F5F180")]
		internal static void Initialize()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		private ISystemCertificateProvider CertificateProvider
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public SystemCertificateProvider CertificateProvider
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public X509PalImpl X509Pal
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4F5F500", Offset = "0x4F5E100", VA = "0x184F5F500")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4F5F400", Offset = "0x4F5E000", VA = "0x184F5F400")]
		private SystemDependencyProvider()
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		private static SystemDependencyProvider instance;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x8")]
		private static object syncRoot;
	}
}
