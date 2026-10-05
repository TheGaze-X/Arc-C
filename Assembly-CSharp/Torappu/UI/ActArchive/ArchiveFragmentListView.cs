using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B8E RID: 27534
	[Token(Token = "0x2006B8E")]
	public class ArchiveFragmentListView : DataBinder<FragmentProperty>, IHotfixable
	{
		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0602754D RID: 161101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602754E RID: 161102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE8")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602754D")]
			[Address(RVA = "0x2282F40", Offset = "0x2281B40", VA = "0x182282F40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602754E")]
			[Address(RVA = "0x2282FA0", Offset = "0x2281BA0", VA = "0x182282FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602754F RID: 161103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602754F")]
		[Address(RVA = "0x2282B30", Offset = "0x2281730", VA = "0x182282B30", Slot = "7")]
		public override void OnValueChanged(FragmentProperty property)
		{
		}

		// Token: 0x06027550 RID: 161104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027550")]
		[Address(RVA = "0x2282DB0", Offset = "0x22819B0", VA = "0x182282DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027551 RID: 161105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027551")]
		[Address(RVA = "0x2282ED0", Offset = "0x2281AD0", VA = "0x182282ED0")]
		public ArchiveFragmentListView()
		{
		}

		// Token: 0x04037B7B RID: 228219
		[Token(Token = "0x4037B7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveFragmentListAdapter _adapter;

		// Token: 0x04037B7C RID: 228220
		[Token(Token = "0x4037B7C")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04037B7E RID: 228222
		[Token(Token = "0x4037B7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04037B7F RID: 228223
		[Token(Token = "0x4037B7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04037B80 RID: 228224
		[Token(Token = "0x4037B80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037B81 RID: 228225
		[Token(Token = "0x4037B81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037B82 RID: 228226
		[Token(Token = "0x4037B82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
