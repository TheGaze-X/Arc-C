using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x020045F8 RID: 17912
	[Token(Token = "0x20045F8")]
	public class RL02TopicModeForegroundPluginContext : RoguelikeTopicModeForegroundPluginContext
	{
		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0601B3AD RID: 111533 RVA: 0x000A4BB0 File Offset: 0x000A2DB0
		[Token(Token = "0x170040F6")]
		public override bool isExploreLock
		{
			[Token(Token = "0x601B3AD")]
			[Address(RVA = "0x1465B50", Offset = "0x1464750", VA = "0x181465B50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B3AE RID: 111534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3AE")]
		[Address(RVA = "0x1465920", Offset = "0x1464520", VA = "0x181465920", Slot = "5")]
		public override void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
		{
		}

		// Token: 0x0601B3AF RID: 111535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3AF")]
		[Address(RVA = "0x1465A60", Offset = "0x1464660", VA = "0x181465A60")]
		public RL02TopicModeForegroundPluginContext()
		{
		}

		// Token: 0x0601B3B0 RID: 111536 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
		[Token(Token = "0x601B3B0")]
		[Address(RVA = "0x1430E80", Offset = "0x142FA80", VA = "0x181430E80")]
		private bool <>xLuaBaseProxy_get_isExploreLock()
		{
			return default(bool);
		}

		// Token: 0x0601B3B1 RID: 111537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3B1")]
		[Address(RVA = "0x1430E70", Offset = "0x142FA70", VA = "0x181430E70")]
		private void <>xLuaBaseProxy_RefreshData(RoguelikeTopicModeViewModel P0)
		{
		}

		// Token: 0x040231D4 RID: 143828
		[Token(Token = "0x40231D4")]
		[FieldOffset(Offset = "0x18")]
		private RL02TopicModeForegroundPluginContext.RL02TopicModeForegroundPluginModel m_viewModel;

		// Token: 0x040231D5 RID: 143829
		[Token(Token = "0x40231D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExploreLock;

		// Token: 0x040231D6 RID: 143830
		[Token(Token = "0x40231D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040231D7 RID: 143831
		[Token(Token = "0x40231D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045F9 RID: 17913
		[Token(Token = "0x20045F9")]
		public class RL02TopicModeForegroundPluginModel : IHotfixable
		{
			// Token: 0x0601B3B2 RID: 111538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3B2")]
			[Address(RVA = "0x1465BC0", Offset = "0x14647C0", VA = "0x181465BC0")]
			public void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
			{
			}

			// Token: 0x0601B3B3 RID: 111539 RVA: 0x000A4BE0 File Offset: 0x000A2DE0
			[Token(Token = "0x601B3B3")]
			[Address(RVA = "0x1465CB0", Offset = "0x14648B0", VA = "0x181465CB0")]
			private bool _CheckIfExploreLock(RoguelikeTopicModeViewModel topicModeViewModel)
			{
				return default(bool);
			}

			// Token: 0x0601B3B4 RID: 111540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B3B4")]
			[Address(RVA = "0x1465D50", Offset = "0x1464950", VA = "0x181465D50")]
			public RL02TopicModeForegroundPluginModel()
			{
			}

			// Token: 0x040231D8 RID: 143832
			[Token(Token = "0x40231D8")]
			[FieldOffset(Offset = "0x10")]
			public bool isExploreLock;

			// Token: 0x040231D9 RID: 143833
			[Token(Token = "0x40231D9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RefreshData;

			// Token: 0x040231DA RID: 143834
			[Token(Token = "0x40231DA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckIfExploreLock;

			// Token: 0x040231DB RID: 143835
			[Token(Token = "0x40231DB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
