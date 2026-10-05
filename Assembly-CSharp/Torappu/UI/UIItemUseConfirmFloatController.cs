using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200373F RID: 14143
	[Token(Token = "0x200373F")]
	public class UIItemUseConfirmFloatController : PageSingleComponent
	{
		// Token: 0x06016775 RID: 92021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016775")]
		[Address(RVA = "0xEEC170", Offset = "0xEEAD70", VA = "0x180EEC170")]
		public static void RenderConfirmPanel(int cost, string itemId, ItemType itemType, string confirmText, Action onConfirm)
		{
		}

		// Token: 0x06016776 RID: 92022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016776")]
		[Address(RVA = "0xEEC2E0", Offset = "0xEEAEE0", VA = "0x180EEC2E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016777 RID: 92023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016777")]
		[Address(RVA = "0xEEC440", Offset = "0xEEB040", VA = "0x180EEC440")]
		private void _RenderConfirm(int cost, string itemId, ItemType itemType, string confirmText, Action onConfirm)
		{
		}

		// Token: 0x06016778 RID: 92024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016778")]
		[Address(RVA = "0xEEC710", Offset = "0xEEB310", VA = "0x180EEC710")]
		public UIItemUseConfirmFloatController()
		{
		}

		// Token: 0x0401B0EA RID: 110826
		[Token(Token = "0x401B0EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("This should be full-screen to make float cover everything")]
		private RectTransform _floatHolder;

		// Token: 0x0401B0EB RID: 110827
		[Token(Token = "0x401B0EB")]
		[FieldOffset(Offset = "0x28")]
		private UIItemUseConfirmFloat m_floatInst;

		// Token: 0x0401B0EC RID: 110828
		[Token(Token = "0x401B0EC")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401B0ED RID: 110829
		[Token(Token = "0x401B0ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderConfirmPanel;

		// Token: 0x0401B0EE RID: 110830
		[Token(Token = "0x401B0EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B0EF RID: 110831
		[Token(Token = "0x401B0EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderConfirm;

		// Token: 0x0401B0F0 RID: 110832
		[Token(Token = "0x401B0F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
