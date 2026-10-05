using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC8 RID: 27336
	[Token(Token = "0x2006AC8")]
	public class PicProxy : ActArchiveCompProxy<ArchivePicController>
	{
		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x060271A5 RID: 160165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6B")]
		protected override string compType
		{
			[Token(Token = "0x60271A5")]
			[Address(RVA = "0x225F480", Offset = "0x225E080", VA = "0x18225F480", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271A6 RID: 160166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A6")]
		[Address(RVA = "0x225EC10", Offset = "0x225D810", VA = "0x18225EC10", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271A7 RID: 160167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A7")]
		[Address(RVA = "0x225F170", Offset = "0x225DD70", VA = "0x18225F170")]
		private void _OnPicItemClicked(ActArchiveType type, string picID)
		{
		}

		// Token: 0x060271A8 RID: 160168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A8")]
		[Address(RVA = "0x225EFE0", Offset = "0x225DBE0", VA = "0x18225EFE0")]
		private void _OnFullscreenToggled(bool on)
		{
		}

		// Token: 0x060271A9 RID: 160169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271A9")]
		[Address(RVA = "0x225F290", Offset = "0x225DE90", VA = "0x18225F290")]
		private void _OnSetHomeKV()
		{
		}

		// Token: 0x060271AA RID: 160170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271AA")]
		[Address(RVA = "0x225F410", Offset = "0x225E010", VA = "0x18225F410")]
		public PicProxy()
		{
		}

		// Token: 0x04037514 RID: 226580
		[Token(Token = "0x4037514")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037515 RID: 226581
		[Token(Token = "0x4037515")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037516 RID: 226582
		[Token(Token = "0x4037516")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPicItemClicked;

		// Token: 0x04037517 RID: 226583
		[Token(Token = "0x4037517")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnFullscreenToggled;

		// Token: 0x04037518 RID: 226584
		[Token(Token = "0x4037518")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSetHomeKV;

		// Token: 0x04037519 RID: 226585
		[Token(Token = "0x4037519")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
