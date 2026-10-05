using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038A6 RID: 14502
	[Token(Token = "0x20038A6")]
	public class UIUniWebViewInstCenter : SingletonMonoBehaviour<UIUniWebViewInstCenter>, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x06016F23 RID: 93987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F23")]
		[Address(RVA = "0xF685E0", Offset = "0xF671E0", VA = "0x180F685E0")]
		public UIUniWebViewInstCenter()
		{
		}

		// Token: 0x0401BB20 RID: 113440
		[Token(Token = "0x401BB20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _instHolder;

		// Token: 0x0401BB21 RID: 113441
		[Token(Token = "0x401BB21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
