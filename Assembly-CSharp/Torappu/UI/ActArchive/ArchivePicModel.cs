using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE0 RID: 27616
	[Token(Token = "0x2006BE0")]
	public class ArchivePicModel : IHotfixable
	{
		// Token: 0x060276F9 RID: 161529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276F9")]
		[Address(RVA = "0x229ACF0", Offset = "0x22998F0", VA = "0x18229ACF0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060276FA RID: 161530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276FA")]
		[Address(RVA = "0x229B320", Offset = "0x2299F20", VA = "0x18229B320")]
		private ActArchiveResData.PicArchiveResItemData _getArchivePicResData(string picId)
		{
			return null;
		}

		// Token: 0x060276FB RID: 161531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276FB")]
		[Address(RVA = "0x229AAD0", Offset = "0x22996D0", VA = "0x18229AAD0")]
		public string GetDefaultItemID()
		{
			return null;
		}

		// Token: 0x060276FC RID: 161532 RVA: 0x000CE5E0 File Offset: 0x000CC7E0
		[Token(Token = "0x60276FC")]
		[Address(RVA = "0x229AC60", Offset = "0x2299860", VA = "0x18229AC60")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x060276FD RID: 161533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276FD")]
		[Address(RVA = "0x229B270", Offset = "0x2299E70", VA = "0x18229B270")]
		public ArchivePicModel()
		{
		}

		// Token: 0x04037DFF RID: 228863
		[Token(Token = "0x4037DFF")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, PicItemModel> picItems;

		// Token: 0x04037E00 RID: 228864
		[Token(Token = "0x4037E00")]
		[FieldOffset(Offset = "0x18")]
		public string selectedPicId;

		// Token: 0x04037E01 RID: 228865
		[Token(Token = "0x4037E01")]
		[FieldOffset(Offset = "0x20")]
		public bool isFullscreen;

		// Token: 0x04037E02 RID: 228866
		[Token(Token = "0x4037E02")]
		[FieldOffset(Offset = "0x21")]
		public bool isInit;

		// Token: 0x04037E03 RID: 228867
		[Token(Token = "0x4037E03")]
		[FieldOffset(Offset = "0x28")]
		public string homeKVId;

		// Token: 0x04037E04 RID: 228868
		[Token(Token = "0x4037E04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037E05 RID: 228869
		[Token(Token = "0x4037E05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__getArchivePicResData;

		// Token: 0x04037E06 RID: 228870
		[Token(Token = "0x4037E06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemID;

		// Token: 0x04037E07 RID: 228871
		[Token(Token = "0x4037E07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x04037E08 RID: 228872
		[Token(Token = "0x4037E08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
