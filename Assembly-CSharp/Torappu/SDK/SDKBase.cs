using System;
using Il2CppDummyDll;
using U8.SDK;
using UnityEngine;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014D9 RID: 5337
	[Token(Token = "0x20014D9")]
	[DisallowMultipleComponent]
	public abstract class SDKBase<T> : SingletonMonoBehaviour<T>, ISingletonNotAutoCreate, ISDKBase, IHotfixable where T : MonoBehaviour
	{
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06007B1D RID: 31517
		[Token(Token = "0x17000EAC")]
		public abstract IExternalPlugin externalPlugin { [Token(Token = "0x6007B1D")] get; }

		// Token: 0x06007B1E RID: 31518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B1E")]
		protected SDKBase()
		{
		}

		// Token: 0x04007954 RID: 31060
		[Token(Token = "0x4007954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
