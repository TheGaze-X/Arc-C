using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053BC RID: 21436
	[Token(Token = "0x20053BC")]
	public abstract class RoguelikeScrollReportEndingFrameViewModelPlugin : IHotfixable
	{
		// Token: 0x0601F8AD RID: 129197 RVA: 0x000B22A8 File Offset: 0x000B04A8
		[Token(Token = "0x601F8AD")]
		[Address(RVA = "0x1943990", Offset = "0x1942590", VA = "0x181943990", Slot = "4")]
		public virtual bool CheckRogueEndingTextValid()
		{
			return default(bool);
		}

		// Token: 0x0601F8AE RID: 129198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8AE")]
		[Address(RVA = "0x1944AF0", Offset = "0x19436F0", VA = "0x181944AF0", Slot = "5")]
		public virtual string GetSummaryActor()
		{
			return null;
		}

		// Token: 0x0601F8AF RID: 129199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8AF")]
		[Address(RVA = "0x1944A30", Offset = "0x1943630", VA = "0x181944A30", Slot = "6")]
		public virtual string GetPlayerName()
		{
			return null;
		}

		// Token: 0x0601F8B0 RID: 129200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B0")]
		[Address(RVA = "0x19449D0", Offset = "0x19435D0", VA = "0x1819449D0", Slot = "7")]
		public virtual IRoguelikeScrollEndingText GetEndingText()
		{
			return null;
		}

		// Token: 0x0601F8B1 RID: 129201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B1")]
		[Address(RVA = "0x1944940", Offset = "0x1943540", VA = "0x181944940", Slot = "8")]
		public virtual List<string> ExportZoneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Zone zoneInfo)
		{
			return null;
		}

		// Token: 0x0601F8B2 RID: 129202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B2")]
		[Address(RVA = "0x1944280", Offset = "0x1942E80", VA = "0x181944280", Slot = "9")]
		public virtual List<string> ExportNodeSceneInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8B3 RID: 129203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B3")]
		[Address(RVA = "0x19439F0", Offset = "0x19425F0", VA = "0x1819439F0", Slot = "10")]
		public virtual List<string> ExportNodeAlchemyInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8B4 RID: 129204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B4")]
		[Address(RVA = "0x1944600", Offset = "0x1943200", VA = "0x181944600", Slot = "11")]
		public virtual List<string> ExportNodeStashedTicketInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8B5 RID: 129205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B5")]
		[Address(RVA = "0x1943B80", Offset = "0x1942780", VA = "0x181943B80", Slot = "12")]
		public virtual List<string> ExportNodeBattleInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8B6 RID: 129206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B6")]
		[Address(RVA = "0x1944150", Offset = "0x1942D50", VA = "0x181944150", Slot = "13")]
		public virtual List<string> ExportNodeSceneAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8B7 RID: 129207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B7")]
		[Address(RVA = "0x1943A80", Offset = "0x1942680", VA = "0x181943A80", Slot = "14")]
		public virtual List<string> ExportNodeBattleAdditionInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8B8 RID: 129208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B8")]
		[Address(RVA = "0x1943EA0", Offset = "0x1942AA0", VA = "0x181943EA0", Slot = "15")]
		public virtual List<string> ExportNodeGotAdditionRelicInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8B9 RID: 129209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8B9")]
		[Address(RVA = "0x1943E10", Offset = "0x1942A10", VA = "0x181943E10", Slot = "16")]
		public virtual List<string> ExportNodeGotAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Got got, RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8BA RID: 129210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8BA")]
		[Address(RVA = "0x1943F30", Offset = "0x1942B30", VA = "0x181943F30", Slot = "17")]
		public virtual List<string> ExportNodeMeetShopInfo(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return null;
		}

		// Token: 0x0601F8BB RID: 129211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8BB")]
		[Address(RVA = "0x19448B0", Offset = "0x19434B0", VA = "0x1819448B0", Slot = "18")]
		public virtual List<string> ExportShopNodeRecycleAdditionInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.ShopNode shop)
		{
			return null;
		}

		// Token: 0x0601F8BC RID: 129212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8BC")]
		[Address(RVA = "0x19440C0", Offset = "0x1942CC0", VA = "0x1819440C0", Slot = "19")]
		public virtual List<string> ExportNodeModuleChangeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8BD RID: 129213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8BD")]
		[Address(RVA = "0x1944050", Offset = "0x1942C50", VA = "0x181944050", Slot = "20")]
		public virtual List<string> ExportNodeModuleBetweenInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8BE RID: 129214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8BE")]
		[Address(RVA = "0x1944590", Offset = "0x1943190", VA = "0x181944590", Slot = "21")]
		public virtual List<string> ExportNodeSpRecruit(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8BF RID: 129215 RVA: 0x000B22C0 File Offset: 0x000B04C0
		[Token(Token = "0x601F8BF")]
		[Address(RVA = "0x19438F0", Offset = "0x19424F0", VA = "0x1819438F0", Slot = "22")]
		public virtual bool CheckIsShopNode(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x0601F8C0 RID: 129216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8C0")]
		[Address(RVA = "0x1944B60", Offset = "0x1943760", VA = "0x181944B60", Slot = "23")]
		public virtual void LoadData(RoguelikeScrollReportEndingFrameViewModel model)
		{
		}

		// Token: 0x0601F8C1 RID: 129217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8C1")]
		[Address(RVA = "0x1944F00", Offset = "0x1943B00", VA = "0x181944F00", Slot = "24")]
		protected virtual List<string> _ExportNodeSacrificeInfo(string topicId, RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8C2 RID: 129218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8C2")]
		[Address(RVA = "0x1944C50", Offset = "0x1943850", VA = "0x181944C50", Slot = "25")]
		protected virtual List<string> _ExportExchangeLogInfo(string topicId, IRoguelikeScrollEndingText endingText, RoguelikeScrollReportEndingFrameViewModel.Exchange exchange)
		{
			return null;
		}

		// Token: 0x0601F8C3 RID: 129219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8C3")]
		[Address(RVA = "0x1944DA0", Offset = "0x19439A0", VA = "0x181944DA0", Slot = "26")]
		protected virtual List<string> _ExportNodeDuelInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo)
		{
			return null;
		}

		// Token: 0x0601F8C4 RID: 129220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8C4")]
		[Address(RVA = "0x1945080", Offset = "0x1943C80", VA = "0x181945080", Slot = "27")]
		protected virtual List<string> _ExportSpZoneNodeInfo(RoguelikeScrollReportEndingFrameViewModel.Node nodeInfo, RoguelikeGameChoiceSceneData sceneData)
		{
			return null;
		}

		// Token: 0x0601F8C5 RID: 129221 RVA: 0x000B22D8 File Offset: 0x000B04D8
		[Token(Token = "0x601F8C5")]
		[Address(RVA = "0x1944BE0", Offset = "0x19437E0", VA = "0x181944BE0", Slot = "28")]
		protected virtual bool _CheckIsSpecialNodeBattle(RoguelikeScrollReportEndingFrameViewModel.Node node)
		{
			return default(bool);
		}

		// Token: 0x0601F8C6 RID: 129222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8C6")]
		[Address(RVA = "0x1945110", Offset = "0x1943D10", VA = "0x181945110")]
		protected RoguelikeScrollReportEndingFrameViewModelPlugin()
		{
		}

		// Token: 0x0402A76B RID: 173931
		[Token(Token = "0x402A76B")]
		[FieldOffset(Offset = "0x10")]
		protected RoguelikeScrollReportEndingFrameViewModel m_closure;

		// Token: 0x0402A76C RID: 173932
		[Token(Token = "0x402A76C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckRogueEndingTextValid;

		// Token: 0x0402A76D RID: 173933
		[Token(Token = "0x402A76D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSummaryActor;

		// Token: 0x0402A76E RID: 173934
		[Token(Token = "0x402A76E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPlayerName;

		// Token: 0x0402A76F RID: 173935
		[Token(Token = "0x402A76F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEndingText;

		// Token: 0x0402A770 RID: 173936
		[Token(Token = "0x402A770")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ExportZoneAdditionInfo;

		// Token: 0x0402A771 RID: 173937
		[Token(Token = "0x402A771")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExportNodeSceneInfo;

		// Token: 0x0402A772 RID: 173938
		[Token(Token = "0x402A772")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ExportNodeAlchemyInfo;

		// Token: 0x0402A773 RID: 173939
		[Token(Token = "0x402A773")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ExportNodeStashedTicketInfo;

		// Token: 0x0402A774 RID: 173940
		[Token(Token = "0x402A774")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleInfo;

		// Token: 0x0402A775 RID: 173941
		[Token(Token = "0x402A775")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ExportNodeSceneAdditionInfo;

		// Token: 0x0402A776 RID: 173942
		[Token(Token = "0x402A776")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ExportNodeBattleAdditionInfo;

		// Token: 0x0402A777 RID: 173943
		[Token(Token = "0x402A777")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionRelicInfo;

		// Token: 0x0402A778 RID: 173944
		[Token(Token = "0x402A778")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ExportNodeGotAdditionInfo;

		// Token: 0x0402A779 RID: 173945
		[Token(Token = "0x402A779")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ExportNodeMeetShopInfo;

		// Token: 0x0402A77A RID: 173946
		[Token(Token = "0x402A77A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ExportShopNodeRecycleAdditionInfo;

		// Token: 0x0402A77B RID: 173947
		[Token(Token = "0x402A77B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleChangeInfo;

		// Token: 0x0402A77C RID: 173948
		[Token(Token = "0x402A77C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ExportNodeModuleBetweenInfo;

		// Token: 0x0402A77D RID: 173949
		[Token(Token = "0x402A77D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ExportNodeSpRecruit;

		// Token: 0x0402A77E RID: 173950
		[Token(Token = "0x402A77E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckIsShopNode;

		// Token: 0x0402A77F RID: 173951
		[Token(Token = "0x402A77F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A780 RID: 173952
		[Token(Token = "0x402A780")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ExportNodeSacrificeInfo;

		// Token: 0x0402A781 RID: 173953
		[Token(Token = "0x402A781")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ExportExchangeLogInfo;

		// Token: 0x0402A782 RID: 173954
		[Token(Token = "0x402A782")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ExportNodeDuelInfo;

		// Token: 0x0402A783 RID: 173955
		[Token(Token = "0x402A783")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ExportSpZoneNodeInfo;

		// Token: 0x0402A784 RID: 173956
		[Token(Token = "0x402A784")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckIsSpecialNodeBattle;

		// Token: 0x0402A785 RID: 173957
		[Token(Token = "0x402A785")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
