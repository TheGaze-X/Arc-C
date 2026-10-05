using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200533A RID: 21306
	[Token(Token = "0x200533A")]
	public abstract class RoguelikeMenuBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F6C3 RID: 128707
		[Token(Token = "0x601F6C3")]
		protected abstract UISwitchTween GenerateUISwitchTween();

		// Token: 0x0601F6C4 RID: 128708
		[Token(Token = "0x601F6C4")]
		protected abstract void RefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode);

		// Token: 0x0601F6C5 RID: 128709
		[Token(Token = "0x601F6C5")]
		protected abstract bool AchieveShowStatus(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter);

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x0601F6C6 RID: 128710 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6C7 RID: 128711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049AD")]
		public string topicId
		{
			[Token(Token = "0x601F6C6")]
			[Address(RVA = "0x19277A0", Offset = "0x19263A0", VA = "0x1819277A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6C7")]
			[Address(RVA = "0x1927980", Offset = "0x1926580", VA = "0x181927980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x0601F6C8 RID: 128712 RVA: 0x000B1E40 File Offset: 0x000B0040
		[Token(Token = "0x170049AE")]
		public bool canClick
		{
			[Token(Token = "0x601F6C8")]
			[Address(RVA = "0x1927710", Offset = "0x1926310", VA = "0x181927710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x0601F6C9 RID: 128713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6CA RID: 128714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049AF")]
		public RoguelikeMenu bindMenu
		{
			[Token(Token = "0x601F6C9")]
			[Address(RVA = "0x1927650", Offset = "0x1926250", VA = "0x181927650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6CA")]
			[Address(RVA = "0x1927880", Offset = "0x1926480", VA = "0x181927880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x0601F6CB RID: 128715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6CC RID: 128716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049B0")]
		public RoguelikeDungeonController bindController
		{
			[Token(Token = "0x601F6CB")]
			[Address(RVA = "0x19275F0", Offset = "0x19261F0", VA = "0x1819275F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6CC")]
			[Address(RVA = "0x1927800", Offset = "0x1926400", VA = "0x181927800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x0601F6CD RID: 128717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6CE RID: 128718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049B1")]
		public StateEngine bindStateEngine
		{
			[Token(Token = "0x601F6CD")]
			[Address(RVA = "0x19276B0", Offset = "0x19262B0", VA = "0x1819276B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6CE")]
			[Address(RVA = "0x1927900", Offset = "0x1926500", VA = "0x181927900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F6CF RID: 128719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6CF")]
		[Address(RVA = "0x1927310", Offset = "0x1925F10", VA = "0x181927310")]
		private void _SetShowStatus(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F6D0 RID: 128720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D0")]
		[Address(RVA = "0x1925EC0", Offset = "0x1924AC0", VA = "0x181925EC0")]
		public void DoRefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode)
		{
		}

		// Token: 0x0601F6D1 RID: 128721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D1")]
		[Address(RVA = "0x1926130", Offset = "0x1924D30", VA = "0x181926130", Slot = "7")]
		public virtual void Init(RoguelikeDungeonController controller, StateEngine stateEngine, RoguelikeMenu menu, RoguelikeMenuViewModel viewModel)
		{
		}

		// Token: 0x0601F6D2 RID: 128722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D2")]
		[Address(RVA = "0x19268B0", Offset = "0x19254B0", VA = "0x1819268B0")]
		public void Render(RoguelikeMenuBinary binary, RoguelikeMenuViewModel viewModel)
		{
		}

		// Token: 0x0601F6D3 RID: 128723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D3")]
		[Address(RVA = "0x1925D70", Offset = "0x1924970", VA = "0x181925D70")]
		public void ApplySelect(RoguelikeMenuType type, bool fastMode = false)
		{
		}

		// Token: 0x0601F6D4 RID: 128724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D4")]
		[Address(RVA = "0x1925E40", Offset = "0x1924A40", VA = "0x181925E40")]
		public void ClearSelect(bool fastMode = false)
		{
		}

		// Token: 0x0601F6D5 RID: 128725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D5")]
		[Address(RVA = "0x1926C40", Offset = "0x1925840", VA = "0x181926C40")]
		private void _ApplySelect(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F6D6 RID: 128726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D6")]
		[Address(RVA = "0x1926F90", Offset = "0x1925B90", VA = "0x181926F90")]
		private void _CollectMenuEffectPrefabs()
		{
		}

		// Token: 0x0601F6D7 RID: 128727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D7")]
		[Address(RVA = "0x19274E0", Offset = "0x19260E0", VA = "0x1819274E0")]
		protected RoguelikeMenuBar()
		{
		}

		// Token: 0x0402A43E RID: 173118
		[Token(Token = "0x402A43E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeMenuObject> _menuObjects;

		// Token: 0x0402A43F RID: 173119
		[Token(Token = "0x402A43F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<RoguelikeMenuWindow> _menuWindows;

		// Token: 0x0402A440 RID: 173120
		[Token(Token = "0x402A440")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RoguelikeMenuBar.PrefabConfig> _menuWindowsPrefabWithParents;

		// Token: 0x0402A441 RID: 173121
		[Token(Token = "0x402A441")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402A442 RID: 173122
		[Token(Token = "0x402A442")]
		[FieldOffset(Offset = "0x38")]
		private bool m_lastShowStatus;

		// Token: 0x0402A443 RID: 173123
		[Token(Token = "0x402A443")]
		[FieldOffset(Offset = "0x40")]
		private List<RoguelikeMenuEffect> m_menuEffects;

		// Token: 0x0402A444 RID: 173124
		[Token(Token = "0x402A444")]
		[FieldOffset(Offset = "0x48")]
		private List<RoguelikeMenuWindow> m_menuWindows;

		// Token: 0x0402A449 RID: 173129
		[Token(Token = "0x402A449")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402A44A RID: 173130
		[Token(Token = "0x402A44A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402A44B RID: 173131
		[Token(Token = "0x402A44B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canClick;

		// Token: 0x0402A44C RID: 173132
		[Token(Token = "0x402A44C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bindMenu;

		// Token: 0x0402A44D RID: 173133
		[Token(Token = "0x402A44D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_bindMenu;

		// Token: 0x0402A44E RID: 173134
		[Token(Token = "0x402A44E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_bindController;

		// Token: 0x0402A44F RID: 173135
		[Token(Token = "0x402A44F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_bindController;

		// Token: 0x0402A450 RID: 173136
		[Token(Token = "0x402A450")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_bindStateEngine;

		// Token: 0x0402A451 RID: 173137
		[Token(Token = "0x402A451")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_bindStateEngine;

		// Token: 0x0402A452 RID: 173138
		[Token(Token = "0x402A452")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetShowStatus;

		// Token: 0x0402A453 RID: 173139
		[Token(Token = "0x402A453")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoRefreshMenuBar;

		// Token: 0x0402A454 RID: 173140
		[Token(Token = "0x402A454")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A455 RID: 173141
		[Token(Token = "0x402A455")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A456 RID: 173142
		[Token(Token = "0x402A456")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ApplySelect;

		// Token: 0x0402A457 RID: 173143
		[Token(Token = "0x402A457")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ClearSelect;

		// Token: 0x0402A458 RID: 173144
		[Token(Token = "0x402A458")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ApplySelect;

		// Token: 0x0402A459 RID: 173145
		[Token(Token = "0x402A459")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CollectMenuEffectPrefabs;

		// Token: 0x0402A45A RID: 173146
		[Token(Token = "0x402A45A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200533B RID: 21307
		[Token(Token = "0x200533B")]
		[Serializable]
		public struct PrefabConfig
		{
			// Token: 0x0402A45B RID: 173147
			[Token(Token = "0x402A45B")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeMenuWindow windowPrefab;

			// Token: 0x0402A45C RID: 173148
			[Token(Token = "0x402A45C")]
			[FieldOffset(Offset = "0x8")]
			public Transform parent;
		}
	}
}
