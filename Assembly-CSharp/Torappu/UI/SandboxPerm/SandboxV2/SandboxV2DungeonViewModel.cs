using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042F5 RID: 17141
	[Token(Token = "0x20042F5")]
	public class SandboxV2DungeonViewModel : IHotfixable
	{
		// Token: 0x0601A56D RID: 107885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A56D")]
		[Address(RVA = "0x1345750", Offset = "0x1344350", VA = "0x181345750")]
		private void _IncreaseSequenceNum(SandboxV2DungeonViewModel.SequenceNumFlag flag)
		{
		}

		// Token: 0x0601A56E RID: 107886 RVA: 0x000A15E0 File Offset: 0x0009F7E0
		[Token(Token = "0x601A56E")]
		[Address(RVA = "0x13453F0", Offset = "0x1343FF0", VA = "0x1813453F0")]
		private int _GetSequenceNum(SandboxV2DungeonViewModel.SequenceNumFlag flag)
		{
			return 0;
		}

		// Token: 0x0601A56F RID: 107887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A56F")]
		[Address(RVA = "0x1344940", Offset = "0x1343540", VA = "0x181344940")]
		public void LoadData(string topic, [Optional] SandboxV2DungeonViewModel.LoadDataParam param)
		{
		}

		// Token: 0x0601A570 RID: 107888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A570")]
		[Address(RVA = "0x1345810", Offset = "0x1344410", VA = "0x181345810")]
		private void _LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData, PlayerSandboxV2.Dungeon playerDungeonData, SandboxV2DungeonViewModel.LoadDataParam param)
		{
		}

		// Token: 0x0601A571 RID: 107889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A571")]
		[Address(RVA = "0x1346FE0", Offset = "0x1345BE0", VA = "0x181346FE0")]
		private void _UpdateData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A572 RID: 107890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A572")]
		[Address(RVA = "0x1348280", Offset = "0x1346E80", VA = "0x181348280")]
		private void _UpdatePathData(SandboxV2DungeonFloatViewModel floatViewModel)
		{
		}

		// Token: 0x0601A573 RID: 107891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A573")]
		[Address(RVA = "0x1347B30", Offset = "0x1346730", VA = "0x181347B30")]
		private void _UpdateEnemyRushData(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A574 RID: 107892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A574")]
		[Address(RVA = "0x1348AF0", Offset = "0x13476F0", VA = "0x181348AF0")]
		private void _UpdateRareAnimalData(SandboxV2Data topicDetailData, PlayerSandboxV2.Dungeon playerDungeonData)
		{
		}

		// Token: 0x0601A575 RID: 107893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A575")]
		[Address(RVA = "0x1348DE0", Offset = "0x13479E0", VA = "0x181348DE0")]
		private void _UpdateRiftFloatData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A576 RID: 107894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A576")]
		[Address(RVA = "0x1348060", Offset = "0x1346C60", VA = "0x181348060")]
		private void _UpdateNodeFloatData()
		{
		}

		// Token: 0x0601A577 RID: 107895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A577")]
		[Address(RVA = "0x13487D0", Offset = "0x13473D0", VA = "0x1813487D0")]
		private void _UpdateQuestData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerSandboxData)
		{
		}

		// Token: 0x0601A578 RID: 107896 RVA: 0x000A15F8 File Offset: 0x0009F7F8
		[Token(Token = "0x601A578")]
		[Address(RVA = "0x1345480", Offset = "0x1344080", VA = "0x181345480")]
		private bool _HasQuest(SandboxV2Data topicDetailData, PlayerSandboxV2 playerSandboxData)
		{
			return default(bool);
		}

		// Token: 0x0601A579 RID: 107897 RVA: 0x000A1610 File Offset: 0x0009F810
		[Token(Token = "0x601A579")]
		[Address(RVA = "0x1345630", Offset = "0x1344230", VA = "0x181345630")]
		private bool _HasRiftQuest(SandboxV2Data topicDetailData)
		{
			return default(bool);
		}

		// Token: 0x0601A57A RID: 107898 RVA: 0x000A1628 File Offset: 0x0009F828
		[Token(Token = "0x601A57A")]
		[Address(RVA = "0x1345310", Offset = "0x1343F10", VA = "0x181345310")]
		private SandboxV2DungeonViewModel.ChallengeState _GetCurrChallengeState(PlayerSandboxV2.Status playerStatus, PlayerSandboxV2.Dungeon playerDungeonData)
		{
			return SandboxV2DungeonViewModel.ChallengeState.NONE;
		}

		// Token: 0x0601A57B RID: 107899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A57B")]
		[Address(RVA = "0x1344790", Offset = "0x1343390", VA = "0x181344790")]
		public SandboxV2DungeonNodeViewModel GetNodeViewModel(string nodeId)
		{
			return null;
		}

		// Token: 0x0601A57C RID: 107900 RVA: 0x000A1640 File Offset: 0x0009F840
		[Token(Token = "0x601A57C")]
		[Address(RVA = "0x1344470", Offset = "0x1343070", VA = "0x181344470")]
		public bool CheckNodeSelected(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A57D RID: 107901 RVA: 0x000A1658 File Offset: 0x0009F858
		[Token(Token = "0x601A57D")]
		[Address(RVA = "0x1344840", Offset = "0x1343440", VA = "0x181344840")]
		public bool HasBossEnemyRush()
		{
			return default(bool);
		}

		// Token: 0x0601A57E RID: 107902 RVA: 0x000A1670 File Offset: 0x0009F870
		[Token(Token = "0x601A57E")]
		[Address(RVA = "0x1344200", Offset = "0x1342E00", VA = "0x181344200")]
		public bool CanSelectNode(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A57F RID: 107903 RVA: 0x000A1688 File Offset: 0x0009F888
		[Token(Token = "0x601A57F")]
		[Address(RVA = "0x1344DD0", Offset = "0x13439D0", VA = "0x181344DD0")]
		public bool SetSelectedNode(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A580 RID: 107904 RVA: 0x000A16A0 File Offset: 0x0009F8A0
		[Token(Token = "0x601A580")]
		[Address(RVA = "0x1344340", Offset = "0x1342F40", VA = "0x181344340")]
		public bool CancelSelectedNode()
		{
			return default(bool);
		}

		// Token: 0x0601A581 RID: 107905 RVA: 0x000A16B8 File Offset: 0x0009F8B8
		[Token(Token = "0x601A581")]
		[Address(RVA = "0x1344F60", Offset = "0x1343B60", VA = "0x181344F60")]
		public bool SetSelectedPath(string pathId)
		{
			return default(bool);
		}

		// Token: 0x0601A582 RID: 107906 RVA: 0x000A16D0 File Offset: 0x0009F8D0
		[Token(Token = "0x601A582")]
		[Address(RVA = "0x13443F0", Offset = "0x1342FF0", VA = "0x1813443F0")]
		public bool CancelSelectedPath()
		{
			return default(bool);
		}

		// Token: 0x0601A583 RID: 107907 RVA: 0x000A16E8 File Offset: 0x0009F8E8
		[Token(Token = "0x601A583")]
		[Address(RVA = "0x1344D20", Offset = "0x1343920", VA = "0x181344D20")]
		public bool SetSelectedFloatGroup(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A584 RID: 107908 RVA: 0x000A1700 File Offset: 0x0009F900
		[Token(Token = "0x601A584")]
		[Address(RVA = "0x13442C0", Offset = "0x1342EC0", VA = "0x1813442C0")]
		public bool CancelSelectedFloatGroup()
		{
			return default(bool);
		}

		// Token: 0x0601A585 RID: 107909 RVA: 0x000A1718 File Offset: 0x0009F918
		[Token(Token = "0x601A585")]
		[Address(RVA = "0x1344510", Offset = "0x1343110", VA = "0x181344510")]
		public bool FocusNode(string nodeId, SandboxV2DungeonNodeFocusType focusType, bool fastMode = false, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return default(bool);
		}

		// Token: 0x0601A586 RID: 107910 RVA: 0x000A1730 File Offset: 0x0009F930
		[Token(Token = "0x601A586")]
		[Address(RVA = "0x1344660", Offset = "0x1343260", VA = "0x181344660")]
		public bool FocusZone(string zoneId, bool fastMode = false, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return default(bool);
		}

		// Token: 0x0601A587 RID: 107911 RVA: 0x000A1748 File Offset: 0x0009F948
		[Token(Token = "0x601A587")]
		[Address(RVA = "0x1345200", Offset = "0x1343E00", VA = "0x181345200")]
		public bool Zoom(SandboxV2DungeonCameraController.ZoomType zoomType, string nodeId, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return default(bool);
		}

		// Token: 0x0601A588 RID: 107912 RVA: 0x000A1760 File Offset: 0x0009F960
		[Token(Token = "0x601A588")]
		[Address(RVA = "0x1344C70", Offset = "0x1343870", VA = "0x181344C70")]
		public bool SetEnterAnimStatus(bool playEnterAnim, bool fastMode = false)
		{
			return default(bool);
		}

		// Token: 0x0601A589 RID: 107913 RVA: 0x000A1778 File Offset: 0x0009F978
		[Token(Token = "0x601A589")]
		[Address(RVA = "0x1345150", Offset = "0x1343D50", VA = "0x181345150")]
		public bool TutorialOnly_RegisterNode(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A58A RID: 107914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A58A")]
		[Address(RVA = "0x1345010", Offset = "0x1343C10", VA = "0x181345010")]
		public string TutorialOnly_GetNodeIdByEnemyRushGroupKey(string enemyRushGroupKey)
		{
			return null;
		}

		// Token: 0x0601A58B RID: 107915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A58B")]
		[Address(RVA = "0x1348FA0", Offset = "0x1347BA0", VA = "0x181348FA0")]
		public SandboxV2DungeonViewModel()
		{
		}

		// Token: 0x040216C7 RID: 136903
		[Token(Token = "0x40216C7")]
		private const string LINE_ID_FORMAT = "{0}|{1}";

		// Token: 0x040216C8 RID: 136904
		[Token(Token = "0x40216C8")]
		private const string PATH_ID_FORMAT = "{0}|{1}|{2}";

		// Token: 0x040216C9 RID: 136905
		[Token(Token = "0x40216C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<SandboxV2DungeonViewModel.SequenceNumFlag, int> m_sequenceNums;

		// Token: 0x040216CA RID: 136906
		[Token(Token = "0x40216CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x040216CB RID: 136907
		[Token(Token = "0x40216CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x040216CC RID: 136908
		[Token(Token = "0x40216CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string centerNodeId;

		// Token: 0x040216CD RID: 136909
		[Token(Token = "0x40216CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string monthModeNodeId;

		// Token: 0x040216CE RID: 136910
		[Token(Token = "0x40216CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float centerNodeEnterAnimDelay;

		// Token: 0x040216CF RID: 136911
		[Token(Token = "0x40216CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SandboxV2MapConfig mapConfig;

		// Token: 0x040216D0 RID: 136912
		[Token(Token = "0x40216D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SandboxV2DungeonGameflowViewModel gameflowViewModel;

		// Token: 0x040216D1 RID: 136913
		[Token(Token = "0x40216D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SandboxV2DungeonMiscViewModel miscViewModel;

		// Token: 0x040216D2 RID: 136914
		[Token(Token = "0x40216D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<string, SandboxV2DungeonZoneViewModel> zones;

		// Token: 0x040216D3 RID: 136915
		[Token(Token = "0x40216D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Dictionary<string, SandboxV2DungeonNodeViewModel> nodes;

		// Token: 0x040216D4 RID: 136916
		[Token(Token = "0x40216D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dictionary<string, SandboxV2DungeonLineViewModel> lines;

		// Token: 0x040216D5 RID: 136917
		[Token(Token = "0x40216D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Dictionary<string, SandboxV2DungeonPathLineViewModel> pathLines;

		// Token: 0x040216D6 RID: 136918
		[Token(Token = "0x40216D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<SandboxV2DungeonNodeViewModel> nodeList;

		// Token: 0x040216D7 RID: 136919
		[Token(Token = "0x40216D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<SandboxV2DungeonEnemyRushViewModel> enemyRushList;

		// Token: 0x040216D8 RID: 136920
		[Token(Token = "0x40216D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SandboxV2DungeonViewModel.ChallengeState challengeState;

		// Token: 0x040216D9 RID: 136921
		[Token(Token = "0x40216D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool needPlayEnterAnim;

		// Token: 0x040216DA RID: 136922
		[Token(Token = "0x40216DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		public bool fastModeWhenDungeonChange;

		// Token: 0x040216DB RID: 136923
		[Token(Token = "0x40216DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
		public bool hasQuestTracker;

		// Token: 0x040216DC RID: 136924
		[Token(Token = "0x40216DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int otherTrackerCount;

		// Token: 0x040216DD RID: 136925
		[Token(Token = "0x40216DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool isBasementEmergency;

		// Token: 0x040216DE RID: 136926
		[Token(Token = "0x40216DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		public bool hasEmergencyEnemyRush;

		// Token: 0x040216DF RID: 136927
		[Token(Token = "0x40216DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string selectedNodeId;

		// Token: 0x040216E0 RID: 136928
		[Token(Token = "0x40216E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string selectedPathId;

		// Token: 0x040216E1 RID: 136929
		[Token(Token = "0x40216E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string selectedFloatGroupNodeId;

		// Token: 0x040216E2 RID: 136930
		[Token(Token = "0x40216E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SandboxV2DungeonViewModel.FocusParam focusParam;

		// Token: 0x040216E3 RID: 136931
		[Token(Token = "0x40216E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public SandboxV2DungeonViewModel.NodeRegisterParam registerParam;

		// Token: 0x040216E4 RID: 136932
		[Token(Token = "0x40216E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public SandboxV2DungeonViewModel.EnterAnimParam enterAnimParam;

		// Token: 0x040216E5 RID: 136933
		[Token(Token = "0x40216E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__IncreaseSequenceNum;

		// Token: 0x040216E6 RID: 136934
		[Token(Token = "0x40216E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetSequenceNum;

		// Token: 0x040216E7 RID: 136935
		[Token(Token = "0x40216E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040216E8 RID: 136936
		[Token(Token = "0x40216E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040216E9 RID: 136937
		[Token(Token = "0x40216E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040216EA RID: 136938
		[Token(Token = "0x40216EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdatePathData;

		// Token: 0x040216EB RID: 136939
		[Token(Token = "0x40216EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateEnemyRushData;

		// Token: 0x040216EC RID: 136940
		[Token(Token = "0x40216EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRareAnimalData;

		// Token: 0x040216ED RID: 136941
		[Token(Token = "0x40216ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateRiftFloatData;

		// Token: 0x040216EE RID: 136942
		[Token(Token = "0x40216EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateNodeFloatData;

		// Token: 0x040216EF RID: 136943
		[Token(Token = "0x40216EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateQuestData;

		// Token: 0x040216F0 RID: 136944
		[Token(Token = "0x40216F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HasQuest;

		// Token: 0x040216F1 RID: 136945
		[Token(Token = "0x40216F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HasRiftQuest;

		// Token: 0x040216F2 RID: 136946
		[Token(Token = "0x40216F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetCurrChallengeState;

		// Token: 0x040216F3 RID: 136947
		[Token(Token = "0x40216F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetNodeViewModel;

		// Token: 0x040216F4 RID: 136948
		[Token(Token = "0x40216F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckNodeSelected;

		// Token: 0x040216F5 RID: 136949
		[Token(Token = "0x40216F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HasBossEnemyRush;

		// Token: 0x040216F6 RID: 136950
		[Token(Token = "0x40216F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CanSelectNode;

		// Token: 0x040216F7 RID: 136951
		[Token(Token = "0x40216F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetSelectedNode;

		// Token: 0x040216F8 RID: 136952
		[Token(Token = "0x40216F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CancelSelectedNode;

		// Token: 0x040216F9 RID: 136953
		[Token(Token = "0x40216F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetSelectedPath;

		// Token: 0x040216FA RID: 136954
		[Token(Token = "0x40216FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CancelSelectedPath;

		// Token: 0x040216FB RID: 136955
		[Token(Token = "0x40216FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SetSelectedFloatGroup;

		// Token: 0x040216FC RID: 136956
		[Token(Token = "0x40216FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CancelSelectedFloatGroup;

		// Token: 0x040216FD RID: 136957
		[Token(Token = "0x40216FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_FocusNode;

		// Token: 0x040216FE RID: 136958
		[Token(Token = "0x40216FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_FocusZone;

		// Token: 0x040216FF RID: 136959
		[Token(Token = "0x40216FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_Zoom;

		// Token: 0x04021700 RID: 136960
		[Token(Token = "0x4021700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetEnterAnimStatus;

		// Token: 0x04021701 RID: 136961
		[Token(Token = "0x4021701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterNode;

		// Token: 0x04021702 RID: 136962
		[Token(Token = "0x4021702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetNodeIdByEnemyRushGroupKey;

		// Token: 0x04021703 RID: 136963
		[Token(Token = "0x4021703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042F6 RID: 17142
		[Token(Token = "0x20042F6")]
		public enum SequenceNumFlag
		{
			// Token: 0x04021705 RID: 136965
			[Token(Token = "0x4021705")]
			NONE,
			// Token: 0x04021706 RID: 136966
			[Token(Token = "0x4021706")]
			DUNGEON_CONSTRUCT,
			// Token: 0x04021707 RID: 136967
			[Token(Token = "0x4021707")]
			DUNGEON_CHANGE,
			// Token: 0x04021708 RID: 136968
			[Token(Token = "0x4021708")]
			NODE_SELECTION,
			// Token: 0x04021709 RID: 136969
			[Token(Token = "0x4021709")]
			PATH_SELECTION,
			// Token: 0x0402170A RID: 136970
			[Token(Token = "0x402170A")]
			FLOAT_GROUP_SELECTION,
			// Token: 0x0402170B RID: 136971
			[Token(Token = "0x402170B")]
			DUNGEON_FOCUS,
			// Token: 0x0402170C RID: 136972
			[Token(Token = "0x402170C")]
			ENTER_ANIM,
			// Token: 0x0402170D RID: 136973
			[Token(Token = "0x402170D")]
			TUTORIAL_ONLY_NODE_REGISTER
		}

		// Token: 0x020042F7 RID: 17143
		[Token(Token = "0x20042F7")]
		public struct SeqNumChecker
		{
			// Token: 0x0601A58C RID: 107916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A58C")]
			[Address(RVA = "0x13557D0", Offset = "0x13543D0", VA = "0x1813557D0")]
			public SeqNumChecker(SandboxV2DungeonViewModel.SequenceNumFlag flag)
			{
			}

			// Token: 0x0601A58D RID: 107917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A58D")]
			[Address(RVA = "0x13556F0", Offset = "0x13542F0", VA = "0x1813556F0")]
			public SeqNumChecker(SandboxV2DungeonViewModel.SequenceNumFlag[] flag)
			{
			}

			// Token: 0x0601A58E RID: 107918 RVA: 0x000A1790 File Offset: 0x0009F990
			[Token(Token = "0x601A58E")]
			[Address(RVA = "0x1355590", Offset = "0x1354190", VA = "0x181355590")]
			public bool Updated(SandboxV2DungeonViewModel viewModel)
			{
				return default(bool);
			}

			// Token: 0x0402170E RID: 136974
			[Token(Token = "0x402170E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private SandboxV2DungeonViewModel.SequenceNumFlag[] m_flag;

			// Token: 0x0402170F RID: 136975
			[Token(Token = "0x402170F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int[] m_seqNum;
		}

		// Token: 0x020042F8 RID: 17144
		[Token(Token = "0x20042F8")]
		public struct LoadDataParam
		{
			// Token: 0x04021710 RID: 136976
			[Token(Token = "0x4021710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool fastMode;

			// Token: 0x04021711 RID: 136977
			[Token(Token = "0x4021711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool needPlayEnterAnim;

			// Token: 0x04021712 RID: 136978
			[Token(Token = "0x4021712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string preferredFocusNodeId;

			// Token: 0x04021713 RID: 136979
			[Token(Token = "0x4021713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isMonthMode;
		}

		// Token: 0x020042F9 RID: 17145
		[Token(Token = "0x20042F9")]
		public struct FocusParam
		{
			// Token: 0x04021714 RID: 136980
			[Token(Token = "0x4021714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string focusNodeId;

			// Token: 0x04021715 RID: 136981
			[Token(Token = "0x4021715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonNodeFocusPosType focusPosType;

			// Token: 0x04021716 RID: 136982
			[Token(Token = "0x4021716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool fastMode;

			// Token: 0x04021717 RID: 136983
			[Token(Token = "0x4021717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string focusZoneId;

			// Token: 0x04021718 RID: 136984
			[Token(Token = "0x4021718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SandboxV2DungeonFocusType focusType;

			// Token: 0x04021719 RID: 136985
			[Token(Token = "0x4021719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			// Token: 0x0402171A RID: 136986
			[Token(Token = "0x402171A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Ease easeType;

			// Token: 0x0402171B RID: 136987
			[Token(Token = "0x402171B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public SandboxV2DungeonCameraController.ZoomType zoomType;
		}

		// Token: 0x020042FA RID: 17146
		[Token(Token = "0x20042FA")]
		public struct NodeRegisterParam
		{
			// Token: 0x0402171C RID: 136988
			[Token(Token = "0x402171C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string registerNodeId;
		}

		// Token: 0x020042FB RID: 17147
		[Token(Token = "0x20042FB")]
		public struct EnterAnimParam
		{
			// Token: 0x0402171D RID: 136989
			[Token(Token = "0x402171D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool playedEnterAnim;

			// Token: 0x0402171E RID: 136990
			[Token(Token = "0x402171E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool fastMode;
		}

		// Token: 0x020042FC RID: 17148
		[Token(Token = "0x20042FC")]
		public enum ChallengeState
		{
			// Token: 0x04021720 RID: 136992
			[Token(Token = "0x4021720")]
			NONE,
			// Token: 0x04021721 RID: 136993
			[Token(Token = "0x4021721")]
			INACTIVE,
			// Token: 0x04021722 RID: 136994
			[Token(Token = "0x4021722")]
			FIRST_CROSS_DAY,
			// Token: 0x04021723 RID: 136995
			[Token(Token = "0x4021723")]
			ACTIVE
		}
	}
}
