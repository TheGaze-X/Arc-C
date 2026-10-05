using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A82 RID: 23170
	[Token(Token = "0x2005A82")]
	public class DetailGPViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B56 RID: 138070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B56")]
		[Address(RVA = "0x1C18770", Offset = "0x1C17370", VA = "0x181C18770")]
		public DetailGPViewModel()
		{
		}

		// Token: 0x0402E178 RID: 188792
		[Token(Token = "0x402E178")]
		[FieldOffset(Offset = "0x70")]
		public ItemBundle[] itemList;

		// Token: 0x0402E179 RID: 188793
		[Token(Token = "0x402E179")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, SpecialItemInfo> specialItemInfos;

		// Token: 0x0402E17A RID: 188794
		[Token(Token = "0x402E17A")]
		[FieldOffset(Offset = "0x80")]
		public bool useGpTicket;

		// Token: 0x0402E17B RID: 188795
		[Token(Token = "0x402E17B")]
		[FieldOffset(Offset = "0x88")]
		public string gpTicketId;

		// Token: 0x0402E17C RID: 188796
		[Token(Token = "0x402E17C")]
		[FieldOffset(Offset = "0x90")]
		public List<PackageImgDisplayData> imgDisplayDataList;

		// Token: 0x0402E17D RID: 188797
		[Token(Token = "0x402E17D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
