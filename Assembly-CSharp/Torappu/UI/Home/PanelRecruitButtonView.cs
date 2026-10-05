using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C44 RID: 19524
	[Token(Token = "0x2004C44")]
	public class PanelRecruitButtonView : MonoBehaviour
	{
		// Token: 0x0601D4F5 RID: 120053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4F5")]
		[Address(RVA = "0x16F2DD0", Offset = "0x16F19D0", VA = "0x1816F2DD0")]
		public void SetData(bool recruiting, int countdownInSec)
		{
		}

		// Token: 0x0601D4F6 RID: 120054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4F6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PanelRecruitButtonView()
		{
		}

		// Token: 0x04026905 RID: 157957
		[Token(Token = "0x4026905")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _recruitNotice;

		// Token: 0x04026906 RID: 157958
		[Token(Token = "0x4026906")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countdownLabel;
	}
}
