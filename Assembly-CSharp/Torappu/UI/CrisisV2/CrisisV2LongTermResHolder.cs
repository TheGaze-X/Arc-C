using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A4 RID: 22948
	[Token(Token = "0x20059A4")]
	public class CrisisV2LongTermResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021739 RID: 137017 RVA: 0x000BA510 File Offset: 0x000B8710
		[Token(Token = "0x6021739")]
		[Address(RVA = "0x1BC1710", Offset = "0x1BC0310", VA = "0x181BC1710")]
		public SpriteRenderData GetAchieveMapBkgSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602173A RID: 137018 RVA: 0x000BA528 File Offset: 0x000B8728
		[Token(Token = "0x602173A")]
		[Address(RVA = "0x1BC17B0", Offset = "0x1BC03B0", VA = "0x181BC17B0")]
		public SpriteRenderData GetAchieveTitleImgSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602173B RID: 137019 RVA: 0x000BA540 File Offset: 0x000B8740
		[Token(Token = "0x602173B")]
		[Address(RVA = "0x1BC1850", Offset = "0x1BC0450", VA = "0x181BC1850")]
		public SpriteRenderData GetBattleFinishBgSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602173C RID: 137020 RVA: 0x000BA558 File Offset: 0x000B8758
		[Token(Token = "0x602173C")]
		[Address(RVA = "0x1BC18F0", Offset = "0x1BC04F0", VA = "0x181BC18F0")]
		private SpriteRenderData _SafeGetSprite(string name)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602173D RID: 137021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602173D")]
		[Address(RVA = "0x1BC1A30", Offset = "0x1BC0630", VA = "0x181BC1A30")]
		public CrisisV2LongTermResHolder()
		{
		}

		// Token: 0x0402DA68 RID: 186984
		[Token(Token = "0x402DA68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402DA69 RID: 186985
		[Token(Token = "0x402DA69")]
		private const string ACHIEVE_MAP_BKG = "achieve_map_bkg";

		// Token: 0x0402DA6A RID: 186986
		[Token(Token = "0x402DA6A")]
		private const string ACHIEVE_TITLE_IMG = "achieve_title_img";

		// Token: 0x0402DA6B RID: 186987
		[Token(Token = "0x402DA6B")]
		private const string BATTLE_FINISH_BKG = "battle_finish_bg";

		// Token: 0x0402DA6C RID: 186988
		[Token(Token = "0x402DA6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAchieveMapBkgSprite;

		// Token: 0x0402DA6D RID: 186989
		[Token(Token = "0x402DA6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAchieveTitleImgSprite;

		// Token: 0x0402DA6E RID: 186990
		[Token(Token = "0x402DA6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBattleFinishBgSprite;

		// Token: 0x0402DA6F RID: 186991
		[Token(Token = "0x402DA6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SafeGetSprite;

		// Token: 0x0402DA70 RID: 186992
		[Token(Token = "0x402DA70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
