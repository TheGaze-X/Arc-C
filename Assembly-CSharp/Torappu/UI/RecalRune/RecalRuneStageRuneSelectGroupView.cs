using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047C1 RID: 18369
	[Token(Token = "0x20047C1")]
	public class RecalRuneStageRuneSelectGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BCE7 RID: 113895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCE7")]
		[Address(RVA = "0x1532890", Offset = "0x1531490", VA = "0x181532890")]
		public void Render(IRecalRuneRuneGroup iGroup, RecalRuneStageRuneItemViewModel focusedItem, bool fastMode)
		{
		}

		// Token: 0x0601BCE8 RID: 113896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCE8")]
		[Address(RVA = "0x1532780", Offset = "0x1531380", VA = "0x181532780")]
		private void InitIfNot()
		{
		}

		// Token: 0x0601BCE9 RID: 113897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCE9")]
		[Address(RVA = "0x1532D10", Offset = "0x1531910", VA = "0x181532D10")]
		public RecalRuneStageRuneSelectGroupView()
		{
		}

		// Token: 0x040242BA RID: 148154
		[Token(Token = "0x40242BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> _fixedVariants;

		// Token: 0x040242BB RID: 148155
		[Token(Token = "0x40242BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _exclusiveVariants;

		// Token: 0x040242BC RID: 148156
		[Token(Token = "0x40242BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _runeGroup;

		// Token: 0x040242BD RID: 148157
		[Token(Token = "0x40242BD")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040242BE RID: 148158
		[Token(Token = "0x40242BE")]
		[FieldOffset(Offset = "0x38")]
		private RecalRuneStageRuneSelectGroupView.Adapter m_adapter;

		// Token: 0x040242BF RID: 148159
		[Token(Token = "0x40242BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040242C0 RID: 148160
		[Token(Token = "0x40242C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x040242C1 RID: 148161
		[Token(Token = "0x40242C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047C2 RID: 18370
		[Token(Token = "0x20047C2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004220 RID: 16928
			// (get) Token: 0x0601BCEA RID: 113898 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601BCEB RID: 113899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004220")]
			public List<RecalRuneStageRuneItemViewModel> dataSource
			{
				[Token(Token = "0x601BCEA")]
				[Address(RVA = "0x1520DD0", Offset = "0x151F9D0", VA = "0x181520DD0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601BCEB")]
				[Address(RVA = "0x1520F50", Offset = "0x151FB50", VA = "0x181520F50")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004221 RID: 16929
			// (get) Token: 0x0601BCEC RID: 113900 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601BCED RID: 113901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004221")]
			public RecalRuneStageRuneItemViewModel focusedItem
			{
				[Token(Token = "0x601BCEC")]
				[Address(RVA = "0x1520E90", Offset = "0x151FA90", VA = "0x181520E90")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601BCED")]
				[Address(RVA = "0x1521040", Offset = "0x151FC40", VA = "0x181521040")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0601BCEE RID: 113902 RVA: 0x000A6548 File Offset: 0x000A4748
			// (set) Token: 0x0601BCEF RID: 113903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004222")]
			public bool fastMode
			{
				[Token(Token = "0x601BCEE")]
				[Address(RVA = "0x1520E30", Offset = "0x151FA30", VA = "0x181520E30")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x601BCEF")]
				[Address(RVA = "0x1520FD0", Offset = "0x151FBD0", VA = "0x181520FD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0601BCF0 RID: 113904 RVA: 0x000A6560 File Offset: 0x000A4760
			[Token(Token = "0x17004223")]
			public override int count
			{
				[Token(Token = "0x601BCF0")]
				[Address(RVA = "0x1520D10", Offset = "0x151F910", VA = "0x181520D10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BCF1 RID: 113905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BCF1")]
			[Address(RVA = "0x1520910", Offset = "0x151F510", VA = "0x181520910", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601BCF2 RID: 113906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCF2")]
			[Address(RVA = "0x1520B90", Offset = "0x151F790", VA = "0x181520B90")]
			public Adapter()
			{
			}

			// Token: 0x040242C5 RID: 148165
			[Token(Token = "0x40242C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x040242C6 RID: 148166
			[Token(Token = "0x40242C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x040242C7 RID: 148167
			[Token(Token = "0x40242C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_focusedItem;

			// Token: 0x040242C8 RID: 148168
			[Token(Token = "0x40242C8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_focusedItem;

			// Token: 0x040242C9 RID: 148169
			[Token(Token = "0x40242C9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_fastMode;

			// Token: 0x040242CA RID: 148170
			[Token(Token = "0x40242CA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_fastMode;

			// Token: 0x040242CB RID: 148171
			[Token(Token = "0x40242CB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040242CC RID: 148172
			[Token(Token = "0x40242CC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040242CD RID: 148173
			[Token(Token = "0x40242CD")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
