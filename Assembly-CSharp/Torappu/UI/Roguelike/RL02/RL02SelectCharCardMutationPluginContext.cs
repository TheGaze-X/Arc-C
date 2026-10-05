using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200579E RID: 22430
	[Token(Token = "0x200579E")]
	public class RL02SelectCharCardMutationPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x06020CED RID: 134381 RVA: 0x000B7630 File Offset: 0x000B5830
		[Token(Token = "0x6020CED")]
		[Address(RVA = "0x1B26AE0", Offset = "0x1B256E0", VA = "0x181B26AE0")]
		private RoguelikeGameCharBuffType _GetMutationType(int troopInstId)
		{
			return RoguelikeGameCharBuffType.NONE;
		}

		// Token: 0x06020CEE RID: 134382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CEE")]
		[Address(RVA = "0x1B26890", Offset = "0x1B25490", VA = "0x181B26890", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020CEF RID: 134383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CEF")]
		[Address(RVA = "0x1B26790", Offset = "0x1B25390", VA = "0x181B26790", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x06020CF0 RID: 134384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CF0")]
		[Address(RVA = "0x1B26690", Offset = "0x1B25290", VA = "0x181B26690", Slot = "18")]
		public override RoguelikeMenuButtonPluginBase GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig showConfig)
		{
			return null;
		}

		// Token: 0x06020CF1 RID: 134385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CF1")]
		[Address(RVA = "0x1B26B90", Offset = "0x1B25790", VA = "0x181B26B90")]
		public RL02SelectCharCardMutationPluginContext()
		{
		}

		// Token: 0x06020CF2 RID: 134386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CF2")]
		[Address(RVA = "0x1A71000", Offset = "0x1A6FC00", VA = "0x181A71000")]
		private RoguelikeMenuButtonPluginBase <>xLuaBaseProxy_GetCustomPendingEventSelectMenuPlugin(RoguelikeCharSelectStateBean.ShowConfig P0)
		{
			return null;
		}

		// Token: 0x0402C94C RID: 182604
		[Token(Token = "0x402C94C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeMenuButtonPluginBase _purifyMenuPlugin;

		// Token: 0x0402C94D RID: 182605
		[Token(Token = "0x402C94D")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntStructDictionary<int, RoguelikeGameCharBuffType> m_charBuffDict;

		// Token: 0x0402C94E RID: 182606
		[Token(Token = "0x402C94E")]
		[FieldOffset(Offset = "0x28")]
		private string m_topicId;

		// Token: 0x0402C94F RID: 182607
		[Token(Token = "0x402C94F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetMutationType;

		// Token: 0x0402C950 RID: 182608
		[Token(Token = "0x402C950")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C951 RID: 182609
		[Token(Token = "0x402C951")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402C952 RID: 182610
		[Token(Token = "0x402C952")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCustomPendingEventSelectMenuPlugin;

		// Token: 0x0402C953 RID: 182611
		[Token(Token = "0x402C953")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200579F RID: 22431
		[Token(Token = "0x200579F")]
		public class RL02SelectCharCardViewMutationPlugin : RoguelikeCharCardPlugin<RL02SelectCharCardMutationPluginContext>
		{
			// Token: 0x06020CF3 RID: 134387 RVA: 0x000B7648 File Offset: 0x000B5848
			[Token(Token = "0x6020CF3")]
			[Address(RVA = "0x1B26DA0", Offset = "0x1B259A0", VA = "0x181B26DA0", Slot = "14")]
			public override bool OverrideRaritySprite(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Sprite sprite)
			{
				return default(bool);
			}

			// Token: 0x06020CF4 RID: 134388 RVA: 0x000B7660 File Offset: 0x000B5860
			[Token(Token = "0x6020CF4")]
			[Address(RVA = "0x1B26C40", Offset = "0x1B25840", VA = "0x181B26C40", Slot = "15")]
			public override bool OverrideCharNameColor(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out Color color)
			{
				return default(bool);
			}

			// Token: 0x06020CF5 RID: 134389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CF5")]
			[Address(RVA = "0x1B26F60", Offset = "0x1B25B60", VA = "0x181B26F60")]
			public RL02SelectCharCardViewMutationPlugin()
			{
			}

			// Token: 0x0402C954 RID: 182612
			[Token(Token = "0x402C954")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Color MUTATION_CHAR_NAME_COLOR;

			// Token: 0x0402C955 RID: 182613
			[Token(Token = "0x402C955")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Color EVOLUTION_CHAR_NAME_COLOR;

			// Token: 0x0402C956 RID: 182614
			[Token(Token = "0x402C956")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideRaritySprite;

			// Token: 0x0402C957 RID: 182615
			[Token(Token = "0x402C957")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideCharNameColor;

			// Token: 0x0402C958 RID: 182616
			[Token(Token = "0x402C958")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
