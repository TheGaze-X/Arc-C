using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005473 RID: 21619
	[Token(Token = "0x2005473")]
	public class RoguelikeCharCardSpPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0601FD17 RID: 130327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD17")]
		[Address(RVA = "0x19E9DD0", Offset = "0x19E89D0", VA = "0x1819E9DD0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601FD18 RID: 130328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD18")]
		[Address(RVA = "0x19E9CF0", Offset = "0x19E88F0", VA = "0x1819E9CF0", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601FD19 RID: 130329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD19")]
		[Address(RVA = "0x19E9E30", Offset = "0x19E8A30", VA = "0x1819E9E30")]
		public RoguelikeCharCardSpPluginContext()
		{
		}

		// Token: 0x0402ADEE RID: 175598
		[Token(Token = "0x402ADEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSelectCharSpConflictPanel _spConflictPrefab;

		// Token: 0x0402ADEF RID: 175599
		[Token(Token = "0x402ADEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402ADF0 RID: 175600
		[Token(Token = "0x402ADF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402ADF1 RID: 175601
		[Token(Token = "0x402ADF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005474 RID: 21620
		[Token(Token = "0x2005474")]
		public class RoguelikeCharCardSpViewPlugin : RoguelikeCharCardPlugin<RoguelikeCharCardSpPluginContext>
		{
			// Token: 0x0601FD1A RID: 130330 RVA: 0x000B3580 File Offset: 0x000B1780
			[Token(Token = "0x601FD1A")]
			[Address(RVA = "0x19E9ED0", Offset = "0x19E8AD0", VA = "0x1819E9ED0", Slot = "16")]
			public override bool OverrideConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out RoguelikeSelectCharConflictPanel prefab)
			{
				return default(bool);
			}

			// Token: 0x0601FD1B RID: 130331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD1B")]
			[Address(RVA = "0x19E9FC0", Offset = "0x19E8BC0", VA = "0x1819E9FC0", Slot = "18")]
			public override void RenderConflictPanel(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, RoguelikeSelectCharConflictPanel panel)
			{
			}

			// Token: 0x0601FD1C RID: 130332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD1C")]
			[Address(RVA = "0x19EA1A0", Offset = "0x19E8DA0", VA = "0x1819EA1A0")]
			public RoguelikeCharCardSpViewPlugin()
			{
			}

			// Token: 0x0402ADF2 RID: 175602
			[Token(Token = "0x402ADF2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideConflictPanel;

			// Token: 0x0402ADF3 RID: 175603
			[Token(Token = "0x402ADF3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderConflictPanel;

			// Token: 0x0402ADF4 RID: 175604
			[Token(Token = "0x402ADF4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
