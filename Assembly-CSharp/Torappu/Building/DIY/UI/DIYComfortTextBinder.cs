using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200197B RID: 6523
	[Token(Token = "0x200197B")]
	public class DIYComfortTextBinder : DataBinder<StringProperty>
	{
		// Token: 0x0600A3B4 RID: 41908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B4")]
		[Address(RVA = "0x31D82A0", Offset = "0x31D6EA0", VA = "0x1831D82A0", Slot = "7")]
		public override void OnValueChanged(StringProperty property)
		{
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B5")]
		[Address(RVA = "0x31D8360", Offset = "0x31D6F60", VA = "0x1831D8360")]
		public DIYComfortTextBinder()
		{
		}

		// Token: 0x04009A69 RID: 39529
		[Token(Token = "0x4009A69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _atomosPhereText;

		// Token: 0x04009A6A RID: 39530
		[Token(Token = "0x4009A6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009A6B RID: 39531
		[Token(Token = "0x4009A6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
