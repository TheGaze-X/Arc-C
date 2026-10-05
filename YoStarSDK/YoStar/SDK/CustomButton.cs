using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public class CustomButton : Button, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06000367 RID: 871 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x5C09AC0", Offset = "0x5C086C0", VA = "0x185C09AC0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x5C09CF0", Offset = "0x5C088F0", VA = "0x185C09CF0")]
		private void Update()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x5C094C0", Offset = "0x5C080C0", VA = "0x185C094C0", Slot = "36")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x5C09680", Offset = "0x5C08280", VA = "0x185C09680", Slot = "37")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x5C09BE0", Offset = "0x5C087E0", VA = "0x185C09BE0")]
		private void UpdateVisualState()
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x5C099A0", Offset = "0x5C085A0", VA = "0x185C099A0")]
		public void SetupOutLine()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x5C09840", Offset = "0x5C08440", VA = "0x185C09840")]
		public void SetupDefault()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x5C09D10", Offset = "0x5C08910", VA = "0x185C09D10")]
		public CustomButton()
		{
		}

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x100")]
		public Text buttonText;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x108")]
		protected bool lastInteractable;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x110")]
		private readonly string outlinePath;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x118")]
		private readonly string bgPath;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x120")]
		private Color buttonTextColor;
	}
}
