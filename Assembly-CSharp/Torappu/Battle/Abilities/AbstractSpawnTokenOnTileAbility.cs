using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ADB RID: 10971
	[Token(Token = "0x2002ADB")]
	public abstract class AbstractSpawnTokenOnTileAbility : CastOnTileAbility, IActionNodeSource
	{
		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0601249B RID: 74907 RVA: 0x000700B0 File Offset: 0x0006E2B0
		[Token(Token = "0x1700281B")]
		public override SourceApplyWay applyWay
		{
			[Token(Token = "0x601249B")]
			[Address(RVA = "0xA4C560", Offset = "0xA4B160", VA = "0x180A4C560", Slot = "22")]
			get
			{
				return SourceApplyWay.NONE;
			}
		}

		// Token: 0x0601249C RID: 74908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601249C")]
		[Address(RVA = "0xA4C170", Offset = "0xA4AD70", VA = "0x180A4C170", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0601249D RID: 74909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601249D")]
		[Address(RVA = "0xA4C210", Offset = "0xA4AE10", VA = "0x180A4C210", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x0601249E RID: 74910
		[Token(Token = "0x601249E")]
		protected abstract void DoSpawnOnTile(Tile tile);

		// Token: 0x0601249F RID: 74911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601249F")]
		[Address(RVA = "0xA4C2A0", Offset = "0xA4AEA0", VA = "0x180A4C2A0", Slot = "110")]
		protected override void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060124A0 RID: 74912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A0")]
		[Address(RVA = "0xA4C4B0", Offset = "0xA4B0B0", VA = "0x180A4C4B0")]
		protected AbstractSpawnTokenOnTileAbility()
		{
		}

		// Token: 0x060124A1 RID: 74913 RVA: 0x000700C8 File Offset: 0x0006E2C8
		[Token(Token = "0x60124A1")]
		[Address(RVA = "0xA25D40", Offset = "0xA24940", VA = "0x180A25D40")]
		private SourceApplyWay <>xLuaBaseProxy_get_applyWay()
		{
			return SourceApplyWay.NONE;
		}

		// Token: 0x060124A2 RID: 74914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A2")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x060124A3 RID: 74915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124A3")]
		[Address(RVA = "0xA4C4A0", Offset = "0xA4B0A0", VA = "0x180A4C4A0")]
		private void <>xLuaBaseProxy_OnCastOnTile(Tile P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014AD3 RID: 84691
		[Token(Token = "0x4014AD3")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("CastOnTile")]
		private SourceApplyWay _applyWay;

		// Token: 0x04014AD4 RID: 84692
		[Token(Token = "0x4014AD4")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("CastOnTile")]
		private ActionArray _actions;

		// Token: 0x04014AD5 RID: 84693
		[Token(Token = "0x4014AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_applyWay;

		// Token: 0x04014AD6 RID: 84694
		[Token(Token = "0x4014AD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04014AD7 RID: 84695
		[Token(Token = "0x4014AD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014AD8 RID: 84696
		[Token(Token = "0x4014AD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014AD9 RID: 84697
		[Token(Token = "0x4014AD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
