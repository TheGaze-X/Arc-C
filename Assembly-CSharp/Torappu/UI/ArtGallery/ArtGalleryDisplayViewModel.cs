using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006639 RID: 26169
	[Token(Token = "0x2006639")]
	public class ArtGalleryDisplayViewModel : IHotfixable
	{
		// Token: 0x06025979 RID: 153977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025979")]
		[Address(RVA = "0x208C470", Offset = "0x208B070", VA = "0x18208C470")]
		public void LoadData()
		{
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602597A")]
		[Address(RVA = "0x208C530", Offset = "0x208B130", VA = "0x18208C530")]
		public void SetCurrSelectedFilter(ArtGalleryFilterType filterType)
		{
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602597B")]
		[Address(RVA = "0x208C640", Offset = "0x208B240", VA = "0x18208C640")]
		public void SetCurrSelectedTab(ArtGalleryTabType tabType)
		{
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602597C")]
		[Address(RVA = "0x208C7F0", Offset = "0x208B3F0", VA = "0x18208C7F0")]
		public void SetSelectItem(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam newSelectParam)
		{
		}

		// Token: 0x0602597D RID: 153981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602597D")]
		[Address(RVA = "0x208C750", Offset = "0x208B350", VA = "0x18208C750")]
		public void SetFocusData(ArtGalleryDisplayViewModel.ArtGalleryFocusParam newFocusParam)
		{
		}

		// Token: 0x0602597E RID: 153982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602597E")]
		[Address(RVA = "0x208C870", Offset = "0x208B470", VA = "0x18208C870")]
		public ArtGalleryDisplayViewModel()
		{
		}

		// Token: 0x04034D08 RID: 216328
		[Token(Token = "0x4034D08")]
		[FieldOffset(Offset = "0x10")]
		public ArtGalleryTabType currTab;

		// Token: 0x04034D09 RID: 216329
		[Token(Token = "0x4034D09")]
		[FieldOffset(Offset = "0x14")]
		public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule currFilterRule;

		// Token: 0x04034D0A RID: 216330
		[Token(Token = "0x4034D0A")]
		[FieldOffset(Offset = "0x18")]
		public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam;

		// Token: 0x04034D0B RID: 216331
		[Token(Token = "0x4034D0B")]
		[FieldOffset(Offset = "0x28")]
		public EnumIntStructDictionary<ArtGalleryTabType, ArtGalleryDisplayViewModel.ArtGalleryFocusParam> itemFocusParamDict;

		// Token: 0x04034D0C RID: 216332
		[Token(Token = "0x4034D0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D0D RID: 216333
		[Token(Token = "0x4034D0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCurrSelectedFilter;

		// Token: 0x04034D0E RID: 216334
		[Token(Token = "0x4034D0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCurrSelectedTab;

		// Token: 0x04034D0F RID: 216335
		[Token(Token = "0x4034D0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectItem;

		// Token: 0x04034D10 RID: 216336
		[Token(Token = "0x4034D10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFocusData;

		// Token: 0x04034D11 RID: 216337
		[Token(Token = "0x4034D11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200663A RID: 26170
		[Token(Token = "0x200663A")]
		public struct ArtGalleryItemSelectParam
		{
			// Token: 0x170058F2 RID: 22770
			// (get) Token: 0x0602597F RID: 153983 RVA: 0x000C86D0 File Offset: 0x000C68D0
			[Token(Token = "0x170058F2")]
			public bool isEmpty
			{
				[Token(Token = "0x602597F")]
				[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04034D12 RID: 216338
			[Token(Token = "0x4034D12")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam EMTPY;

			// Token: 0x04034D13 RID: 216339
			[Token(Token = "0x4034D13")]
			[FieldOffset(Offset = "0x0")]
			public string selectItemId;

			// Token: 0x04034D14 RID: 216340
			[Token(Token = "0x4034D14")]
			[FieldOffset(Offset = "0x8")]
			public ItemType selectItemType;
		}

		// Token: 0x0200663B RID: 26171
		[Token(Token = "0x200663B")]
		public struct ArtGalleryFocusParam
		{
			// Token: 0x04034D15 RID: 216341
			[Token(Token = "0x4034D15")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ArtGalleryDisplayViewModel.ArtGalleryFocusParam DO_NOTHING;

			// Token: 0x04034D16 RID: 216342
			[Token(Token = "0x4034D16")]
			[FieldOffset(Offset = "0x8")]
			public static readonly ArtGalleryDisplayViewModel.ArtGalleryFocusParam SCROLL_TOP;

			// Token: 0x04034D17 RID: 216343
			[Token(Token = "0x4034D17")]
			[FieldOffset(Offset = "0x0")]
			public bool needFocus;

			// Token: 0x04034D18 RID: 216344
			[Token(Token = "0x4034D18")]
			[FieldOffset(Offset = "0x4")]
			public float oneMinusNormalizedPos;
		}

		// Token: 0x0200663C RID: 26172
		[Token(Token = "0x200663C")]
		public struct ArtGalleryShuffleRule
		{
			// Token: 0x04034D19 RID: 216345
			[Token(Token = "0x4034D19")]
			[FieldOffset(Offset = "0x0")]
			public ArtGalleryFilterType currFilter;
		}
	}
}
