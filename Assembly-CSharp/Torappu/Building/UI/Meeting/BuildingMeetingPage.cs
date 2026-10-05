using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D06 RID: 7430
	[Token(Token = "0x2001D06")]
	public class BuildingMeetingPage : BuildingCommonPage
	{
		// Token: 0x0600B771 RID: 46961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B771")]
		[Address(RVA = "0x3339C10", Offset = "0x3338810", VA = "0x183339C10", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B772")]
		[Address(RVA = "0x3339C80", Offset = "0x3338880", VA = "0x183339C80")]
		public BuildingMeetingPage()
		{
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B773")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0400B591 RID: 46481
		[Token(Token = "0x400B591")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0400B592 RID: 46482
		[Token(Token = "0x400B592")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D07 RID: 7431
		[Token(Token = "0x2001D07")]
		public class Argument
		{
			// Token: 0x0600B774 RID: 46964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B774")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x0400B593 RID: 46483
			[Token(Token = "0x400B593")]
			[FieldOffset(Offset = "0x10")]
			public IMeetingSession session;

			// Token: 0x0400B594 RID: 46484
			[Token(Token = "0x400B594")]
			[FieldOffset(Offset = "0x18")]
			public string title;

			// Token: 0x0400B595 RID: 46485
			[Token(Token = "0x400B595")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x0400B596 RID: 46486
			[Token(Token = "0x400B596")]
			[FieldOffset(Offset = "0x24")]
			public int maxLevel;
		}
	}
}
