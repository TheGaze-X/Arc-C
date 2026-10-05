using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200581F RID: 22559
	[Token(Token = "0x200581F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RL03TotemDataUtil
	{
		// Token: 0x06020F65 RID: 135013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F65")]
		[Address(RVA = "0x1B56A20", Offset = "0x1B55620", VA = "0x181B56A20")]
		private static void _SyncCacheTotemCollectionFromPlayerData(string topicId, ref List<RL03TotemViewModel> totemViewModels)
		{
		}

		// Token: 0x06020F66 RID: 135014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F66")]
		[Address(RVA = "0x1B551A0", Offset = "0x1B53DA0", VA = "0x181B551A0")]
		public static void LoadTotemViewModelsSplit(string topicId, ref List<RL03TotemViewModel> totemViewModels, ref List<RL03TotemViewModel> locationTotemViewModels, ref List<RL03TotemViewModel> effectTotemViewModels)
		{
		}

		// Token: 0x06020F67 RID: 135015 RVA: 0x000B7FA8 File Offset: 0x000B61A8
		[Token(Token = "0x6020F67")]
		[Address(RVA = "0x1B54B20", Offset = "0x1B53720", VA = "0x181B54B20")]
		public static int GetTotemCombineCountAgainstCollectionWithUpdate(string topicId, ref List<RL03TotemViewModel> totemModelList, RL03TotemViewModel srcTotemModel)
		{
			return 0;
		}

		// Token: 0x06020F68 RID: 135016 RVA: 0x000B7FC0 File Offset: 0x000B61C0
		[Token(Token = "0x6020F68")]
		[Address(RVA = "0x1B54C80", Offset = "0x1B53880", VA = "0x181B54C80")]
		public static bool IsBossCombineGroupName(string combineGroupName)
		{
			return default(bool);
		}

		// Token: 0x06020F69 RID: 135017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F69")]
		[Address(RVA = "0x1B54CF0", Offset = "0x1B538F0", VA = "0x181B54CF0")]
		public static string LoadCombineDesc(string topicId, string combineGroupName, RoguelikeTotemColorType colorType)
		{
			return null;
		}

		// Token: 0x06020F6A RID: 135018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F6A")]
		[Address(RVA = "0x1B553E0", Offset = "0x1B53FE0", VA = "0x181B553E0")]
		public static RL03TotemViewModel PickResonanceMainTotemViewModel(RL03TotemViewModel location, RL03TotemViewModel effect)
		{
			return null;
		}

		// Token: 0x06020F6B RID: 135019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F6B")]
		[Address(RVA = "0x1B54980", Offset = "0x1B53580", VA = "0x181B54980")]
		public static string FormatTotemFullDesc(RL03TotemViewModel totemViewModel, bool isResonance = false)
		{
			return null;
		}

		// Token: 0x06020F6C RID: 135020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F6C")]
		[Address(RVA = "0x1B54F00", Offset = "0x1B53B00", VA = "0x181B54F00")]
		public static void LoadLocationTotemSelectableResult(string topicId, List<RL03TotemViewModel> locationTotemViewModels, ref Dictionary<string, LocationTotemMapSelectResult> locationTotemMapSelectResultDict)
		{
		}

		// Token: 0x06020F6D RID: 135021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F6D")]
		[Address(RVA = "0x1B56400", Offset = "0x1B55000", VA = "0x181B56400")]
		private static LocationTotemMapSelectResult _GeneLocationTotemSelectResult(RoguelikeDungeonZone curZone, int curDepth, int curIndex, bool isInPortal, RL03TotemViewModel locationTotemViewModel)
		{
			return null;
		}

		// Token: 0x06020F6E RID: 135022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F6E")]
		[Address(RVA = "0x1B55C70", Offset = "0x1B54870", VA = "0x181B55C70")]
		private static void _FindSelectableNodeWithOnlyForVert(RoguelikeDungeonZone curZone, int curDepth, bool isInPortal, RL03TotemViewModel locationTotemViewModel, ref HashSet<string> selectNodeSet)
		{
		}

		// Token: 0x06020F6F RID: 135023 RVA: 0x000B7FD8 File Offset: 0x000B61D8
		[Token(Token = "0x6020F6F")]
		[Address(RVA = "0x1B55A70", Offset = "0x1B54670", VA = "0x181B55A70")]
		private static bool _CheckNodeValidInOnlyForVertMode(RoguelikeDungeonNode node, int curDepth, bool isInPortal, RL03TotemViewModel locationTotemViewModel, ref List<RoguelikeDungeonNode> validBroNodeList)
		{
			return default(bool);
		}

		// Token: 0x06020F70 RID: 135024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F70")]
		[Address(RVA = "0x1B56080", Offset = "0x1B54C80", VA = "0x181B56080")]
		private static void _FindSelectableNodesWithExpandLength(RoguelikeDungeonZone curZone, int curDepth, bool isInPortal, RL03TotemViewModel locationTotemViewModel, ref HashSet<string> selectNodeSet)
		{
		}

		// Token: 0x06020F71 RID: 135025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F71")]
		[Address(RVA = "0x1B56700", Offset = "0x1B55300", VA = "0x181B56700")]
		private static void _NodeWithExpandLengthDFSHelper(RoguelikeDungeonNode node, int curDepth, bool isInPortal, RL03TotemViewModel locationTotemViewModel, ref List<RoguelikeDungeonNode> pathList, ref List<List<RoguelikeDungeonNode>> resultList)
		{
		}

		// Token: 0x06020F72 RID: 135026 RVA: 0x000B7FF0 File Offset: 0x000B61F0
		[Token(Token = "0x6020F72")]
		[Address(RVA = "0x1B55990", Offset = "0x1B54590", VA = "0x181B55990")]
		private static bool _CheckNodeValidInExpandLengthMode(RoguelikeDungeonNode node, int curDepth, bool isInPortal, RL03TotemViewModel locationTotemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020F73 RID: 135027 RVA: 0x000B8008 File Offset: 0x000B6208
		[Token(Token = "0x6020F73")]
		[Address(RVA = "0x1B556C0", Offset = "0x1B542C0", VA = "0x181B556C0")]
		private static bool _CheckIfNodeSelectable(RoguelikeDungeonZone curZone, int curDepth, int curIndex, bool isInPortal, RoguelikeDungeonNode node, RL03TotemViewModel locationTotemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020F74 RID: 135028 RVA: 0x000B8020 File Offset: 0x000B6220
		[Token(Token = "0x6020F74")]
		[Address(RVA = "0x1B555B0", Offset = "0x1B541B0", VA = "0x181B555B0")]
		private static bool _CheckIfNodeIsDirectDescendant(RoguelikeDungeonNode node, RoguelikeDungeonNode targetNode)
		{
			return default(bool);
		}

		// Token: 0x06020F75 RID: 135029 RVA: 0x000B8038 File Offset: 0x000B6238
		[Token(Token = "0x6020F75")]
		[Address(RVA = "0x1B55810", Offset = "0x1B54410", VA = "0x181B55810")]
		private static bool _CheckNodeTypeValid(RoguelikeDungeonNode node, RoguelikeTotemLinkedNodeTypeData linkedNodeTypeData)
		{
			return default(bool);
		}

		// Token: 0x0402CD26 RID: 183590
		[Token(Token = "0x402CD26")]
		private const string COMBINE_GROUP_BOSS = "boss";

		// Token: 0x0402CD27 RID: 183591
		[Token(Token = "0x402CD27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SyncCacheTotemCollectionFromPlayerData;

		// Token: 0x0402CD28 RID: 183592
		[Token(Token = "0x402CD28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadTotemViewModelsSplit;

		// Token: 0x0402CD29 RID: 183593
		[Token(Token = "0x402CD29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTotemCombineCountAgainstCollectionWithUpdate;

		// Token: 0x0402CD2A RID: 183594
		[Token(Token = "0x402CD2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsBossCombineGroupName;

		// Token: 0x0402CD2B RID: 183595
		[Token(Token = "0x402CD2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadCombineDesc;

		// Token: 0x0402CD2C RID: 183596
		[Token(Token = "0x402CD2C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PickResonanceMainTotemViewModel;

		// Token: 0x0402CD2D RID: 183597
		[Token(Token = "0x402CD2D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FormatTotemFullDesc;

		// Token: 0x0402CD2E RID: 183598
		[Token(Token = "0x402CD2E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadLocationTotemSelectableResult;

		// Token: 0x0402CD2F RID: 183599
		[Token(Token = "0x402CD2F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GeneLocationTotemSelectResult;

		// Token: 0x0402CD30 RID: 183600
		[Token(Token = "0x402CD30")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindSelectableNodeWithOnlyForVert;

		// Token: 0x0402CD31 RID: 183601
		[Token(Token = "0x402CD31")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckNodeValidInOnlyForVertMode;

		// Token: 0x0402CD32 RID: 183602
		[Token(Token = "0x402CD32")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FindSelectableNodesWithExpandLength;

		// Token: 0x0402CD33 RID: 183603
		[Token(Token = "0x402CD33")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__NodeWithExpandLengthDFSHelper;

		// Token: 0x0402CD34 RID: 183604
		[Token(Token = "0x402CD34")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckNodeValidInExpandLengthMode;

		// Token: 0x0402CD35 RID: 183605
		[Token(Token = "0x402CD35")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfNodeSelectable;

		// Token: 0x0402CD36 RID: 183606
		[Token(Token = "0x402CD36")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfNodeIsDirectDescendant;

		// Token: 0x0402CD37 RID: 183607
		[Token(Token = "0x402CD37")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckNodeTypeValid;
	}
}
