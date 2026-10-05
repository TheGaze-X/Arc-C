using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005615 RID: 22037
	[Token(Token = "0x2005615")]
	public class RL05GoodsObjCopperIconView : RoguelikeGoodsObjIconView
	{
		// Token: 0x0602054A RID: 132426 RVA: 0x000B56F8 File Offset: 0x000B38F8
		[Token(Token = "0x602054A")]
		[Address(RVA = "0x1A7D0E0", Offset = "0x1A7BCE0", VA = "0x181A7D0E0", Slot = "5")]
		public override bool NeedShowPlugin(RoguelikeGoodsViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0602054B RID: 132427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602054B")]
		[Address(RVA = "0x1A7D160", Offset = "0x1A7BD60", VA = "0x181A7D160", Slot = "6")]
		public override void Render(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0602054C RID: 132428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602054C")]
		[Address(RVA = "0x1A7D580", Offset = "0x1A7C180", VA = "0x181A7D580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602054D RID: 132429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602054D")]
		[Address(RVA = "0x1A7D620", Offset = "0x1A7C220", VA = "0x181A7D620")]
		private void _RenderCopperItem(RoguelikeGameCopperItemViewModel copperModel)
		{
		}

		// Token: 0x0602054E RID: 132430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602054E")]
		[Address(RVA = "0x1A7D800", Offset = "0x1A7C400", VA = "0x181A7D800")]
		private void _RenderLuckyLevel(RoguelikeGameCopperItemViewModel copperModel)
		{
		}

		// Token: 0x0602054F RID: 132431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602054F")]
		[Address(RVA = "0x1A7D920", Offset = "0x1A7C520", VA = "0x181A7D920")]
		public RL05GoodsObjCopperIconView()
		{
		}

		// Token: 0x0402BC25 RID: 179237
		[Token(Token = "0x402BC25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05CopperItemView _itemCardPrefab;

		// Token: 0x0402BC26 RID: 179238
		[Token(Token = "0x402BC26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0402BC27 RID: 179239
		[Token(Token = "0x402BC27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402BC28 RID: 179240
		[Token(Token = "0x402BC28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _luckyLevelImage;

		// Token: 0x0402BC29 RID: 179241
		[Token(Token = "0x402BC29")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x0402BC2A RID: 179242
		[Token(Token = "0x402BC2A")]
		[FieldOffset(Offset = "0x48")]
		private ILoadAsset m_loadAsset;

		// Token: 0x0402BC2B RID: 179243
		[Token(Token = "0x402BC2B")]
		[FieldOffset(Offset = "0x50")]
		private RL05CopperItemView m_itemCardInstance;

		// Token: 0x0402BC2C RID: 179244
		[Token(Token = "0x402BC2C")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedTopicId;

		// Token: 0x0402BC2D RID: 179245
		[Token(Token = "0x402BC2D")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeCopperResHolder m_resHolder;

		// Token: 0x0402BC2E RID: 179246
		[Token(Token = "0x402BC2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedShowPlugin;

		// Token: 0x0402BC2F RID: 179247
		[Token(Token = "0x402BC2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BC30 RID: 179248
		[Token(Token = "0x402BC30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BC31 RID: 179249
		[Token(Token = "0x402BC31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCopperItem;

		// Token: 0x0402BC32 RID: 179250
		[Token(Token = "0x402BC32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderLuckyLevel;

		// Token: 0x0402BC33 RID: 179251
		[Token(Token = "0x402BC33")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
