using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public class UISingletonInputController : SingletonMonoBehaviour<UISingletonInputController>, ISingletonNotAutoCreate
	{
		// Token: 0x06000953 RID: 2387 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x555FF30", Offset = "0x555EB30", VA = "0x18555FF30")]
		public void DisableEventSystem(bool disable, [Optional] string key)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5560020", Offset = "0x555EC20", VA = "0x185560020")]
		public UISingletonInputController()
		{
		}

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		public const string DEFAULT_EVENT_SYSTEM_KEY = "UISingletonInputController";

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem _eventSystem;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EnableStateWithKey m_disableEventSystem;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate198 __Hotfix0_DisableEventSystem;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
