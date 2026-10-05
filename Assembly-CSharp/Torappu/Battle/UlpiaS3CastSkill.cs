using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002461 RID: 9313
	[Token(Token = "0x2002461")]
	public class UlpiaS3CastSkill : CastSkillWithSuspendable
	{
		// Token: 0x0600EFA2 RID: 61346 RVA: 0x000583C8 File Offset: 0x000565C8
		[Token(Token = "0x600EFA2")]
		[Address(RVA = "0x67F3F0", Offset = "0x67DFF0", VA = "0x18067F3F0", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600EFA3 RID: 61347 RVA: 0x000583E0 File Offset: 0x000565E0
		[Token(Token = "0x17001F16")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600EFA3")]
			[Address(RVA = "0x6809D0", Offset = "0x67F5D0", VA = "0x1806809D0", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600EFA4 RID: 61348 RVA: 0x000583F8 File Offset: 0x000565F8
		[Token(Token = "0x17001F17")]
		public override bool isAffecting
		{
			[Token(Token = "0x600EFA4")]
			[Address(RVA = "0x680960", Offset = "0x67F560", VA = "0x180680960", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA5")]
		[Address(RVA = "0x67F0B0", Offset = "0x67DCB0", VA = "0x18067F0B0", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA6")]
		[Address(RVA = "0x67F460", Offset = "0x67E060", VA = "0x18067F460", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA7")]
		[Address(RVA = "0x67F370", Offset = "0x67DF70", VA = "0x18067F370", Slot = "53")]
		public override void InterruptIfNot()
		{
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x00058410 File Offset: 0x00056610
		[Token(Token = "0x600EFA8")]
		[Address(RVA = "0x67FAB0", Offset = "0x67E6B0", VA = "0x18067FAB0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA9")]
		[Address(RVA = "0x67F9B0", Offset = "0x67E5B0", VA = "0x18067F9B0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EFAA RID: 61354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFAA")]
		[Address(RVA = "0x67F690", Offset = "0x67E290", VA = "0x18067F690", Slot = "61")]
		public override void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600EFAB RID: 61355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFAB")]
		[Address(RVA = "0x680050", Offset = "0x67EC50", VA = "0x180680050")]
		private void _ResetSharedData(Blackboard blackboard)
		{
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x00058428 File Offset: 0x00056628
		[Token(Token = "0x600EFAC")]
		[Address(RVA = "0x6801B0", Offset = "0x67EDB0", VA = "0x1806801B0")]
		private bool _RespawnToLocatedPos()
		{
			return default(bool);
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFAD")]
		[Address(RVA = "0x67FCF0", Offset = "0x67E8F0", VA = "0x18067FCF0")]
		private void _KillToken()
		{
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFAE")]
		[Address(RVA = "0x67FB80", Offset = "0x67E780", VA = "0x18067FB80")]
		private void _AddDynamicBuffTileExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFAF")]
		[Address(RVA = "0x67FEE0", Offset = "0x67EAE0", VA = "0x18067FEE0")]
		private void _RemoveDynamicBuffTileExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x00058440 File Offset: 0x00056640
		[Token(Token = "0x600EFB0")]
		[Address(RVA = "0x6805C0", Offset = "0x67F1C0", VA = "0x1806805C0")]
		private bool _TriggerAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EFB1 RID: 61361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFB1")]
		[Address(RVA = "0x6806A0", Offset = "0x67F2A0", VA = "0x1806806A0")]
		public UlpiaS3CastSkill()
		{
		}

		// Token: 0x0600EFB2 RID: 61362 RVA: 0x00058458 File Offset: 0x00056658
		[Token(Token = "0x600EFB2")]
		[Address(RVA = "0x67FA90", Offset = "0x67E690", VA = "0x18067FA90")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EFB3 RID: 61363 RVA: 0x00058470 File Offset: 0x00056670
		[Token(Token = "0x600EFB3")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600EFB4 RID: 61364 RVA: 0x00058488 File Offset: 0x00056688
		[Token(Token = "0x600EFB4")]
		[Address(RVA = "0x6346C0", Offset = "0x6332C0", VA = "0x1806346C0")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600EFB5 RID: 61365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFB5")]
		[Address(RVA = "0x6432F0", Offset = "0x641EF0", VA = "0x1806432F0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EFB6 RID: 61366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFB6")]
		[Address(RVA = "0x634E00", Offset = "0x633A00", VA = "0x180634E00")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600EFB7 RID: 61367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFB7")]
		[Address(RVA = "0x674810", Offset = "0x673410", VA = "0x180674810")]
		private void <>xLuaBaseProxy_InterruptIfNot()
		{
		}

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x000584A0 File Offset: 0x000566A0
		[Token(Token = "0x600EFB8")]
		[Address(RVA = "0x67FAA0", Offset = "0x67E6A0", VA = "0x18067FAA0")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EFB9 RID: 61369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFB9")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EFBA RID: 61370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFBA")]
		[Address(RVA = "0x635EF0", Offset = "0x634AF0", VA = "0x180635EF0")]
		private void <>xLuaBaseProxy_OnOwnerFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x040108F8 RID: 67832
		[Token(Token = "0x40108F8")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Ability _restoreAbility;

		// Token: 0x040108F9 RID: 67833
		[Token(Token = "0x40108F9")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private bool _isManuallyDiscardable;

		// Token: 0x040108FA RID: 67834
		[Token(Token = "0x40108FA")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private string _respawnPlaceTokenBuffKey;

		// Token: 0x040108FB RID: 67835
		[Token(Token = "0x40108FB")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _respawnBBKey;

		// Token: 0x040108FC RID: 67836
		[Token(Token = "0x40108FC")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _restoreBBKey;

		// Token: 0x040108FD RID: 67837
		[Token(Token = "0x40108FD")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _skillProgressBBKey;

		// Token: 0x040108FE RID: 67838
		[Token(Token = "0x40108FE")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _colBBKey;

		// Token: 0x040108FF RID: 67839
		[Token(Token = "0x40108FF")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _rowBBKey;

		// Token: 0x04010900 RID: 67840
		[Token(Token = "0x4010900")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _locatedColBBKey;

		// Token: 0x04010901 RID: 67841
		[Token(Token = "0x4010901")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _locatedRowBBKey;

		// Token: 0x04010902 RID: 67842
		[Token(Token = "0x4010902")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _respawnInPlaceBBKey;

		// Token: 0x04010903 RID: 67843
		[Token(Token = "0x4010903")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _resetBlackboard;

		// Token: 0x04010904 RID: 67844
		[Token(Token = "0x4010904")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _addRespawnBlackboard;

		// Token: 0x04010905 RID: 67845
		[Token(Token = "0x4010905")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _removeRespawnBlackboard;

		// Token: 0x04010906 RID: 67846
		[Token(Token = "0x4010906")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_isCharacterResapwn;

		// Token: 0x04010907 RID: 67847
		[Token(Token = "0x4010907")]
		[FieldOffset(Offset = "0x1D0")]
		private FP m_respawnSkillProgress;

		// Token: 0x04010908 RID: 67848
		[Token(Token = "0x4010908")]
		[FieldOffset(Offset = "0x1D8")]
		private PeriodicTimer m_timer;

		// Token: 0x04010909 RID: 67849
		[Token(Token = "0x4010909")]
		[FieldOffset(Offset = "0x1E0")]
		private List<Entity> m_tokens;

		// Token: 0x0401090A RID: 67850
		[Token(Token = "0x401090A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x0401090B RID: 67851
		[Token(Token = "0x401090B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x0401090C RID: 67852
		[Token(Token = "0x401090C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x0401090D RID: 67853
		[Token(Token = "0x401090D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x0401090E RID: 67854
		[Token(Token = "0x401090E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x0401090F RID: 67855
		[Token(Token = "0x401090F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x04010910 RID: 67856
		[Token(Token = "0x4010910")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010911 RID: 67857
		[Token(Token = "0x4010911")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010912 RID: 67858
		[Token(Token = "0x4010912")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x04010913 RID: 67859
		[Token(Token = "0x4010913")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetSharedData;

		// Token: 0x04010914 RID: 67860
		[Token(Token = "0x4010914")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RespawnToLocatedPos;

		// Token: 0x04010915 RID: 67861
		[Token(Token = "0x4010915")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__KillToken;

		// Token: 0x04010916 RID: 67862
		[Token(Token = "0x4010916")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AddDynamicBuffTileExcludeCharacter;

		// Token: 0x04010917 RID: 67863
		[Token(Token = "0x4010917")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RemoveDynamicBuffTileExcludeCharacter;

		// Token: 0x04010918 RID: 67864
		[Token(Token = "0x4010918")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TriggerAbility;

		// Token: 0x04010919 RID: 67865
		[Token(Token = "0x4010919")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
