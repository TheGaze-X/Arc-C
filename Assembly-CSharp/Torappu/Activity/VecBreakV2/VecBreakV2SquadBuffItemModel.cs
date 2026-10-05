using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E90 RID: 28304
	[Token(Token = "0x2006E90")]
	public class VecBreakV2SquadBuffItemModel : IHotfixable
	{
		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x06028499 RID: 165017 RVA: 0x000D1430 File Offset: 0x000CF630
		// (set) Token: 0x0602849A RID: 165018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F30")]
		public bool isEmpty
		{
			[Token(Token = "0x6028499")]
			[Address(RVA = "0x23A6CE0", Offset = "0x23A58E0", VA = "0x1823A6CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602849A")]
			[Address(RVA = "0x23A6DC0", Offset = "0x23A59C0", VA = "0x1823A6DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x0602849B RID: 165019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602849C RID: 165020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F31")]
		public string iconId
		{
			[Token(Token = "0x602849B")]
			[Address(RVA = "0x23A6C80", Offset = "0x23A5880", VA = "0x1823A6C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602849C")]
			[Address(RVA = "0x23A6D40", Offset = "0x23A5940", VA = "0x1823A6D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602849D RID: 165021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602849D")]
		[Address(RVA = "0x23A6AD0", Offset = "0x23A56D0", VA = "0x1823A6AD0")]
		public void LoadData(ActVecBreakV2Data actData, string buffId)
		{
		}

		// Token: 0x0602849E RID: 165022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602849E")]
		[Address(RVA = "0x23A6C20", Offset = "0x23A5820", VA = "0x1823A6C20")]
		public VecBreakV2SquadBuffItemModel()
		{
		}

		// Token: 0x04039419 RID: 234521
		[Token(Token = "0x4039419")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403941A RID: 234522
		[Token(Token = "0x403941A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEmpty;

		// Token: 0x0403941B RID: 234523
		[Token(Token = "0x403941B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x0403941C RID: 234524
		[Token(Token = "0x403941C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_iconId;

		// Token: 0x0403941D RID: 234525
		[Token(Token = "0x403941D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403941E RID: 234526
		[Token(Token = "0x403941E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
