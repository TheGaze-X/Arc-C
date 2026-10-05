using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053CE RID: 21454
	[Token(Token = "0x20053CE")]
	public class RoguelikeRewardState : PopupFadeState
	{
		// Token: 0x0601F92D RID: 129325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F92D")]
		[Address(RVA = "0x1942C20", Offset = "0x1941820", VA = "0x181942C20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F92E RID: 129326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F92E")]
		[Address(RVA = "0x1942C80", Offset = "0x1941880", VA = "0x181942C80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F92F")]
		[Address(RVA = "0x1942F20", Offset = "0x1941B20", VA = "0x181942F20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F930 RID: 129328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F930")]
		[Address(RVA = "0x1942EB0", Offset = "0x1941AB0", VA = "0x181942EB0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601F931 RID: 129329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F931")]
		[Address(RVA = "0x1942B30", Offset = "0x1941730", VA = "0x181942B30")]
		public void AddStateRelatedEffect(GameObject effectObj)
		{
		}

		// Token: 0x0601F932 RID: 129330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F932")]
		[Address(RVA = "0x1943010", Offset = "0x1941C10", VA = "0x181943010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F933 RID: 129331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F933")]
		[Address(RVA = "0x19433B0", Offset = "0x1941FB0", VA = "0x1819433B0")]
		private void _SetEffectsActive(bool isActive)
		{
		}

		// Token: 0x0601F934 RID: 129332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F934")]
		[Address(RVA = "0x1942E00", Offset = "0x1941A00", VA = "0x181942E00")]
		public void OnListClick()
		{
		}

		// Token: 0x0601F935 RID: 129333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F935")]
		[Address(RVA = "0x19434B0", Offset = "0x19420B0", VA = "0x1819434B0")]
		public RoguelikeRewardState()
		{
		}

		// Token: 0x0601F936 RID: 129334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F936")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F937 RID: 129335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F937")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F938 RID: 129336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F938")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402A820 RID: 174112
		[Token(Token = "0x402A820")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeRewardStateBean m_stateBean;

		// Token: 0x0402A821 RID: 174113
		[Token(Token = "0x402A821")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402A822 RID: 174114
		[Token(Token = "0x402A822")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeRewardEntryView _entryView;

		// Token: 0x0402A823 RID: 174115
		[Token(Token = "0x402A823")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0402A824 RID: 174116
		[Token(Token = "0x402A824")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<GameObject> _effectHolder;

		// Token: 0x0402A825 RID: 174117
		[Token(Token = "0x402A825")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isResumed;

		// Token: 0x0402A826 RID: 174118
		[Token(Token = "0x402A826")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x0402A827 RID: 174119
		[Token(Token = "0x402A827")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402A828 RID: 174120
		[Token(Token = "0x402A828")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeRewardStyle m_style;

		// Token: 0x0402A829 RID: 174121
		[Token(Token = "0x402A829")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_inited;

		// Token: 0x0402A82A RID: 174122
		[Token(Token = "0x402A82A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A82B RID: 174123
		[Token(Token = "0x402A82B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A82C RID: 174124
		[Token(Token = "0x402A82C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402A82D RID: 174125
		[Token(Token = "0x402A82D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402A82E RID: 174126
		[Token(Token = "0x402A82E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddStateRelatedEffect;

		// Token: 0x0402A82F RID: 174127
		[Token(Token = "0x402A82F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A830 RID: 174128
		[Token(Token = "0x402A830")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetEffectsActive;

		// Token: 0x0402A831 RID: 174129
		[Token(Token = "0x402A831")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnListClick;

		// Token: 0x0402A832 RID: 174130
		[Token(Token = "0x402A832")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
