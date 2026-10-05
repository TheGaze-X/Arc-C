using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	public class ChooseGPItem : NormalGPItem
	{
		// Token: 0x06006533 RID: 25907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006533")]
		[Address(RVA = "0x1EE7AE0", Offset = "0x1EE66E0", VA = "0x181EE7AE0")]
		public ChooseGPItem()
		{
		}

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[FieldOffset(Offset = "0x80")]
		public List<ChooseGiftPackageShopOption> options;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[FieldOffset(Offset = "0x88")]
		public string desc;

		// Token: 0x04003236 RID: 12854
		[Token(Token = "0x4003236")]
		[FieldOffset(Offset = "0x90")]
		public string itemDisplayDesc;

		// Token: 0x04003237 RID: 12855
		[Token(Token = "0x4003237")]
		[FieldOffset(Offset = "0x98")]
		public int itemDisplayNum;
	}
}
