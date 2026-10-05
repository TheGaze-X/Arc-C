using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public class YoTextFiledScript : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x5C55540", Offset = "0x5C54140", VA = "0x185C55540", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x5C55160", Offset = "0x5C53D60", VA = "0x185C55160")]
		private void Awake()
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x5C555C0", Offset = "0x5C541C0", VA = "0x185C555C0")]
		private void Update()
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x5C55500", Offset = "0x5C54100", VA = "0x185C55500")]
		private void OnEndEdit(string text)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x5C558F0", Offset = "0x5C544F0", VA = "0x185C558F0")]
		public YoTextFiledScript()
		{
		}

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x18")]
		private Outline outline;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x20")]
		private Color editingColor;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x30")]
		private Color endEditColor;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x40")]
		private InputField inputField;
	}
}
