using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005470 RID: 21616
	[Token(Token = "0x2005470")]
	public class RoguelikeCharCardPopulationPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x0601FD0A RID: 130314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A9F")]
		public override List<RoguelikeCharCardComparer> additionalComparers
		{
			[Token(Token = "0x601FD0A")]
			[Address(RVA = "0x19E99D0", Offset = "0x19E85D0", VA = "0x1819E99D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FD0B RID: 130315 RVA: 0x000B3508 File Offset: 0x000B1708
		[Token(Token = "0x601FD0B")]
		[Address(RVA = "0x19E97F0", Offset = "0x19E83F0", VA = "0x1819E97F0")]
		private int _CalculateSelectedPopulation(RoguelikeSelectCharViewModel groupModel)
		{
			return 0;
		}

		// Token: 0x0601FD0C RID: 130316 RVA: 0x000B3520 File Offset: 0x000B1720
		[Token(Token = "0x601FD0C")]
		[Address(RVA = "0x19E93E0", Offset = "0x19E7FE0", VA = "0x1819E93E0", Slot = "17")]
		public override bool CheckCharSelectValid(RoguelikeSelectCharViewModel groupModel, RoguelikeCharCardViewModel charModel, out string invalidToast)
		{
			return default(bool);
		}

		// Token: 0x0601FD0D RID: 130317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD0D")]
		[Address(RVA = "0x19E9710", Offset = "0x19E8310", VA = "0x1819E9710", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601FD0E RID: 130318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD0E")]
		[Address(RVA = "0x19E9630", Offset = "0x19E8230", VA = "0x1819E9630", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0601FD0F RID: 130319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD0F")]
		[Address(RVA = "0x19E9930", Offset = "0x19E8530", VA = "0x1819E9930")]
		public RoguelikeCharCardPopulationPluginContext()
		{
		}

		// Token: 0x0601FD10 RID: 130320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FD10")]
		[Address(RVA = "0x19E7FF0", Offset = "0x19E6BF0", VA = "0x1819E7FF0")]
		private List<RoguelikeCharCardComparer> <>xLuaBaseProxy_get_additionalComparers()
		{
			return null;
		}

		// Token: 0x0601FD11 RID: 130321 RVA: 0x000B3538 File Offset: 0x000B1738
		[Token(Token = "0x601FD11")]
		[Address(RVA = "0x19E7FE0", Offset = "0x19E6BE0", VA = "0x1819E7FE0")]
		private bool <>xLuaBaseProxy_CheckCharSelectValid(RoguelikeSelectCharViewModel P0, RoguelikeCharCardViewModel P1, out string P2)
		{
			return default(bool);
		}

		// Token: 0x0402ADE2 RID: 175586
		[Token(Token = "0x402ADE2")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402ADE3 RID: 175587
		[Token(Token = "0x402ADE3")]
		[FieldOffset(Offset = "0x20")]
		private int m_currPopulation;

		// Token: 0x0402ADE4 RID: 175588
		[Token(Token = "0x402ADE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_additionalComparers;

		// Token: 0x0402ADE5 RID: 175589
		[Token(Token = "0x402ADE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalculateSelectedPopulation;

		// Token: 0x0402ADE6 RID: 175590
		[Token(Token = "0x402ADE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckCharSelectValid;

		// Token: 0x0402ADE7 RID: 175591
		[Token(Token = "0x402ADE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402ADE8 RID: 175592
		[Token(Token = "0x402ADE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402ADE9 RID: 175593
		[Token(Token = "0x402ADE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005471 RID: 21617
		[Token(Token = "0x2005471")]
		public class RoguelikeCharCardPopulationViewPlugin : RoguelikeCharCardPlugin<RoguelikeCharCardPopulationPluginContext>
		{
			// Token: 0x0601FD12 RID: 130322 RVA: 0x000B3550 File Offset: 0x000B1750
			[Token(Token = "0x601FD12")]
			[Address(RVA = "0x19E9BC0", Offset = "0x19E87C0", VA = "0x1819E9BC0", Slot = "17")]
			public override bool OverrideValid(RoguelikeCharCardViewModel viewModel, RoguelikeCharSelectStateBean.ShowConfig showConfig, bool isSelect, int selectIndex, out bool valid)
			{
				return default(bool);
			}

			// Token: 0x0601FD13 RID: 130323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FD13")]
			[Address(RVA = "0x19E9C80", Offset = "0x19E8880", VA = "0x1819E9C80")]
			public RoguelikeCharCardPopulationViewPlugin()
			{
			}

			// Token: 0x0402ADEA RID: 175594
			[Token(Token = "0x402ADEA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OverrideValid;

			// Token: 0x0402ADEB RID: 175595
			[Token(Token = "0x402ADEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
