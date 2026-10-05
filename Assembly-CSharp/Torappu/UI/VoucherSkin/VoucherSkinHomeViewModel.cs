using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B92 RID: 15250
	[Token(Token = "0x2003B92")]
	public class VoucherSkinHomeViewModel : IHotfixable
	{
		// Token: 0x06017E55 RID: 97877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E55")]
		[Address(RVA = "0x10258B0", Offset = "0x10244B0", VA = "0x1810258B0")]
		public void LoadData(VoucherSkinPage.Params param)
		{
		}

		// Token: 0x06017E56 RID: 97878 RVA: 0x000988E0 File Offset: 0x00096AE0
		[Token(Token = "0x6017E56")]
		[Address(RVA = "0x1025AD0", Offset = "0x10246D0", VA = "0x181025AD0")]
		public bool TrySwitchRuleState(bool show)
		{
			return default(bool);
		}

		// Token: 0x06017E57 RID: 97879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E57")]
		[Address(RVA = "0x1025B50", Offset = "0x1024750", VA = "0x181025B50")]
		public VoucherSkinHomeViewModel()
		{
		}

		// Token: 0x0401CE45 RID: 118341
		[Token(Token = "0x401CE45")]
		[FieldOffset(Offset = "0x10")]
		public string voucherItemId;

		// Token: 0x0401CE46 RID: 118342
		[Token(Token = "0x401CE46")]
		[FieldOffset(Offset = "0x18")]
		public int voucherItemInstId;

		// Token: 0x0401CE47 RID: 118343
		[Token(Token = "0x401CE47")]
		[FieldOffset(Offset = "0x1C")]
		public ItemType voucherItemType;

		// Token: 0x0401CE48 RID: 118344
		[Token(Token = "0x401CE48")]
		[FieldOffset(Offset = "0x20")]
		public List<VoucherSkinItemViewModel> skinModelList;

		// Token: 0x0401CE49 RID: 118345
		[Token(Token = "0x401CE49")]
		[FieldOffset(Offset = "0x28")]
		public long shopEndTime;

		// Token: 0x0401CE4A RID: 118346
		[Token(Token = "0x401CE4A")]
		[FieldOffset(Offset = "0x30")]
		public string ruleDesc;

		// Token: 0x0401CE4B RID: 118347
		[Token(Token = "0x401CE4B")]
		[FieldOffset(Offset = "0x38")]
		public bool showRule;

		// Token: 0x0401CE4C RID: 118348
		[Token(Token = "0x401CE4C")]
		[FieldOffset(Offset = "0x39")]
		public bool isPreview;

		// Token: 0x0401CE4D RID: 118349
		[Token(Token = "0x401CE4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401CE4E RID: 118350
		[Token(Token = "0x401CE4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TrySwitchRuleState;

		// Token: 0x0401CE4F RID: 118351
		[Token(Token = "0x401CE4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
