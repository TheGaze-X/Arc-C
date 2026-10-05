using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200348C RID: 13452
	[Token(Token = "0x200348C")]
	[RequireComponent(typeof(Image))]
	public class ImageDataBinder : DataBinder<SpriteProperty>
	{
		// Token: 0x06015743 RID: 87875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015743")]
		[Address(RVA = "0xDEA610", Offset = "0xDE9210", VA = "0x180DEA610")]
		protected void Start()
		{
		}

		// Token: 0x06015744 RID: 87876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015744")]
		[Address(RVA = "0xDEA530", Offset = "0xDE9130", VA = "0x180DEA530", Slot = "7")]
		public override void OnValueChanged(SpriteProperty property)
		{
		}

		// Token: 0x06015745 RID: 87877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015745")]
		[Address(RVA = "0xDEA690", Offset = "0xDE9290", VA = "0x180DEA690")]
		public ImageDataBinder()
		{
		}

		// Token: 0x04019AED RID: 105197
		[Token(Token = "0x4019AED")]
		[FieldOffset(Offset = "0x20")]
		private Image m_image;

		// Token: 0x04019AEE RID: 105198
		[Token(Token = "0x4019AEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04019AEF RID: 105199
		[Token(Token = "0x4019AEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04019AF0 RID: 105200
		[Token(Token = "0x4019AF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
