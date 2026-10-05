using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Authentication
{
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	public sealed class Credentials
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000124E0 File Offset: 0x000106E0
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000639")]
		public AuthenticationTypes Type
		{
			[Token(Token = "0x6002ADA")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return AuthenticationTypes.Unknown;
			}
			[Token(Token = "0x6002ADB")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002ADD RID: 10973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063A")]
		public string UserName
		{
			[Token(Token = "0x6002ADC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ADD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063B")]
		public string Password
		{
			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x53CB200", Offset = "0x53C9E00", VA = "0x1853CB200")]
		public Credentials(string userName, string password)
		{
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0x43CCED0", Offset = "0x43CBAD0", VA = "0x1843CCED0")]
		public Credentials(AuthenticationTypes type, string userName, string password)
		{
		}
	}
}
