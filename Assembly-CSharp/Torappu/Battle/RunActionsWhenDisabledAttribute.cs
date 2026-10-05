using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021A3 RID: 8611
	[Token(Token = "0x20021A3")]
	[AttributeUsage(AttributeTargets.Field)]
	public class RunActionsWhenDisabledAttribute : Attribute
	{
		// Token: 0x0600D6AF RID: 54959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6AF")]
		[Address(RVA = "0x4EEA50", Offset = "0x4ED650", VA = "0x1804EEA50")]
		public RunActionsWhenDisabledAttribute(bool runWhenDisabled)
		{
		}

		// Token: 0x0400E6D6 RID: 59094
		[Token(Token = "0x400E6D6")]
		[FieldOffset(Offset = "0x10")]
		public bool runWhenDisabled;
	}
}
