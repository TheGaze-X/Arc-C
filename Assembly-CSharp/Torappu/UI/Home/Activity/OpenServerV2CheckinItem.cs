using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C87 RID: 19591
	[Token(Token = "0x2004C87")]
	public class OpenServerV2CheckinItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D5ED RID: 120301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5ED")]
		[Address(RVA = "0x16EE6C0", Offset = "0x16ED2C0", VA = "0x1816EE6C0")]
		public void Render(OpenServerV2CheckinItem.RenderParam renderParam)
		{
		}

		// Token: 0x0601D5EE RID: 120302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5EE")]
		[Address(RVA = "0x16EE460", Offset = "0x16ED060", VA = "0x1816EE460")]
		public void OnClick()
		{
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5EF")]
		[Address(RVA = "0x16EE5F0", Offset = "0x16ED1F0", VA = "0x1816EE5F0")]
		public void OnItemDescShowClick()
		{
		}

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F0")]
		[Address(RVA = "0x16EF0B0", Offset = "0x16EDCB0", VA = "0x1816EF0B0")]
		private void _OnItemClick()
		{
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F1")]
		[Address(RVA = "0x16EF130", Offset = "0x16EDD30", VA = "0x1816EF130")]
		public OpenServerV2CheckinItem()
		{
		}

		// Token: 0x04026A7A RID: 158330
		[Token(Token = "0x4026A7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtIndex;

		// Token: 0x04026A7B RID: 158331
		[Token(Token = "0x4026A7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04026A7C RID: 158332
		[Token(Token = "0x4026A7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _imgIcons;

		// Token: 0x04026A7D RID: 158333
		[Token(Token = "0x4026A7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _txtCounts;

		// Token: 0x04026A7E RID: 158334
		[Token(Token = "0x4026A7E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _neverGet;

		// Token: 0x04026A7F RID: 158335
		[Token(Token = "0x4026A7F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _transformCheckinValid;

		// Token: 0x04026A80 RID: 158336
		[Token(Token = "0x4026A80")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _alreadyGet;

		// Token: 0x04026A81 RID: 158337
		[Token(Token = "0x4026A81")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _alreadyGet2;

		// Token: 0x04026A82 RID: 158338
		[Token(Token = "0x4026A82")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _upPart;

		// Token: 0x04026A83 RID: 158339
		[Token(Token = "0x4026A83")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _downPart;

		// Token: 0x04026A84 RID: 158340
		[Token(Token = "0x4026A84")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Sprite> _upSpritePart;

		// Token: 0x04026A85 RID: 158341
		[Token(Token = "0x4026A85")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Sprite> _downSpritePart;

		// Token: 0x04026A86 RID: 158342
		[Token(Token = "0x4026A86")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _canGet;

		// Token: 0x04026A87 RID: 158343
		[Token(Token = "0x4026A87")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _canGetHotspot;

		// Token: 0x04026A88 RID: 158344
		[Token(Token = "0x4026A88")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objItem;

		// Token: 0x04026A89 RID: 158345
		[Token(Token = "0x4026A89")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _itemDescHotspot;

		// Token: 0x04026A8A RID: 158346
		[Token(Token = "0x4026A8A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04026A8B RID: 158347
		[Token(Token = "0x4026A8B")]
		[FieldOffset(Offset = "0xA8")]
		private int m_index;

		// Token: 0x04026A8C RID: 158348
		[Token(Token = "0x4026A8C")]
		[FieldOffset(Offset = "0xB0")]
		private Action<int> m_clickAction;

		// Token: 0x04026A8D RID: 158349
		[Token(Token = "0x4026A8D")]
		[FieldOffset(Offset = "0xB8")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x04026A8E RID: 158350
		[Token(Token = "0x4026A8E")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_tween;

		// Token: 0x04026A8F RID: 158351
		[Token(Token = "0x4026A8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026A90 RID: 158352
		[Token(Token = "0x4026A90")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026A91 RID: 158353
		[Token(Token = "0x4026A91")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemDescShowClick;

		// Token: 0x04026A92 RID: 158354
		[Token(Token = "0x4026A92")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04026A93 RID: 158355
		[Token(Token = "0x4026A93")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C88 RID: 19592
		[Token(Token = "0x2004C88")]
		public struct RenderParam
		{
			// Token: 0x04026A94 RID: 158356
			[Token(Token = "0x4026A94")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04026A95 RID: 158357
			[Token(Token = "0x4026A95")]
			[FieldOffset(Offset = "0x8")]
			public ICheckinItemData data;

			// Token: 0x04026A96 RID: 158358
			[Token(Token = "0x4026A96")]
			[FieldOffset(Offset = "0x10")]
			public Action<int> clickAction;
		}
	}
}
