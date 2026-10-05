using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsSerializeAsAttribute : Attribute
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
		{
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[Token(Token = "0x1700069D")]
		public SettingsSerializeAs SerializeAs
		{
			[Token(Token = "0x6001CA4")]
			[Address(RVA = "0x50C0590", Offset = "0x50BF190", VA = "0x1850C0590")]
			get
			{
				return SettingsSerializeAs.String;
			}
		}
	}
}
