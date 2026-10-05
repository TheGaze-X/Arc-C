using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C46 RID: 27718
	[Token(Token = "0x2006C46")]
	public class ArchiveTotemListDataBinder : DataBinder<TotemProperty>
	{
		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x06027910 RID: 162064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027911 RID: 162065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D7A")]
		public ArchiveTotemController controller
		{
			[Token(Token = "0x6027910")]
			[Address(RVA = "0x22C1DE0", Offset = "0x22C09E0", VA = "0x1822C1DE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027911")]
			[Address(RVA = "0x22C1E40", Offset = "0x22C0A40", VA = "0x1822C1E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027912 RID: 162066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027912")]
		[Address(RVA = "0x22C16F0", Offset = "0x22C02F0", VA = "0x1822C16F0", Slot = "7")]
		public override void OnValueChanged(TotemProperty property)
		{
		}

		// Token: 0x06027913 RID: 162067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027913")]
		[Address(RVA = "0x22C1B90", Offset = "0x22C0790", VA = "0x1822C1B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027914 RID: 162068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027914")]
		[Address(RVA = "0x22C1D70", Offset = "0x22C0970", VA = "0x1822C1D70")]
		public ArchiveTotemListDataBinder()
		{
		}

		// Token: 0x040381B6 RID: 229814
		[Token(Token = "0x40381B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveTotemDetailView _detailView;

		// Token: 0x040381B7 RID: 229815
		[Token(Token = "0x40381B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveTotemRecycleAdapter _adapter;

		// Token: 0x040381B8 RID: 229816
		[Token(Token = "0x40381B8")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040381BA RID: 229818
		[Token(Token = "0x40381BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040381BB RID: 229819
		[Token(Token = "0x40381BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040381BC RID: 229820
		[Token(Token = "0x40381BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040381BD RID: 229821
		[Token(Token = "0x40381BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040381BE RID: 229822
		[Token(Token = "0x40381BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
