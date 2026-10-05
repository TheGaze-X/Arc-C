using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046C0 RID: 18112
	[Token(Token = "0x20046C0")]
	public class RL04TopicModeForegroundPluginContext : RoguelikeTopicModeForegroundPluginContext
	{
		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x0601B77D RID: 112509 RVA: 0x000A54F8 File Offset: 0x000A36F8
		[Token(Token = "0x17004167")]
		public override bool isExploreLock
		{
			[Token(Token = "0x601B77D")]
			[Address(RVA = "0x14CF390", Offset = "0x14CDF90", VA = "0x1814CF390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B77E RID: 112510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B77E")]
		[Address(RVA = "0x14CF160", Offset = "0x14CDD60", VA = "0x1814CF160", Slot = "5")]
		public override void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
		{
		}

		// Token: 0x0601B77F RID: 112511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B77F")]
		[Address(RVA = "0x14CF2A0", Offset = "0x14CDEA0", VA = "0x1814CF2A0")]
		public RL04TopicModeForegroundPluginContext()
		{
		}

		// Token: 0x0601B780 RID: 112512 RVA: 0x000A5510 File Offset: 0x000A3710
		[Token(Token = "0x601B780")]
		[Address(RVA = "0x1430E80", Offset = "0x142FA80", VA = "0x181430E80")]
		private bool <>xLuaBaseProxy_get_isExploreLock()
		{
			return default(bool);
		}

		// Token: 0x0601B781 RID: 112513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B781")]
		[Address(RVA = "0x1430E70", Offset = "0x142FA70", VA = "0x181430E70")]
		private void <>xLuaBaseProxy_RefreshData(RoguelikeTopicModeViewModel P0)
		{
		}

		// Token: 0x04023909 RID: 145673
		[Token(Token = "0x4023909")]
		[FieldOffset(Offset = "0x18")]
		private RL04TopicModeForegroundPluginContext.RL04TopicModeForegroundPluginModel m_viewModel;

		// Token: 0x0402390A RID: 145674
		[Token(Token = "0x402390A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExploreLock;

		// Token: 0x0402390B RID: 145675
		[Token(Token = "0x402390B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402390C RID: 145676
		[Token(Token = "0x402390C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046C1 RID: 18113
		[Token(Token = "0x20046C1")]
		public class RL04TopicModeForegroundPluginModel : IHotfixable
		{
			// Token: 0x0601B782 RID: 112514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B782")]
			[Address(RVA = "0x14CF400", Offset = "0x14CE000", VA = "0x1814CF400")]
			public void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
			{
			}

			// Token: 0x0601B783 RID: 112515 RVA: 0x000A5528 File Offset: 0x000A3728
			[Token(Token = "0x601B783")]
			[Address(RVA = "0x14CF4F0", Offset = "0x14CE0F0", VA = "0x1814CF4F0")]
			private bool _CheckIfExploreLock(RoguelikeTopicModeViewModel topicModeViewModel)
			{
				return default(bool);
			}

			// Token: 0x0601B784 RID: 112516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B784")]
			[Address(RVA = "0x14CF590", Offset = "0x14CE190", VA = "0x1814CF590")]
			public RL04TopicModeForegroundPluginModel()
			{
			}

			// Token: 0x0402390D RID: 145677
			[Token(Token = "0x402390D")]
			[FieldOffset(Offset = "0x10")]
			public bool isExploreLock;

			// Token: 0x0402390E RID: 145678
			[Token(Token = "0x402390E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RefreshData;

			// Token: 0x0402390F RID: 145679
			[Token(Token = "0x402390F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckIfExploreLock;

			// Token: 0x04023910 RID: 145680
			[Token(Token = "0x4023910")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
