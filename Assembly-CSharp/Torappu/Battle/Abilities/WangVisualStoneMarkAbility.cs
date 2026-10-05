using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BBD RID: 11197
	[Token(Token = "0x2002BBD")]
	public class WangVisualStoneMarkAbility : ProjectileToTileWithExtraActionsAbility
	{
		// Token: 0x06012E97 RID: 77463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E97")]
		[Address(RVA = "0xAD77D0", Offset = "0xAD63D0", VA = "0x180AD77D0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012E98 RID: 77464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E98")]
		[Address(RVA = "0xAD7970", Offset = "0xAD6570", VA = "0x180AD7970", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012E99 RID: 77465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E99")]
		[Address(RVA = "0xAD7C60", Offset = "0xAD6860", VA = "0x180AD7C60")]
		public void RemoveStoneMark(GridPosition pos, bool isOverlapped = false)
		{
		}

		// Token: 0x06012E9A RID: 77466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E9A")]
		[Address(RVA = "0xAD7F30", Offset = "0xAD6B30", VA = "0x180AD7F30")]
		public void RunFailedActions()
		{
		}

		// Token: 0x06012E9B RID: 77467 RVA: 0x00073ED8 File Offset: 0x000720D8
		[Token(Token = "0x6012E9B")]
		[Address(RVA = "0xAD7BF0", Offset = "0xAD67F0", VA = "0x180AD7BF0", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012E9C RID: 77468 RVA: 0x00073EF0 File Offset: 0x000720F0
		[Token(Token = "0x6012E9C")]
		[Address(RVA = "0xAD75E0", Offset = "0xAD61E0", VA = "0x180AD75E0", Slot = "79")]
		protected override bool DoOnHasNoTarget(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012E9D RID: 77469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E9D")]
		[Address(RVA = "0xAD7260", Offset = "0xAD5E60", VA = "0x180AD7260", Slot = "111")]
		protected override void CreateProjectileOnTile(Tile tile)
		{
		}

		// Token: 0x06012E9E RID: 77470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E9E")]
		[Address(RVA = "0xAD7760", Offset = "0xAD6360", VA = "0x180AD7760", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012E9F RID: 77471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E9F")]
		[Address(RVA = "0xAD76C0", Offset = "0xAD62C0", VA = "0x180AD76C0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012EA0 RID: 77472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EA0")]
		[Address(RVA = "0xAD8190", Offset = "0xAD6D90", VA = "0x180AD8190")]
		public WangVisualStoneMarkAbility()
		{
		}

		// Token: 0x06012EA1 RID: 77473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EA1")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012EA2 RID: 77474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EA2")]
		[Address(RVA = "0xA4FF70", Offset = "0xA4EB70", VA = "0x180A4FF70")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012EA3 RID: 77475 RVA: 0x00073F08 File Offset: 0x00072108
		[Token(Token = "0x6012EA3")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012EA4 RID: 77476 RVA: 0x00073F20 File Offset: 0x00072120
		[Token(Token = "0x6012EA4")]
		[Address(RVA = "0xAD8160", Offset = "0xAD6D60", VA = "0x180AD8160")]
		private bool <>xLuaBaseProxy_DoOnHasNoTarget(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012EA5 RID: 77477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EA5")]
		[Address(RVA = "0xAD8150", Offset = "0xAD6D50", VA = "0x180AD8150")]
		private void <>xLuaBaseProxy_CreateProjectileOnTile(Tile P0)
		{
		}

		// Token: 0x06012EA6 RID: 77478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012EA6")]
		[Address(RVA = "0xAD8180", Offset = "0xAD6D80", VA = "0x180AD8180")]
		private IList<ActionNode> <>xLuaBaseProxy_GetEventActions(AbilityStandard.Event P0)
		{
			return null;
		}

		// Token: 0x06012EA7 RID: 77479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012EA7")]
		[Address(RVA = "0xAD8170", Offset = "0xAD6D70", VA = "0x180AD8170")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x04015560 RID: 87392
		[Token(Token = "0x4015560")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		private ActionArray _actionsOnMarkFailed;

		// Token: 0x04015561 RID: 87393
		[Token(Token = "0x4015561")]
		[FieldOffset(Offset = "0x280")]
		private WangStoneTriggerManager m_stoneManager;

		// Token: 0x04015562 RID: 87394
		[Token(Token = "0x4015562")]
		[FieldOffset(Offset = "0x288")]
		private int m_stoneCnt;

		// Token: 0x04015563 RID: 87395
		[Token(Token = "0x4015563")]
		[FieldOffset(Offset = "0x28C")]
		private int m_maxStoneCnt;

		// Token: 0x04015564 RID: 87396
		[Token(Token = "0x4015564")]
		[FieldOffset(Offset = "0x290")]
		private WangStoneTriggerManager.StoneType m_stoneType;

		// Token: 0x04015565 RID: 87397
		[Token(Token = "0x4015565")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x04015566 RID: 87398
		[Token(Token = "0x4015566")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015567 RID: 87399
		[Token(Token = "0x4015567")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RemoveStoneMark;

		// Token: 0x04015568 RID: 87400
		[Token(Token = "0x4015568")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RunFailedActions;

		// Token: 0x04015569 RID: 87401
		[Token(Token = "0x4015569")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x0401556A RID: 87402
		[Token(Token = "0x401556A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoOnHasNoTarget;

		// Token: 0x0401556B RID: 87403
		[Token(Token = "0x401556B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateProjectileOnTile;

		// Token: 0x0401556C RID: 87404
		[Token(Token = "0x401556C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x0401556D RID: 87405
		[Token(Token = "0x401556D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0401556E RID: 87406
		[Token(Token = "0x401556E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
