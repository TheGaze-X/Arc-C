using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AE9 RID: 10985
	[Token(Token = "0x2002AE9")]
	public class PoachrRespawnPredefinedAbility : CastOnTileAbility
	{
		// Token: 0x06012560 RID: 75104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012560")]
		[Address(RVA = "0xA59830", Offset = "0xA58430", VA = "0x180A59830", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012561 RID: 75105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012561")]
		[Address(RVA = "0xA598C0", Offset = "0xA584C0", VA = "0x180A598C0", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012562 RID: 75106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012562")]
		[Address(RVA = "0xA59E50", Offset = "0xA58A50", VA = "0x180A59E50")]
		public PoachrRespawnPredefinedAbility()
		{
		}

		// Token: 0x06012563 RID: 75107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012563")]
		[Address(RVA = "0xA4C4A0", Offset = "0xA4B0A0", VA = "0x180A4C4A0")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014BA5 RID: 84901
		[Token(Token = "0x4014BA5")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("CastOnTile")]
		private ActionArray _actions;

		// Token: 0x04014BA6 RID: 84902
		[Token(Token = "0x4014BA6")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("Poachr")]
		public BuffData _huntBuff;

		// Token: 0x04014BA7 RID: 84903
		[Token(Token = "0x4014BA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014BA8 RID: 84904
		[Token(Token = "0x4014BA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014BA9 RID: 84905
		[Token(Token = "0x4014BA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
