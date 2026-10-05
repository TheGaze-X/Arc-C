using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002330 RID: 9008
	[Token(Token = "0x2002330")]
	public class Mainline12SightManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x0600E393 RID: 58259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C88")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E393")]
			[Address(RVA = "0x5816B0", Offset = "0x5802B0", VA = "0x1805816B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E394")]
		[Address(RVA = "0x5805D0", Offset = "0x57F1D0", VA = "0x1805805D0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E395")]
		[Address(RVA = "0x580E30", Offset = "0x57FA30", VA = "0x180580E30")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E396")]
		[Address(RVA = "0x581030", Offset = "0x57FC30", VA = "0x180581030")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E397")]
		[Address(RVA = "0x580810", Offset = "0x57F410", VA = "0x180580810", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E398")]
		[Address(RVA = "0x5812F0", Offset = "0x57FEF0", VA = "0x1805812F0")]
		private void _UpdateTileByDiff()
		{
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E399")]
		[Address(RVA = "0x580D40", Offset = "0x57F940", VA = "0x180580D40")]
		private void _MarkInView(bool inCharView, Tile tile)
		{
		}

		// Token: 0x0600E39A RID: 58266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E39A")]
		[Address(RVA = "0x581560", Offset = "0x580160", VA = "0x180581560")]
		public Mainline12SightManager()
		{
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E39B")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E39C RID: 58268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E39C")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E39D RID: 58269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E39D")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400FA15 RID: 64021
		[Token(Token = "0x400FA15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _inSight;

		// Token: 0x0400FA16 RID: 64022
		[Token(Token = "0x400FA16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _outOfSight;

		// Token: 0x0400FA17 RID: 64023
		[Token(Token = "0x400FA17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _notViewed;

		// Token: 0x0400FA18 RID: 64024
		[Token(Token = "0x400FA18")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<Character, int> m_unitModeIndexCache;

		// Token: 0x0400FA19 RID: 64025
		[Token(Token = "0x400FA19")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<Character, List<Tile>> m_tileInUnitAttackRangeBefore;

		// Token: 0x0400FA1A RID: 64026
		[Token(Token = "0x400FA1A")]
		[FieldOffset(Offset = "0x50")]
		private List<Tile> m_newInViewTile;

		// Token: 0x0400FA1B RID: 64027
		[Token(Token = "0x400FA1B")]
		[FieldOffset(Offset = "0x58")]
		private int[,] m_cacheTileStatus;

		// Token: 0x0400FA1C RID: 64028
		[Token(Token = "0x400FA1C")]
		[FieldOffset(Offset = "0x60")]
		private int[,] m_tileStatus;

		// Token: 0x0400FA1D RID: 64029
		[Token(Token = "0x400FA1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FA1E RID: 64030
		[Token(Token = "0x400FA1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FA1F RID: 64031
		[Token(Token = "0x400FA1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FA20 RID: 64032
		[Token(Token = "0x400FA20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FA21 RID: 64033
		[Token(Token = "0x400FA21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FA22 RID: 64034
		[Token(Token = "0x400FA22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTileByDiff;

		// Token: 0x0400FA23 RID: 64035
		[Token(Token = "0x400FA23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__MarkInView;

		// Token: 0x0400FA24 RID: 64036
		[Token(Token = "0x400FA24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
