using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B99 RID: 27545
	[Token(Token = "0x2006B99")]
	public class LandmarkItemModel : ArchiveItemModel
	{
		// Token: 0x0602757B RID: 161147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602757B")]
		[Address(RVA = "0x228CBF0", Offset = "0x228B7F0", VA = "0x18228CBF0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602757C RID: 161148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602757C")]
		[Address(RVA = "0x228CB60", Offset = "0x228B760", VA = "0x18228CB60", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x0602757D RID: 161149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602757D")]
		[Address(RVA = "0x228CC50", Offset = "0x228B850", VA = "0x18228CC50")]
		public LandmarkItemModel()
		{
		}

		// Token: 0x04037BCE RID: 228302
		[Token(Token = "0x4037BCE")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.LandmarkArchiveResItemData landmarkItemData;

		// Token: 0x04037BCF RID: 228303
		[Token(Token = "0x4037BCF")]
		[FieldOffset(Offset = "0x38")]
		public string landmarkId;

		// Token: 0x04037BD0 RID: 228304
		[Token(Token = "0x4037BD0")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04037BD1 RID: 228305
		[Token(Token = "0x4037BD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037BD2 RID: 228306
		[Token(Token = "0x4037BD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037BD3 RID: 228307
		[Token(Token = "0x4037BD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
