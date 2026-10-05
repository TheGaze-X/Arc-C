using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC7 RID: 27335
	[Token(Token = "0x2006AC7")]
	public class MusicProxy : ActArchiveCompProxy<ArchiveMusicController>
	{
		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x060271A0 RID: 160160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6A")]
		protected override string compType
		{
			[Token(Token = "0x60271A0")]
			[Address(RVA = "0x225E6A0", Offset = "0x225D2A0", VA = "0x18225E6A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271A1 RID: 160161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A1")]
		[Address(RVA = "0x225E020", Offset = "0x225CC20", VA = "0x18225E020", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271A2 RID: 160162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A2")]
		[Address(RVA = "0x225E390", Offset = "0x225CF90", VA = "0x18225E390")]
		private void _OnMusicItemClicked(ActArchiveType type, string musicID)
		{
		}

		// Token: 0x060271A3 RID: 160163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A3")]
		[Address(RVA = "0x225E4B0", Offset = "0x225D0B0", VA = "0x18225E4B0")]
		private void _OnSetHomeTheme()
		{
		}

		// Token: 0x060271A4 RID: 160164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A4")]
		[Address(RVA = "0x225E630", Offset = "0x225D230", VA = "0x18225E630")]
		public MusicProxy()
		{
		}

		// Token: 0x0403750F RID: 226575
		[Token(Token = "0x403750F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037510 RID: 226576
		[Token(Token = "0x4037510")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037511 RID: 226577
		[Token(Token = "0x4037511")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnMusicItemClicked;

		// Token: 0x04037512 RID: 226578
		[Token(Token = "0x4037512")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSetHomeTheme;

		// Token: 0x04037513 RID: 226579
		[Token(Token = "0x4037513")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
