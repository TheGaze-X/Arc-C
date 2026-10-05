using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200379A RID: 14234
	[Token(Token = "0x200379A")]
	public class HideArrowIfScrollAtLastItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601694E RID: 92494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601694E")]
		[Address(RVA = "0xEF8C60", Offset = "0xEF7860", VA = "0x180EF8C60")]
		public void SetParam(HideArrowIfScrollAtLastItem.Param param)
		{
		}

		// Token: 0x0601694F RID: 92495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601694F")]
		[Address(RVA = "0xEF8EA0", Offset = "0xEF7AA0", VA = "0x180EF8EA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016950 RID: 92496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016950")]
		[Address(RVA = "0xEF8FD0", Offset = "0xEF7BD0", VA = "0x180EF8FD0")]
		private void _OnValueChanged(Vector2 size)
		{
		}

		// Token: 0x06016951 RID: 92497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016951")]
		[Address(RVA = "0xEF9160", Offset = "0xEF7D60", VA = "0x180EF9160")]
		private void _UpdateArrowState(Vector2 size)
		{
		}

		// Token: 0x06016952 RID: 92498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016952")]
		[Address(RVA = "0xEF9050", Offset = "0xEF7C50", VA = "0x180EF9050")]
		private void _RecalculateThreshold()
		{
		}

		// Token: 0x06016953 RID: 92499 RVA: 0x00091EA8 File Offset: 0x000900A8
		[Token(Token = "0x6016953")]
		[Address(RVA = "0xEF8DA0", Offset = "0xEF79A0", VA = "0x180EF8DA0")]
		private float _CalculateAxisThreshold(float axisLength, int itemCnt, float itemSize)
		{
			return 0f;
		}

		// Token: 0x06016954 RID: 92500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016954")]
		[Address(RVA = "0xEF8CF0", Offset = "0xEF78F0", VA = "0x180EF8CF0")]
		private void Start()
		{
		}

		// Token: 0x06016955 RID: 92501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016955")]
		[Address(RVA = "0xEF9260", Offset = "0xEF7E60", VA = "0x180EF9260")]
		public HideArrowIfScrollAtLastItem()
		{
		}

		// Token: 0x0401B376 RID: 111478
		[Token(Token = "0x401B376")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _lastItemCnt;

		// Token: 0x0401B377 RID: 111479
		[Token(Token = "0x401B377")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _horizontalArrow;

		// Token: 0x0401B378 RID: 111480
		[Token(Token = "0x401B378")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _verticalArrow;

		// Token: 0x0401B379 RID: 111481
		[Token(Token = "0x401B379")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401B37A RID: 111482
		[Token(Token = "0x401B37A")]
		[FieldOffset(Offset = "0x38")]
		private UIWrappedScrollRect.Wrapper m_scrollRect;

		// Token: 0x0401B37B RID: 111483
		[Token(Token = "0x401B37B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isScrollVertical;

		// Token: 0x0401B37C RID: 111484
		[Token(Token = "0x401B37C")]
		[FieldOffset(Offset = "0x41")]
		private bool m_isScrollHorizontal;

		// Token: 0x0401B37D RID: 111485
		[Token(Token = "0x401B37D")]
		[FieldOffset(Offset = "0x44")]
		private HideArrowIfScrollAtLastItem.Param m_cachedParam;

		// Token: 0x0401B37E RID: 111486
		[Token(Token = "0x401B37E")]
		[FieldOffset(Offset = "0x50")]
		private float m_cachedVerThreshold;

		// Token: 0x0401B37F RID: 111487
		[Token(Token = "0x401B37F")]
		[FieldOffset(Offset = "0x54")]
		private float m_cachedHorThreshold;

		// Token: 0x0401B380 RID: 111488
		[Token(Token = "0x401B380")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0401B381 RID: 111489
		[Token(Token = "0x401B381")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B382 RID: 111490
		[Token(Token = "0x401B382")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401B383 RID: 111491
		[Token(Token = "0x401B383")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateArrowState;

		// Token: 0x0401B384 RID: 111492
		[Token(Token = "0x401B384")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RecalculateThreshold;

		// Token: 0x0401B385 RID: 111493
		[Token(Token = "0x401B385")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalculateAxisThreshold;

		// Token: 0x0401B386 RID: 111494
		[Token(Token = "0x401B386")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B387 RID: 111495
		[Token(Token = "0x401B387")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200379B RID: 14235
		[Token(Token = "0x200379B")]
		public struct Param
		{
			// Token: 0x0401B388 RID: 111496
			[Token(Token = "0x401B388")]
			[FieldOffset(Offset = "0x0")]
			public int itemCount;

			// Token: 0x0401B389 RID: 111497
			[Token(Token = "0x401B389")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 itemSize;
		}
	}
}
