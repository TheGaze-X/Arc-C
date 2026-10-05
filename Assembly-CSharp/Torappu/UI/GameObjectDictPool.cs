using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003481 RID: 13441
	[Token(Token = "0x2003481")]
	public abstract class GameObjectDictPool<TObj> : AbstractGameObjectDictPool<TObj, TObj> where TObj : Component
	{
		// Token: 0x06015723 RID: 87843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015723")]
		protected sealed override void SetInstActive(TObj inst, bool active)
		{
		}

		// Token: 0x06015724 RID: 87844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015724")]
		protected GameObjectDictPool()
		{
		}

		// Token: 0x04019ACB RID: 105163
		[Token(Token = "0x4019ACB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetInstActive;

		// Token: 0x04019ACC RID: 105164
		[Token(Token = "0x4019ACC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
