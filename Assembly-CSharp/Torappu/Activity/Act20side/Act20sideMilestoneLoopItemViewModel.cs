using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A0 RID: 30368
	[Token(Token = "0x20076A0")]
	public class Act20sideMilestoneLoopItemViewModel : IHotfixable
	{
		// Token: 0x0602AB42 RID: 174914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB42")]
		[Address(RVA = "0x2676F40", Offset = "0x2675B40", VA = "0x182676F40")]
		public Act20sideMilestoneLoopItemViewModel()
		{
		}

		// Token: 0x0403D89D RID: 252061
		[Token(Token = "0x403D89D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Act20sideMilestoneLoopItemViewModel.Item> itemList;

		// Token: 0x0403D89E RID: 252062
		[Token(Token = "0x403D89E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076A1 RID: 30369
		[Token(Token = "0x20076A1")]
		public class Item
		{
			// Token: 0x0602AB43 RID: 174915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB43")]
			[Address(RVA = "0x267CFC0", Offset = "0x267BBC0", VA = "0x18267CFC0")]
			public Item(bool hasItem = false, [Optional] string itemId)
			{
			}

			// Token: 0x0403D89F RID: 252063
			[Token(Token = "0x403D89F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403D8A0 RID: 252064
			[Token(Token = "0x403D8A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool hasItem;
		}
	}
}
