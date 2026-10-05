using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B9D RID: 27549
	[Token(Token = "0x2006B9D")]
	public class LandmarkCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027587 RID: 161159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027587")]
		[Address(RVA = "0x228CAF0", Offset = "0x228B6F0", VA = "0x18228CAF0")]
		public LandmarkCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027588 RID: 161160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027588")]
		[Address(RVA = "0x228C2A0", Offset = "0x228AEA0", VA = "0x18228C2A0")]
		public LandmarkItemModel GetLandmarkItemInfo(string landmarkId)
		{
			return null;
		}

		// Token: 0x06027589 RID: 161161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027589")]
		[Address(RVA = "0x228C940", Offset = "0x228B540", VA = "0x18228C940")]
		public void SetSelectedLandmarkItem(string landmarkId, bool isInit)
		{
		}

		// Token: 0x0602758A RID: 161162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602758A")]
		[Address(RVA = "0x228C6D0", Offset = "0x228B2D0", VA = "0x18228C6D0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602758B RID: 161163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602758B")]
		[Address(RVA = "0x228C080", Offset = "0x228AC80", VA = "0x18228C080", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602758C RID: 161164 RVA: 0x000CE238 File Offset: 0x000CC438
		[Token(Token = "0x602758C")]
		[Address(RVA = "0x228C650", Offset = "0x228B250", VA = "0x18228C650", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602758D RID: 161165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602758D")]
		[Address(RVA = "0x228C890", Offset = "0x228B490", VA = "0x18228C890", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602758E RID: 161166 RVA: 0x000CE250 File Offset: 0x000CC450
		[Token(Token = "0x602758E")]
		[Address(RVA = "0x228C390", Offset = "0x228AF90", VA = "0x18228C390", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602758F RID: 161167 RVA: 0x000CE268 File Offset: 0x000CC468
		[Token(Token = "0x602758F")]
		[Address(RVA = "0x228C4F0", Offset = "0x228B0F0", VA = "0x18228C4F0", Slot = "9")]
		public override bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06027590 RID: 161168 RVA: 0x000CE280 File Offset: 0x000CC480
		[Token(Token = "0x6027590")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027591 RID: 161169 RVA: 0x000CE298 File Offset: 0x000CC498
		[Token(Token = "0x6027591")]
		[Address(RVA = "0x2274CB0", Offset = "0x22738B0", VA = "0x182274CB0")]
		private bool <>xLuaBaseProxy_IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x04037BDE RID: 228318
		[Token(Token = "0x4037BDE")]
		[FieldOffset(Offset = "0x18")]
		public LandmarkProperty landmark;

		// Token: 0x04037BDF RID: 228319
		[Token(Token = "0x4037BDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037BE0 RID: 228320
		[Token(Token = "0x4037BE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetLandmarkItemInfo;

		// Token: 0x04037BE1 RID: 228321
		[Token(Token = "0x4037BE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedLandmarkItem;

		// Token: 0x04037BE2 RID: 228322
		[Token(Token = "0x4037BE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037BE3 RID: 228323
		[Token(Token = "0x4037BE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037BE4 RID: 228324
		[Token(Token = "0x4037BE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037BE5 RID: 228325
		[Token(Token = "0x4037BE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037BE6 RID: 228326
		[Token(Token = "0x4037BE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x04037BE7 RID: 228327
		[Token(Token = "0x4037BE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsUnlocked;
	}
}
