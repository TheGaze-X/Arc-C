using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A5D RID: 10845
	[Token(Token = "0x2002A5D")]
	public class SandboxBattleDataController : IHotfixable
	{
		// Token: 0x0601201C RID: 73756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601201C")]
		[Address(RVA = "0xA08300", Offset = "0xA06F00", VA = "0x180A08300")]
		public SandboxBattleDataController(GameModeFactory.SandboxGameMode gameMode, SandboxBattleManager manager)
		{
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x0601201D RID: 73757 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0601201E RID: 73758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000072")]
		public event Action<string, int> onItemCollect
		{
			[Token(Token = "0x601201D")]
			[Address(RVA = "0xA08740", Offset = "0xA07340", VA = "0x180A08740")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x601201E")]
			[Address(RVA = "0xA08910", Offset = "0xA07510", VA = "0x180A08910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0601201F RID: 73759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002791")]
		public SandboxOutput output
		{
			[Token(Token = "0x601201F")]
			[Address(RVA = "0xA088A0", Offset = "0xA074A0", VA = "0x180A088A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x06012020 RID: 73760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002792")]
		public Dictionary<SandboxEntityStatusKey, SandboxEntityStatusValue> entityStatus
		{
			[Token(Token = "0x6012020")]
			[Address(RVA = "0xA08840", Offset = "0xA07440", VA = "0x180A08840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012021 RID: 73761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012021")]
		[Address(RVA = "0xA05490", Offset = "0xA04090", VA = "0x180A05490")]
		public void Init()
		{
		}

		// Token: 0x06012022 RID: 73762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012022")]
		[Address(RVA = "0xA075E0", Offset = "0xA061E0", VA = "0x180A075E0")]
		private void _InitInputStatus()
		{
		}

		// Token: 0x06012023 RID: 73763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012023")]
		[Address(RVA = "0xA062A0", Offset = "0xA04EA0", VA = "0x180A062A0")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06012024 RID: 73764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012024")]
		[Address(RVA = "0xA05750", Offset = "0xA04350", VA = "0x180A05750")]
		public void OnFetchGameOverOutput()
		{
		}

		// Token: 0x06012025 RID: 73765 RVA: 0x0006E0E8 File Offset: 0x0006C2E8
		[Token(Token = "0x6012025")]
		[Address(RVA = "0xA04830", Offset = "0xA03430", VA = "0x180A04830")]
		public bool FetchBossRecordedStatus(string rushEnemyUid, string targetKey, out SandboxRushBossStatus status)
		{
			return default(bool);
		}

		// Token: 0x06012026 RID: 73766 RVA: 0x0006E100 File Offset: 0x0006C300
		[Token(Token = "0x6012026")]
		[Address(RVA = "0xA04D50", Offset = "0xA03950", VA = "0x180A04D50")]
		public bool FetchUniEnemyRecordedStatus(string targetKey, out SandboxV2UniEnemyStatus status)
		{
			return default(bool);
		}

		// Token: 0x06012027 RID: 73767 RVA: 0x0006E118 File Offset: 0x0006C318
		[Token(Token = "0x6012027")]
		[Address(RVA = "0xA04ED0", Offset = "0xA03AD0", VA = "0x180A04ED0")]
		public bool FetchUnitRecordedStatus(SandboxEntityStatusKey targetKey, out SandboxEntityStatusValue status)
		{
			return default(bool);
		}

		// Token: 0x06012028 RID: 73768 RVA: 0x0006E130 File Offset: 0x0006C330
		[Token(Token = "0x6012028")]
		[Address(RVA = "0xA049C0", Offset = "0xA035C0", VA = "0x180A049C0")]
		public bool FetchPlacedItemRecordedStatus(SandboxPlacedItemStatusKey targetKey, out SandboxPlacedItemStatusValue status)
		{
			return default(bool);
		}

		// Token: 0x06012029 RID: 73769 RVA: 0x0006E148 File Offset: 0x0006C348
		[Token(Token = "0x6012029")]
		[Address(RVA = "0xA04B60", Offset = "0xA03760", VA = "0x180A04B60")]
		public bool FetchUniEnemyExtraInfo(string targetKey, out RareAnimalExtraInfo extraInfo)
		{
			return default(bool);
		}

		// Token: 0x0601202A RID: 73770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601202A")]
		[Address(RVA = "0xA067C0", Offset = "0xA053C0", VA = "0x180A067C0")]
		public void RecordUnitState(SandboxLevelDataProcessor levelDataProcessor, SandboxEntityStatusKey targetKey, SandboxEntityStatusValue newStatus)
		{
		}

		// Token: 0x0601202B RID: 73771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601202B")]
		[Address(RVA = "0xA06630", Offset = "0xA05230", VA = "0x180A06630")]
		public void RecordPlacedItemState(SandboxPlacedItemStatusKey targetKey, SandboxPlacedItemStatusValue newStatus)
		{
		}

		// Token: 0x0601202C RID: 73772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601202C")]
		[Address(RVA = "0xA06400", Offset = "0xA05000", VA = "0x180A06400")]
		public void RecordBossState(string enemyUid, string targetKey, SandboxRushBossStatus newStatus)
		{
		}

		// Token: 0x0601202D RID: 73773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601202D")]
		[Address(RVA = "0xA06700", Offset = "0xA05300", VA = "0x180A06700")]
		public void RecordUniEnemyState(string targetKey, SandboxV2UniEnemyStatus newStatus)
		{
		}

		// Token: 0x0601202E RID: 73774 RVA: 0x0006E160 File Offset: 0x0006C360
		[Token(Token = "0x601202E")]
		[Address(RVA = "0xA04550", Offset = "0xA03150", VA = "0x180A04550")]
		public bool CheckSpecialUniEnemy(string enemyId)
		{
			return default(bool);
		}

		// Token: 0x0601202F RID: 73775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601202F")]
		[Address(RVA = "0xA069C0", Offset = "0xA055C0", VA = "0x180A069C0")]
		public void RecordUsingConstructItem(Character character)
		{
		}

		// Token: 0x06012030 RID: 73776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012030")]
		[Address(RVA = "0xA055F0", Offset = "0xA041F0", VA = "0x180A055F0")]
		public void MarkRushEnemyDead(RushEnemy rushEnemy)
		{
		}

		// Token: 0x06012031 RID: 73777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012031")]
		[Address(RVA = "0xA056B0", Offset = "0xA042B0", VA = "0x180A056B0")]
		public void MarkRushEnemyReachExit(RushEnemy rushEnemy)
		{
		}

		// Token: 0x06012032 RID: 73778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012032")]
		[Address(RVA = "0xA054F0", Offset = "0xA040F0", VA = "0x180A054F0")]
		public void MarkEnemyNeedRefreshDead(LevelData.ActionID actionId)
		{
		}

		// Token: 0x06012033 RID: 73779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012033")]
		[Address(RVA = "0xA047B0", Offset = "0xA033B0", VA = "0x180A047B0")]
		public void ConstructSaveLevelRes()
		{
		}

		// Token: 0x06012034 RID: 73780 RVA: 0x0006E178 File Offset: 0x0006C378
		[Token(Token = "0x6012034")]
		[Address(RVA = "0xA052B0", Offset = "0xA03EB0", VA = "0x180A052B0")]
		public int GetResCountByID(string resId, bool thisLevel)
		{
			return 0;
		}

		// Token: 0x06012035 RID: 73781 RVA: 0x0006E190 File Offset: 0x0006C390
		[Token(Token = "0x6012035")]
		[Address(RVA = "0xA07A80", Offset = "0xA06680", VA = "0x180A07A80")]
		private uint _PackedResDictKey(Entity entity)
		{
			return 0U;
		}

		// Token: 0x06012036 RID: 73782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012036")]
		[Address(RVA = "0xA072D0", Offset = "0xA05ED0", VA = "0x180A072D0")]
		public int[] SandboxEntityPackedItems(Entity entity)
		{
			return null;
		}

		// Token: 0x06012037 RID: 73783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012037")]
		[Address(RVA = "0xA07E80", Offset = "0xA06A80", VA = "0x180A07E80")]
		private void _SandboxEntityPackItem(Entity entity, ResPackType type, int count = 1)
		{
		}

		// Token: 0x06012038 RID: 73784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012038")]
		[Address(RVA = "0xA07BB0", Offset = "0xA067B0", VA = "0x180A07BB0")]
		private void _SandboxCollectItem(string itemId, int count = 1, bool withToast = true, bool withSound = true)
		{
		}

		// Token: 0x06012039 RID: 73785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012039")]
		[Address(RVA = "0xA071C0", Offset = "0xA05DC0", VA = "0x180A071C0")]
		public void SandboxEntityDropItem(Entity entity, ResDropSourceType type)
		{
		}

		// Token: 0x0601203A RID: 73786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601203A")]
		[Address(RVA = "0xA06F30", Offset = "0xA05B30", VA = "0x180A06F30")]
		public void SandboxEntityDropItem(Entity entity, string itemId, int count)
		{
		}

		// Token: 0x0601203B RID: 73787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601203B")]
		[Address(RVA = "0xA06E90", Offset = "0xA05A90", VA = "0x180A06E90")]
		public void SandboxCollectItem(string itemId, int count)
		{
		}

		// Token: 0x0601203C RID: 73788 RVA: 0x0006E1A8 File Offset: 0x0006C3A8
		[Token(Token = "0x601203C")]
		[Address(RVA = "0xA04620", Offset = "0xA03220", VA = "0x180A04620")]
		public bool CollectPackedRes(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0601203D RID: 73789 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
		[Token(Token = "0x601203D")]
		[Address(RVA = "0xA073F0", Offset = "0xA05FF0", VA = "0x180A073F0")]
		public bool TransferAllPackedRes(Entity fromTarget, Entity toTarget)
		{
			return default(bool);
		}

		// Token: 0x0601203E RID: 73790 RVA: 0x0006E1D8 File Offset: 0x0006C3D8
		[Token(Token = "0x601203E")]
		[Address(RVA = "0xA081A0", Offset = "0xA06DA0", VA = "0x180A081A0")]
		private int _TransferPackedRes(Entity fromTarget, Entity toTarget, ResPackType type, int transferCount)
		{
			return 0;
		}

		// Token: 0x0601203F RID: 73791 RVA: 0x0006E1F0 File Offset: 0x0006C3F0
		[Token(Token = "0x601203F")]
		[Address(RVA = "0xA05100", Offset = "0xA03D00", VA = "0x180A05100")]
		public int GetPackedResMaxCount(Entity entity)
		{
			return 0;
		}

		// Token: 0x06012040 RID: 73792 RVA: 0x0006E208 File Offset: 0x0006C408
		[Token(Token = "0x6012040")]
		[Address(RVA = "0xA04FA0", Offset = "0xA03BA0", VA = "0x180A04FA0")]
		public int GetPackedResMaxCount(Deck.Card card)
		{
			return 0;
		}

		// Token: 0x06012041 RID: 73793 RVA: 0x0006E220 File Offset: 0x0006C420
		[Token(Token = "0x6012041")]
		[Address(RVA = "0xA05210", Offset = "0xA03E10", VA = "0x180A05210")]
		public int GetPackedResRestCount(Entity entity)
		{
			return 0;
		}

		// Token: 0x06012042 RID: 73794 RVA: 0x0006E238 File Offset: 0x0006C438
		[Token(Token = "0x6012042")]
		[Address(RVA = "0xA05380", Offset = "0xA03F80", VA = "0x180A05380")]
		public int GetTotalPackedResCount(Entity entity)
		{
			return 0;
		}

		// Token: 0x06012043 RID: 73795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012043")]
		[Address(RVA = "0xA06DE0", Offset = "0xA059E0", VA = "0x180A06DE0")]
		public void SandboxAvgCollectItem(string itemId, int count, bool withToast = true)
		{
		}

		// Token: 0x06012044 RID: 73796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012044")]
		[Address(RVA = "0xA06C60", Offset = "0xA05860", VA = "0x180A06C60")]
		public void SandboxAvgCollectItemList(List<UIItemViewModel> models)
		{
		}

		// Token: 0x06012045 RID: 73797 RVA: 0x0006E250 File Offset: 0x0006C450
		[Token(Token = "0x6012045")]
		[Address(RVA = "0xA04430", Offset = "0xA03030", VA = "0x180A04430")]
		public bool CheckItemCount(string itemId, int count, bool containsEq)
		{
			return default(bool);
		}

		// Token: 0x04014566 RID: 83302
		[Token(Token = "0x4014566")]
		[FieldOffset(Offset = "0x10")]
		private SandboxInput m_input;

		// Token: 0x04014567 RID: 83303
		[Token(Token = "0x4014567")]
		[FieldOffset(Offset = "0x18")]
		private SandboxOutput m_output;

		// Token: 0x04014568 RID: 83304
		[Token(Token = "0x4014568")]
		[FieldOffset(Offset = "0x20")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x04014569 RID: 83305
		[Token(Token = "0x4014569")]
		[FieldOffset(Offset = "0x28")]
		private SandboxBattleManager m_manager;

		// Token: 0x0401456A RID: 83306
		[Token(Token = "0x401456A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> m_resCollectedTotal;

		// Token: 0x0401456B RID: 83307
		[Token(Token = "0x401456B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, int> m_resCollectedThisLevel;

		// Token: 0x0401456C RID: 83308
		[Token(Token = "0x401456C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, int[]> m_resCollectedOnEnity;

		// Token: 0x0401456D RID: 83309
		[Token(Token = "0x401456D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, int> m_entityDroppedThisLevel;

		// Token: 0x0401456E RID: 83310
		[Token(Token = "0x401456E")]
		[FieldOffset(Offset = "0x50")]
		private List<RushEnemy> m_rushEnemyReachExit;

		// Token: 0x0401456F RID: 83311
		[Token(Token = "0x401456F")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<LevelData.ActionID, int> m_killedEnemies;

		// Token: 0x04014570 RID: 83312
		[Token(Token = "0x4014570")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<SandboxEntityStatusKey, SandboxEntityStatusValue> m_entityStatus;

		// Token: 0x04014571 RID: 83313
		[Token(Token = "0x4014571")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<SandboxPlacedItemStatusKey, SandboxPlacedItemStatusValue> m_placedItemStatus;

		// Token: 0x04014572 RID: 83314
		[Token(Token = "0x4014572")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<SandboxPlacedItemStatusKey, SandboxPlacedItemStatusValue> m_outPlacedItemStatus;

		// Token: 0x04014573 RID: 83315
		[Token(Token = "0x4014573")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, int> m_usedConstructItems;

		// Token: 0x04014574 RID: 83316
		[Token(Token = "0x4014574")]
		[FieldOffset(Offset = "0x80")]
		private List<string> m_shinyUniEnemy;

		// Token: 0x04014576 RID: 83318
		[Token(Token = "0x4014576")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04014577 RID: 83319
		[Token(Token = "0x4014577")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_add_onItemCollect;

		// Token: 0x04014578 RID: 83320
		[Token(Token = "0x4014578")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_remove_onItemCollect;

		// Token: 0x04014579 RID: 83321
		[Token(Token = "0x4014579")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_output;

		// Token: 0x0401457A RID: 83322
		[Token(Token = "0x401457A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_entityStatus;

		// Token: 0x0401457B RID: 83323
		[Token(Token = "0x401457B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401457C RID: 83324
		[Token(Token = "0x401457C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitInputStatus;

		// Token: 0x0401457D RID: 83325
		[Token(Token = "0x401457D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0401457E RID: 83326
		[Token(Token = "0x401457E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFetchGameOverOutput;

		// Token: 0x0401457F RID: 83327
		[Token(Token = "0x401457F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FetchBossRecordedStatus;

		// Token: 0x04014580 RID: 83328
		[Token(Token = "0x4014580")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FetchUniEnemyRecordedStatus;

		// Token: 0x04014581 RID: 83329
		[Token(Token = "0x4014581")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FetchUnitRecordedStatus;

		// Token: 0x04014582 RID: 83330
		[Token(Token = "0x4014582")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FetchPlacedItemRecordedStatus;

		// Token: 0x04014583 RID: 83331
		[Token(Token = "0x4014583")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FetchUniEnemyExtraInfo;

		// Token: 0x04014584 RID: 83332
		[Token(Token = "0x4014584")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RecordUnitState;

		// Token: 0x04014585 RID: 83333
		[Token(Token = "0x4014585")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RecordPlacedItemState;

		// Token: 0x04014586 RID: 83334
		[Token(Token = "0x4014586")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RecordBossState;

		// Token: 0x04014587 RID: 83335
		[Token(Token = "0x4014587")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RecordUniEnemyState;

		// Token: 0x04014588 RID: 83336
		[Token(Token = "0x4014588")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckSpecialUniEnemy;

		// Token: 0x04014589 RID: 83337
		[Token(Token = "0x4014589")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RecordUsingConstructItem;

		// Token: 0x0401458A RID: 83338
		[Token(Token = "0x401458A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_MarkRushEnemyDead;

		// Token: 0x0401458B RID: 83339
		[Token(Token = "0x401458B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_MarkRushEnemyReachExit;

		// Token: 0x0401458C RID: 83340
		[Token(Token = "0x401458C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_MarkEnemyNeedRefreshDead;

		// Token: 0x0401458D RID: 83341
		[Token(Token = "0x401458D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ConstructSaveLevelRes;

		// Token: 0x0401458E RID: 83342
		[Token(Token = "0x401458E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetResCountByID;

		// Token: 0x0401458F RID: 83343
		[Token(Token = "0x401458F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PackedResDictKey;

		// Token: 0x04014590 RID: 83344
		[Token(Token = "0x4014590")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SandboxEntityPackedItems;

		// Token: 0x04014591 RID: 83345
		[Token(Token = "0x4014591")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SandboxEntityPackItem;

		// Token: 0x04014592 RID: 83346
		[Token(Token = "0x4014592")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SandboxCollectItem;

		// Token: 0x04014593 RID: 83347
		[Token(Token = "0x4014593")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_SandboxEntityDropItem;

		// Token: 0x04014594 RID: 83348
		[Token(Token = "0x4014594")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix1_SandboxEntityDropItem;

		// Token: 0x04014595 RID: 83349
		[Token(Token = "0x4014595")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SandboxCollectItem;

		// Token: 0x04014596 RID: 83350
		[Token(Token = "0x4014596")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CollectPackedRes;

		// Token: 0x04014597 RID: 83351
		[Token(Token = "0x4014597")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_TransferAllPackedRes;

		// Token: 0x04014598 RID: 83352
		[Token(Token = "0x4014598")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TransferPackedRes;

		// Token: 0x04014599 RID: 83353
		[Token(Token = "0x4014599")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetPackedResMaxCount;

		// Token: 0x0401459A RID: 83354
		[Token(Token = "0x401459A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix1_GetPackedResMaxCount;

		// Token: 0x0401459B RID: 83355
		[Token(Token = "0x401459B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetPackedResRestCount;

		// Token: 0x0401459C RID: 83356
		[Token(Token = "0x401459C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetTotalPackedResCount;

		// Token: 0x0401459D RID: 83357
		[Token(Token = "0x401459D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_SandboxAvgCollectItem;

		// Token: 0x0401459E RID: 83358
		[Token(Token = "0x401459E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_SandboxAvgCollectItemList;

		// Token: 0x0401459F RID: 83359
		[Token(Token = "0x401459F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckItemCount;
	}
}
