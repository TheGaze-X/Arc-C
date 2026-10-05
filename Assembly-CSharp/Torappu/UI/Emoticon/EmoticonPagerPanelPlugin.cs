using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050DF RID: 20703
	[Token(Token = "0x20050DF")]
	public abstract class EmoticonPagerPanelPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E9C3 RID: 125379
		[Token(Token = "0x601E9C3")]
		public abstract float AdjustPagerRectHeight(EmoticonPagerPanelModel model);

		// Token: 0x0601E9C4 RID: 125380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9C4")]
		[Address(RVA = "0x183A950", Offset = "0x1839550", VA = "0x18183A950")]
		protected EmoticonPagerPanelPlugin()
		{
		}

		// Token: 0x04029050 RID: 168016
		[Token(Token = "0x4029050")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
