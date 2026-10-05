using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068C1 RID: 26817
	[Token(Token = "0x20068C1")]
	public class SpecialStoryStageViewModel : StageViewModel, IHotfixable
	{
		// Token: 0x060266C1 RID: 157377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C1")]
		[Address(RVA = "0x217DDE0", Offset = "0x217C9E0", VA = "0x18217DDE0", Slot = "4")]
		public override void SetGameData(StageData stageData, StageViewModel.TimelyDropOptions timelyOptions, [Optional] StageDiffGroupTable table)
		{
		}

		// Token: 0x060266C2 RID: 157378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C2")]
		[Address(RVA = "0x217E480", Offset = "0x217D080", VA = "0x18217E480")]
		public SpecialStoryStageViewModel()
		{
		}

		// Token: 0x060266C3 RID: 157379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266C3")]
		[Address(RVA = "0x217E440", Offset = "0x217D040", VA = "0x18217E440")]
		private void <>xLuaBaseProxy_SetGameData(StageData P0, StageViewModel.TimelyDropOptions P1, StageDiffGroupTable P2)
		{
		}

		// Token: 0x040361EB RID: 221675
		[Token(Token = "0x40361EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Dictionary<int, string> spstProgressDesc;

		// Token: 0x040361EC RID: 221676
		[Token(Token = "0x40361EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<ItemBundle> spstRewards;

		// Token: 0x040361ED RID: 221677
		[Token(Token = "0x40361ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool spstPrevUnlocked;

		// Token: 0x040361EE RID: 221678
		[Token(Token = "0x40361EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public string spstPrevStageId;

		// Token: 0x040361EF RID: 221679
		[Token(Token = "0x40361EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PlayerSpecialStage spstStage;

		// Token: 0x040361F0 RID: 221680
		[Token(Token = "0x40361F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int spstProgress;

		// Token: 0x040361F1 RID: 221681
		[Token(Token = "0x40361F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public List<string> spstUnlockStages;

		// Token: 0x040361F2 RID: 221682
		[Token(Token = "0x40361F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string spstImageId;

		// Token: 0x040361F3 RID: 221683
		[Token(Token = "0x40361F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string spstKeyItemId;

		// Token: 0x040361F4 RID: 221684
		[Token(Token = "0x40361F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public string spstUnlockDesc;

		// Token: 0x040361F5 RID: 221685
		[Token(Token = "0x40361F5")]
		private const string SPECIAL_STORY_UNLOCK_TEMPLATE_READ_STORY = "ReadStorySome";

		// Token: 0x040361F6 RID: 221686
		[Token(Token = "0x40361F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetGameData;

		// Token: 0x040361F7 RID: 221687
		[Token(Token = "0x40361F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068C2 RID: 26818
		[Token(Token = "0x20068C2")]
		public struct DisplayInfo
		{
			// Token: 0x040361F8 RID: 221688
			[Token(Token = "0x40361F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string extraDesc;

			// Token: 0x040361F9 RID: 221689
			[Token(Token = "0x40361F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string imageId;

			// Token: 0x040361FA RID: 221690
			[Token(Token = "0x40361FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static SpecialStoryStageViewModel.DisplayInfo EMPTY;
		}
	}
}
