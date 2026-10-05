using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200582D RID: 22573
	[Token(Token = "0x200582D")]
	public class RL03ScrollReportEndingFrameViewModelPlugin : RoguelikeScrollReportEndingFrameViewModelPlugin
	{
		// Token: 0x06020FB0 RID: 135088 RVA: 0x000B80F8 File Offset: 0x000B62F8
		[Token(Token = "0x6020FB0")]
		[Address(RVA = "0x1B4F9F0", Offset = "0x1B4E5F0", VA = "0x181B4F9F0", Slot = "4")]
		public override bool CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x06020FB1 RID: 135089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB1")]
		[Address(RVA = "0x1B506F0", Offset = "0x1B4F2F0", VA = "0x181B506F0", Slot = "5")]
		public override string GetSummaryActor()
		{
			return null;
		}

		// Token: 0x06020FB2 RID: 135090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB2")]
		[Address(RVA = "0x1B50670", Offset = "0x1B4F270", VA = "0x181B50670", Slot = "7")]
		public override IRoguelikeScrollEndingText GetEndingText()
		{
			return null;
		}

		// Token: 0x06020FB3 RID: 135091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB3")]
		[Address(RVA = "0x1B504F0", Offset = "0x1B4F0F0", VA = "0x181B504F0", Slot = "8")]
		public override List<string> ExportZoneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x06020FB4 RID: 135092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB4")]
		[Address(RVA = "0x1B50820", Offset = "0x1B4F420", VA = "0x181B50820", Slot = "25")]
		protected override List<string> _ExportExchangeLogInfo(string topicId, IRoguelikeScrollEndingText endingText, RoguelikeScrollReportEndingFrameViewModel.Exchange exchange)
		{
			return null;
		}

		// Token: 0x06020FB5 RID: 135093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB5")]
		[Address(RVA = "0x1B4FA70", Offset = "0x1B4E670", VA = "0x181B4FA70", Slot = "14")]
		public override List<string> ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FB6 RID: 135094 RVA: 0x000B8110 File Offset: 0x000B6310
		[Token(Token = "0x6020FB6")]
		[Address(RVA = "0x1B507A0", Offset = "0x1B4F3A0", VA = "0x181B507A0", Slot = "28")]
		protected override bool _CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x06020FB7 RID: 135095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB7")]
		[Address(RVA = "0x1B4FC00", Offset = "0x1B4E800", VA = "0x181B4FC00", Slot = "16")]
		public override List<string> ExportNodeGotAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x06020FB8 RID: 135096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB8")]
		[Address(RVA = "0x1B50030", Offset = "0x1B4EC30", VA = "0x181B50030", Slot = "19")]
		public override List<string> ExportNodeModuleChangeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FB9 RID: 135097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FB9")]
		[Address(RVA = "0x1B4FD50", Offset = "0x1B4E950", VA = "0x181B4FD50", Slot = "20")]
		public override List<string> ExportNodeModuleBetweenInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FBA RID: 135098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBA")]
		[Address(RVA = "0x1B515A0", Offset = "0x1B501A0", VA = "0x181B515A0")]
		private List<string> _ExportZoneTotemModuleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x06020FBB RID: 135099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBB")]
		[Address(RVA = "0x1B517B0", Offset = "0x1B503B0", VA = "0x181B517B0")]
		private string _ExportZoneVisionModuleAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x06020FBC RID: 135100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBC")]
		[Address(RVA = "0x1B50FE0", Offset = "0x1B4FBE0", VA = "0x181B50FE0")]
		private string _ExportNodeChaosModuleValueChangeInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FBD RID: 135101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBD")]
		[Address(RVA = "0x1B509B0", Offset = "0x1B4F5B0", VA = "0x181B509B0")]
		private List<string> _ExportNodeChaosModuleGradeChangeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FBE RID: 135102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBE")]
		[Address(RVA = "0x1B50EA0", Offset = "0x1B4FAA0", VA = "0x181B50EA0")]
		private string _ExportNodeChaosModuleGradeUpGainInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo, Dictionary<string, RoguelikeChaosData> chaosDatas)
		{
			return null;
		}

		// Token: 0x06020FBF RID: 135103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FBF")]
		[Address(RVA = "0x1B50D60", Offset = "0x1B4F960", VA = "0x181B50D60")]
		private string _ExportNodeChaosModuleGradeDownLostInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo, Dictionary<string, RoguelikeChaosData> chaosDatas)
		{
			return null;
		}

		// Token: 0x06020FC0 RID: 135104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC0")]
		[Address(RVA = "0x1B51A00", Offset = "0x1B50600", VA = "0x181B51A00")]
		private string _GetChaosChangesStr(List<string> chaosIdList, Dictionary<string, RoguelikeChaosData> chaosDatas)
		{
			return null;
		}

		// Token: 0x06020FC1 RID: 135105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC1")]
		[Address(RVA = "0x1B51470", Offset = "0x1B50070", VA = "0x181B51470")]
		private string _ExportNodeVisionModuleValueUpInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FC2 RID: 135106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC2")]
		[Address(RVA = "0x1B51250", Offset = "0x1B4FE50", VA = "0x181B51250")]
		private string _ExportNodeVisionModuleGradeUpInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FC3 RID: 135107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC3")]
		[Address(RVA = "0x1B51340", Offset = "0x1B4FF40", VA = "0x181B51340")]
		private string _ExportNodeVisionModuleValueDownInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FC4 RID: 135108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC4")]
		[Address(RVA = "0x1B51160", Offset = "0x1B4FD60", VA = "0x181B51160")]
		private string _ExportNodeVisionModuleGradeDownInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x06020FC5 RID: 135109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020FC5")]
		[Address(RVA = "0x1B51C40", Offset = "0x1B50840", VA = "0x181B51C40")]
		public RL03ScrollReportEndingFrameViewModelPlugin()
		{
		}

		// Token: 0x06020FC6 RID: 135110 RVA: 0x000B8128 File Offset: 0x000B6328
		[Token(Token = "0x6020FC6")]
		[Address(RVA = "0x1A5ABE0", Offset = "0x1A597E0", VA = "0x181A5ABE0")]
		private bool <>xLuaBaseProxy_CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x06020FC7 RID: 135111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC7")]
		[Address(RVA = "0x1A5AC80", Offset = "0x1A59880", VA = "0x181A5AC80")]
		private string <>xLuaBaseProxy_GetSummaryActor()
		{
			return null;
		}

		// Token: 0x06020FC8 RID: 135112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC8")]
		[Address(RVA = "0x1A5AC70", Offset = "0x1A59870", VA = "0x181A5AC70")]
		private IRoguelikeScrollEndingText <>xLuaBaseProxy_GetEndingText()
		{
			return null;
		}

		// Token: 0x06020FC9 RID: 135113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FC9")]
		[Address(RVA = "0x1A5AC60", Offset = "0x1A59860", VA = "0x181A5AC60")]
		private List<string> <>xLuaBaseProxy_ExportZoneAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Zone P1)
		{
			return null;
		}

		// Token: 0x06020FCA RID: 135114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FCA")]
		[Address(RVA = "0x1B50790", Offset = "0x1B4F390", VA = "0x181B50790")]
		private List<string> <>xLuaBaseProxy__ExportExchangeLogInfo(string P0, IRoguelikeScrollEndingText P1, RoguelikeScrollReportEndingFrameViewModel.Exchange P2)
		{
			return null;
		}

		// Token: 0x06020FCB RID: 135115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FCB")]
		[Address(RVA = "0x1A5ABF0", Offset = "0x1A597F0", VA = "0x181A5ABF0")]
		private List<string> <>xLuaBaseProxy_ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x06020FCC RID: 135116 RVA: 0x000B8140 File Offset: 0x000B6340
		[Token(Token = "0x6020FCC")]
		[Address(RVA = "0x1A5AC90", Offset = "0x1A59890", VA = "0x181A5AC90")]
		private bool <>xLuaBaseProxy__CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return default(bool);
		}

		// Token: 0x06020FCD RID: 135117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FCD")]
		[Address(RVA = "0x1A5AC10", Offset = "0x1A59810", VA = "0x181A5AC10")]
		private List<string> <>xLuaBaseProxy_ExportNodeGotAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Got P1, RoguelikeScrollReportEndingFrameViewModel.Node P2)
		{
			return null;
		}

		// Token: 0x06020FCE RID: 135118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FCE")]
		[Address(RVA = "0x1A5AC30", Offset = "0x1A59830", VA = "0x181A5AC30")]
		private List<string> <>xLuaBaseProxy_ExportNodeModuleChangeInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x06020FCF RID: 135119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020FCF")]
		[Address(RVA = "0x1B50780", Offset = "0x1B4F380", VA = "0x181B50780")]
		private List<string> <>xLuaBaseProxy_ExportNodeModuleBetweenInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x0402CDA6 RID: 183718
		[Token(Token = "0x402CDA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckRogueEndingTextValid;

		// Token: 0x0402CDA7 RID: 183719
		[Token(Token = "0x402CDA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummaryActor;

		// Token: 0x0402CDA8 RID: 183720
		[Token(Token = "0x402CDA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEndingText;

		// Token: 0x0402CDA9 RID: 183721
		[Token(Token = "0x402CDA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExportZoneAdditionInfo;

		// Token: 0x0402CDAA RID: 183722
		[Token(Token = "0x402CDAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExportExchangeLogInfo;

		// Token: 0x0402CDAB RID: 183723
		[Token(Token = "0x402CDAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleAdditionInfo;

		// Token: 0x0402CDAC RID: 183724
		[Token(Token = "0x402CDAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialNodeBattle;

		// Token: 0x0402CDAD RID: 183725
		[Token(Token = "0x402CDAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionInfo;

		// Token: 0x0402CDAE RID: 183726
		[Token(Token = "0x402CDAE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleChangeInfo;

		// Token: 0x0402CDAF RID: 183727
		[Token(Token = "0x402CDAF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleBetweenInfo;

		// Token: 0x0402CDB0 RID: 183728
		[Token(Token = "0x402CDB0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExportZoneTotemModuleAdditionInfo;

		// Token: 0x0402CDB1 RID: 183729
		[Token(Token = "0x402CDB1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExportZoneVisionModuleAdditionInfo;

		// Token: 0x0402CDB2 RID: 183730
		[Token(Token = "0x402CDB2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExportNodeChaosModuleValueChangeInfo;

		// Token: 0x0402CDB3 RID: 183731
		[Token(Token = "0x402CDB3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExportNodeChaosModuleGradeChangeInfo;

		// Token: 0x0402CDB4 RID: 183732
		[Token(Token = "0x402CDB4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExportNodeChaosModuleGradeUpGainInfo;

		// Token: 0x0402CDB5 RID: 183733
		[Token(Token = "0x402CDB5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ExportNodeChaosModuleGradeDownLostInfo;

		// Token: 0x0402CDB6 RID: 183734
		[Token(Token = "0x402CDB6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetChaosChangesStr;

		// Token: 0x0402CDB7 RID: 183735
		[Token(Token = "0x402CDB7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ExportNodeVisionModuleValueUpInfo;

		// Token: 0x0402CDB8 RID: 183736
		[Token(Token = "0x402CDB8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ExportNodeVisionModuleGradeUpInfo;

		// Token: 0x0402CDB9 RID: 183737
		[Token(Token = "0x402CDB9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ExportNodeVisionModuleValueDownInfo;

		// Token: 0x0402CDBA RID: 183738
		[Token(Token = "0x402CDBA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ExportNodeVisionModuleGradeDownInfo;

		// Token: 0x0402CDBB RID: 183739
		[Token(Token = "0x402CDBB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
