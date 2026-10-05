using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034B0 RID: 13488
	[Token(Token = "0x20034B0")]
	public class ActBattleFinishCommonMilestoneViewModel : IHotfixable
	{
		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x06015801 RID: 88065 RVA: 0x0008C4C0 File Offset: 0x0008A6C0
		// (set) Token: 0x06015802 RID: 88066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032C7")]
		public int playLength
		{
			[Token(Token = "0x6015801")]
			[Address(RVA = "0xDF5860", Offset = "0xDF4460", VA = "0x180DF5860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015802")]
			[Address(RVA = "0xDF59A0", Offset = "0xDF45A0", VA = "0x180DF59A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x06015803 RID: 88067 RVA: 0x0008C4D8 File Offset: 0x0008A6D8
		// (set) Token: 0x06015804 RID: 88068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032C8")]
		public bool levelUp
		{
			[Token(Token = "0x6015803")]
			[Address(RVA = "0xDF5800", Offset = "0xDF4400", VA = "0x180DF5800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015804")]
			[Address(RVA = "0xDF5930", Offset = "0xDF4530", VA = "0x180DF5930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x06015805 RID: 88069 RVA: 0x0008C4F0 File Offset: 0x0008A6F0
		// (set) Token: 0x06015806 RID: 88070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032C9")]
		public bool levelMax
		{
			[Token(Token = "0x6015805")]
			[Address(RVA = "0xDF57A0", Offset = "0xDF43A0", VA = "0x180DF57A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015806")]
			[Address(RVA = "0xDF58C0", Offset = "0xDF44C0", VA = "0x180DF58C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015807 RID: 88071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015807")]
		[Address(RVA = "0xDF4F80", Offset = "0xDF3B80", VA = "0x180DF4F80")]
		public void LoadData(List<ActivityCommonMilestoneData> milestoneDatas, PlayerActivity.MilestoneInfo playerMilestone, int normalMilestone, int extraMilestone)
		{
		}

		// Token: 0x06015808 RID: 88072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015808")]
		[Address(RVA = "0xDF56F0", Offset = "0xDF42F0", VA = "0x180DF56F0")]
		public ActBattleFinishCommonMilestoneViewModel()
		{
		}

		// Token: 0x04019C23 RID: 105507
		[Token(Token = "0x4019C23")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<ActBattleFinishCommonMilestoneViewModel.LevelPlayItem> playItems;

		// Token: 0x04019C27 RID: 105511
		[Token(Token = "0x4019C27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playLength;

		// Token: 0x04019C28 RID: 105512
		[Token(Token = "0x4019C28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_playLength;

		// Token: 0x04019C29 RID: 105513
		[Token(Token = "0x4019C29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_levelUp;

		// Token: 0x04019C2A RID: 105514
		[Token(Token = "0x4019C2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_levelUp;

		// Token: 0x04019C2B RID: 105515
		[Token(Token = "0x4019C2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_levelMax;

		// Token: 0x04019C2C RID: 105516
		[Token(Token = "0x4019C2C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_levelMax;

		// Token: 0x04019C2D RID: 105517
		[Token(Token = "0x4019C2D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04019C2E RID: 105518
		[Token(Token = "0x4019C2E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034B1 RID: 13489
		[Token(Token = "0x20034B1")]
		public struct LevelPlayItem : IProceduralClip
		{
			// Token: 0x06015809 RID: 88073 RVA: 0x0008C508 File Offset: 0x0008A708
			[Token(Token = "0x6015809")]
			[Address(RVA = "0xE05840", Offset = "0xE04440", VA = "0x180E05840", Slot = "4")]
			public int GetLength()
			{
				return 0;
			}

			// Token: 0x04019C2F RID: 105519
			[Token(Token = "0x4019C2F")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x04019C30 RID: 105520
			[Token(Token = "0x4019C30")]
			[FieldOffset(Offset = "0x4")]
			public int volume;

			// Token: 0x04019C31 RID: 105521
			[Token(Token = "0x4019C31")]
			[FieldOffset(Offset = "0x8")]
			public int start;

			// Token: 0x04019C32 RID: 105522
			[Token(Token = "0x4019C32")]
			[FieldOffset(Offset = "0xC")]
			public int end;
		}
	}
}
