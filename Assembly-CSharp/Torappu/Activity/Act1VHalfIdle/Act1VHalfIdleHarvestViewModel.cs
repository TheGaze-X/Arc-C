using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077AE RID: 30638
	[Token(Token = "0x20077AE")]
	public class Act1VHalfIdleHarvestViewModel : IHotfixable
	{
		// Token: 0x0602B036 RID: 176182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B036")]
		[Address(RVA = "0x26CF1A0", Offset = "0x26CDDA0", VA = "0x1826CF1A0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602B037 RID: 176183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B037")]
		[Address(RVA = "0x26CF720", Offset = "0x26CE320", VA = "0x1826CF720")]
		public void RefreshData()
		{
		}

		// Token: 0x0602B038 RID: 176184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B038")]
		[Address(RVA = "0x26CFB10", Offset = "0x26CE710", VA = "0x1826CFB10")]
		public void RefreshProduceProgressOnly(long curTs)
		{
		}

		// Token: 0x0602B039 RID: 176185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B039")]
		[Address(RVA = "0x26CF9D0", Offset = "0x26CE5D0", VA = "0x1826CF9D0")]
		public void RefreshHarvestResultOnly()
		{
		}

		// Token: 0x0602B03A RID: 176186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B03A")]
		[Address(RVA = "0x26CFDF0", Offset = "0x26CE9F0", VA = "0x1826CFDF0")]
		public Act1VHalfIdleHarvestViewModel()
		{
		}

		// Token: 0x0403E17A RID: 254330
		[Token(Token = "0x403E17A")]
		[FieldOffset(Offset = "0x10")]
		public bool isInvalidTs;

		// Token: 0x0403E17B RID: 254331
		[Token(Token = "0x403E17B")]
		[FieldOffset(Offset = "0x14")]
		public int itemViewModelsSeqNum;

		// Token: 0x0403E17C RID: 254332
		[Token(Token = "0x403E17C")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VHalfIdleHarvestItemViewModel> itemViewModels;

		// Token: 0x0403E17D RID: 254333
		[Token(Token = "0x403E17D")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdleHarvestViewModel.ProduceState productState;

		// Token: 0x0403E17E RID: 254334
		[Token(Token = "0x403E17E")]
		[FieldOffset(Offset = "0x28")]
		public long lastRefreshTs;

		// Token: 0x0403E17F RID: 254335
		[Token(Token = "0x403E17F")]
		[FieldOffset(Offset = "0x30")]
		public long lastHarvestTs;

		// Token: 0x0403E180 RID: 254336
		[Token(Token = "0x403E180")]
		[FieldOffset(Offset = "0x38")]
		public long maxHarvestTs;

		// Token: 0x0403E181 RID: 254337
		[Token(Token = "0x403E181")]
		[FieldOffset(Offset = "0x40")]
		public long lastProduceTs;

		// Token: 0x0403E182 RID: 254338
		[Token(Token = "0x403E182")]
		[FieldOffset(Offset = "0x48")]
		public long nextProduceTs;

		// Token: 0x0403E183 RID: 254339
		[Token(Token = "0x403E183")]
		[FieldOffset(Offset = "0x50")]
		public long showHintTs;

		// Token: 0x0403E184 RID: 254340
		[Token(Token = "0x403E184")]
		[FieldOffset(Offset = "0x58")]
		public long actStartTs;

		// Token: 0x0403E185 RID: 254341
		[Token(Token = "0x403E185")]
		[FieldOffset(Offset = "0x60")]
		public int maxHarvestTime;

		// Token: 0x0403E186 RID: 254342
		[Token(Token = "0x403E186")]
		[FieldOffset(Offset = "0x64")]
		public int showHintThresholdTime;

		// Token: 0x0403E187 RID: 254343
		[Token(Token = "0x403E187")]
		[FieldOffset(Offset = "0x68")]
		public int produceCd;

		// Token: 0x0403E188 RID: 254344
		[Token(Token = "0x403E188")]
		[FieldOffset(Offset = "0x6C")]
		public float harvestProgress;

		// Token: 0x0403E189 RID: 254345
		[Token(Token = "0x403E189")]
		[FieldOffset(Offset = "0x70")]
		public float produceProgress;

		// Token: 0x0403E18A RID: 254346
		[Token(Token = "0x403E18A")]
		[FieldOffset(Offset = "0x78")]
		public string actId;

		// Token: 0x0403E18B RID: 254347
		[Token(Token = "0x403E18B")]
		[FieldOffset(Offset = "0x80")]
		public bool showCountDownHint;

		// Token: 0x0403E18C RID: 254348
		[Token(Token = "0x403E18C")]
		[FieldOffset(Offset = "0x88")]
		public string countDownHintText;

		// Token: 0x0403E18D RID: 254349
		[Token(Token = "0x403E18D")]
		[FieldOffset(Offset = "0x90")]
		public string harvestRuleTipText;

		// Token: 0x0403E18E RID: 254350
		[Token(Token = "0x403E18E")]
		[FieldOffset(Offset = "0x98")]
		public TimeSpan countDownTimeSpan;

		// Token: 0x0403E18F RID: 254351
		[Token(Token = "0x403E18F")]
		[FieldOffset(Offset = "0xA0")]
		private long m_actEndTs;

		// Token: 0x0403E190 RID: 254352
		[Token(Token = "0x403E190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E191 RID: 254353
		[Token(Token = "0x403E191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403E192 RID: 254354
		[Token(Token = "0x403E192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshProduceProgressOnly;

		// Token: 0x0403E193 RID: 254355
		[Token(Token = "0x403E193")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshHarvestResultOnly;

		// Token: 0x0403E194 RID: 254356
		[Token(Token = "0x403E194")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077AF RID: 30639
		[Token(Token = "0x20077AF")]
		public enum ProduceState
		{
			// Token: 0x0403E196 RID: 254358
			[Token(Token = "0x403E196")]
			EMPTY,
			// Token: 0x0403E197 RID: 254359
			[Token(Token = "0x403E197")]
			PRODUCING,
			// Token: 0x0403E198 RID: 254360
			[Token(Token = "0x403E198")]
			FULL
		}
	}
}
