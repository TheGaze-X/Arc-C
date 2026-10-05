using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E4 RID: 29924
	[Token(Token = "0x20074E4")]
	public class RhineArcViewModel
	{
		// Token: 0x0602A2F4 RID: 172788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2F4")]
		[Address(RVA = "0x25D8C90", Offset = "0x25D7890", VA = "0x1825D8C90")]
		public RhineArcViewModel()
		{
		}

		// Token: 0x0403C9B8 RID: 248248
		[Token(Token = "0x403C9B8")]
		public const float LENGTH_MULTI_PARAM = 1f;

		// Token: 0x0403C9B9 RID: 248249
		[Token(Token = "0x403C9B9")]
		[FieldOffset(Offset = "0x10")]
		public int contentFocusX;

		// Token: 0x0403C9BA RID: 248250
		[Token(Token = "0x403C9BA")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, RhineArcViewModel.Group> groupDict;

		// Token: 0x0403C9BB RID: 248251
		[Token(Token = "0x403C9BB")]
		[FieldOffset(Offset = "0x20")]
		public int maxUnAvailGroupSize;

		// Token: 0x0403C9BC RID: 248252
		[Token(Token = "0x403C9BC")]
		[FieldOffset(Offset = "0x24")]
		public int maxAvailGroupSize;

		// Token: 0x0403C9BD RID: 248253
		[Token(Token = "0x403C9BD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<Act25SideData.Act25SideArchiveItemType, bool> isArchiveItemHaveAvail;

		// Token: 0x020074E5 RID: 29925
		[Token(Token = "0x20074E5")]
		public class Group
		{
			// Token: 0x0602A2F5 RID: 172789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2F5")]
			[Address(RVA = "0x25D47E0", Offset = "0x25D33E0", VA = "0x1825D47E0")]
			public Group()
			{
			}

			// Token: 0x0403C9BE RID: 248254
			[Token(Token = "0x403C9BE")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0403C9BF RID: 248255
			[Token(Token = "0x403C9BF")]
			[FieldOffset(Offset = "0x18")]
			public string groupName;

			// Token: 0x0403C9C0 RID: 248256
			[Token(Token = "0x403C9C0")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, RhineArcViewModel.Item> items;

			// Token: 0x0403C9C1 RID: 248257
			[Token(Token = "0x403C9C1")]
			[FieldOffset(Offset = "0x28")]
			public int maxLine;

			// Token: 0x0403C9C2 RID: 248258
			[Token(Token = "0x403C9C2")]
			[FieldOffset(Offset = "0x2C")]
			public int minUnAvailLine;

			// Token: 0x0403C9C3 RID: 248259
			[Token(Token = "0x403C9C3")]
			[FieldOffset(Offset = "0x30")]
			public int maxAvailLine;

			// Token: 0x0403C9C4 RID: 248260
			[Token(Token = "0x403C9C4")]
			[FieldOffset(Offset = "0x34")]
			public int percent;

			// Token: 0x0403C9C5 RID: 248261
			[Token(Token = "0x403C9C5")]
			[FieldOffset(Offset = "0x38")]
			public string firstLockItemId;

			// Token: 0x0403C9C6 RID: 248262
			[Token(Token = "0x403C9C6")]
			[FieldOffset(Offset = "0x40")]
			public bool isAllUnlock;

			// Token: 0x0403C9C7 RID: 248263
			[Token(Token = "0x403C9C7")]
			[FieldOffset(Offset = "0x41")]
			public bool isAreaUnlock;
		}

		// Token: 0x020074E6 RID: 29926
		[Token(Token = "0x20074E6")]
		public class Item
		{
			// Token: 0x0602A2F6 RID: 172790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A2F6")]
			[Address(RVA = "0x25D48A0", Offset = "0x25D34A0", VA = "0x1825D48A0")]
			public Item()
			{
			}

			// Token: 0x0403C9C8 RID: 248264
			[Token(Token = "0x403C9C8")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0403C9C9 RID: 248265
			[Token(Token = "0x403C9C9")]
			[FieldOffset(Offset = "0x18")]
			public Act25SideData.Act25SideArchiveItemType type;

			// Token: 0x0403C9CA RID: 248266
			[Token(Token = "0x403C9CA")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x0403C9CB RID: 248267
			[Token(Token = "0x403C9CB")]
			[FieldOffset(Offset = "0x28")]
			public string numberId;

			// Token: 0x0403C9CC RID: 248268
			[Token(Token = "0x403C9CC")]
			[FieldOffset(Offset = "0x30")]
			public string iconId;

			// Token: 0x0403C9CD RID: 248269
			[Token(Token = "0x403C9CD")]
			[FieldOffset(Offset = "0x38")]
			public int pos;

			// Token: 0x0403C9CE RID: 248270
			[Token(Token = "0x403C9CE")]
			[FieldOffset(Offset = "0x3C")]
			public bool isHaveDot;

			// Token: 0x0403C9CF RID: 248271
			[Token(Token = "0x403C9CF")]
			[FieldOffset(Offset = "0x3D")]
			public bool isAvail;

			// Token: 0x0403C9D0 RID: 248272
			[Token(Token = "0x403C9D0")]
			[FieldOffset(Offset = "0x3E")]
			public bool isNew;

			// Token: 0x0403C9D1 RID: 248273
			[Token(Token = "0x403C9D1")]
			[FieldOffset(Offset = "0x40")]
			public string keyToastText;
		}
	}
}
