using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075FA RID: 30202
	[Token(Token = "0x20075FA")]
	public class Act24sideMissionActItemViewModel : IHotfixable
	{
		// Token: 0x0602A857 RID: 174167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A857")]
		[Address(RVA = "0x2623A30", Offset = "0x2622630", VA = "0x182623A30")]
		public Act24sideMissionActItemViewModel(UIItemViewModel itemViewModel, bool showCount = false, bool canClick = false)
		{
		}

		// Token: 0x0403D357 RID: 250711
		[Token(Token = "0x403D357")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0403D358 RID: 250712
		[Token(Token = "0x403D358")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x0403D359 RID: 250713
		[Token(Token = "0x403D359")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0403D35A RID: 250714
		[Token(Token = "0x403D35A")]
		[FieldOffset(Offset = "0x28")]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403D35B RID: 250715
		[Token(Token = "0x403D35B")]
		[FieldOffset(Offset = "0x30")]
		public bool showCount;

		// Token: 0x0403D35C RID: 250716
		[Token(Token = "0x403D35C")]
		[FieldOffset(Offset = "0x31")]
		public bool canClick;

		// Token: 0x0403D35D RID: 250717
		[Token(Token = "0x403D35D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
