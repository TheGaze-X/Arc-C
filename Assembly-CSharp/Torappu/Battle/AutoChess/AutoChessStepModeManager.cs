using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002757 RID: 10071
	[Token(Token = "0x2002757")]
	public class AutoChessStepModeManager : IHotfixable
	{
		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0601068C RID: 67212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023DD")]
		private AutoChessGameManager gameManager
		{
			[Token(Token = "0x601068C")]
			[Address(RVA = "0x821020", Offset = "0x81FC20", VA = "0x180821020")]
			get
			{
				return null;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0601068D RID: 67213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023DE")]
		private ObjectPool<AutoChessBattleStepActionData> actionDataPool
		{
			[Token(Token = "0x601068D")]
			[Address(RVA = "0x820E60", Offset = "0x81FA60", VA = "0x180820E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601068E RID: 67214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601068E")]
		[Address(RVA = "0x81E4C0", Offset = "0x81D0C0", VA = "0x18081E4C0")]
		public void Start()
		{
		}

		// Token: 0x0601068F RID: 67215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601068F")]
		[Address(RVA = "0x81E1C0", Offset = "0x81CDC0", VA = "0x18081E1C0")]
		public void Reset()
		{
		}

		// Token: 0x06010690 RID: 67216 RVA: 0x000640F8 File Offset: 0x000622F8
		[Token(Token = "0x6010690")]
		[Address(RVA = "0x81D6A0", Offset = "0x81C2A0", VA = "0x18081D6A0")]
		public bool NextFrame(bool additional = false)
		{
			return default(bool);
		}

		// Token: 0x06010691 RID: 67217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010691")]
		[Address(RVA = "0x81E7A0", Offset = "0x81D3A0", VA = "0x18081E7A0")]
		public void UpdateSeq(int seq)
		{
		}

		// Token: 0x06010692 RID: 67218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010692")]
		[Address(RVA = "0x820190", Offset = "0x81ED90", VA = "0x180820190")]
		private void _OnSeqUpdated()
		{
		}

		// Token: 0x06010693 RID: 67219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010693")]
		[Address(RVA = "0x820A00", Offset = "0x81F600", VA = "0x180820A00")]
		private void _RecoverBossHp(int hpDelta)
		{
		}

		// Token: 0x06010694 RID: 67220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010694")]
		[Address(RVA = "0x820870", Offset = "0x81F470", VA = "0x180820870")]
		private void _RecoverBossHp(Enemy boss, int hpDelta)
		{
		}

		// Token: 0x06010695 RID: 67221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010695")]
		[Address(RVA = "0x81D560", Offset = "0x81C160", VA = "0x18081D560")]
		public void ApplyAction(AutoChessBattleStepActionData actionData)
		{
		}

		// Token: 0x06010696 RID: 67222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010696")]
		[Address(RVA = "0x820290", Offset = "0x81EE90", VA = "0x180820290")]
		private void _ParseApplyStepAction(AutoChessBattleStepActionData actionData)
		{
		}

		// Token: 0x06010697 RID: 67223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010697")]
		[Address(RVA = "0x81EFE0", Offset = "0x81DBE0", VA = "0x18081EFE0")]
		private void _ApplyEnemyAppear(List<int> paramList)
		{
		}

		// Token: 0x06010698 RID: 67224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010698")]
		[Address(RVA = "0x81F530", Offset = "0x81E130", VA = "0x18081F530")]
		private void _ApplySummonedEnemyAppear(List<int> paramList)
		{
		}

		// Token: 0x06010699 RID: 67225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010699")]
		[Address(RVA = "0x81F210", Offset = "0x81DE10", VA = "0x18081F210")]
		private void _ApplyEnemyFinish(List<int> paramList)
		{
		}

		// Token: 0x0601069A RID: 67226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069A")]
		[Address(RVA = "0x81ECC0", Offset = "0x81D8C0", VA = "0x18081ECC0")]
		private void _ApplyBossStateChanged(List<int> paramList)
		{
		}

		// Token: 0x0601069B RID: 67227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069B")]
		[Address(RVA = "0x81EB70", Offset = "0x81D770", VA = "0x18081EB70")]
		private void _ApplyBattleStateChanged(List<int> paramList)
		{
		}

		// Token: 0x0601069C RID: 67228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069C")]
		[Address(RVA = "0x81F3C0", Offset = "0x81DFC0", VA = "0x18081F3C0")]
		private void _ApplyPlayerStateChanged(List<int> paramList)
		{
		}

		// Token: 0x0601069D RID: 67229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069D")]
		[Address(RVA = "0x81DE60", Offset = "0x81CA60", VA = "0x18081DE60")]
		public void OnEnemyRegistered(Enemy enemy)
		{
		}

		// Token: 0x0601069E RID: 67230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069E")]
		[Address(RVA = "0x81E090", Offset = "0x81CC90", VA = "0x18081E090")]
		public void OnEntityApplyModifier(Entity entity, ref Modifier modifier)
		{
		}

		// Token: 0x0601069F RID: 67231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601069F")]
		[Address(RVA = "0x81F840", Offset = "0x81E440", VA = "0x18081F840")]
		private void _OnBossEnemyTakeDamage(Enemy boss, ref Modifier modifier)
		{
		}

		// Token: 0x060106A0 RID: 67232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106A0")]
		[Address(RVA = "0x81D810", Offset = "0x81C410", VA = "0x18081D810")]
		public void OnEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x060106A1 RID: 67233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106A1")]
		[Address(RVA = "0x81DB00", Offset = "0x81C700", VA = "0x18081DB00")]
		public void OnEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x060106A2 RID: 67234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106A2")]
		[Address(RVA = "0x81FE80", Offset = "0x81EA80", VA = "0x18081FE80")]
		private void _OnNewSummonedEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x060106A3 RID: 67235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106A3")]
		[Address(RVA = "0x81FC30", Offset = "0x81E830", VA = "0x18081FC30")]
		private void _OnManagedEnemyReachExit(Enemy enemy, BossBattleEnemyInfo enemyInfo)
		{
		}

		// Token: 0x060106A4 RID: 67236 RVA: 0x00064110 File Offset: 0x00062310
		[Token(Token = "0x60106A4")]
		[Address(RVA = "0x81D5E0", Offset = "0x81C1E0", VA = "0x18081D5E0")]
		public int GetEnemyEscapedCount(int instId)
		{
			return 0;
		}

		// Token: 0x060106A5 RID: 67237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106A5")]
		[Address(RVA = "0x820BE0", Offset = "0x81F7E0", VA = "0x180820BE0")]
		public AutoChessStepModeManager()
		{
		}

		// Token: 0x040125D2 RID: 75218
		[Token(Token = "0x40125D2")]
		private const int m_summonEnemyInstStart = 65536;

		// Token: 0x040125D3 RID: 75219
		[Token(Token = "0x40125D3")]
		private const int m_bosshp_cost_seq_range = 30;

		// Token: 0x040125D4 RID: 75220
		[Token(Token = "0x40125D4")]
		private const int m_updateBattleStatusInterval = 10;

		// Token: 0x040125D5 RID: 75221
		[Token(Token = "0x40125D5")]
		private const int m_ignoredSeqNum = 30;

		// Token: 0x040125D6 RID: 75222
		[Token(Token = "0x40125D6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_battleStatusDirty;

		// Token: 0x040125D7 RID: 75223
		[Token(Token = "0x40125D7")]
		[FieldOffset(Offset = "0x14")]
		private int m_seq;

		// Token: 0x040125D8 RID: 75224
		[Token(Token = "0x40125D8")]
		[FieldOffset(Offset = "0x18")]
		private int m_playerUidIndex;

		// Token: 0x040125D9 RID: 75225
		[Token(Token = "0x40125D9")]
		[FieldOffset(Offset = "0x1C")]
		private int m_playerGroup;

		// Token: 0x040125DA RID: 75226
		[Token(Token = "0x40125DA")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessGameManager m_gameManager;

		// Token: 0x040125DB RID: 75227
		[Token(Token = "0x40125DB")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPool<AutoChessBattleStepActionData> m_actionDataPool;

		// Token: 0x040125DC RID: 75228
		[Token(Token = "0x40125DC")]
		[FieldOffset(Offset = "0x30")]
		private List<AutoChessBattleStepActionData> m_cachedActions;

		// Token: 0x040125DD RID: 75229
		[Token(Token = "0x40125DD")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<uint, ObjectPtr<Enemy>> m_bossEnemyInfo;

		// Token: 0x040125DE RID: 75230
		[Token(Token = "0x40125DE")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_enemyEscapeCountDict;

		// Token: 0x040125DF RID: 75231
		[Token(Token = "0x40125DF")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, int> m_summonedEnemyCountDict;

		// Token: 0x040125E0 RID: 75232
		[Token(Token = "0x40125E0")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, BossBattleEnemyInfo> m_enemyInfos;

		// Token: 0x040125E1 RID: 75233
		[Token(Token = "0x40125E1")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<int, ObjectPtr<Enemy>> m_enemyEntityDict;

		// Token: 0x040125E2 RID: 75234
		[Token(Token = "0x40125E2")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<int, int> m_cachedCostHpInfo;

		// Token: 0x040125E3 RID: 75235
		[Token(Token = "0x40125E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameManager;

		// Token: 0x040125E4 RID: 75236
		[Token(Token = "0x40125E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actionDataPool;

		// Token: 0x040125E5 RID: 75237
		[Token(Token = "0x40125E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040125E6 RID: 75238
		[Token(Token = "0x40125E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040125E7 RID: 75239
		[Token(Token = "0x40125E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NextFrame;

		// Token: 0x040125E8 RID: 75240
		[Token(Token = "0x40125E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSeq;

		// Token: 0x040125E9 RID: 75241
		[Token(Token = "0x40125E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSeqUpdated;

		// Token: 0x040125EA RID: 75242
		[Token(Token = "0x40125EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RecoverBossHp;

		// Token: 0x040125EB RID: 75243
		[Token(Token = "0x40125EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1__RecoverBossHp;

		// Token: 0x040125EC RID: 75244
		[Token(Token = "0x40125EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyAction;

		// Token: 0x040125ED RID: 75245
		[Token(Token = "0x40125ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ParseApplyStepAction;

		// Token: 0x040125EE RID: 75246
		[Token(Token = "0x40125EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ApplyEnemyAppear;

		// Token: 0x040125EF RID: 75247
		[Token(Token = "0x40125EF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ApplySummonedEnemyAppear;

		// Token: 0x040125F0 RID: 75248
		[Token(Token = "0x40125F0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ApplyEnemyFinish;

		// Token: 0x040125F1 RID: 75249
		[Token(Token = "0x40125F1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ApplyBossStateChanged;

		// Token: 0x040125F2 RID: 75250
		[Token(Token = "0x40125F2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplyBattleStateChanged;

		// Token: 0x040125F3 RID: 75251
		[Token(Token = "0x40125F3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplyPlayerStateChanged;

		// Token: 0x040125F4 RID: 75252
		[Token(Token = "0x40125F4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnEnemyRegistered;

		// Token: 0x040125F5 RID: 75253
		[Token(Token = "0x40125F5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEntityApplyModifier;

		// Token: 0x040125F6 RID: 75254
		[Token(Token = "0x40125F6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnBossEnemyTakeDamage;

		// Token: 0x040125F7 RID: 75255
		[Token(Token = "0x40125F7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnEnemyKilled;

		// Token: 0x040125F8 RID: 75256
		[Token(Token = "0x40125F8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnEnemyReachExit;

		// Token: 0x040125F9 RID: 75257
		[Token(Token = "0x40125F9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnNewSummonedEnemyReachExit;

		// Token: 0x040125FA RID: 75258
		[Token(Token = "0x40125FA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnManagedEnemyReachExit;

		// Token: 0x040125FB RID: 75259
		[Token(Token = "0x40125FB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetEnemyEscapedCount;

		// Token: 0x040125FC RID: 75260
		[Token(Token = "0x40125FC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
