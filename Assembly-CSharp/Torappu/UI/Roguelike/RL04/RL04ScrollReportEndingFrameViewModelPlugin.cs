using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056AF RID: 22191
	[Token(Token = "0x20056AF")]
	public class RL04ScrollReportEndingFrameViewModelPlugin : RoguelikeScrollReportEndingFrameViewModelPlugin
	{
		// Token: 0x060208B4 RID: 133300 RVA: 0x000B65F8 File Offset: 0x000B47F8
		[Token(Token = "0x60208B4")]
		[Address(RVA = "0x1AB2820", Offset = "0x1AB1420", VA = "0x181AB2820", Slot = "4")]
		public override bool CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x060208B5 RID: 133301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208B5")]
		[Address(RVA = "0x1AB39D0", Offset = "0x1AB25D0", VA = "0x181AB39D0", Slot = "5")]
		public override string GetSummaryActor()
		{
			return null;
		}

		// Token: 0x060208B6 RID: 133302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208B6")]
		[Address(RVA = "0x1AB3950", Offset = "0x1AB2550", VA = "0x181AB3950", Slot = "7")]
		public override IRoguelikeScrollEndingText GetEndingText()
		{
			return null;
		}

		// Token: 0x060208B7 RID: 133303 RVA: 0x000B6610 File Offset: 0x000B4810
		[Token(Token = "0x60208B7")]
		[Address(RVA = "0x1AB3A90", Offset = "0x1AB2690", VA = "0x181AB3A90", Slot = "28")]
		protected override bool _CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x060208B8 RID: 133304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208B8")]
		[Address(RVA = "0x1AB34A0", Offset = "0x1AB20A0", VA = "0x181AB34A0", Slot = "8")]
		public override List<string> ExportZoneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x060208B9 RID: 133305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208B9")]
		[Address(RVA = "0x1AB28A0", Offset = "0x1AB14A0", VA = "0x181AB28A0", Slot = "10")]
		public override List<string> ExportNodeAlchemyInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060208BA RID: 133306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BA")]
		[Address(RVA = "0x1AB31F0", Offset = "0x1AB1DF0", VA = "0x181AB31F0", Slot = "18")]
		public override List<string> ExportShopNodeRecycleAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.ShopNode shop)
		{
			return null;
		}

		// Token: 0x060208BB RID: 133307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BB")]
		[Address(RVA = "0x1AB2BC0", Offset = "0x1AB17C0", VA = "0x181AB2BC0", Slot = "15")]
		public override List<string> ExportNodeGotAdditionRelicInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208BC RID: 133308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BC")]
		[Address(RVA = "0x1AB2A70", Offset = "0x1AB1670", VA = "0x181AB2A70", Slot = "16")]
		public override List<string> ExportNodeGotAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x060208BD RID: 133309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BD")]
		[Address(RVA = "0x1AB2EB0", Offset = "0x1AB1AB0", VA = "0x181AB2EB0", Slot = "19")]
		public override List<string> ExportNodeModuleChangeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208BE RID: 133310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BE")]
		[Address(RVA = "0x1AB3B10", Offset = "0x1AB2710", VA = "0x181AB3B10")]
		private List<string> _ExportNodeAlchemyInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208BF RID: 133311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208BF")]
		[Address(RVA = "0x1AB45E0", Offset = "0x1AB31E0", VA = "0x181AB45E0")]
		private List<string> _ExportNodeUseFragmentInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208C0 RID: 133312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C0")]
		[Address(RVA = "0x1AB4340", Offset = "0x1AB2F40", VA = "0x181AB4340")]
		private string _ExportNodeLostFragmentInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208C1 RID: 133313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C1")]
		[Address(RVA = "0x1AB41C0", Offset = "0x1AB2DC0", VA = "0x181AB41C0")]
		private string _ExportNodeFragmentBagStatusInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208C2 RID: 133314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C2")]
		[Address(RVA = "0x1AB3DA0", Offset = "0x1AB29A0", VA = "0x181AB3DA0")]
		private List<string> _ExportNodeDisasterInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x060208C3 RID: 133315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C3")]
		[Address(RVA = "0x1AB49A0", Offset = "0x1AB35A0", VA = "0x181AB49A0")]
		private string _MergeItemsNameToLongStr(List<string> itemNameList)
		{
			return null;
		}

		// Token: 0x060208C4 RID: 133316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208C4")]
		[Address(RVA = "0x1AB4A60", Offset = "0x1AB3660", VA = "0x181AB4A60")]
		public RL04ScrollReportEndingFrameViewModelPlugin()
		{
		}

		// Token: 0x060208C5 RID: 133317 RVA: 0x000B6628 File Offset: 0x000B4828
		[Token(Token = "0x60208C5")]
		[Address(RVA = "0x1A5ABE0", Offset = "0x1A597E0", VA = "0x181A5ABE0")]
		private bool <>xLuaBaseProxy_CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x060208C6 RID: 133318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C6")]
		[Address(RVA = "0x1A5AC80", Offset = "0x1A59880", VA = "0x181A5AC80")]
		private string <>xLuaBaseProxy_GetSummaryActor()
		{
			return null;
		}

		// Token: 0x060208C7 RID: 133319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C7")]
		[Address(RVA = "0x1A5AC70", Offset = "0x1A59870", VA = "0x181A5AC70")]
		private IRoguelikeScrollEndingText <>xLuaBaseProxy_GetEndingText()
		{
			return null;
		}

		// Token: 0x060208C8 RID: 133320 RVA: 0x000B6640 File Offset: 0x000B4840
		[Token(Token = "0x60208C8")]
		[Address(RVA = "0x1A5AC90", Offset = "0x1A59890", VA = "0x181A5AC90")]
		private bool <>xLuaBaseProxy__CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node P0)
		{
			return default(bool);
		}

		// Token: 0x060208C9 RID: 133321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208C9")]
		[Address(RVA = "0x1A5AC60", Offset = "0x1A59860", VA = "0x181A5AC60")]
		private List<string> <>xLuaBaseProxy_ExportZoneAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Zone P1)
		{
			return null;
		}

		// Token: 0x060208CA RID: 133322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208CA")]
		[Address(RVA = "0x1AB3A60", Offset = "0x1AB2660", VA = "0x181AB3A60")]
		private List<string> <>xLuaBaseProxy_ExportNodeAlchemyInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x060208CB RID: 133323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208CB")]
		[Address(RVA = "0x1AB3A80", Offset = "0x1AB2680", VA = "0x181AB3A80")]
		private List<string> <>xLuaBaseProxy_ExportShopNodeRecycleAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.ShopNode P1)
		{
			return null;
		}

		// Token: 0x060208CC RID: 133324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208CC")]
		[Address(RVA = "0x1AB3A70", Offset = "0x1AB2670", VA = "0x181AB3A70")]
		private List<string> <>xLuaBaseProxy_ExportNodeGotAdditionRelicInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Got P1, RoguelikeScrollReportEndingFrameViewModel.Node P2)
		{
			return null;
		}

		// Token: 0x060208CD RID: 133325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208CD")]
		[Address(RVA = "0x1A5AC10", Offset = "0x1A59810", VA = "0x181A5AC10")]
		private List<string> <>xLuaBaseProxy_ExportNodeGotAdditionInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Got P1, RoguelikeScrollReportEndingFrameViewModel.Node P2)
		{
			return null;
		}

		// Token: 0x060208CE RID: 133326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208CE")]
		[Address(RVA = "0x1A5AC30", Offset = "0x1A59830", VA = "0x181A5AC30")]
		private List<string> <>xLuaBaseProxy_ExportNodeModuleChangeInfo(string P0, RoguelikeScrollReportEndingFrameViewModel.Node P1)
		{
			return null;
		}

		// Token: 0x0402C184 RID: 180612
		[Token(Token = "0x402C184")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckRogueEndingTextValid;

		// Token: 0x0402C185 RID: 180613
		[Token(Token = "0x402C185")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummaryActor;

		// Token: 0x0402C186 RID: 180614
		[Token(Token = "0x402C186")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEndingText;

		// Token: 0x0402C187 RID: 180615
		[Token(Token = "0x402C187")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialNodeBattle;

		// Token: 0x0402C188 RID: 180616
		[Token(Token = "0x402C188")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExportZoneAdditionInfo;

		// Token: 0x0402C189 RID: 180617
		[Token(Token = "0x402C189")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExportNodeAlchemyInfo;

		// Token: 0x0402C18A RID: 180618
		[Token(Token = "0x402C18A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ExportShopNodeRecycleAdditionInfo;

		// Token: 0x0402C18B RID: 180619
		[Token(Token = "0x402C18B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionRelicInfo;

		// Token: 0x0402C18C RID: 180620
		[Token(Token = "0x402C18C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionInfo;

		// Token: 0x0402C18D RID: 180621
		[Token(Token = "0x402C18D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleChangeInfo;

		// Token: 0x0402C18E RID: 180622
		[Token(Token = "0x402C18E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExportNodeAlchemyInfo;

		// Token: 0x0402C18F RID: 180623
		[Token(Token = "0x402C18F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExportNodeUseFragmentInfo;

		// Token: 0x0402C190 RID: 180624
		[Token(Token = "0x402C190")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExportNodeLostFragmentInfo;

		// Token: 0x0402C191 RID: 180625
		[Token(Token = "0x402C191")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExportNodeFragmentBagStatusInfo;

		// Token: 0x0402C192 RID: 180626
		[Token(Token = "0x402C192")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExportNodeDisasterInfo;

		// Token: 0x0402C193 RID: 180627
		[Token(Token = "0x402C193")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__MergeItemsNameToLongStr;

		// Token: 0x0402C194 RID: 180628
		[Token(Token = "0x402C194")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
