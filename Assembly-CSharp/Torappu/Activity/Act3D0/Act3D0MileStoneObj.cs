using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200740A RID: 29706
	[Token(Token = "0x200740A")]
	public class Act3D0MileStoneObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F36 RID: 171830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F36")]
		[Address(RVA = "0x258F470", Offset = "0x258E070", VA = "0x18258F470")]
		private void _Inited()
		{
		}

		// Token: 0x06029F37 RID: 171831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F37")]
		[Address(RVA = "0x258EAA0", Offset = "0x258D6A0", VA = "0x18258EAA0")]
		public void RenderAgain(Act3D0MileStoneViewModel viewModel)
		{
		}

		// Token: 0x06029F38 RID: 171832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F38")]
		[Address(RVA = "0x258EA10", Offset = "0x258D610", VA = "0x18258EA10")]
		public void OnClick()
		{
		}

		// Token: 0x06029F39 RID: 171833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F39")]
		[Address(RVA = "0x258F680", Offset = "0x258E280", VA = "0x18258F680")]
		public Act3D0MileStoneObj()
		{
		}

		// Token: 0x0403C203 RID: 246275
		[Token(Token = "0x403C203")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _finishImg;

		// Token: 0x0403C204 RID: 246276
		[Token(Token = "0x403C204")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _ableToGetImg;

		// Token: 0x0403C205 RID: 246277
		[Token(Token = "0x403C205")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ableToGetPart;

		// Token: 0x0403C206 RID: 246278
		[Token(Token = "0x403C206")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x0403C207 RID: 246279
		[Token(Token = "0x403C207")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cannotGetPart;

		// Token: 0x0403C208 RID: 246280
		[Token(Token = "0x403C208")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x0403C209 RID: 246281
		[Token(Token = "0x403C209")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0403C20A RID: 246282
		[Token(Token = "0x403C20A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403C20B RID: 246283
		[Token(Token = "0x403C20B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403C20C RID: 246284
		[Token(Token = "0x403C20C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _countText_2;

		// Token: 0x0403C20D RID: 246285
		[Token(Token = "0x403C20D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _countTextActive;

		// Token: 0x0403C20E RID: 246286
		[Token(Token = "0x403C20E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _countTextNoActive;

		// Token: 0x0403C20F RID: 246287
		[Token(Token = "0x403C20F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403C210 RID: 246288
		[Token(Token = "0x403C210")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _countSymbol;

		// Token: 0x0403C211 RID: 246289
		[Token(Token = "0x403C211")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _backShiningImg;

		// Token: 0x0403C212 RID: 246290
		[Token(Token = "0x403C212")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _maskB;

		// Token: 0x0403C213 RID: 246291
		[Token(Token = "0x403C213")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _maskW;

		// Token: 0x0403C214 RID: 246292
		[Token(Token = "0x403C214")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403C215 RID: 246293
		[Token(Token = "0x403C215")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _replicateFlag1;

		// Token: 0x0403C216 RID: 246294
		[Token(Token = "0x403C216")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _replicateFlag2;

		// Token: 0x0403C217 RID: 246295
		[Token(Token = "0x403C217")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403C218 RID: 246296
		[Token(Token = "0x403C218")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0403C219 RID: 246297
		[Token(Token = "0x403C219")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemCard m_itemCard;

		// Token: 0x0403C21A RID: 246298
		[Token(Token = "0x403C21A")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cacheId;

		// Token: 0x0403C21B RID: 246299
		[Token(Token = "0x403C21B")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_cacheTween;

		// Token: 0x0403C21C RID: 246300
		[Token(Token = "0x403C21C")]
		private const float ANIMATION_ALPHA_SPEED = 8f;

		// Token: 0x0403C21D RID: 246301
		[Token(Token = "0x403C21D")]
		private const float ANIMATION_ANIM_SPEED = 6f;

		// Token: 0x0403C21E RID: 246302
		[Token(Token = "0x403C21E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Inited;

		// Token: 0x0403C21F RID: 246303
		[Token(Token = "0x403C21F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderAgain;

		// Token: 0x0403C220 RID: 246304
		[Token(Token = "0x403C220")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C221 RID: 246305
		[Token(Token = "0x403C221")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
