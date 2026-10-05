using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsManageabilityAttribute : Attribute
	{
		// Token: 0x06001C92 RID: 7314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public SettingsManageabilityAttribute(SettingsManageability manageability)
		{
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x1700069B")]
		public SettingsManageability Manageability
		{
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x50BF3C0", Offset = "0x50BDFC0", VA = "0x1850BF3C0")]
			get
			{
				return SettingsManageability.Roaming;
			}
		}
	}
}
