using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E8F RID: 28303
	[Token(Token = "0x2006E8F")]
	public class VecBreakV2SquadBuffViewModel : IHotfixable
	{
		// Token: 0x06028490 RID: 165008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028490")]
		[Address(RVA = "0x23A76B0", Offset = "0x23A62B0", VA = "0x1823A76B0")]
		private VecBreakV2SquadBuffViewModel()
		{
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x06028491 RID: 165009 RVA: 0x000D1418 File Offset: 0x000CF618
		// (set) Token: 0x06028492 RID: 165010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F2D")]
		public bool canUseBuff
		{
			[Token(Token = "0x6028491")]
			[Address(RVA = "0x23A77D0", Offset = "0x23A63D0", VA = "0x1823A77D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028492")]
			[Address(RVA = "0x23A7930", Offset = "0x23A6530", VA = "0x1823A7930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x06028493 RID: 165011 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028494 RID: 165012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F2E")]
		public List<VecBreakV2SquadBuffItemModel> buffItemList
		{
			[Token(Token = "0x6028493")]
			[Address(RVA = "0x23A7770", Offset = "0x23A6370", VA = "0x1823A7770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028494")]
			[Address(RVA = "0x23A78B0", Offset = "0x23A64B0", VA = "0x1823A78B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x06028495 RID: 165013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028496 RID: 165014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F2F")]
		public string actId
		{
			[Token(Token = "0x6028495")]
			[Address(RVA = "0x23A7710", Offset = "0x23A6310", VA = "0x1823A7710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028496")]
			[Address(RVA = "0x23A7830", Offset = "0x23A6430", VA = "0x1823A7830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028497 RID: 165015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028497")]
		[Address(RVA = "0x23A7010", Offset = "0x23A5C10", VA = "0x1823A7010")]
		public static VecBreakV2SquadBuffViewModel Create(string stageId)
		{
			return null;
		}

		// Token: 0x06028498 RID: 165016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028498")]
		[Address(RVA = "0x23A7190", Offset = "0x23A5D90", VA = "0x1823A7190")]
		private void _LoadData(bool canUseBuff, ActVecBreakV2Data actData, PlayerActivity.PlayerVecBreakV2 playerActData, string actId)
		{
		}

		// Token: 0x0403940E RID: 234510
		[Token(Token = "0x403940E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403940F RID: 234511
		[Token(Token = "0x403940F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canUseBuff;

		// Token: 0x04039410 RID: 234512
		[Token(Token = "0x4039410")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_canUseBuff;

		// Token: 0x04039411 RID: 234513
		[Token(Token = "0x4039411")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_buffItemList;

		// Token: 0x04039412 RID: 234514
		[Token(Token = "0x4039412")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_buffItemList;

		// Token: 0x04039413 RID: 234515
		[Token(Token = "0x4039413")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039414 RID: 234516
		[Token(Token = "0x4039414")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039415 RID: 234517
		[Token(Token = "0x4039415")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04039416 RID: 234518
		[Token(Token = "0x4039416")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadData;
	}
}
