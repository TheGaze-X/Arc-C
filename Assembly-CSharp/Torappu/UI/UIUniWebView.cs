using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038A5 RID: 14501
	[Token(Token = "0x20038A5")]
	[RequireComponent(typeof(RectTransform))]
	public class UIUniWebView : MonoBehaviour, IHotfixable, ISafeAreaListener
	{
		// Token: 0x06016F1B RID: 93979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F1B")]
		[Address(RVA = "0xF68C90", Offset = "0xF67890", VA = "0x180F68C90")]
		private void EnsureWidget()
		{
		}

		// Token: 0x06016F1C RID: 93980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F1C")]
		[Address(RVA = "0xF68D60", Offset = "0xF67960", VA = "0x180F68D60")]
		public void InitIfNot()
		{
		}

		// Token: 0x06016F1D RID: 93981 RVA: 0x00094128 File Offset: 0x00092328
		[Token(Token = "0x6016F1D")]
		[Address(RVA = "0xF68E30", Offset = "0xF67A30", VA = "0x180F68E30")]
		public bool OpenUrl(string url, bool fade = false, float duration = 0.4f)
		{
			return default(bool);
		}

		// Token: 0x06016F1E RID: 93982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F1E")]
		[Address(RVA = "0xF68C10", Offset = "0xF67810", VA = "0x180F68C10")]
		public void Close(bool fade = false, float duration = 0.4f)
		{
		}

		// Token: 0x06016F1F RID: 93983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F1F")]
		[Address(RVA = "0xF68650", Offset = "0xF67250", VA = "0x180F68650")]
		public UniWebViewEdgeInsets CalculateInsets()
		{
			return null;
		}

		// Token: 0x06016F20 RID: 93984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F20")]
		[Address(RVA = "0xF68DC0", Offset = "0xF679C0", VA = "0x180F68DC0", Slot = "4")]
		public void OnSafeRectUpdated(SafeRect safeRect)
		{
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F21")]
		[Address(RVA = "0xF68F40", Offset = "0xF67B40", VA = "0x180F68F40")]
		private void _OnReceiveKeyCode(int keyCode)
		{
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F22")]
		[Address(RVA = "0xF68FE0", Offset = "0xF67BE0", VA = "0x180F68FE0")]
		public UIUniWebView()
		{
		}

		// Token: 0x0401BB12 RID: 113426
		[Token(Token = "0x401BB12")]
		private const int BACK_PRESS_KEYCODE = 4;

		// Token: 0x0401BB13 RID: 113427
		[Token(Token = "0x401BB13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _alpha;

		// Token: 0x0401BB14 RID: 113428
		[Token(Token = "0x401BB14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Enable only if OpenUrl() is failed.")]
		private GameObject _failedTarget;

		// Token: 0x0401BB15 RID: 113429
		[Token(Token = "0x401BB15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool openLinksInExternal;

		// Token: 0x0401BB16 RID: 113430
		[Token(Token = "0x401BB16")]
		[FieldOffset(Offset = "0x30")]
		public Camera targetCamera;

		// Token: 0x0401BB17 RID: 113431
		[Token(Token = "0x401BB17")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _rectTransform;

		// Token: 0x0401BB18 RID: 113432
		[Token(Token = "0x401BB18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsureWidget;

		// Token: 0x0401BB19 RID: 113433
		[Token(Token = "0x401BB19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401BB1A RID: 113434
		[Token(Token = "0x401BB1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenUrl;

		// Token: 0x0401BB1B RID: 113435
		[Token(Token = "0x401BB1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0401BB1C RID: 113436
		[Token(Token = "0x401BB1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateInsets;

		// Token: 0x0401BB1D RID: 113437
		[Token(Token = "0x401BB1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0401BB1E RID: 113438
		[Token(Token = "0x401BB1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnReceiveKeyCode;

		// Token: 0x0401BB1F RID: 113439
		[Token(Token = "0x401BB1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
