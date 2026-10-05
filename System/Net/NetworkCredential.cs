using System;
using System.Security;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class NetworkCredential : ICredentials
	{
		// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x505B6F0", Offset = "0x505A2F0", VA = "0x18505B6F0")]
		public NetworkCredential(string userName, string password)
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x505B610", Offset = "0x505A210", VA = "0x18505B610")]
		public NetworkCredential(string userName, string password, string domain)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040F")]
		public string UserName
		{
			[Token(Token = "0x600136D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600136E")]
			[Address(RVA = "0x505B890", Offset = "0x505A490", VA = "0x18505B890")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000410")]
		public string Password
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x505B600", Offset = "0x505A200", VA = "0x18505B600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001370")]
			[Address(RVA = "0x505B860", Offset = "0x505A460", VA = "0x18505B860")]
			set
			{
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000411")]
		public string Domain
		{
			[Token(Token = "0x6001371")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001372")]
			[Address(RVA = "0x505B800", Offset = "0x505A400", VA = "0x18505B800")]
			set
			{
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		internal string InternalGetUserName()
		{
			return null;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x505B600", Offset = "0x505A200", VA = "0x18505B600")]
		internal string InternalGetPassword()
		{
			return null;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		internal string InternalGetDomain()
		{
			return null;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "4")]
		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			return null;
		}

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x10")]
		private string m_domain;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x18")]
		private string m_userName;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x20")]
		private SecureString m_password;
	}
}
