using System;
using Il2CppDummyDll;
using Torappu.Scripts.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x02004589 RID: 17801
	[Token(Token = "0x2004589")]
	public class RL05TopicModeForegroundPluginContext : RoguelikeTopicModeForegroundPluginContext
	{
		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x0601B1A7 RID: 111015 RVA: 0x000A4628 File Offset: 0x000A2828
		[Token(Token = "0x17004099")]
		public override bool isExploreLock
		{
			[Token(Token = "0x601B1A7")]
			[Address(RVA = "0x1430F80", Offset = "0x142FB80", VA = "0x181430F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B1A8 RID: 111016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1A8")]
		[Address(RVA = "0x1430DB0", Offset = "0x142F9B0", VA = "0x181430DB0", Slot = "5")]
		public override void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
		{
		}

		// Token: 0x0601B1A9 RID: 111017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1A9")]
		[Address(RVA = "0x1430E90", Offset = "0x142FA90", VA = "0x181430E90")]
		public RL05TopicModeForegroundPluginContext()
		{
		}

		// Token: 0x0601B1AA RID: 111018 RVA: 0x000A4640 File Offset: 0x000A2840
		[Token(Token = "0x601B1AA")]
		[Address(RVA = "0x1430E80", Offset = "0x142FA80", VA = "0x181430E80")]
		private bool <>xLuaBaseProxy_get_isExploreLock()
		{
			return default(bool);
		}

		// Token: 0x0601B1AB RID: 111019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1AB")]
		[Address(RVA = "0x1430E70", Offset = "0x142FA70", VA = "0x181430E70")]
		private void <>xLuaBaseProxy_RefreshData(RoguelikeTopicModeViewModel P0)
		{
		}

		// Token: 0x04022DE1 RID: 142817
		[Token(Token = "0x4022DE1")]
		[FieldOffset(Offset = "0x18")]
		private readonly RL05TopicModeForegroundPluginContext.RL05TopicModeForegroundPluginModel m_viewModel;

		// Token: 0x04022DE2 RID: 142818
		[Token(Token = "0x4022DE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExploreLock;

		// Token: 0x04022DE3 RID: 142819
		[Token(Token = "0x4022DE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04022DE4 RID: 142820
		[Token(Token = "0x4022DE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200458A RID: 17802
		[Token(Token = "0x200458A")]
		private class RL05TopicModeForegroundPluginModel : IHotfixable
		{
			// Token: 0x0601B1AC RID: 111020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1AC")]
			[Address(RVA = "0x1430FF0", Offset = "0x142FBF0", VA = "0x181430FF0")]
			public void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
			{
			}

			// Token: 0x0601B1AD RID: 111021 RVA: 0x000A4658 File Offset: 0x000A2858
			[Token(Token = "0x601B1AD")]
			[Address(RVA = "0x1431070", Offset = "0x142FC70", VA = "0x181431070")]
			private bool _CheckIfExploreLock(RoguelikeTopicModeViewModel topicModeViewModel)
			{
				return default(bool);
			}

			// Token: 0x0601B1AE RID: 111022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1AE")]
			[Address(RVA = "0x1431250", Offset = "0x142FE50", VA = "0x181431250")]
			public RL05TopicModeForegroundPluginModel()
			{
			}

			// Token: 0x04022DE5 RID: 142821
			[Token(Token = "0x4022DE5")]
			[FieldOffset(Offset = "0x10")]
			public bool isExploreLock;

			// Token: 0x04022DE6 RID: 142822
			[Token(Token = "0x4022DE6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RefreshData;

			// Token: 0x04022DE7 RID: 142823
			[Token(Token = "0x4022DE7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckIfExploreLock;

			// Token: 0x04022DE8 RID: 142824
			[Token(Token = "0x4022DE8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
