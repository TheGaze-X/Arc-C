using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046A8 RID: 18088
	[Token(Token = "0x20046A8")]
	public class RoguelikeActivitySeedListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B70A RID: 112394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70A")]
		[Address(RVA = "0x14D49E0", Offset = "0x14D35E0", VA = "0x1814D49E0")]
		public void Render(RoguelikeActivitySeedItemModel itemModel, bool isPlaying, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601B70B RID: 112395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70B")]
		[Address(RVA = "0x14D4D10", Offset = "0x14D3910", VA = "0x1814D4D10")]
		private void _RenderHistory(RoguelikeActivityHistorySeedItemModel historyModel, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601B70C RID: 112396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70C")]
		[Address(RVA = "0x14D50A0", Offset = "0x14D3CA0", VA = "0x1814D50A0")]
		private void _RenderPredefine(RoguelikeActivityPredefineSeedItemModel predefineModel)
		{
		}

		// Token: 0x0601B70D RID: 112397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70D")]
		[Address(RVA = "0x14D4960", Offset = "0x14D3560", VA = "0x1814D4960")]
		public void OnClickSelectSeed()
		{
		}

		// Token: 0x0601B70E RID: 112398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70E")]
		[Address(RVA = "0x14D48E0", Offset = "0x14D34E0", VA = "0x1814D48E0")]
		public void OnClickCopySeed()
		{
		}

		// Token: 0x0601B70F RID: 112399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B70F")]
		[Address(RVA = "0x14D5150", Offset = "0x14D3D50", VA = "0x1814D5150")]
		public RoguelikeActivitySeedListItem()
		{
		}

		// Token: 0x04023814 RID: 145428
		[Token(Token = "0x4023814")]
		private const string HISTORY_GAME_DESC_FORMAT = "{0} | {1}{2} | {3}";

		// Token: 0x04023815 RID: 145429
		[Token(Token = "0x4023815")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x04023816 RID: 145430
		[Token(Token = "0x4023816")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _seedPanel;

		// Token: 0x04023817 RID: 145431
		[Token(Token = "0x4023817")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _historyIconPanel;

		// Token: 0x04023818 RID: 145432
		[Token(Token = "0x4023818")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _historyEndingIcon;

		// Token: 0x04023819 RID: 145433
		[Token(Token = "0x4023819")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _historyBandIcon;

		// Token: 0x0402381A RID: 145434
		[Token(Token = "0x402381A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _predefineIconPanel;

		// Token: 0x0402381B RID: 145435
		[Token(Token = "0x402381B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _seedTxt;

		// Token: 0x0402381C RID: 145436
		[Token(Token = "0x402381C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _copyBtn;

		// Token: 0x0402381D RID: 145437
		[Token(Token = "0x402381D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _historyEndTime;

		// Token: 0x0402381E RID: 145438
		[Token(Token = "0x402381E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _historyGameDesc;

		// Token: 0x0402381F RID: 145439
		[Token(Token = "0x402381F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _historyDescPanel;

		// Token: 0x04023820 RID: 145440
		[Token(Token = "0x4023820")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _predefineDesc;

		// Token: 0x04023821 RID: 145441
		[Token(Token = "0x4023821")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _predefineDescPanel;

		// Token: 0x04023822 RID: 145442
		[Token(Token = "0x4023822")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _selectSeedBtn;

		// Token: 0x04023823 RID: 145443
		[Token(Token = "0x4023823")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _seedPlaying;

		// Token: 0x04023824 RID: 145444
		[Token(Token = "0x4023824")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _rightDecorateStateToggle;

		// Token: 0x04023825 RID: 145445
		[Token(Token = "0x4023825")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _endIconBk;

		// Token: 0x04023826 RID: 145446
		[Token(Token = "0x4023826")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04023827 RID: 145447
		[Token(Token = "0x4023827")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedSeed;

		// Token: 0x04023828 RID: 145448
		[Token(Token = "0x4023828")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public Action<string> onClickSelectSeed;

		// Token: 0x04023829 RID: 145449
		[Token(Token = "0x4023829")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public Action<string> onClickCopySeed;

		// Token: 0x0402382A RID: 145450
		[Token(Token = "0x402382A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402382B RID: 145451
		[Token(Token = "0x402382B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderHistory;

		// Token: 0x0402382C RID: 145452
		[Token(Token = "0x402382C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderPredefine;

		// Token: 0x0402382D RID: 145453
		[Token(Token = "0x402382D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickSelectSeed;

		// Token: 0x0402382E RID: 145454
		[Token(Token = "0x402382E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickCopySeed;

		// Token: 0x0402382F RID: 145455
		[Token(Token = "0x402382F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
