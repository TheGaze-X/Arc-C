using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044ED RID: 17645
	[Token(Token = "0x20044ED")]
	public class RoguelikeTopicMonthTaskModel : IHotfixable
	{
		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x0601AF01 RID: 110337 RVA: 0x000A3AB8 File Offset: 0x000A1CB8
		[Token(Token = "0x17003FF1")]
		public int position
		{
			[Token(Token = "0x601AF01")]
			[Address(RVA = "0x142A6D0", Offset = "0x14292D0", VA = "0x18142A6D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x0601AF02 RID: 110338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FF2")]
		public RoguelikeTopicMonthMission taskData
		{
			[Token(Token = "0x601AF02")]
			[Address(RVA = "0x142A7F0", Offset = "0x14293F0", VA = "0x18142A7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0601AF03 RID: 110339 RVA: 0x000A3AD0 File Offset: 0x000A1CD0
		[Token(Token = "0x17003FF3")]
		public int progress
		{
			[Token(Token = "0x601AF03")]
			[Address(RVA = "0x142A730", Offset = "0x1429330", VA = "0x18142A730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0601AF04 RID: 110340 RVA: 0x000A3AE8 File Offset: 0x000A1CE8
		[Token(Token = "0x17003FF4")]
		public int target
		{
			[Token(Token = "0x601AF04")]
			[Address(RVA = "0x142A790", Offset = "0x1429390", VA = "0x18142A790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0601AF05 RID: 110341 RVA: 0x000A3B00 File Offset: 0x000A1D00
		[Token(Token = "0x17003FF5")]
		public bool isCompleted
		{
			[Token(Token = "0x601AF05")]
			[Address(RVA = "0x142A660", Offset = "0x1429260", VA = "0x18142A660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601AF06 RID: 110342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF06")]
		[Address(RVA = "0x142A520", Offset = "0x1429120", VA = "0x18142A520")]
		public void LoadData(int pos, RoguelikeTopicMonthMission taskData, int progress, int target, int state, bool isBpMax)
		{
		}

		// Token: 0x0601AF07 RID: 110343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF07")]
		[Address(RVA = "0x142A600", Offset = "0x1429200", VA = "0x18142A600")]
		public RoguelikeTopicMonthTaskModel()
		{
		}

		// Token: 0x040228DA RID: 141530
		[Token(Token = "0x40228DA")]
		[FieldOffset(Offset = "0x10")]
		private int m_position;

		// Token: 0x040228DB RID: 141531
		[Token(Token = "0x40228DB")]
		[FieldOffset(Offset = "0x18")]
		private RoguelikeTopicMonthMission m_taskData;

		// Token: 0x040228DC RID: 141532
		[Token(Token = "0x40228DC")]
		[FieldOffset(Offset = "0x20")]
		private int m_progress;

		// Token: 0x040228DD RID: 141533
		[Token(Token = "0x40228DD")]
		[FieldOffset(Offset = "0x24")]
		private int m_target;

		// Token: 0x040228DE RID: 141534
		[Token(Token = "0x40228DE")]
		[FieldOffset(Offset = "0x28")]
		private int m_state;

		// Token: 0x040228DF RID: 141535
		[Token(Token = "0x40228DF")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_bpMax;

		// Token: 0x040228E0 RID: 141536
		[Token(Token = "0x40228E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x040228E1 RID: 141537
		[Token(Token = "0x40228E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_taskData;

		// Token: 0x040228E2 RID: 141538
		[Token(Token = "0x40228E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x040228E3 RID: 141539
		[Token(Token = "0x40228E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040228E4 RID: 141540
		[Token(Token = "0x40228E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x040228E5 RID: 141541
		[Token(Token = "0x40228E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040228E6 RID: 141542
		[Token(Token = "0x40228E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
