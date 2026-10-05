using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E41 RID: 15937
	[Token(Token = "0x2003E41")]
	public class SpecialOperatorBoardMainModel : IHotfixable
	{
		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x06018C13 RID: 101395 RVA: 0x0009B8F8 File Offset: 0x00099AF8
		// (set) Token: 0x06018C14 RID: 101396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF1")]
		public int focusSeqNum
		{
			[Token(Token = "0x6018C13")]
			[Address(RVA = "0x116EC80", Offset = "0x116D880", VA = "0x18116EC80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6018C14")]
			[Address(RVA = "0x116EDC0", Offset = "0x116D9C0", VA = "0x18116EDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x06018C15 RID: 101397 RVA: 0x0009B910 File Offset: 0x00099B10
		// (set) Token: 0x06018C16 RID: 101398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AF2")]
		public float focusPos
		{
			[Token(Token = "0x6018C15")]
			[Address(RVA = "0x116EC20", Offset = "0x116D820", VA = "0x18116EC20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6018C16")]
			[Address(RVA = "0x116ED50", Offset = "0x116D950", VA = "0x18116ED50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x06018C17 RID: 101399 RVA: 0x0009B928 File Offset: 0x00099B28
		[Token(Token = "0x17003AF3")]
		public bool showDiagram
		{
			[Token(Token = "0x6018C17")]
			[Address(RVA = "0x116ECE0", Offset = "0x116D8E0", VA = "0x18116ECE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06018C18 RID: 101400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C18")]
		[Address(RVA = "0x116DD10", Offset = "0x116C910", VA = "0x18116DD10")]
		public void InitData(string charId)
		{
		}

		// Token: 0x06018C19 RID: 101401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C19")]
		[Address(RVA = "0x116E080", Offset = "0x116CC80", VA = "0x18116E080")]
		public void RefreshData()
		{
		}

		// Token: 0x06018C1A RID: 101402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C1A")]
		[Address(RVA = "0x116E340", Offset = "0x116CF40", VA = "0x18116E340")]
		public void UpdateEnterSeqNum()
		{
		}

		// Token: 0x06018C1B RID: 101403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C1B")]
		[Address(RVA = "0x116E2B0", Offset = "0x116CEB0", VA = "0x18116E2B0")]
		public void SwitchTab(SpecialOperatorBoardTabType tabType)
		{
		}

		// Token: 0x06018C1C RID: 101404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C1C")]
		[Address(RVA = "0x116E220", Offset = "0x116CE20", VA = "0x18116E220")]
		public void SwitchLvlupTab(SpecialOperatorDetailNodeType lvlupTabType)
		{
		}

		// Token: 0x06018C1D RID: 101405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C1D")]
		[Address(RVA = "0x116E8A0", Offset = "0x116D4A0", VA = "0x18116E8A0")]
		private void _TryFocusNodeInCurrTab()
		{
		}

		// Token: 0x06018C1E RID: 101406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018C1E")]
		[Address(RVA = "0x116DCB0", Offset = "0x116C8B0", VA = "0x18116DCB0")]
		public SpecialOperatorBoardNodeBase FindSelectedNode()
		{
			return null;
		}

		// Token: 0x06018C1F RID: 101407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018C1F")]
		[Address(RVA = "0x116DB80", Offset = "0x116C780", VA = "0x18116DB80")]
		public SpecialOperatorBoardNodeBase FindNode(string nodeId)
		{
			return null;
		}

		// Token: 0x06018C20 RID: 101408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018C20")]
		[Address(RVA = "0x116DC50", Offset = "0x116C850", VA = "0x18116DC50")]
		public SpecialOperatorBoardLvlupModel FindSelectLvlupModel()
		{
			return null;
		}

		// Token: 0x06018C21 RID: 101409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C21")]
		[Address(RVA = "0x116E570", Offset = "0x116D170", VA = "0x18116E570")]
		private void _InitBoardModels(SpecialOperatorDetailData detailInfo)
		{
		}

		// Token: 0x06018C22 RID: 101410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C22")]
		[Address(RVA = "0x116E840", Offset = "0x116D440", VA = "0x18116E840")]
		private void _InitTabSelection()
		{
		}

		// Token: 0x06018C23 RID: 101411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018C23")]
		[Address(RVA = "0x116E3A0", Offset = "0x116CFA0", VA = "0x18116E3A0")]
		private SpecialOperatorBoardLvlupModel _FindSelectedBoardModel()
		{
			return null;
		}

		// Token: 0x06018C24 RID: 101412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018C24")]
		[Address(RVA = "0x116E470", Offset = "0x116D070", VA = "0x18116E470")]
		private SpecialOperatorBoardLvlupModel _InitBoardModelByType(SpecialOperatorDetailNodeType nodeType)
		{
			return null;
		}

		// Token: 0x06018C25 RID: 101413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C25")]
		[Address(RVA = "0x116EA50", Offset = "0x116D650", VA = "0x18116EA50")]
		public SpecialOperatorBoardMainModel()
		{
		}

		// Token: 0x0401E6CC RID: 124620
		[Token(Token = "0x401E6CC")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0401E6CD RID: 124621
		[Token(Token = "0x401E6CD")]
		[FieldOffset(Offset = "0x18")]
		public string targetId;

		// Token: 0x0401E6CE RID: 124622
		[Token(Token = "0x401E6CE")]
		[FieldOffset(Offset = "0x20")]
		public string bgId;

		// Token: 0x0401E6CF RID: 124623
		[Token(Token = "0x401E6CF")]
		[FieldOffset(Offset = "0x28")]
		public string bgEffectId;

		// Token: 0x0401E6D0 RID: 124624
		[Token(Token = "0x401E6D0")]
		[FieldOffset(Offset = "0x30")]
		public string charEffectId;

		// Token: 0x0401E6D1 RID: 124625
		[Token(Token = "0x401E6D1")]
		[FieldOffset(Offset = "0x38")]
		public SpecialOperatorTargetType targetType;

		// Token: 0x0401E6D2 RID: 124626
		[Token(Token = "0x401E6D2")]
		[FieldOffset(Offset = "0x40")]
		public SpecialOperatorBoardSummaryModel summaryModel;

		// Token: 0x0401E6D3 RID: 124627
		[Token(Token = "0x401E6D3")]
		[FieldOffset(Offset = "0x48")]
		public List<SpecialOperatorBoardLvlupModel> boardLvlupModels;

		// Token: 0x0401E6D4 RID: 124628
		[Token(Token = "0x401E6D4")]
		[FieldOffset(Offset = "0x50")]
		public SpecialOperatorBoardTabType curTabType;

		// Token: 0x0401E6D5 RID: 124629
		[Token(Token = "0x401E6D5")]
		[FieldOffset(Offset = "0x54")]
		public SpecialOperatorDetailNodeType curLvlupTabType;

		// Token: 0x0401E6D6 RID: 124630
		[Token(Token = "0x401E6D6")]
		[FieldOffset(Offset = "0x58")]
		public string inGameMechanicsToast;

		// Token: 0x0401E6D7 RID: 124631
		[Token(Token = "0x401E6D7")]
		[FieldOffset(Offset = "0x60")]
		public string selectedNodeId;

		// Token: 0x0401E6D8 RID: 124632
		[Token(Token = "0x401E6D8")]
		[FieldOffset(Offset = "0x68")]
		public int enterSeqNum;

		// Token: 0x0401E6DB RID: 124635
		[Token(Token = "0x401E6DB")]
		[FieldOffset(Offset = "0x78")]
		public string lockPreToast;

		// Token: 0x0401E6DC RID: 124636
		[Token(Token = "0x401E6DC")]
		[FieldOffset(Offset = "0x80")]
		public string lockTaskToast;

		// Token: 0x0401E6DD RID: 124637
		[Token(Token = "0x401E6DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusSeqNum;

		// Token: 0x0401E6DE RID: 124638
		[Token(Token = "0x401E6DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusSeqNum;

		// Token: 0x0401E6DF RID: 124639
		[Token(Token = "0x401E6DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_focusPos;

		// Token: 0x0401E6E0 RID: 124640
		[Token(Token = "0x401E6E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_focusPos;

		// Token: 0x0401E6E1 RID: 124641
		[Token(Token = "0x401E6E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showDiagram;

		// Token: 0x0401E6E2 RID: 124642
		[Token(Token = "0x401E6E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401E6E3 RID: 124643
		[Token(Token = "0x401E6E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401E6E4 RID: 124644
		[Token(Token = "0x401E6E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateEnterSeqNum;

		// Token: 0x0401E6E5 RID: 124645
		[Token(Token = "0x401E6E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SwitchTab;

		// Token: 0x0401E6E6 RID: 124646
		[Token(Token = "0x401E6E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SwitchLvlupTab;

		// Token: 0x0401E6E7 RID: 124647
		[Token(Token = "0x401E6E7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryFocusNodeInCurrTab;

		// Token: 0x0401E6E8 RID: 124648
		[Token(Token = "0x401E6E8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FindSelectedNode;

		// Token: 0x0401E6E9 RID: 124649
		[Token(Token = "0x401E6E9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FindNode;

		// Token: 0x0401E6EA RID: 124650
		[Token(Token = "0x401E6EA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FindSelectLvlupModel;

		// Token: 0x0401E6EB RID: 124651
		[Token(Token = "0x401E6EB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitBoardModels;

		// Token: 0x0401E6EC RID: 124652
		[Token(Token = "0x401E6EC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitTabSelection;

		// Token: 0x0401E6ED RID: 124653
		[Token(Token = "0x401E6ED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FindSelectedBoardModel;

		// Token: 0x0401E6EE RID: 124654
		[Token(Token = "0x401E6EE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitBoardModelByType;

		// Token: 0x0401E6EF RID: 124655
		[Token(Token = "0x401E6EF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
