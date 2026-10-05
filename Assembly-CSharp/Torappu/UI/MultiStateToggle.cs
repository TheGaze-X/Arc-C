using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003992 RID: 14738
	[Token(Token = "0x2003992")]
	public class MultiStateToggle : UIBehaviour, IPointerClickHandler, IEventSystemHandler, IHotfixable
	{
		// Token: 0x060174CC RID: 95436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174CC")]
		[Address(RVA = "0xFAC480", Offset = "0xFAB080", VA = "0x180FAC480", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060174CD RID: 95437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174CD")]
		[Address(RVA = "0xFAC4E0", Offset = "0xFAB0E0", VA = "0x180FAC4E0")]
		public void InitIfNot()
		{
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x060174CE RID: 95438 RVA: 0x00095DC0 File Offset: 0x00093FC0
		// (set) Token: 0x060174CF RID: 95439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037C7")]
		[Inspect]
		public bool interactable
		{
			[Token(Token = "0x60174CE")]
			[Address(RVA = "0xFAC9C0", Offset = "0xFAB5C0", VA = "0x180FAC9C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60174CF")]
			[Address(RVA = "0xFACBB0", Offset = "0xFAB7B0", VA = "0x180FACBB0")]
			set
			{
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x060174D0 RID: 95440 RVA: 0x00095DD8 File Offset: 0x00093FD8
		// (set) Token: 0x060174D1 RID: 95441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037C8")]
		public bool selected
		{
			[Token(Token = "0x60174D0")]
			[Address(RVA = "0xFACB50", Offset = "0xFAB750", VA = "0x180FACB50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60174D1")]
			[Address(RVA = "0xFACCC0", Offset = "0xFAB8C0", VA = "0x180FACCC0")]
			set
			{
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x060174D2 RID: 95442 RVA: 0x00095DF0 File Offset: 0x00093FF0
		// (set) Token: 0x060174D3 RID: 95443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037C9")]
		public int selectIdx
		{
			[Token(Token = "0x60174D2")]
			[Address(RVA = "0xFACA20", Offset = "0xFAB620", VA = "0x180FACA20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60174D3")]
			[Address(RVA = "0xFACC40", Offset = "0xFAB840", VA = "0x180FACC40")]
			set
			{
			}
		}

		// Token: 0x060174D4 RID: 95444 RVA: 0x00095E08 File Offset: 0x00094008
		[Token(Token = "0x60174D4")]
		[Address(RVA = "0xFAC6C0", Offset = "0xFAB2C0", VA = "0x180FAC6C0")]
		public bool SetSelectedID(string id)
		{
			return default(bool);
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x060174D5 RID: 95445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170037CA")]
		public string selectedId
		{
			[Token(Token = "0x60174D5")]
			[Address(RVA = "0xFACA80", Offset = "0xFAB680", VA = "0x180FACA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060174D6 RID: 95446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174D6")]
		[Address(RVA = "0xFAC620", Offset = "0xFAB220", VA = "0x180FAC620", Slot = "17")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060174D7 RID: 95447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174D7")]
		[Address(RVA = "0xFAC7C0", Offset = "0xFAB3C0", VA = "0x180FAC7C0")]
		private void _SetSelect(int idx)
		{
		}

		// Token: 0x060174D8 RID: 95448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174D8")]
		[Address(RVA = "0xFAC960", Offset = "0xFAB560", VA = "0x180FAC960")]
		public MultiStateToggle()
		{
		}

		// Token: 0x060174D9 RID: 95449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174D9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0401C1FE RID: 115198
		[Token(Token = "0x401C1FE")]
		private const int UNSELECTED_IDX = 0;

		// Token: 0x0401C1FF RID: 115199
		[Token(Token = "0x401C1FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MultiStateItem[] _states;

		// Token: 0x0401C200 RID: 115200
		[Token(Token = "0x401C200")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private bool _interactable;

		// Token: 0x0401C201 RID: 115201
		[Token(Token = "0x401C201")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _nonInteractiveNode;

		// Token: 0x0401C202 RID: 115202
		[Token(Token = "0x401C202")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[ReadOnly]
		private int m_selectIdx;

		// Token: 0x0401C203 RID: 115203
		[Token(Token = "0x401C203")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Action<MultiStateToggle> eSelecteChanged;

		// Token: 0x0401C204 RID: 115204
		[Token(Token = "0x401C204")]
		[FieldOffset(Offset = "0x40")]
		private bool m_init;

		// Token: 0x0401C205 RID: 115205
		[Token(Token = "0x401C205")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C206 RID: 115206
		[Token(Token = "0x401C206")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401C207 RID: 115207
		[Token(Token = "0x401C207")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0401C208 RID: 115208
		[Token(Token = "0x401C208")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_interactable;

		// Token: 0x0401C209 RID: 115209
		[Token(Token = "0x401C209")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0401C20A RID: 115210
		[Token(Token = "0x401C20A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0401C20B RID: 115211
		[Token(Token = "0x401C20B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectIdx;

		// Token: 0x0401C20C RID: 115212
		[Token(Token = "0x401C20C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selectIdx;

		// Token: 0x0401C20D RID: 115213
		[Token(Token = "0x401C20D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSelectedID;

		// Token: 0x0401C20E RID: 115214
		[Token(Token = "0x401C20E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selectedId;

		// Token: 0x0401C20F RID: 115215
		[Token(Token = "0x401C20F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x0401C210 RID: 115216
		[Token(Token = "0x401C210")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetSelect;

		// Token: 0x0401C211 RID: 115217
		[Token(Token = "0x401C211")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
