using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B8C RID: 27532
	[Token(Token = "0x2006B8C")]
	public class ArchiveFragmentListAdapter : LoopScrollAdapter<ArchiveFragmentListAdapter.ViewHolder, ArchiveFragmentGroupModel>, IHotfixable
	{
		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x06027543 RID: 161091 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027544 RID: 161092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE5")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6027543")]
			[Address(RVA = "0x22828A0", Offset = "0x22814A0", VA = "0x1822828A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027544")]
			[Address(RVA = "0x22829C0", Offset = "0x22815C0", VA = "0x1822829C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x06027545 RID: 161093 RVA: 0x000CE100 File Offset: 0x000CC300
		// (set) Token: 0x06027546 RID: 161094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE6")]
		public bool showSwitchAnim
		{
			[Token(Token = "0x6027545")]
			[Address(RVA = "0x2282960", Offset = "0x2281560", VA = "0x182282960")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6027546")]
			[Address(RVA = "0x2282AC0", Offset = "0x22816C0", VA = "0x182282AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x06027547 RID: 161095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027548 RID: 161096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE7")]
		public string selectedItemId
		{
			[Token(Token = "0x6027547")]
			[Address(RVA = "0x2282900", Offset = "0x2281500", VA = "0x182282900")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027548")]
			[Address(RVA = "0x2282A40", Offset = "0x2281640", VA = "0x182282A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027549 RID: 161097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027549")]
		[Address(RVA = "0x22824C0", Offset = "0x22810C0", VA = "0x1822824C0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602754A RID: 161098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602754A")]
		[Address(RVA = "0x2282640", Offset = "0x2281240", VA = "0x182282640", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, ArchiveFragmentListAdapter.ViewHolder holder, ArchiveFragmentGroupModel data)
		{
		}

		// Token: 0x0602754B RID: 161099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602754B")]
		[Address(RVA = "0x2282830", Offset = "0x2281430", VA = "0x182282830")]
		public ArchiveFragmentListAdapter()
		{
		}

		// Token: 0x04037B6D RID: 228205
		[Token(Token = "0x4037B6D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArchiveFragmentGroupView _itemPrefab;

		// Token: 0x04037B71 RID: 228209
		[Token(Token = "0x4037B71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04037B72 RID: 228210
		[Token(Token = "0x4037B72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04037B73 RID: 228211
		[Token(Token = "0x4037B73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showSwitchAnim;

		// Token: 0x04037B74 RID: 228212
		[Token(Token = "0x4037B74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showSwitchAnim;

		// Token: 0x04037B75 RID: 228213
		[Token(Token = "0x4037B75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x04037B76 RID: 228214
		[Token(Token = "0x4037B76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectedItemId;

		// Token: 0x04037B77 RID: 228215
		[Token(Token = "0x4037B77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04037B78 RID: 228216
		[Token(Token = "0x4037B78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04037B79 RID: 228217
		[Token(Token = "0x4037B79")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B8D RID: 27533
		[Token(Token = "0x2006B8D")]
		public class ViewHolder
		{
			// Token: 0x0602754C RID: 161100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602754C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04037B7A RID: 228218
			[Token(Token = "0x4037B7A")]
			[FieldOffset(Offset = "0x10")]
			public ArchiveFragmentGroupView view;
		}
	}
}
