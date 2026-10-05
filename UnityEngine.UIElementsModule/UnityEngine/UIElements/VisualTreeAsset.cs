using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	[HelpURL("UIE-VisualTree-landing")]
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public bool importedWithErrors
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x5B238D0", Offset = "0x5B224D0", VA = "0x185B238D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			internal set
			{
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00009AF8 File Offset: 0x00007CF8
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000486")]
		public bool importedWithWarnings
		{
			[Token(Token = "0x60011DE")]
			[Address(RVA = "0x5B238E0", Offset = "0x5B224E0", VA = "0x185B238E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			internal set
			{
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x5B33100", Offset = "0x5B31D00", VA = "0x185B33100")]
		internal int GetNextChildSerialNumber()
		{
			return 0;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000487")]
		public IEnumerable<VisualTreeAsset> templateDependencies
		{
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x5B33930", Offset = "0x5B32530", VA = "0x185B33930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000488")]
		public IEnumerable<StyleSheet> stylesheets
		{
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x5B338A0", Offset = "0x5B324A0", VA = "0x185B338A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000489")]
		internal List<VisualElementAsset> visualElementAssets
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x5964990", Offset = "0x5963590", VA = "0x185964990")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		internal List<TemplateAsset> templateAssets
		{
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x59976A0", Offset = "0x59962A0", VA = "0x1859976A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048B")]
		internal List<VisualTreeAsset.SlotDefinition> slots
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x59976F0", Offset = "0x59962F0", VA = "0x1859976F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00009B28 File Offset: 0x00007D28
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		internal int contentContainerId
		{
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x59F2270", Offset = "0x59F0E70", VA = "0x1859F2270")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			set
			{
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x5B33160", Offset = "0x5B31D60", VA = "0x185B33160")]
		public TemplateContainer Instantiate()
		{
			return null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x5B32600", Offset = "0x5B31200", VA = "0x185B32600")]
		public TemplateContainer Instantiate(string bindingPath)
		{
			return null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x5B327E0", Offset = "0x5B313E0", VA = "0x185B327E0")]
		public TemplateContainer CloneTree()
		{
			return null;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x5B32600", Offset = "0x5B31200", VA = "0x185B32600")]
		public TemplateContainer CloneTree(string bindingPath)
		{
			return null;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x5B31E20", Offset = "0x5B30A20", VA = "0x185B31E20")]
		public void CloneTree(VisualElement target)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x5B32650", Offset = "0x5B31250", VA = "0x185B32650")]
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x5B31E50", Offset = "0x5B30A50", VA = "0x185B31E50")]
		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x5B31410", Offset = "0x5B30010", VA = "0x185B31410")]
		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
		{
			return null;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x5B327F0", Offset = "0x5B313F0", VA = "0x185B327F0")]
		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			return 0;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x5B33570", Offset = "0x5B32170", VA = "0x185B33570")]
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			return default(bool);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x5B332D0", Offset = "0x5B31ED0", VA = "0x185B332D0")]
		internal VisualTreeAsset ResolveTemplate(string templateName)
		{
			return null;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x5B32820", Offset = "0x5B31420", VA = "0x185B32820")]
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
		{
			return null;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x5B31060", Offset = "0x5B2FC60", VA = "0x185B31060")]
		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x5B310D0", Offset = "0x5B2FCD0", VA = "0x185B310D0")]
		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00009B70 File Offset: 0x00007D70
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048D")]
		public int contentHash
		{
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x5B33890", Offset = "0x5B32490", VA = "0x185B33890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x150B100", Offset = "0x1509D00", VA = "0x18150B100")]
			set
			{
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public VisualTreeAsset()
		{
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x5B33650", Offset = "0x5B32250", VA = "0x185B33650")]
		[CompilerGenerated]
		internal static VisualElement <Create>g__CreateError|49_0(ref VisualTreeAsset.<>c__DisplayClass49_0 A_0)
		{
			return null;
		}

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x0")]
		internal static string LinkedVEAInTemplatePropertyName;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ImportedWithErrors;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_ImportedWithWarnings;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VisualTreeAsset.UsingEntry> m_Usings;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal StyleSheet inlineSheet;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<VisualElementAsset> m_VisualElementAssets;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<TemplateAsset> m_TemplateAssets;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<VisualTreeAsset.SlotDefinition> m_Slots;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int m_ContentContainerId;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int m_ContentHash;

		// Token: 0x02000288 RID: 648
		[Token(Token = "0x2000288")]
		[Serializable]
		internal struct UsingEntry
		{
			// Token: 0x060011FE RID: 4606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011FE")]
			[Address(RVA = "0x5B2CB50", Offset = "0x5B2B750", VA = "0x185B2CB50")]
			public UsingEntry(string alias, string path)
			{
			}

			// Token: 0x0400094F RID: 2383
			[Token(Token = "0x400094F")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly IComparer<VisualTreeAsset.UsingEntry> comparer;

			// Token: 0x04000950 RID: 2384
			[Token(Token = "0x4000950")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string alias;

			// Token: 0x04000951 RID: 2385
			[Token(Token = "0x4000951")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string path;

			// Token: 0x04000952 RID: 2386
			[Token(Token = "0x4000952")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public VisualTreeAsset asset;
		}

		// Token: 0x02000289 RID: 649
		[Token(Token = "0x2000289")]
		private class UsingEntryComparer : IComparer<VisualTreeAsset.UsingEntry>
		{
			// Token: 0x06001200 RID: 4608 RVA: 0x00009B88 File Offset: 0x00007D88
			[Token(Token = "0x6001200")]
			[Address(RVA = "0x5B2CAA0", Offset = "0x5B2B6A0", VA = "0x185B2CAA0", Slot = "4")]
			public int Compare(VisualTreeAsset.UsingEntry x, VisualTreeAsset.UsingEntry y)
			{
				return 0;
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001201")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UsingEntryComparer()
			{
			}
		}

		// Token: 0x0200028A RID: 650
		[Token(Token = "0x200028A")]
		[Serializable]
		internal struct SlotDefinition
		{
			// Token: 0x04000953 RID: 2387
			[Token(Token = "0x4000953")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string name;

			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int insertionPointId;
		}

		// Token: 0x0200028B RID: 651
		[Token(Token = "0x200028B")]
		[Serializable]
		internal struct SlotUsageEntry
		{
			// Token: 0x04000955 RID: 2389
			[Token(Token = "0x4000955")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string slotName;

			// Token: 0x04000956 RID: 2390
			[Token(Token = "0x4000956")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int assetId;
		}
	}
}
