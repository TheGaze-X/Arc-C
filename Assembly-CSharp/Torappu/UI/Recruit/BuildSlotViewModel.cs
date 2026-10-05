using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046FA RID: 18170
	[Token(Token = "0x20046FA")]
	public class BuildSlotViewModel : BuildConfigCostViewModel
	{
		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x0601B8EB RID: 112875 RVA: 0x000A5798 File Offset: 0x000A3998
		// (set) Token: 0x0601B8EC RID: 112876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004193")]
		public int slotIndex
		{
			[Token(Token = "0x601B8EB")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B8EC")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x0601B8ED RID: 112877 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B8EE RID: 112878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004194")]
		public string lockedText
		{
			[Token(Token = "0x601B8ED")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B8EE")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x0601B8EF RID: 112879 RVA: 0x000A57B0 File Offset: 0x000A39B0
		// (set) Token: 0x0601B8F0 RID: 112880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004195")]
		public BuildingRoomInfoModel hireRoom
		{
			[Token(Token = "0x601B8EF")]
			[Address(RVA = "0x14DAA60", Offset = "0x14D9660", VA = "0x1814DAA60")]
			[CompilerGenerated]
			get
			{
				return default(BuildingRoomInfoModel);
			}
			[Token(Token = "0x601B8F0")]
			[Address(RVA = "0x14DAAE0", Offset = "0x14D96E0", VA = "0x1814DAAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x0601B8F1 RID: 112881 RVA: 0x000A57C8 File Offset: 0x000A39C8
		[Token(Token = "0x17004196")]
		public RecruitBuildSlotState state
		{
			[Token(Token = "0x601B8F1")]
			[Address(RVA = "0x14DAAA0", Offset = "0x14D96A0", VA = "0x1814DAAA0")]
			get
			{
				return RecruitBuildSlotState.EMPTY;
			}
		}

		// Token: 0x0601B8F2 RID: 112882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8F2")]
		[Address(RVA = "0x14DA390", Offset = "0x14D8F90", VA = "0x1814DA390")]
		public void LoadData(int slotIndex)
		{
		}

		// Token: 0x0601B8F3 RID: 112883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8F3")]
		[Address(RVA = "0x14DA840", Offset = "0x14D9440", VA = "0x1814DA840")]
		public void RefreshData(long costTime, int selectTagCount, PlayerRecruit.NormalModel.SlotModel.TagItem[] tagLists)
		{
		}

		// Token: 0x0601B8F4 RID: 112884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8F4")]
		[Address(RVA = "0x14DA930", Offset = "0x14D9530", VA = "0x1814DA930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B8F5 RID: 112885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B8F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildSlotViewModel()
		{
		}

		// Token: 0x04023B13 RID: 146195
		[Token(Token = "0x4023B13")]
		[FieldOffset(Offset = "0x40")]
		private PlayerRecruit.NormalModel.SlotModel.State m_playerBuildState;

		// Token: 0x04023B14 RID: 146196
		[Token(Token = "0x4023B14")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isBuildFinish;

		// Token: 0x04023B16 RID: 146198
		[Token(Token = "0x4023B16")]
		[FieldOffset(Offset = "0x50")]
		public DateTime maxFinishTime;

		// Token: 0x04023B17 RID: 146199
		[Token(Token = "0x4023B17")]
		[FieldOffset(Offset = "0x58")]
		public long remainTimeReal;

		// Token: 0x04023B18 RID: 146200
		[Token(Token = "0x4023B18")]
		[FieldOffset(Offset = "0x60")]
		public long remainTimeShow;

		// Token: 0x04023B19 RID: 146201
		[Token(Token = "0x4023B19")]
		[FieldOffset(Offset = "0x68")]
		public int selectCostMinutes;

		// Token: 0x04023B1A RID: 146202
		[Token(Token = "0x4023B1A")]
		[FieldOffset(Offset = "0x70")]
		public BuildTagModel[] selectTags;
	}
}
