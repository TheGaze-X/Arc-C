using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x17000032")]
		internal override bool IsFull
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4F78B60", Offset = "0x4F77760", VA = "0x184F78B60", Slot = "5")]
		internal override int Decode(char[] chars, int startPos, int len)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public IncrementalReadDummyDecoder()
		{
		}
	}
}
