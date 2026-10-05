using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019AA RID: 6570
	[Token(Token = "0x20019AA")]
	public class DIYThemePanelTextBinder : DataBinder<DIYViewListProperty>
	{
		// Token: 0x0600A4F7 RID: 42231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4F7")]
		[Address(RVA = "0x31F7880", Offset = "0x31F6480", VA = "0x1831F7880", Slot = "7")]
		public override void OnValueChanged(DIYViewListProperty property)
		{
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4F8")]
		[Address(RVA = "0x31F79F0", Offset = "0x31F65F0", VA = "0x1831F79F0")]
		private void _SetTitleText()
		{
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4F9")]
		[Address(RVA = "0x31F7C50", Offset = "0x31F6850", VA = "0x1831F7C50")]
		public DIYThemePanelTextBinder()
		{
		}

		// Token: 0x04009C44 RID: 40004
		[Token(Token = "0x4009C44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04009C45 RID: 40005
		[Token(Token = "0x4009C45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _themeLine;

		// Token: 0x04009C46 RID: 40006
		[Token(Token = "0x4009C46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _themeText;

		// Token: 0x04009C47 RID: 40007
		[Token(Token = "0x4009C47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009C48 RID: 40008
		[Token(Token = "0x4009C48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetTitleText;

		// Token: 0x04009C49 RID: 40009
		[Token(Token = "0x4009C49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
