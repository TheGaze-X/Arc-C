using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E8 RID: 23016
	[Token(Token = "0x20059E8")]
	public class CrisisV2SeasonAtlasResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602189E RID: 137374 RVA: 0x000BAA20 File Offset: 0x000B8C20
		[Token(Token = "0x602189E")]
		[Address(RVA = "0x1BDFDB0", Offset = "0x1BDE9B0", VA = "0x181BDFDB0")]
		public SpriteRenderData GetMapDetailDecorSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602189F RID: 137375 RVA: 0x000BAA38 File Offset: 0x000B8C38
		[Token(Token = "0x602189F")]
		[Address(RVA = "0x1BDFD10", Offset = "0x1BDE910", VA = "0x181BDFD10")]
		public SpriteRenderData GetMainBtnPicSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A0 RID: 137376 RVA: 0x000BAA50 File Offset: 0x000B8C50
		[Token(Token = "0x60218A0")]
		[Address(RVA = "0x1BDFF90", Offset = "0x1BDEB90", VA = "0x181BDFF90")]
		public SpriteRenderData GetTitleImgSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A1 RID: 137377 RVA: 0x000BAA68 File Offset: 0x000B8C68
		[Token(Token = "0x60218A1")]
		[Address(RVA = "0x1BDFE50", Offset = "0x1BDEA50", VA = "0x181BDFE50")]
		public SpriteRenderData GetShopTitleImgSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A2 RID: 137378 RVA: 0x000BAA80 File Offset: 0x000B8C80
		[Token(Token = "0x60218A2")]
		[Address(RVA = "0x1BDF9F0", Offset = "0x1BDE5F0", VA = "0x181BDF9F0")]
		public SpriteRenderData GetEntryBackSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A3 RID: 137379 RVA: 0x000BAA98 File Offset: 0x000B8C98
		[Token(Token = "0x60218A3")]
		[Address(RVA = "0x1BDFC70", Offset = "0x1BDE870", VA = "0x181BDFC70")]
		public SpriteRenderData GetFriendMistIconSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A4 RID: 137380 RVA: 0x000BAAB0 File Offset: 0x000B8CB0
		[Token(Token = "0x60218A4")]
		[Address(RVA = "0x1BDFA90", Offset = "0x1BDE690", VA = "0x181BDFA90")]
		public SpriteRenderData GetEntryBtnSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A5 RID: 137381 RVA: 0x000BAAC8 File Offset: 0x000B8CC8
		[Token(Token = "0x60218A5")]
		[Address(RVA = "0x1BDFB30", Offset = "0x1BDE730", VA = "0x181BDFB30")]
		public SpriteRenderData GetEntryMedalSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A6 RID: 137382 RVA: 0x000BAAE0 File Offset: 0x000B8CE0
		[Token(Token = "0x60218A6")]
		[Address(RVA = "0x1BDFBD0", Offset = "0x1BDE7D0", VA = "0x181BDFBD0")]
		public SpriteRenderData GetEntryTitleSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x000BAAF8 File Offset: 0x000B8CF8
		[Token(Token = "0x60218A7")]
		[Address(RVA = "0x1BDFEF0", Offset = "0x1BDEAF0", VA = "0x181BDFEF0")]
		public SpriteRenderData GetStageEntryIconSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x000BAB10 File Offset: 0x000B8D10
		[Token(Token = "0x60218A8")]
		[Address(RVA = "0x1BE0030", Offset = "0x1BDEC30", VA = "0x181BE0030")]
		private SpriteRenderData _SafeGetSprite(string name)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060218A9 RID: 137385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218A9")]
		[Address(RVA = "0x1BE0170", Offset = "0x1BDED70", VA = "0x181BE0170")]
		public CrisisV2SeasonAtlasResHolder()
		{
		}

		// Token: 0x0402DD57 RID: 187735
		[Token(Token = "0x402DD57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _seasonAtlasObject;

		// Token: 0x0402DD58 RID: 187736
		[Token(Token = "0x402DD58")]
		private const string MAP_DETAIL_DECOR = "map_detail_decor";

		// Token: 0x0402DD59 RID: 187737
		[Token(Token = "0x402DD59")]
		private const string MAIN_BTN_PIC = "main_entry_pic";

		// Token: 0x0402DD5A RID: 187738
		[Token(Token = "0x402DD5A")]
		private const string TITLE_IMG = "title_img";

		// Token: 0x0402DD5B RID: 187739
		[Token(Token = "0x402DD5B")]
		private const string SHOP_TITLE_IMG = "shop_title_img";

		// Token: 0x0402DD5C RID: 187740
		[Token(Token = "0x402DD5C")]
		private const string ENTRY_BACK = "entry_back";

		// Token: 0x0402DD5D RID: 187741
		[Token(Token = "0x402DD5D")]
		private const string FRIEND_MISC_ICON = "friend_misc_icon";

		// Token: 0x0402DD5E RID: 187742
		[Token(Token = "0x402DD5E")]
		private const string ENTRY_BACK_TITLE = "entry_title";

		// Token: 0x0402DD5F RID: 187743
		[Token(Token = "0x402DD5F")]
		private const string ENTRY_MEDAL = "entry_medal";

		// Token: 0x0402DD60 RID: 187744
		[Token(Token = "0x402DD60")]
		private const string ENTRY_BTN = "entry_btn";

		// Token: 0x0402DD61 RID: 187745
		[Token(Token = "0x402DD61")]
		private const string STAGE_ENTRY_ICON = "stage_entry_icon";

		// Token: 0x0402DD62 RID: 187746
		[Token(Token = "0x402DD62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMapDetailDecorSprite;

		// Token: 0x0402DD63 RID: 187747
		[Token(Token = "0x402DD63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMainBtnPicSprite;

		// Token: 0x0402DD64 RID: 187748
		[Token(Token = "0x402DD64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTitleImgSprite;

		// Token: 0x0402DD65 RID: 187749
		[Token(Token = "0x402DD65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetShopTitleImgSprite;

		// Token: 0x0402DD66 RID: 187750
		[Token(Token = "0x402DD66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEntryBackSprite;

		// Token: 0x0402DD67 RID: 187751
		[Token(Token = "0x402DD67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFriendMistIconSprite;

		// Token: 0x0402DD68 RID: 187752
		[Token(Token = "0x402DD68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEntryBtnSprite;

		// Token: 0x0402DD69 RID: 187753
		[Token(Token = "0x402DD69")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEntryMedalSprite;

		// Token: 0x0402DD6A RID: 187754
		[Token(Token = "0x402DD6A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEntryTitleSprite;

		// Token: 0x0402DD6B RID: 187755
		[Token(Token = "0x402DD6B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetStageEntryIconSprite;

		// Token: 0x0402DD6C RID: 187756
		[Token(Token = "0x402DD6C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SafeGetSprite;

		// Token: 0x0402DD6D RID: 187757
		[Token(Token = "0x402DD6D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
