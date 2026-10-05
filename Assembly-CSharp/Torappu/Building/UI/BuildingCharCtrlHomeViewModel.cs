using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF3 RID: 6899
	[Token(Token = "0x2001AF3")]
	public class BuildingCharCtrlHomeViewModel : IHotfixable
	{
		// Token: 0x0600AE56 RID: 44630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE56")]
		[Address(RVA = "0x328D0D0", Offset = "0x328BCD0", VA = "0x18328D0D0")]
		public void LoadData()
		{
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE57")]
		[Address(RVA = "0x328D400", Offset = "0x328C000", VA = "0x18328D400")]
		public BuildingCharCtrlHomeViewModel()
		{
		}

		// Token: 0x0400A6E8 RID: 42728
		[Token(Token = "0x400A6E8")]
		public const string EMOJI_ACTION_ID = "action";

		// Token: 0x0400A6E9 RID: 42729
		[Token(Token = "0x400A6E9")]
		[FieldOffset(Offset = "0x10")]
		public bool isShowUI;

		// Token: 0x0400A6EA RID: 42730
		[Token(Token = "0x400A6EA")]
		[FieldOffset(Offset = "0x11")]
		public bool interactable;

		// Token: 0x0400A6EB RID: 42731
		[Token(Token = "0x400A6EB")]
		[FieldOffset(Offset = "0x12")]
		public bool isInteracting;

		// Token: 0x0400A6EC RID: 42732
		[Token(Token = "0x400A6EC")]
		[FieldOffset(Offset = "0x13")]
		public bool canGoUpstairs;

		// Token: 0x0400A6ED RID: 42733
		[Token(Token = "0x400A6ED")]
		[FieldOffset(Offset = "0x14")]
		public bool inElevatorRoom;

		// Token: 0x0400A6EE RID: 42734
		[Token(Token = "0x400A6EE")]
		[FieldOffset(Offset = "0x15")]
		public bool canGoDownstairs;

		// Token: 0x0400A6EF RID: 42735
		[Token(Token = "0x400A6EF")]
		[FieldOffset(Offset = "0x16")]
		public bool isUpDownstairs;

		// Token: 0x0400A6F0 RID: 42736
		[Token(Token = "0x400A6F0")]
		[FieldOffset(Offset = "0x17")]
		public bool isGoingUp;

		// Token: 0x0400A6F1 RID: 42737
		[Token(Token = "0x400A6F1")]
		[FieldOffset(Offset = "0x18")]
		public bool isGoingDown;

		// Token: 0x0400A6F2 RID: 42738
		[Token(Token = "0x400A6F2")]
		[FieldOffset(Offset = "0x19")]
		public bool showEmoji;

		// Token: 0x0400A6F3 RID: 42739
		[Token(Token = "0x400A6F3")]
		[FieldOffset(Offset = "0x20")]
		public List<string> emojiList;

		// Token: 0x0400A6F4 RID: 42740
		[Token(Token = "0x400A6F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400A6F5 RID: 42741
		[Token(Token = "0x400A6F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
