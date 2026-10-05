using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E3A RID: 15930
	[Token(Token = "0x2003E3A")]
	public class SquadStartButtonView : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x06018C0C RID: 101388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0C")]
		[Address(RVA = "0x1180160", Offset = "0x117ED60", VA = "0x181180160", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x06018C0D RID: 101389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0D")]
		[Address(RVA = "0x1180250", Offset = "0x117EE50", VA = "0x181180250")]
		public SquadStartButtonView()
		{
		}

		// Token: 0x0401E6AE RID: 124590
		[Token(Token = "0x401E6AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SquadHomeStateBean _homeStateBean;

		// Token: 0x0401E6AF RID: 124591
		[Token(Token = "0x401E6AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _goDisabledStartBtn;

		// Token: 0x0401E6B0 RID: 124592
		[Token(Token = "0x401E6B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _goStartBtn;

		// Token: 0x0401E6B1 RID: 124593
		[Token(Token = "0x401E6B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _goStartImg;

		// Token: 0x0401E6B2 RID: 124594
		[Token(Token = "0x401E6B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E6B3 RID: 124595
		[Token(Token = "0x401E6B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
