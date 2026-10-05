using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200376D RID: 14189
	[Token(Token = "0x200376D")]
	public class UIStyleProvider : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601687C RID: 92284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601687C")]
		[Address(RVA = "0xF05080", Offset = "0xF03C80", VA = "0x180F05080")]
		public void Reset(UIStyle style, bool force = false)
		{
		}

		// Token: 0x0601687D RID: 92285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601687D")]
		[Address(RVA = "0xF04E70", Offset = "0xF03A70", VA = "0x180F04E70")]
		public void AddStyleListener(IUIStyleListener listener)
		{
		}

		// Token: 0x0601687E RID: 92286 RVA: 0x00091818 File Offset: 0x0008FA18
		[Token(Token = "0x601687E")]
		[Address(RVA = "0xF04FE0", Offset = "0xF03BE0", VA = "0x180F04FE0")]
		public bool RemoveStyleListener(IUIStyleListener listene)
		{
			return default(bool);
		}

		// Token: 0x0601687F RID: 92287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601687F")]
		[Address(RVA = "0xF05290", Offset = "0xF03E90", VA = "0x180F05290")]
		public UIStyleProvider()
		{
		}

		// Token: 0x0401B240 RID: 111168
		[Token(Token = "0x401B240")]
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		[Group("TestTool")]
		[Inspect]
		private UIStyle m_style;

		// Token: 0x0401B241 RID: 111169
		[Token(Token = "0x401B241")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<IUIStyleListener> m_listeners;

		// Token: 0x0401B242 RID: 111170
		[Token(Token = "0x401B242")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401B243 RID: 111171
		[Token(Token = "0x401B243")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddStyleListener;

		// Token: 0x0401B244 RID: 111172
		[Token(Token = "0x401B244")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RemoveStyleListener;

		// Token: 0x0401B245 RID: 111173
		[Token(Token = "0x401B245")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
