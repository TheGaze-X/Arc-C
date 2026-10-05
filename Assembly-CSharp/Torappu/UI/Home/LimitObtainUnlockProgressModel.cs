using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BA5 RID: 19365
	[Token(Token = "0x2004BA5")]
	public class LimitObtainUnlockProgressModel : IHotfixable
	{
		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x0601D1FA RID: 119290 RVA: 0x000AA988 File Offset: 0x000A8B88
		[Token(Token = "0x1700448B")]
		public bool isEmpty
		{
			[Token(Token = "0x601D1FA")]
			[Address(RVA = "0x16AA7F0", Offset = "0x16A93F0", VA = "0x1816AA7F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1FB")]
		[Address(RVA = "0x16AA770", Offset = "0x16A9370", VA = "0x1816AA770")]
		public LimitObtainUnlockProgressModel()
		{
		}

		// Token: 0x04026371 RID: 156529
		[Token(Token = "0x4026371")]
		[FieldOffset(Offset = "0x10")]
		public string unlockDes;

		// Token: 0x04026372 RID: 156530
		[Token(Token = "0x4026372")]
		[FieldOffset(Offset = "0x18")]
		public int curProgress;

		// Token: 0x04026373 RID: 156531
		[Token(Token = "0x4026373")]
		[FieldOffset(Offset = "0x1C")]
		public int total;

		// Token: 0x04026374 RID: 156532
		[Token(Token = "0x4026374")]
		[FieldOffset(Offset = "0x0")]
		public static readonly LimitObtainUnlockProgressModel DEFAULT;

		// Token: 0x04026375 RID: 156533
		[Token(Token = "0x4026375")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04026376 RID: 156534
		[Token(Token = "0x4026376")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
