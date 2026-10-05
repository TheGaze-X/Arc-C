using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ADC RID: 10972
	[Token(Token = "0x2002ADC")]
	public class AnimatedActionCastOnTileAbility : CastOnTileAbility
	{
		// Token: 0x060124A4 RID: 74916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60124A4")]
		[Address(RVA = "0xA4DF30", Offset = "0xA4CB30", VA = "0x180A4DF30", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060124A5 RID: 74917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A5")]
		[Address(RVA = "0xA4DFC0", Offset = "0xA4CBC0", VA = "0x180A4DFC0", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060124A6 RID: 74918 RVA: 0x000700E0 File Offset: 0x0006E2E0
		[Token(Token = "0x60124A6")]
		[Address(RVA = "0xA4DEA0", Offset = "0xA4CAA0", VA = "0x180A4DEA0", Slot = "90")]
		protected override ActionPurposeMask GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x060124A7 RID: 74919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A7")]
		[Address(RVA = "0xA4DE00", Offset = "0xA4CA00", VA = "0x180A4DE00", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x060124A8 RID: 74920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A8")]
		[Address(RVA = "0xA4E280", Offset = "0xA4CE80", VA = "0x180A4E280")]
		public AnimatedActionCastOnTileAbility()
		{
		}

		// Token: 0x060124A9 RID: 74921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A9")]
		[Address(RVA = "0xA4C4A0", Offset = "0xA4B0A0", VA = "0x180A4C4A0")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060124AA RID: 74922 RVA: 0x000700F8 File Offset: 0x0006E2F8
		[Token(Token = "0x60124AA")]
		[Address(RVA = "0xA1E510", Offset = "0xA1D110", VA = "0x180A1E510")]
		private ActionPurposeMask <>xLuaBaseProxy_GeneratePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x060124AB RID: 74923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124AB")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x04014ADA RID: 84698
		[Token(Token = "0x4014ADA")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x04014ADB RID: 84699
		[Token(Token = "0x4014ADB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014ADC RID: 84700
		[Token(Token = "0x4014ADC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014ADD RID: 84701
		[Token(Token = "0x4014ADD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;

		// Token: 0x04014ADE RID: 84702
		[Token(Token = "0x4014ADE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014ADF RID: 84703
		[Token(Token = "0x4014ADF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
