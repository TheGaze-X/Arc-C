using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F81 RID: 28545
	[Token(Token = "0x2006F81")]
	public class ActMultiV3ManualAlbumModel : IHotfixable
	{
		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x06028838 RID: 165944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F79")]
		public ActMultiV3WeekAlbumViewModel activeAlbum
		{
			[Token(Token = "0x6028838")]
			[Address(RVA = "0x23D4A00", Offset = "0x23D3600", VA = "0x1823D4A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028839 RID: 165945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028839")]
		[Address(RVA = "0x23D4230", Offset = "0x23D2E30", VA = "0x1823D4230")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0602883A RID: 165946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602883A")]
		[Address(RVA = "0x23D4630", Offset = "0x23D3230", VA = "0x1823D4630")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602883B RID: 165947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602883B")]
		[Address(RVA = "0x23D4880", Offset = "0x23D3480", VA = "0x1823D4880")]
		public void UpdateFocusWeek()
		{
		}

		// Token: 0x0602883C RID: 165948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602883C")]
		[Address(RVA = "0x23D4810", Offset = "0x23D3410", VA = "0x1823D4810")]
		public void SelectWeek(int weekIdx)
		{
		}

		// Token: 0x0602883D RID: 165949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602883D")]
		[Address(RVA = "0x23D4950", Offset = "0x23D3550", VA = "0x1823D4950")]
		public ActMultiV3ManualAlbumModel()
		{
		}

		// Token: 0x04039AEF RID: 236271
		[Token(Token = "0x4039AEF")]
		[FieldOffset(Offset = "0x10")]
		public List<ActMultiV3WeekAlbumViewModel> weekModels;

		// Token: 0x04039AF0 RID: 236272
		[Token(Token = "0x4039AF0")]
		[FieldOffset(Offset = "0x18")]
		public bool hasTrackPoint;

		// Token: 0x04039AF1 RID: 236273
		[Token(Token = "0x4039AF1")]
		[FieldOffset(Offset = "0x1C")]
		public int selectedWeekTabIdx;

		// Token: 0x04039AF2 RID: 236274
		[Token(Token = "0x4039AF2")]
		[FieldOffset(Offset = "0x20")]
		public int renderSeqNum;

		// Token: 0x04039AF3 RID: 236275
		[Token(Token = "0x4039AF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeAlbum;

		// Token: 0x04039AF4 RID: 236276
		[Token(Token = "0x4039AF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04039AF5 RID: 236277
		[Token(Token = "0x4039AF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039AF6 RID: 236278
		[Token(Token = "0x4039AF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateFocusWeek;

		// Token: 0x04039AF7 RID: 236279
		[Token(Token = "0x4039AF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectWeek;

		// Token: 0x04039AF8 RID: 236280
		[Token(Token = "0x4039AF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
