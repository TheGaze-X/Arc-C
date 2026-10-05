using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF8 RID: 11000
	[Token(Token = "0x2002AF8")]
	public class SummonEnemyToTileAbility : AbstractAnimatedAbility
	{
		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x060125FC RID: 75260 RVA: 0x000707E8 File Offset: 0x0006E9E8
		[Token(Token = "0x17002847")]
		public bool randomEnemy
		{
			[Token(Token = "0x60125FC")]
			[Address(RVA = "0xA79250", Offset = "0xA77E50", VA = "0x180A79250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x060125FD RID: 75261 RVA: 0x00070800 File Offset: 0x0006EA00
		[Token(Token = "0x17002848")]
		protected bool unharmful
		{
			[Token(Token = "0x60125FD")]
			[Address(RVA = "0xA792B0", Offset = "0xA77EB0", VA = "0x180A792B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x060125FE RID: 75262 RVA: 0x00070818 File Offset: 0x0006EA18
		[Token(Token = "0x17002849")]
		protected virtual bool notSpawnWhenCastEnd
		{
			[Token(Token = "0x60125FE")]
			[Address(RVA = "0xA735C0", Offset = "0xA721C0", VA = "0x180A735C0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125FF RID: 75263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60125FF")]
		[Address(RVA = "0xA777D0", Offset = "0xA763D0", VA = "0x180A777D0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012600 RID: 75264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012600")]
		[Address(RVA = "0xA77840", Offset = "0xA76440", VA = "0x180A77840", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012601 RID: 75265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012601")]
		[Address(RVA = "0xA77710", Offset = "0xA76310", VA = "0x180A77710", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012602 RID: 75266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012602")]
		[Address(RVA = "0xA77670", Offset = "0xA76270", VA = "0x180A77670", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012603 RID: 75267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012603")]
		[Address(RVA = "0xA77150", Offset = "0xA75D50", VA = "0x180A77150", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012604 RID: 75268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012604")]
		[Address(RVA = "0xA78750", Offset = "0xA77350", VA = "0x180A78750", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012605 RID: 75269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012605")]
		[Address(RVA = "0xA77440", Offset = "0xA76040", VA = "0x180A77440")]
		public void FinishAllSummonedEnemy(object arg)
		{
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x06012606 RID: 75270 RVA: 0x00070830 File Offset: 0x0006EA30
		[Token(Token = "0x1700284A")]
		public override bool isReady
		{
			[Token(Token = "0x6012606")]
			[Address(RVA = "0xA79150", Offset = "0xA77D50", VA = "0x180A79150", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x06012607 RID: 75271 RVA: 0x00070848 File Offset: 0x0006EA48
		[Token(Token = "0x1700284B")]
		private bool isSummonNotFull
		{
			[Token(Token = "0x6012607")]
			[Address(RVA = "0xA791C0", Offset = "0xA77DC0", VA = "0x180A791C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012608 RID: 75272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012608")]
		[Address(RVA = "0xA77B90", Offset = "0xA76790", VA = "0x180A77B90", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012609 RID: 75273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012609")]
		[Address(RVA = "0xA778D0", Offset = "0xA764D0", VA = "0x180A778D0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0601260A RID: 75274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260A")]
		[Address(RVA = "0xA78930", Offset = "0xA77530", VA = "0x180A78930")]
		private void _DoSummonEnemy()
		{
		}

		// Token: 0x0601260B RID: 75275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260B")]
		[Address(RVA = "0xA78FC0", Offset = "0xA77BC0", VA = "0x180A78FC0")]
		public SummonEnemyToTileAbility()
		{
		}

		// Token: 0x0601260C RID: 75276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260C")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0601260D RID: 75277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260D")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0601260E RID: 75278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260E")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601260F RID: 75279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601260F")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x06012610 RID: 75280 RVA: 0x00070860 File Offset: 0x0006EA60
		[Token(Token = "0x6012610")]
		[Address(RVA = "0xA38720", Offset = "0xA37320", VA = "0x180A38720")]
		private bool <>xLuaBaseProxy_get_isReady()
		{
			return default(bool);
		}

		// Token: 0x06012611 RID: 75281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012611")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x06012612 RID: 75282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012612")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x04014C65 RID: 85093
		[Token(Token = "0x4014C65")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private TargetSelector _sourceSelector;

		// Token: 0x04014C66 RID: 85094
		[Token(Token = "0x4014C66")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string _enemyKey;

		// Token: 0x04014C67 RID: 85095
		[Token(Token = "0x4014C67")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private MotionMode _motionMode;

		// Token: 0x04014C68 RID: 85096
		[Token(Token = "0x4014C68")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _unharmful;

		// Token: 0x04014C69 RID: 85097
		[Token(Token = "0x4014C69")]
		[FieldOffset(Offset = "0x1DD")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _alwaysCountAsKilled;

		// Token: 0x04014C6A RID: 85098
		[Token(Token = "0x4014C6A")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private float _waitTime;

		// Token: 0x04014C6B RID: 85099
		[Token(Token = "0x4014C6B")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		[Group("SummonEnemy")]
		private float _offset;

		// Token: 0x04014C6C RID: 85100
		[Token(Token = "0x4014C6C")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string _summonTileEffect;

		// Token: 0x04014C6D RID: 85101
		[Token(Token = "0x4014C6D")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _noEndPosition;

		// Token: 0x04014C6E RID: 85102
		[Token(Token = "0x4014C6E")]
		[FieldOffset(Offset = "0x1F1")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _rootTileAsCenter;

		// Token: 0x04014C6F RID: 85103
		[Token(Token = "0x4014C6F")]
		[FieldOffset(Offset = "0x1F2")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _summonToAllTile;

		// Token: 0x04014C70 RID: 85104
		[Token(Token = "0x4014C70")]
		[FieldOffset(Offset = "0x1F3")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _randomEnemy;

		// Token: 0x04014C71 RID: 85105
		[Token(Token = "0x4014C71")]
		[FieldOffset(Offset = "0x1F8")]
		[Inspect("randomEnemy")]
		[SerializeField]
		[Group("SummonEnemy")]
		private string[] _randomEnemys;

		// Token: 0x04014C72 RID: 85106
		[Token(Token = "0x4014C72")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _onlySelectMe;

		// Token: 0x04014C73 RID: 85107
		[Token(Token = "0x4014C73")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		[Group("SummonEnemy")]
		private BuffData[] _buffsToEnemy;

		// Token: 0x04014C74 RID: 85108
		[Token(Token = "0x4014C74")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("SummonEnemy")]
		private bool _summonOnCastStart;

		// Token: 0x04014C75 RID: 85109
		[Token(Token = "0x4014C75")]
		[FieldOffset(Offset = "0x211")]
		[SerializeField]
		[Group("Special")]
		private bool _loadValueFromBB;

		// Token: 0x04014C76 RID: 85110
		[Token(Token = "0x4014C76")]
		[FieldOffset(Offset = "0x212")]
		[SerializeField]
		[Group("Special")]
		private bool _dynamicEnemyKey;

		// Token: 0x04014C77 RID: 85111
		[Token(Token = "0x4014C77")]
		[FieldOffset(Offset = "0x213")]
		[SerializeField]
		[Group("Special")]
		private bool _finishSummonedWhenOwnerFinish;

		// Token: 0x04014C78 RID: 85112
		[Token(Token = "0x4014C78")]
		[FieldOffset(Offset = "0x218")]
		private ObjectPtr<Entity> m_routeSource;

		// Token: 0x04014C79 RID: 85113
		[Token(Token = "0x4014C79")]
		[FieldOffset(Offset = "0x228")]
		protected List<ObjectPtr<Tile>> m_targetTile;

		// Token: 0x04014C7A RID: 85114
		[Token(Token = "0x4014C7A")]
		[FieldOffset(Offset = "0x230")]
		private ObjectPtr<Effect> m_summonEffect;

		// Token: 0x04014C7B RID: 85115
		[Token(Token = "0x4014C7B")]
		[FieldOffset(Offset = "0x240")]
		private List<ObjectPtr<Enemy>> m_summonedEnemy;

		// Token: 0x04014C7C RID: 85116
		[Token(Token = "0x4014C7C")]
		[FieldOffset(Offset = "0x248")]
		private List<string> m_randomEnemys;

		// Token: 0x04014C7D RID: 85117
		[Token(Token = "0x4014C7D")]
		[FieldOffset(Offset = "0x250")]
		private int m_maxSummonedCount;

		// Token: 0x04014C7E RID: 85118
		[Token(Token = "0x4014C7E")]
		[FieldOffset(Offset = "0x258")]
		protected string m_enemyKey;

		// Token: 0x04014C7F RID: 85119
		[Token(Token = "0x4014C7F")]
		[FieldOffset(Offset = "0x260")]
		protected float m_offset;

		// Token: 0x04014C80 RID: 85120
		[Token(Token = "0x4014C80")]
		[FieldOffset(Offset = "0x264")]
		private bool m_useTileSelector;

		// Token: 0x04014C81 RID: 85121
		[Token(Token = "0x4014C81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_randomEnemy;

		// Token: 0x04014C82 RID: 85122
		[Token(Token = "0x4014C82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unharmful;

		// Token: 0x04014C83 RID: 85123
		[Token(Token = "0x4014C83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_notSpawnWhenCastEnd;

		// Token: 0x04014C84 RID: 85124
		[Token(Token = "0x4014C84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014C85 RID: 85125
		[Token(Token = "0x4014C85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014C86 RID: 85126
		[Token(Token = "0x4014C86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014C87 RID: 85127
		[Token(Token = "0x4014C87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014C88 RID: 85128
		[Token(Token = "0x4014C88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C89 RID: 85129
		[Token(Token = "0x4014C89")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014C8A RID: 85130
		[Token(Token = "0x4014C8A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FinishAllSummonedEnemy;

		// Token: 0x04014C8B RID: 85131
		[Token(Token = "0x4014C8B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isReady;

		// Token: 0x04014C8C RID: 85132
		[Token(Token = "0x4014C8C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isSummonNotFull;

		// Token: 0x04014C8D RID: 85133
		[Token(Token = "0x4014C8D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014C8E RID: 85134
		[Token(Token = "0x4014C8E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014C8F RID: 85135
		[Token(Token = "0x4014C8F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoSummonEnemy;

		// Token: 0x04014C90 RID: 85136
		[Token(Token = "0x4014C90")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
