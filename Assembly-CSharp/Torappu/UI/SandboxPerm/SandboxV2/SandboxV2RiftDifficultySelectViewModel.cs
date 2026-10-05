using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200439A RID: 17306
	[Token(Token = "0x200439A")]
	public class SandboxV2RiftDifficultySelectViewModel : IHotfixable
	{
		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0601A917 RID: 108823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EFD")]
		public string selectDifficultyId
		{
			[Token(Token = "0x601A917")]
			[Address(RVA = "0x13B2960", Offset = "0x13B1560", VA = "0x1813B2960")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A918 RID: 108824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A918")]
		[Address(RVA = "0x13B1CF0", Offset = "0x13B08F0", VA = "0x1813B1CF0")]
		public void LoadData(string topicId, string riftId)
		{
		}

		// Token: 0x0601A919 RID: 108825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A919")]
		[Address(RVA = "0x13B2260", Offset = "0x13B0E60", VA = "0x1813B2260")]
		public void UpdateSelectDifficulty(int selectLevel)
		{
		}

		// Token: 0x0601A91A RID: 108826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A91A")]
		[Address(RVA = "0x13B22F0", Offset = "0x13B0EF0", VA = "0x1813B22F0")]
		private List<UIItemViewModel> _GetRewardGroupById(string groupId, SandboxV2Data gameData)
		{
			return null;
		}

		// Token: 0x0601A91B RID: 108827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A91B")]
		[Address(RVA = "0x13B28B0", Offset = "0x13B14B0", VA = "0x1813B28B0")]
		public SandboxV2RiftDifficultySelectViewModel()
		{
		}

		// Token: 0x04021D7F RID: 138623
		[Token(Token = "0x4021D7F")]
		private const int DEFAULT_DISPLAY_ITEM_COUNT = 1;

		// Token: 0x04021D80 RID: 138624
		[Token(Token = "0x4021D80")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2RiftDifficultySelectViewModel.SandboxV2RiftDifficultySelectItemModel> difficultyItems;

		// Token: 0x04021D81 RID: 138625
		[Token(Token = "0x4021D81")]
		[FieldOffset(Offset = "0x18")]
		public int canSelectDifficultyLevel;

		// Token: 0x04021D82 RID: 138626
		[Token(Token = "0x4021D82")]
		[FieldOffset(Offset = "0x1C")]
		public int completedDifficultyLevel;

		// Token: 0x04021D83 RID: 138627
		[Token(Token = "0x4021D83")]
		[FieldOffset(Offset = "0x20")]
		public int selectDifficultyLevel;

		// Token: 0x04021D84 RID: 138628
		[Token(Token = "0x4021D84")]
		[FieldOffset(Offset = "0x24")]
		public int sequenceNum;

		// Token: 0x04021D85 RID: 138629
		[Token(Token = "0x4021D85")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isRandomRift;

		// Token: 0x04021D86 RID: 138630
		[Token(Token = "0x4021D86")]
		[FieldOffset(Offset = "0x29")]
		private bool m_isPreyRift;

		// Token: 0x04021D87 RID: 138631
		[Token(Token = "0x4021D87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectDifficultyId;

		// Token: 0x04021D88 RID: 138632
		[Token(Token = "0x4021D88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021D89 RID: 138633
		[Token(Token = "0x4021D89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelectDifficulty;

		// Token: 0x04021D8A RID: 138634
		[Token(Token = "0x4021D8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetRewardGroupById;

		// Token: 0x04021D8B RID: 138635
		[Token(Token = "0x4021D8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200439B RID: 17307
		[Token(Token = "0x200439B")]
		public class SandboxV2RiftDifficultySelectItemModel : IHotfixable
		{
			// Token: 0x0601A91C RID: 108828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A91C")]
			[Address(RVA = "0x13B0A40", Offset = "0x13AF640", VA = "0x1813B0A40")]
			public SandboxV2RiftDifficultySelectItemModel()
			{
			}

			// Token: 0x04021D8C RID: 138636
			[Token(Token = "0x4021D8C")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04021D8D RID: 138637
			[Token(Token = "0x4021D8D")]
			[FieldOffset(Offset = "0x18")]
			public int difficultyLevel;

			// Token: 0x04021D8E RID: 138638
			[Token(Token = "0x4021D8E")]
			[FieldOffset(Offset = "0x20")]
			public string difficultyDesc;

			// Token: 0x04021D8F RID: 138639
			[Token(Token = "0x4021D8F")]
			[FieldOffset(Offset = "0x28")]
			public List<UIItemViewModel> rewards;

			// Token: 0x04021D90 RID: 138640
			[Token(Token = "0x4021D90")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
