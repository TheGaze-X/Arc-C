using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A6 RID: 26790
	[Token(Token = "0x20068A6")]
	public class ActivityCustomZoneStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06026652 RID: 157266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026652")]
		[Address(RVA = "0x21781F0", Offset = "0x2176DF0", VA = "0x1821781F0")]
		public ActivityCustomZoneStateBean()
		{
		}

		// Token: 0x04036118 RID: 221464
		[Token(Token = "0x4036118")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public ActivityCustomZoneMapProperty mapProperty;

		// Token: 0x04036119 RID: 221465
		[Token(Token = "0x4036119")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
