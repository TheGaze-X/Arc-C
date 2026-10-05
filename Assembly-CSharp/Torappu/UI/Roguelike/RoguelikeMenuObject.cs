using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005340 RID: 21312
	[Token(Token = "0x2005340")]
	public abstract class RoguelikeMenuObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x0601F6DD RID: 128733
		[Token(Token = "0x170049B2")]
		public abstract RoguelikeMenuType menuType { [Token(Token = "0x601F6DD")] get; }

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x0601F6DE RID: 128734
		[Token(Token = "0x170049B3")]
		public abstract Type viewModelType { [Token(Token = "0x601F6DE")] get; }

		// Token: 0x0601F6DF RID: 128735
		[Token(Token = "0x601F6DF")]
		public abstract void DoRender(RoguelikeMenuCompViewModel viewModel);

		// Token: 0x0601F6E0 RID: 128736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E0")]
		[Address(RVA = "0x1929220", Offset = "0x1927E20", VA = "0x181929220", Slot = "7")]
		public virtual void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F6E1 RID: 128737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E1")]
		[Address(RVA = "0x1929100", Offset = "0x1927D00", VA = "0x181929100", Slot = "8")]
		public virtual void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x0601F6E2 RID: 128738 RVA: 0x000B1E70 File Offset: 0x000B0070
		[Token(Token = "0x601F6E2")]
		[Address(RVA = "0x1928F90", Offset = "0x1927B90", VA = "0x181928F90", Slot = "9")]
		public virtual bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x0601F6E3 RID: 128739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E3")]
		[Address(RVA = "0x1929180", Offset = "0x1927D80", VA = "0x181929180", Slot = "10")]
		public virtual void OpenSelf()
		{
		}

		// Token: 0x0601F6E4 RID: 128740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E4")]
		[Address(RVA = "0x1928D50", Offset = "0x1927950", VA = "0x181928D50", Slot = "11")]
		public virtual void CloseSelf()
		{
		}

		// Token: 0x0601F6E5 RID: 128741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E5")]
		[Address(RVA = "0x1929020", Offset = "0x1927C20", VA = "0x181929020", Slot = "12")]
		public virtual void OnClick()
		{
		}

		// Token: 0x0601F6E6 RID: 128742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E6")]
		[Address(RVA = "0x1928F10", Offset = "0x1927B10", VA = "0x181928F10", Slot = "13")]
		public virtual void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F6E7 RID: 128743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F6E7")]
		[Address(RVA = "0x1928E50", Offset = "0x1927A50", VA = "0x181928E50", Slot = "14")]
		public virtual List<RoguelikeMenuEffect> CollectMenuEffectPrefabs()
		{
			return null;
		}

		// Token: 0x0601F6E8 RID: 128744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E8")]
		[Address(RVA = "0x1928EB0", Offset = "0x1927AB0", VA = "0x181928EB0", Slot = "15")]
		public virtual void DispatchMenuEffects(List<RoguelikeMenuEffect> instanceList)
		{
		}

		// Token: 0x0601F6E9 RID: 128745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6E9")]
		[Address(RVA = "0x19292B0", Offset = "0x1927EB0", VA = "0x1819292B0")]
		protected RoguelikeMenuObject()
		{
		}

		// Token: 0x0402A491 RID: 173201
		[Token(Token = "0x402A491")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public RoguelikeMenuBar bindMenuBar;

		// Token: 0x0402A492 RID: 173202
		[Token(Token = "0x402A492")]
		[FieldOffset(Offset = "0x20")]
		protected RoguelikeMenuType currSelectedType;

		// Token: 0x0402A493 RID: 173203
		[Token(Token = "0x402A493")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A494 RID: 173204
		[Token(Token = "0x402A494")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402A495 RID: 173205
		[Token(Token = "0x402A495")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsSelected;

		// Token: 0x0402A496 RID: 173206
		[Token(Token = "0x402A496")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenSelf;

		// Token: 0x0402A497 RID: 173207
		[Token(Token = "0x402A497")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CloseSelf;

		// Token: 0x0402A498 RID: 173208
		[Token(Token = "0x402A498")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A499 RID: 173209
		[Token(Token = "0x402A499")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A49A RID: 173210
		[Token(Token = "0x402A49A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CollectMenuEffectPrefabs;

		// Token: 0x0402A49B RID: 173211
		[Token(Token = "0x402A49B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DispatchMenuEffects;

		// Token: 0x0402A49C RID: 173212
		[Token(Token = "0x402A49C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
