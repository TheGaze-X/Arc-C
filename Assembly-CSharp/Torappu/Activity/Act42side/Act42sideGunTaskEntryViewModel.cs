using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007315 RID: 29461
	[Token(Token = "0x2007315")]
	public class Act42sideGunTaskEntryViewModel : IHotfixable
	{
		// Token: 0x06029AA5 RID: 170661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AA5")]
		[Address(RVA = "0x2516F90", Offset = "0x2515B90", VA = "0x182516F90")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029AA6 RID: 170662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AA6")]
		[Address(RVA = "0x25176F0", Offset = "0x25162F0", VA = "0x1825176F0")]
		public Act42sideGunTaskEntryViewModel()
		{
		}

		// Token: 0x0403B9A6 RID: 244134
		[Token(Token = "0x403B9A6")]
		[FieldOffset(Offset = "0x10")]
		public List<Act42sideGunTaskEntryTrustorViewModel> trustors;

		// Token: 0x0403B9A7 RID: 244135
		[Token(Token = "0x403B9A7")]
		[FieldOffset(Offset = "0x18")]
		public int tokenNum;

		// Token: 0x0403B9A8 RID: 244136
		[Token(Token = "0x403B9A8")]
		[FieldOffset(Offset = "0x1C")]
		public PlayerActivity.PlayerAct42SideActivity.RewardState rewardState;

		// Token: 0x0403B9A9 RID: 244137
		[Token(Token = "0x403B9A9")]
		[FieldOffset(Offset = "0x20")]
		public bool showArchiveEntry;

		// Token: 0x0403B9AA RID: 244138
		[Token(Token = "0x403B9AA")]
		[FieldOffset(Offset = "0x21")]
		public bool showArchiveTrack;

		// Token: 0x0403B9AB RID: 244139
		[Token(Token = "0x403B9AB")]
		[FieldOffset(Offset = "0x28")]
		public string archiveLockToast;

		// Token: 0x0403B9AC RID: 244140
		[Token(Token = "0x403B9AC")]
		[FieldOffset(Offset = "0x30")]
		public bool isActEnd;

		// Token: 0x0403B9AD RID: 244141
		[Token(Token = "0x403B9AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B9AE RID: 244142
		[Token(Token = "0x403B9AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007316 RID: 29462
		[Token(Token = "0x2007316")]
		public class RewardTrack : ITrackPointModel, IHotfixable
		{
			// Token: 0x06029AA7 RID: 170663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029AA7")]
			[Address(RVA = "0x251C330", Offset = "0x251AF30", VA = "0x18251C330", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17006276 RID: 25206
			// (get) Token: 0x06029AA8 RID: 170664 RVA: 0x000D6338 File Offset: 0x000D4538
			[Token(Token = "0x17006276")]
			public bool isShow
			{
				[Token(Token = "0x6029AA8")]
				[Address(RVA = "0x251C460", Offset = "0x251B060", VA = "0x18251C460", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06029AA9 RID: 170665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029AA9")]
			[Address(RVA = "0x251C400", Offset = "0x251B000", VA = "0x18251C400")]
			public RewardTrack()
			{
			}

			// Token: 0x0403B9AF RID: 244143
			[Token(Token = "0x403B9AF")]
			[FieldOffset(Offset = "0x10")]
			private bool m_show;

			// Token: 0x0403B9B0 RID: 244144
			[Token(Token = "0x403B9B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403B9B1 RID: 244145
			[Token(Token = "0x403B9B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403B9B2 RID: 244146
			[Token(Token = "0x403B9B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02007317 RID: 29463
			[Token(Token = "0x2007317")]
			public class Input
			{
				// Token: 0x06029AAA RID: 170666 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6029AAA")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x0403B9B3 RID: 244147
				[Token(Token = "0x403B9B3")]
				[FieldOffset(Offset = "0x10")]
				public bool isShow;
			}
		}
	}
}
