using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	[AttributeUsage(AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x5107CE0", Offset = "0x51068E0", VA = "0x185107CE0")]
		public MonitoringDescriptionAttribute(string description)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000136")]
		public override string Description
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x5107D40", Offset = "0x5106940", VA = "0x185107D40", Slot = "7")]
			get
			{
				return null;
			}
		}
	}
}
