using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BCD RID: 27597
	[Token(Token = "0x2006BCD")]
	public class NewsCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602769A RID: 161434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602769A")]
		[Address(RVA = "0x22A5600", Offset = "0x22A4200", VA = "0x1822A5600")]
		public NewsCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602769B RID: 161435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602769B")]
		[Address(RVA = "0x22A5070", Offset = "0x22A3C70", VA = "0x1822A5070")]
		public NewsItemModel GetNewsItemInfo(string newsId)
		{
			return null;
		}

		// Token: 0x0602769C RID: 161436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602769C")]
		[Address(RVA = "0x22A5450", Offset = "0x22A4050", VA = "0x1822A5450")]
		public void SetSelectedNewsItem(string newsID, bool isInit)
		{
		}

		// Token: 0x0602769D RID: 161437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602769D")]
		[Address(RVA = "0x22A51E0", Offset = "0x22A3DE0", VA = "0x1822A51E0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602769E RID: 161438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602769E")]
		[Address(RVA = "0x22A4E50", Offset = "0x22A3A50", VA = "0x1822A4E50", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602769F RID: 161439 RVA: 0x000CE568 File Offset: 0x000CC768
		[Token(Token = "0x602769F")]
		[Address(RVA = "0x22A5160", Offset = "0x22A3D60", VA = "0x1822A5160", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060276A0 RID: 161440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A0")]
		[Address(RVA = "0x22A53A0", Offset = "0x22A3FA0", VA = "0x1822A53A0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x04037D77 RID: 228727
		[Token(Token = "0x4037D77")]
		[FieldOffset(Offset = "0x18")]
		public NewsProperty news;

		// Token: 0x04037D78 RID: 228728
		[Token(Token = "0x4037D78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037D79 RID: 228729
		[Token(Token = "0x4037D79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNewsItemInfo;

		// Token: 0x04037D7A RID: 228730
		[Token(Token = "0x4037D7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedNewsItem;

		// Token: 0x04037D7B RID: 228731
		[Token(Token = "0x4037D7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037D7C RID: 228732
		[Token(Token = "0x4037D7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037D7D RID: 228733
		[Token(Token = "0x4037D7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037D7E RID: 228734
		[Token(Token = "0x4037D7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;
	}
}
