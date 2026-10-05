using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437E RID: 17278
	[Token(Token = "0x200437E")]
	public class SandboxV2RacerTempItemViewModel : SandboxV2RacerModel, IHotfixable
	{
		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x0601A87B RID: 108667 RVA: 0x000A24B0 File Offset: 0x000A06B0
		[Token(Token = "0x17003EF0")]
		public override bool isTemp
		{
			[Token(Token = "0x601A87B")]
			[Address(RVA = "0x13B0060", Offset = "0x13AEC60", VA = "0x1813B0060", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x0601A87C RID: 108668 RVA: 0x000A24C8 File Offset: 0x000A06C8
		// (set) Token: 0x0601A87D RID: 108669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EF1")]
		public override bool isMarked
		{
			[Token(Token = "0x601A87C")]
			[Address(RVA = "0x13B0000", Offset = "0x13AEC00", VA = "0x1813B0000", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601A87D")]
			[Address(RVA = "0x13B01A0", Offset = "0x13AEDA0", VA = "0x1813B01A0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0601A87E RID: 108670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EF2")]
		public override string name
		{
			[Token(Token = "0x601A87E")]
			[Address(RVA = "0x13B0120", Offset = "0x13AED20", VA = "0x1813B0120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0601A87F RID: 108671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EF3")]
		public override List<SandboxV2RacerMedalModel> medalList
		{
			[Token(Token = "0x601A87F")]
			[Address(RVA = "0x13B00C0", Offset = "0x13AECC0", VA = "0x1813B00C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A880 RID: 108672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A880")]
		[Address(RVA = "0x13AFEF0", Offset = "0x13AEAF0", VA = "0x1813AFEF0")]
		public void LoadData(string topicId, SandboxV2RacingData gameData, string instId, PlayerSandboxV2.Racing.TempRacerInfo playerRacer)
		{
		}

		// Token: 0x0601A881 RID: 108673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A881")]
		[Address(RVA = "0x13AFFA0", Offset = "0x13AEBA0", VA = "0x1813AFFA0")]
		public SandboxV2RacerTempItemViewModel()
		{
		}

		// Token: 0x04021C40 RID: 138304
		[Token(Token = "0x4021C40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTemp;

		// Token: 0x04021C41 RID: 138305
		[Token(Token = "0x4021C41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMarked;

		// Token: 0x04021C42 RID: 138306
		[Token(Token = "0x4021C42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isMarked;

		// Token: 0x04021C43 RID: 138307
		[Token(Token = "0x4021C43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04021C44 RID: 138308
		[Token(Token = "0x4021C44")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_medalList;

		// Token: 0x04021C45 RID: 138309
		[Token(Token = "0x4021C45")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021C46 RID: 138310
		[Token(Token = "0x4021C46")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
