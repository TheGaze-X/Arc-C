using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SpecialSettingAttribute : Attribute
	{
		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public SpecialSettingAttribute(SpecialSetting specialSetting)
		{
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x1700069E")]
		public SpecialSetting SpecialSetting
		{
			[Token(Token = "0x6001CA8")]
			[Address(RVA = "0x50C1E30", Offset = "0x50C0A30", VA = "0x1850C1E30")]
			get
			{
				return SpecialSetting.ConnectionString;
			}
		}
	}
}
