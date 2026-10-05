using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E0E RID: 19982
	[Token(Token = "0x2004E0E")]
	public class NameCardV2MagazineButtonView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DDB8 RID: 122296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB8")]
		[Address(RVA = "0x1776240", Offset = "0x1774E40", VA = "0x181776240", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DDB9 RID: 122297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDB9")]
		[Address(RVA = "0x1776320", Offset = "0x1774F20", VA = "0x181776320")]
		public void OpenMagazineCoverPage()
		{
		}

		// Token: 0x0601DDBA RID: 122298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDBA")]
		[Address(RVA = "0x17763B0", Offset = "0x1774FB0", VA = "0x1817763B0")]
		public NameCardV2MagazineButtonView()
		{
		}

		// Token: 0x04027939 RID: 162105
		[Token(Token = "0x4027939")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objAdd;

		// Token: 0x0402793A RID: 162106
		[Token(Token = "0x402793A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objEdit;

		// Token: 0x0402793B RID: 162107
		[Token(Token = "0x402793B")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402793C RID: 162108
		[Token(Token = "0x402793C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402793D RID: 162109
		[Token(Token = "0x402793D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenMagazineCoverPage;

		// Token: 0x0402793E RID: 162110
		[Token(Token = "0x402793E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
