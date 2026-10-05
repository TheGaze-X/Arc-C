using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005967 RID: 22887
	[Token(Token = "0x2005967")]
	public class CrisisV2MapModel : IHotfixable
	{
		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x060215AC RID: 136620 RVA: 0x000B9AC0 File Offset: 0x000B7CC0
		// (set) Token: 0x060215AD RID: 136621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E57")]
		public bool isDimensionListShow
		{
			[Token(Token = "0x60215AC")]
			[Address(RVA = "0x1BAF560", Offset = "0x1BAE160", VA = "0x181BAF560")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60215AD")]
			[Address(RVA = "0x1BAFBC0", Offset = "0x1BAE7C0", VA = "0x181BAFBC0")]
			set
			{
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x060215AE RID: 136622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E58")]
		public List<int> maxScoreList
		{
			[Token(Token = "0x60215AE")]
			[Address(RVA = "0x1BAF7B0", Offset = "0x1BAE3B0", VA = "0x181BAF7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x060215AF RID: 136623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E59")]
		public List<int> highestScoreList
		{
			[Token(Token = "0x60215AF")]
			[Address(RVA = "0x1BAF430", Offset = "0x1BAE030", VA = "0x181BAF430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x060215B0 RID: 136624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5A")]
		public Dictionary<string, CrisisV2MapRoadModel> roadModelMap
		{
			[Token(Token = "0x60215B0")]
			[Address(RVA = "0x1BAF900", Offset = "0x1BAE500", VA = "0x181BAF900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x060215B1 RID: 136625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5B")]
		public Dictionary<string, CrisisV2MapNodeModel> nodeModelMap
		{
			[Token(Token = "0x60215B1")]
			[Address(RVA = "0x1BAF8A0", Offset = "0x1BAE4A0", VA = "0x181BAF8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x060215B2 RID: 136626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5C")]
		public Dictionary<string, CrisisV2MapBagModel> bagModelMap
		{
			[Token(Token = "0x60215B2")]
			[Address(RVA = "0x1BAF1F0", Offset = "0x1BADDF0", VA = "0x181BAF1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x060215B3 RID: 136627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5D")]
		public CrisisV2SlotDetailViewModel slotDetailViewModel
		{
			[Token(Token = "0x60215B3")]
			[Address(RVA = "0x1BAFA30", Offset = "0x1BAE630", VA = "0x181BAFA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x060215B4 RID: 136628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5E")]
		public CrisisV2BagDetailViewModel bagDetailViewModel
		{
			[Token(Token = "0x60215B4")]
			[Address(RVA = "0x1BAF190", Offset = "0x1BADD90", VA = "0x181BAF190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x060215B5 RID: 136629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E5F")]
		public CrisisV2RuneDetailViewModel mapRuneDetailViewModel
		{
			[Token(Token = "0x60215B5")]
			[Address(RVA = "0x1BAF680", Offset = "0x1BAE280", VA = "0x181BAF680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x060215B6 RID: 136630 RVA: 0x000B9AD8 File Offset: 0x000B7CD8
		[Token(Token = "0x17004E60")]
		public CrisisV2MapModel.ViewType viewType
		{
			[Token(Token = "0x60215B6")]
			[Address(RVA = "0x1BAFB60", Offset = "0x1BAE760", VA = "0x181BAFB60")]
			get
			{
				return CrisisV2MapModel.ViewType.NONE;
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x060215B7 RID: 136631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E61")]
		public List<int> currentScoreList
		{
			[Token(Token = "0x60215B7")]
			[Address(RVA = "0x1BAF2B0", Offset = "0x1BADEB0", VA = "0x181BAF2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x060215B8 RID: 136632 RVA: 0x000B9AF0 File Offset: 0x000B7CF0
		[Token(Token = "0x17004E62")]
		public CrisisV2StageType mapType
		{
			[Token(Token = "0x60215B8")]
			[Address(RVA = "0x1BAF740", Offset = "0x1BAE340", VA = "0x181BAF740")]
			get
			{
				return CrisisV2StageType.NONE;
			}
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x060215B9 RID: 136633 RVA: 0x000B9B08 File Offset: 0x000B7D08
		[Token(Token = "0x17004E63")]
		public bool showTempTip
		{
			[Token(Token = "0x60215B9")]
			[Address(RVA = "0x1BAF9C0", Offset = "0x1BAE5C0", VA = "0x181BAF9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x060215BA RID: 136634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E64")]
		public string seasonId
		{
			[Token(Token = "0x60215BA")]
			[Address(RVA = "0x1BAF960", Offset = "0x1BAE560", VA = "0x181BAF960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x060215BB RID: 136635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E65")]
		public CrisisV2MapStageData mapStageData
		{
			[Token(Token = "0x60215BB")]
			[Address(RVA = "0x1BAF6E0", Offset = "0x1BAE2E0", VA = "0x181BAF6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x060215BC RID: 136636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E66")]
		public string currentMapId
		{
			[Token(Token = "0x60215BC")]
			[Address(RVA = "0x1BAF250", Offset = "0x1BADE50", VA = "0x181BAF250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x060215BD RID: 136637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E67")]
		public string focusNodeId
		{
			[Token(Token = "0x60215BD")]
			[Address(RVA = "0x1BAF310", Offset = "0x1BADF10", VA = "0x181BAF310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x060215BE RID: 136638 RVA: 0x000B9B20 File Offset: 0x000B7D20
		[Token(Token = "0x17004E68")]
		public int switchSeqNum
		{
			[Token(Token = "0x60215BE")]
			[Address(RVA = "0x1BAFA90", Offset = "0x1BAE690", VA = "0x181BAFA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x060215BF RID: 136639 RVA: 0x000B9B38 File Offset: 0x000B7D38
		[Token(Token = "0x17004E69")]
		public int jumpSeqNum
		{
			[Token(Token = "0x60215BF")]
			[Address(RVA = "0x1BAF620", Offset = "0x1BAE220", VA = "0x181BAF620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x060215C0 RID: 136640 RVA: 0x000B9B50 File Offset: 0x000B7D50
		[Token(Token = "0x17004E6A")]
		public float jumpPos
		{
			[Token(Token = "0x60215C0")]
			[Address(RVA = "0x1BAF5C0", Offset = "0x1BAE1C0", VA = "0x181BAF5C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x060215C1 RID: 136641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E6B")]
		public string avgJumpRuneNodeId
		{
			[Token(Token = "0x60215C1")]
			[Address(RVA = "0x1BAF0D0", Offset = "0x1BADCD0", VA = "0x181BAF0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x060215C2 RID: 136642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E6C")]
		public string avgJumpBagId
		{
			[Token(Token = "0x60215C2")]
			[Address(RVA = "0x1BAF010", Offset = "0x1BADC10", VA = "0x181BAF010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x060215C3 RID: 136643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E6D")]
		public string avgJumpTreasureId
		{
			[Token(Token = "0x60215C3")]
			[Address(RVA = "0x1BAF130", Offset = "0x1BADD30", VA = "0x181BAF130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x060215C4 RID: 136644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E6E")]
		public string avgJumpKeypontId
		{
			[Token(Token = "0x60215C4")]
			[Address(RVA = "0x1BAF070", Offset = "0x1BADC70", VA = "0x181BAF070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x060215C5 RID: 136645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E6F")]
		public string areaBgId
		{
			[Token(Token = "0x60215C5")]
			[Address(RVA = "0x1BAEFA0", Offset = "0x1BADBA0", VA = "0x181BAEFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x060215C6 RID: 136646 RVA: 0x000B9B68 File Offset: 0x000B7D68
		[Token(Token = "0x17004E70")]
		public int interactId
		{
			[Token(Token = "0x60215C6")]
			[Address(RVA = "0x1BAF4F0", Offset = "0x1BAE0F0", VA = "0x181BAF4F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x060215C7 RID: 136647 RVA: 0x000B9B80 File Offset: 0x000B7D80
		[Token(Token = "0x17004E71")]
		public int tipsSeqNum
		{
			[Token(Token = "0x60215C7")]
			[Address(RVA = "0x1BAFAF0", Offset = "0x1BAE6F0", VA = "0x181BAFAF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x060215C8 RID: 136648 RVA: 0x000B9B98 File Offset: 0x000B7D98
		[Token(Token = "0x17004E72")]
		public int highestScore
		{
			[Token(Token = "0x60215C8")]
			[Address(RVA = "0x1BAF490", Offset = "0x1BAE090", VA = "0x181BAF490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x060215C9 RID: 136649 RVA: 0x000B9BB0 File Offset: 0x000B7DB0
		[Token(Token = "0x17004E73")]
		public CrisisV2MissionProgress missionProgress
		{
			[Token(Token = "0x60215C9")]
			[Address(RVA = "0x1BAF810", Offset = "0x1BAE410", VA = "0x181BAF810")]
			get
			{
				return default(CrisisV2MissionProgress);
			}
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x060215CA RID: 136650 RVA: 0x000B9BC8 File Offset: 0x000B7DC8
		[Token(Token = "0x17004E74")]
		public int hidePreviewSeqNum
		{
			[Token(Token = "0x60215CA")]
			[Address(RVA = "0x1BAF3C0", Offset = "0x1BADFC0", VA = "0x181BAF3C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060215CB RID: 136651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215CB")]
		[Address(RVA = "0x1BA9D60", Offset = "0x1BA8960", VA = "0x181BA9D60")]
		public void UpdateFocus(CrisisV2MapModel.TargetType targetType, string targetId, CrisisV2MapModel.ActionType actionType)
		{
		}

		// Token: 0x060215CC RID: 136652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215CC")]
		[Address(RVA = "0x1BAA630", Offset = "0x1BA9230", VA = "0x181BAA630")]
		public void UpdatePreviewWithNode(string previewNodeId)
		{
		}

		// Token: 0x060215CD RID: 136653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215CD")]
		[Address(RVA = "0x1BAA400", Offset = "0x1BA9000", VA = "0x181BAA400")]
		public void UpdatePreviewWithBag(string previewBagId)
		{
		}

		// Token: 0x060215CE RID: 136654 RVA: 0x000B9BE0 File Offset: 0x000B7DE0
		[Token(Token = "0x60215CE")]
		[Address(RVA = "0x1BA77B0", Offset = "0x1BA63B0", VA = "0x181BA77B0")]
		public int HidePreview()
		{
			return 0;
		}

		// Token: 0x060215CF RID: 136655 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		[Token(Token = "0x60215CF")]
		[Address(RVA = "0x1BA7A80", Offset = "0x1BA6680", VA = "0x181BA7A80")]
		public bool IsInPreview()
		{
			return default(bool);
		}

		// Token: 0x060215D0 RID: 136656 RVA: 0x000B9C10 File Offset: 0x000B7E10
		[Token(Token = "0x60215D0")]
		[Address(RVA = "0x1BA7170", Offset = "0x1BA5D70", VA = "0x181BA7170")]
		public CrisisV2PreviewInfo GetPreviewInfo()
		{
			return default(CrisisV2PreviewInfo);
		}

		// Token: 0x060215D1 RID: 136657 RVA: 0x000B9C28 File Offset: 0x000B7E28
		[Token(Token = "0x60215D1")]
		[Address(RVA = "0x1BA8E00", Offset = "0x1BA7A00", VA = "0x181BA8E00")]
		public bool NeedHighLight(string nodeOrBagId)
		{
			return default(bool);
		}

		// Token: 0x060215D2 RID: 136658 RVA: 0x000B9C40 File Offset: 0x000B7E40
		[Token(Token = "0x60215D2")]
		[Address(RVA = "0x1BA78C0", Offset = "0x1BA64C0", VA = "0x181BA78C0")]
		public bool IsBagFocus(string bagId)
		{
			return default(bool);
		}

		// Token: 0x060215D3 RID: 136659 RVA: 0x000B9C58 File Offset: 0x000B7E58
		[Token(Token = "0x60215D3")]
		[Address(RVA = "0x1BA7D60", Offset = "0x1BA6960", VA = "0x181BA7D60")]
		public bool IsNodeFocus(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060215D4 RID: 136660 RVA: 0x000B9C70 File Offset: 0x000B7E70
		[Token(Token = "0x60215D4")]
		[Address(RVA = "0x1BA97D0", Offset = "0x1BA83D0", VA = "0x181BA97D0")]
		public bool TryGetTipsInfo(out CrisisV2TipsInfo tipsInfo)
		{
			return default(bool);
		}

		// Token: 0x060215D5 RID: 136661 RVA: 0x000B9C88 File Offset: 0x000B7E88
		[Token(Token = "0x60215D5")]
		[Address(RVA = "0x1BA9630", Offset = "0x1BA8230", VA = "0x181BA9630")]
		public bool TryGetExpireTime(long currentTs, out string timeStr)
		{
			return default(bool);
		}

		// Token: 0x060215D6 RID: 136662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215D6")]
		[Address(RVA = "0x1BA8050", Offset = "0x1BA6C50", VA = "0x181BA8050")]
		public void LoadMap(string mapId)
		{
		}

		// Token: 0x060215D7 RID: 136663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215D7")]
		[Address(RVA = "0x1BAC8D0", Offset = "0x1BAB4D0", VA = "0x181BAC8D0")]
		private void _LoadMapSelectSlotFromLocalCache(string seasonId, string mapId)
		{
		}

		// Token: 0x060215D8 RID: 136664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215D8")]
		[Address(RVA = "0x1BA8E90", Offset = "0x1BA7A90", VA = "0x181BA8E90")]
		public void SaveSelectSlotToLocalCache()
		{
		}

		// Token: 0x060215D9 RID: 136665 RVA: 0x000B9CA0 File Offset: 0x000B7EA0
		[Token(Token = "0x60215D9")]
		[Address(RVA = "0x1BA7A00", Offset = "0x1BA6600", VA = "0x181BA7A00")]
		public bool IsHardScore(int score)
		{
			return default(bool);
		}

		// Token: 0x060215DA RID: 136666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215DA")]
		[Address(RVA = "0x1BAAB30", Offset = "0x1BA9730", VA = "0x181BAAB30")]
		private void _CalcCurrentScoreList()
		{
		}

		// Token: 0x060215DB RID: 136667 RVA: 0x000B9CB8 File Offset: 0x000B7EB8
		[Token(Token = "0x60215DB")]
		[Address(RVA = "0x1BA6030", Offset = "0x1BA4C30", VA = "0x181BA6030")]
		public int CalcSelectTotalScore()
		{
			return 0;
		}

		// Token: 0x060215DC RID: 136668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215DC")]
		[Address(RVA = "0x1BA9E80", Offset = "0x1BA8A80", VA = "0x181BA9E80")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x060215DD RID: 136669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215DD")]
		[Address(RVA = "0x1BAE050", Offset = "0x1BACC50", VA = "0x181BAE050")]
		private void _UpdateMissionStatus()
		{
		}

		// Token: 0x060215DE RID: 136670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215DE")]
		[Address(RVA = "0x1BADEB0", Offset = "0x1BACAB0", VA = "0x181BADEB0")]
		private void _UpdateHighestScoreList(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x060215DF RID: 136671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215DF")]
		[Address(RVA = "0x1BAE3F0", Offset = "0x1BACFF0", VA = "0x181BAE3F0")]
		private void _UpdateNode(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x060215E0 RID: 136672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215E0")]
		[Address(RVA = "0x1BADD80", Offset = "0x1BAC980", VA = "0x181BADD80")]
		private void _UpdateBag(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x060215E1 RID: 136673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215E1")]
		[Address(RVA = "0x1BAE540", Offset = "0x1BAD140", VA = "0x181BAE540")]
		private void _UpdateStartNodeSet()
		{
		}

		// Token: 0x060215E2 RID: 136674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215E2")]
		[Address(RVA = "0x1BADA70", Offset = "0x1BAC670", VA = "0x181BADA70")]
		private void _UpdateAvailNodeSet()
		{
		}

		// Token: 0x060215E3 RID: 136675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215E3")]
		[Address(RVA = "0x1BAA870", Offset = "0x1BA9470", VA = "0x181BAA870")]
		private void _AddAvailNodeImpl(Queue<string> nodeQueue, HashSet<string> availNodeSet)
		{
		}

		// Token: 0x060215E4 RID: 136676 RVA: 0x000B9CD0 File Offset: 0x000B7ED0
		[Token(Token = "0x60215E4")]
		[Address(RVA = "0x1BA5D70", Offset = "0x1BA4970", VA = "0x181BA5D70")]
		public CrisisV2Progress CalcBagScoreProgress(string bagId)
		{
			return default(CrisisV2Progress);
		}

		// Token: 0x060215E5 RID: 136677 RVA: 0x000B9CE8 File Offset: 0x000B7EE8
		[Token(Token = "0x60215E5")]
		[Address(RVA = "0x1BA7820", Offset = "0x1BA6420", VA = "0x181BA7820")]
		public bool IsBagAllSelected(string bagId)
		{
			return default(bool);
		}

		// Token: 0x060215E6 RID: 136678 RVA: 0x000B9D00 File Offset: 0x000B7F00
		[Token(Token = "0x60215E6")]
		[Address(RVA = "0x1BA64A0", Offset = "0x1BA50A0", VA = "0x181BA64A0")]
		public CrisisV2MapBagStatus GetBagStatus(string bagId)
		{
			return CrisisV2MapBagStatus.DISABLE;
		}

		// Token: 0x060215E7 RID: 136679 RVA: 0x000B9D18 File Offset: 0x000B7F18
		[Token(Token = "0x60215E7")]
		[Address(RVA = "0x1BA6A10", Offset = "0x1BA5610", VA = "0x181BA6A10")]
		public CrisisV2MapNodeStatus GetNodeStatus(string nodeId)
		{
			return CrisisV2MapNodeStatus.DISABLE;
		}

		// Token: 0x060215E8 RID: 136680 RVA: 0x000B9D30 File Offset: 0x000B7F30
		[Token(Token = "0x60215E8")]
		[Address(RVA = "0x1BAB940", Offset = "0x1BAA540", VA = "0x181BAB940")]
		private bool _IsHighlightBag(string bagId)
		{
			return default(bool);
		}

		// Token: 0x060215E9 RID: 136681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60215E9")]
		[Address(RVA = "0x1BA76F0", Offset = "0x1BA62F0", VA = "0x181BA76F0")]
		public string GetSlotViewBagTutorialKey(string bagId)
		{
			return null;
		}

		// Token: 0x060215EA RID: 136682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215EA")]
		[Address(RVA = "0x1BA6720", Offset = "0x1BA5320", VA = "0x181BA6720")]
		public void GetBagViewBagTutorialKey(string bagId, out string bagTutorialKey, out string titleTutorialKey, out string detailTutorialKey)
		{
		}

		// Token: 0x060215EB RID: 136683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60215EB")]
		[Address(RVA = "0x1BA68A0", Offset = "0x1BA54A0", VA = "0x181BA68A0")]
		public string GetNodeSlotTutorialKey(string nodeId, CrisisV2NodeSlotType slotType)
		{
			return null;
		}

		// Token: 0x060215EC RID: 136684 RVA: 0x000B9D48 File Offset: 0x000B7F48
		[Token(Token = "0x60215EC")]
		[Address(RVA = "0x1BABD50", Offset = "0x1BAA950", VA = "0x181BABD50")]
		private bool _IsNodeSelected(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060215ED RID: 136685 RVA: 0x000B9D60 File Offset: 0x000B7F60
		[Token(Token = "0x60215ED")]
		[Address(RVA = "0x1BABB30", Offset = "0x1BAA730", VA = "0x181BABB30")]
		private bool _IsNodeAvail(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060215EE RID: 136686 RVA: 0x000B9D78 File Offset: 0x000B7F78
		[Token(Token = "0x60215EE")]
		[Address(RVA = "0x1BABBD0", Offset = "0x1BAA7D0", VA = "0x181BABBD0")]
		private bool _IsNodeReachable(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060215EF RID: 136687 RVA: 0x000B9D90 File Offset: 0x000B7F90
		[Token(Token = "0x60215EF")]
		[Address(RVA = "0x1BA7300", Offset = "0x1BA5F00", VA = "0x181BA7300")]
		public CrisisV2MapRoadStatus GetRoadStatus(string roadId)
		{
			return CrisisV2MapRoadStatus.DISABLE;
		}

		// Token: 0x060215F0 RID: 136688 RVA: 0x000B9DA8 File Offset: 0x000B7FA8
		[Token(Token = "0x60215F0")]
		[Address(RVA = "0x1BAB9C0", Offset = "0x1BAA5C0", VA = "0x181BAB9C0")]
		private bool _IsNodeAutoSelectInBag(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x060215F1 RID: 136689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F1")]
		[Address(RVA = "0x1BA9090", Offset = "0x1BA7C90", VA = "0x181BA9090")]
		public void SelectBag(string bagId)
		{
		}

		// Token: 0x060215F2 RID: 136690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F2")]
		[Address(RVA = "0x1BA9B50", Offset = "0x1BA8750", VA = "0x181BA9B50")]
		public void UnselectBag(string bagId)
		{
		}

		// Token: 0x060215F3 RID: 136691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F3")]
		[Address(RVA = "0x1BA94E0", Offset = "0x1BA80E0", VA = "0x181BA94E0")]
		public void SelectNode(string nodeId)
		{
		}

		// Token: 0x060215F4 RID: 136692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F4")]
		[Address(RVA = "0x1BACFF0", Offset = "0x1BABBF0", VA = "0x181BACFF0")]
		private void _RefreshRuneSelectDetailList()
		{
		}

		// Token: 0x060215F5 RID: 136693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F5")]
		[Address(RVA = "0x1BAD690", Offset = "0x1BAC290", VA = "0x181BAD690")]
		private void _SelectNode(string nodeId)
		{
		}

		// Token: 0x060215F6 RID: 136694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F6")]
		[Address(RVA = "0x1BAD2B0", Offset = "0x1BABEB0", VA = "0x181BAD2B0")]
		private void _SelectNodeImpl(Queue<string> nodeQueue)
		{
		}

		// Token: 0x060215F7 RID: 136695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F7")]
		[Address(RVA = "0x1BA9CD0", Offset = "0x1BA88D0", VA = "0x181BA9CD0")]
		public void UnselectNode(string nodeId)
		{
		}

		// Token: 0x060215F8 RID: 136696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F8")]
		[Address(RVA = "0x1BAD9B0", Offset = "0x1BAC5B0", VA = "0x181BAD9B0")]
		private void _UnselectNode(string nodeId)
		{
		}

		// Token: 0x060215F9 RID: 136697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215F9")]
		[Address(RVA = "0x1BA9570", Offset = "0x1BA8170", VA = "0x181BA9570")]
		public void SwitchViewType(float jumpPos)
		{
		}

		// Token: 0x060215FA RID: 136698 RVA: 0x000B9DC0 File Offset: 0x000B7FC0
		[Token(Token = "0x60215FA")]
		[Address(RVA = "0x1BA6110", Offset = "0x1BA4D10", VA = "0x181BA6110")]
		public int ChangeViewType(CrisisV2MapModel.ViewType viewType)
		{
			return 0;
		}

		// Token: 0x060215FB RID: 136699 RVA: 0x000B9DD8 File Offset: 0x000B7FD8
		[Token(Token = "0x60215FB")]
		[Address(RVA = "0x1BAB2F0", Offset = "0x1BA9EF0", VA = "0x181BAB2F0")]
		private int _ChangeViewType(CrisisV2MapModel.ViewType viewType)
		{
			return 0;
		}

		// Token: 0x060215FC RID: 136700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215FC")]
		[Address(RVA = "0x1BA61F0", Offset = "0x1BA4DF0", VA = "0x181BA61F0")]
		public void ClearSelectNodes()
		{
		}

		// Token: 0x060215FD RID: 136701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215FD")]
		[Address(RVA = "0x1BAE730", Offset = "0x1BAD330", VA = "0x181BAE730")]
		private void _ValidationSelectSet()
		{
		}

		// Token: 0x060215FE RID: 136702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215FE")]
		[Address(RVA = "0x1BAAFF0", Offset = "0x1BA9BF0", VA = "0x181BAAFF0")]
		private void _CalcValidNodeSetImpl(Queue<string> nodeQueue, HashSet<string> validNodeSet)
		{
		}

		// Token: 0x060215FF RID: 136703 RVA: 0x000B9DF0 File Offset: 0x000B7FF0
		[Token(Token = "0x60215FF")]
		[Address(RVA = "0x1BA7F20", Offset = "0x1BA6B20", VA = "0x181BA7F20")]
		public int JumpToNode(CrisisV2MapModel.ViewType currentView, string nodeId)
		{
			return 0;
		}

		// Token: 0x06021600 RID: 136704 RVA: 0x000B9E08 File Offset: 0x000B8008
		[Token(Token = "0x6021600")]
		[Address(RVA = "0x1BA7E80", Offset = "0x1BA6A80", VA = "0x181BA7E80")]
		public int JumpToBag(CrisisV2MapModel.ViewType currentView, string bagId)
		{
			return 0;
		}

		// Token: 0x06021601 RID: 136705 RVA: 0x000B9E20 File Offset: 0x000B8020
		[Token(Token = "0x6021601")]
		[Address(RVA = "0x1BABFA0", Offset = "0x1BAABA0", VA = "0x181BABFA0")]
		private int _JumpToDetailViewNearestBag(CrisisV2MapModel.ViewType srcView, CrisisV2MapModel.ViewType dstView, float curPos)
		{
			return 0;
		}

		// Token: 0x06021602 RID: 136706 RVA: 0x000B9E38 File Offset: 0x000B8038
		[Token(Token = "0x6021602")]
		[Address(RVA = "0x1BAC210", Offset = "0x1BAAE10", VA = "0x181BAC210")]
		private int _JumpToNode(CrisisV2MapModel.ViewType currentView, string nodeId)
		{
			return 0;
		}

		// Token: 0x06021603 RID: 136707 RVA: 0x000B9E50 File Offset: 0x000B8050
		[Token(Token = "0x6021603")]
		[Address(RVA = "0x1BABE10", Offset = "0x1BAAA10", VA = "0x181BABE10")]
		private int _JumpToBag(CrisisV2MapModel.ViewType currentView, string bagId)
		{
			return 0;
		}

		// Token: 0x06021604 RID: 136708 RVA: 0x000B9E68 File Offset: 0x000B8068
		[Token(Token = "0x6021604")]
		[Address(RVA = "0x1BAC310", Offset = "0x1BAAF10", VA = "0x181BAC310")]
		private int _JumpToPos(CrisisV2MapModel.ViewType currentView, float targetPos)
		{
			return 0;
		}

		// Token: 0x06021605 RID: 136709 RVA: 0x000B9E80 File Offset: 0x000B8080
		[Token(Token = "0x6021605")]
		[Address(RVA = "0x1BAB7A0", Offset = "0x1BAA3A0", VA = "0x181BAB7A0")]
		private CrisisV2MapRoadStatus _GetNodeRoadStatus(string startNodeId, string endNodeId)
		{
			return CrisisV2MapRoadStatus.DISABLE;
		}

		// Token: 0x06021606 RID: 136710 RVA: 0x000B9E98 File Offset: 0x000B8098
		[Token(Token = "0x6021606")]
		[Address(RVA = "0x1BAB880", Offset = "0x1BAA480", VA = "0x181BAB880")]
		private CrisisV2MapRoadStatus _GetTreasureRoadStatus(string bagId, string nodeId)
		{
			return CrisisV2MapRoadStatus.DISABLE;
		}

		// Token: 0x06021607 RID: 136711 RVA: 0x000B9EB0 File Offset: 0x000B80B0
		[Token(Token = "0x6021607")]
		[Address(RVA = "0x1BAB400", Offset = "0x1BAA000", VA = "0x181BAB400")]
		private CrisisV2MapRoadStatus _GetBagRoadStatus(string roadId)
		{
			return CrisisV2MapRoadStatus.DISABLE;
		}

		// Token: 0x06021608 RID: 136712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021608")]
		[Address(RVA = "0x1BAC5F0", Offset = "0x1BAB1F0", VA = "0x181BAC5F0")]
		private void _LoadExclusionGroup(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x06021609 RID: 136713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021609")]
		[Address(RVA = "0x1BAC810", Offset = "0x1BAB410", VA = "0x181BAC810")]
		private void _LoadHighLightSlot(CrisisV2SeasonConstData constData)
		{
		}

		// Token: 0x0602160A RID: 136714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602160A")]
		[Address(RVA = "0x1BAC3C0", Offset = "0x1BAAFC0", VA = "0x181BAC3C0")]
		private void _LoadBag(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602160B RID: 136715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602160B")]
		[Address(RVA = "0x1BACA50", Offset = "0x1BAB650", VA = "0x181BACA50")]
		private void _LoadNode(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602160C RID: 136716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602160C")]
		[Address(RVA = "0x1BACC90", Offset = "0x1BAB890", VA = "0x181BACC90")]
		private void _LoadRoad(CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602160D RID: 136717 RVA: 0x000B9EC8 File Offset: 0x000B80C8
		[Token(Token = "0x602160D")]
		[Address(RVA = "0x1BA7AF0", Offset = "0x1BA66F0", VA = "0x181BA7AF0")]
		public bool IsNodeExclusion(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0602160E RID: 136718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602160E")]
		[Address(RVA = "0x1BAB610", Offset = "0x1BAA210", VA = "0x181BAB610")]
		private string _GetExlucsionSelectNodeId(string groupId)
		{
			return null;
		}

		// Token: 0x0602160F RID: 136719 RVA: 0x000B9EE0 File Offset: 0x000B80E0
		[Token(Token = "0x602160F")]
		[Address(RVA = "0x1BA7220", Offset = "0x1BA5E20", VA = "0x181BA7220")]
		public CrisisV2RoadPointStyle GetRoadPointStyle(CrisisV2MapRoadPointData targetData)
		{
			return CrisisV2RoadPointStyle.NONE;
		}

		// Token: 0x06021610 RID: 136720 RVA: 0x000B9EF8 File Offset: 0x000B80F8
		[Token(Token = "0x6021610")]
		[Address(RVA = "0x1BA6190", Offset = "0x1BA4D90", VA = "0x181BA6190")]
		public bool CheckIfCurMapHasBagView()
		{
			return default(bool);
		}

		// Token: 0x06021611 RID: 136721 RVA: 0x000B9F10 File Offset: 0x000B8110
		[Token(Token = "0x6021611")]
		[Address(RVA = "0x1BAB390", Offset = "0x1BA9F90", VA = "0x181BAB390")]
		private bool _CheckIfCurMapHasBagView()
		{
			return default(bool);
		}

		// Token: 0x06021612 RID: 136722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021612")]
		[Address(RVA = "0x1BAD200", Offset = "0x1BABE00", VA = "0x181BAD200")]
		private void _RefreshSlotRuneSingleViewList()
		{
		}

		// Token: 0x06021613 RID: 136723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021613")]
		[Address(RVA = "0x1BAD170", Offset = "0x1BABD70", VA = "0x181BAD170")]
		private void _RefreshSlotRunePackViewList()
		{
		}

		// Token: 0x06021614 RID: 136724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021614")]
		[Address(RVA = "0x1BA6C70", Offset = "0x1BA5870", VA = "0x181BA6C70")]
		public string GetOverrideCrisisV2PermBgmEvent()
		{
			return null;
		}

		// Token: 0x06021615 RID: 136725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021615")]
		[Address(RVA = "0x1BA74C0", Offset = "0x1BA60C0", VA = "0x181BA74C0")]
		public List<string> GetSelectedRuneSlotList()
		{
			return null;
		}

		// Token: 0x06021616 RID: 136726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021616")]
		[Address(RVA = "0x1BA6E50", Offset = "0x1BA5A50", VA = "0x181BA6E50")]
		public List<RuneTable.PackedRuneData> GetPackedRuneData()
		{
			return null;
		}

		// Token: 0x06021617 RID: 136727 RVA: 0x000B9F28 File Offset: 0x000B8128
		[Token(Token = "0x6021617")]
		[Address(RVA = "0x1BA62B0", Offset = "0x1BA4EB0", VA = "0x181BA62B0")]
		public BattleStageInfo GenerateBattleStageInfo()
		{
			return default(BattleStageInfo);
		}

		// Token: 0x06021618 RID: 136728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021618")]
		[Address(RVA = "0x1BACE80", Offset = "0x1BABA80", VA = "0x181BACE80")]
		private void _RefreshRuneDetailFocusBySelect(CrisisV2MapModel.TargetType targetType, string targetId, CrisisV2MapModel.ActionType actionType)
		{
		}

		// Token: 0x06021619 RID: 136729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021619")]
		[Address(RVA = "0x1BACF40", Offset = "0x1BABB40", VA = "0x181BACF40")]
		private void _RefreshRuneDetailFocusBySwitch(CrisisV2MapModel.ViewType currentViewType, string targetId)
		{
		}

		// Token: 0x0602161A RID: 136730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602161A")]
		[Address(RVA = "0x1BAEA50", Offset = "0x1BAD650", VA = "0x181BAEA50")]
		public CrisisV2MapModel()
		{
		}

		// Token: 0x0402D7C9 RID: 186313
		[Token(Token = "0x402D7C9")]
		[FieldOffset(Offset = "0x10")]
		private string m_mapId;

		// Token: 0x0402D7CA RID: 186314
		[Token(Token = "0x402D7CA")]
		[FieldOffset(Offset = "0x18")]
		private string m_seasonId;

		// Token: 0x0402D7CB RID: 186315
		[Token(Token = "0x402D7CB")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<string> m_selectNodeSet;

		// Token: 0x0402D7CC RID: 186316
		[Token(Token = "0x402D7CC")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<string> m_startNodeSet;

		// Token: 0x0402D7CD RID: 186317
		[Token(Token = "0x402D7CD")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<string> m_availNodeSet;

		// Token: 0x0402D7CE RID: 186318
		[Token(Token = "0x402D7CE")]
		[FieldOffset(Offset = "0x38")]
		private List<int> m_currentScoreList;

		// Token: 0x0402D7CF RID: 186319
		[Token(Token = "0x402D7CF")]
		[FieldOffset(Offset = "0x40")]
		private List<int> m_highestScoreList;

		// Token: 0x0402D7D0 RID: 186320
		[Token(Token = "0x402D7D0")]
		[FieldOffset(Offset = "0x48")]
		private int m_highestScore;

		// Token: 0x0402D7D1 RID: 186321
		[Token(Token = "0x402D7D1")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_maxScoreList;

		// Token: 0x0402D7D2 RID: 186322
		[Token(Token = "0x402D7D2")]
		[FieldOffset(Offset = "0x58")]
		private Queue<string> m_tempNodeQueue;

		// Token: 0x0402D7D3 RID: 186323
		[Token(Token = "0x402D7D3")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<string> m_tempNodeSet;

		// Token: 0x0402D7D4 RID: 186324
		[Token(Token = "0x402D7D4")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<string> m_tempBagWaitingSet;

		// Token: 0x0402D7D5 RID: 186325
		[Token(Token = "0x402D7D5")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<string> m_tempBagSuccessSet;

		// Token: 0x0402D7D6 RID: 186326
		[Token(Token = "0x402D7D6")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, CrisisV2MapRoadModel> m_roadModelMap;

		// Token: 0x0402D7D7 RID: 186327
		[Token(Token = "0x402D7D7")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, CrisisV2MapNodeModel> m_nodeModelMap;

		// Token: 0x0402D7D8 RID: 186328
		[Token(Token = "0x402D7D8")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<string, CrisisV2MapBagModel> m_bagModelMap;

		// Token: 0x0402D7D9 RID: 186329
		[Token(Token = "0x402D7D9")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<string, CrisisV2MapExclusionModel> m_exclusionModelMap;

		// Token: 0x0402D7DA RID: 186330
		[Token(Token = "0x402D7DA")]
		[FieldOffset(Offset = "0x98")]
		private CrisisV2SlotDetailViewModel m_slotDetailViewModel;

		// Token: 0x0402D7DB RID: 186331
		[Token(Token = "0x402D7DB")]
		[FieldOffset(Offset = "0xA0")]
		private CrisisV2BagDetailViewModel m_bagDetailViewModel;

		// Token: 0x0402D7DC RID: 186332
		[Token(Token = "0x402D7DC")]
		[FieldOffset(Offset = "0xA8")]
		private CrisisV2MapDetailData m_mapDetailData;

		// Token: 0x0402D7DD RID: 186333
		[Token(Token = "0x402D7DD")]
		[FieldOffset(Offset = "0xB0")]
		private CrisisV2MapStageData m_mapStageData;

		// Token: 0x0402D7DE RID: 186334
		[Token(Token = "0x402D7DE")]
		[FieldOffset(Offset = "0xB8")]
		private CrisisV2SeasonConstData m_constData;

		// Token: 0x0402D7DF RID: 186335
		[Token(Token = "0x402D7DF")]
		[FieldOffset(Offset = "0xC0")]
		private CrisisV2RuneDetailViewModel m_mapRuneDetailViewModel;

		// Token: 0x0402D7E0 RID: 186336
		[Token(Token = "0x402D7E0")]
		[FieldOffset(Offset = "0xC8")]
		private CrisisV2SeasonInfo m_seasonInfo;

		// Token: 0x0402D7E1 RID: 186337
		[Token(Token = "0x402D7E1")]
		[FieldOffset(Offset = "0xD0")]
		private int m_bgmHardPoint;

		// Token: 0x0402D7E2 RID: 186338
		[Token(Token = "0x402D7E2")]
		[FieldOffset(Offset = "0xD4")]
		private int m_hardStyleScoreThreshold;

		// Token: 0x0402D7E3 RID: 186339
		[Token(Token = "0x402D7E3")]
		[FieldOffset(Offset = "0xD8")]
		private CrisisV2MissionProgress m_missionProgress;

		// Token: 0x0402D7E4 RID: 186340
		[Token(Token = "0x402D7E4")]
		[FieldOffset(Offset = "0xE8")]
		private string m_avgJumpRuneNodeId;

		// Token: 0x0402D7E5 RID: 186341
		[Token(Token = "0x402D7E5")]
		[FieldOffset(Offset = "0xF0")]
		private string m_avgJumpTreasureNodeId;

		// Token: 0x0402D7E6 RID: 186342
		[Token(Token = "0x402D7E6")]
		[FieldOffset(Offset = "0xF8")]
		private string m_avgJumpKeypointNodeId;

		// Token: 0x0402D7E7 RID: 186343
		[Token(Token = "0x402D7E7")]
		[FieldOffset(Offset = "0x100")]
		private string m_avgJumpBagId;

		// Token: 0x0402D7E8 RID: 186344
		[Token(Token = "0x402D7E8")]
		[FieldOffset(Offset = "0x108")]
		private int m_switchViewSeqNum;

		// Token: 0x0402D7E9 RID: 186345
		[Token(Token = "0x402D7E9")]
		[FieldOffset(Offset = "0x10C")]
		private CrisisV2MapModel.ViewType m_viewType;

		// Token: 0x0402D7EA RID: 186346
		[Token(Token = "0x402D7EA")]
		[FieldOffset(Offset = "0x110")]
		private int m_jumpSeqNum;

		// Token: 0x0402D7EB RID: 186347
		[Token(Token = "0x402D7EB")]
		[FieldOffset(Offset = "0x114")]
		private float m_jumpPos;

		// Token: 0x0402D7EC RID: 186348
		[Token(Token = "0x402D7EC")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isDimensionListShow;

		// Token: 0x0402D7ED RID: 186349
		[Token(Token = "0x402D7ED")]
		[FieldOffset(Offset = "0x120")]
		private CrisisV2MapModel.CrisisV2FocusModel m_focusModel;

		// Token: 0x0402D7EE RID: 186350
		[Token(Token = "0x402D7EE")]
		[FieldOffset(Offset = "0x128")]
		private CrisisV2MapModel.CrisisV2PreviewModel m_previewModel;

		// Token: 0x0402D7EF RID: 186351
		[Token(Token = "0x402D7EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDimensionListShow;

		// Token: 0x0402D7F0 RID: 186352
		[Token(Token = "0x402D7F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isDimensionListShow;

		// Token: 0x0402D7F1 RID: 186353
		[Token(Token = "0x402D7F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxScoreList;

		// Token: 0x0402D7F2 RID: 186354
		[Token(Token = "0x402D7F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_highestScoreList;

		// Token: 0x0402D7F3 RID: 186355
		[Token(Token = "0x402D7F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_roadModelMap;

		// Token: 0x0402D7F4 RID: 186356
		[Token(Token = "0x402D7F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_nodeModelMap;

		// Token: 0x0402D7F5 RID: 186357
		[Token(Token = "0x402D7F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bagModelMap;

		// Token: 0x0402D7F6 RID: 186358
		[Token(Token = "0x402D7F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_slotDetailViewModel;

		// Token: 0x0402D7F7 RID: 186359
		[Token(Token = "0x402D7F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bagDetailViewModel;

		// Token: 0x0402D7F8 RID: 186360
		[Token(Token = "0x402D7F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_mapRuneDetailViewModel;

		// Token: 0x0402D7F9 RID: 186361
		[Token(Token = "0x402D7F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402D7FA RID: 186362
		[Token(Token = "0x402D7FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_currentScoreList;

		// Token: 0x0402D7FB RID: 186363
		[Token(Token = "0x402D7FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_mapType;

		// Token: 0x0402D7FC RID: 186364
		[Token(Token = "0x402D7FC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_showTempTip;

		// Token: 0x0402D7FD RID: 186365
		[Token(Token = "0x402D7FD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_seasonId;

		// Token: 0x0402D7FE RID: 186366
		[Token(Token = "0x402D7FE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_mapStageData;

		// Token: 0x0402D7FF RID: 186367
		[Token(Token = "0x402D7FF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_currentMapId;

		// Token: 0x0402D800 RID: 186368
		[Token(Token = "0x402D800")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_focusNodeId;

		// Token: 0x0402D801 RID: 186369
		[Token(Token = "0x402D801")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_switchSeqNum;

		// Token: 0x0402D802 RID: 186370
		[Token(Token = "0x402D802")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_jumpSeqNum;

		// Token: 0x0402D803 RID: 186371
		[Token(Token = "0x402D803")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_jumpPos;

		// Token: 0x0402D804 RID: 186372
		[Token(Token = "0x402D804")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_avgJumpRuneNodeId;

		// Token: 0x0402D805 RID: 186373
		[Token(Token = "0x402D805")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_avgJumpBagId;

		// Token: 0x0402D806 RID: 186374
		[Token(Token = "0x402D806")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_avgJumpTreasureId;

		// Token: 0x0402D807 RID: 186375
		[Token(Token = "0x402D807")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_avgJumpKeypontId;

		// Token: 0x0402D808 RID: 186376
		[Token(Token = "0x402D808")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_areaBgId;

		// Token: 0x0402D809 RID: 186377
		[Token(Token = "0x402D809")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_interactId;

		// Token: 0x0402D80A RID: 186378
		[Token(Token = "0x402D80A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_tipsSeqNum;

		// Token: 0x0402D80B RID: 186379
		[Token(Token = "0x402D80B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_highestScore;

		// Token: 0x0402D80C RID: 186380
		[Token(Token = "0x402D80C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_missionProgress;

		// Token: 0x0402D80D RID: 186381
		[Token(Token = "0x402D80D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_hidePreviewSeqNum;

		// Token: 0x0402D80E RID: 186382
		[Token(Token = "0x402D80E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_UpdateFocus;

		// Token: 0x0402D80F RID: 186383
		[Token(Token = "0x402D80F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_UpdatePreviewWithNode;

		// Token: 0x0402D810 RID: 186384
		[Token(Token = "0x402D810")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UpdatePreviewWithBag;

		// Token: 0x0402D811 RID: 186385
		[Token(Token = "0x402D811")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_HidePreview;

		// Token: 0x0402D812 RID: 186386
		[Token(Token = "0x402D812")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_IsInPreview;

		// Token: 0x0402D813 RID: 186387
		[Token(Token = "0x402D813")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetPreviewInfo;

		// Token: 0x0402D814 RID: 186388
		[Token(Token = "0x402D814")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_NeedHighLight;

		// Token: 0x0402D815 RID: 186389
		[Token(Token = "0x402D815")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_IsBagFocus;

		// Token: 0x0402D816 RID: 186390
		[Token(Token = "0x402D816")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_IsNodeFocus;

		// Token: 0x0402D817 RID: 186391
		[Token(Token = "0x402D817")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_TryGetTipsInfo;

		// Token: 0x0402D818 RID: 186392
		[Token(Token = "0x402D818")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryGetExpireTime;

		// Token: 0x0402D819 RID: 186393
		[Token(Token = "0x402D819")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_LoadMap;

		// Token: 0x0402D81A RID: 186394
		[Token(Token = "0x402D81A")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__LoadMapSelectSlotFromLocalCache;

		// Token: 0x0402D81B RID: 186395
		[Token(Token = "0x402D81B")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SaveSelectSlotToLocalCache;

		// Token: 0x0402D81C RID: 186396
		[Token(Token = "0x402D81C")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_IsHardScore;

		// Token: 0x0402D81D RID: 186397
		[Token(Token = "0x402D81D")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__CalcCurrentScoreList;

		// Token: 0x0402D81E RID: 186398
		[Token(Token = "0x402D81E")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CalcSelectTotalScore;

		// Token: 0x0402D81F RID: 186399
		[Token(Token = "0x402D81F")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D820 RID: 186400
		[Token(Token = "0x402D820")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__UpdateMissionStatus;

		// Token: 0x0402D821 RID: 186401
		[Token(Token = "0x402D821")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__UpdateHighestScoreList;

		// Token: 0x0402D822 RID: 186402
		[Token(Token = "0x402D822")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__UpdateNode;

		// Token: 0x0402D823 RID: 186403
		[Token(Token = "0x402D823")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__UpdateBag;

		// Token: 0x0402D824 RID: 186404
		[Token(Token = "0x402D824")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__UpdateStartNodeSet;

		// Token: 0x0402D825 RID: 186405
		[Token(Token = "0x402D825")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__UpdateAvailNodeSet;

		// Token: 0x0402D826 RID: 186406
		[Token(Token = "0x402D826")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__AddAvailNodeImpl;

		// Token: 0x0402D827 RID: 186407
		[Token(Token = "0x402D827")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_CalcBagScoreProgress;

		// Token: 0x0402D828 RID: 186408
		[Token(Token = "0x402D828")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_IsBagAllSelected;

		// Token: 0x0402D829 RID: 186409
		[Token(Token = "0x402D829")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_GetBagStatus;

		// Token: 0x0402D82A RID: 186410
		[Token(Token = "0x402D82A")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetNodeStatus;

		// Token: 0x0402D82B RID: 186411
		[Token(Token = "0x402D82B")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__IsHighlightBag;

		// Token: 0x0402D82C RID: 186412
		[Token(Token = "0x402D82C")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GetSlotViewBagTutorialKey;

		// Token: 0x0402D82D RID: 186413
		[Token(Token = "0x402D82D")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetBagViewBagTutorialKey;

		// Token: 0x0402D82E RID: 186414
		[Token(Token = "0x402D82E")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetNodeSlotTutorialKey;

		// Token: 0x0402D82F RID: 186415
		[Token(Token = "0x402D82F")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__IsNodeSelected;

		// Token: 0x0402D830 RID: 186416
		[Token(Token = "0x402D830")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__IsNodeAvail;

		// Token: 0x0402D831 RID: 186417
		[Token(Token = "0x402D831")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__IsNodeReachable;

		// Token: 0x0402D832 RID: 186418
		[Token(Token = "0x402D832")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetRoadStatus;

		// Token: 0x0402D833 RID: 186419
		[Token(Token = "0x402D833")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__IsNodeAutoSelectInBag;

		// Token: 0x0402D834 RID: 186420
		[Token(Token = "0x402D834")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_SelectBag;

		// Token: 0x0402D835 RID: 186421
		[Token(Token = "0x402D835")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_UnselectBag;

		// Token: 0x0402D836 RID: 186422
		[Token(Token = "0x402D836")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_SelectNode;

		// Token: 0x0402D837 RID: 186423
		[Token(Token = "0x402D837")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__RefreshRuneSelectDetailList;

		// Token: 0x0402D838 RID: 186424
		[Token(Token = "0x402D838")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__SelectNode;

		// Token: 0x0402D839 RID: 186425
		[Token(Token = "0x402D839")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__SelectNodeImpl;

		// Token: 0x0402D83A RID: 186426
		[Token(Token = "0x402D83A")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_UnselectNode;

		// Token: 0x0402D83B RID: 186427
		[Token(Token = "0x402D83B")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__UnselectNode;

		// Token: 0x0402D83C RID: 186428
		[Token(Token = "0x402D83C")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_SwitchViewType;

		// Token: 0x0402D83D RID: 186429
		[Token(Token = "0x402D83D")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_ChangeViewType;

		// Token: 0x0402D83E RID: 186430
		[Token(Token = "0x402D83E")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__ChangeViewType;

		// Token: 0x0402D83F RID: 186431
		[Token(Token = "0x402D83F")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_ClearSelectNodes;

		// Token: 0x0402D840 RID: 186432
		[Token(Token = "0x402D840")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__ValidationSelectSet;

		// Token: 0x0402D841 RID: 186433
		[Token(Token = "0x402D841")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__CalcValidNodeSetImpl;

		// Token: 0x0402D842 RID: 186434
		[Token(Token = "0x402D842")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_JumpToNode;

		// Token: 0x0402D843 RID: 186435
		[Token(Token = "0x402D843")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_JumpToBag;

		// Token: 0x0402D844 RID: 186436
		[Token(Token = "0x402D844")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__JumpToDetailViewNearestBag;

		// Token: 0x0402D845 RID: 186437
		[Token(Token = "0x402D845")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__JumpToNode;

		// Token: 0x0402D846 RID: 186438
		[Token(Token = "0x402D846")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__JumpToBag;

		// Token: 0x0402D847 RID: 186439
		[Token(Token = "0x402D847")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__JumpToPos;

		// Token: 0x0402D848 RID: 186440
		[Token(Token = "0x402D848")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__GetNodeRoadStatus;

		// Token: 0x0402D849 RID: 186441
		[Token(Token = "0x402D849")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__GetTreasureRoadStatus;

		// Token: 0x0402D84A RID: 186442
		[Token(Token = "0x402D84A")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__GetBagRoadStatus;

		// Token: 0x0402D84B RID: 186443
		[Token(Token = "0x402D84B")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__LoadExclusionGroup;

		// Token: 0x0402D84C RID: 186444
		[Token(Token = "0x402D84C")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__LoadHighLightSlot;

		// Token: 0x0402D84D RID: 186445
		[Token(Token = "0x402D84D")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__LoadBag;

		// Token: 0x0402D84E RID: 186446
		[Token(Token = "0x402D84E")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__LoadNode;

		// Token: 0x0402D84F RID: 186447
		[Token(Token = "0x402D84F")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__LoadRoad;

		// Token: 0x0402D850 RID: 186448
		[Token(Token = "0x402D850")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_IsNodeExclusion;

		// Token: 0x0402D851 RID: 186449
		[Token(Token = "0x402D851")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__GetExlucsionSelectNodeId;

		// Token: 0x0402D852 RID: 186450
		[Token(Token = "0x402D852")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_GetRoadPointStyle;

		// Token: 0x0402D853 RID: 186451
		[Token(Token = "0x402D853")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_CheckIfCurMapHasBagView;

		// Token: 0x0402D854 RID: 186452
		[Token(Token = "0x402D854")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__CheckIfCurMapHasBagView;

		// Token: 0x0402D855 RID: 186453
		[Token(Token = "0x402D855")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0__RefreshSlotRuneSingleViewList;

		// Token: 0x0402D856 RID: 186454
		[Token(Token = "0x402D856")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__RefreshSlotRunePackViewList;

		// Token: 0x0402D857 RID: 186455
		[Token(Token = "0x402D857")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GetOverrideCrisisV2PermBgmEvent;

		// Token: 0x0402D858 RID: 186456
		[Token(Token = "0x402D858")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_GetSelectedRuneSlotList;

		// Token: 0x0402D859 RID: 186457
		[Token(Token = "0x402D859")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_GetPackedRuneData;

		// Token: 0x0402D85A RID: 186458
		[Token(Token = "0x402D85A")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_GenerateBattleStageInfo;

		// Token: 0x0402D85B RID: 186459
		[Token(Token = "0x402D85B")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0__RefreshRuneDetailFocusBySelect;

		// Token: 0x0402D85C RID: 186460
		[Token(Token = "0x402D85C")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__RefreshRuneDetailFocusBySwitch;

		// Token: 0x0402D85D RID: 186461
		[Token(Token = "0x402D85D")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005968 RID: 22888
		[Token(Token = "0x2005968")]
		public enum ViewType
		{
			// Token: 0x0402D85F RID: 186463
			[Token(Token = "0x402D85F")]
			NONE,
			// Token: 0x0402D860 RID: 186464
			[Token(Token = "0x402D860")]
			SLOT,
			// Token: 0x0402D861 RID: 186465
			[Token(Token = "0x402D861")]
			BAG
		}

		// Token: 0x02005969 RID: 22889
		[Token(Token = "0x2005969")]
		public enum ActionType
		{
			// Token: 0x0402D863 RID: 186467
			[Token(Token = "0x402D863")]
			NONE,
			// Token: 0x0402D864 RID: 186468
			[Token(Token = "0x402D864")]
			ADD,
			// Token: 0x0402D865 RID: 186469
			[Token(Token = "0x402D865")]
			REMOVE,
			// Token: 0x0402D866 RID: 186470
			[Token(Token = "0x402D866")]
			UNAVAIL,
			// Token: 0x0402D867 RID: 186471
			[Token(Token = "0x402D867")]
			HIGHLIGHT
		}

		// Token: 0x0200596A RID: 22890
		[Token(Token = "0x200596A")]
		public enum TargetType
		{
			// Token: 0x0402D869 RID: 186473
			[Token(Token = "0x402D869")]
			NONE,
			// Token: 0x0402D86A RID: 186474
			[Token(Token = "0x402D86A")]
			NODE,
			// Token: 0x0402D86B RID: 186475
			[Token(Token = "0x402D86B")]
			BAG
		}

		// Token: 0x0200596B RID: 22891
		[Token(Token = "0x200596B")]
		private class CrisisV2FocusModel : IHotfixable
		{
			// Token: 0x17004E75 RID: 20085
			// (get) Token: 0x0602161B RID: 136731 RVA: 0x000B9F40 File Offset: 0x000B8140
			[Token(Token = "0x17004E75")]
			public int interactId
			{
				[Token(Token = "0x602161B")]
				[Address(RVA = "0x1BC1590", Offset = "0x1BC0190", VA = "0x181BC1590")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17004E76 RID: 20086
			// (get) Token: 0x0602161C RID: 136732 RVA: 0x000B9F58 File Offset: 0x000B8158
			[Token(Token = "0x17004E76")]
			public int tipsSeqNum
			{
				[Token(Token = "0x602161C")]
				[Address(RVA = "0x1BC16B0", Offset = "0x1BC02B0", VA = "0x181BC16B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17004E77 RID: 20087
			// (get) Token: 0x0602161D RID: 136733 RVA: 0x000B9F70 File Offset: 0x000B8170
			[Token(Token = "0x17004E77")]
			public CrisisV2MapModel.ActionType actionType
			{
				[Token(Token = "0x602161D")]
				[Address(RVA = "0x1BC1530", Offset = "0x1BC0130", VA = "0x181BC1530")]
				get
				{
					return CrisisV2MapModel.ActionType.NONE;
				}
			}

			// Token: 0x17004E78 RID: 20088
			// (get) Token: 0x0602161E RID: 136734 RVA: 0x000B9F88 File Offset: 0x000B8188
			[Token(Token = "0x17004E78")]
			public CrisisV2MapModel.TargetType targetType
			{
				[Token(Token = "0x602161E")]
				[Address(RVA = "0x1BC1650", Offset = "0x1BC0250", VA = "0x181BC1650")]
				get
				{
					return CrisisV2MapModel.TargetType.NONE;
				}
			}

			// Token: 0x17004E79 RID: 20089
			// (get) Token: 0x0602161F RID: 136735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004E79")]
			public string targetId
			{
				[Token(Token = "0x602161F")]
				[Address(RVA = "0x1BC15F0", Offset = "0x1BC01F0", VA = "0x181BC15F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06021620 RID: 136736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021620")]
			[Address(RVA = "0x1BC11F0", Offset = "0x1BBFDF0", VA = "0x181BC11F0")]
			public void FoucusOn(CrisisV2MapModel.TargetType targetType, string targetId, CrisisV2MapModel.ActionType actionType)
			{
			}

			// Token: 0x06021621 RID: 136737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021621")]
			[Address(RVA = "0x1BC13E0", Offset = "0x1BBFFE0", VA = "0x181BC13E0")]
			private void _UpdateTipsSeqNumIfNecessary()
			{
			}

			// Token: 0x06021622 RID: 136738 RVA: 0x000B9FA0 File Offset: 0x000B81A0
			[Token(Token = "0x6021622")]
			[Address(RVA = "0x1BC1370", Offset = "0x1BBFF70", VA = "0x181BC1370")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06021623 RID: 136739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021623")]
			[Address(RVA = "0x1BC1180", Offset = "0x1BBFD80", VA = "0x181BC1180")]
			public void Clear()
			{
			}

			// Token: 0x06021624 RID: 136740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021624")]
			[Address(RVA = "0x1BC14D0", Offset = "0x1BC00D0", VA = "0x181BC14D0")]
			public CrisisV2FocusModel()
			{
			}

			// Token: 0x0402D86C RID: 186476
			[Token(Token = "0x402D86C")]
			[FieldOffset(Offset = "0x10")]
			private int m_interactId;

			// Token: 0x0402D86D RID: 186477
			[Token(Token = "0x402D86D")]
			[FieldOffset(Offset = "0x14")]
			private int m_tipsSeqNum;

			// Token: 0x0402D86E RID: 186478
			[Token(Token = "0x402D86E")]
			[FieldOffset(Offset = "0x18")]
			private CrisisV2MapModel.ActionType m_actionType;

			// Token: 0x0402D86F RID: 186479
			[Token(Token = "0x402D86F")]
			[FieldOffset(Offset = "0x1C")]
			private CrisisV2MapModel.TargetType m_targetType;

			// Token: 0x0402D870 RID: 186480
			[Token(Token = "0x402D870")]
			[FieldOffset(Offset = "0x20")]
			private string m_targetId;

			// Token: 0x0402D871 RID: 186481
			[Token(Token = "0x402D871")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_interactId;

			// Token: 0x0402D872 RID: 186482
			[Token(Token = "0x402D872")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_tipsSeqNum;

			// Token: 0x0402D873 RID: 186483
			[Token(Token = "0x402D873")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_actionType;

			// Token: 0x0402D874 RID: 186484
			[Token(Token = "0x402D874")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_targetType;

			// Token: 0x0402D875 RID: 186485
			[Token(Token = "0x402D875")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_targetId;

			// Token: 0x0402D876 RID: 186486
			[Token(Token = "0x402D876")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_FoucusOn;

			// Token: 0x0402D877 RID: 186487
			[Token(Token = "0x402D877")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__UpdateTipsSeqNumIfNecessary;

			// Token: 0x0402D878 RID: 186488
			[Token(Token = "0x402D878")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x0402D879 RID: 186489
			[Token(Token = "0x402D879")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Clear;

			// Token: 0x0402D87A RID: 186490
			[Token(Token = "0x402D87A")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200596C RID: 22892
		[Token(Token = "0x200596C")]
		private class CrisisV2PreviewModel : IHotfixable
		{
			// Token: 0x17004E7A RID: 20090
			// (get) Token: 0x06021625 RID: 136741 RVA: 0x000B9FB8 File Offset: 0x000B81B8
			[Token(Token = "0x17004E7A")]
			public int hidePreviewSeqNum
			{
				[Token(Token = "0x6021625")]
				[Address(RVA = "0x1BCB670", Offset = "0x1BCA270", VA = "0x181BCB670")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021626 RID: 136742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021626")]
			[Address(RVA = "0x1BCB4F0", Offset = "0x1BCA0F0", VA = "0x181BCB4F0")]
			public void UpdatePreview(CrisisV2PreviewInfo info)
			{
			}

			// Token: 0x06021627 RID: 136743 RVA: 0x000B9FD0 File Offset: 0x000B81D0
			[Token(Token = "0x6021627")]
			[Address(RVA = "0x1BCB2B0", Offset = "0x1BC9EB0", VA = "0x181BCB2B0")]
			public int HidePreview()
			{
				return 0;
			}

			// Token: 0x06021628 RID: 136744 RVA: 0x000B9FE8 File Offset: 0x000B81E8
			[Token(Token = "0x6021628")]
			[Address(RVA = "0x1BCB210", Offset = "0x1BC9E10", VA = "0x181BCB210")]
			public CrisisV2PreviewInfo GetPreviewInfo()
			{
				return default(CrisisV2PreviewInfo);
			}

			// Token: 0x06021629 RID: 136745 RVA: 0x000BA000 File Offset: 0x000B8200
			[Token(Token = "0x6021629")]
			[Address(RVA = "0x1BCB3C0", Offset = "0x1BC9FC0", VA = "0x181BCB3C0")]
			public bool IsInPreview()
			{
				return default(bool);
			}

			// Token: 0x0602162A RID: 136746 RVA: 0x000BA018 File Offset: 0x000B8218
			[Token(Token = "0x602162A")]
			[Address(RVA = "0x1BCB420", Offset = "0x1BCA020", VA = "0x181BCB420")]
			public bool NeedHighLight(string nodeOrBagId)
			{
				return default(bool);
			}

			// Token: 0x0602162B RID: 136747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602162B")]
			[Address(RVA = "0x1BCB5B0", Offset = "0x1BCA1B0", VA = "0x181BCB5B0")]
			public CrisisV2PreviewModel()
			{
			}

			// Token: 0x0402D87B RID: 186491
			[Token(Token = "0x402D87B")]
			[FieldOffset(Offset = "0x10")]
			private CrisisV2PreviewInfo m_previewInfo;

			// Token: 0x0402D87C RID: 186492
			[Token(Token = "0x402D87C")]
			[FieldOffset(Offset = "0x48")]
			private int m_hidePreviewSeqNum;

			// Token: 0x0402D87D RID: 186493
			[Token(Token = "0x402D87D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hidePreviewSeqNum;

			// Token: 0x0402D87E RID: 186494
			[Token(Token = "0x402D87E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdatePreview;

			// Token: 0x0402D87F RID: 186495
			[Token(Token = "0x402D87F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HidePreview;

			// Token: 0x0402D880 RID: 186496
			[Token(Token = "0x402D880")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreviewInfo;

			// Token: 0x0402D881 RID: 186497
			[Token(Token = "0x402D881")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsInPreview;

			// Token: 0x0402D882 RID: 186498
			[Token(Token = "0x402D882")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_NeedHighLight;

			// Token: 0x0402D883 RID: 186499
			[Token(Token = "0x402D883")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
