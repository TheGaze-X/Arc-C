using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020BA RID: 8378
	[Token(Token = "0x20020BA")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NodeBlockWidthAttribute : Attribute
	{
		// Token: 0x0600CDB8 RID: 52664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDB8")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public NodeBlockWidthAttribute(int width)
		{
		}

		// Token: 0x0400D9CE RID: 55758
		[Token(Token = "0x400D9CE")]
		[FieldOffset(Offset = "0x10")]
		public int width;

		// Token: 0x0400D9CF RID: 55759
		[Token(Token = "0x400D9CF")]
		[FieldOffset(Offset = "0x0")]
		public static int DEFAULT_WIDTH;
	}
}
