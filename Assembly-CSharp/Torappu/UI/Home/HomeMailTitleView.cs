using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C34 RID: 19508
	[Token(Token = "0x2004C34")]
	public class HomeMailTitleView : DataBinder<MailTitleViewProperty>, IHotfixable
	{
		// Token: 0x0601D4B1 RID: 119985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B1")]
		[Address(RVA = "0x16D4350", Offset = "0x16D2F50", VA = "0x1816D4350", Slot = "7")]
		public override void OnValueChanged(MailTitleViewProperty property)
		{
		}

		// Token: 0x0601D4B2 RID: 119986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4B2")]
		[Address(RVA = "0x16D4400", Offset = "0x16D3000", VA = "0x1816D4400")]
		public HomeMailTitleView()
		{
		}

		// Token: 0x04026889 RID: 157833
		[Token(Token = "0x4026889")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelMailArchive;

		// Token: 0x0402688A RID: 157834
		[Token(Token = "0x402688A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _trackPointMailArchive;

		// Token: 0x0402688B RID: 157835
		[Token(Token = "0x402688B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402688C RID: 157836
		[Token(Token = "0x402688C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
