using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD6 RID: 27350
	[Token(Token = "0x2006AD6")]
	public class WrathProxy : ActArchiveCompProxy<ArchiveWrathController>
	{
		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x060271F5 RID: 160245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C79")]
		protected override string compType
		{
			[Token(Token = "0x60271F5")]
			[Address(RVA = "0x2261AB0", Offset = "0x22606B0", VA = "0x182261AB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271F6 RID: 160246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271F6")]
		[Address(RVA = "0x2261630", Offset = "0x2260230", VA = "0x182261630", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271F7 RID: 160247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F7")]
		[Address(RVA = "0x2261700", Offset = "0x2260300", VA = "0x182261700", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271F8 RID: 160248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F8")]
		[Address(RVA = "0x2261940", Offset = "0x2260540", VA = "0x182261940")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271F9 RID: 160249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F9")]
		[Address(RVA = "0x2261A40", Offset = "0x2260640", VA = "0x182261A40")]
		public WrathProxy()
		{
		}

		// Token: 0x04037564 RID: 226660
		[Token(Token = "0x4037564")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037565 RID: 226661
		[Token(Token = "0x4037565")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037566 RID: 226662
		[Token(Token = "0x4037566")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037567 RID: 226663
		[Token(Token = "0x4037567")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04037568 RID: 226664
		[Token(Token = "0x4037568")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
