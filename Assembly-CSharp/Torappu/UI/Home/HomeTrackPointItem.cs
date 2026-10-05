using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B30 RID: 19248
	[Token(Token = "0x2004B30")]
	public abstract class HomeTrackPointItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601CFF0 RID: 118768
		[Token(Token = "0x601CFF0")]
		public abstract void Render(ITrackPointModel model);

		// Token: 0x0601CFF1 RID: 118769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF1")]
		[Address(RVA = "0x1679A90", Offset = "0x1678690", VA = "0x181679A90")]
		protected HomeTrackPointItem()
		{
		}

		// Token: 0x0402607F RID: 155775
		[Token(Token = "0x402607F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
