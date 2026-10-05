using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[HelpURL("https://developer.vuplex.com/webview/IPointerInputDetector")]
	public class CanvasPointerInputDetector : DefaultPointerInputDetector
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5BB0BE0", Offset = "0x5BAF7E0", VA = "0x185BB0BE0", Slot = "33")]
		protected override Vector2 _convertToNormalizedPoint(PointerEventData pointerEventData)
		{
			return default(Vector2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5BB0B70", Offset = "0x5BAF770", VA = "0x185BB0B70", Slot = "34")]
		protected override Vector2 _convertToNormalizedPoint(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x5BB0EE0", Offset = "0x5BAFAE0", VA = "0x185BB0EE0")]
		private Vector2 _convertVector2ToNormalizedPoint(Vector2 localPoint)
		{
			return default(Vector2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5BB0FC0", Offset = "0x5BAFBC0", VA = "0x185BB0FC0")]
		private RectTransform _getRectTransform()
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5BB1060", Offset = "0x5BAFC60", VA = "0x185BB1060", Slot = "35")]
		protected override bool _positionIsZero(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5BB0F60", Offset = "0x5BAFB60", VA = "0x185BB0F60")]
		public CanvasPointerInputDetector()
		{
		}

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform _cachedRectTransform;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x80")]
		private CachingGetter<Canvas> _canvasGetter;
	}
}
