using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007252 RID: 29266
	[Token(Token = "0x2007252")]
	[Serializable]
	public class Act5D1ShopDetailCommonStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060297A9 RID: 169897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297A9")]
		[Address(RVA = "0x24E8420", Offset = "0x24E7020", VA = "0x1824E8420")]
		public Act5D1ShopDetailCommonStateBean()
		{
		}

		// Token: 0x0403B43A RID: 242746
		[Token(Token = "0x403B43A")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public Act5D1ShopCommonViewModel model;

		// Token: 0x0403B43B RID: 242747
		[Token(Token = "0x403B43B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
