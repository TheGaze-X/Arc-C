using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200560F RID: 22031
	[Token(Token = "0x200560F")]
	public class RL05SquadTroopCountPluginContext : RoguelikeCharCardViewPluginContext
	{
		// Token: 0x0602053A RID: 132410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602053A")]
		[Address(RVA = "0x1A715C0", Offset = "0x1A701C0", VA = "0x181A715C0", Slot = "24")]
		public override IRoguelikeCharCardPlugin GetPlugin()
		{
			return null;
		}

		// Token: 0x0602053B RID: 132411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602053B")]
		[Address(RVA = "0x1A716A0", Offset = "0x1A702A0", VA = "0x181A716A0", Slot = "25")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0602053C RID: 132412 RVA: 0x000B5650 File Offset: 0x000B3850
		[Token(Token = "0x602053C")]
		[Address(RVA = "0x1A71720", Offset = "0x1A70320", VA = "0x181A71720", Slot = "23")]
		public override bool OverrideSquadTroopCount(List<RoguelikeCharCardViewModel> curCharInSquad, out int squadTroopCount)
		{
			return default(bool);
		}

		// Token: 0x0602053D RID: 132413 RVA: 0x000B5668 File Offset: 0x000B3868
		[Token(Token = "0x602053D")]
		[Address(RVA = "0x1A71800", Offset = "0x1A70400", VA = "0x181A71800")]
		private bool _GetCandleCharCount(string topicId, List<RoguelikeCharCardViewModel> curCharInSquad, out int squadTroopCount)
		{
			return default(bool);
		}

		// Token: 0x0602053E RID: 132414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602053E")]
		[Address(RVA = "0x1A71C20", Offset = "0x1A70820", VA = "0x181A71C20")]
		public RL05SquadTroopCountPluginContext()
		{
		}

		// Token: 0x0602053F RID: 132415 RVA: 0x000B5680 File Offset: 0x000B3880
		[Token(Token = "0x602053F")]
		[Address(RVA = "0x1A717F0", Offset = "0x1A703F0", VA = "0x181A717F0")]
		private bool <>xLuaBaseProxy_OverrideSquadTroopCount(List<RoguelikeCharCardViewModel> P0, out int P1)
		{
			return default(bool);
		}

		// Token: 0x0402BC14 RID: 179220
		[Token(Token = "0x402BC14")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<string> m_expeditionMap;

		// Token: 0x0402BC15 RID: 179221
		[Token(Token = "0x402BC15")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x0402BC16 RID: 179222
		[Token(Token = "0x402BC16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x0402BC17 RID: 179223
		[Token(Token = "0x402BC17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BC18 RID: 179224
		[Token(Token = "0x402BC18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OverrideSquadTroopCount;

		// Token: 0x0402BC19 RID: 179225
		[Token(Token = "0x402BC19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetCandleCharCount;

		// Token: 0x0402BC1A RID: 179226
		[Token(Token = "0x402BC1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005610 RID: 22032
		[Token(Token = "0x2005610")]
		public class RL05SquadTroopCountPlugin : RoguelikeCharCardPlugin<RL05SquadTroopCountPluginContext>
		{
			// Token: 0x06020540 RID: 132416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020540")]
			[Address(RVA = "0x1A71CD0", Offset = "0x1A708D0", VA = "0x181A71CD0")]
			public RL05SquadTroopCountPlugin()
			{
			}

			// Token: 0x0402BC1B RID: 179227
			[Token(Token = "0x402BC1B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
