using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004853 RID: 18515
	[Token(Token = "0x2004853")]
	public class MissionArchiveTrackViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0601BF93 RID: 114579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF93")]
		[Address(RVA = "0x1554AF0", Offset = "0x15536F0", VA = "0x181554AF0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x0601BF94 RID: 114580 RVA: 0x000A6BA8 File Offset: 0x000A4DA8
		// (set) Token: 0x0601BF95 RID: 114581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004279")]
		public bool isShow
		{
			[Token(Token = "0x601BF94")]
			[Address(RVA = "0x1554C80", Offset = "0x1553880", VA = "0x181554C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601BF95")]
			[Address(RVA = "0x1554CE0", Offset = "0x15538E0", VA = "0x181554CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601BF96 RID: 114582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF96")]
		[Address(RVA = "0x1554C20", Offset = "0x1553820", VA = "0x181554C20")]
		public MissionArchiveTrackViewModel()
		{
		}

		// Token: 0x040247C3 RID: 149443
		[Token(Token = "0x40247C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040247C4 RID: 149444
		[Token(Token = "0x40247C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040247C5 RID: 149445
		[Token(Token = "0x40247C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x040247C6 RID: 149446
		[Token(Token = "0x40247C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004854 RID: 18516
		[Token(Token = "0x2004854")]
		public class Input
		{
			// Token: 0x0601BF97 RID: 114583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BF97")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040247C7 RID: 149447
			[Token(Token = "0x40247C7")]
			[FieldOffset(Offset = "0x10")]
			public PlayerMissionArchive playerData;
		}
	}
}
