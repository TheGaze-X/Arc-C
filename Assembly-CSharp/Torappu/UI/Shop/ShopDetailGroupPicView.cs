using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AAC RID: 23212
	[Token(Token = "0x2005AAC")]
	public class ShopDetailGroupPicView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021C23 RID: 138275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C23")]
		[Address(RVA = "0x1C3BFA0", Offset = "0x1C3ABA0", VA = "0x181C3BFA0")]
		public void ApplyImgInfo(List<Sprite> groupImgList, Vector2 cellSize)
		{
		}

		// Token: 0x06021C24 RID: 138276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C24")]
		[Address(RVA = "0x1C3C370", Offset = "0x1C3AF70", VA = "0x181C3C370")]
		private void Awake()
		{
		}

		// Token: 0x06021C25 RID: 138277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C25")]
		[Address(RVA = "0x1C3C470", Offset = "0x1C3B070", VA = "0x181C3C470")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021C26 RID: 138278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C26")]
		[Address(RVA = "0x1C3C570", Offset = "0x1C3B170", VA = "0x181C3C570")]
		private void Update()
		{
		}

		// Token: 0x06021C27 RID: 138279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C27")]
		[Address(RVA = "0x1C3C6F0", Offset = "0x1C3B2F0", VA = "0x181C3C6F0")]
		private void _PageSwitchCallback(int index)
		{
		}

		// Token: 0x06021C28 RID: 138280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C28")]
		[Address(RVA = "0x1C3C7D0", Offset = "0x1C3B3D0", VA = "0x181C3C7D0")]
		private void _TryTweenToPage(int pageIndex)
		{
		}

		// Token: 0x06021C29 RID: 138281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C29")]
		[Address(RVA = "0x1C3C860", Offset = "0x1C3B460", VA = "0x181C3C860")]
		public ShopDetailGroupPicView()
		{
		}

		// Token: 0x0402E302 RID: 189186
		[Token(Token = "0x402E302")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _trans;

		// Token: 0x0402E303 RID: 189187
		[Token(Token = "0x402E303")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollViewPager _viewPager;

		// Token: 0x0402E304 RID: 189188
		[Token(Token = "0x402E304")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _viewToggle;

		// Token: 0x0402E305 RID: 189189
		[Token(Token = "0x402E305")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _toggleContainer;

		// Token: 0x0402E306 RID: 189190
		[Token(Token = "0x402E306")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _viewImg;

		// Token: 0x0402E307 RID: 189191
		[Token(Token = "0x402E307")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _viewImgContainer;

		// Token: 0x0402E308 RID: 189192
		[Token(Token = "0x402E308")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GridLayoutGroup _layoutGroup;

		// Token: 0x0402E309 RID: 189193
		[Token(Token = "0x402E309")]
		[FieldOffset(Offset = "0x50")]
		private List<Toggle> m_switchToggles;

		// Token: 0x0402E30A RID: 189194
		[Token(Token = "0x402E30A")]
		[FieldOffset(Offset = "0x58")]
		private List<Image> m_imgList;

		// Token: 0x0402E30B RID: 189195
		[Token(Token = "0x402E30B")]
		[FieldOffset(Offset = "0x60")]
		private int m_currentMaxCount;

		// Token: 0x0402E30C RID: 189196
		[Token(Token = "0x402E30C")]
		[FieldOffset(Offset = "0x64")]
		private float m_switchCountDown;

		// Token: 0x0402E30D RID: 189197
		[Token(Token = "0x402E30D")]
		private const float SWITCH_PAGE_PERIOD = 6f;

		// Token: 0x0402E30E RID: 189198
		[Token(Token = "0x402E30E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyImgInfo;

		// Token: 0x0402E30F RID: 189199
		[Token(Token = "0x402E30F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0402E310 RID: 189200
		[Token(Token = "0x402E310")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E311 RID: 189201
		[Token(Token = "0x402E311")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402E312 RID: 189202
		[Token(Token = "0x402E312")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PageSwitchCallback;

		// Token: 0x0402E313 RID: 189203
		[Token(Token = "0x402E313")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTweenToPage;

		// Token: 0x0402E314 RID: 189204
		[Token(Token = "0x402E314")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
