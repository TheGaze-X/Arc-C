using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YoStar.SDK.UI
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class LoadingPanel : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x5C64730", Offset = "0x5C63330", VA = "0x185C64730")]
		private void Awake()
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x5C64A20", Offset = "0x5C63620", VA = "0x185C64A20")]
		public void StopAnimation()
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x5C64900", Offset = "0x5C63500", VA = "0x185C64900", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x5C64990", Offset = "0x5C63590", VA = "0x185C64990", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x5C64870", Offset = "0x5C63470", VA = "0x185C64870")]
		private void OnDisable()
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public LoadingPanel()
		{
		}

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x18")]
		private Animator animator;
	}
}
