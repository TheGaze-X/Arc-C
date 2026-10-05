using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace YoStar.SDK.UI
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	public class MouseHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000C3")]
		public UnityAction onPointerEnter
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000C4")]
		public UnityAction onPointerExit
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x5134D0", Offset = "0x5120D0", VA = "0x1805134D0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x5134F0", Offset = "0x5120F0", VA = "0x1805134F0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MouseHover()
		{
		}
	}
}
