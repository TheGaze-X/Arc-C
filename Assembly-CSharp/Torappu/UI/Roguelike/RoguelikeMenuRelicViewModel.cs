using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200534D RID: 21325
	[Token(Token = "0x200534D")]
	public class RoguelikeMenuRelicViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x0601F71A RID: 128794 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F71B RID: 128795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049B8")]
		public string diffName
		{
			[Token(Token = "0x601F71A")]
			[Address(RVA = "0x192A320", Offset = "0x1928F20", VA = "0x18192A320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F71B")]
			[Address(RVA = "0x192A470", Offset = "0x1929070", VA = "0x18192A470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049B9 RID: 18873
		// (get) Token: 0x0601F71C RID: 128796 RVA: 0x000B1EB8 File Offset: 0x000B00B8
		// (set) Token: 0x0601F71D RID: 128797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049B9")]
		public int diffLevel
		{
			[Token(Token = "0x601F71C")]
			[Address(RVA = "0x192A2C0", Offset = "0x1928EC0", VA = "0x18192A2C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601F71D")]
			[Address(RVA = "0x192A400", Offset = "0x1929000", VA = "0x18192A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x0601F71E RID: 128798 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F71F RID: 128799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049BA")]
		public string diffDisplayIconId
		{
			[Token(Token = "0x601F71E")]
			[Address(RVA = "0x192A260", Offset = "0x1928E60", VA = "0x18192A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F71F")]
			[Address(RVA = "0x192A380", Offset = "0x1928F80", VA = "0x18192A380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F720 RID: 128800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F720")]
		[Address(RVA = "0x1929560", Offset = "0x1928160", VA = "0x181929560", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F721 RID: 128801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F721")]
		[Address(RVA = "0x1929CE0", Offset = "0x19288E0", VA = "0x181929CE0")]
		public List<IRoguelikeRelicViewModel> LoadWholeRelicViewModelList(RoguelikeMenuRelicViewModel.CombineParam combineParam)
		{
			return null;
		}

		// Token: 0x0601F722 RID: 128802 RVA: 0x000B1ED0 File Offset: 0x000B00D0
		[Token(Token = "0x601F722")]
		[Address(RVA = "0x1929490", Offset = "0x1928090", VA = "0x181929490")]
		public int GetWholeRelicViewModelsCount(RoguelikeMenuRelicViewModel.CombineParam combineParam)
		{
			return 0;
		}

		// Token: 0x0601F723 RID: 128803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F723")]
		[Address(RVA = "0x1929F10", Offset = "0x1928B10", VA = "0x181929F10")]
		private void _LoadExploreTool(string topicId, Dictionary<string, PlayerRoguelikeV2.CurrentData.ExploreTool> playerExploreToolDict)
		{
		}

		// Token: 0x0601F724 RID: 128804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F724")]
		[Address(RVA = "0x192A120", Offset = "0x1928D20", VA = "0x18192A120")]
		public RoguelikeMenuRelicViewModel()
		{
		}

		// Token: 0x0601F725 RID: 128805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F725")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4D3 RID: 173267
		[Token(Token = "0x402A4D3")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeRelicViewModel initialRelic;

		// Token: 0x0402A4D4 RID: 173268
		[Token(Token = "0x402A4D4")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTrapViewModel trap;

		// Token: 0x0402A4D5 RID: 173269
		[Token(Token = "0x402A4D5")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeRelicViewModel> relics;

		// Token: 0x0402A4D6 RID: 173270
		[Token(Token = "0x402A4D6")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeExploreToolViewModel> exploreTools;

		// Token: 0x0402A4D7 RID: 173271
		[Token(Token = "0x402A4D7")]
		[FieldOffset(Offset = "0x38")]
		public bool initProcessing;

		// Token: 0x0402A4DB RID: 173275
		[Token(Token = "0x402A4DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diffName;

		// Token: 0x0402A4DC RID: 173276
		[Token(Token = "0x402A4DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_diffName;

		// Token: 0x0402A4DD RID: 173277
		[Token(Token = "0x402A4DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_diffLevel;

		// Token: 0x0402A4DE RID: 173278
		[Token(Token = "0x402A4DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_diffLevel;

		// Token: 0x0402A4DF RID: 173279
		[Token(Token = "0x402A4DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_diffDisplayIconId;

		// Token: 0x0402A4E0 RID: 173280
		[Token(Token = "0x402A4E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_diffDisplayIconId;

		// Token: 0x0402A4E1 RID: 173281
		[Token(Token = "0x402A4E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4E2 RID: 173282
		[Token(Token = "0x402A4E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadWholeRelicViewModelList;

		// Token: 0x0402A4E3 RID: 173283
		[Token(Token = "0x402A4E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetWholeRelicViewModelsCount;

		// Token: 0x0402A4E4 RID: 173284
		[Token(Token = "0x402A4E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadExploreTool;

		// Token: 0x0402A4E5 RID: 173285
		[Token(Token = "0x402A4E5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200534E RID: 21326
		[Token(Token = "0x200534E")]
		public struct CombineParam
		{
			// Token: 0x0402A4E6 RID: 173286
			[Token(Token = "0x402A4E6")]
			[FieldOffset(Offset = "0x0")]
			public bool ignoreExploreTool;

			// Token: 0x0402A4E7 RID: 173287
			[Token(Token = "0x402A4E7")]
			[FieldOffset(Offset = "0x1")]
			public bool ignoreTrap;
		}
	}
}
