using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005343 RID: 21315
	[Token(Token = "0x2005343")]
	public class RoguelikeMenuViewRenderer<TValue> : IRoguelikeMenuViewRenderer, IHotfixable
	{
		// Token: 0x0601F6F0 RID: 128752 RVA: 0x000B1E88 File Offset: 0x000B0088
		[Token(Token = "0x601F6F0")]
		private bool _Equals(TValue a, TValue b)
		{
			return default(bool);
		}

		// Token: 0x0601F6F1 RID: 128753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6F1")]
		public RoguelikeMenuViewRenderer(RoguelikeMenuViewRenderer<TValue>.Getter getter, Action<TValue, bool> renderAction)
		{
		}

		// Token: 0x0601F6F2 RID: 128754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6F2")]
		public void Update()
		{
		}

		// Token: 0x0601F6F3 RID: 128755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6F3")]
		public void Render(bool fastMode)
		{
		}

		// Token: 0x0601F6F4 RID: 128756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6F4")]
		public void Render(bool fastMode, out TValue lastRenderValue, out TValue currRenderValue)
		{
		}

		// Token: 0x0402A4A0 RID: 173216
		[Token(Token = "0x402A4A0")]
		[FieldOffset(Offset = "0x0")]
		private Action<TValue, bool> m_renderAction;

		// Token: 0x0402A4A1 RID: 173217
		[Token(Token = "0x402A4A1")]
		[FieldOffset(Offset = "0x0")]
		private RoguelikeMenuViewRenderer<TValue>.Getter m_getter;

		// Token: 0x0402A4A2 RID: 173218
		[Token(Token = "0x402A4A2")]
		[FieldOffset(Offset = "0x0")]
		private TValue m_cachedValue;

		// Token: 0x0402A4A3 RID: 173219
		[Token(Token = "0x402A4A3")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isDirty;

		// Token: 0x0402A4A4 RID: 173220
		[Token(Token = "0x402A4A4")]
		[FieldOffset(Offset = "0x0")]
		private TValue m_lastRenderValue;

		// Token: 0x0402A4A5 RID: 173221
		[Token(Token = "0x402A4A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Equals;

		// Token: 0x0402A4A6 RID: 173222
		[Token(Token = "0x402A4A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402A4A7 RID: 173223
		[Token(Token = "0x402A4A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402A4A8 RID: 173224
		[Token(Token = "0x402A4A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A4A9 RID: 173225
		[Token(Token = "0x402A4A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x02005344 RID: 21316
		// (Invoke) Token: 0x0601F6F6 RID: 128758
		[Token(Token = "0x2005344")]
		public delegate TValue Getter();
	}
}
