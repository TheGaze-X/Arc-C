using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACB RID: 27339
	[Token(Token = "0x2006ACB")]
	public class DynamicStoryProxy : ActArchiveCompProxy<ArchiveDynamicStoryController>
	{
		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x060271B5 RID: 160181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6E")]
		protected override string compType
		{
			[Token(Token = "0x60271B5")]
			[Address(RVA = "0x225C340", Offset = "0x225AF40", VA = "0x18225C340", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271B6 RID: 160182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271B6")]
		[Address(RVA = "0x225BE20", Offset = "0x225AA20", VA = "0x18225BE20", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271B7 RID: 160183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B7")]
		[Address(RVA = "0x225BEF0", Offset = "0x225AAF0", VA = "0x18225BEF0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271B8 RID: 160184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B8")]
		[Address(RVA = "0x225C1D0", Offset = "0x225ADD0", VA = "0x18225C1D0")]
		private void _OnStoryItemClicked(ActArchiveType type, string storyId)
		{
		}

		// Token: 0x060271B9 RID: 160185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271B9")]
		[Address(RVA = "0x225C2D0", Offset = "0x225AED0", VA = "0x18225C2D0")]
		public DynamicStoryProxy()
		{
		}

		// Token: 0x04037524 RID: 226596
		[Token(Token = "0x4037524")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037525 RID: 226597
		[Token(Token = "0x4037525")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037526 RID: 226598
		[Token(Token = "0x4037526")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037527 RID: 226599
		[Token(Token = "0x4037527")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStoryItemClicked;

		// Token: 0x04037528 RID: 226600
		[Token(Token = "0x4037528")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
