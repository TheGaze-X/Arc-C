using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003502 RID: 13570
	[Token(Token = "0x2003502")]
	public class CharacterCardSortTypeViewModel : IHotfixable
	{
		// Token: 0x06015A50 RID: 88656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A50")]
		[Address(RVA = "0xE327D0", Offset = "0xE313D0", VA = "0x180E327D0")]
		public void LoadCache(string pageName, CharacterSortType defaultType = CharacterSortType.BY_LEVEL_UP, bool hasCustomSortType = true)
		{
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x06015A51 RID: 88657 RVA: 0x0008D258 File Offset: 0x0008B458
		// (set) Token: 0x06015A52 RID: 88658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003352")]
		public CharacterSortType sortType
		{
			[Token(Token = "0x6015A51")]
			[Address(RVA = "0xE32EF0", Offset = "0xE31AF0", VA = "0x180E32EF0")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
			[Token(Token = "0x6015A52")]
			[Address(RVA = "0xE32F50", Offset = "0xE31B50", VA = "0x180E32F50")]
			set
			{
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x06015A53 RID: 88659 RVA: 0x0008D270 File Offset: 0x0008B470
		[Token(Token = "0x17003353")]
		public bool customTypeSet
		{
			[Token(Token = "0x6015A53")]
			[Address(RVA = "0xE32E30", Offset = "0xE31A30", VA = "0x180E32E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x06015A54 RID: 88660 RVA: 0x0008D288 File Offset: 0x0008B488
		[Token(Token = "0x17003354")]
		public int customSortType
		{
			[Token(Token = "0x6015A54")]
			[Address(RVA = "0xE32DD0", Offset = "0xE319D0", VA = "0x180E32DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x06015A55 RID: 88661 RVA: 0x0008D2A0 File Offset: 0x0008B4A0
		[Token(Token = "0x17003355")]
		public bool isStarMarkTopMode
		{
			[Token(Token = "0x6015A55")]
			[Address(RVA = "0xE32E90", Offset = "0xE31A90", VA = "0x180E32E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015A56 RID: 88662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A56")]
		[Address(RVA = "0xE329D0", Offset = "0xE315D0", VA = "0x180E329D0")]
		public void TryUpdateCustomSortType(CharacterSortType sortType)
		{
		}

		// Token: 0x06015A57 RID: 88663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A57")]
		[Address(RVA = "0xE32B30", Offset = "0xE31730", VA = "0x180E32B30")]
		public void TryUpdateStarMarkTop(bool isStarMarkTop)
		{
		}

		// Token: 0x06015A58 RID: 88664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A58")]
		[Address(RVA = "0xE32BD0", Offset = "0xE317D0", VA = "0x180E32BD0")]
		private void _TryLoadCustomSortTypeCache()
		{
		}

		// Token: 0x06015A59 RID: 88665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A59")]
		[Address(RVA = "0xE32CE0", Offset = "0xE318E0", VA = "0x180E32CE0")]
		private void _TrySaveCustomSortTypeCache()
		{
		}

		// Token: 0x06015A5A RID: 88666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A5A")]
		[Address(RVA = "0xE32D70", Offset = "0xE31970", VA = "0x180E32D70")]
		public CharacterCardSortTypeViewModel()
		{
		}

		// Token: 0x04019F3C RID: 106300
		[Token(Token = "0x4019F3C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_customTypeSet;

		// Token: 0x04019F3D RID: 106301
		[Token(Token = "0x4019F3D")]
		[FieldOffset(Offset = "0x14")]
		private int m_customSortType;

		// Token: 0x04019F3E RID: 106302
		[Token(Token = "0x4019F3E")]
		[FieldOffset(Offset = "0x18")]
		private CharacterSortType m_sortType;

		// Token: 0x04019F3F RID: 106303
		[Token(Token = "0x4019F3F")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_hasCustomSortType;

		// Token: 0x04019F40 RID: 106304
		[Token(Token = "0x4019F40")]
		[FieldOffset(Offset = "0x1D")]
		private bool m_starMarkTop;

		// Token: 0x04019F41 RID: 106305
		[Token(Token = "0x4019F41")]
		[FieldOffset(Offset = "0x20")]
		private string m_customSortTypeCachedKey;

		// Token: 0x04019F42 RID: 106306
		[Token(Token = "0x4019F42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCache;

		// Token: 0x04019F43 RID: 106307
		[Token(Token = "0x4019F43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x04019F44 RID: 106308
		[Token(Token = "0x4019F44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sortType;

		// Token: 0x04019F45 RID: 106309
		[Token(Token = "0x4019F45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_customTypeSet;

		// Token: 0x04019F46 RID: 106310
		[Token(Token = "0x4019F46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_customSortType;

		// Token: 0x04019F47 RID: 106311
		[Token(Token = "0x4019F47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isStarMarkTopMode;

		// Token: 0x04019F48 RID: 106312
		[Token(Token = "0x4019F48")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryUpdateCustomSortType;

		// Token: 0x04019F49 RID: 106313
		[Token(Token = "0x4019F49")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryUpdateStarMarkTop;

		// Token: 0x04019F4A RID: 106314
		[Token(Token = "0x4019F4A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryLoadCustomSortTypeCache;

		// Token: 0x04019F4B RID: 106315
		[Token(Token = "0x4019F4B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TrySaveCustomSortTypeCache;

		// Token: 0x04019F4C RID: 106316
		[Token(Token = "0x4019F4C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
