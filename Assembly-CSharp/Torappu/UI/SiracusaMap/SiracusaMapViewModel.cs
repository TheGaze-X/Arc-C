using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003FA4 RID: 16292
	[Token(Token = "0x2003FA4")]
	public class SiracusaMapViewModel : IHotfixable, IStageSelectHandler
	{
		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x06019459 RID: 103513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C62")]
		public Dictionary<string, SiracusaMapZoneInfoViewModel> mapZoneInfoViewModels
		{
			[Token(Token = "0x6019459")]
			[Address(RVA = "0x120DBA0", Offset = "0x120C7A0", VA = "0x18120DBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0601945A RID: 103514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C63")]
		public Dictionary<string, List<SiracusaMapStageInfoViewModel>> zoneStageInfoMap
		{
			[Token(Token = "0x601945A")]
			[Address(RVA = "0x120DED0", Offset = "0x120CAD0", VA = "0x18120DED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0601945B RID: 103515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C64")]
		public Dictionary<string, SiracusaData.AreaData> lockedAreaMap
		{
			[Token(Token = "0x601945B")]
			[Address(RVA = "0x120DB40", Offset = "0x120C740", VA = "0x18120DB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0601945C RID: 103516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C65")]
		public Dictionary<string, SiracusaMapMapNodeViewModel> nodeViewModels
		{
			[Token(Token = "0x601945C")]
			[Address(RVA = "0x120DC00", Offset = "0x120C800", VA = "0x18120DC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0601945D RID: 103517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C66")]
		public List<string> curTaskPointIds
		{
			[Token(Token = "0x601945D")]
			[Address(RVA = "0x120DAE0", Offset = "0x120C6E0", VA = "0x18120DAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601945E RID: 103518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601945E")]
		[Address(RVA = "0x12098B0", Offset = "0x12084B0", VA = "0x1812098B0")]
		public void Init(SiracusaMapViewModel.InitParam param)
		{
		}

		// Token: 0x0601945F RID: 103519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601945F")]
		[Address(RVA = "0x120A4A0", Offset = "0x12090A0", VA = "0x18120A4A0")]
		public void UpdateModelWithPlayerData(PlayerSiracusaMap playerSiracusa)
		{
		}

		// Token: 0x06019460 RID: 103520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019460")]
		[Address(RVA = "0x1209A40", Offset = "0x1208640", VA = "0x181209A40")]
		public void ReBuildNodeViewModels(SiracusaMapViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x06019461 RID: 103521 RVA: 0x0009D8A8 File Offset: 0x0009BAA8
		[Token(Token = "0x6019461")]
		[Address(RVA = "0x120A050", Offset = "0x1208C50", VA = "0x18120A050")]
		public bool SelectPoint(string pointId, bool needChangeNodeShowSelected = true)
		{
			return default(bool);
		}

		// Token: 0x06019462 RID: 103522 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		[Token(Token = "0x6019462")]
		[Address(RVA = "0x12099D0", Offset = "0x12085D0", VA = "0x1812099D0")]
		public bool IsSelectingNormal()
		{
			return default(bool);
		}

		// Token: 0x06019463 RID: 103523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019463")]
		[Address(RVA = "0x12096E0", Offset = "0x12082E0", VA = "0x1812096E0")]
		public SiracusaMapViewModel.NormalStageRelation GetNormalStageRelation(string stageId)
		{
			return null;
		}

		// Token: 0x06019464 RID: 103524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019464")]
		[Address(RVA = "0x120A1D0", Offset = "0x1208DD0", VA = "0x18120A1D0")]
		public IEnumerator<SiracusaMapViewModel.StageViewModelStruct> TranverseNormalStages([Optional] Func<StageViewModel, bool> picker)
		{
			return null;
		}

		// Token: 0x06019465 RID: 103525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019465")]
		[Address(RVA = "0x120A2A0", Offset = "0x1208EA0", VA = "0x18120A2A0")]
		public string TryGetCurPointIdWithStageId(string stageId)
		{
			return null;
		}

		// Token: 0x06019466 RID: 103526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019466")]
		[Address(RVA = "0x120B870", Offset = "0x120A470", VA = "0x18120B870")]
		private void _LoadGameDataZoneInfo()
		{
		}

		// Token: 0x06019467 RID: 103527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019467")]
		[Address(RVA = "0x120C240", Offset = "0x120AE40", VA = "0x18120C240")]
		private void _LoadValidStageData()
		{
		}

		// Token: 0x06019468 RID: 103528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019468")]
		[Address(RVA = "0x120D4A0", Offset = "0x120C0A0", VA = "0x18120D4A0")]
		private void _UpdateShowAreaAndPoints(PlayerSiracusaMap playerSiracusa)
		{
		}

		// Token: 0x06019469 RID: 103529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019469")]
		[Address(RVA = "0x120BCC0", Offset = "0x120A8C0", VA = "0x18120BCC0")]
		private void _LoadStageInfoFromPlayer()
		{
		}

		// Token: 0x0601946A RID: 103530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601946A")]
		[Address(RVA = "0x120D070", Offset = "0x120BC70", VA = "0x18120D070")]
		private void _ReloadZoneInfoMap()
		{
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601946B")]
		[Address(RVA = "0x120B1F0", Offset = "0x1209DF0", VA = "0x18120B1F0")]
		private void _CalcTaskNodesWhenRebuild(SiracusaMapViewModel.UpdateParam updateParam, ref List<string> showPoints, ref List<string> selectNodes, out Dictionary<string, SiracusaMapViewModel.TaskNodeStruct> taskNodeMap)
		{
		}

		// Token: 0x0601946C RID: 103532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601946C")]
		[Address(RVA = "0x120AA50", Offset = "0x1209650", VA = "0x18120AA50")]
		private static void _CalcSmallMapTaskNodesWhenRebuild(SiracusaMapViewModel.UpdateParam updateParam, out List<string> showPoints, ref List<string> selectNodes, ref Dictionary<string, SiracusaMapViewModel.TaskNodeStruct> taskNodeMap)
		{
		}

		// Token: 0x0601946D RID: 103533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601946D")]
		[Address(RVA = "0x120A530", Offset = "0x1209130", VA = "0x18120A530")]
		private static void _CalcBigMapTaskNodesWhenRebuild(SiracusaMapViewModel.UpdateParam updateParam, ref Dictionary<string, SiracusaMapViewModel.TaskNodeStruct> taskNodeMap)
		{
		}

		// Token: 0x0601946E RID: 103534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601946E")]
		[Address(RVA = "0x120CB60", Offset = "0x120B760", VA = "0x18120CB60")]
		private void _ReloadNodeViewModelWithPointInfo(List<string> pointIds, [Optional] List<string> selectPoints, [Optional] Dictionary<string, SiracusaMapViewModel.TaskNodeStruct> taskNodes)
		{
		}

		// Token: 0x0601946F RID: 103535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601946F")]
		[Address(RVA = "0x120B4B0", Offset = "0x120A0B0", VA = "0x18120B4B0")]
		private static SiracusaMapStageInfoViewModel _GeneStageInfoViewModel(Dictionary<string, PlayerStage> playerStages, SiracusaMapViewModel.StageViewModelStruct stageViewModelStruct)
		{
			return null;
		}

		// Token: 0x06019470 RID: 103536 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
		[Token(Token = "0x6019470")]
		[Address(RVA = "0x120BBB0", Offset = "0x120A7B0", VA = "0x18120BBB0")]
		private static int _LoadRankNum(SiracusaMapViewModel.StageViewModelStruct stageViewModelStruct, PlayerStageState normalPlayerStageState, PlayerStageState hardPlayerStageState)
		{
			return 0;
		}

		// Token: 0x06019471 RID: 103537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019471")]
		[Address(RVA = "0x120B7A0", Offset = "0x120A3A0", VA = "0x18120B7A0")]
		private string _GetCornerIconIdFromZone(StageViewModel stageViewModel)
		{
			return null;
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x06019472 RID: 103538 RVA: 0x0009D8F0 File Offset: 0x0009BAF0
		[Token(Token = "0x17003C67")]
		public SpecialStageType stageSelectedType
		{
			[Token(Token = "0x6019472")]
			[Address(RVA = "0x120DE50", Offset = "0x120CA50", VA = "0x18120DE50", Slot = "4")]
			get
			{
				return SpecialStageType.NORMAL;
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x06019473 RID: 103539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C68")]
		public SiracusaMapMapNodeViewModel selectedNodeViewModel
		{
			[Token(Token = "0x6019473")]
			[Address(RVA = "0x120DC60", Offset = "0x120C860", VA = "0x18120DC60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019474 RID: 103540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019474")]
		[Address(RVA = "0x1209460", Offset = "0x1208060", VA = "0x181209460", Slot = "5")]
		public StageViewModel FindNormalStageFromSpecialStage(string notNormalStageId, SpecialStageType sourceStageType)
		{
			return null;
		}

		// Token: 0x06019475 RID: 103541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019475")]
		[Address(RVA = "0x1209590", Offset = "0x1208190", VA = "0x181209590", Slot = "6")]
		public StageViewModel FindSpecialStageFromNormal(string normalStageId, SpecialStageType targetStageType)
		{
			return null;
		}

		// Token: 0x06019476 RID: 103542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019476")]
		[Address(RVA = "0x1209770", Offset = "0x1208370", VA = "0x181209770", Slot = "7")]
		public StageViewModel GetStageByType(SpecialStageType stageType)
		{
			return null;
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x06019477 RID: 103543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C69")]
		public StageViewModel selectedStageHard
		{
			[Token(Token = "0x6019477")]
			[Address(RVA = "0x120DCC0", Offset = "0x120C8C0", VA = "0x18120DCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x06019478 RID: 103544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C6A")]
		public StageViewModel selectedStageNormal
		{
			[Token(Token = "0x6019478")]
			[Address(RVA = "0x120DD40", Offset = "0x120C940", VA = "0x18120DD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x06019479 RID: 103545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C6B")]
		public StageViewModel selectedStage
		{
			[Token(Token = "0x6019479")]
			[Address(RVA = "0x120DDC0", Offset = "0x120C9C0", VA = "0x18120DDC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601947A RID: 103546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601947A")]
		[Address(RVA = "0x120D740", Offset = "0x120C340", VA = "0x18120D740")]
		public SiracusaMapViewModel()
		{
		}

		// Token: 0x0401F5FD RID: 128509
		[Token(Token = "0x401F5FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_groupId;

		// Token: 0x0401F5FE RID: 128510
		[Token(Token = "0x401F5FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isRetro;

		// Token: 0x0401F5FF RID: 128511
		[Token(Token = "0x401F5FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Act21SideData m_actData;

		// Token: 0x0401F600 RID: 128512
		[Token(Token = "0x401F600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SiracusaData m_siracusaData;

		// Token: 0x0401F601 RID: 128513
		[Token(Token = "0x401F601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long m_enterTimeStamp;

		// Token: 0x0401F602 RID: 128514
		[Token(Token = "0x401F602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, SiracusaMapZoneInfoViewModel> m_mapZoneInfoDict;

		// Token: 0x0401F603 RID: 128515
		[Token(Token = "0x401F603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SiracusaMapViewModel.StageViewModelStruct> m_normalStageList;

		// Token: 0x0401F604 RID: 128516
		[Token(Token = "0x401F604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<SiracusaMapViewModel.StageViewModelStruct> m_taskStageList;

		// Token: 0x0401F605 RID: 128517
		[Token(Token = "0x401F605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ListDict<string, StageViewModel> m_stageViewModels;

		// Token: 0x0401F606 RID: 128518
		[Token(Token = "0x401F606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, SiracusaData.AreaData> m_lockedAreaMap;

		// Token: 0x0401F607 RID: 128519
		[Token(Token = "0x401F607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<string> m_showPointIdList;

		// Token: 0x0401F608 RID: 128520
		[Token(Token = "0x401F608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ListDict<string, SiracusaMapStageInfoViewModel> m_pointNormalStageInfoMap;

		// Token: 0x0401F609 RID: 128521
		[Token(Token = "0x401F609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, SiracusaMapViewModel.NormalStageRelation> m_normalStageRelations;

		// Token: 0x0401F60A RID: 128522
		[Token(Token = "0x401F60A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ListDict<string, List<SiracusaMapStageInfoViewModel>> m_pointTaskStageInfoMap;

		// Token: 0x0401F60B RID: 128523
		[Token(Token = "0x401F60B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, List<SiracusaMapStageInfoViewModel>> m_zoneStageInfoMap;

		// Token: 0x0401F60C RID: 128524
		[Token(Token = "0x401F60C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<string> m_taskPointIds;

		// Token: 0x0401F60D RID: 128525
		[Token(Token = "0x401F60D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<string, SiracusaMapMapNodeViewModel> m_nodeViewModels;

		// Token: 0x0401F60E RID: 128526
		[Token(Token = "0x401F60E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SiracusaMapMapNodeViewModel m_selectedNodeViewModel;

		// Token: 0x0401F60F RID: 128527
		[Token(Token = "0x401F60F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapZoneInfoViewModels;

		// Token: 0x0401F610 RID: 128528
		[Token(Token = "0x401F610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zoneStageInfoMap;

		// Token: 0x0401F611 RID: 128529
		[Token(Token = "0x401F611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lockedAreaMap;

		// Token: 0x0401F612 RID: 128530
		[Token(Token = "0x401F612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodeViewModels;

		// Token: 0x0401F613 RID: 128531
		[Token(Token = "0x401F613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curTaskPointIds;

		// Token: 0x0401F614 RID: 128532
		[Token(Token = "0x401F614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F615 RID: 128533
		[Token(Token = "0x401F615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateModelWithPlayerData;

		// Token: 0x0401F616 RID: 128534
		[Token(Token = "0x401F616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReBuildNodeViewModels;

		// Token: 0x0401F617 RID: 128535
		[Token(Token = "0x401F617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectPoint;

		// Token: 0x0401F618 RID: 128536
		[Token(Token = "0x401F618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsSelectingNormal;

		// Token: 0x0401F619 RID: 128537
		[Token(Token = "0x401F619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetNormalStageRelation;

		// Token: 0x0401F61A RID: 128538
		[Token(Token = "0x401F61A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TranverseNormalStages;

		// Token: 0x0401F61B RID: 128539
		[Token(Token = "0x401F61B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetCurPointIdWithStageId;

		// Token: 0x0401F61C RID: 128540
		[Token(Token = "0x401F61C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadGameDataZoneInfo;

		// Token: 0x0401F61D RID: 128541
		[Token(Token = "0x401F61D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadValidStageData;

		// Token: 0x0401F61E RID: 128542
		[Token(Token = "0x401F61E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateShowAreaAndPoints;

		// Token: 0x0401F61F RID: 128543
		[Token(Token = "0x401F61F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadStageInfoFromPlayer;

		// Token: 0x0401F620 RID: 128544
		[Token(Token = "0x401F620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ReloadZoneInfoMap;

		// Token: 0x0401F621 RID: 128545
		[Token(Token = "0x401F621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CalcTaskNodesWhenRebuild;

		// Token: 0x0401F622 RID: 128546
		[Token(Token = "0x401F622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CalcSmallMapTaskNodesWhenRebuild;

		// Token: 0x0401F623 RID: 128547
		[Token(Token = "0x401F623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CalcBigMapTaskNodesWhenRebuild;

		// Token: 0x0401F624 RID: 128548
		[Token(Token = "0x401F624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ReloadNodeViewModelWithPointInfo;

		// Token: 0x0401F625 RID: 128549
		[Token(Token = "0x401F625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GeneStageInfoViewModel;

		// Token: 0x0401F626 RID: 128550
		[Token(Token = "0x401F626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadRankNum;

		// Token: 0x0401F627 RID: 128551
		[Token(Token = "0x401F627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetCornerIconIdFromZone;

		// Token: 0x0401F628 RID: 128552
		[Token(Token = "0x401F628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_stageSelectedType;

		// Token: 0x0401F629 RID: 128553
		[Token(Token = "0x401F629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_selectedNodeViewModel;

		// Token: 0x0401F62A RID: 128554
		[Token(Token = "0x401F62A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_FindNormalStageFromSpecialStage;

		// Token: 0x0401F62B RID: 128555
		[Token(Token = "0x401F62B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_FindSpecialStageFromNormal;

		// Token: 0x0401F62C RID: 128556
		[Token(Token = "0x401F62C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetStageByType;

		// Token: 0x0401F62D RID: 128557
		[Token(Token = "0x401F62D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_selectedStageHard;

		// Token: 0x0401F62E RID: 128558
		[Token(Token = "0x401F62E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_selectedStageNormal;

		// Token: 0x0401F62F RID: 128559
		[Token(Token = "0x401F62F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_selectedStage;

		// Token: 0x0401F630 RID: 128560
		[Token(Token = "0x401F630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FA5 RID: 16293
		[Token(Token = "0x2003FA5")]
		public struct InitParam
		{
			// Token: 0x0401F631 RID: 128561
			[Token(Token = "0x401F631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string groupId;

			// Token: 0x0401F632 RID: 128562
			[Token(Token = "0x401F632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isRetro;

			// Token: 0x0401F633 RID: 128563
			[Token(Token = "0x401F633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Act21SideData actData;

			// Token: 0x0401F634 RID: 128564
			[Token(Token = "0x401F634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SiracusaData siracusaData;

			// Token: 0x0401F635 RID: 128565
			[Token(Token = "0x401F635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public long enterTimeStamp;
		}

		// Token: 0x02003FA6 RID: 16294
		[Token(Token = "0x2003FA6")]
		public struct UpdateParam
		{
			// Token: 0x0401F636 RID: 128566
			[Token(Token = "0x401F636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SiracusaMapPanelMapViewModel.MapState mapState;

			// Token: 0x0401F637 RID: 128567
			[Token(Token = "0x401F637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool isNormalNaviSelected;

			// Token: 0x0401F638 RID: 128568
			[Token(Token = "0x401F638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SiracusaCharTaskRingModel targetRingModel;

			// Token: 0x0401F639 RID: 128569
			[Token(Token = "0x401F639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string charCardId;

			// Token: 0x0401F63A RID: 128570
			[Token(Token = "0x401F63A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Color charThemeColor;

			// Token: 0x0401F63B RID: 128571
			[Token(Token = "0x401F63B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> naviSelectedPoints;

			// Token: 0x0401F63C RID: 128572
			[Token(Token = "0x401F63C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string naviSelectedPointId;
		}

		// Token: 0x02003FA7 RID: 16295
		[Token(Token = "0x2003FA7")]
		public class NormalStageRelation : IHotfixable
		{
			// Token: 0x0601947B RID: 103547 RVA: 0x0009D908 File Offset: 0x0009BB08
			[Token(Token = "0x601947B")]
			[Address(RVA = "0x11F80C0", Offset = "0x11F6CC0", VA = "0x1811F80C0")]
			public bool NeedDrawLine()
			{
				return default(bool);
			}

			// Token: 0x0601947C RID: 103548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601947C")]
			[Address(RVA = "0x11F8130", Offset = "0x11F6D30", VA = "0x1811F8130")]
			public NormalStageRelation()
			{
			}

			// Token: 0x0401F63D RID: 128573
			[Token(Token = "0x401F63D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string pointId;

			// Token: 0x0401F63E RID: 128574
			[Token(Token = "0x401F63E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string prevPointId;

			// Token: 0x0401F63F RID: 128575
			[Token(Token = "0x401F63F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool shouldShowLine;

			// Token: 0x0401F640 RID: 128576
			[Token(Token = "0x401F640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NeedDrawLine;

			// Token: 0x0401F641 RID: 128577
			[Token(Token = "0x401F641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003FA8 RID: 16296
		[Token(Token = "0x2003FA8")]
		public struct StageViewModelStruct
		{
			// Token: 0x0401F642 RID: 128578
			[Token(Token = "0x401F642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static SiracusaMapViewModel.StageViewModelStruct EMPTY;

			// Token: 0x0401F643 RID: 128579
			[Token(Token = "0x401F643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StageViewModel normalStageViewModel;

			// Token: 0x0401F644 RID: 128580
			[Token(Token = "0x401F644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public StageViewModel hardStageViewModel;

			// Token: 0x0401F645 RID: 128581
			[Token(Token = "0x401F645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string pointId;

			// Token: 0x0401F646 RID: 128582
			[Token(Token = "0x401F646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int sortId;
		}

		// Token: 0x02003FA9 RID: 16297
		[Token(Token = "0x2003FA9")]
		private struct TaskNodeStruct
		{
			// Token: 0x0401F647 RID: 128583
			[Token(Token = "0x401F647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string charCardId;

			// Token: 0x0401F648 RID: 128584
			[Token(Token = "0x401F648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string taskRingId;

			// Token: 0x0401F649 RID: 128585
			[Token(Token = "0x401F649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x0401F64A RID: 128586
			[Token(Token = "0x401F64A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string npcId;

			// Token: 0x0401F64B RID: 128587
			[Token(Token = "0x401F64B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Color themeColor;

			// Token: 0x0401F64C RID: 128588
			[Token(Token = "0x401F64C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string stageId;

			// Token: 0x0401F64D RID: 128589
			[Token(Token = "0x401F64D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlayerSiracusaMap.StateEnum taskStatus;
		}
	}
}
