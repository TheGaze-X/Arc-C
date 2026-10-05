using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x02006982 RID: 27010
	[Token(Token = "0x2006982")]
	public class StageStartBattleETButton : MonoBehaviour
	{
		// Token: 0x06026A5B RID: 158299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A5B")]
		[Address(RVA = "0x21BC930", Offset = "0x21BB530", VA = "0x1821BC930")]
		public void SetStartBattleEvent(Button.ButtonClickedEvent clickEvent)
		{
		}

		// Token: 0x06026A5C RID: 158300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A5C")]
		[Address(RVA = "0x21BC740", Offset = "0x21BB340", VA = "0x1821BC740")]
		public void Render(PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026A5D RID: 158301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A5D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageStartBattleETButton()
		{
		}

		// Token: 0x04036902 RID: 223490
		[Token(Token = "0x4036902")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _btnStartBattle;

		// Token: 0x04036903 RID: 223491
		[Token(Token = "0x4036903")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bkgCost;

		// Token: 0x04036904 RID: 223492
		[Token(Token = "0x4036904")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgStartBattle;

		// Token: 0x04036905 RID: 223493
		[Token(Token = "0x4036905")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEtCost;

		// Token: 0x04036906 RID: 223494
		[Token(Token = "0x4036906")]
		[FieldOffset(Offset = "0x38")]
		private string m_styleId;
	}
}
