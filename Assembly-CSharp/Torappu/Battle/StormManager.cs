using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200234D RID: 9037
	[Token(Token = "0x200234D")]
	public class StormManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C9D")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4AC")]
			[Address(RVA = "0x5AC220", Offset = "0x5AAE20", VA = "0x1805AC220", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4AD")]
		[Address(RVA = "0x5AAD80", Offset = "0x5A9980", VA = "0x1805AAD80")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4AE")]
		[Address(RVA = "0x5AB310", Offset = "0x5A9F10", VA = "0x1805AB310")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4AF")]
		[Address(RVA = "0x5AB8C0", Offset = "0x5AA4C0", VA = "0x1805AB8C0")]
		private void _UpdateStormBlocker(IBuildable unit)
		{
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B0")]
		[Address(RVA = "0x5AB780", Offset = "0x5AA380", VA = "0x1805AB780")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x00052B30 File Offset: 0x00050D30
		[Token(Token = "0x600E4B1")]
		[Address(RVA = "0x5AACA0", Offset = "0x5A98A0", VA = "0x1805AACA0")]
		private bool _CharacterValid(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B2")]
		[Address(RVA = "0x5ABB50", Offset = "0x5AA750", VA = "0x1805ABB50")]
		private void _UpdateTileStatus()
		{
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B3")]
		[Address(RVA = "0x5AAB30", Offset = "0x5A9730", VA = "0x1805AAB30", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B4")]
		[Address(RVA = "0x5AC120", Offset = "0x5AAD20", VA = "0x1805AC120")]
		public StormManager()
		{
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4B5")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E4B6 RID: 58550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B6")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0400FC05 RID: 64517
		[Token(Token = "0x400FC05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _inStormKey;

		// Token: 0x0400FC06 RID: 64518
		[Token(Token = "0x400FC06")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _notInStormKey;

		// Token: 0x0400FC07 RID: 64519
		[Token(Token = "0x400FC07")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _trapTagWhiteList;

		// Token: 0x0400FC08 RID: 64520
		[Token(Token = "0x400FC08")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TargetOptions _targetOption;

		// Token: 0x0400FC09 RID: 64521
		[Token(Token = "0x400FC09")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<StormManager.DirectionEffectSetting> _effectSettings;

		// Token: 0x0400FC0A RID: 64522
		[Token(Token = "0x400FC0A")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<Unit, GridPosition> m_tileContainStormBlocker;

		// Token: 0x0400FC0B RID: 64523
		[Token(Token = "0x400FC0B")]
		[FieldOffset(Offset = "0xB0")]
		private bool[,] m_tileInStormBefore;

		// Token: 0x0400FC0C RID: 64524
		[Token(Token = "0x400FC0C")]
		[FieldOffset(Offset = "0xB8")]
		private bool[,] m_tileInStorm;

		// Token: 0x0400FC0D RID: 64525
		[Token(Token = "0x400FC0D")]
		[FieldOffset(Offset = "0xC0")]
		private SharedConsts.Direction m_stormDirection;

		// Token: 0x0400FC0E RID: 64526
		[Token(Token = "0x400FC0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC0F RID: 64527
		[Token(Token = "0x400FC0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400FC10 RID: 64528
		[Token(Token = "0x400FC10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FC11 RID: 64529
		[Token(Token = "0x400FC11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateStormBlocker;

		// Token: 0x0400FC12 RID: 64530
		[Token(Token = "0x400FC12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FC13 RID: 64531
		[Token(Token = "0x400FC13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CharacterValid;

		// Token: 0x0400FC14 RID: 64532
		[Token(Token = "0x400FC14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateTileStatus;

		// Token: 0x0400FC15 RID: 64533
		[Token(Token = "0x400FC15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400FC16 RID: 64534
		[Token(Token = "0x400FC16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200234E RID: 9038
		[Token(Token = "0x200234E")]
		[Serializable]
		private struct DirectionEffectSetting
		{
			// Token: 0x0400FC17 RID: 64535
			[Token(Token = "0x400FC17")]
			[FieldOffset(Offset = "0x0")]
			public string effectKey;

			// Token: 0x0400FC18 RID: 64536
			[Token(Token = "0x400FC18")]
			[FieldOffset(Offset = "0x8")]
			public int effectLevel;
		}
	}
}
