using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F74 RID: 24436
	[Token(Token = "0x2005F74")]
	public class CharacterInfoBuildingBuffUpgradeNotifyView : UINotifyView<CharacterInfoBuildingBuffUpgradeNotifyView.Param>
	{
		// Token: 0x060235E9 RID: 144873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235E9")]
		[Address(RVA = "0x1DFE740", Offset = "0x1DFD340", VA = "0x181DFE740", Slot = "9")]
		protected override void Render(CharacterInfoBuildingBuffUpgradeNotifyView.Param param)
		{
		}

		// Token: 0x060235EA RID: 144874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235EA")]
		[Address(RVA = "0x1DFEAB0", Offset = "0x1DFD6B0", VA = "0x181DFEAB0")]
		public CharacterInfoBuildingBuffUpgradeNotifyView()
		{
		}

		// Token: 0x04030D9D RID: 200093
		[Token(Token = "0x4030D9D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04030D9E RID: 200094
		[Token(Token = "0x4030D9E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x04030D9F RID: 200095
		[Token(Token = "0x4030D9F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04030DA0 RID: 200096
		[Token(Token = "0x4030DA0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _bkg;

		// Token: 0x04030DA1 RID: 200097
		[Token(Token = "0x4030DA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DA2 RID: 200098
		[Token(Token = "0x4030DA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F75 RID: 24437
		[Token(Token = "0x2005F75")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060235EB RID: 144875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235EB")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04030DA3 RID: 200099
			[Token(Token = "0x4030DA3")]
			[FieldOffset(Offset = "0x10")]
			public string buffId;
		}
	}
}
