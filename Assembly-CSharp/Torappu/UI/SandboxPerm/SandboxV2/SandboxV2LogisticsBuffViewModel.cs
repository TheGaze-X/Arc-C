using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004349 RID: 17225
	[Token(Token = "0x2004349")]
	public class SandboxV2LogisticsBuffViewModel : IHotfixable
	{
		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0601A734 RID: 108340 RVA: 0x000A1D90 File Offset: 0x0009FF90
		[Token(Token = "0x17003EC4")]
		public bool isFullBuff
		{
			[Token(Token = "0x601A734")]
			[Address(RVA = "0x1386320", Offset = "0x1384F20", VA = "0x181386320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0601A735 RID: 108341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EC5")]
		public string combinedDesc
		{
			[Token(Token = "0x601A735")]
			[Address(RVA = "0x13862C0", Offset = "0x1384EC0", VA = "0x1813862C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A736 RID: 108342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A736")]
		[Address(RVA = "0x1386260", Offset = "0x1384E60", VA = "0x181386260")]
		public SandboxV2LogisticsBuffViewModel()
		{
		}

		// Token: 0x04021A18 RID: 137752
		[Token(Token = "0x4021A18")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory profession;

		// Token: 0x04021A19 RID: 137753
		[Token(Token = "0x4021A19")]
		[FieldOffset(Offset = "0x14")]
		public int totalCount;

		// Token: 0x04021A1A RID: 137754
		[Token(Token = "0x4021A1A")]
		[FieldOffset(Offset = "0x18")]
		public int maxValidCount;

		// Token: 0x04021A1B RID: 137755
		[Token(Token = "0x4021A1B")]
		[FieldOffset(Offset = "0x20")]
		public string baseDesc;

		// Token: 0x04021A1C RID: 137756
		[Token(Token = "0x4021A1C")]
		[FieldOffset(Offset = "0x28")]
		public string buffParam;

		// Token: 0x04021A1D RID: 137757
		[Token(Token = "0x4021A1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isFullBuff;

		// Token: 0x04021A1E RID: 137758
		[Token(Token = "0x4021A1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_combinedDesc;

		// Token: 0x04021A1F RID: 137759
		[Token(Token = "0x4021A1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
