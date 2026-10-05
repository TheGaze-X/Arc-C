using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public class CustomTextColor : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5C86AA0", Offset = "0x5C856A0", VA = "0x185C86AA0")]
		private void Start()
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5C86940", Offset = "0x5C85540", VA = "0x185C86940", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5C869F0", Offset = "0x5C855F0", VA = "0x185C869F0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x5C86B60", Offset = "0x5C85760", VA = "0x185C86B60")]
		public CustomTextColor()
		{
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x18")]
		private Text textComponent;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x20")]
		public Color normalColor;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x30")]
		public Color hoverColor;
	}
}
