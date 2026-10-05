using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007430 RID: 29744
	[Token(Token = "0x2007430")]
	public class Act38sideEntryFireworkPuzzleViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029FB6 RID: 171958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB6")]
		[Address(RVA = "0x2582DC0", Offset = "0x25819C0", VA = "0x182582DC0")]
		public Act38sideEntryFireworkPuzzleViewModel(object param)
		{
		}

		// Token: 0x06029FB7 RID: 171959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FB7")]
		[Address(RVA = "0x2582B90", Offset = "0x2581790", VA = "0x182582B90")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403C311 RID: 246545
		[Token(Token = "0x403C311")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403C312 RID: 246546
		[Token(Token = "0x403C312")]
		[FieldOffset(Offset = "0x28")]
		public Act38sideEntryFireworkPuzzleViewModel.Status status;

		// Token: 0x0403C313 RID: 246547
		[Token(Token = "0x403C313")]
		[FieldOffset(Offset = "0x2C")]
		public bool hasDailyTrack;

		// Token: 0x0403C314 RID: 246548
		[Token(Token = "0x403C314")]
		[FieldOffset(Offset = "0x30")]
		public string unlockDesc;

		// Token: 0x0403C315 RID: 246549
		[Token(Token = "0x403C315")]
		[FieldOffset(Offset = "0x38")]
		public string closeDesc;

		// Token: 0x0403C316 RID: 246550
		[Token(Token = "0x403C316")]
		[FieldOffset(Offset = "0x40")]
		public string lockedToastText;

		// Token: 0x0403C317 RID: 246551
		[Token(Token = "0x403C317")]
		[FieldOffset(Offset = "0x48")]
		public string closedToastText;

		// Token: 0x0403C318 RID: 246552
		[Token(Token = "0x403C318")]
		[FieldOffset(Offset = "0x50")]
		public string puzzleCrossDayTrackId;

		// Token: 0x0403C319 RID: 246553
		[Token(Token = "0x403C319")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C31A RID: 246554
		[Token(Token = "0x403C31A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x02007431 RID: 29745
		[Token(Token = "0x2007431")]
		public class Input
		{
			// Token: 0x06029FB8 RID: 171960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029FB8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403C31B RID: 246555
			[Token(Token = "0x403C31B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x02007432 RID: 29746
		[Token(Token = "0x2007432")]
		public enum Status
		{
			// Token: 0x0403C31D RID: 246557
			[Token(Token = "0x403C31D")]
			LOCKED,
			// Token: 0x0403C31E RID: 246558
			[Token(Token = "0x403C31E")]
			UNLOCK,
			// Token: 0x0403C31F RID: 246559
			[Token(Token = "0x403C31F")]
			CLOSED
		}
	}
}
