using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF9 RID: 11001
	[Token(Token = "0x2002AF9")]
	public class TriggerTileAbility : CastOnTileAbility
	{
		// Token: 0x06012613 RID: 75283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012613")]
		[Address(RVA = "0xA79310", Offset = "0xA77F10", VA = "0x180A79310", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012614 RID: 75284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012614")]
		[Address(RVA = "0xA79380", Offset = "0xA77F80", VA = "0x180A79380", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012615 RID: 75285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012615")]
		[Address(RVA = "0xA79470", Offset = "0xA78070", VA = "0x180A79470")]
		public TriggerTileAbility()
		{
		}

		// Token: 0x06012616 RID: 75286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012616")]
		[Address(RVA = "0xA4C4A0", Offset = "0xA4B0A0", VA = "0x180A4C4A0")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014C91 RID: 85137
		[Token(Token = "0x4014C91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014C92 RID: 85138
		[Token(Token = "0x4014C92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014C93 RID: 85139
		[Token(Token = "0x4014C93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
