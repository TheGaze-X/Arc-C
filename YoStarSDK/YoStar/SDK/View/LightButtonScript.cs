using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public class LightButtonScript : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x5C2B960", Offset = "0x5C2A560", VA = "0x185C2B960")]
		private void Awake()
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x5C2BD00", Offset = "0x5C2A900", VA = "0x185C2BD00", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x5C2BE70", Offset = "0x5C2AA70", VA = "0x185C2BE70", Slot = "4")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x5C2BC20", Offset = "0x5C2A820", VA = "0x185C2BC20")]
		private void DisableStatus()
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x5C2BFF0", Offset = "0x5C2ABF0", VA = "0x185C2BFF0")]
		private void Update()
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x5C2C210", Offset = "0x5C2AE10", VA = "0x185C2C210")]
		private void normalStatus()
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x5C2BA00", Offset = "0x5C2A600", VA = "0x185C2BA00")]
		private void DealImage()
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LightButtonScript()
		{
		}

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x18")]
		private Button button;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x20")]
		private Image image;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x28")]
		private Text text;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x30")]
		private bool enter;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x38")]
		private string imageName;
	}
}
