using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037C4 RID: 14276
	[Token(Token = "0x20037C4")]
	public class UICullMaskController : MonoBehaviour, ISafeAreaListener, IHotfixable
	{
		// Token: 0x06016A19 RID: 92697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A19")]
		[Address(RVA = "0xF12010", Offset = "0xF10C10", VA = "0x180F12010")]
		private void Start()
		{
		}

		// Token: 0x06016A1A RID: 92698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A1A")]
		[Address(RVA = "0xF11EB0", Offset = "0xF10AB0", VA = "0x180F11EB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016A1B RID: 92699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A1B")]
		[Address(RVA = "0xF11F90", Offset = "0xF10B90", VA = "0x180F11F90", Slot = "4")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x06016A1C RID: 92700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A1C")]
		[Address(RVA = "0xF11F30", Offset = "0xF10B30", VA = "0x180F11F30")]
		private void OnEnable()
		{
		}

		// Token: 0x06016A1D RID: 92701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A1D")]
		[Address(RVA = "0xF12370", Offset = "0xF10F70", VA = "0x180F12370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016A1E RID: 92702 RVA: 0x000920B8 File Offset: 0x000902B8
		[Token(Token = "0x6016A1E")]
		[Address(RVA = "0xF120D0", Offset = "0xF10CD0", VA = "0x180F120D0")]
		private Vector2 _CalcUniformScreenSize()
		{
			return default(Vector2);
		}

		// Token: 0x06016A1F RID: 92703 RVA: 0x000920D0 File Offset: 0x000902D0
		[Token(Token = "0x6016A1F")]
		[Address(RVA = "0xF121A0", Offset = "0xF10DA0", VA = "0x180F121A0")]
		private Vector2 _DefaultStandardContentSize()
		{
			return default(Vector2);
		}

		// Token: 0x06016A20 RID: 92704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A20")]
		[Address(RVA = "0xF12400", Offset = "0xF11000", VA = "0x180F12400")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x06016A21 RID: 92705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A21")]
		[Address(RVA = "0xF127C0", Offset = "0xF113C0", VA = "0x180F127C0")]
		public UICullMaskController()
		{
		}

		// Token: 0x0401B47E RID: 111742
		[Token(Token = "0x401B47E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _panelLeft;

		// Token: 0x0401B47F RID: 111743
		[Token(Token = "0x401B47F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelRight;

		// Token: 0x0401B480 RID: 111744
		[Token(Token = "0x401B480")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelTop;

		// Token: 0x0401B481 RID: 111745
		[Token(Token = "0x401B481")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelBottom;

		// Token: 0x0401B482 RID: 111746
		[Token(Token = "0x401B482")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelCenter;

		// Token: 0x0401B483 RID: 111747
		[Token(Token = "0x401B483")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasScaler _canvasScaler;

		// Token: 0x0401B484 RID: 111748
		[Token(Token = "0x401B484")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0401B485 RID: 111749
		[Token(Token = "0x401B485")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B486 RID: 111750
		[Token(Token = "0x401B486")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B487 RID: 111751
		[Token(Token = "0x401B487")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0401B488 RID: 111752
		[Token(Token = "0x401B488")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B489 RID: 111753
		[Token(Token = "0x401B489")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B48A RID: 111754
		[Token(Token = "0x401B48A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalcUniformScreenSize;

		// Token: 0x0401B48B RID: 111755
		[Token(Token = "0x401B48B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DefaultStandardContentSize;

		// Token: 0x0401B48C RID: 111756
		[Token(Token = "0x401B48C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateLayout;

		// Token: 0x0401B48D RID: 111757
		[Token(Token = "0x401B48D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
