using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004728 RID: 18216
	[Token(Token = "0x2004728")]
	public class RecruitBuildTagView : MonoBehaviour
	{
		// Token: 0x0601B9BF RID: 113087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9BF")]
		[Address(RVA = "0x14F96C0", Offset = "0x14F82C0", VA = "0x1814F96C0")]
		public void Render(BuildTagModel tagModel)
		{
		}

		// Token: 0x0601B9C0 RID: 113088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C0")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitBuildTagView()
		{
		}

		// Token: 0x04023C8E RID: 146574
		[Token(Token = "0x4023C8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _activeBkg;

		// Token: 0x04023C8F RID: 146575
		[Token(Token = "0x4023C8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _inactiveBkg;

		// Token: 0x04023C90 RID: 146576
		[Token(Token = "0x4023C90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04023C91 RID: 146577
		[Token(Token = "0x4023C91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _inactiveFtg;
	}
}
