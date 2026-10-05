using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006539 RID: 25913
	[Token(Token = "0x2006539")]
	public class ArtMagazineCoverOverviewHomeView : DataBinder<ArtMagazineCoverOverviewHomeViewModelProperty>
	{
		// Token: 0x060253E6 RID: 152550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E6")]
		[Address(RVA = "0x2033250", Offset = "0x2031E50", VA = "0x182033250", Slot = "7")]
		public override void OnValueChanged(ArtMagazineCoverOverviewHomeViewModelProperty property)
		{
		}

		// Token: 0x060253E7 RID: 152551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E7")]
		[Address(RVA = "0x20331C0", Offset = "0x2031DC0", VA = "0x1820331C0")]
		public void EventOnDisplayBtnClick()
		{
		}

		// Token: 0x060253E8 RID: 152552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253E8")]
		[Address(RVA = "0x2033510", Offset = "0x2032110", VA = "0x182033510")]
		public ArtMagazineCoverOverviewHomeView()
		{
		}

		// Token: 0x040343FE RID: 214014
		[Token(Token = "0x40343FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleDisplay;

		// Token: 0x040343FF RID: 214015
		[Token(Token = "0x40343FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDisplayBtnInfo;

		// Token: 0x04034400 RID: 214016
		[Token(Token = "0x4034400")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colFilterTxtAll;

		// Token: 0x04034401 RID: 214017
		[Token(Token = "0x4034401")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colFilterTxtDisplay;

		// Token: 0x04034402 RID: 214018
		[Token(Token = "0x4034402")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtMagazineCoverOverviewView _leafView;

		// Token: 0x04034403 RID: 214019
		[Token(Token = "0x4034403")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034404 RID: 214020
		[Token(Token = "0x4034404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034405 RID: 214021
		[Token(Token = "0x4034405")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnDisplayBtnClick;

		// Token: 0x04034406 RID: 214022
		[Token(Token = "0x4034406")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
