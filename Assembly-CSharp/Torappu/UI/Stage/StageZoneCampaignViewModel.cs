using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200679D RID: 26525
	[Token(Token = "0x200679D")]
	public class StageZoneCampaignViewModel : IHotfixable
	{
		// Token: 0x060260AB RID: 155819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260AB")]
		[Address(RVA = "0x211C490", Offset = "0x211B090", VA = "0x18211C490")]
		public void LoadData()
		{
		}

		// Token: 0x060260AC RID: 155820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260AC")]
		[Address(RVA = "0x211C7E0", Offset = "0x211B3E0", VA = "0x18211C7E0")]
		public StageZoneCampaignViewModel()
		{
		}

		// Token: 0x04035886 RID: 219270
		[Token(Token = "0x4035886")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x04035887 RID: 219271
		[Token(Token = "0x4035887")]
		[FieldOffset(Offset = "0x14")]
		public int currentFee;

		// Token: 0x04035888 RID: 219272
		[Token(Token = "0x4035888")]
		[FieldOffset(Offset = "0x18")]
		public int totalFee;

		// Token: 0x04035889 RID: 219273
		[Token(Token = "0x4035889")]
		[FieldOffset(Offset = "0x20")]
		public string feeCountDownStr;

		// Token: 0x0403588A RID: 219274
		[Token(Token = "0x403588A")]
		[FieldOffset(Offset = "0x28")]
		public string rotateGroupId;

		// Token: 0x0403588B RID: 219275
		[Token(Token = "0x403588B")]
		[FieldOffset(Offset = "0x30")]
		public string rotateStageId;

		// Token: 0x0403588C RID: 219276
		[Token(Token = "0x403588C")]
		[FieldOffset(Offset = "0x38")]
		public string rotateStageName;

		// Token: 0x0403588D RID: 219277
		[Token(Token = "0x403588D")]
		[FieldOffset(Offset = "0x40")]
		public string rotateZoneId;

		// Token: 0x0403588E RID: 219278
		[Token(Token = "0x403588E")]
		[FieldOffset(Offset = "0x48")]
		public string rotateZoneName;

		// Token: 0x0403588F RID: 219279
		[Token(Token = "0x403588F")]
		[FieldOffset(Offset = "0x50")]
		public Sprite spriteRotateZoneIcon;

		// Token: 0x04035890 RID: 219280
		[Token(Token = "0x4035890")]
		[FieldOffset(Offset = "0x58")]
		public string rotateRemainTimeStr;

		// Token: 0x04035891 RID: 219281
		[Token(Token = "0x4035891")]
		[FieldOffset(Offset = "0x60")]
		public long rotateRemainTime;

		// Token: 0x04035892 RID: 219282
		[Token(Token = "0x4035892")]
		[FieldOffset(Offset = "0x68")]
		public bool isRotateUnlocked;

		// Token: 0x04035893 RID: 219283
		[Token(Token = "0x4035893")]
		[FieldOffset(Offset = "0x70")]
		public string rotateUnlockStr;

		// Token: 0x04035894 RID: 219284
		[Token(Token = "0x4035894")]
		[FieldOffset(Offset = "0x78")]
		public bool isTrainingAllOpen;

		// Token: 0x04035895 RID: 219285
		[Token(Token = "0x4035895")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035896 RID: 219286
		[Token(Token = "0x4035896")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
