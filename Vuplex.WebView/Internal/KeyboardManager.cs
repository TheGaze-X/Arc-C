using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	internal class KeyboardManager : MonoBehaviour
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000056")]
		public static KeyboardManager Instance
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x5BCD970", Offset = "0x5BCC570", VA = "0x185BCD970")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x5BCBDA0", Offset = "0x5BCA9A0", VA = "0x185BCBDA0")]
		public void AddKeyboard(BaseKeyboard keyboard)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x5BCC800", Offset = "0x5BCB400", VA = "0x185BCC800")]
		public void RemoveKeyboard(BaseKeyboard keyboard)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x5BCC9A0", Offset = "0x5BCB5A0", VA = "0x185BCC9A0")]
		public void SetKeyboardEnabled(BaseWebViewPrefab webViewPrefab, bool enabled)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x5BCBF10", Offset = "0x5BCAB10", VA = "0x185BCBF10")]
		private void Awake()
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x5BCC730", Offset = "0x5BCB330", VA = "0x185BCC730")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5BCCAC0", Offset = "0x5BCB6C0", VA = "0x185BCCAC0")]
		private void WebViewPrefab_Clicked(object sender, ClickedEventArgs eventArgs)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5BCD1A0", Offset = "0x5BCBDA0", VA = "0x185BCD1A0")]
		private void _addWebViewPrefab(BaseWebViewPrefab webViewPrefab)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5BCC440", Offset = "0x5BCB040", VA = "0x185BCC440")]
		private void NativeKeyboardListener_ImeCompositionCancelled(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5BCC4B0", Offset = "0x5BCB0B0", VA = "0x185BCC4B0")]
		private void NativeKeyboardListener_ImeCompositionChanged(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5BCC540", Offset = "0x5BCB140", VA = "0x185BCC540")]
		private void NativeKeyboardListener_ImeCompositionFinished(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5BCC5D0", Offset = "0x5BCB1D0", VA = "0x185BCC5D0")]
		private void NativeKeyboardListener_KeyDownReceived(object sender, KeyboardEventArgs eventArgs)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x5BCC6A0", Offset = "0x5BCB2A0", VA = "0x185BCC6A0")]
		private void NativeKeyboardListener_KeyUpReceived(object sender, KeyboardEventArgs eventArgs)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5BCC770", Offset = "0x5BCB370", VA = "0x185BCC770")]
		private void OnScreenKeyboard_KeyPressed(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5104EF0", Offset = "0x5103AF0", VA = "0x185104EF0")]
		private void OnScreenKeyboard_PointerEntered(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5BCC7F0", Offset = "0x5BCB3F0", VA = "0x185BCC7F0")]
		private void OnScreenKeyboard_PointerExited(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x5BCC9C0", Offset = "0x5BCB5C0", VA = "0x185BCC9C0")]
		private void Update()
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x5BCD500", Offset = "0x5BCC100", VA = "0x185BCD500")]
		private void _removeWebViewPrefab(BaseWebViewPrefab webViewPrefab)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5BCD810", Offset = "0x5BCC410", VA = "0x185BCD810")]
		private void _setFocusedWebViewPrefab(BaseWebViewPrefab webViewPrefab)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5BCCDC0", Offset = "0x5BCB9C0", VA = "0x185BCCDC0")]
		private void WebView_FocusChanged(object sender, EventArgs<bool> eventArgs)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x5BCCF70", Offset = "0x5BCBB70", VA = "0x185BCCF70")]
		private void WebView_ImeInputFieldPositionChanged(object sender, EventArgs<Vector2Int> eventArgs)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x5BCCB90", Offset = "0x5BCB790", VA = "0x185BCCB90")]
		private void WebViewPrefab_PointerEntered(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5BCCCC0", Offset = "0x5BCB8C0", VA = "0x185BCCCC0")]
		private void WebViewPrefab_PointerExited(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5BCD430", Offset = "0x5BCC030", VA = "0x185BCD430")]
		public KeyboardManager()
		{
		}

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x0")]
		private static bool _destroyed;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x18")]
		private BaseWebViewPrefab _focusedWebViewPrefab;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x20")]
		private BaseWebViewPrefab _hoveredWebViewPrefab;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x8")]
		private static KeyboardManager _instance;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<BaseKeyboard> _keyboards;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x30")]
		private NativeKeyboardListener _nativeKeyboardListener;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x38")]
		private bool _pointerIsHoveringOverKeyboard;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<BaseWebViewPrefab> _webViewPrefabs;
	}
}
