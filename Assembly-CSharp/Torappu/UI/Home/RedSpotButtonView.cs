using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C47 RID: 19527
	[Token(Token = "0x2004C47")]
	[RequireComponent(typeof(Button))]
	public class RedSpotButtonView : MonoBehaviour
	{
		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x0601D4FD RID: 120061 RVA: 0x000AB2B8 File Offset: 0x000A94B8
		// (set) Token: 0x0601D4FE RID: 120062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044DC")]
		public bool interactable
		{
			[Token(Token = "0x601D4FD")]
			[Address(RVA = "0x16F3A70", Offset = "0x16F2670", VA = "0x1816F3A70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D4FE")]
			[Address(RVA = "0x16F3AD0", Offset = "0x16F26D0", VA = "0x1816F3AD0")]
			set
			{
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x0601D4FF RID: 120063 RVA: 0x000AB2D0 File Offset: 0x000A94D0
		// (set) Token: 0x0601D500 RID: 120064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044DD")]
		public bool highlighted
		{
			[Token(Token = "0x601D4FF")]
			[Address(RVA = "0x16F3A00", Offset = "0x16F2600", VA = "0x1816F3A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D500")]
			[Address(RVA = "0x16F3AC0", Offset = "0x16F26C0", VA = "0x1816F3AC0")]
			set
			{
			}
		}

		// Token: 0x0601D501 RID: 120065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D501")]
		[Address(RVA = "0x16F3980", Offset = "0x16F2580", VA = "0x1816F3980")]
		private void _UpdateRedSpot()
		{
		}

		// Token: 0x0601D502 RID: 120066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D502")]
		[Address(RVA = "0x16F3920", Offset = "0x16F2520", VA = "0x1816F3920")]
		private void Awake()
		{
		}

		// Token: 0x0601D503 RID: 120067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D503")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RedSpotButtonView()
		{
		}

		// Token: 0x04026912 RID: 157970
		[Token(Token = "0x4026912")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _redSpot;

		// Token: 0x04026913 RID: 157971
		[Token(Token = "0x4026913")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _highlightedOnAwake;

		// Token: 0x04026914 RID: 157972
		[Token(Token = "0x4026914")]
		[FieldOffset(Offset = "0x28")]
		private Button m_button;

		// Token: 0x04026915 RID: 157973
		[Token(Token = "0x4026915")]
		[FieldOffset(Offset = "0x30")]
		private bool m_highlighted;
	}
}
