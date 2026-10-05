using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BBA RID: 27578
	[Token(Token = "0x2006BBA")]
	public class MusicItemModel : ArchiveItemModel
	{
		// Token: 0x06027630 RID: 161328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027630")]
		[Address(RVA = "0x22A4CF0", Offset = "0x22A38F0", VA = "0x1822A4CF0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027631 RID: 161329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027631")]
		[Address(RVA = "0x22A4C60", Offset = "0x22A3860", VA = "0x1822A4C60", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027632 RID: 161330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027632")]
		[Address(RVA = "0x22A4D50", Offset = "0x22A3950", VA = "0x1822A4D50")]
		public MusicItemModel()
		{
		}

		// Token: 0x04037CD0 RID: 228560
		[Token(Token = "0x4037CD0")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.AudioArchiveResItemData musicItemData;

		// Token: 0x04037CD1 RID: 228561
		[Token(Token = "0x4037CD1")]
		[FieldOffset(Offset = "0x38")]
		public string musicId;

		// Token: 0x04037CD2 RID: 228562
		[Token(Token = "0x4037CD2")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04037CD3 RID: 228563
		[Token(Token = "0x4037CD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037CD4 RID: 228564
		[Token(Token = "0x4037CD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037CD5 RID: 228565
		[Token(Token = "0x4037CD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
