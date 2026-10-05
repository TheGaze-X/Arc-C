using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019AF RID: 6575
	[Token(Token = "0x20019AF")]
	public class DIYViewListExpandButtonBinder : DataBinder<DIYViewListProperty>
	{
		// Token: 0x0600A52C RID: 42284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52C")]
		[Address(RVA = "0x31FB350", Offset = "0x31F9F50", VA = "0x1831FB350", Slot = "7")]
		public override void OnValueChanged(DIYViewListProperty property)
		{
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52D")]
		[Address(RVA = "0x31FB410", Offset = "0x31FA010", VA = "0x1831FB410")]
		public DIYViewListExpandButtonBinder()
		{
		}

		// Token: 0x04009C90 RID: 40080
		[Token(Token = "0x4009C90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconOnExpand;

		// Token: 0x04009C91 RID: 40081
		[Token(Token = "0x4009C91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _iconOnFold;

		// Token: 0x04009C92 RID: 40082
		[Token(Token = "0x4009C92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009C93 RID: 40083
		[Token(Token = "0x4009C93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
