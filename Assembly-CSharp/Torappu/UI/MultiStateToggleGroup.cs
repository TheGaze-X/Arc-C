using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003994 RID: 14740
	[Token(Token = "0x2003994")]
	public class MultiStateToggleGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x060174DB RID: 95451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174DB")]
		[Address(RVA = "0xFABC80", Offset = "0xFAA880", VA = "0x180FABC80")]
		private void Awake()
		{
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x060174DC RID: 95452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060174DD RID: 95453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037CB")]
		public string selectedStateID
		{
			[Token(Token = "0x60174DC")]
			[Address(RVA = "0xFAC160", Offset = "0xFAAD60", VA = "0x180FAC160")]
			get
			{
				return null;
			}
			[Token(Token = "0x60174DD")]
			[Address(RVA = "0xFAC230", Offset = "0xFAAE30", VA = "0x180FAC230")]
			set
			{
			}
		}

		// Token: 0x060174DE RID: 95454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174DE")]
		[Address(RVA = "0xFABEE0", Offset = "0xFAAAE0", VA = "0x180FABEE0")]
		private void _HandleSelectChanged(MultiStateToggle toggle)
		{
		}

		// Token: 0x060174DF RID: 95455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174DF")]
		[Address(RVA = "0xFAC0C0", Offset = "0xFAACC0", VA = "0x180FAC0C0")]
		public MultiStateToggleGroup()
		{
		}

		// Token: 0x0401C214 RID: 115220
		[Token(Token = "0x401C214")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MultiStateToggleGroup.StateChangedEvent _onStateChanged;

		// Token: 0x0401C215 RID: 115221
		[Token(Token = "0x401C215")]
		[FieldOffset(Offset = "0x20")]
		private MultiStateToggle[] m_toggles;

		// Token: 0x0401C216 RID: 115222
		[Token(Token = "0x401C216")]
		[FieldOffset(Offset = "0x28")]
		private MultiStateToggle m_selected;

		// Token: 0x0401C217 RID: 115223
		[Token(Token = "0x401C217")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Action<string> eStateChanged;

		// Token: 0x0401C218 RID: 115224
		[Token(Token = "0x401C218")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C219 RID: 115225
		[Token(Token = "0x401C219")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedStateID;

		// Token: 0x0401C21A RID: 115226
		[Token(Token = "0x401C21A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectedStateID;

		// Token: 0x0401C21B RID: 115227
		[Token(Token = "0x401C21B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleSelectChanged;

		// Token: 0x0401C21C RID: 115228
		[Token(Token = "0x401C21C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003995 RID: 14741
		[Token(Token = "0x2003995")]
		[Serializable]
		public class StateChangedEvent : UnityEvent
		{
			// Token: 0x060174E0 RID: 95456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60174E0")]
			[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
			public StateChangedEvent()
			{
			}
		}
	}
}
