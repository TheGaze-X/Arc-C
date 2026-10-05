using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002457 RID: 9303
	[Token(Token = "0x2002457")]
	public class DemetrS3CastSkill : CastSkill
	{
		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x00057F48 File Offset: 0x00056148
		[Token(Token = "0x17001F06")]
		private bool isCharacterRespawn
		{
			[Token(Token = "0x600EF11")]
			[Address(RVA = "0x6755F0", Offset = "0x6741F0", VA = "0x1806755F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600EF12 RID: 61202 RVA: 0x00057F60 File Offset: 0x00056160
		[Token(Token = "0x17001F07")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600EF12")]
			[Address(RVA = "0x675650", Offset = "0x674250", VA = "0x180675650", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x00057F78 File Offset: 0x00056178
		[Token(Token = "0x17001F08")]
		public override bool isAffecting
		{
			[Token(Token = "0x600EF13")]
			[Address(RVA = "0x675540", Offset = "0x674140", VA = "0x180675540", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EF14 RID: 61204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF14")]
		[Address(RVA = "0x673D00", Offset = "0x672900", VA = "0x180673D00", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EF15 RID: 61205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF15")]
		[Address(RVA = "0x674190", Offset = "0x672D90", VA = "0x180674190", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600EF16 RID: 61206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF16")]
		[Address(RVA = "0x674010", Offset = "0x672C10", VA = "0x180674010", Slot = "53")]
		public override void InterruptIfNot()
		{
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF17")]
		[Address(RVA = "0x6746F0", Offset = "0x6732F0", VA = "0x1806746F0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF18")]
		[Address(RVA = "0x6743D0", Offset = "0x672FD0", VA = "0x1806743D0", Slot = "61")]
		public override void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600EF19 RID: 61209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF19")]
		[Address(RVA = "0x674CF0", Offset = "0x6738F0", VA = "0x180674CF0")]
		private void _ResetSharedData(Blackboard blackboard)
		{
		}

		// Token: 0x0600EF1A RID: 61210 RVA: 0x00057F90 File Offset: 0x00056190
		[Token(Token = "0x600EF1A")]
		[Address(RVA = "0x674E50", Offset = "0x673A50", VA = "0x180674E50")]
		private bool _RespawnToLocatedPos()
		{
			return default(bool);
		}

		// Token: 0x0600EF1B RID: 61211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF1B")]
		[Address(RVA = "0x674990", Offset = "0x673590", VA = "0x180674990")]
		private void _KillToken()
		{
		}

		// Token: 0x0600EF1C RID: 61212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF1C")]
		[Address(RVA = "0x674820", Offset = "0x673420", VA = "0x180674820")]
		private void _AddDynamicBuffTileExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600EF1D RID: 61213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF1D")]
		[Address(RVA = "0x674B80", Offset = "0x673780", VA = "0x180674B80")]
		private void _RemoveDynamicBuffTileExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600EF1E RID: 61214 RVA: 0x00057FA8 File Offset: 0x000561A8
		[Token(Token = "0x600EF1E")]
		[Address(RVA = "0x675220", Offset = "0x673E20", VA = "0x180675220")]
		private bool _TriggerAbility()
		{
			return default(bool);
		}

		// Token: 0x0600EF1F RID: 61215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF1F")]
		[Address(RVA = "0x674130", Offset = "0x672D30", VA = "0x180674130")]
		public void KillTokenOutSide()
		{
		}

		// Token: 0x0600EF20 RID: 61216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF20")]
		[Address(RVA = "0x675300", Offset = "0x673F00", VA = "0x180675300")]
		public DemetrS3CastSkill()
		{
		}

		// Token: 0x0600EF21 RID: 61217 RVA: 0x00057FC0 File Offset: 0x000561C0
		[Token(Token = "0x600EF21")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600EF22 RID: 61218 RVA: 0x00057FD8 File Offset: 0x000561D8
		[Token(Token = "0x600EF22")]
		[Address(RVA = "0x6346C0", Offset = "0x6332C0", VA = "0x1806346C0")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600EF23 RID: 61219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF23")]
		[Address(RVA = "0x6432F0", Offset = "0x641EF0", VA = "0x1806432F0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EF24 RID: 61220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF24")]
		[Address(RVA = "0x634E00", Offset = "0x633A00", VA = "0x180634E00")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600EF25 RID: 61221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF25")]
		[Address(RVA = "0x674810", Offset = "0x673410", VA = "0x180674810")]
		private void <>xLuaBaseProxy_InterruptIfNot()
		{
		}

		// Token: 0x0600EF26 RID: 61222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF26")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EF27 RID: 61223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF27")]
		[Address(RVA = "0x635EF0", Offset = "0x634AF0", VA = "0x180635EF0")]
		private void <>xLuaBaseProxy_OnOwnerFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x04010861 RID: 67681
		[Token(Token = "0x4010861")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Ability _restoreAbility;

		// Token: 0x04010862 RID: 67682
		[Token(Token = "0x4010862")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _respawnBBKey;

		// Token: 0x04010863 RID: 67683
		[Token(Token = "0x4010863")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _restoreBBKey;

		// Token: 0x04010864 RID: 67684
		[Token(Token = "0x4010864")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _skillProgressBBKey;

		// Token: 0x04010865 RID: 67685
		[Token(Token = "0x4010865")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _colBBKey;

		// Token: 0x04010866 RID: 67686
		[Token(Token = "0x4010866")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _rowBBKey;

		// Token: 0x04010867 RID: 67687
		[Token(Token = "0x4010867")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _locatedColBBKey;

		// Token: 0x04010868 RID: 67688
		[Token(Token = "0x4010868")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _locatedRowBBKey;

		// Token: 0x04010869 RID: 67689
		[Token(Token = "0x4010869")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _respawnInPlaceBBKey;

		// Token: 0x0401086A RID: 67690
		[Token(Token = "0x401086A")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _interruptLockKeys;

		// Token: 0x0401086B RID: 67691
		[Token(Token = "0x401086B")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _resetBlackboard;

		// Token: 0x0401086C RID: 67692
		[Token(Token = "0x401086C")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _addRespawnBlackboard;

		// Token: 0x0401086D RID: 67693
		[Token(Token = "0x401086D")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		public List<Blackboard.DataPair> _removeRespawnBlackboard;

		// Token: 0x0401086E RID: 67694
		[Token(Token = "0x401086E")]
		[FieldOffset(Offset = "0x1A8")]
		private bool m_isCharacterResapwn;

		// Token: 0x0401086F RID: 67695
		[Token(Token = "0x401086F")]
		[FieldOffset(Offset = "0x1B0")]
		private FP m_respawnSkillProgress;

		// Token: 0x04010870 RID: 67696
		[Token(Token = "0x4010870")]
		[FieldOffset(Offset = "0x1B8")]
		private PeriodicTimer m_timer;

		// Token: 0x04010871 RID: 67697
		[Token(Token = "0x4010871")]
		[FieldOffset(Offset = "0x1C0")]
		private List<Entity> m_tokens;

		// Token: 0x04010872 RID: 67698
		[Token(Token = "0x4010872")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCharacterRespawn;

		// Token: 0x04010873 RID: 67699
		[Token(Token = "0x4010873")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x04010874 RID: 67700
		[Token(Token = "0x4010874")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04010875 RID: 67701
		[Token(Token = "0x4010875")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010876 RID: 67702
		[Token(Token = "0x4010876")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04010877 RID: 67703
		[Token(Token = "0x4010877")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x04010878 RID: 67704
		[Token(Token = "0x4010878")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010879 RID: 67705
		[Token(Token = "0x4010879")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x0401087A RID: 67706
		[Token(Token = "0x401087A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ResetSharedData;

		// Token: 0x0401087B RID: 67707
		[Token(Token = "0x401087B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RespawnToLocatedPos;

		// Token: 0x0401087C RID: 67708
		[Token(Token = "0x401087C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__KillToken;

		// Token: 0x0401087D RID: 67709
		[Token(Token = "0x401087D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddDynamicBuffTileExcludeCharacter;

		// Token: 0x0401087E RID: 67710
		[Token(Token = "0x401087E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RemoveDynamicBuffTileExcludeCharacter;

		// Token: 0x0401087F RID: 67711
		[Token(Token = "0x401087F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TriggerAbility;

		// Token: 0x04010880 RID: 67712
		[Token(Token = "0x4010880")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_KillTokenOutSide;

		// Token: 0x04010881 RID: 67713
		[Token(Token = "0x4010881")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
