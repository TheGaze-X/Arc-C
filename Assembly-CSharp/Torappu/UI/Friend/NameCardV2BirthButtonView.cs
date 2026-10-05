using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E03 RID: 19971
	[Token(Token = "0x2004E03")]
	public class NameCardV2BirthButtonView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DD8C RID: 122252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8C")]
		[Address(RVA = "0x1773610", Offset = "0x1772210", VA = "0x181773610", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DD8D RID: 122253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8D")]
		[Address(RVA = "0x17736D0", Offset = "0x17722D0", VA = "0x1817736D0")]
		public void SetBirth()
		{
		}

		// Token: 0x0601DD8E RID: 122254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8E")]
		[Address(RVA = "0x1773760", Offset = "0x1772360", VA = "0x181773760")]
		public NameCardV2BirthButtonView()
		{
		}

		// Token: 0x040278CE RID: 161998
		[Token(Token = "0x40278CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _setBirthGo;

		// Token: 0x040278CF RID: 161999
		[Token(Token = "0x40278CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _setBirthTrackPoint;

		// Token: 0x040278D0 RID: 162000
		[Token(Token = "0x40278D0")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040278D1 RID: 162001
		[Token(Token = "0x40278D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040278D2 RID: 162002
		[Token(Token = "0x40278D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetBirth;

		// Token: 0x040278D3 RID: 162003
		[Token(Token = "0x40278D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
