using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Event/Event System")]
	public class EventSystem : UIBehaviour
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CC")]
		public static EventSystem current
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x5B87540", Offset = "0x5B86140", VA = "0x185B87540")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x5B87750", Offset = "0x5B86350", VA = "0x185B87750")]
			set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x170001CD")]
		public static int Count
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x5B873D0", Offset = "0x5B85FD0", VA = "0x185B873D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00004AA0 File Offset: 0x00002CA0
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CE")]
		public bool sendNavigationEvents
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00004AB8 File Offset: 0x00002CB8
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CF")]
		public int pixelDragThreshold
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D0")]
		public BaseInputModule currentInputModule
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D1")]
		public GameObject firstSelectedGameObject
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D2")]
		public GameObject currentSelectedGameObject
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D3")]
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x170001D4")]
		public bool isFocused
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x5B87340", Offset = "0x5B85F40", VA = "0x185B87340")]
		protected EventSystem()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x5B86E20", Offset = "0x5B85A20", VA = "0x185B86E20")]
		public void UpdateModules()
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x170001D5")]
		public bool alreadySelecting
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x5B86250", Offset = "0x5B84E50", VA = "0x185B86250")]
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		private BaseEventData baseEventDataCache
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x5B87440", Offset = "0x5B86040", VA = "0x185B87440")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x5B861A0", Offset = "0x5B84DA0", VA = "0x185B861A0")]
		public void SetSelectedGameObject(GameObject selected)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x5B85BD0", Offset = "0x5B847D0", VA = "0x185B85BD0")]
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			return 0;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x5B859F0", Offset = "0x5B845F0", VA = "0x185B859F0")]
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x5B855E0", Offset = "0x5B841E0", VA = "0x185B855E0")]
		public bool IsPointerOverGameObject()
		{
			return default(bool);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x5B85520", Offset = "0x5B84120", VA = "0x185B85520")]
		public bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x170001D7")]
		private bool isUIToolkitActiveEventSystem
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x5B875F0", Offset = "0x5B861F0", VA = "0x185B875F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x170001D8")]
		private bool sendUIToolkitEvents
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x5B876E0", Offset = "0x5B862E0", VA = "0x185B876E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x170001D9")]
		private bool createUIToolkitPanelGameObjectsOnStart
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5B874D0", Offset = "0x5B860D0", VA = "0x185B874D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x5B86490", Offset = "0x5B85090", VA = "0x185B86490")]
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x5B85250", Offset = "0x5B83E50", VA = "0x185B85250")]
		private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x5B86650", Offset = "0x5B85250", VA = "0x185B86650", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x5B856B0", Offset = "0x5B842B0", VA = "0x185B856B0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x5B85890", Offset = "0x5B84490", VA = "0x185B85890", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x5B85750", Offset = "0x5B84350", VA = "0x185B85750", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x5B86B90", Offset = "0x5B85790", VA = "0x185B86B90")]
		private void TickModules()
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00004B90 File Offset: 0x00002D90
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DA")]
		public bool DisableFocusLogic
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5B85690", Offset = "0x5B84290", VA = "0x185B85690", Slot = "17")]
		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5B86F60", Offset = "0x5B85B60", VA = "0x185B86F60", Slot = "18")]
		protected virtual void Update()
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5B85120", Offset = "0x5B83D20", VA = "0x185B85120")]
		private void ChangeEventModule(BaseInputModule module)
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5B86C80", Offset = "0x5B85880", VA = "0x185B86C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x18")]
		private List<BaseInputModule> m_SystemInputModules;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		private BaseInputModule m_CurrentInputModule;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x0")]
		private static List<EventSystem> m_EventSystems;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x8")]
		public static Action<EventSystem> OnEventSystemEnabled;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("m_Selected")]
		[SerializeField]
		private GameObject m_FirstSelected;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_sendNavigationEvents;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_DragThreshold;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_CurrentSelected;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_HasFocus;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x41")]
		private bool m_SelectionGuard;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x48")]
		private BaseEventData m_DummyData;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Comparison<RaycastResult> s_RaycastComparer;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x18")]
		private static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;

		// Token: 0x020000C3 RID: 195
		[Token(Token = "0x20000C3")]
		private struct UIToolkitOverrideConfig
		{
			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			[FieldOffset(Offset = "0x0")]
			public EventSystem activeEventSystem;

			// Token: 0x04000342 RID: 834
			[Token(Token = "0x4000342")]
			[FieldOffset(Offset = "0x8")]
			public bool sendEvents;

			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x9")]
			public bool createPanelGameObjectsOnStart;
		}
	}
}
