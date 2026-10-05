using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal struct SliderHandler
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x59AFFF0", Offset = "0x59AEBF0", VA = "0x1859AFFF0")]
		public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, [Optional] GUIStyle thumbExtent)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x59AE380", Offset = "0x59ACF80", VA = "0x1859AE380")]
		public float Handle()
		{
			return 0f;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x59AE7F0", Offset = "0x59AD3F0", VA = "0x1859AE7F0")]
		private float OnMouseDown()
		{
			return 0f;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x59AED40", Offset = "0x59AD940", VA = "0x1859AED40")]
		private float OnMouseDrag()
		{
			return 0f;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x59AEE90", Offset = "0x59ADA90", VA = "0x1859AEE90")]
		private float OnMouseUp()
		{
			return 0f;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x59AEF10", Offset = "0x59ADB10", VA = "0x1859AEF10")]
		private float OnRepaint()
		{
			return 0f;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x59AE270", Offset = "0x59ACE70", VA = "0x1859AE270")]
		private EventType CurrentEventType()
		{
			return EventType.MouseDown;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x59AE2B0", Offset = "0x59ACEB0", VA = "0x1859AE2B0")]
		private int CurrentScrollTroughSide()
		{
			return 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x59AE700", Offset = "0x59AD300", VA = "0x1859AE700")]
		private bool IsEmptySlider()
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x59AF810", Offset = "0x59AE410", VA = "0x1859AF810")]
		private bool SupportsPageMovements()
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x59AF520", Offset = "0x59AE120", VA = "0x1859AF520")]
		private float PageMovementValue()
		{
			return 0f;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x59AF5D0", Offset = "0x59AE1D0", VA = "0x1859AF5D0")]
		private float PageUpMovementBound()
		{
			return 0f;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x59AE2A0", Offset = "0x59ACEA0", VA = "0x1859AE2A0")]
		private Event CurrentEvent()
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x59AFAC0", Offset = "0x59AE6C0", VA = "0x1859AFAC0")]
		private float ValueForCurrentMousePosition()
		{
			return 0f;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x59AE200", Offset = "0x59ACE00", VA = "0x1859AE200")]
		private float Clamp(float value)
		{
			return 0f;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x59AF9A0", Offset = "0x59AE5A0", VA = "0x1859AF9A0")]
		private Rect ThumbSelectionRect()
		{
			return default(Rect);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x59AF7B0", Offset = "0x59AE3B0", VA = "0x1859AF7B0")]
		private void StartDraggingWithValue(float dragStartValue)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x59AF680", Offset = "0x59AE280", VA = "0x1859AF680")]
		private SliderState SliderState()
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x59AF870", Offset = "0x59AE470", VA = "0x1859AF870")]
		private Rect ThumbExtRect()
		{
			return default(Rect);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x59AF950", Offset = "0x59AE550", VA = "0x1859AF950")]
		private Rect ThumbRect()
		{
			return default(Rect);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x59AFD10", Offset = "0x59AE910", VA = "0x1859AFD10")]
		private Rect VerticalThumbRect()
		{
			return default(Rect);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x59AE430", Offset = "0x59AD030", VA = "0x1859AE430")]
		private Rect HorizontalThumbRect()
		{
			return default(Rect);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x59AE230", Offset = "0x59ACE30", VA = "0x1859AE230")]
		private float ClampedCurrentValue()
		{
			return 0f;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x59AE750", Offset = "0x59AD350", VA = "0x1859AE750")]
		private float MousePosition()
		{
			return 0f;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x59AFC30", Offset = "0x59AE830", VA = "0x1859AFC30")]
		private float ValuesPerPixel()
		{
			return 0f;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x59AF9F0", Offset = "0x59AE5F0", VA = "0x1859AF9F0")]
		private float ThumbSize()
		{
			return 0f;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x59AE720", Offset = "0x59AD320", VA = "0x1859AE720")]
		private float MaxValue()
		{
			return 0f;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x59AE740", Offset = "0x59AD340", VA = "0x1859AE740")]
		private float MinValue()
		{
			return 0f;
		}

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Rect position;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float currentValue;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly float size;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float start;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly float end;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly GUIStyle slider;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly GUIStyle thumb;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GUIStyle thumbExtent;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly bool horiz;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly int id;
	}
}
