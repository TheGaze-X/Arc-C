using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004731 RID: 18225
	[Token(Token = "0x2004731")]
	public class RecruitBuildConfigCostText : MonoBehaviour
	{
		// Token: 0x0601BA01 RID: 113153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA01")]
		[Address(RVA = "0x14F5BC0", Offset = "0x14F47C0", VA = "0x1814F5BC0")]
		public void Render(long curCount, long requireCount, ItemType type)
		{
		}

		// Token: 0x0601BA02 RID: 113154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA02")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitBuildConfigCostText()
		{
		}

		// Token: 0x04023D13 RID: 146707
		[Token(Token = "0x4023D13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _hilightColor;

		// Token: 0x04023D14 RID: 146708
		[Token(Token = "0x4023D14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bkgActive;

		// Token: 0x04023D15 RID: 146709
		[Token(Token = "0x4023D15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bkgInactive;

		// Token: 0x04023D16 RID: 146710
		[Token(Token = "0x4023D16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNum;
	}
}
