using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x02004675 RID: 18037
	[Token(Token = "0x2004675")]
	public class RoguelikeTopicModeToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x0601B620 RID: 112160 RVA: 0x000A4FD0 File Offset: 0x000A31D0
		// (set) Token: 0x0601B621 RID: 112161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700412D")]
		public bool interactable
		{
			[Token(Token = "0x601B620")]
			[Address(RVA = "0x14BDE00", Offset = "0x14BCA00", VA = "0x1814BDE00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B621")]
			[Address(RVA = "0x14BDF80", Offset = "0x14BCB80", VA = "0x1814BDF80")]
			set
			{
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x0601B622 RID: 112162 RVA: 0x000A4FE8 File Offset: 0x000A31E8
		// (set) Token: 0x0601B623 RID: 112163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700412E")]
		public bool isUnlock
		{
			[Token(Token = "0x601B622")]
			[Address(RVA = "0x14BDEC0", Offset = "0x14BCAC0", VA = "0x1814BDEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B623")]
			[Address(RVA = "0x14BE080", Offset = "0x14BCC80", VA = "0x1814BE080")]
			set
			{
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x0601B624 RID: 112164 RVA: 0x000A5000 File Offset: 0x000A3200
		// (set) Token: 0x0601B625 RID: 112165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700412F")]
		public bool isOpened
		{
			[Token(Token = "0x601B624")]
			[Address(RVA = "0x14BDE60", Offset = "0x14BCA60", VA = "0x1814BDE60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B625")]
			[Address(RVA = "0x14BE000", Offset = "0x14BCC00", VA = "0x1814BE000")]
			set
			{
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x0601B626 RID: 112166 RVA: 0x000A5018 File Offset: 0x000A3218
		[Token(Token = "0x17004130")]
		public ModeTabIDs.SerializeTabID tabType
		{
			[Token(Token = "0x601B626")]
			[Address(RVA = "0x14BDF20", Offset = "0x14BCB20", VA = "0x1814BDF20")]
			get
			{
				return ModeTabIDs.SerializeTabID.NONE;
			}
		}

		// Token: 0x0601B627 RID: 112167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B627")]
		[Address(RVA = "0x14BD890", Offset = "0x14BC490", VA = "0x1814BD890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B628 RID: 112168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B628")]
		[Address(RVA = "0x14BD6C0", Offset = "0x14BC2C0", VA = "0x1814BD6C0")]
		public void UpdateStatus(string topicId, ModeTabIDs.SerializeTabID selectedType)
		{
		}

		// Token: 0x0601B629 RID: 112169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B629")]
		[Address(RVA = "0x14BDBE0", Offset = "0x14BC7E0", VA = "0x1814BDBE0")]
		private void _RefreshTabStatus()
		{
		}

		// Token: 0x0601B62A RID: 112170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62A")]
		[Address(RVA = "0x14BD9B0", Offset = "0x14BC5B0", VA = "0x1814BD9B0")]
		private void _OnTabClicked()
		{
		}

		// Token: 0x0601B62B RID: 112171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62B")]
		[Address(RVA = "0x14BDD90", Offset = "0x14BC990", VA = "0x1814BDD90")]
		public RoguelikeTopicModeToggle()
		{
		}

		// Token: 0x04023644 RID: 144964
		[Token(Token = "0x4023644")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ModeTabIDs.SerializeTabID _tabType;

		// Token: 0x04023645 RID: 144965
		[Token(Token = "0x4023645")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x04023646 RID: 144966
		[Token(Token = "0x4023646")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x04023647 RID: 144967
		[Token(Token = "0x4023647")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unselectedObj;

		// Token: 0x04023648 RID: 144968
		[Token(Token = "0x4023648")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _disableObj;

		// Token: 0x04023649 RID: 144969
		[Token(Token = "0x4023649")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isUnlocked;

		// Token: 0x0402364A RID: 144970
		[Token(Token = "0x402364A")]
		[FieldOffset(Offset = "0x41")]
		private bool m_interactable;

		// Token: 0x0402364B RID: 144971
		[Token(Token = "0x402364B")]
		[FieldOffset(Offset = "0x42")]
		private bool m_isOpened;

		// Token: 0x0402364C RID: 144972
		[Token(Token = "0x402364C")]
		[FieldOffset(Offset = "0x44")]
		private ModeTabIDs.SerializeTabID m_curType;

		// Token: 0x0402364D RID: 144973
		[Token(Token = "0x402364D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0402364E RID: 144974
		[Token(Token = "0x402364E")]
		[FieldOffset(Offset = "0x50")]
		private string m_topicId;

		// Token: 0x0402364F RID: 144975
		[Token(Token = "0x402364F")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<ModeTabIDs.SerializeTabID> onTabClicked;

		// Token: 0x04023650 RID: 144976
		[Token(Token = "0x4023650")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x04023651 RID: 144977
		[Token(Token = "0x4023651")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_interactable;

		// Token: 0x04023652 RID: 144978
		[Token(Token = "0x4023652")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x04023653 RID: 144979
		[Token(Token = "0x4023653")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isUnlock;

		// Token: 0x04023654 RID: 144980
		[Token(Token = "0x4023654")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isOpened;

		// Token: 0x04023655 RID: 144981
		[Token(Token = "0x4023655")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isOpened;

		// Token: 0x04023656 RID: 144982
		[Token(Token = "0x4023656")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tabType;

		// Token: 0x04023657 RID: 144983
		[Token(Token = "0x4023657")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023658 RID: 144984
		[Token(Token = "0x4023658")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04023659 RID: 144985
		[Token(Token = "0x4023659")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshTabStatus;

		// Token: 0x0402365A RID: 144986
		[Token(Token = "0x402365A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTabClicked;

		// Token: 0x0402365B RID: 144987
		[Token(Token = "0x402365B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
