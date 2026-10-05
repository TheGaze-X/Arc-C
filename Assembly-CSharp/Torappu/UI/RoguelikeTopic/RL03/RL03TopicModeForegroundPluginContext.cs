using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045AC RID: 17836
	[Token(Token = "0x20045AC")]
	public class RL03TopicModeForegroundPluginContext : RoguelikeTopicModeForegroundPluginContext
	{
		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0601B248 RID: 111176 RVA: 0x000A47A8 File Offset: 0x000A29A8
		[Token(Token = "0x170040AD")]
		public override bool isExploreLock
		{
			[Token(Token = "0x601B248")]
			[Address(RVA = "0x144DB40", Offset = "0x144C740", VA = "0x18144DB40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B249 RID: 111177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B249")]
		[Address(RVA = "0x144D910", Offset = "0x144C510", VA = "0x18144D910", Slot = "5")]
		public override void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
		{
		}

		// Token: 0x0601B24A RID: 111178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B24A")]
		[Address(RVA = "0x144DA50", Offset = "0x144C650", VA = "0x18144DA50")]
		public RL03TopicModeForegroundPluginContext()
		{
		}

		// Token: 0x0601B24B RID: 111179 RVA: 0x000A47C0 File Offset: 0x000A29C0
		[Token(Token = "0x601B24B")]
		[Address(RVA = "0x1430E80", Offset = "0x142FA80", VA = "0x181430E80")]
		private bool <>xLuaBaseProxy_get_isExploreLock()
		{
			return default(bool);
		}

		// Token: 0x0601B24C RID: 111180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B24C")]
		[Address(RVA = "0x1430E70", Offset = "0x142FA70", VA = "0x181430E70")]
		private void <>xLuaBaseProxy_RefreshData(RoguelikeTopicModeViewModel P0)
		{
		}

		// Token: 0x04022F1D RID: 143133
		[Token(Token = "0x4022F1D")]
		[FieldOffset(Offset = "0x18")]
		private RL03TopicModeForegroundPluginContext.RL03TopicModeForegroundPluginModel m_viewModel;

		// Token: 0x04022F1E RID: 143134
		[Token(Token = "0x4022F1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExploreLock;

		// Token: 0x04022F1F RID: 143135
		[Token(Token = "0x4022F1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04022F20 RID: 143136
		[Token(Token = "0x4022F20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045AD RID: 17837
		[Token(Token = "0x20045AD")]
		public class RL03TopicModeForegroundPluginModel : IHotfixable
		{
			// Token: 0x0601B24D RID: 111181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B24D")]
			[Address(RVA = "0x144DBB0", Offset = "0x144C7B0", VA = "0x18144DBB0")]
			public void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
			{
			}

			// Token: 0x0601B24E RID: 111182 RVA: 0x000A47D8 File Offset: 0x000A29D8
			[Token(Token = "0x601B24E")]
			[Address(RVA = "0x144DCA0", Offset = "0x144C8A0", VA = "0x18144DCA0")]
			private bool _CheckIfExploreLock(RoguelikeTopicModeViewModel topicModeViewModel)
			{
				return default(bool);
			}

			// Token: 0x0601B24F RID: 111183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B24F")]
			[Address(RVA = "0x144DD40", Offset = "0x144C940", VA = "0x18144DD40")]
			public RL03TopicModeForegroundPluginModel()
			{
			}

			// Token: 0x04022F21 RID: 143137
			[Token(Token = "0x4022F21")]
			[FieldOffset(Offset = "0x10")]
			public bool isExploreLock;

			// Token: 0x04022F22 RID: 143138
			[Token(Token = "0x4022F22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RefreshData;

			// Token: 0x04022F23 RID: 143139
			[Token(Token = "0x4022F23")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckIfExploreLock;

			// Token: 0x04022F24 RID: 143140
			[Token(Token = "0x4022F24")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
