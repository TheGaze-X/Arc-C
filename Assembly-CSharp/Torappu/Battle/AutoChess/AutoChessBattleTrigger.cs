using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x020026FA RID: 9978
	[Token(Token = "0x20026FA")]
	public class AutoChessBattleTrigger : IHotfixable
	{
		// Token: 0x060103AD RID: 66477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60103AD")]
		[Address(RVA = "0x7D5620", Offset = "0x7D4220", VA = "0x1807D5620")]
		public IEnumerator AutoTrigger()
		{
			return null;
		}

		// Token: 0x060103AE RID: 66478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103AE")]
		[Address(RVA = "0x7D6B30", Offset = "0x7D5730", VA = "0x1807D6B30")]
		private void _OnUnitBorn(object obj)
		{
		}

		// Token: 0x060103AF RID: 66479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103AF")]
		[Address(RVA = "0x7D5840", Offset = "0x7D4440", VA = "0x1807D5840")]
		public void StartBattle()
		{
		}

		// Token: 0x060103B0 RID: 66480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103B0")]
		[Address(RVA = "0x7D56C0", Offset = "0x7D42C0", VA = "0x1807D56C0")]
		public void FinishBattle()
		{
		}

		// Token: 0x060103B1 RID: 66481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103B1")]
		[Address(RVA = "0x7D8230", Offset = "0x7D6E30", VA = "0x1807D8230")]
		private void _TryTriggerAvailableSkills()
		{
		}

		// Token: 0x060103B2 RID: 66482 RVA: 0x00062F88 File Offset: 0x00061188
		[Token(Token = "0x60103B2")]
		[Address(RVA = "0x7D6400", Offset = "0x7D5000", VA = "0x1807D6400")]
		private AutoChessSkillTriggerType _GetAutoChessSkillTriggerType(Character character)
		{
			return AutoChessSkillTriggerType.DEFAULT;
		}

		// Token: 0x060103B3 RID: 66483 RVA: 0x00062FA0 File Offset: 0x000611A0
		[Token(Token = "0x60103B3")]
		[Address(RVA = "0x7D61F0", Offset = "0x7D4DF0", VA = "0x1807D61F0")]
		private bool _DoDefaultCheck(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103B4 RID: 66484 RVA: 0x00062FB8 File Offset: 0x000611B8
		[Token(Token = "0x60103B4")]
		[Address(RVA = "0x7D8580", Offset = "0x7D7180", VA = "0x1807D8580")]
		private bool _TryTriggerSkill(Character character, AutoChessSkillTriggerType type)
		{
			return default(bool);
		}

		// Token: 0x060103B5 RID: 66485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103B5")]
		[Address(RVA = "0x7D80F0", Offset = "0x7D6CF0", VA = "0x1807D80F0")]
		private void _TryStopSkill(Character character)
		{
		}

		// Token: 0x060103B6 RID: 66486 RVA: 0x00062FD0 File Offset: 0x000611D0
		[Token(Token = "0x60103B6")]
		[Address(RVA = "0x7D6E70", Offset = "0x7D5A70", VA = "0x1807D6E70")]
		private bool _TrySearchTarget(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103B7 RID: 66487 RVA: 0x00062FE8 File Offset: 0x000611E8
		[Token(Token = "0x60103B7")]
		[Address(RVA = "0x7D5E10", Offset = "0x7D4A10", VA = "0x1807D5E10")]
		private bool _DefaultTriggerSkill(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103B8 RID: 66488 RVA: 0x00063000 File Offset: 0x00061200
		[Token(Token = "0x60103B8")]
		[Address(RVA = "0x7D6350", Offset = "0x7D4F50", VA = "0x1807D6350")]
		private bool _GdglowSearchEnemy(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103B9 RID: 66489 RVA: 0x00063018 File Offset: 0x00061218
		[Token(Token = "0x60103B9")]
		[Address(RVA = "0x7D7970", Offset = "0x7D6570", VA = "0x1807D7970")]
		private bool _TrySearchWithCustomRange_FindAlly(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103BA RID: 66490 RVA: 0x00063030 File Offset: 0x00061230
		[Token(Token = "0x60103BA")]
		[Address(RVA = "0x7D7D30", Offset = "0x7D6930", VA = "0x1807D7D30")]
		private bool _TrySearchWithCustomRange_FindEnemy(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103BB RID: 66491 RVA: 0x00063048 File Offset: 0x00061248
		[Token(Token = "0x60103BB")]
		[Address(RVA = "0x7D75A0", Offset = "0x7D61A0", VA = "0x1807D75A0")]
		private bool _TrySearchUseSkillRangeToShow_FindEnemy(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103BC RID: 66492 RVA: 0x00063060 File Offset: 0x00061260
		[Token(Token = "0x60103BC")]
		[Address(RVA = "0x7D7190", Offset = "0x7D5D90", VA = "0x1807D7190")]
		private bool _TrySearchUseSkillRangeToShow_FindAlly(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103BD RID: 66493 RVA: 0x00063078 File Offset: 0x00061278
		[Token(Token = "0x60103BD")]
		[Address(RVA = "0x7D8F10", Offset = "0x7D7B10", VA = "0x1807D8F10")]
		private bool _TryUsingSkillTypeMlyssWtrman(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103BE RID: 66494 RVA: 0x00063090 File Offset: 0x00061290
		[Token(Token = "0x60103BE")]
		[Address(RVA = "0x7D66E0", Offset = "0x7D52E0", VA = "0x1807D66E0")]
		private bool _GetMlyssCopiedTargetInstId(Character character, out int copiedChess)
		{
			return default(bool);
		}

		// Token: 0x060103BF RID: 66495 RVA: 0x000630A8 File Offset: 0x000612A8
		[Token(Token = "0x60103BF")]
		[Address(RVA = "0x7D6A10", Offset = "0x7D5610", VA = "0x1807D6A10")]
		private int _GetMlyssTokenToGridPosPriority(GridPosition tokenPos, GridPosition targetPos, int rowMax, int colMax)
		{
			return 0;
		}

		// Token: 0x060103C0 RID: 66496 RVA: 0x000630C0 File Offset: 0x000612C0
		[Token(Token = "0x60103C0")]
		[Address(RVA = "0x7D8D60", Offset = "0x7D7960", VA = "0x1807D8D60")]
		private bool _TryUsingSkillTypeMarcilS2(Character character)
		{
			return default(bool);
		}

		// Token: 0x060103C1 RID: 66497 RVA: 0x000630D8 File Offset: 0x000612D8
		[Token(Token = "0x60103C1")]
		[Address(RVA = "0x7D8BA0", Offset = "0x7D77A0", VA = "0x1807D8BA0")]
		private bool _TryUsingMlyssWtrmanSkill(Character character, int copiedChess)
		{
			return default(bool);
		}

		// Token: 0x060103C2 RID: 66498 RVA: 0x000630F0 File Offset: 0x000612F0
		[Token(Token = "0x60103C2")]
		[Address(RVA = "0x7D5C30", Offset = "0x7D4830", VA = "0x1807D5C30")]
		private bool _CheckToggleSkill(BasicSkill skill)
		{
			return default(bool);
		}

		// Token: 0x060103C3 RID: 66499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103C3")]
		[Address(RVA = "0x7D6C90", Offset = "0x7D5890", VA = "0x1807D6C90")]
		private void _TryDeployAvailableCharacter()
		{
		}

		// Token: 0x060103C4 RID: 66500 RVA: 0x00063108 File Offset: 0x00061308
		[Token(Token = "0x60103C4")]
		[Address(RVA = "0x7D5A60", Offset = "0x7D4660", VA = "0x1807D5A60")]
		private bool _AutoDeploy(Deck deck, ChessInst chessInst, uint cardUid)
		{
			return default(bool);
		}

		// Token: 0x060103C5 RID: 66501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60103C5")]
		[Address(RVA = "0x7D9260", Offset = "0x7D7E60", VA = "0x1807D9260")]
		public AutoChessBattleTrigger()
		{
		}

		// Token: 0x04012295 RID: 74389
		[Token(Token = "0x4012295")]
		[FieldOffset(Offset = "0x10")]
		private bool m_disableDeployNextFrame;

		// Token: 0x04012296 RID: 74390
		[Token(Token = "0x4012296")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessDataIndexer m_indexer;

		// Token: 0x04012297 RID: 74391
		[Token(Token = "0x4012297")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessBattleMiscConfig m_miscConfig;

		// Token: 0x04012298 RID: 74392
		[Token(Token = "0x4012298")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<uint, int> m_blockSkillTicker;

		// Token: 0x04012299 RID: 74393
		[Token(Token = "0x4012299")]
		private const int BLOCK_SKILL_TICK = 10;

		// Token: 0x0401229A RID: 74394
		[Token(Token = "0x401229A")]
		private const float AUTO_TRIGGER_INTERVAL = 0.2f;

		// Token: 0x0401229B RID: 74395
		[Token(Token = "0x401229B")]
		[FieldOffset(Offset = "0x30")]
		private TargetOptions m_findEnemyTargetOptions;

		// Token: 0x0401229C RID: 74396
		[Token(Token = "0x401229C")]
		[FieldOffset(Offset = "0x90")]
		private TargetOptions m_findAllyTargetOptions;

		// Token: 0x0401229D RID: 74397
		[Token(Token = "0x401229D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AutoTrigger;

		// Token: 0x0401229E RID: 74398
		[Token(Token = "0x401229E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0401229F RID: 74399
		[Token(Token = "0x401229F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x040122A0 RID: 74400
		[Token(Token = "0x40122A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FinishBattle;

		// Token: 0x040122A1 RID: 74401
		[Token(Token = "0x40122A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryTriggerAvailableSkills;

		// Token: 0x040122A2 RID: 74402
		[Token(Token = "0x40122A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetAutoChessSkillTriggerType;

		// Token: 0x040122A3 RID: 74403
		[Token(Token = "0x40122A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoDefaultCheck;

		// Token: 0x040122A4 RID: 74404
		[Token(Token = "0x40122A4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerSkill;

		// Token: 0x040122A5 RID: 74405
		[Token(Token = "0x40122A5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryStopSkill;

		// Token: 0x040122A6 RID: 74406
		[Token(Token = "0x40122A6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TrySearchTarget;

		// Token: 0x040122A7 RID: 74407
		[Token(Token = "0x40122A7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DefaultTriggerSkill;

		// Token: 0x040122A8 RID: 74408
		[Token(Token = "0x40122A8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GdglowSearchEnemy;

		// Token: 0x040122A9 RID: 74409
		[Token(Token = "0x40122A9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TrySearchWithCustomRange_FindAlly;

		// Token: 0x040122AA RID: 74410
		[Token(Token = "0x40122AA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TrySearchWithCustomRange_FindEnemy;

		// Token: 0x040122AB RID: 74411
		[Token(Token = "0x40122AB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TrySearchUseSkillRangeToShow_FindEnemy;

		// Token: 0x040122AC RID: 74412
		[Token(Token = "0x40122AC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TrySearchUseSkillRangeToShow_FindAlly;

		// Token: 0x040122AD RID: 74413
		[Token(Token = "0x40122AD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryUsingSkillTypeMlyssWtrman;

		// Token: 0x040122AE RID: 74414
		[Token(Token = "0x40122AE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetMlyssCopiedTargetInstId;

		// Token: 0x040122AF RID: 74415
		[Token(Token = "0x40122AF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetMlyssTokenToGridPosPriority;

		// Token: 0x040122B0 RID: 74416
		[Token(Token = "0x40122B0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryUsingSkillTypeMarcilS2;

		// Token: 0x040122B1 RID: 74417
		[Token(Token = "0x40122B1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryUsingMlyssWtrmanSkill;

		// Token: 0x040122B2 RID: 74418
		[Token(Token = "0x40122B2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckToggleSkill;

		// Token: 0x040122B3 RID: 74419
		[Token(Token = "0x40122B3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryDeployAvailableCharacter;

		// Token: 0x040122B4 RID: 74420
		[Token(Token = "0x40122B4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__AutoDeploy;

		// Token: 0x040122B5 RID: 74421
		[Token(Token = "0x40122B5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
