using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(-100)]
	[AddComponentMenu("UI Toolkit/UI Document")]
	[HelpURL("UIE-get-started-with-runtime-ui")]
	public sealed class UIDocument : MonoBehaviour
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031A")]
		public PanelSettings panelSettings
		{
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x5B165A0", Offset = "0x5B151A0", VA = "0x185B165A0")]
			set
			{
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031B")]
		public UIDocument parentUI
		{
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D89")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			private set
			{
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031C")]
		public VisualTreeAsset visualTreeAsset
		{
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x59976E0", Offset = "0x59962E0", VA = "0x1859976E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0x5B168A0", Offset = "0x5B154A0", VA = "0x185B168A0")]
			set
			{
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700031D")]
		public VisualElement rootVisualElement
		{
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x5997770", Offset = "0x5996370", VA = "0x185997770")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x1700031E")]
		internal int firstChildInserIndex
		{
			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00006BA0 File Offset: 0x00004DA0
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031F")]
		public float sortingOrder
		{
			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x4E4DA40", Offset = "0x4E4C640", VA = "0x184E4DA40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x5B16880", Offset = "0x5B15480", VA = "0x185B16880")]
			set
			{
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x5B15770", Offset = "0x5B14370", VA = "0x185B15770")]
		internal void ApplySortingOrder()
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x5B16510", Offset = "0x5B15110", VA = "0x185B16510")]
		private UIDocument()
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x5B15780", Offset = "0x5B14380", VA = "0x185B15780")]
		private void Awake()
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x5B15880", Offset = "0x5B14480", VA = "0x185B15880")]
		private void OnEnable()
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x5B16310", Offset = "0x5B14F10", VA = "0x185B16310")]
		private void SetupFromHierarchy()
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x5B15790", Offset = "0x5B14390", VA = "0x185B15790")]
		private UIDocument FindUIDocumentParent()
		{
			return null;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x5B16200", Offset = "0x5B14E00", VA = "0x185B16200")]
		internal void Reset()
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x5B155A0", Offset = "0x5B141A0", VA = "0x185B155A0")]
		private void AddChildAndInsertContentToVisualTree(UIDocument child)
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x5B16080", Offset = "0x5B14C80", VA = "0x185B16080")]
		private void RemoveChild(UIDocument child)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x5B15C10", Offset = "0x5B14810", VA = "0x185B15C10")]
		private void RecreateUI()
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x5B16480", Offset = "0x5B15080", VA = "0x185B16480")]
		private void SetupRootClassList()
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x5B156A0", Offset = "0x5B142A0", VA = "0x185B156A0")]
		private void AddRootVisualElementToTree()
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x5B160F0", Offset = "0x5B14CF0", VA = "0x185B160F0")]
		private void RemoveFromHierarchy()
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x5B15840", Offset = "0x5B14440", VA = "0x185B15840")]
		private void OnDisable()
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x5B15960", Offset = "0x5B14560", VA = "0x185B15960")]
		private void OnTransformChildrenChanged()
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x5B15B50", Offset = "0x5B14750", VA = "0x185B15B50")]
		private void OnTransformParentChanged()
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x5B15B60", Offset = "0x5B14760", VA = "0x185B15B60")]
		internal void ReactToHierarchyChanged()
		{
		}

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		internal const string k_RootStyleClassName = "unity-ui-document__root";

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		internal const string k_VisualElementNameSuffix = "-container";

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		private const int k_DefaultSortingOrder = 0;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x0")]
		private static int s_CurrentUIDocumentCounter;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int m_UIDocumentCreationIndex;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PanelSettings m_PanelSettings;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x28")]
		private PanelSettings m_PreviousPanelSettings;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIDocument m_ParentUI;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x38")]
		private UIDocumentList m_ChildrenContent;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x40")]
		private List<UIDocument> m_ChildrenContentCopy;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VisualTreeAsset sourceAsset;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x50")]
		private VisualElement m_RootVisualElement;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x58")]
		private int m_FirstChildInsertIndex;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SortingOrder;
	}
}
