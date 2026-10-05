using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B80 RID: 27520
	[Token(Token = "0x2006B80")]
	public class ArchiveEndbookEndModel : IHotfixable, IComparable<ArchiveEndbookEndModel>
	{
		// Token: 0x06027514 RID: 161044 RVA: 0x000CE010 File Offset: 0x000CC210
		[Token(Token = "0x6027514")]
		[Address(RVA = "0x227E870", Offset = "0x227D470", VA = "0x18227E870", Slot = "4")]
		public int CompareTo(ArchiveEndbookEndModel other)
		{
			return 0;
		}

		// Token: 0x06027515 RID: 161045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027515")]
		[Address(RVA = "0x227E900", Offset = "0x227D500", VA = "0x18227E900")]
		public ArchiveEndbookEndModel()
		{
		}

		// Token: 0x04037B02 RID: 228098
		[Token(Token = "0x4037B02")]
		[FieldOffset(Offset = "0x10")]
		public List<ArchiveEndbookItemModel> endbookItems;

		// Token: 0x04037B03 RID: 228099
		[Token(Token = "0x4037B03")]
		[FieldOffset(Offset = "0x18")]
		public bool hasExtendingItem;

		// Token: 0x04037B04 RID: 228100
		[Token(Token = "0x4037B04")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x04037B05 RID: 228101
		[Token(Token = "0x4037B05")]
		[FieldOffset(Offset = "0x28")]
		public string endBgId;

		// Token: 0x04037B06 RID: 228102
		[Token(Token = "0x4037B06")]
		[FieldOffset(Offset = "0x30")]
		public string endCardImgId;

		// Token: 0x04037B07 RID: 228103
		[Token(Token = "0x4037B07")]
		[FieldOffset(Offset = "0x38")]
		public bool hasAvg;

		// Token: 0x04037B08 RID: 228104
		[Token(Token = "0x4037B08")]
		[FieldOffset(Offset = "0x39")]
		public bool unlocked;

		// Token: 0x04037B09 RID: 228105
		[Token(Token = "0x4037B09")]
		[FieldOffset(Offset = "0x40")]
		public string avgId;

		// Token: 0x04037B0A RID: 228106
		[Token(Token = "0x4037B0A")]
		[FieldOffset(Offset = "0x48")]
		public float collectPercent;

		// Token: 0x04037B0B RID: 228107
		[Token(Token = "0x4037B0B")]
		[FieldOffset(Offset = "0x4C")]
		public int sortOrder;

		// Token: 0x04037B0C RID: 228108
		[Token(Token = "0x4037B0C")]
		[FieldOffset(Offset = "0x50")]
		public bool hasNew;

		// Token: 0x04037B0D RID: 228109
		[Token(Token = "0x4037B0D")]
		[FieldOffset(Offset = "0x58")]
		public string endCgId;

		// Token: 0x04037B0E RID: 228110
		[Token(Token = "0x4037B0E")]
		[FieldOffset(Offset = "0x60")]
		public string textId;

		// Token: 0x04037B0F RID: 228111
		[Token(Token = "0x4037B0F")]
		[FieldOffset(Offset = "0x68")]
		public int selectedGroupIndex;

		// Token: 0x04037B10 RID: 228112
		[Token(Token = "0x4037B10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04037B11 RID: 228113
		[Token(Token = "0x4037B11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
