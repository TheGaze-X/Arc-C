using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class GCOptimizeAttribute : Attribute
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00016488 File Offset: 0x00014688
		[Token(Token = "0x17000144")]
		public OptimizeFlag Flag
		{
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return OptimizeFlag.Default;
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default)
		{
		}

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x10")]
		private OptimizeFlag flag;
	}
}
