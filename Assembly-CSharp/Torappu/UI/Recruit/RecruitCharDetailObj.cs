using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004740 RID: 18240
	[Token(Token = "0x2004740")]
	public class RecruitCharDetailObj : MonoBehaviour
	{
		// Token: 0x0601BA2C RID: 113196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2C")]
		[Address(RVA = "0x14FB120", Offset = "0x14F9D20", VA = "0x1814FB120")]
		public void Render(string charId)
		{
		}

		// Token: 0x0601BA2D RID: 113197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA2D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitCharDetailObj()
		{
		}

		// Token: 0x04023D84 RID: 146820
		[Token(Token = "0x4023D84")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x04023D85 RID: 146821
		[Token(Token = "0x4023D85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backSquare;

		// Token: 0x04023D86 RID: 146822
		[Token(Token = "0x4023D86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charName;
	}
}
