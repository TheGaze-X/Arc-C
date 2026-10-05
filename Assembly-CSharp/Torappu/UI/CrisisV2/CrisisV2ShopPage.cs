using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using Torappu.UI.Crisis;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005914 RID: 22804
	[Token(Token = "0x2005914")]
	public class CrisisV2ShopPage : StateEnginePage
	{
		// Token: 0x060213B1 RID: 136113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213B1")]
		[Address(RVA = "0x1B978E0", Offset = "0x1B964E0", VA = "0x181B978E0")]
		private void _ReturnPage()
		{
		}

		// Token: 0x060213B2 RID: 136114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213B2")]
		[Address(RVA = "0x1B97740", Offset = "0x1B96340", VA = "0x181B97740", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060213B3 RID: 136115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213B3")]
		[Address(RVA = "0x1B97570", Offset = "0x1B96170", VA = "0x181B97570")]
		public static Sprite LoadShopIcon(string seasonId, CrisisShopVer shopVer)
		{
			return null;
		}

		// Token: 0x060213B4 RID: 136116 RVA: 0x000B8FC8 File Offset: 0x000B71C8
		[Token(Token = "0x60213B4")]
		[Address(RVA = "0x1B97610", Offset = "0x1B96210", VA = "0x181B97610")]
		public static SpriteRenderData LoadShopTitle(string seasonId, ILoadAsset loadAsset)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060213B5 RID: 136117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213B5")]
		[Address(RVA = "0x1B974C0", Offset = "0x1B960C0", VA = "0x181B974C0")]
		public static Sprite LoadShopBackPic(string picId, CrisisShopVer shopVer)
		{
			return null;
		}

		// Token: 0x060213B6 RID: 136118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213B6")]
		[Address(RVA = "0x1B97370", Offset = "0x1B95F70", VA = "0x181B97370")]
		public static CrisisStageSeasonResHolder LoadSeasonResHolder(string seasonId)
		{
			return null;
		}

		// Token: 0x060213B7 RID: 136119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213B7")]
		[Address(RVA = "0x1B97980", Offset = "0x1B96580", VA = "0x181B97980")]
		private static Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x060213B8 RID: 136120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213B8")]
		[Address(RVA = "0x1B97AD0", Offset = "0x1B966D0", VA = "0x181B97AD0")]
		public CrisisV2ShopPage()
		{
		}

		// Token: 0x060213BB RID: 136123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213BB")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0402D41B RID: 185371
		[Token(Token = "0x402D41B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0402D41C RID: 185372
		[Token(Token = "0x402D41C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x0402D41D RID: 185373
		[Token(Token = "0x402D41D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402D41E RID: 185374
		[Token(Token = "0x402D41E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadShopIcon;

		// Token: 0x0402D41F RID: 185375
		[Token(Token = "0x402D41F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadShopTitle;

		// Token: 0x0402D420 RID: 185376
		[Token(Token = "0x402D420")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadShopBackPic;

		// Token: 0x0402D421 RID: 185377
		[Token(Token = "0x402D421")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSeasonResHolder;

		// Token: 0x0402D422 RID: 185378
		[Token(Token = "0x402D422")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x0402D423 RID: 185379
		[Token(Token = "0x402D423")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
