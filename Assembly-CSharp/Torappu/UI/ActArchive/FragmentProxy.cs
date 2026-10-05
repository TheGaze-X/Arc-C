using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD4 RID: 27348
	[Token(Token = "0x2006AD4")]
	public class FragmentProxy : ActArchiveCompProxy<ArchiveFragmentController>
	{
		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x060271EB RID: 160235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C77")]
		protected override string compType
		{
			[Token(Token = "0x60271EB")]
			[Address(RVA = "0x225D710", Offset = "0x225C310", VA = "0x18225D710", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271EC RID: 160236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271EC")]
		[Address(RVA = "0x225D270", Offset = "0x225BE70", VA = "0x18225D270", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271ED RID: 160237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271ED")]
		[Address(RVA = "0x225D340", Offset = "0x225BF40", VA = "0x18225D340", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271EE RID: 160238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271EE")]
		[Address(RVA = "0x225D5A0", Offset = "0x225C1A0", VA = "0x18225D5A0")]
		private void _OnItemClicked(string id)
		{
		}

		// Token: 0x060271EF RID: 160239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271EF")]
		[Address(RVA = "0x225D6A0", Offset = "0x225C2A0", VA = "0x18225D6A0")]
		public FragmentProxy()
		{
		}

		// Token: 0x0403755A RID: 226650
		[Token(Token = "0x403755A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403755B RID: 226651
		[Token(Token = "0x403755B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403755C RID: 226652
		[Token(Token = "0x403755C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403755D RID: 226653
		[Token(Token = "0x403755D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403755E RID: 226654
		[Token(Token = "0x403755E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
