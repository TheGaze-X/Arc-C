using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class ButtonHoverEffect : MonoBehaviour
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5C25510", Offset = "0x5C24110", VA = "0x185C25510")]
		private void Awake()
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000075")]
		public string ButtonTitle
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x5C25560", Offset = "0x5C24160", VA = "0x185C25560")]
			set
			{
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ButtonHoverEffect()
		{
		}

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x18")]
		private Text text;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x20")]
		private string buttonTitle;
	}
}
