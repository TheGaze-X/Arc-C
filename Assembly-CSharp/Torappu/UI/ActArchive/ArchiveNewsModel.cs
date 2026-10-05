using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BCA RID: 27594
	[Token(Token = "0x2006BCA")]
	public class ArchiveNewsModel : IHotfixable
	{
		// Token: 0x06027691 RID: 161425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027691")]
		[Address(RVA = "0x22982D0", Offset = "0x2296ED0", VA = "0x1822982D0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027692 RID: 161426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027692")]
		[Address(RVA = "0x2298A40", Offset = "0x2297640", VA = "0x182298A40")]
		private ActArchiveResData.NewsArchiveResItemData _getArchiveNewsResData(string newsId)
		{
			return null;
		}

		// Token: 0x06027693 RID: 161427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027693")]
		[Address(RVA = "0x22980B0", Offset = "0x2296CB0", VA = "0x1822980B0")]
		public string GetDefaultItemID()
		{
			return null;
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x000CE538 File Offset: 0x000CC738
		[Token(Token = "0x6027694")]
		[Address(RVA = "0x2298240", Offset = "0x2296E40", VA = "0x182298240")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x06027695 RID: 161429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027695")]
		[Address(RVA = "0x2298990", Offset = "0x2297590", VA = "0x182298990")]
		public ArchiveNewsModel()
		{
		}

		// Token: 0x04037D6C RID: 228716
		[Token(Token = "0x4037D6C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, NewsItemModel> newsItems;

		// Token: 0x04037D6D RID: 228717
		[Token(Token = "0x4037D6D")]
		[FieldOffset(Offset = "0x18")]
		public string selectedNewsId;

		// Token: 0x04037D6E RID: 228718
		[Token(Token = "0x4037D6E")]
		[FieldOffset(Offset = "0x20")]
		public bool isInit;

		// Token: 0x04037D6F RID: 228719
		[Token(Token = "0x4037D6F")]
		[FieldOffset(Offset = "0x24")]
		public int paramT;

		// Token: 0x04037D70 RID: 228720
		[Token(Token = "0x4037D70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037D71 RID: 228721
		[Token(Token = "0x4037D71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__getArchiveNewsResData;

		// Token: 0x04037D72 RID: 228722
		[Token(Token = "0x4037D72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemID;

		// Token: 0x04037D73 RID: 228723
		[Token(Token = "0x4037D73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x04037D74 RID: 228724
		[Token(Token = "0x4037D74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
