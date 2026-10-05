using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B52 RID: 27474
	[Token(Token = "0x2006B52")]
	public class ArchiveCopperDataBinder : DataBinder<CopperProperty>, IHotfixable
	{
		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x06027436 RID: 160822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027437 RID: 160823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CC7")]
		public ArchiveCopperController controller
		{
			[Token(Token = "0x6027436")]
			[Address(RVA = "0x2270080", Offset = "0x226EC80", VA = "0x182270080")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027437")]
			[Address(RVA = "0x22700E0", Offset = "0x226ECE0", VA = "0x1822700E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027438")]
		[Address(RVA = "0x226FC60", Offset = "0x226E860", VA = "0x18226FC60", Slot = "7")]
		public override void OnValueChanged(CopperProperty property)
		{
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027439")]
		[Address(RVA = "0x226FEF0", Offset = "0x226EAF0", VA = "0x18226FEF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602743A RID: 160826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602743A")]
		[Address(RVA = "0x2270010", Offset = "0x226EC10", VA = "0x182270010")]
		public ArchiveCopperDataBinder()
		{
		}

		// Token: 0x04037932 RID: 227634
		[Token(Token = "0x4037932")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveCopperListAdapter _adapter;

		// Token: 0x04037933 RID: 227635
		[Token(Token = "0x4037933")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArchiveCopperInfoView _infoView;

		// Token: 0x04037934 RID: 227636
		[Token(Token = "0x4037934")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04037936 RID: 227638
		[Token(Token = "0x4037936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037937 RID: 227639
		[Token(Token = "0x4037937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037938 RID: 227640
		[Token(Token = "0x4037938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037939 RID: 227641
		[Token(Token = "0x4037939")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403793A RID: 227642
		[Token(Token = "0x403793A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
