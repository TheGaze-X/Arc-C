using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B0C RID: 31500
	[Token(Token = "0x2007B0C")]
	public class Act12D6OuterBuffDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17006751 RID: 26449
		// (get) Token: 0x0602C1A2 RID: 180642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C1A3 RID: 180643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006751")]
		public PlayerOuterBuffData BuffData
		{
			[Token(Token = "0x602C1A2")]
			[Address(RVA = "0x28109B0", Offset = "0x280F5B0", VA = "0x1828109B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C1A3")]
			[Address(RVA = "0x2810A10", Offset = "0x280F610", VA = "0x182810A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C1A4 RID: 180644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1A4")]
		[Address(RVA = "0x2810720", Offset = "0x280F320", VA = "0x182810720")]
		public void LoadData()
		{
		}

		// Token: 0x0602C1A5 RID: 180645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1A5")]
		[Address(RVA = "0x2810950", Offset = "0x280F550", VA = "0x182810950")]
		public Act12D6OuterBuffDetailStateBean()
		{
		}

		// Token: 0x0403FF05 RID: 261893
		[Token(Token = "0x403FF05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_BuffData;

		// Token: 0x0403FF06 RID: 261894
		[Token(Token = "0x403FF06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_BuffData;

		// Token: 0x0403FF07 RID: 261895
		[Token(Token = "0x403FF07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403FF08 RID: 261896
		[Token(Token = "0x403FF08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
