using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ADC RID: 27356
	[Token(Token = "0x2006ADC")]
	public class AutoFocusScrollView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602720D RID: 160269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602720D")]
		[Address(RVA = "0x2258860", Offset = "0x2257460", VA = "0x182258860")]
		public void StartSpawnChildren()
		{
		}

		// Token: 0x0602720E RID: 160270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602720E")]
		[Address(RVA = "0x2258750", Offset = "0x2257350", VA = "0x182258750")]
		public void FocusOnIndex(int index, int count, bool fastMode, float duration)
		{
		}

		// Token: 0x0602720F RID: 160271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602720F")]
		[Address(RVA = "0x2258A40", Offset = "0x2257640", VA = "0x182258A40")]
		private void _ProcessParam(AutoFocusScrollView.FocusParams param)
		{
		}

		// Token: 0x06027210 RID: 160272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027210")]
		[Address(RVA = "0x2258D00", Offset = "0x2257900", VA = "0x182258D00")]
		public AutoFocusScrollView()
		{
		}

		// Token: 0x04037585 RID: 226693
		[Token(Token = "0x4037585")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04037586 RID: 226694
		[Token(Token = "0x4037586")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _scrollViewRect;

		// Token: 0x04037587 RID: 226695
		[Token(Token = "0x4037587")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemSize;

		// Token: 0x04037588 RID: 226696
		[Token(Token = "0x4037588")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _itemSpacing;

		// Token: 0x04037589 RID: 226697
		[Token(Token = "0x4037589")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _marginFront;

		// Token: 0x0403758A RID: 226698
		[Token(Token = "0x403758A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _marginEnd;

		// Token: 0x0403758B RID: 226699
		[Token(Token = "0x403758B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _horizontal;

		// Token: 0x0403758C RID: 226700
		[Token(Token = "0x403758C")]
		[FieldOffset(Offset = "0x39")]
		private bool m_layoutConstructCompleted;

		// Token: 0x0403758D RID: 226701
		[Token(Token = "0x403758D")]
		[FieldOffset(Offset = "0x40")]
		private AutoFocusScrollView.FocusParams m_pendingParam;

		// Token: 0x0403758E RID: 226702
		[Token(Token = "0x403758E")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x0403758F RID: 226703
		[Token(Token = "0x403758F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_StartSpawnChildren;

		// Token: 0x04037590 RID: 226704
		[Token(Token = "0x4037590")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FocusOnIndex;

		// Token: 0x04037591 RID: 226705
		[Token(Token = "0x4037591")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ProcessParam;

		// Token: 0x04037592 RID: 226706
		[Token(Token = "0x4037592")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006ADD RID: 27357
		[Token(Token = "0x2006ADD")]
		private class FocusParams
		{
			// Token: 0x06027214 RID: 160276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027214")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FocusParams()
			{
			}

			// Token: 0x04037593 RID: 226707
			[Token(Token = "0x4037593")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04037594 RID: 226708
			[Token(Token = "0x4037594")]
			[FieldOffset(Offset = "0x14")]
			public int count;

			// Token: 0x04037595 RID: 226709
			[Token(Token = "0x4037595")]
			[FieldOffset(Offset = "0x18")]
			public bool fastMode;

			// Token: 0x04037596 RID: 226710
			[Token(Token = "0x4037596")]
			[FieldOffset(Offset = "0x1C")]
			public float duration;
		}
	}
}
