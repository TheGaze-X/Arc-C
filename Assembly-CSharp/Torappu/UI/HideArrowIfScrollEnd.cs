using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200379C RID: 14236
	[Token(Token = "0x200379C")]
	public class HideArrowIfScrollEnd : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016956 RID: 92502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016956")]
		[Address(RVA = "0xEF9380", Offset = "0xEF7F80", VA = "0x180EF9380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016957 RID: 92503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016957")]
		[Address(RVA = "0xEF94A0", Offset = "0xEF80A0", VA = "0x180EF94A0")]
		private void _OnValueChanged(Vector2 size)
		{
		}

		// Token: 0x06016958 RID: 92504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016958")]
		[Address(RVA = "0xEF9520", Offset = "0xEF8120", VA = "0x180EF9520")]
		private void _UpdateArrowState(Vector2 size)
		{
		}

		// Token: 0x06016959 RID: 92505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016959")]
		[Address(RVA = "0xEF92D0", Offset = "0xEF7ED0", VA = "0x180EF92D0")]
		private void Start()
		{
		}

		// Token: 0x0601695A RID: 92506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601695A")]
		[Address(RVA = "0xEF9660", Offset = "0xEF8260", VA = "0x180EF9660")]
		public HideArrowIfScrollEnd()
		{
		}

		// Token: 0x0401B38A RID: 111498
		[Token(Token = "0x401B38A")]
		[FieldOffset(Offset = "0x18")]
		private float CONST_DELTA;

		// Token: 0x0401B38B RID: 111499
		[Token(Token = "0x401B38B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _topArrow;

		// Token: 0x0401B38C RID: 111500
		[Token(Token = "0x401B38C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _downArrow;

		// Token: 0x0401B38D RID: 111501
		[Token(Token = "0x401B38D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0401B38E RID: 111502
		[Token(Token = "0x401B38E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0401B38F RID: 111503
		[Token(Token = "0x401B38F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401B390 RID: 111504
		[Token(Token = "0x401B390")]
		[FieldOffset(Offset = "0x48")]
		private UIWrappedScrollRect.Wrapper m_scrollRect;

		// Token: 0x0401B391 RID: 111505
		[Token(Token = "0x401B391")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isScrollVertical;

		// Token: 0x0401B392 RID: 111506
		[Token(Token = "0x401B392")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isScrollHorizontal;

		// Token: 0x0401B393 RID: 111507
		[Token(Token = "0x401B393")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B394 RID: 111508
		[Token(Token = "0x401B394")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401B395 RID: 111509
		[Token(Token = "0x401B395")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateArrowState;

		// Token: 0x0401B396 RID: 111510
		[Token(Token = "0x401B396")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B397 RID: 111511
		[Token(Token = "0x401B397")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
