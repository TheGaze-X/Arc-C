using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E96 RID: 20118
	[Token(Token = "0x2004E96")]
	public class FifthAnnivExploreCarouselViewModel : IHotfixable
	{
		// Token: 0x0601E03D RID: 122941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E03D")]
		[Address(RVA = "0x17B3EF0", Offset = "0x17B2AF0", VA = "0x1817B3EF0")]
		public List<FifthAnnivExploreCarouselViewModel.Item> InstViewModel()
		{
			return null;
		}

		// Token: 0x0601E03E RID: 122942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E03E")]
		[Address(RVA = "0x17B42B0", Offset = "0x17B2EB0", VA = "0x1817B42B0")]
		public FifthAnnivExploreCarouselViewModel()
		{
		}

		// Token: 0x04027E5E RID: 163422
		[Token(Token = "0x4027E5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InstViewModel;

		// Token: 0x04027E5F RID: 163423
		[Token(Token = "0x4027E5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E97 RID: 20119
		[Token(Token = "0x2004E97")]
		public class Item
		{
			// Token: 0x0601E03F RID: 122943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E03F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x04027E60 RID: 163424
			[Token(Token = "0x4027E60")]
			[FieldOffset(Offset = "0x10")]
			public bool isNew;

			// Token: 0x04027E61 RID: 163425
			[Token(Token = "0x4027E61")]
			[FieldOffset(Offset = "0x18")]
			public string text;
		}
	}
}
