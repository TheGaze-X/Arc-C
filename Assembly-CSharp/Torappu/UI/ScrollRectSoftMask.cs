using System;
using Il2CppDummyDll;
using SoftMasking;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039A9 RID: 14761
	[Token(Token = "0x20039A9")]
	public class ScrollRectSoftMask : MonoBehaviour, IHotfixable
	{
		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x06017539 RID: 95545 RVA: 0x00096000 File Offset: 0x00094200
		[Token(Token = "0x170037E1")]
		public Vector2 normalizedPosition
		{
			[Token(Token = "0x6017539")]
			[Address(RVA = "0xFB3420", Offset = "0xFB2020", VA = "0x180FB3420")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0601753A RID: 95546 RVA: 0x00096018 File Offset: 0x00094218
		[Token(Token = "0x170037E2")]
		public bool isHorizontal
		{
			[Token(Token = "0x601753A")]
			[Address(RVA = "0xFB3260", Offset = "0xFB1E60", VA = "0x180FB3260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0601753B RID: 95547 RVA: 0x00096030 File Offset: 0x00094230
		[Token(Token = "0x170037E3")]
		public bool isVertical
		{
			[Token(Token = "0x601753B")]
			[Address(RVA = "0xFB3340", Offset = "0xFB1F40", VA = "0x180FB3340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0601753C RID: 95548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037E4")]
		protected RectTransform viewRect
		{
			[Token(Token = "0x601753C")]
			[Address(RVA = "0xFB34E0", Offset = "0xFB20E0", VA = "0x180FB34E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601753D RID: 95549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601753D")]
		[Address(RVA = "0xFB26D0", Offset = "0xFB12D0", VA = "0x180FB26D0")]
		public void Initialized()
		{
		}

		// Token: 0x0601753E RID: 95550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601753E")]
		[Address(RVA = "0xFB2990", Offset = "0xFB1590", VA = "0x180FB2990")]
		private void OnEnable()
		{
		}

		// Token: 0x0601753F RID: 95551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601753F")]
		[Address(RVA = "0xFB2C60", Offset = "0xFB1860", VA = "0x180FB2C60")]
		private void Update()
		{
		}

		// Token: 0x06017540 RID: 95552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017540")]
		[Address(RVA = "0xFB2B50", Offset = "0xFB1750", VA = "0x180FB2B50")]
		public void Refresh()
		{
		}

		// Token: 0x06017541 RID: 95553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017541")]
		[Address(RVA = "0xFB2850", Offset = "0xFB1450", VA = "0x180FB2850")]
		public void OnDrag(Vector2 value)
		{
		}

		// Token: 0x06017542 RID: 95554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017542")]
		[Address(RVA = "0xFB2DC0", Offset = "0xFB19C0", VA = "0x180FB2DC0")]
		private void _TryUpdateContentFlag()
		{
		}

		// Token: 0x06017543 RID: 95555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017543")]
		[Address(RVA = "0xFB3180", Offset = "0xFB1D80", VA = "0x180FB3180")]
		public ScrollRectSoftMask()
		{
		}

		// Token: 0x0401C274 RID: 115316
		[Token(Token = "0x401C274")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _bothSprite;

		// Token: 0x0401C275 RID: 115317
		[Token(Token = "0x401C275")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _downSprite;

		// Token: 0x0401C276 RID: 115318
		[Token(Token = "0x401C276")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _upSprite;

		// Token: 0x0401C277 RID: 115319
		[Token(Token = "0x401C277")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0401C278 RID: 115320
		[Token(Token = "0x401C278")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401C279 RID: 115321
		[Token(Token = "0x401C279")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x0401C27A RID: 115322
		[Token(Token = "0x401C27A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SoftMask _softMask;

		// Token: 0x0401C27B RID: 115323
		[Token(Token = "0x401C27B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backMask;

		// Token: 0x0401C27C RID: 115324
		[Token(Token = "0x401C27C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _initOnEnable;

		// Token: 0x0401C27D RID: 115325
		[Token(Token = "0x401C27D")]
		[FieldOffset(Offset = "0x59")]
		private bool m_contentFlag;

		// Token: 0x0401C27E RID: 115326
		[Token(Token = "0x401C27E")]
		[FieldOffset(Offset = "0x60")]
		private RectTransform m_viewRect;

		// Token: 0x0401C27F RID: 115327
		[Token(Token = "0x401C27F")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_cachedContentSize;

		// Token: 0x0401C280 RID: 115328
		[Token(Token = "0x401C280")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_cachedBoundSize;

		// Token: 0x0401C281 RID: 115329
		[Token(Token = "0x401C281")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedDirFlag;

		// Token: 0x0401C282 RID: 115330
		[Token(Token = "0x401C282")]
		private const float EPS_DELTA = 0.005f;

		// Token: 0x0401C283 RID: 115331
		[Token(Token = "0x401C283")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_normalizedPosition;

		// Token: 0x0401C284 RID: 115332
		[Token(Token = "0x401C284")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isHorizontal;

		// Token: 0x0401C285 RID: 115333
		[Token(Token = "0x401C285")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isVertical;

		// Token: 0x0401C286 RID: 115334
		[Token(Token = "0x401C286")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_viewRect;

		// Token: 0x0401C287 RID: 115335
		[Token(Token = "0x401C287")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Initialized;

		// Token: 0x0401C288 RID: 115336
		[Token(Token = "0x401C288")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C289 RID: 115337
		[Token(Token = "0x401C289")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401C28A RID: 115338
		[Token(Token = "0x401C28A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0401C28B RID: 115339
		[Token(Token = "0x401C28B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0401C28C RID: 115340
		[Token(Token = "0x401C28C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryUpdateContentFlag;

		// Token: 0x0401C28D RID: 115341
		[Token(Token = "0x401C28D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
