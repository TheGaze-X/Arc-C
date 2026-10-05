using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F83 RID: 28547
	[Token(Token = "0x2006F83")]
	public class ActMultiV3WeekAlbumViewModel : IHotfixable
	{
		// Token: 0x06028841 RID: 165953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028841")]
		[Address(RVA = "0x23EB140", Offset = "0x23E9D40", VA = "0x1823EB140")]
		public ActMultiV3WeekAlbumViewModel(int tabIdx, string rewardId, ActMultiV3WeeklyPhotoRewardData rewardData)
		{
		}

		// Token: 0x06028842 RID: 165954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028842")]
		[Address(RVA = "0x23EABF0", Offset = "0x23E97F0", VA = "0x1823EABF0")]
		public void LoadData(string actId, PlayerActivity.PlayerMultiV3Activity.Photo photo, Dictionary<string, ActMultiV3PhotoTypeData> photoTypeDataDict, ref bool prevCommited)
		{
		}

		// Token: 0x04039AFB RID: 236283
		[Token(Token = "0x4039AFB")]
		[FieldOffset(Offset = "0x10")]
		public int tabIndex;

		// Token: 0x04039AFC RID: 236284
		[Token(Token = "0x4039AFC")]
		[FieldOffset(Offset = "0x18")]
		public string weekRewardId;

		// Token: 0x04039AFD RID: 236285
		[Token(Token = "0x4039AFD")]
		[FieldOffset(Offset = "0x20")]
		public int order;

		// Token: 0x04039AFE RID: 236286
		[Token(Token = "0x4039AFE")]
		[FieldOffset(Offset = "0x28")]
		public string titleDesc;

		// Token: 0x04039AFF RID: 236287
		[Token(Token = "0x4039AFF")]
		[FieldOffset(Offset = "0x30")]
		public long unlockTime;

		// Token: 0x04039B00 RID: 236288
		[Token(Token = "0x4039B00")]
		[FieldOffset(Offset = "0x38")]
		public bool isPrevCommitted;

		// Token: 0x04039B01 RID: 236289
		[Token(Token = "0x4039B01")]
		[FieldOffset(Offset = "0x39")]
		public bool isUnlocked;

		// Token: 0x04039B02 RID: 236290
		[Token(Token = "0x4039B02")]
		[FieldOffset(Offset = "0x3A")]
		public bool isCommitted;

		// Token: 0x04039B03 RID: 236291
		[Token(Token = "0x4039B03")]
		[FieldOffset(Offset = "0x3C")]
		public int collectCnt;

		// Token: 0x04039B04 RID: 236292
		[Token(Token = "0x4039B04")]
		[FieldOffset(Offset = "0x40")]
		public int totalCnt;

		// Token: 0x04039B05 RID: 236293
		[Token(Token = "0x4039B05")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemBundle> rewards;

		// Token: 0x04039B06 RID: 236294
		[Token(Token = "0x4039B06")]
		[FieldOffset(Offset = "0x50")]
		public bool hasTrackPoint;

		// Token: 0x04039B07 RID: 236295
		[Token(Token = "0x4039B07")]
		[FieldOffset(Offset = "0x58")]
		public List<ActMultiV3PhotoViewModel> photos;

		// Token: 0x04039B08 RID: 236296
		[Token(Token = "0x4039B08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039B09 RID: 236297
		[Token(Token = "0x4039B09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
