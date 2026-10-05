using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001813 RID: 6163
	[Token(Token = "0x2001813")]
	public struct ManufactSnapshot : IHotfixable
	{
		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
		[Token(Token = "0x17001130")]
		public int remainSecsForProgress
		{
			[Token(Token = "0x6009BFD")]
			[Address(RVA = "0x31627B0", Offset = "0x31613B0", VA = "0x1831627B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x0003CC00 File Offset: 0x0003AE00
		[Token(Token = "0x17001131")]
		public bool isEmpty
		{
			[Token(Token = "0x6009BFE")]
			[Address(RVA = "0x31625F0", Offset = "0x31611F0", VA = "0x1831625F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x0003CC18 File Offset: 0x0003AE18
		[Token(Token = "0x17001132")]
		public int outputWeight
		{
			[Token(Token = "0x6009BFF")]
			[Address(RVA = "0x3162710", Offset = "0x3161310", VA = "0x183162710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040092A8 RID: 37544
		[Token(Token = "0x40092A8")]
		[FieldOffset(Offset = "0x0")]
		public static ManufactSnapshot DEFAULT;

		// Token: 0x040092A9 RID: 37545
		[Token(Token = "0x40092A9")]
		[FieldOffset(Offset = "0x0")]
		public DateTime time;

		// Token: 0x040092AA RID: 37546
		[Token(Token = "0x40092AA")]
		[FieldOffset(Offset = "0x8")]
		public string formulaId;

		// Token: 0x040092AB RID: 37547
		[Token(Token = "0x40092AB")]
		[FieldOffset(Offset = "0x10")]
		public int weight;

		// Token: 0x040092AC RID: 37548
		[Token(Token = "0x40092AC")]
		[FieldOffset(Offset = "0x14")]
		public int outputSolutionCount;

		// Token: 0x040092AD RID: 37549
		[Token(Token = "0x40092AD")]
		[FieldOffset(Offset = "0x18")]
		public int remainSolutionCount;

		// Token: 0x040092AE RID: 37550
		[Token(Token = "0x40092AE")]
		[FieldOffset(Offset = "0x1C")]
		public int nextRemainSecs;

		// Token: 0x040092AF RID: 37551
		[Token(Token = "0x40092AF")]
		[FieldOffset(Offset = "0x20")]
		public double baseRemainPoint;

		// Token: 0x040092B0 RID: 37552
		[Token(Token = "0x40092B0")]
		[FieldOffset(Offset = "0x28")]
		public int totalRemainSecs;

		// Token: 0x040092B1 RID: 37553
		[Token(Token = "0x40092B1")]
		[FieldOffset(Offset = "0x30")]
		public long saveTime;

		// Token: 0x040092B2 RID: 37554
		[Token(Token = "0x40092B2")]
		[FieldOffset(Offset = "0x38")]
		public ShallowEqualArray<ItemBundle> costs;

		// Token: 0x040092B3 RID: 37555
		[Token(Token = "0x40092B3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_remainSecsForProgress;

		// Token: 0x040092B4 RID: 37556
		[Token(Token = "0x40092B4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x040092B5 RID: 37557
		[Token(Token = "0x40092B5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_outputWeight;
	}
}
