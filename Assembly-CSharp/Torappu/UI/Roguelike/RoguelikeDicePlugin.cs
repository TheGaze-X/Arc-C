using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051F5 RID: 20981
	[Token(Token = "0x20051F5")]
	public abstract class RoguelikeDicePlugin : DataBinder<RoguelikeDiceModelProperty>
	{
		// Token: 0x0601EF99 RID: 126873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF99")]
		[Address(RVA = "0x18B28B0", Offset = "0x18B14B0", VA = "0x1818B28B0", Slot = "7")]
		public override void OnValueChanged(RoguelikeDiceModelProperty property)
		{
		}

		// Token: 0x0601EF9A RID: 126874
		[Token(Token = "0x601EF9A")]
		protected abstract void OnRefresh();

		// Token: 0x0601EF9B RID: 126875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF9B")]
		[Address(RVA = "0x18B2940", Offset = "0x18B1540", VA = "0x1818B2940")]
		protected RoguelikeDicePlugin()
		{
		}

		// Token: 0x04029909 RID: 170249
		[Token(Token = "0x4029909")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402990A RID: 170250
		[Token(Token = "0x402990A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
