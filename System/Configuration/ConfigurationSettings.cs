using System;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public sealed class ConfigurationSettings
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x50BB7F0", Offset = "0x50BA3F0", VA = "0x1850BB7F0")]
		internal ConfigurationSettings()
		{
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000684")]
		public static NameValueCollection AppSettings
		{
			[Token(Token = "0x6001C4F")]
			[Address(RVA = "0x50BB820", Offset = "0x50BA420", VA = "0x1850BB820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x50BB7C0", Offset = "0x50BA3C0", VA = "0x1850BB7C0")]
		[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
		public static object GetConfig(string sectionName)
		{
			return null;
		}
	}
}
