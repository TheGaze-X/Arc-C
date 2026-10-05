using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public class DatePicker_HoldButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x06000784 RID: 1924 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x5C4A520", Offset = "0x5C49120", VA = "0x185C4A520")]
		private void Start()
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x5C4A500", Offset = "0x5C49100", VA = "0x185C4A500", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x5C4A510", Offset = "0x5C49110", VA = "0x185C4A510", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x5C4A8F0", Offset = "0x5C494F0", VA = "0x185C4A8F0")]
		private void Update()
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x5C4A480", Offset = "0x5C49080", VA = "0x185C4A480")]
		private void Execute()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x5C4A9A0", Offset = "0x5C495A0", VA = "0x185C4A9A0")]
		public DatePicker_HoldButton()
		{
		}

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x18")]
		public Button Button;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x20")]
		public float Delay;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x24")]
		private bool pointerDown;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x28")]
		private Action action;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x30")]
		private float lastInvokeTime;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x34")]
		private int executionCount;
	}
}
