using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ABF RID: 27327
	[Token(Token = "0x2006ABF")]
	public class DynamicMusicProxy : ActArchiveCompProxy<ArchiveDynamicMusicController>
	{
		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x06027171 RID: 160113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C62")]
		protected override string compType
		{
			[Token(Token = "0x6027171")]
			[Address(RVA = "0x2239070", Offset = "0x2237C70", VA = "0x182239070", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027172 RID: 160114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027172")]
		[Address(RVA = "0x2238800", Offset = "0x2237400", VA = "0x182238800", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027173 RID: 160115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027173")]
		[Address(RVA = "0x22388D0", Offset = "0x22374D0", VA = "0x1822388D0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x06027174 RID: 160116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027174")]
		[Address(RVA = "0x2238CB0", Offset = "0x22378B0", VA = "0x182238CB0")]
		private void _OnMusicItemClicked(ActArchiveType type, string musicID)
		{
		}

		// Token: 0x06027175 RID: 160117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027175")]
		[Address(RVA = "0x2238E10", Offset = "0x2237A10", VA = "0x182238E10")]
		private void _OnSetHomeTheme()
		{
		}

		// Token: 0x06027176 RID: 160118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027176")]
		[Address(RVA = "0x2239000", Offset = "0x2237C00", VA = "0x182239000")]
		public DynamicMusicProxy()
		{
		}

		// Token: 0x040374DF RID: 226527
		[Token(Token = "0x40374DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374E0 RID: 226528
		[Token(Token = "0x40374E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374E1 RID: 226529
		[Token(Token = "0x40374E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374E2 RID: 226530
		[Token(Token = "0x40374E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnMusicItemClicked;

		// Token: 0x040374E3 RID: 226531
		[Token(Token = "0x40374E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSetHomeTheme;

		// Token: 0x040374E4 RID: 226532
		[Token(Token = "0x40374E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
