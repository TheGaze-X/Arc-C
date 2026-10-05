using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x02004671 RID: 18033
	[Token(Token = "0x2004671")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ModeTabIDs
	{
		// Token: 0x0601B610 RID: 112144 RVA: 0x000A4F88 File Offset: 0x000A3188
		[Token(Token = "0x601B610")]
		[Address(RVA = "0x14AB960", Offset = "0x14AA560", VA = "0x1814AB960")]
		public static ModeTabIDs.SerializeTabID GetTabID(RoguelikeTopicModeViewType modeView)
		{
			return ModeTabIDs.SerializeTabID.NONE;
		}

		// Token: 0x0601B611 RID: 112145 RVA: 0x000A4FA0 File Offset: 0x000A31A0
		[Token(Token = "0x601B611")]
		[Address(RVA = "0x14AB840", Offset = "0x14AA440", VA = "0x1814AB840")]
		public static RoguelikeTopicModeViewType GetModeFromTab(ModeTabIDs.SerializeTabID tabID)
		{
			return RoguelikeTopicModeViewType.NONE;
		}

		// Token: 0x0601B612 RID: 112146 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		[Token(Token = "0x601B612")]
		[Address(RVA = "0x14AB8D0", Offset = "0x14AA4D0", VA = "0x1814AB8D0")]
		public static RoguelikeTopicMode GetModeTypeById(ModeTabIDs.SerializeTabID tabID)
		{
			return RoguelikeTopicMode.NONE;
		}

		// Token: 0x04023621 RID: 144929
		[Token(Token = "0x4023621")]
		private const string TAB_NORMAL_ID = "normal";

		// Token: 0x04023622 RID: 144930
		[Token(Token = "0x4023622")]
		private const string TAB_MONTH_TEAM_ID = "month";

		// Token: 0x04023623 RID: 144931
		[Token(Token = "0x4023623")]
		private const string TAB_CHALLENGE_ID = "challenge";

		// Token: 0x04023624 RID: 144932
		[Token(Token = "0x4023624")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTabID;

		// Token: 0x04023625 RID: 144933
		[Token(Token = "0x4023625")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetModeFromTab;

		// Token: 0x04023626 RID: 144934
		[Token(Token = "0x4023626")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetModeTypeById;

		// Token: 0x02004672 RID: 18034
		[Token(Token = "0x2004672")]
		public enum SerializeTabID
		{
			// Token: 0x04023628 RID: 144936
			[Token(Token = "0x4023628")]
			NONE,
			// Token: 0x04023629 RID: 144937
			[Token(Token = "0x4023629")]
			NORMAL,
			// Token: 0x0402362A RID: 144938
			[Token(Token = "0x402362A")]
			MONTH,
			// Token: 0x0402362B RID: 144939
			[Token(Token = "0x402362B")]
			CHALLENGE
		}
	}
}
