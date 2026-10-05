using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C2B RID: 19499
	[Token(Token = "0x2004C2B")]
	public class HomeMailGainItemView : MonoBehaviour
	{
		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x0601D484 RID: 119940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044D6")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x601D484")]
			[Address(RVA = "0x16D2B20", Offset = "0x16D1720", VA = "0x1816D2B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D485 RID: 119941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D485")]
		[Address(RVA = "0x16D2900", Offset = "0x16D1500", VA = "0x1816D2900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D486 RID: 119942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D486")]
		[Address(RVA = "0x16D2220", Offset = "0x16D0E20", VA = "0x1816D2220")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601D487 RID: 119943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D487")]
		[Address(RVA = "0x16D2220", Offset = "0x16D0E20", VA = "0x1816D2220")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0601D488 RID: 119944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D488")]
		[Address(RVA = "0x16D2560", Offset = "0x16D1160", VA = "0x1816D2560")]
		public void Show()
		{
		}

		// Token: 0x0601D489 RID: 119945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D489")]
		[Address(RVA = "0x16D2230", Offset = "0x16D0E30", VA = "0x1816D2230")]
		public void Hide()
		{
		}

		// Token: 0x0601D48A RID: 119946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48A")]
		[Address(RVA = "0x16D2410", Offset = "0x16D1010", VA = "0x1816D2410")]
		public void Render(List<UIItemViewModel> itemModels)
		{
		}

		// Token: 0x0601D48B RID: 119947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48B")]
		[Address(RVA = "0x16D2370", Offset = "0x16D0F70", VA = "0x1816D2370")]
		private void OnEnable()
		{
		}

		// Token: 0x0601D48C RID: 119948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48C")]
		[Address(RVA = "0x16D2360", Offset = "0x16D0F60", VA = "0x1816D2360")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D48D RID: 119949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48D")]
		[Address(RVA = "0x16D2A70", Offset = "0x16D1670", VA = "0x1816D2A70")]
		private void _UpdateAutoLayouts()
		{
		}

		// Token: 0x0601D48E RID: 119950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48E")]
		[Address(RVA = "0x16D28B0", Offset = "0x16D14B0", VA = "0x1816D28B0")]
		private void _ClearTween()
		{
		}

		// Token: 0x0601D48F RID: 119951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D48F")]
		[Address(RVA = "0x16D27E0", Offset = "0x16D13E0", VA = "0x1816D27E0")]
		private void _ClearSprites()
		{
		}

		// Token: 0x0601D490 RID: 119952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D490")]
		[Address(RVA = "0x16D29F0", Offset = "0x16D15F0", VA = "0x1816D29F0")]
		private IEnumerator _ReupdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0601D491 RID: 119953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D491")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public HomeMailGainItemView()
		{
		}

		// Token: 0x04026849 RID: 157769
		[Token(Token = "0x4026849")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x0402684A RID: 157770
		[Token(Token = "0x402684A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemGridLayout;

		// Token: 0x0402684B RID: 157771
		[Token(Token = "0x402684B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x0402684C RID: 157772
		[Token(Token = "0x402684C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _blurBkg;

		// Token: 0x0402684D RID: 157773
		[Token(Token = "0x402684D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402684E RID: 157774
		[Token(Token = "0x402684E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0402684F RID: 157775
		[Token(Token = "0x402684F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x04026850 RID: 157776
		[Token(Token = "0x4026850")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isShowing;

		// Token: 0x04026851 RID: 157777
		[Token(Token = "0x4026851")]
		[FieldOffset(Offset = "0x50")]
		private Sprite m_blurSprite;

		// Token: 0x04026852 RID: 157778
		[Token(Token = "0x4026852")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_cachedTween;

		// Token: 0x04026853 RID: 157779
		[Token(Token = "0x4026853")]
		[FieldOffset(Offset = "0x60")]
		private HomeMailGainItemView.ItemAdapter m_itemAdapter;

		// Token: 0x04026854 RID: 157780
		[Token(Token = "0x4026854")]
		[FieldOffset(Offset = "0x68")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x04026855 RID: 157781
		[Token(Token = "0x4026855")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform m_rectTransform;

		// Token: 0x04026856 RID: 157782
		[Token(Token = "0x4026856")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x02004C2C RID: 19500
		[Token(Token = "0x2004C2C")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D493 RID: 119955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D493")]
			[Address(RVA = "0x16DB8D0", Offset = "0x16DA4D0", VA = "0x1816DB8D0")]
			public ItemAdapter(HomeMailGainItemView closure)
			{
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0601D494 RID: 119956 RVA: 0x000AB198 File Offset: 0x000A9398
			[Token(Token = "0x170044D7")]
			public override int count
			{
				[Token(Token = "0x601D494")]
				[Address(RVA = "0x16DB950", Offset = "0x16DA550", VA = "0x1816DB950", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D495 RID: 119957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D495")]
			[Address(RVA = "0x16DB5D0", Offset = "0x16DA1D0", VA = "0x1816DB5D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026857 RID: 157783
			[Token(Token = "0x4026857")]
			[FieldOffset(Offset = "0x20")]
			private HomeMailGainItemView m_closure;

			// Token: 0x04026858 RID: 157784
			[Token(Token = "0x4026858")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026859 RID: 157785
			[Token(Token = "0x4026859")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402685A RID: 157786
			[Token(Token = "0x402685A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
