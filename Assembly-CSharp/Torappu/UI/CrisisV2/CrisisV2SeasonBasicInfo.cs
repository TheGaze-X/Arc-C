using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200590A RID: 22794
	[Token(Token = "0x200590A")]
	public struct CrisisV2SeasonBasicInfo : IHotfixable
	{
		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x06021371 RID: 136049 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021372 RID: 136050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF2")]
		public string id
		{
			[Token(Token = "0x6021371")]
			[Address(RVA = "0x1B91910", Offset = "0x1B90510", VA = "0x181B91910")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6021372")]
			[Address(RVA = "0x1B91C80", Offset = "0x1B90880", VA = "0x181B91C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x06021373 RID: 136051 RVA: 0x000B8F08 File Offset: 0x000B7108
		// (set) Token: 0x06021374 RID: 136052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF3")]
		public long startTs
		{
			[Token(Token = "0x6021373")]
			[Address(RVA = "0x1B91B50", Offset = "0x1B90750", VA = "0x181B91B50")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6021374")]
			[Address(RVA = "0x1B91F40", Offset = "0x1B90B40", VA = "0x181B91F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x06021375 RID: 136053 RVA: 0x000B8F20 File Offset: 0x000B7120
		// (set) Token: 0x06021376 RID: 136054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF4")]
		public long endTs
		{
			[Token(Token = "0x6021375")]
			[Address(RVA = "0x1B91880", Offset = "0x1B90480", VA = "0x181B91880")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6021376")]
			[Address(RVA = "0x1B91BE0", Offset = "0x1B907E0", VA = "0x181B91BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x06021377 RID: 136055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021378 RID: 136056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF5")]
		public string name
		{
			[Token(Token = "0x6021377")]
			[Address(RVA = "0x1B91A30", Offset = "0x1B90630", VA = "0x181B91A30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6021378")]
			[Address(RVA = "0x1B91DE0", Offset = "0x1B909E0", VA = "0x181B91DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06021379 RID: 136057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602137A RID: 136058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF6")]
		public PlayerCrisisV2Season playerSeason
		{
			[Token(Token = "0x6021379")]
			[Address(RVA = "0x1B91AC0", Offset = "0x1B906C0", VA = "0x181B91AC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x602137A")]
			[Address(RVA = "0x1B91E90", Offset = "0x1B90A90", VA = "0x181B91E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x0602137B RID: 136059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602137C RID: 136060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DF7")]
		public string medalGroup
		{
			[Token(Token = "0x602137B")]
			[Address(RVA = "0x1B919A0", Offset = "0x1B905A0", VA = "0x181B919A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x602137C")]
			[Address(RVA = "0x1B91D30", Offset = "0x1B90930", VA = "0x181B91D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602137D RID: 136061 RVA: 0x000B8F38 File Offset: 0x000B7138
		[Token(Token = "0x602137D")]
		[Address(RVA = "0x1B91490", Offset = "0x1B90090", VA = "0x181B91490")]
		public static CrisisV2SeasonBasicInfo LoadCurrentSeason()
		{
			return default(CrisisV2SeasonBasicInfo);
		}

		// Token: 0x0602137E RID: 136062 RVA: 0x000B8F50 File Offset: 0x000B7150
		[Token(Token = "0x602137E")]
		[Address(RVA = "0x1B913B0", Offset = "0x1B8FFB0", VA = "0x181B913B0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0402D3E1 RID: 185313
		[Token(Token = "0x402D3E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CrisisV2SeasonBasicInfo EMPTY;

		// Token: 0x0402D3E8 RID: 185320
		[Token(Token = "0x402D3E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0402D3E9 RID: 185321
		[Token(Token = "0x402D3E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x0402D3EA RID: 185322
		[Token(Token = "0x402D3EA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_startTs;

		// Token: 0x0402D3EB RID: 185323
		[Token(Token = "0x402D3EB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_startTs;

		// Token: 0x0402D3EC RID: 185324
		[Token(Token = "0x402D3EC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_endTs;

		// Token: 0x0402D3ED RID: 185325
		[Token(Token = "0x402D3ED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_endTs;

		// Token: 0x0402D3EE RID: 185326
		[Token(Token = "0x402D3EE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402D3EF RID: 185327
		[Token(Token = "0x402D3EF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402D3F0 RID: 185328
		[Token(Token = "0x402D3F0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_playerSeason;

		// Token: 0x0402D3F1 RID: 185329
		[Token(Token = "0x402D3F1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_playerSeason;

		// Token: 0x0402D3F2 RID: 185330
		[Token(Token = "0x402D3F2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_medalGroup;

		// Token: 0x0402D3F3 RID: 185331
		[Token(Token = "0x402D3F3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_medalGroup;

		// Token: 0x0402D3F4 RID: 185332
		[Token(Token = "0x402D3F4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadCurrentSeason;

		// Token: 0x0402D3F5 RID: 185333
		[Token(Token = "0x402D3F5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsEmpty;
	}
}
