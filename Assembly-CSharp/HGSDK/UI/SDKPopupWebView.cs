using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace HGSDK.UI
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[RequireComponent(typeof(CanvasGroup))]
	public class SDKPopupWebView : MonoBehaviour
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		protected CanvasGroup canvasGroup
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x2536FE0", Offset = "0x2535BE0", VA = "0x182536FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x17000130")]
		private bool isFade
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x2537080", Offset = "0x2535C80", VA = "0x182537080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2536E90", Offset = "0x2535A90", VA = "0x182536E90")]
		public void SetCamera(Camera camera)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2536EC0", Offset = "0x2535AC0", VA = "0x182536EC0")]
		private void Start()
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x2536D20", Offset = "0x2535920", VA = "0x182536D20")]
		public void OpenUrl(string url, [Optional] Action onClosed)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2536B30", Offset = "0x2535730", VA = "0x182536B30")]
		public void CloseMe()
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2536F90", Offset = "0x2535B90", VA = "0x182536F90")]
		private void _ClearAll()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1A84420", Offset = "0x1A83020", VA = "0x181A84420")]
		public SDKPopupWebView()
		{
		}

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIUniWebView _webView;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action m_onClosed;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup m_canvasGroup;
	}
}
