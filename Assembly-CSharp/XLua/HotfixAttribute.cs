using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class HotfixAttribute : Attribute
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x17000145")]
		public HotfixFlag Flag
		{
			[Token(Token = "0x60036CA")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return HotfixFlag.Stateless;
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		{
		}

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x10")]
		private HotfixFlag flag;
	}
}
