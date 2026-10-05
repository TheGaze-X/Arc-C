using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACA RID: 27338
	[Token(Token = "0x2006ACA")]
	public class StoryProxy : ActArchiveCompProxy<ArchiveStoryController>
	{
		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x060271B1 RID: 160177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6D")]
		protected override string compType
		{
			[Token(Token = "0x60271B1")]
			[Address(RVA = "0x2260B00", Offset = "0x225F700", VA = "0x182260B00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271B2 RID: 160178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B2")]
		[Address(RVA = "0x2260670", Offset = "0x225F270", VA = "0x182260670", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271B3 RID: 160179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B3")]
		[Address(RVA = "0x2260970", Offset = "0x225F570", VA = "0x182260970")]
		private void _OnStoryItemClicked(ActArchiveType type, string storyId)
		{
		}

		// Token: 0x060271B4 RID: 160180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B4")]
		[Address(RVA = "0x2260A90", Offset = "0x225F690", VA = "0x182260A90")]
		public StoryProxy()
		{
		}

		// Token: 0x04037520 RID: 226592
		[Token(Token = "0x4037520")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037521 RID: 226593
		[Token(Token = "0x4037521")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037522 RID: 226594
		[Token(Token = "0x4037522")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnStoryItemClicked;

		// Token: 0x04037523 RID: 226595
		[Token(Token = "0x4037523")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
