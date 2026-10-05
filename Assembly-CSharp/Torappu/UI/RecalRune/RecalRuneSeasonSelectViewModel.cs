using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x02004792 RID: 18322
	[Token(Token = "0x2004792")]
	public class RecalRuneSeasonSelectViewModel : IHotfixable
	{
		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0601BBE5 RID: 113637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041E4")]
		public List<RecalRuneSeasonItemViewModel> seasons
		{
			[Token(Token = "0x601BBE5")]
			[Address(RVA = "0x150E080", Offset = "0x150CC80", VA = "0x18150E080")]
			get
			{
				return null;
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x0601BBE6 RID: 113638 RVA: 0x000A60C8 File Offset: 0x000A42C8
		// (set) Token: 0x0601BBE7 RID: 113639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041E5")]
		public int focusIndex
		{
			[Token(Token = "0x601BBE6")]
			[Address(RVA = "0x150E020", Offset = "0x150CC20", VA = "0x18150E020")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601BBE7")]
			[Address(RVA = "0x150E0E0", Offset = "0x150CCE0", VA = "0x18150E0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601BBE8 RID: 113640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBE8")]
		[Address(RVA = "0x150D860", Offset = "0x150C460", VA = "0x18150D860")]
		public void LoadData(string focus)
		{
		}

		// Token: 0x0601BBE9 RID: 113641 RVA: 0x000A60E0 File Offset: 0x000A42E0
		[Token(Token = "0x601BBE9")]
		[Address(RVA = "0x150DD50", Offset = "0x150C950", VA = "0x18150DD50")]
		private int _FindDefaultFocusIndex()
		{
			return 0;
		}

		// Token: 0x0601BBEA RID: 113642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BBEA")]
		[Address(RVA = "0x150DF70", Offset = "0x150CB70", VA = "0x18150DF70")]
		public RecalRuneSeasonSelectViewModel()
		{
		}

		// Token: 0x040240DA RID: 147674
		[Token(Token = "0x40240DA")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<RecalRuneSeasonItemViewModel> m_seasons;

		// Token: 0x040240DC RID: 147676
		[Token(Token = "0x40240DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_seasons;

		// Token: 0x040240DD RID: 147677
		[Token(Token = "0x40240DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_focusIndex;

		// Token: 0x040240DE RID: 147678
		[Token(Token = "0x40240DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_focusIndex;

		// Token: 0x040240DF RID: 147679
		[Token(Token = "0x40240DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040240E0 RID: 147680
		[Token(Token = "0x40240E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindDefaultFocusIndex;

		// Token: 0x040240E1 RID: 147681
		[Token(Token = "0x40240E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
