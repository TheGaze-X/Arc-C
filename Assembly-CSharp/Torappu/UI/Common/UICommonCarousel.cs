using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Common
{
	// Token: 0x02005C24 RID: 23588
	[Token(Token = "0x2005C24")]
	public class UICommonCarousel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602231E RID: 140062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602231E")]
		[Address(RVA = "0x1CB6080", Offset = "0x1CB4C80", VA = "0x181CB6080")]
		public void InitState()
		{
		}

		// Token: 0x0602231F RID: 140063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602231F")]
		public T GenCarouselItem<T>(T item) where T : UICommonCarouselItem
		{
			return null;
		}

		// Token: 0x06022320 RID: 140064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022320")]
		[Address(RVA = "0x1CB5F80", Offset = "0x1CB4B80", VA = "0x181CB5F80")]
		public void AddAnim(UICommonCarouselItem item, float speed, [Optional] Action onFinish)
		{
		}

		// Token: 0x06022321 RID: 140065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022321")]
		[Address(RVA = "0x1CB6200", Offset = "0x1CB4E00", VA = "0x181CB6200")]
		public void PlaySequence(bool loop)
		{
		}

		// Token: 0x06022322 RID: 140066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022322")]
		[Address(RVA = "0x1CB6450", Offset = "0x1CB5050", VA = "0x181CB6450")]
		private void _InstTweener(RectTransform item, float perferedWidth, float speed, Action onFinish)
		{
		}

		// Token: 0x06022323 RID: 140067 RVA: 0x000BC9E8 File Offset: 0x000BABE8
		[Token(Token = "0x6022323")]
		[Address(RVA = "0x1CB6380", Offset = "0x1CB4F80", VA = "0x181CB6380")]
		private bool _CheckItemIllegal(UICommonCarouselItem item)
		{
			return default(bool);
		}

		// Token: 0x06022324 RID: 140068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022324")]
		[Address(RVA = "0x1CB6890", Offset = "0x1CB5490", VA = "0x181CB6890")]
		public UICommonCarousel()
		{
		}

		// Token: 0x0402EE80 RID: 192128
		[Token(Token = "0x402EE80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0402EE81 RID: 192129
		[Token(Token = "0x402EE81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402EE82 RID: 192130
		[Token(Token = "0x402EE82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeOutTime;

		// Token: 0x0402EE83 RID: 192131
		[Token(Token = "0x402EE83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tween m_hideTween;

		// Token: 0x0402EE84 RID: 192132
		[Token(Token = "0x402EE84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sequence m_animSequence;

		// Token: 0x0402EE85 RID: 192133
		[Token(Token = "0x402EE85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_width;

		// Token: 0x0402EE86 RID: 192134
		[Token(Token = "0x402EE86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_animTime;

		// Token: 0x0402EE87 RID: 192135
		[Token(Token = "0x402EE87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitState;

		// Token: 0x0402EE88 RID: 192136
		[Token(Token = "0x402EE88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenCarouselItem;

		// Token: 0x0402EE89 RID: 192137
		[Token(Token = "0x402EE89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddAnim;

		// Token: 0x0402EE8A RID: 192138
		[Token(Token = "0x402EE8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlaySequence;

		// Token: 0x0402EE8B RID: 192139
		[Token(Token = "0x402EE8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InstTweener;

		// Token: 0x0402EE8C RID: 192140
		[Token(Token = "0x402EE8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckItemIllegal;

		// Token: 0x0402EE8D RID: 192141
		[Token(Token = "0x402EE8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
