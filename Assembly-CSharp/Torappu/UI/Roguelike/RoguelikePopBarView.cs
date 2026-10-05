using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D0 RID: 20944
	[Token(Token = "0x20051D0")]
	public class RoguelikePopBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x0601EEF3 RID: 126707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700483C")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x601EEF3")]
			[Address(RVA = "0x18C09B0", Offset = "0x18BF5B0", VA = "0x1818C09B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EEF4 RID: 126708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF4")]
		[Address(RVA = "0x18C04C0", Offset = "0x18BF0C0", VA = "0x1818C04C0")]
		public void RenderValue(float currentValInput, float maxVal, bool fixInCoro = true, float delta = -1f)
		{
		}

		// Token: 0x0601EEF5 RID: 126709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF5")]
		[Address(RVA = "0x18BFE30", Offset = "0x18BEA30", VA = "0x1818BFE30")]
		public void LateUpdate()
		{
		}

		// Token: 0x0601EEF6 RID: 126710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF6")]
		[Address(RVA = "0x18BFC50", Offset = "0x18BE850", VA = "0x1818BFC50")]
		public void CheckPos()
		{
		}

		// Token: 0x0601EEF7 RID: 126711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF7")]
		[Address(RVA = "0x18C0290", Offset = "0x18BEE90", VA = "0x1818C0290")]
		public void RenderTween(int currentVal, int maxVal, float duration = 1f)
		{
		}

		// Token: 0x0601EEF8 RID: 126712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF8")]
		[Address(RVA = "0x18C0070", Offset = "0x18BEC70", VA = "0x1818C0070")]
		public void RenderTween(int currentVal, int maxInitVal, int maxTargetVal, float duration = 1f)
		{
		}

		// Token: 0x0601EEF9 RID: 126713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF9")]
		[Address(RVA = "0x18BFE90", Offset = "0x18BEA90", VA = "0x1818BFE90")]
		public void RenderTweenCurrent(int currentVal, int maxVal, int currentTargetVal, float duration = 0.3f)
		{
		}

		// Token: 0x0601EEFA RID: 126714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EEFA")]
		[Address(RVA = "0x18C07C0", Offset = "0x18BF3C0", VA = "0x1818C07C0")]
		private Coroutine _CoroutineWithPage(IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x0601EEFB RID: 126715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEFB")]
		[Address(RVA = "0x18C0940", Offset = "0x18BF540", VA = "0x1818C0940")]
		public RoguelikePopBarView()
		{
		}

		// Token: 0x04029820 RID: 170016
		[Token(Token = "0x4029820")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _currentBar;

		// Token: 0x04029821 RID: 170017
		[Token(Token = "0x4029821")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _maxBar;

		// Token: 0x04029822 RID: 170018
		[Token(Token = "0x4029822")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxCount1;

		// Token: 0x04029823 RID: 170019
		[Token(Token = "0x4029823")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxCount2;

		// Token: 0x04029824 RID: 170020
		[Token(Token = "0x4029824")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _currentCount1;

		// Token: 0x04029825 RID: 170021
		[Token(Token = "0x4029825")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maxLength;

		// Token: 0x04029826 RID: 170022
		[Token(Token = "0x4029826")]
		[FieldOffset(Offset = "0x48")]
		private UIPageListener m_pageListener;

		// Token: 0x04029827 RID: 170023
		[Token(Token = "0x4029827")]
		[FieldOffset(Offset = "0x50")]
		private float m_cacheCurrentVal;

		// Token: 0x04029828 RID: 170024
		[Token(Token = "0x4029828")]
		[FieldOffset(Offset = "0x54")]
		private float m_cacheMaxValue;

		// Token: 0x04029829 RID: 170025
		[Token(Token = "0x4029829")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x0402982A RID: 170026
		[Token(Token = "0x402982A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderValue;

		// Token: 0x0402982B RID: 170027
		[Token(Token = "0x402982B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0402982C RID: 170028
		[Token(Token = "0x402982C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckPos;

		// Token: 0x0402982D RID: 170029
		[Token(Token = "0x402982D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderTween;

		// Token: 0x0402982E RID: 170030
		[Token(Token = "0x402982E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_RenderTween;

		// Token: 0x0402982F RID: 170031
		[Token(Token = "0x402982F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderTweenCurrent;

		// Token: 0x04029830 RID: 170032
		[Token(Token = "0x4029830")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x04029831 RID: 170033
		[Token(Token = "0x4029831")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
