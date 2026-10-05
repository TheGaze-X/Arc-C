using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[AttributeUsage(AttributeTargets.All)]
	internal class SRDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x51030E0", Offset = "0x5101CE0", VA = "0x1851030E0")]
		public SRDescriptionAttribute(string description)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		public override string Description
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x5103140", Offset = "0x5101D40", VA = "0x185103140", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x18")]
		private bool isReplaced;
	}
}
