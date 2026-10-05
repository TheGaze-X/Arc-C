using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055C7 RID: 21959
	[Token(Token = "0x20055C7")]
	public class RL05ScrollReportEndingFrameViewModelPlugin : RoguelikeScrollReportEndingFrameViewModelPlugin
	{
		// Token: 0x060203AE RID: 132014 RVA: 0x000B4FD8 File Offset: 0x000B31D8
		[Token(Token = "0x60203AE")]
		[Address(RVA = "0x1A58EC0", Offset = "0x1A57AC0", VA = "0x181A58EC0", Slot = "4")]
		public override bool CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x060203AF RID: 132015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203AF")]
		[Address(RVA = "0x1A5AB40", Offset = "0x1A59740", VA = "0x181A5AB40", Slot = "5")]
		public override string GetSummaryActor()
		{
			return null;
		}

		// Token: 0x060203B0 RID: 132016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B0")]
		[Address(RVA = "0x1A5AAC0", Offset = "0x1A596C0", VA = "0x181A5AAC0", Slot = "7")]
		public override IRoguelikeScrollEndingText GetEndingText()
		{
			return null;
		}

		// Token: 0x060203B1 RID: 132017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B1")]
		[Address(RVA = "0x1A5A510", Offset = "0x1A59110", VA = "0x181A5A510", Slot = "8")]
		public override List<string> ExportZoneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x060203B2 RID: 132018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B2")]
		[Address(RVA = "0x1A58F40", Offset = "0x1A57B40", VA = "0x181A58F40", Slot = "14")]
		public override List<string> ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060203B3 RID: 132019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B3")]
		[Address(RVA = "0x1A59240", Offset = "0x1A57E40", VA = "0x181A59240", Slot = "12")]
		public override List<string> ExportNodeBattleInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060203B4 RID: 132020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B4")]
		[Address(RVA = "0x1A5B9A0", Offset = "0x1A5A5A0", VA = "0x181A5B9A0", Slot = "27")]
		protected override List<string> _ExportSpZoneNodeInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo, RoguelikeGameChoiceSceneData sceneData)
		{
			return null;
		}

		// Token: 0x060203B5 RID: 132021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B5")]
		[Address(RVA = "0x1A59870", Offset = "0x1A58470", VA = "0x181A59870", Slot = "17")]
		public override List<string> ExportNodeMeetShopInfo(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060203B6 RID: 132022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B6")]
		[Address(RVA = "0x1A59BD0", Offset = "0x1A587D0", VA = "0x181A59BD0", Slot = "13")]
		public override List<string> ExportNodeSceneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060203B7 RID: 132023 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		[Token(Token = "0x60203B7")]
		[Address(RVA = "0x1A5AD50", Offset = "0x1A59950", VA = "0x181A5AD50", Slot = "28")]
		protected override bool _CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x060203B8 RID: 132024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B8")]
		[Address(RVA = "0x1A59530", Offset = "0x1A58130", VA = "0x181A59530", Slot = "16")]
		public override List<string> ExportNodeGotAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060203B9 RID: 132025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203B9")]
		[Address(RVA = "0x1A599C0", Offset = "0x1A585C0", VA = "0x181A599C0", Slot = "19")]
		public override List<string> ExportNodeModuleChangeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060203BA RID: 132026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203BA")]
		[Address(RVA = "0x1A5A0B0", Offset = "0x1A58CB0", VA = "0x181A5A0B0", Slot = "21")]
		public override List<string> ExportNodeSpRecruit(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060203BB RID: 132027 RVA: 0x000B5008 File Offset: 0x000B3208
		[Token(Token = "0x60203BB")]
		[Address(RVA = "0x1A58DD0", Offset = "0x1A579D0", VA = "0x181A58DD0", Slot = "22")]
		public override bool CheckIsShopNode(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x060203BC RID: 132028 RVA: 0x000B5020 File Offset: 0x000B3220
		[Token(Token = "0x60203BC")]
		[Address(RVA = "0x1A5ACB0", Offset = "0x1A598B0", VA = "0x181A5ACB0")]
		private bool _CheckIsSkyShopNode(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x060203BD RID: 132029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203BD")]
		[Address(RVA = "0x1A5B6B0", Offset = "0x1A5A2B0", VA = "0x181A5B6B0")]
		private List<string> _ExportMeetWrathInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.WrathChange wrath)
		{
			return null;
		}

		// Token: 0x060203BE RID: 132030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203BE")]
		[Address(RVA = "0x1A5B080", Offset = "0x1A59C80", VA = "0x181A5B080")]
		private List<string> _ExportDrawCopperInfo(string topicId, List<RoguelikeScrollReportEndingFrameViewModel.DrawCopper> draws)
		{
			return null;
		}

		// Token: 0x060203BF RID: 132031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203BF")]
		[Address(RVA = "0x1A5B410", Offset = "0x1A5A010", VA = "0x181A5B410")]
		private List<string> _ExportLostCopperInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060203C0 RID: 132032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C0")]
		[Address(RVA = "0x1A5ADE0", Offset = "0x1A599E0", VA = "0x181A5ADE0")]
		private List<string> _ExportCandleInfo(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060203C1 RID: 132033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C1")]
		[Address(RVA = "0x1A5BC30", Offset = "0x1A5A830", VA = "0x181A5BC30")]
		private string _MergeItemsNameToLongStr(List<string> itemNameList)
		{
			return null;
		}

		// Token: 0x060203C2 RID: 132034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203C2")]
		[Address(RVA = "0x1A5BD00", Offset = "0x1A5A900", VA = "0x181A5BD00")]
		public RL05ScrollReportEndingFrameViewModelPlugin()
		{
		}

		// Token: 0x060203C3 RID: 132035 RVA: 0x000B5038 File Offset: 0x000B3238
		[Token(Token = "0x60203C3")]
		[Address(RVA = "0x1A5ABE0", Offset = "0x1A597E0", VA = "0x181A5ABE0")]
		private bool <>xLuaBaseProxy_CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x060203C4 RID: 132036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C4")]
		[Address(RVA = "0x1A5AC80", Offset = "0x1A59880", VA = "0x181A5AC80")]
		private string <>xLuaBaseProxy_GetSummaryActor()
		{
			return null;
		}

		// Token: 0x060203C5 RID: 132037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C5")]
		[Address(RVA = "0x1A5AC70", Offset = "0x1A59870", VA = "0x181A5AC70")]
		private IRoguelikeScrollEndingText <>xLuaBaseProxy_GetEndingText()
		{
			return null;
		}

		// Token: 0x060203C6 RID: 132038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C6")]
		[Address(RVA = "0x1A5AC60", Offset = "0x1A59860", VA = "0x181A5AC60")]
		private List<string> <>xLuaBaseProxy_ExportZoneAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Zone P1)
		{
			return null;
		}

		// Token: 0x060203C7 RID: 132039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C7")]
		[Address(RVA = "0x1A5ABF0", Offset = "0x1A597F0", VA = "0x181A5ABF0")]
		private List<string> <>xLuaBaseProxy_ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x060203C8 RID: 132040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C8")]
		[Address(RVA = "0x1A5AC00", Offset = "0x1A59800", VA = "0x181A5AC00")]
		private List<string> <>xLuaBaseProxy_ExportNodeBattleInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x060203C9 RID: 132041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203C9")]
		[Address(RVA = "0x1A5ACA0", Offset = "0x1A598A0", VA = "0x181A5ACA0")]
		private List<string> <>xLuaBaseProxy__ExportSpZoneNodeInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0, RoguelikeGameChoiceSceneData P1)
		{
			return null;
		}

		// Token: 0x060203CA RID: 132042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203CA")]
		[Address(RVA = "0x1A5AC20", Offset = "0x1A59820", VA = "0x181A5AC20")]
		private List<string> <>xLuaBaseProxy_ExportNodeMeetShopInfo(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x060203CB RID: 132043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203CB")]
		[Address(RVA = "0x1A5AC40", Offset = "0x1A59840", VA = "0x181A5AC40")]
		private List<string> <>xLuaBaseProxy_ExportNodeSceneAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x060203CC RID: 132044 RVA: 0x000B5050 File Offset: 0x000B3250
		[Token(Token = "0x60203CC")]
		[Address(RVA = "0x1A5AC90", Offset = "0x1A59890", VA = "0x181A5AC90")]
		private bool <>xLuaBaseProxy__CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return default(bool);
		}

		// Token: 0x060203CD RID: 132045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203CD")]
		[Address(RVA = "0x1A5AC10", Offset = "0x1A59810", VA = "0x181A5AC10")]
		private List<string> <>xLuaBaseProxy_ExportNodeGotAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Got P1, RoguelikeScrollReportEndingFrameViewModel.Node P2)
		{
			return null;
		}

		// Token: 0x060203CE RID: 132046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203CE")]
		[Address(RVA = "0x1A5AC30", Offset = "0x1A59830", VA = "0x181A5AC30")]
		private List<string> <>xLuaBaseProxy_ExportNodeModuleChangeInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x060203CF RID: 132047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203CF")]
		[Address(RVA = "0x1A5AC50", Offset = "0x1A59850", VA = "0x181A5AC50")]
		private List<string> <>xLuaBaseProxy_ExportNodeSpRecruit(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return null;
		}

		// Token: 0x060203D0 RID: 132048 RVA: 0x000B5068 File Offset: 0x000B3268
		[Token(Token = "0x60203D0")]
		[Address(RVA = "0x1A5ABD0", Offset = "0x1A597D0", VA = "0x181A5ABD0")]
		private bool <>xLuaBaseProxy_CheckIsShopNode(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return default(bool);
		}

		// Token: 0x0402B997 RID: 178583
		[Token(Token = "0x402B997")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckRogueEndingTextValid;

		// Token: 0x0402B998 RID: 178584
		[Token(Token = "0x402B998")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummaryActor;

		// Token: 0x0402B999 RID: 178585
		[Token(Token = "0x402B999")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEndingText;

		// Token: 0x0402B99A RID: 178586
		[Token(Token = "0x402B99A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExportZoneAdditionInfo;

		// Token: 0x0402B99B RID: 178587
		[Token(Token = "0x402B99B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleAdditionInfo;

		// Token: 0x0402B99C RID: 178588
		[Token(Token = "0x402B99C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleInfo;

		// Token: 0x0402B99D RID: 178589
		[Token(Token = "0x402B99D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExportSpZoneNodeInfo;

		// Token: 0x0402B99E RID: 178590
		[Token(Token = "0x402B99E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExportNodeMeetShopInfo;

		// Token: 0x0402B99F RID: 178591
		[Token(Token = "0x402B99F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ExportNodeSceneAdditionInfo;

		// Token: 0x0402B9A0 RID: 178592
		[Token(Token = "0x402B9A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialNodeBattle;

		// Token: 0x0402B9A1 RID: 178593
		[Token(Token = "0x402B9A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionInfo;

		// Token: 0x0402B9A2 RID: 178594
		[Token(Token = "0x402B9A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleChangeInfo;

		// Token: 0x0402B9A3 RID: 178595
		[Token(Token = "0x402B9A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ExportNodeSpRecruit;

		// Token: 0x0402B9A4 RID: 178596
		[Token(Token = "0x402B9A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIsShopNode;

		// Token: 0x0402B9A5 RID: 178597
		[Token(Token = "0x402B9A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIsSkyShopNode;

		// Token: 0x0402B9A6 RID: 178598
		[Token(Token = "0x402B9A6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ExportMeetWrathInfo;

		// Token: 0x0402B9A7 RID: 178599
		[Token(Token = "0x402B9A7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExportDrawCopperInfo;

		// Token: 0x0402B9A8 RID: 178600
		[Token(Token = "0x402B9A8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ExportLostCopperInfo;

		// Token: 0x0402B9A9 RID: 178601
		[Token(Token = "0x402B9A9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ExportCandleInfo;

		// Token: 0x0402B9AA RID: 178602
		[Token(Token = "0x402B9AA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__MergeItemsNameToLongStr;

		// Token: 0x0402B9AB RID: 178603
		[Token(Token = "0x402B9AB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
