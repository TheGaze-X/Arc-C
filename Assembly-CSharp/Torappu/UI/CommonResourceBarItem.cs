using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200391B RID: 14619
	[Token(Token = "0x200391B")]
	public class CommonResourceBarItem : MonoBehaviour
	{
		// Token: 0x060171AF RID: 94639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AF")]
		[Address(RVA = "0xF70B10", Offset = "0xF6F710", VA = "0x180F70B10")]
		public void Render(bool isShow, string content)
		{
		}

		// Token: 0x060171B0 RID: 94640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B0")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CommonResourceBarItem()
		{
		}

		// Token: 0x0401BE41 RID: 114241
		[Token(Token = "0x401BE41")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textContent;
	}
}
