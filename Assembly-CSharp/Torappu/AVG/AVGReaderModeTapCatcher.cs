using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F65 RID: 8037
	[Token(Token = "0x2001F65")]
	public class AVGReaderModeTapCatcher : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IEndDragHandler, IHotfixable
	{
		// Token: 0x0600C7BB RID: 51131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BB")]
		[Address(RVA = "0x348D3A0", Offset = "0x348BFA0", VA = "0x18348D3A0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600C7BC RID: 51132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BC")]
		[Address(RVA = "0x348D440", Offset = "0x348C040", VA = "0x18348D440", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600C7BD RID: 51133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BD")]
		[Address(RVA = "0x348D2A0", Offset = "0x348BEA0", VA = "0x18348D2A0", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BE")]
		[Address(RVA = "0x348D320", Offset = "0x348BF20", VA = "0x18348D320", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7BF")]
		[Address(RVA = "0x348D5B0", Offset = "0x348C1B0", VA = "0x18348D5B0")]
		public AVGReaderModeTapCatcher()
		{
		}

		// Token: 0x0400CDD2 RID: 52690
		[Token(Token = "0x400CDD2")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onTap;

		// Token: 0x0400CDD3 RID: 52691
		[Token(Token = "0x400CDD3")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onDrag;

		// Token: 0x0400CDD4 RID: 52692
		[Token(Token = "0x400CDD4")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action onDragEnd;

		// Token: 0x0400CDD5 RID: 52693
		[Token(Token = "0x400CDD5")]
		[FieldOffset(Offset = "0x30")]
		private bool _isDragging;

		// Token: 0x0400CDD6 RID: 52694
		[Token(Token = "0x400CDD6")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 _pointerDownPos;

		// Token: 0x0400CDD7 RID: 52695
		[Token(Token = "0x400CDD7")]
		[FieldOffset(Offset = "0x3C")]
		private float _pointerDownTime;

		// Token: 0x0400CDD8 RID: 52696
		[Token(Token = "0x400CDD8")]
		private const float TAP_MAX_DISTANCE = 15f;

		// Token: 0x0400CDD9 RID: 52697
		[Token(Token = "0x400CDD9")]
		private const float TAP_MAX_TIME = 0.25f;

		// Token: 0x0400CDDA RID: 52698
		[Token(Token = "0x400CDDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0400CDDB RID: 52699
		[Token(Token = "0x400CDDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x0400CDDC RID: 52700
		[Token(Token = "0x400CDDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0400CDDD RID: 52701
		[Token(Token = "0x400CDDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x0400CDDE RID: 52702
		[Token(Token = "0x400CDDE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
