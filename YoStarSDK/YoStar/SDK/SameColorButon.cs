using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	public class SameColorButon : Button, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600036F RID: 879 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x5C155E0", Offset = "0x5C141E0", VA = "0x185C155E0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x5C15440", Offset = "0x5C14040", VA = "0x185C15440", Slot = "36")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x5C15510", Offset = "0x5C14110", VA = "0x185C15510", Slot = "37")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x5C15710", Offset = "0x5C14310", VA = "0x185C15710")]
		public SameColorButon()
		{
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x100")]
		private Text buttonText;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x108")]
		private Color _highlightedColor;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x118")]
		private Color _selectedColor;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x128")]
		private Color _normalColor;
	}
}
