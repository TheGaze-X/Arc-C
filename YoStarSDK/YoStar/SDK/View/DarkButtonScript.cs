using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public class DarkButtonScript : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x5C26D30", Offset = "0x5C25930", VA = "0x185C26D30")]
		private void Awake()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x5C26F70", Offset = "0x5C25B70", VA = "0x185C26F70")]
		private void Normal()
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x5C27190", Offset = "0x5C25D90", VA = "0x185C27190", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x5C27220", Offset = "0x5C25E20", VA = "0x185C27220", Slot = "4")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x5C26DE0", Offset = "0x5C259E0", VA = "0x185C26DE0")]
		private void DisableStatus()
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DarkButtonScript()
		{
		}

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x18")]
		private Button button;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x20")]
		private Image image;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x28")]
		private Text text;
	}
}
