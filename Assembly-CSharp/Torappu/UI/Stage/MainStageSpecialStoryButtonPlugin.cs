using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200690B RID: 26891
	[Token(Token = "0x200690B")]
	public class MainStageSpecialStoryButtonPlugin : StageButtonHolderPlugin
	{
		// Token: 0x06026844 RID: 157764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026844")]
		[Address(RVA = "0x2193EB0", Offset = "0x2192AB0", VA = "0x182193EB0")]
		public void OnSpecialRewardClick()
		{
		}

		// Token: 0x06026845 RID: 157765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026845")]
		[Address(RVA = "0x2193660", Offset = "0x2192260", VA = "0x182193660", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06026846 RID: 157766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026846")]
		[Address(RVA = "0x2193730", Offset = "0x2192330", VA = "0x182193730", Slot = "5")]
		protected override void OnRenderStage(StageViewModel viewModel)
		{
		}

		// Token: 0x06026847 RID: 157767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026847")]
		[Address(RVA = "0x2193F70", Offset = "0x2192B70", VA = "0x182193F70")]
		public MainStageSpecialStoryButtonPlugin()
		{
		}

		// Token: 0x040364C4 RID: 222404
		[Token(Token = "0x40364C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _decoSquares;

		// Token: 0x040364C5 RID: 222405
		[Token(Token = "0x40364C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _spstReward;

		// Token: 0x040364C6 RID: 222406
		[Token(Token = "0x40364C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x040364C7 RID: 222407
		[Token(Token = "0x40364C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x040364C8 RID: 222408
		[Token(Token = "0x40364C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _spstObj;

		// Token: 0x040364C9 RID: 222409
		[Token(Token = "0x40364C9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _spstAniamtionGroup;

		// Token: 0x040364CA RID: 222410
		[Token(Token = "0x40364CA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x040364CB RID: 222411
		[Token(Token = "0x40364CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _unlockedColor;

		// Token: 0x040364CC RID: 222412
		[Token(Token = "0x40364CC")]
		private const float ANIMATION_ORIGIN_ALPHA = 0f;

		// Token: 0x040364CD RID: 222413
		[Token(Token = "0x40364CD")]
		private const float ANIMATION_TARGET_ALPHA = 1f;

		// Token: 0x040364CE RID: 222414
		[Token(Token = "0x40364CE")]
		private const float ANIMATION_DURATION = 10f;

		// Token: 0x040364CF RID: 222415
		[Token(Token = "0x40364CF")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x040364D0 RID: 222416
		[Token(Token = "0x40364D0")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_itemModel;

		// Token: 0x040364D1 RID: 222417
		[Token(Token = "0x40364D1")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_lineTween;

		// Token: 0x040364D2 RID: 222418
		[Token(Token = "0x40364D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSpecialRewardClick;

		// Token: 0x040364D3 RID: 222419
		[Token(Token = "0x40364D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040364D4 RID: 222420
		[Token(Token = "0x40364D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x040364D5 RID: 222421
		[Token(Token = "0x40364D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
