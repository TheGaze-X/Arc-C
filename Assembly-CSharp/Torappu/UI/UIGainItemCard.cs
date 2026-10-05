using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003931 RID: 14641
	[Token(Token = "0x2003931")]
	public class UIGainItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017242 RID: 94786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017242")]
		[Address(RVA = "0xF91D30", Offset = "0xF90930", VA = "0x180F91D30")]
		public void Render(UIGainItemCard.Options options, UIGainItemFloatPanel closure, Action onFinished)
		{
		}

		// Token: 0x06017243 RID: 94787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017243")]
		[Address(RVA = "0xF91C20", Offset = "0xF90820", VA = "0x180F91C20")]
		public void HideEffect(UIGainItemFloatPanel closure)
		{
		}

		// Token: 0x06017244 RID: 94788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017244")]
		[Address(RVA = "0xF91AE0", Offset = "0xF906E0", VA = "0x180F91AE0")]
		public void ForceToEnd(UIGainItemFloatPanel closure)
		{
		}

		// Token: 0x06017245 RID: 94789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017245")]
		[Address(RVA = "0xF92470", Offset = "0xF91070", VA = "0x180F92470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017246 RID: 94790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017246")]
		[Address(RVA = "0xF92310", Offset = "0xF90F10", VA = "0x180F92310")]
		private IEnumerator _DoRenderCoroutine(float delay, bool showEffect)
		{
			return null;
		}

		// Token: 0x06017247 RID: 94791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017247")]
		[Address(RVA = "0xF92560", Offset = "0xF91160", VA = "0x180F92560")]
		private void _ResetAll(UIGainItemFloatPanel closure)
		{
		}

		// Token: 0x06017248 RID: 94792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017248")]
		[Address(RVA = "0xF923F0", Offset = "0xF90FF0", VA = "0x180F923F0")]
		private void _FinishMe()
		{
		}

		// Token: 0x06017249 RID: 94793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017249")]
		[Address(RVA = "0xF92680", Offset = "0xF91280", VA = "0x180F92680")]
		private void _StopCoroutine(UIGainItemFloatPanel closure)
		{
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601724A")]
		[Address(RVA = "0xF92720", Offset = "0xF91320", VA = "0x180F92720")]
		public UIGainItemCard()
		{
		}

		// Token: 0x0401BEEB RID: 114411
		[Token(Token = "0x401BEEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIItemCard _internalPrefab;

		// Token: 0x0401BEEC RID: 114412
		[Token(Token = "0x401BEEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _effectHolder;

		// Token: 0x0401BEED RID: 114413
		[Token(Token = "0x401BEED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayForInternalCard;

		// Token: 0x0401BEEE RID: 114414
		[Token(Token = "0x401BEEE")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_internalCard;

		// Token: 0x0401BEEF RID: 114415
		[Token(Token = "0x401BEEF")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine m_coroutine;

		// Token: 0x0401BEF0 RID: 114416
		[Token(Token = "0x401BEF0")]
		[FieldOffset(Offset = "0x40")]
		private Action m_onFinished;

		// Token: 0x0401BEF1 RID: 114417
		[Token(Token = "0x401BEF1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isShowEffect;

		// Token: 0x0401BEF2 RID: 114418
		[Token(Token = "0x401BEF2")]
		[FieldOffset(Offset = "0x49")]
		private bool m_hasInited;

		// Token: 0x0401BEF3 RID: 114419
		[Token(Token = "0x401BEF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401BEF4 RID: 114420
		[Token(Token = "0x401BEF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0401BEF5 RID: 114421
		[Token(Token = "0x401BEF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForceToEnd;

		// Token: 0x0401BEF6 RID: 114422
		[Token(Token = "0x401BEF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401BEF7 RID: 114423
		[Token(Token = "0x401BEF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoRenderCoroutine;

		// Token: 0x0401BEF8 RID: 114424
		[Token(Token = "0x401BEF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAll;

		// Token: 0x0401BEF9 RID: 114425
		[Token(Token = "0x401BEF9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FinishMe;

		// Token: 0x0401BEFA RID: 114426
		[Token(Token = "0x401BEFA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StopCoroutine;

		// Token: 0x0401BEFB RID: 114427
		[Token(Token = "0x401BEFB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003932 RID: 14642
		[Token(Token = "0x2003932")]
		public struct Options
		{
			// Token: 0x0401BEFC RID: 114428
			[Token(Token = "0x401BEFC")]
			[FieldOffset(Offset = "0x0")]
			public UIItemViewModel model;

			// Token: 0x0401BEFD RID: 114429
			[Token(Token = "0x401BEFD")]
			[FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x0401BEFE RID: 114430
			[Token(Token = "0x401BEFE")]
			[FieldOffset(Offset = "0xC")]
			public float itemScaleFactor;

			// Token: 0x0401BEFF RID: 114431
			[Token(Token = "0x401BEFF")]
			[FieldOffset(Offset = "0x10")]
			public bool isShowEffect;
		}
	}
}
