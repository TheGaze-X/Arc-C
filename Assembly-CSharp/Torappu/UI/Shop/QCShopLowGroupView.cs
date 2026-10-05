using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B11 RID: 23313
	[Token(Token = "0x2005B11")]
	public class QCShopLowGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DD8 RID: 138712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DD8")]
		[Address(RVA = "0x1C5B7A0", Offset = "0x1C5A3A0", VA = "0x181C5B7A0")]
		public void InitGroupData(QCShopLowGroupViewModel shopGroupViewModel)
		{
		}

		// Token: 0x06021DD9 RID: 138713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DD9")]
		[Address(RVA = "0x1C5BDA0", Offset = "0x1C5A9A0", VA = "0x181C5BDA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021DDA RID: 138714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DDA")]
		[Address(RVA = "0x1C5B9E0", Offset = "0x1C5A5E0", VA = "0x181C5B9E0")]
		public void OnEnter()
		{
		}

		// Token: 0x06021DDB RID: 138715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DDB")]
		[Address(RVA = "0x1C5BAC0", Offset = "0x1C5A6C0", VA = "0x181C5BAC0")]
		public void OnExit()
		{
		}

		// Token: 0x06021DDC RID: 138716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DDC")]
		[Address(RVA = "0x1C5BB40", Offset = "0x1C5A740", VA = "0x181C5BB40")]
		public void OnLockedGroupClicked()
		{
		}

		// Token: 0x06021DDD RID: 138717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DDD")]
		[Address(RVA = "0x1C5BBE0", Offset = "0x1C5A7E0", VA = "0x181C5BBE0")]
		public void UpdateUnlockProgress()
		{
		}

		// Token: 0x06021DDE RID: 138718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DDE")]
		[Address(RVA = "0x1C5BEC0", Offset = "0x1C5AAC0", VA = "0x181C5BEC0")]
		public QCShopLowGroupView()
		{
		}

		// Token: 0x0402E64D RID: 190029
		[Token(Token = "0x402E64D")]
		private const float SHOW_ALPHA = 1f;

		// Token: 0x0402E64E RID: 190030
		[Token(Token = "0x402E64E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0402E64F RID: 190031
		[Token(Token = "0x402E64F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private QCNormalGoodItem _item;

		// Token: 0x0402E650 RID: 190032
		[Token(Token = "0x402E650")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _lockedCanvas;

		// Token: 0x0402E651 RID: 190033
		[Token(Token = "0x402E651")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _legacyLock;

		// Token: 0x0402E652 RID: 190034
		[Token(Token = "0x402E652")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _unlockBarObj;

		// Token: 0x0402E653 RID: 190035
		[Token(Token = "0x402E653")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _unlockProgressBar;

		// Token: 0x0402E654 RID: 190036
		[Token(Token = "0x402E654")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _unlockProgressText;

		// Token: 0x0402E655 RID: 190037
		[Token(Token = "0x402E655")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaLocked;

		// Token: 0x0402E656 RID: 190038
		[Token(Token = "0x402E656")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _container;

		// Token: 0x0402E657 RID: 190039
		[Token(Token = "0x402E657")]
		[FieldOffset(Offset = "0x60")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E658 RID: 190040
		[Token(Token = "0x402E658")]
		[FieldOffset(Offset = "0x68")]
		private QCShopLowGroupViewModel m_shopGroupViewModel;

		// Token: 0x0402E659 RID: 190041
		[Token(Token = "0x402E659")]
		[FieldOffset(Offset = "0x70")]
		private QCShopLowGroupView.Adapter m_adapter;

		// Token: 0x0402E65A RID: 190042
		[Token(Token = "0x402E65A")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402E65B RID: 190043
		[Token(Token = "0x402E65B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitGroupData;

		// Token: 0x0402E65C RID: 190044
		[Token(Token = "0x402E65C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E65D RID: 190045
		[Token(Token = "0x402E65D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E65E RID: 190046
		[Token(Token = "0x402E65E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402E65F RID: 190047
		[Token(Token = "0x402E65F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLockedGroupClicked;

		// Token: 0x0402E660 RID: 190048
		[Token(Token = "0x402E660")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateUnlockProgress;

		// Token: 0x0402E661 RID: 190049
		[Token(Token = "0x402E661")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B12 RID: 23314
		[Token(Token = "0x2005B12")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06021DDF RID: 138719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021DDF")]
			[Address(RVA = "0x1C582B0", Offset = "0x1C56EB0", VA = "0x181C582B0")]
			public Adapter(QCShopLowGroupView closure)
			{
			}

			// Token: 0x17004F3C RID: 20284
			// (get) Token: 0x06021DE0 RID: 138720 RVA: 0x000BB770 File Offset: 0x000B9970
			[Token(Token = "0x17004F3C")]
			public override int count
			{
				[Token(Token = "0x6021DE0")]
				[Address(RVA = "0x1C58390", Offset = "0x1C56F90", VA = "0x181C58390", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021DE1 RID: 138721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021DE1")]
			[Address(RVA = "0x1C580B0", Offset = "0x1C56CB0", VA = "0x181C580B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E662 RID: 190050
			[Token(Token = "0x402E662")]
			[FieldOffset(Offset = "0x20")]
			private QCShopLowGroupView m_closure;

			// Token: 0x0402E663 RID: 190051
			[Token(Token = "0x402E663")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E664 RID: 190052
			[Token(Token = "0x402E664")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E665 RID: 190053
			[Token(Token = "0x402E665")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
