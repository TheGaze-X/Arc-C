using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B9A RID: 27546
	[Token(Token = "0x2006B9A")]
	public class ArchiveLandmarkModel : IHotfixable
	{
		// Token: 0x0602757E RID: 161150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602757E")]
		[Address(RVA = "0x2284F80", Offset = "0x2283B80", VA = "0x182284F80")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602757F RID: 161151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602757F")]
		[Address(RVA = "0x2285410", Offset = "0x2284010", VA = "0x182285410")]
		private ActArchiveResData.LandmarkArchiveResItemData _GetArchiveLandmarkResData(string landmarkId)
		{
			return null;
		}

		// Token: 0x06027580 RID: 161152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027580")]
		[Address(RVA = "0x2284D60", Offset = "0x2283960", VA = "0x182284D60")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x06027581 RID: 161153 RVA: 0x000CE208 File Offset: 0x000CC408
		[Token(Token = "0x6027581")]
		[Address(RVA = "0x2284EF0", Offset = "0x2283AF0", VA = "0x182284EF0")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x06027582 RID: 161154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027582")]
		[Address(RVA = "0x2285520", Offset = "0x2284120", VA = "0x182285520")]
		public ArchiveLandmarkModel()
		{
		}

		// Token: 0x04037BD4 RID: 228308
		[Token(Token = "0x4037BD4")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, LandmarkItemModel> landmarkItems;

		// Token: 0x04037BD5 RID: 228309
		[Token(Token = "0x4037BD5")]
		[FieldOffset(Offset = "0x18")]
		public string selectedLandmarkId;

		// Token: 0x04037BD6 RID: 228310
		[Token(Token = "0x4037BD6")]
		[FieldOffset(Offset = "0x20")]
		public bool isInit;

		// Token: 0x04037BD7 RID: 228311
		[Token(Token = "0x4037BD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037BD8 RID: 228312
		[Token(Token = "0x4037BD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetArchiveLandmarkResData;

		// Token: 0x04037BD9 RID: 228313
		[Token(Token = "0x4037BD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x04037BDA RID: 228314
		[Token(Token = "0x4037BDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x04037BDB RID: 228315
		[Token(Token = "0x4037BDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
