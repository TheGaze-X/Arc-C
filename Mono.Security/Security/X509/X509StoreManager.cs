using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public sealed class X509StoreManager
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		internal static string CurrentUserPath
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x4A8E640", Offset = "0x4A8D240", VA = "0x184A8E640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		internal static string LocalMachinePath
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x4A8E940", Offset = "0x4A8D540", VA = "0x184A8E940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		internal static string NewCurrentUserPath
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x4A8EC60", Offset = "0x4A8D860", VA = "0x184A8EC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		internal static string NewLocalMachinePath
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x4A8ED90", Offset = "0x4A8D990", VA = "0x184A8ED90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public static X509Stores CurrentUser
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x4A8E760", Offset = "0x4A8D360", VA = "0x184A8E760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public static X509Stores LocalMachine
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x4A8EA70", Offset = "0x4A8D670", VA = "0x184A8EA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public static X509CertificateCollection TrustedRootCertificates
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x4A8EEC0", Offset = "0x4A8DAC0", VA = "0x184A8EEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static string _userPath;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x8")]
		private static string _localMachinePath;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		private static string _newUserPath;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		private static string _newLocalMachinePath;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		private static X509Stores _userStore;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x28")]
		private static X509Stores _machineStore;
	}
}
