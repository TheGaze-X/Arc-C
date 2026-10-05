using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x0200161A RID: 5658
	[Token(Token = "0x200161A")]
	public abstract class LuaUITransEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x06008085 RID: 32901
		[Token(Token = "0x6008085")]
		public abstract IEnumerator ShowCoroutine();

		// Token: 0x06008086 RID: 32902
		[Token(Token = "0x6008086")]
		public abstract IEnumerator HideCoroutine();

		// Token: 0x06008087 RID: 32903
		[Token(Token = "0x6008087")]
		public abstract void ShowImmediatly();

		// Token: 0x06008088 RID: 32904
		[Token(Token = "0x6008088")]
		public abstract void HideImmediatly();

		// Token: 0x06008089 RID: 32905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008089")]
		[Address(RVA = "0x2893720", Offset = "0x2892320", VA = "0x182893720")]
		protected LuaUITransEffect()
		{
		}

		// Token: 0x040081A7 RID: 33191
		[Token(Token = "0x40081A7")]
		public const float POP_SMOOTH_DELAY = 0.05f;

		// Token: 0x040081A8 RID: 33192
		[Token(Token = "0x40081A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
