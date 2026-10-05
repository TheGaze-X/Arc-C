using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005334 RID: 21300
	[Token(Token = "0x2005334")]
	public class RoguelikeMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x0601F6A8 RID: 128680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F6A9 RID: 128681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049A4")]
		public string topicId
		{
			[Token(Token = "0x601F6A8")]
			[Address(RVA = "0x192D8B0", Offset = "0x192C4B0", VA = "0x18192D8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F6A9")]
			[Address(RVA = "0x192D910", Offset = "0x192C510", VA = "0x18192D910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F6AA RID: 128682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6AA")]
		[Address(RVA = "0x192C640", Offset = "0x192B240", VA = "0x18192C640")]
		public void RegisterMenuAdapter(Type stateType, RoguelikeMenuAdapter adapter, [Optional] Type adapterType)
		{
		}

		// Token: 0x0601F6AB RID: 128683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F6AB")]
		[Address(RVA = "0x192CB80", Offset = "0x192B780", VA = "0x18192CB80")]
		private RoguelikeMenuAdapter _GetStateMenuAdapter(Type stateType)
		{
			return null;
		}

		// Token: 0x0601F6AC RID: 128684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6AC")]
		[Address(RVA = "0x192CED0", Offset = "0x192BAD0", VA = "0x18192CED0")]
		private void _OnDataUpdated(object arg)
		{
		}

		// Token: 0x0601F6AD RID: 128685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6AD")]
		[Address(RVA = "0x192CD40", Offset = "0x192B940", VA = "0x18192CD40")]
		private void _OnBeforeStateTransition(object arg)
		{
		}

		// Token: 0x0601F6AE RID: 128686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6AE")]
		[Address(RVA = "0x192D190", Offset = "0x192BD90", VA = "0x18192D190")]
		private void _OnStateChanged(object arg, bool statePaused)
		{
		}

		// Token: 0x0601F6AF RID: 128687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6AF")]
		[Address(RVA = "0x192D110", Offset = "0x192BD10", VA = "0x18192D110")]
		private void _OnSelectCharChange(object arg)
		{
		}

		// Token: 0x0601F6B0 RID: 128688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6B0")]
		[Address(RVA = "0x192D4F0", Offset = "0x192C0F0", VA = "0x18192D4F0")]
		private void _RefreshMenu(bool fastMode)
		{
		}

		// Token: 0x0601F6B1 RID: 128689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6B1")]
		[Address(RVA = "0x192C140", Offset = "0x192AD40", VA = "0x18192C140")]
		public void Init(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F6B2 RID: 128690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6B2")]
		[Address(RVA = "0x192C7B0", Offset = "0x192B3B0", VA = "0x18192C7B0")]
		public void SetMenuBarSelectStatus(RoguelikeMenuBar menuBar, bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601F6B3 RID: 128691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6B3")]
		[Address(RVA = "0x192BFB0", Offset = "0x192ABB0", VA = "0x18192BFB0")]
		public void ClearSelect(bool fastMode = false)
		{
		}

		// Token: 0x0601F6B4 RID: 128692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6B4")]
		[Address(RVA = "0x192D6A0", Offset = "0x192C2A0", VA = "0x18192D6A0")]
		public RoguelikeMenu()
		{
		}

		// Token: 0x0402A40C RID: 173068
		[Token(Token = "0x402A40C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeMenuBar> _menuBars;

		// Token: 0x0402A40D RID: 173069
		[Token(Token = "0x402A40D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _raycastTriggers;

		// Token: 0x0402A40E RID: 173070
		[Token(Token = "0x402A40E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RoguelikeMenuViewModel m_viewModel;

		// Token: 0x0402A40F RID: 173071
		[Token(Token = "0x402A40F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RoguelikeMenuAdapter m_topAdapter;

		// Token: 0x0402A410 RID: 173072
		[Token(Token = "0x402A410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RoguelikeMenu.StateTransitionParam m_currTransParam;

		// Token: 0x0402A411 RID: 173073
		[Token(Token = "0x402A411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<Type, RoguelikeMenuAdapter> m_adapters;

		// Token: 0x0402A412 RID: 173074
		[Token(Token = "0x402A412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StateEngine m_bindStateEngine;

		// Token: 0x0402A413 RID: 173075
		[Token(Token = "0x402A413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HashSet<int> m_selectStatus;

		// Token: 0x0402A415 RID: 173077
		[Token(Token = "0x402A415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402A416 RID: 173078
		[Token(Token = "0x402A416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402A417 RID: 173079
		[Token(Token = "0x402A417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterMenuAdapter;

		// Token: 0x0402A418 RID: 173080
		[Token(Token = "0x402A418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetStateMenuAdapter;

		// Token: 0x0402A419 RID: 173081
		[Token(Token = "0x402A419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnDataUpdated;

		// Token: 0x0402A41A RID: 173082
		[Token(Token = "0x402A41A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBeforeStateTransition;

		// Token: 0x0402A41B RID: 173083
		[Token(Token = "0x402A41B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x0402A41C RID: 173084
		[Token(Token = "0x402A41C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSelectCharChange;

		// Token: 0x0402A41D RID: 173085
		[Token(Token = "0x402A41D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshMenu;

		// Token: 0x0402A41E RID: 173086
		[Token(Token = "0x402A41E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A41F RID: 173087
		[Token(Token = "0x402A41F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetMenuBarSelectStatus;

		// Token: 0x0402A420 RID: 173088
		[Token(Token = "0x402A420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ClearSelect;

		// Token: 0x0402A421 RID: 173089
		[Token(Token = "0x402A421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005335 RID: 21301
		[Token(Token = "0x2005335")]
		public class StateTransitionParam
		{
			// Token: 0x0601F6B7 RID: 128695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F6B7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateTransitionParam()
			{
			}

			// Token: 0x0402A422 RID: 173090
			[Token(Token = "0x402A422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool transitionIn;

			// Token: 0x0402A423 RID: 173091
			[Token(Token = "0x402A423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type transitionDestType;

			// Token: 0x0402A424 RID: 173092
			[Token(Token = "0x402A424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Stack<Type> transitionPredicatedStack;
		}
	}
}
