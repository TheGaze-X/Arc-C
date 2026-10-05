using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020B9 RID: 8377
	[Token(Token = "0x20020B9")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NodeLabelWidthAttribute : Attribute
	{
		// Token: 0x0600CDB7 RID: 52663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDB7")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public NodeLabelWidthAttribute(int width)
		{
		}

		// Token: 0x0400D9CC RID: 55756
		[Token(Token = "0x400D9CC")]
		public const int DEFAULT_WIDTH = 100;

		// Token: 0x0400D9CD RID: 55757
		[Token(Token = "0x400D9CD")]
		[FieldOffset(Offset = "0x10")]
		public int width;
	}
}
