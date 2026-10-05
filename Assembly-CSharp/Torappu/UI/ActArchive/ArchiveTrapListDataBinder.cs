using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C54 RID: 27732
	[Token(Token = "0x2006C54")]
	public class ArchiveTrapListDataBinder : DataBinder<TrapProperty>
	{
		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x06027962 RID: 162146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027963 RID: 162147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D8B")]
		public ArchiveTrapController controller
		{
			[Token(Token = "0x6027962")]
			[Address(RVA = "0x22C6010", Offset = "0x22C4C10", VA = "0x1822C6010")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027963")]
			[Address(RVA = "0x22C6070", Offset = "0x22C4C70", VA = "0x1822C6070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x06027964 RID: 162148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D8C")]
		public ArchiveTrapRecycleAdapter adapter
		{
			[Token(Token = "0x6027964")]
			[Address(RVA = "0x22C5FB0", Offset = "0x22C4BB0", VA = "0x1822C5FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027965 RID: 162149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027965")]
		[Address(RVA = "0x22C5E20", Offset = "0x22C4A20", VA = "0x1822C5E20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027966 RID: 162150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027966")]
		[Address(RVA = "0x22C5A80", Offset = "0x22C4680", VA = "0x1822C5A80", Slot = "7")]
		public override void OnValueChanged(TrapProperty property)
		{
		}

		// Token: 0x06027967 RID: 162151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027967")]
		[Address(RVA = "0x22C5F40", Offset = "0x22C4B40", VA = "0x1822C5F40")]
		public ArchiveTrapListDataBinder()
		{
		}

		// Token: 0x04038235 RID: 229941
		[Token(Token = "0x4038235")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveTrapRecycleAdapter _adapter;

		// Token: 0x04038236 RID: 229942
		[Token(Token = "0x4038236")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04038238 RID: 229944
		[Token(Token = "0x4038238")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038239 RID: 229945
		[Token(Token = "0x4038239")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403823A RID: 229946
		[Token(Token = "0x403823A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0403823B RID: 229947
		[Token(Token = "0x403823B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403823C RID: 229948
		[Token(Token = "0x403823C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403823D RID: 229949
		[Token(Token = "0x403823D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
