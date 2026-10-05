using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsProviderAttribute : Attribute
	{
		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public SettingsProviderAttribute(string providerTypeName)
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public SettingsProviderAttribute(Type providerType)
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		public string ProviderTypeName
		{
			[Token(Token = "0x6001CA2")]
			[Address(RVA = "0x50C01D0", Offset = "0x50BEDD0", VA = "0x1850C01D0")]
			get
			{
				return null;
			}
		}
	}
}
