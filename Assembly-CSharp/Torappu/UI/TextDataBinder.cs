using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200348D RID: 13453
	[Token(Token = "0x200348D")]
	[RequireComponent(typeof(Text))]
	public class TextDataBinder : DataBinder<StringProperty>
	{
		// Token: 0x06015746 RID: 87878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015746")]
		[Address(RVA = "0xDEC580", Offset = "0xDEB180", VA = "0x180DEC580")]
		private Text GetText()
		{
			return null;
		}

		// Token: 0x06015747 RID: 87879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015747")]
		[Address(RVA = "0xDEC650", Offset = "0xDEB250", VA = "0x180DEC650", Slot = "7")]
		public override void OnValueChanged(StringProperty property)
		{
		}

		// Token: 0x06015748 RID: 87880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015748")]
		[Address(RVA = "0xDEC7F0", Offset = "0xDEB3F0", VA = "0x180DEC7F0")]
		public TextDataBinder()
		{
		}

		// Token: 0x04019AF1 RID: 105201
		[Token(Token = "0x4019AF1")]
		[FieldOffset(Offset = "0x20")]
		private Text m_text;

		// Token: 0x04019AF2 RID: 105202
		[Token(Token = "0x4019AF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetText;

		// Token: 0x04019AF3 RID: 105203
		[Token(Token = "0x4019AF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04019AF4 RID: 105204
		[Token(Token = "0x4019AF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
