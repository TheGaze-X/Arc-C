using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE8 RID: 19944
	[Token(Token = "0x2004DE8")]
	public class FriendNameCardMedalHolder : DataBinder<NameCardMedalSelectProperty>
	{
		// Token: 0x0601DD09 RID: 122121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD09")]
		[Address(RVA = "0x1751F60", Offset = "0x1750B60", VA = "0x181751F60", Slot = "7")]
		public override void OnValueChanged(NameCardMedalSelectProperty property)
		{
		}

		// Token: 0x0601DD0A RID: 122122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD0A")]
		[Address(RVA = "0x1752020", Offset = "0x1750C20", VA = "0x181752020")]
		public FriendNameCardMedalHolder()
		{
		}

		// Token: 0x040277B4 RID: 161716
		[Token(Token = "0x40277B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FriendNameCardMedalView _view;

		// Token: 0x040277B5 RID: 161717
		[Token(Token = "0x40277B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public UINameCardEvent onClickEvent;

		// Token: 0x040277B6 RID: 161718
		[Token(Token = "0x40277B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040277B7 RID: 161719
		[Token(Token = "0x40277B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
