using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class LuaCallCSharpAttribute : Attribute
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x00016470 File Offset: 0x00014670
		[Token(Token = "0x17000143")]
		public GenFlag Flag
		{
			[Token(Token = "0x60036C1")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return GenFlag.No;
			}
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		{
		}

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x10")]
		private GenFlag flag;
	}
}
