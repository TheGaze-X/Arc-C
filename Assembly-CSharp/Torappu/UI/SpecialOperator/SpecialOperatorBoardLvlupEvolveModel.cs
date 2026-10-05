using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E98 RID: 16024
	[Token(Token = "0x2003E98")]
	public class SpecialOperatorBoardLvlupEvolveModel : SpecialOperatorBoardLvlupModel
	{
		// Token: 0x06018E15 RID: 101909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E15")]
		[Address(RVA = "0x118A800", Offset = "0x1189400", VA = "0x18118A800", Slot = "5")]
		public override void InitData(string charId, SpecialOperatorDetailTabData tabData, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018E16 RID: 101910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E16")]
		[Address(RVA = "0x118B550", Offset = "0x118A150", VA = "0x18118B550")]
		private static List<SpecialOperatorBoardEvolveNodeViewModel.Feature> _LoadNodeFeatures(string charId, CharacterData charData, CharacterData.PhaseData fromPhaseData, CharacterData.PhaseData curPhaseData, EvolvePhase fromPhase, EvolvePhase curPhase)
		{
			return null;
		}

		// Token: 0x06018E17 RID: 101911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E17")]
		[Address(RVA = "0x118AD70", Offset = "0x1189970", VA = "0x18118AD70", Slot = "6")]
		public override void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018E18 RID: 101912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E18")]
		[Address(RVA = "0x118B360", Offset = "0x1189F60", VA = "0x18118B360")]
		private void _InitNodeList(string charId, SpecialOperatorDetailData detailData)
		{
		}

		// Token: 0x06018E19 RID: 101913 RVA: 0x0009C4E0 File Offset: 0x0009A6E0
		[Token(Token = "0x6018E19")]
		[Address(RVA = "0x118B2A0", Offset = "0x1189EA0", VA = "0x18118B2A0", Slot = "7")]
		public override bool TryGetNodeModel(string nodeId, out SpecialOperatorBoardNodeBase nodeModel)
		{
			return default(bool);
		}

		// Token: 0x06018E1A RID: 101914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E1A")]
		[Address(RVA = "0x118C3A0", Offset = "0x118AFA0", VA = "0x18118C3A0")]
		public SpecialOperatorBoardLvlupEvolveModel()
		{
		}

		// Token: 0x06018E1B RID: 101915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E1B")]
		[Address(RVA = "0x116BFE0", Offset = "0x116ABE0", VA = "0x18116BFE0")]
		private void <>xLuaBaseProxy_InitData(string P0, SpecialOperatorDetailTabData P1, SpecialOperatorDetailData P2)
		{
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E1C")]
		[Address(RVA = "0x118B350", Offset = "0x1189F50", VA = "0x18118B350")]
		private void <>xLuaBaseProxy_RefreshData(PlayerCharacter P0)
		{
		}

		// Token: 0x0401EA8A RID: 125578
		[Token(Token = "0x401EA8A")]
		[FieldOffset(Offset = "0x30")]
		public EvolvePhase curEvolvePhase;

		// Token: 0x0401EA8B RID: 125579
		[Token(Token = "0x401EA8B")]
		[FieldOffset(Offset = "0x34")]
		public int curLevel;

		// Token: 0x0401EA8C RID: 125580
		[Token(Token = "0x401EA8C")]
		[FieldOffset(Offset = "0x38")]
		public int curExp;

		// Token: 0x0401EA8D RID: 125581
		[Token(Token = "0x401EA8D")]
		[FieldOffset(Offset = "0x3C")]
		public int levelMax;

		// Token: 0x0401EA8E RID: 125582
		[Token(Token = "0x401EA8E")]
		[FieldOffset(Offset = "0x40")]
		public int expMax;

		// Token: 0x0401EA8F RID: 125583
		[Token(Token = "0x401EA8F")]
		[FieldOffset(Offset = "0x48")]
		public CharacterData.PhaseData[] phaseData;

		// Token: 0x0401EA90 RID: 125584
		[Token(Token = "0x401EA90")]
		[FieldOffset(Offset = "0x50")]
		public List<ISpecialOperatorBoardEvolveItemViewModel> itemViewModels;

		// Token: 0x0401EA91 RID: 125585
		[Token(Token = "0x401EA91")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, SpecialOperatorBoardNodeBase> nodeDict;

		// Token: 0x0401EA92 RID: 125586
		[Token(Token = "0x401EA92")]
		[FieldOffset(Offset = "0x60")]
		public bool showCursorPanel;

		// Token: 0x0401EA93 RID: 125587
		[Token(Token = "0x401EA93")]
		[FieldOffset(Offset = "0x61")]
		public bool canEvolve;

		// Token: 0x0401EA94 RID: 125588
		[Token(Token = "0x401EA94")]
		[FieldOffset(Offset = "0x62")]
		public bool evolveLevelMax;

		// Token: 0x0401EA95 RID: 125589
		[Token(Token = "0x401EA95")]
		[FieldOffset(Offset = "0x68")]
		public string expTip;

		// Token: 0x0401EA96 RID: 125590
		[Token(Token = "0x401EA96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401EA97 RID: 125591
		[Token(Token = "0x401EA97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadNodeFeatures;

		// Token: 0x0401EA98 RID: 125592
		[Token(Token = "0x401EA98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EA99 RID: 125593
		[Token(Token = "0x401EA99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitNodeList;

		// Token: 0x0401EA9A RID: 125594
		[Token(Token = "0x401EA9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetNodeModel;

		// Token: 0x0401EA9B RID: 125595
		[Token(Token = "0x401EA9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
