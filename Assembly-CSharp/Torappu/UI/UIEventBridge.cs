using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200386C RID: 14444
	[Token(Token = "0x200386C")]
	public class UIEventBridge : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016DF1 RID: 93681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DF1")]
		[Address(RVA = "0xF5F2E0", Offset = "0xF5DEE0", VA = "0x180F5F2E0")]
		public void TriggerEventByBridge()
		{
		}

		// Token: 0x06016DF2 RID: 93682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DF2")]
		[Address(RVA = "0xF5F350", Offset = "0xF5DF50", VA = "0x180F5F350")]
		public UIEventBridge()
		{
		}

		// Token: 0x0401B968 RID: 113000
		[Token(Token = "0x401B968")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent _action;

		// Token: 0x0401B969 RID: 113001
		[Token(Token = "0x401B969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerEventByBridge;

		// Token: 0x0401B96A RID: 113002
		[Token(Token = "0x401B96A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
