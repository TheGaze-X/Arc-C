using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B3 RID: 22195
	[Token(Token = "0x20056B3")]
	public class RL04FocusStatePlugin : RoguelikeFocusStatePlugin
	{
		// Token: 0x060208E6 RID: 133350 RVA: 0x000B6658 File Offset: 0x000B4858
		[Token(Token = "0x60208E6")]
		[Address(RVA = "0x1AA7F30", Offset = "0x1AA6B30", VA = "0x181AA7F30", Slot = "5")]
		public override bool PassRollNodeItemChecker(string topicId, RoguelikeTopicDetail topicData, RoguelikeDungeonNode focusNode)
		{
			return default(bool);
		}

		// Token: 0x17004C47 RID: 19527
		// (get) Token: 0x060208E7 RID: 133351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C47")]
		public override string noCountToast
		{
			[Token(Token = "0x60208E7")]
			[Address(RVA = "0x1AA8100", Offset = "0x1AA6D00", VA = "0x181AA8100", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x060208E8 RID: 133352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C48")]
		public override string rollSucToast
		{
			[Token(Token = "0x60208E8")]
			[Address(RVA = "0x1AA8180", Offset = "0x1AA6D80", VA = "0x181AA8180", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060208E9 RID: 133353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208E9")]
		[Address(RVA = "0x1AA80A0", Offset = "0x1AA6CA0", VA = "0x181AA80A0")]
		public RL04FocusStatePlugin()
		{
		}

		// Token: 0x060208EA RID: 133354 RVA: 0x000B6670 File Offset: 0x000B4870
		[Token(Token = "0x60208EA")]
		[Address(RVA = "0x1A61000", Offset = "0x1A5FC00", VA = "0x181A61000")]
		private bool <>xLuaBaseProxy_PassRollNodeItemChecker(string P0, RoguelikeTopicDetail P1, RoguelikeDungeonNode P2)
		{
			return default(bool);
		}

		// Token: 0x060208EB RID: 133355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208EB")]
		[Address(RVA = "0x1AA8090", Offset = "0x1AA6C90", VA = "0x181AA8090")]
		private string <>xLuaBaseProxy_get_noCountToast()
		{
			return null;
		}

		// Token: 0x060208EC RID: 133356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208EC")]
		[Address(RVA = "0x1A61020", Offset = "0x1A5FC20", VA = "0x181A61020")]
		private string <>xLuaBaseProxy_get_rollSucToast()
		{
			return null;
		}

		// Token: 0x0402C1B3 RID: 180659
		[Token(Token = "0x402C1B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PassRollNodeItemChecker;

		// Token: 0x0402C1B4 RID: 180660
		[Token(Token = "0x402C1B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_noCountToast;

		// Token: 0x0402C1B5 RID: 180661
		[Token(Token = "0x402C1B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rollSucToast;

		// Token: 0x0402C1B6 RID: 180662
		[Token(Token = "0x402C1B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
