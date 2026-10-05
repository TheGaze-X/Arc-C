using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032C3 RID: 12995
	[Token(Token = "0x20032C3")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UICharacterInfoPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06014A92 RID: 84626 RVA: 0x00087EE8 File Offset: 0x000860E8
		// (set) Token: 0x06014A93 RID: 84627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030EB")]
		public UICharacterInfoPanel.ModeType mode
		{
			[Token(Token = "0x6014A92")]
			[Address(RVA = "0xCEEB00", Offset = "0xCED700", VA = "0x180CEEB00")]
			[CompilerGenerated]
			get
			{
				return UICharacterInfoPanel.ModeType.RUNTIME_CHARACTER_MODE;
			}
			[Token(Token = "0x6014A93")]
			[Address(RVA = "0xCEF190", Offset = "0xCEDD90", VA = "0x180CEF190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06014A94 RID: 84628 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014A95 RID: 84629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030EC")]
		private Deck.Card card
		{
			[Token(Token = "0x6014A94")]
			[Address(RVA = "0xCEE960", Offset = "0xCED560", VA = "0x180CEE960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014A95")]
			[Address(RVA = "0xCEEE40", Offset = "0xCEDA40", VA = "0x180CEEE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06014A96 RID: 84630 RVA: 0x00087F00 File Offset: 0x00086100
		// (set) Token: 0x06014A97 RID: 84631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030ED")]
		private ObjectPtr<Character> character
		{
			[Token(Token = "0x6014A96")]
			[Address(RVA = "0xCEE9C0", Offset = "0xCED5C0", VA = "0x180CEE9C0")]
			[CompilerGenerated]
			get
			{
				return default(ObjectPtr<Character>);
			}
			[Token(Token = "0x6014A97")]
			[Address(RVA = "0xCEEEC0", Offset = "0xCEDAC0", VA = "0x180CEEEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06014A98 RID: 84632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030EE")]
		private UICharacterInfoSubPanel statusSubPanel
		{
			[Token(Token = "0x6014A98")]
			[Address(RVA = "0xCEEB60", Offset = "0xCED760", VA = "0x180CEEB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06014A99 RID: 84633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030EF")]
		private UICharacterInfoSubPanel tabGroupSubPanel
		{
			[Token(Token = "0x6014A99")]
			[Address(RVA = "0xCEECE0", Offset = "0xCED8E0", VA = "0x180CEECE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06014A9A RID: 84634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F0")]
		private UICharacterInfoSubPanel additionSubPanel
		{
			[Token(Token = "0x6014A9A")]
			[Address(RVA = "0xCEE900", Offset = "0xCED500", VA = "0x180CEE900")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06014A9B RID: 84635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F1")]
		public UICharacterInfoTabGroupSubPanel tabGroupSubPanelCasted
		{
			[Token(Token = "0x6014A9B")]
			[Address(RVA = "0xCEEBC0", Offset = "0xCED7C0", VA = "0x180CEEBC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06014A9C RID: 84636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F2")]
		public UICharacterTabGroup uiCharacterTabGroup
		{
			[Token(Token = "0x6014A9C")]
			[Address(RVA = "0xCEED40", Offset = "0xCED940", VA = "0x180CEED40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06014A9D RID: 84637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F3")]
		public BattleIllustration illustHandler
		{
			[Token(Token = "0x6014A9D")]
			[Address(RVA = "0xCEEA40", Offset = "0xCED640", VA = "0x180CEEA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06014A9E RID: 84638 RVA: 0x00087F18 File Offset: 0x00086118
		// (set) Token: 0x06014A9F RID: 84639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030F4")]
		public bool isOpen
		{
			[Token(Token = "0x6014A9E")]
			[Address(RVA = "0xCEEAA0", Offset = "0xCED6A0", VA = "0x180CEEAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014A9F")]
			[Address(RVA = "0xCEEF40", Offset = "0xCEDB40", VA = "0x180CEEF40")]
			private set
			{
			}
		}

		// Token: 0x06014AA0 RID: 84640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA0")]
		[Address(RVA = "0xCEC5B0", Offset = "0xCEB1B0", VA = "0x180CEC5B0")]
		public void OnInit()
		{
		}

		// Token: 0x06014AA1 RID: 84641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA1")]
		[Address(RVA = "0xCECDF0", Offset = "0xCEB9F0", VA = "0x180CECDF0")]
		public void ShowCard(Deck.Card card, bool foldIllust = false)
		{
		}

		// Token: 0x06014AA2 RID: 84642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA2")]
		[Address(RVA = "0xCED0A0", Offset = "0xCEBCA0", VA = "0x180CED0A0")]
		public void ShowCharacter(Character character, bool foldIllust = false, bool noSideBy = false)
		{
		}

		// Token: 0x06014AA3 RID: 84643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA3")]
		[Address(RVA = "0xCEC270", Offset = "0xCEAE70", VA = "0x180CEC270")]
		public void Hide([Optional] Deck.Card card)
		{
		}

		// Token: 0x06014AA4 RID: 84644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA4")]
		[Address(RVA = "0xCED810", Offset = "0xCEC410", VA = "0x180CED810")]
		private void _SetData()
		{
		}

		// Token: 0x06014AA5 RID: 84645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA5")]
		[Address(RVA = "0xCED540", Offset = "0xCEC140", VA = "0x180CED540")]
		private void _LoadIllust(BattleCharacterData data, bool fold)
		{
		}

		// Token: 0x06014AA6 RID: 84646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA6")]
		[Address(RVA = "0xCEC1A0", Offset = "0xCEADA0", VA = "0x180CEC1A0")]
		private void Awake()
		{
		}

		// Token: 0x06014AA7 RID: 84647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA7")]
		[Address(RVA = "0xCED490", Offset = "0xCEC090", VA = "0x180CED490")]
		private void Update()
		{
		}

		// Token: 0x06014AA8 RID: 84648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA8")]
		[Address(RVA = "0xCEDE30", Offset = "0xCECA30", VA = "0x180CEDE30")]
		private void _UpdateData()
		{
		}

		// Token: 0x06014AA9 RID: 84649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AA9")]
		[Address(RVA = "0xCEC910", Offset = "0xCEB510", VA = "0x180CEC910")]
		public void RefreshHookedSubPanels()
		{
		}

		// Token: 0x06014AAA RID: 84650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AAA")]
		[Address(RVA = "0xCEC4B0", Offset = "0xCEB0B0", VA = "0x180CEC4B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014AAB RID: 84651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AAB")]
		[Address(RVA = "0xCEE840", Offset = "0xCED440", VA = "0x180CEE840")]
		public UICharacterInfoPanel()
		{
		}

		// Token: 0x040187D8 RID: 100312
		[Token(Token = "0x40187D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_tweenTime;

		// Token: 0x040187D9 RID: 100313
		[Token(Token = "0x40187D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BattleIllustration _illustHandler;

		// Token: 0x040187DA RID: 100314
		[Token(Token = "0x40187DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterInfoSubPanel _statusSubPanel;

		// Token: 0x040187DB RID: 100315
		[Token(Token = "0x40187DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterInfoSubPanel _tabGroupSubPanel;

		// Token: 0x040187DC RID: 100316
		[Token(Token = "0x40187DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup[] m_canvasGroup;

		// Token: 0x040187DD RID: 100317
		[Token(Token = "0x40187DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_isOpen;

		// Token: 0x040187E1 RID: 100321
		[Token(Token = "0x40187E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UICharacterInfoSubPanel m_statusSubPanel;

		// Token: 0x040187E2 RID: 100322
		[Token(Token = "0x40187E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UICharacterInfoSubPanel m_tabGroupSubPanel;

		// Token: 0x040187E3 RID: 100323
		[Token(Token = "0x40187E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UICharacterInfoSubPanel m_additionSubPanel;

		// Token: 0x040187E4 RID: 100324
		[Token(Token = "0x40187E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image m_illust;

		// Token: 0x040187E5 RID: 100325
		[Token(Token = "0x40187E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<UICharacterInfoPanel.HookedCharacterInfoType, UICharacterInfoSubPanel> m_hookedSubPanels;

		// Token: 0x040187E6 RID: 100326
		[Token(Token = "0x40187E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x040187E7 RID: 100327
		[Token(Token = "0x40187E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mode;

		// Token: 0x040187E8 RID: 100328
		[Token(Token = "0x40187E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_card;

		// Token: 0x040187E9 RID: 100329
		[Token(Token = "0x40187E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_card;

		// Token: 0x040187EA RID: 100330
		[Token(Token = "0x40187EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x040187EB RID: 100331
		[Token(Token = "0x40187EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x040187EC RID: 100332
		[Token(Token = "0x40187EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_statusSubPanel;

		// Token: 0x040187ED RID: 100333
		[Token(Token = "0x40187ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_tabGroupSubPanel;

		// Token: 0x040187EE RID: 100334
		[Token(Token = "0x40187EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_additionSubPanel;

		// Token: 0x040187EF RID: 100335
		[Token(Token = "0x40187EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_tabGroupSubPanelCasted;

		// Token: 0x040187F0 RID: 100336
		[Token(Token = "0x40187F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_uiCharacterTabGroup;

		// Token: 0x040187F1 RID: 100337
		[Token(Token = "0x40187F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_illustHandler;

		// Token: 0x040187F2 RID: 100338
		[Token(Token = "0x40187F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isOpen;

		// Token: 0x040187F3 RID: 100339
		[Token(Token = "0x40187F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_isOpen;

		// Token: 0x040187F4 RID: 100340
		[Token(Token = "0x40187F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040187F5 RID: 100341
		[Token(Token = "0x40187F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowCard;

		// Token: 0x040187F6 RID: 100342
		[Token(Token = "0x40187F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowCharacter;

		// Token: 0x040187F7 RID: 100343
		[Token(Token = "0x40187F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040187F8 RID: 100344
		[Token(Token = "0x40187F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x040187F9 RID: 100345
		[Token(Token = "0x40187F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadIllust;

		// Token: 0x040187FA RID: 100346
		[Token(Token = "0x40187FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040187FB RID: 100347
		[Token(Token = "0x40187FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040187FC RID: 100348
		[Token(Token = "0x40187FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040187FD RID: 100349
		[Token(Token = "0x40187FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshHookedSubPanels;

		// Token: 0x040187FE RID: 100350
		[Token(Token = "0x40187FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040187FF RID: 100351
		[Token(Token = "0x40187FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032C4 RID: 12996
		[Token(Token = "0x20032C4")]
		public enum ModeType
		{
			// Token: 0x04018801 RID: 100353
			[Token(Token = "0x4018801")]
			RUNTIME_CHARACTER_MODE,
			// Token: 0x04018802 RID: 100354
			[Token(Token = "0x4018802")]
			STATIC_CARD_MODE,
			// Token: 0x04018803 RID: 100355
			[Token(Token = "0x4018803")]
			OFF
		}

		// Token: 0x020032C5 RID: 12997
		[Token(Token = "0x20032C5")]
		public enum HookedCharacterInfoType
		{
			// Token: 0x04018805 RID: 100357
			[Token(Token = "0x4018805")]
			STATUS,
			// Token: 0x04018806 RID: 100358
			[Token(Token = "0x4018806")]
			TAB_GROUP,
			// Token: 0x04018807 RID: 100359
			[Token(Token = "0x4018807")]
			ADDITION,
			// Token: 0x04018808 RID: 100360
			[Token(Token = "0x4018808")]
			E_NUM
		}

		// Token: 0x020032C6 RID: 12998
		[Token(Token = "0x20032C6")]
		[Serializable]
		public struct HookedCharacterInfoSubPanel
		{
			// Token: 0x04018809 RID: 100361
			[Token(Token = "0x4018809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UICharacterInfoPanel.HookedCharacterInfoType hookedType;

			// Token: 0x0401880A RID: 100362
			[Token(Token = "0x401880A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UICharacterInfoSubPanel hookedSubpanel;
		}
	}
}
