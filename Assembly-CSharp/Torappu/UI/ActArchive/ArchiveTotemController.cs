using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C44 RID: 27716
	[Token(Token = "0x2006C44")]
	public abstract class ArchiveTotemController : ActArchiveController
	{
		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x06027905 RID: 162053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D77")]
		public ArchiveTotemListDataBinder dataBinder
		{
			[Token(Token = "0x6027905")]
			[Address(RVA = "0x22C1040", Offset = "0x22BFC40", VA = "0x1822C1040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x06027906 RID: 162054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027907 RID: 162055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D78")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x6027906")]
			[Address(RVA = "0x22C10A0", Offset = "0x22BFCA0", VA = "0x1822C10A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027907")]
			[Address(RVA = "0x22C1100", Offset = "0x22BFD00", VA = "0x1822C1100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027908 RID: 162056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027908")]
		[Address(RVA = "0x22C0EC0", Offset = "0x22BFAC0", VA = "0x1822C0EC0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027909 RID: 162057
		[Token(Token = "0x6027909")]
		public abstract Sprite LoadItemIcon(TotemItemModel item);

		// Token: 0x0602790A RID: 162058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602790A")]
		[Address(RVA = "0x22C0FE0", Offset = "0x22BFBE0", VA = "0x1822C0FE0")]
		protected ArchiveTotemController()
		{
		}

		// Token: 0x0602790B RID: 162059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602790B")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0403819E RID: 229790
		[Token(Token = "0x403819E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveTotemListDataBinder _totemDataBinder;

		// Token: 0x040381A0 RID: 229792
		[Token(Token = "0x40381A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x040381A1 RID: 229793
		[Token(Token = "0x40381A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x040381A2 RID: 229794
		[Token(Token = "0x40381A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x040381A3 RID: 229795
		[Token(Token = "0x40381A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x040381A4 RID: 229796
		[Token(Token = "0x40381A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
