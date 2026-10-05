using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B30 RID: 23344
	[Token(Token = "0x2005B30")]
	public class ShopRecommendTemplateNormalFurnViewModel : ShopRecommendTemplateViewModelBase, IHotfixable
	{
		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06021E49 RID: 138825 RVA: 0x000BBA10 File Offset: 0x000B9C10
		[Token(Token = "0x17004F44")]
		public long showStartTs
		{
			[Token(Token = "0x6021E49")]
			[Address(RVA = "0x1C690F0", Offset = "0x1C67CF0", VA = "0x181C690F0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06021E4A RID: 138826 RVA: 0x000BBA28 File Offset: 0x000B9C28
		[Token(Token = "0x17004F45")]
		public long showEndTs
		{
			[Token(Token = "0x6021E4A")]
			[Address(RVA = "0x1C69090", Offset = "0x1C67C90", VA = "0x181C69090")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06021E4B RID: 138827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F46")]
		public string furnSetName
		{
			[Token(Token = "0x6021E4B")]
			[Address(RVA = "0x1C68F70", Offset = "0x1C67B70", VA = "0x181C68F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x06021E4C RID: 138828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F47")]
		public string desc
		{
			[Token(Token = "0x6021E4C")]
			[Address(RVA = "0x1C68F10", Offset = "0x1C67B10", VA = "0x181C68F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x06021E4D RID: 138829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F48")]
		public string backColor
		{
			[Token(Token = "0x6021E4D")]
			[Address(RVA = "0x1C68E50", Offset = "0x1C67A50", VA = "0x181C68E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x06021E4E RID: 138830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F49")]
		public string textColor
		{
			[Token(Token = "0x6021E4E")]
			[Address(RVA = "0x1C69150", Offset = "0x1C67D50", VA = "0x181C69150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x06021E4F RID: 138831 RVA: 0x000BBA40 File Offset: 0x000B9C40
		[Token(Token = "0x17004F4A")]
		public bool isNew
		{
			[Token(Token = "0x6021E4F")]
			[Address(RVA = "0x1C69030", Offset = "0x1C67C30", VA = "0x181C69030")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x06021E50 RID: 138832 RVA: 0x000BBA58 File Offset: 0x000B9C58
		[Token(Token = "0x17004F4B")]
		public bool isFullPack
		{
			[Token(Token = "0x6021E50")]
			[Address(RVA = "0x1C68FD0", Offset = "0x1C67BD0", VA = "0x181C68FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x06021E51 RID: 138833 RVA: 0x000BBA70 File Offset: 0x000B9C70
		[Token(Token = "0x17004F4C")]
		public int count
		{
			[Token(Token = "0x6021E51")]
			[Address(RVA = "0x1C68EB0", Offset = "0x1C67AB0", VA = "0x181C68EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06021E52 RID: 138834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F4D")]
		public string actName
		{
			[Token(Token = "0x6021E52")]
			[Address(RVA = "0x1C68DF0", Offset = "0x1C679F0", VA = "0x181C68DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021E53 RID: 138835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E53")]
		[Address(RVA = "0x1C68B80", Offset = "0x1C67780", VA = "0x181C68B80", Slot = "4")]
		public override void LoadData(ShopRecommendItem recommendItem)
		{
		}

		// Token: 0x06021E54 RID: 138836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E54")]
		[Address(RVA = "0x1C68D50", Offset = "0x1C67950", VA = "0x181C68D50")]
		public ShopRecommendTemplateNormalFurnViewModel()
		{
		}

		// Token: 0x0402E711 RID: 190225
		[Token(Token = "0x402E711")]
		[FieldOffset(Offset = "0x18")]
		protected long m_showStartTs;

		// Token: 0x0402E712 RID: 190226
		[Token(Token = "0x402E712")]
		[FieldOffset(Offset = "0x20")]
		protected long m_showEndTs;

		// Token: 0x0402E713 RID: 190227
		[Token(Token = "0x402E713")]
		[FieldOffset(Offset = "0x28")]
		private string m_furnSetName;

		// Token: 0x0402E714 RID: 190228
		[Token(Token = "0x402E714")]
		[FieldOffset(Offset = "0x30")]
		private string m_desc;

		// Token: 0x0402E715 RID: 190229
		[Token(Token = "0x402E715")]
		[FieldOffset(Offset = "0x38")]
		private string m_backColor;

		// Token: 0x0402E716 RID: 190230
		[Token(Token = "0x402E716")]
		[FieldOffset(Offset = "0x40")]
		private string m_textColor;

		// Token: 0x0402E717 RID: 190231
		[Token(Token = "0x402E717")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isNew;

		// Token: 0x0402E718 RID: 190232
		[Token(Token = "0x402E718")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isFullPack;

		// Token: 0x0402E719 RID: 190233
		[Token(Token = "0x402E719")]
		[FieldOffset(Offset = "0x4C")]
		private int m_count;

		// Token: 0x0402E71A RID: 190234
		[Token(Token = "0x402E71A")]
		[FieldOffset(Offset = "0x50")]
		private string m_actName;

		// Token: 0x0402E71B RID: 190235
		[Token(Token = "0x402E71B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showStartTs;

		// Token: 0x0402E71C RID: 190236
		[Token(Token = "0x402E71C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showEndTs;

		// Token: 0x0402E71D RID: 190237
		[Token(Token = "0x402E71D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_furnSetName;

		// Token: 0x0402E71E RID: 190238
		[Token(Token = "0x402E71E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402E71F RID: 190239
		[Token(Token = "0x402E71F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_backColor;

		// Token: 0x0402E720 RID: 190240
		[Token(Token = "0x402E720")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_textColor;

		// Token: 0x0402E721 RID: 190241
		[Token(Token = "0x402E721")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isNew;

		// Token: 0x0402E722 RID: 190242
		[Token(Token = "0x402E722")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isFullPack;

		// Token: 0x0402E723 RID: 190243
		[Token(Token = "0x402E723")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402E724 RID: 190244
		[Token(Token = "0x402E724")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_actName;

		// Token: 0x0402E725 RID: 190245
		[Token(Token = "0x402E725")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E726 RID: 190246
		[Token(Token = "0x402E726")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
