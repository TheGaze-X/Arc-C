using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E9 RID: 9449
	[Token(Token = "0x20024E9")]
	public class AdvancedSelectorWithEnemyOptions : AdvancedSelector
	{
		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600F371 RID: 62321 RVA: 0x00059CD0 File Offset: 0x00057ED0
		[Token(Token = "0x17001FB7")]
		protected bool filterBuff
		{
			[Token(Token = "0x600F371")]
			[Address(RVA = "0x69CA70", Offset = "0x69B670", VA = "0x18069CA70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x0600F372 RID: 62322 RVA: 0x00059CE8 File Offset: 0x00057EE8
		[Token(Token = "0x17001FB8")]
		protected bool checkReachableToOwner
		{
			[Token(Token = "0x600F372")]
			[Address(RVA = "0x69CA10", Offset = "0x69B610", VA = "0x18069CA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x0600F373 RID: 62323 RVA: 0x00059D00 File Offset: 0x00057F00
		[Token(Token = "0x17001FB9")]
		protected bool filterUnbalance
		{
			[Token(Token = "0x600F373")]
			[Address(RVA = "0x69CB30", Offset = "0x69B730", VA = "0x18069CB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x0600F374 RID: 62324 RVA: 0x00059D18 File Offset: 0x00057F18
		[Token(Token = "0x17001FBA")]
		protected bool filterEnemyMassLevel
		{
			[Token(Token = "0x600F374")]
			[Address(RVA = "0x69CAD0", Offset = "0x69B6D0", VA = "0x18069CAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F375 RID: 62325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F375")]
		[Address(RVA = "0x69C860", Offset = "0x69B460", VA = "0x18069C860", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F376")]
		[Address(RVA = "0x69C2C0", Offset = "0x69AEC0", VA = "0x18069C2C0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F377 RID: 62327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F377")]
		[Address(RVA = "0x69C950", Offset = "0x69B550", VA = "0x18069C950")]
		public AdvancedSelectorWithEnemyOptions()
		{
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F378")]
		[Address(RVA = "0x60C6F0", Offset = "0x60B2F0", VA = "0x18060C6F0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F379 RID: 62329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F379")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D64 RID: 68964
		[Token(Token = "0x4010D64")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private EnemyLevelMask _enemyLevelMask;

		// Token: 0x04010D65 RID: 68965
		[Token(Token = "0x4010D65")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private MotionMask _motionMask;

		// Token: 0x04010D66 RID: 68966
		[Token(Token = "0x4010D66")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _allowNoneApplyWay;

		// Token: 0x04010D67 RID: 68967
		[Token(Token = "0x4010D67")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private SourceApplyWay _applyWay;

		// Token: 0x04010D68 RID: 68968
		[Token(Token = "0x4010D68")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _filterByEnemiesKey;

		// Token: 0x04010D69 RID: 68969
		[Token(Token = "0x4010D69")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private EnemyKeyExcludeMode _filterEnemyKeyMode;

		// Token: 0x04010D6A RID: 68970
		[Token(Token = "0x4010D6A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _enemyKey;

		// Token: 0x04010D6B RID: 68971
		[Token(Token = "0x4010D6B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _filterByEnemiesMode;

		// Token: 0x04010D6C RID: 68972
		[Token(Token = "0x4010D6C")]
		[FieldOffset(Offset = "0x111")]
		[SerializeField]
		private bool _filterByEnemiesTag;

		// Token: 0x04010D6D RID: 68973
		[Token(Token = "0x4010D6D")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private int _enemyMode;

		// Token: 0x04010D6E RID: 68974
		[Token(Token = "0x4010D6E")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _enemyTag;

		// Token: 0x04010D6F RID: 68975
		[Token(Token = "0x4010D6F")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _excludeDisappeared;

		// Token: 0x04010D70 RID: 68976
		[Token(Token = "0x4010D70")]
		[FieldOffset(Offset = "0x121")]
		[SerializeField]
		private bool _excludeInCombat;

		// Token: 0x04010D71 RID: 68977
		[Token(Token = "0x4010D71")]
		[FieldOffset(Offset = "0x122")]
		[SerializeField]
		private bool _filterBuff;

		// Token: 0x04010D72 RID: 68978
		[Token(Token = "0x4010D72")]
		[FieldOffset(Offset = "0x123")]
		[SerializeField]
		[Inspect("filterBuff")]
		private bool _buffKeyExcluded;

		// Token: 0x04010D73 RID: 68979
		[Token(Token = "0x4010D73")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Inspect("filterBuff")]
		private string _buffKey;

		// Token: 0x04010D74 RID: 68980
		[Token(Token = "0x4010D74")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private bool _checkReachableToOwner;

		// Token: 0x04010D75 RID: 68981
		[Token(Token = "0x4010D75")]
		[FieldOffset(Offset = "0x131")]
		[SerializeField]
		[Inspect("checkReachableToOwner")]
		private bool _avoidObstacleLike;

		// Token: 0x04010D76 RID: 68982
		[Token(Token = "0x4010D76")]
		[FieldOffset(Offset = "0x132")]
		[SerializeField]
		private bool _filterUnbalance;

		// Token: 0x04010D77 RID: 68983
		[Token(Token = "0x4010D77")]
		[FieldOffset(Offset = "0x133")]
		[SerializeField]
		[Inspect("filterUnbalance")]
		private bool _filterNotInUnbalance;

		// Token: 0x04010D78 RID: 68984
		[Token(Token = "0x4010D78")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private bool _filterAbnormalImmune;

		// Token: 0x04010D79 RID: 68985
		[Token(Token = "0x4010D79")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private AbnormalFlag _abnormalFlagImmune;

		// Token: 0x04010D7A RID: 68986
		[Token(Token = "0x4010D7A")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private bool _filterEnemyMassLevel;

		// Token: 0x04010D7B RID: 68987
		[Token(Token = "0x4010D7B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Inspect("filterEnemyMassLevel")]
		private CompareType _massCompareType;

		// Token: 0x04010D7C RID: 68988
		[Token(Token = "0x4010D7C")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		[Inspect("filterEnemyMassLevel")]
		private int _massLevel;

		// Token: 0x04010D7D RID: 68989
		[Token(Token = "0x4010D7D")]
		[FieldOffset(Offset = "0x148")]
		private string m_enemyKey;

		// Token: 0x04010D7E RID: 68990
		[Token(Token = "0x4010D7E")]
		[FieldOffset(Offset = "0x150")]
		private int m_filterMassLevel;

		// Token: 0x04010D7F RID: 68991
		[Token(Token = "0x4010D7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterBuff;

		// Token: 0x04010D80 RID: 68992
		[Token(Token = "0x4010D80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkReachableToOwner;

		// Token: 0x04010D81 RID: 68993
		[Token(Token = "0x4010D81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_filterUnbalance;

		// Token: 0x04010D82 RID: 68994
		[Token(Token = "0x4010D82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterEnemyMassLevel;

		// Token: 0x04010D83 RID: 68995
		[Token(Token = "0x4010D83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010D84 RID: 68996
		[Token(Token = "0x4010D84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D85 RID: 68997
		[Token(Token = "0x4010D85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
