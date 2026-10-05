using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B33 RID: 27443
	[Token(Token = "0x2006B33")]
	public abstract class ArchiveChaosController : ActArchiveController
	{
		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x060273AF RID: 160687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273B0 RID: 160688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB3")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x60273AF")]
			[Address(RVA = "0x2268AA0", Offset = "0x22676A0", VA = "0x182268AA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273B0")]
			[Address(RVA = "0x2268B00", Offset = "0x2267700", VA = "0x182268B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x060273B1 RID: 160689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CB4")]
		public ArchiveChaosListDataBinder dataBinder
		{
			[Token(Token = "0x60273B1")]
			[Address(RVA = "0x2268A40", Offset = "0x2267640", VA = "0x182268A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060273B2 RID: 160690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273B2")]
		[Address(RVA = "0x22688C0", Offset = "0x22674C0", VA = "0x1822688C0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060273B3 RID: 160691
		[Token(Token = "0x60273B3")]
		public abstract Sprite LoadChaosIcon(string archiveId, string chaosId);

		// Token: 0x060273B4 RID: 160692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273B4")]
		[Address(RVA = "0x22689E0", Offset = "0x22675E0", VA = "0x1822689E0")]
		protected ArchiveChaosController()
		{
		}

		// Token: 0x060273B5 RID: 160693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273B5")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x04037819 RID: 227353
		[Token(Token = "0x4037819")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveChaosListDataBinder _chaosDataBinder;

		// Token: 0x0403781B RID: 227355
		[Token(Token = "0x403781B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403781C RID: 227356
		[Token(Token = "0x403781C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403781D RID: 227357
		[Token(Token = "0x403781D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x0403781E RID: 227358
		[Token(Token = "0x403781E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403781F RID: 227359
		[Token(Token = "0x403781F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
