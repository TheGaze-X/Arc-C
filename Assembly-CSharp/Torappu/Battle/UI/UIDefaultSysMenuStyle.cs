using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x020032EE RID: 13038
	[Token(Token = "0x20032EE")]
	public class UIDefaultSysMenuStyle : UIBattleSystemMenuPanel.StyleController
	{
		// Token: 0x06014B73 RID: 84851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B73")]
		[Address(RVA = "0xD28BB0", Offset = "0xD277B0", VA = "0x180D28BB0", Slot = "4")]
		public override void SetData(float progress, ref UIBattleSystemMenuPanel.BattleReward reward)
		{
		}

		// Token: 0x06014B74 RID: 84852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B74")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDefaultSysMenuStyle()
		{
		}

		// Token: 0x040189D3 RID: 100819
		[Token(Token = "0x40189D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UITextSlider _progressSlider;

		// Token: 0x040189D4 RID: 100820
		[Token(Token = "0x40189D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descriptionLabel;

		// Token: 0x040189D5 RID: 100821
		[Token(Token = "0x40189D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _giveUpLabel;

		// Token: 0x040189D6 RID: 100822
		[Token(Token = "0x40189D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBattleSystemMenuCostReturn _costReturnItem;
	}
}
