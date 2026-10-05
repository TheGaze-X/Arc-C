using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020005A3 RID: 1443
	[Token(Token = "0x20005A3")]
	public class ScreenUtil : Singleton<ScreenUtil>, IHotfixable
	{
		// Token: 0x06006068 RID: 24680 RVA: 0x0002F490 File Offset: 0x0002D690
		[Token(Token = "0x6006068")]
		[Address(RVA = "0x1CF7B10", Offset = "0x1CF6710", VA = "0x181CF7B10")]
		public static ScreenUtil.UISleepBlocker BlockSleep()
		{
			return default(ScreenUtil.UISleepBlocker);
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		[Token(Token = "0x6006069")]
		[Address(RVA = "0x1CF7E90", Offset = "0x1CF6A90", VA = "0x181CF7E90")]
		private ScreenUtil.UISleepBlocker _RequestSleepBlocker()
		{
			return default(ScreenUtil.UISleepBlocker);
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606A")]
		[Address(RVA = "0x1CF7D40", Offset = "0x1CF6940", VA = "0x181CF7D40")]
		private void _ReleaseSleepBlocker(long id)
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606B")]
		[Address(RVA = "0x1CF7CF0", Offset = "0x1CF68F0", VA = "0x181CF7CF0")]
		private static void _BlockSleep()
		{
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606C")]
		[Address(RVA = "0x1CF7FD0", Offset = "0x1CF6BD0", VA = "0x181CF7FD0")]
		private static void _UnblockSleep()
		{
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606D")]
		[Address(RVA = "0x1CF8020", Offset = "0x1CF6C20", VA = "0x181CF8020")]
		private ScreenUtil()
		{
		}

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		private const long UISLEEPBLOCK_INVALID_ID = 0L;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x10")]
		private readonly ListSet<long> m_activeBlockers;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x18")]
		private long m_activeBlockerIndex;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BlockSleep;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RequestSleepBlocker;

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReleaseSleepBlocker;

		// Token: 0x040029E5 RID: 10725
		[Token(Token = "0x40029E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__BlockSleep;

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UnblockSleep;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020005A4 RID: 1444
		[Token(Token = "0x20005A4")]
		public struct UISleepBlocker
		{
			// Token: 0x0600606E RID: 24686 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
			[Token(Token = "0x600606E")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			public static ScreenUtil.UISleepBlocker ScreenUtil_Create(long id)
			{
				return default(ScreenUtil.UISleepBlocker);
			}

			// Token: 0x0600606F RID: 24687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600606F")]
			[Address(RVA = "0x1CFD2D0", Offset = "0x1CFBED0", VA = "0x181CFD2D0")]
			public void Release()
			{
			}

			// Token: 0x06006070 RID: 24688 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
			[Token(Token = "0x6006070")]
			[Address(RVA = "0x1CFD2C0", Offset = "0x1CFBEC0", VA = "0x181CFD2C0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040029E8 RID: 10728
			[Token(Token = "0x40029E8")]
			[FieldOffset(Offset = "0x0")]
			private long m_id;

			// Token: 0x040029E9 RID: 10729
			[Token(Token = "0x40029E9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ScreenUtil.UISleepBlocker EMPTY;
		}
	}
}
