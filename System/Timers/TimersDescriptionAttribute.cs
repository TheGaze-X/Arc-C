using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Timers
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[AttributeUsage(AttributeTargets.All)]
	public class TimersDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x51041C0", Offset = "0x5102DC0", VA = "0x1851041C0")]
		public TimersDescriptionAttribute(string description)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public override string Description
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x5104220", Offset = "0x5102E20", VA = "0x185104220", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x18")]
		private bool replaced;
	}
}
