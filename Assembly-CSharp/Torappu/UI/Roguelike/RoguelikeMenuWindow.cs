using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005345 RID: 21317
	[Token(Token = "0x2005345")]
	public abstract class RoguelikeMenuWindow : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x0601F6F9 RID: 128761
		[Token(Token = "0x170049B5")]
		public abstract RoguelikeMenuType selectType { [Token(Token = "0x601F6F9")] get; }

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x0601F6FA RID: 128762
		[Token(Token = "0x170049B6")]
		public abstract Type viewModelType { [Token(Token = "0x601F6FA")] get; }

		// Token: 0x0601F6FB RID: 128763
		[Token(Token = "0x601F6FB")]
		public abstract void DoRender(RoguelikeMenuCompViewModel viewModel);

		// Token: 0x0601F6FC RID: 128764 RVA: 0x000B1EA0 File Offset: 0x000B00A0
		[Token(Token = "0x601F6FC")]
		[Address(RVA = "0x192B540", Offset = "0x192A140", VA = "0x18192B540", Slot = "7")]
		public virtual bool IsSelected(RoguelikeMenuType type)
		{
			return default(bool);
		}

		// Token: 0x0601F6FD RID: 128765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6FD")]
		[Address(RVA = "0x192B5F0", Offset = "0x192A1F0", VA = "0x18192B5F0", Slot = "8")]
		public virtual void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F6FE RID: 128766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F6FE")]
		[Address(RVA = "0x192B2F0", Offset = "0x1929EF0", VA = "0x18192B2F0", Slot = "9")]
		protected virtual UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F6FF RID: 128767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6FF")]
		[Address(RVA = "0x192B470", Offset = "0x192A070", VA = "0x18192B470")]
		public void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F700 RID: 128768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F700")]
		[Address(RVA = "0x192B760", Offset = "0x192A360", VA = "0x18192B760")]
		protected RoguelikeMenuWindow()
		{
		}

		// Token: 0x0402A4AA RID: 173226
		[Token(Token = "0x402A4AA")]
		[FieldOffset(Offset = "0x0")]
		protected static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A4AB RID: 173227
		[Token(Token = "0x402A4AB")]
		[FieldOffset(Offset = "0x8")]
		protected static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A4AC RID: 173228
		[Token(Token = "0x402A4AC")]
		[FieldOffset(Offset = "0x18")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402A4AD RID: 173229
		[Token(Token = "0x402A4AD")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public RoguelikeMenuBar bindMenuBar;

		// Token: 0x0402A4AE RID: 173230
		[Token(Token = "0x402A4AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsSelected;

		// Token: 0x0402A4AF RID: 173231
		[Token(Token = "0x402A4AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A4B0 RID: 173232
		[Token(Token = "0x402A4B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A4B1 RID: 173233
		[Token(Token = "0x402A4B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A4B2 RID: 173234
		[Token(Token = "0x402A4B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
