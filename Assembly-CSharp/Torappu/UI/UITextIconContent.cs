using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A35 RID: 14901
	[Token(Token = "0x2003A35")]
	public class UITextIconContent : MonoBehaviour
	{
		// Token: 0x0601784E RID: 96334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601784E")]
		[Address(RVA = "0xFD57C0", Offset = "0xFD43C0", VA = "0x180FD57C0")]
		private void Start()
		{
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0601784F RID: 96335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017850 RID: 96336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003859")]
		public string text
		{
			[Token(Token = "0x601784F")]
			[Address(RVA = "0xFD5900", Offset = "0xFD4500", VA = "0x180FD5900")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017850")]
			[Address(RVA = "0xFD59A0", Offset = "0xFD45A0", VA = "0x180FD59A0")]
			set
			{
			}
		}

		// Token: 0x06017851 RID: 96337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017851")]
		[Address(RVA = "0xFD57D0", Offset = "0xFD43D0", VA = "0x180FD57D0")]
		private void _UpdateState()
		{
		}

		// Token: 0x06017852 RID: 96338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017852")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UITextIconContent()
		{
		}

		// Token: 0x0401C672 RID: 116338
		[Token(Token = "0x401C672")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401C673 RID: 116339
		[Token(Token = "0x401C673")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;
	}
}
