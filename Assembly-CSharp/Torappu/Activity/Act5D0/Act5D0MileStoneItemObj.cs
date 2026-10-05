using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F1 RID: 29169
	[Token(Token = "0x20071F1")]
	public class Act5D0MileStoneItemObj : MileStoneItem
	{
		// Token: 0x06029604 RID: 169476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029604")]
		[Address(RVA = "0x24C1140", Offset = "0x24BFD40", VA = "0x1824C1140", Slot = "4")]
		public override void InitData(MileStoneViewModel viewModel)
		{
		}

		// Token: 0x06029605 RID: 169477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029605")]
		[Address(RVA = "0x24C1600", Offset = "0x24C0200", VA = "0x1824C1600", Slot = "5")]
		protected override void OnRenderDataPart(MileStoneViewModel viewModel)
		{
		}

		// Token: 0x06029606 RID: 169478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029606")]
		[Address(RVA = "0x24C18B0", Offset = "0x24C04B0", VA = "0x1824C18B0", Slot = "6")]
		protected override void OnRenderItemStyle(MileStoneViewModel.PartType part, MileStoneViewModel.State state)
		{
		}

		// Token: 0x06029607 RID: 169479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029607")]
		[Address(RVA = "0x24C1ED0", Offset = "0x24C0AD0", VA = "0x1824C1ED0")]
		public Act5D0MileStoneItemObj()
		{
		}

		// Token: 0x06029608 RID: 169480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029608")]
		[Address(RVA = "0x24C1EA0", Offset = "0x24C0AA0", VA = "0x1824C1EA0")]
		private void <>xLuaBaseProxy_InitData(MileStoneViewModel P0)
		{
		}

		// Token: 0x06029609 RID: 169481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029609")]
		[Address(RVA = "0x24C1EB0", Offset = "0x24C0AB0", VA = "0x1824C1EB0")]
		private void <>xLuaBaseProxy_OnRenderDataPart(MileStoneViewModel P0)
		{
		}

		// Token: 0x0602960A RID: 169482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602960A")]
		[Address(RVA = "0x24C1EC0", Offset = "0x24C0AC0", VA = "0x1824C1EC0")]
		private void <>xLuaBaseProxy_OnRenderItemStyle(MileStoneViewModel.PartType P0, MileStoneViewModel.State P1)
		{
		}

		// Token: 0x0403B17A RID: 242042
		[Token(Token = "0x403B17A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _bgEff;

		// Token: 0x0403B17B RID: 242043
		[Token(Token = "0x403B17B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403B17C RID: 242044
		[Token(Token = "0x403B17C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _ableToGetButton;

		// Token: 0x0403B17D RID: 242045
		[Token(Token = "0x403B17D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _indexText;

		// Token: 0x0403B17E RID: 242046
		[Token(Token = "0x403B17E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403B17F RID: 242047
		[Token(Token = "0x403B17F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403B180 RID: 242048
		[Token(Token = "0x403B180")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _countSymbol;

		// Token: 0x0403B181 RID: 242049
		[Token(Token = "0x403B181")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403B182 RID: 242050
		[Token(Token = "0x403B182")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x0403B183 RID: 242051
		[Token(Token = "0x403B183")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _contentRoot;

		// Token: 0x0403B184 RID: 242052
		[Token(Token = "0x403B184")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _gapRoot;

		// Token: 0x0403B185 RID: 242053
		[Token(Token = "0x403B185")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _group;

		// Token: 0x0403B186 RID: 242054
		[Token(Token = "0x403B186")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _completeMark;

		// Token: 0x0403B187 RID: 242055
		[Token(Token = "0x403B187")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403B188 RID: 242056
		[Token(Token = "0x403B188")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403B189 RID: 242057
		[Token(Token = "0x403B189")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _replicateFlag;

		// Token: 0x0403B18A RID: 242058
		[Token(Token = "0x403B18A")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_cacheTween;

		// Token: 0x0403B18B RID: 242059
		[Token(Token = "0x403B18B")]
		private const float ANIMATION_ALPHA_SPEED = 8f;

		// Token: 0x0403B18C RID: 242060
		[Token(Token = "0x403B18C")]
		private const float ANIMATION_ANIM_SPEED = 6f;

		// Token: 0x0403B18D RID: 242061
		[Token(Token = "0x403B18D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B18E RID: 242062
		[Token(Token = "0x403B18E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDataPart;

		// Token: 0x0403B18F RID: 242063
		[Token(Token = "0x403B18F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderItemStyle;

		// Token: 0x0403B190 RID: 242064
		[Token(Token = "0x403B190")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
