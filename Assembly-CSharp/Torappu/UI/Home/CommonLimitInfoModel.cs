using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B9D RID: 19357
	[Token(Token = "0x2004B9D")]
	public class CommonLimitInfoModel : ICommonLimitInfoModel, IComparable<ICommonLimitInfoModel>, ITimeValidInfo, IHotfixable
	{
		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x0601D1E1 RID: 119265 RVA: 0x000AA910 File Offset: 0x000A8B10
		// (set) Token: 0x0601D1E2 RID: 119266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004486")]
		public long startTs
		{
			[Token(Token = "0x601D1E1")]
			[Address(RVA = "0x1699D20", Offset = "0x1698920", VA = "0x181699D20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601D1E2")]
			[Address(RVA = "0x1699E70", Offset = "0x1698A70", VA = "0x181699E70", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x0601D1E3 RID: 119267 RVA: 0x000AA928 File Offset: 0x000A8B28
		// (set) Token: 0x0601D1E4 RID: 119268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004487")]
		public long endTs
		{
			[Token(Token = "0x601D1E3")]
			[Address(RVA = "0x1699CC0", Offset = "0x16988C0", VA = "0x181699CC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601D1E4")]
			[Address(RVA = "0x1699E00", Offset = "0x1698A00", VA = "0x181699E00", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x0601D1E5 RID: 119269 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D1E6 RID: 119270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004488")]
		public string canNotGainDesc
		{
			[Token(Token = "0x601D1E5")]
			[Address(RVA = "0x1699C60", Offset = "0x1698860", VA = "0x181699C60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D1E6")]
			[Address(RVA = "0x1699D80", Offset = "0x1698980", VA = "0x181699D80", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D1E7 RID: 119271 RVA: 0x000AA940 File Offset: 0x000A8B40
		[Token(Token = "0x601D1E7")]
		[Address(RVA = "0x16999F0", Offset = "0x16985F0", VA = "0x1816999F0", Slot = "10")]
		public int CompareTo(ICommonLimitInfoModel other)
		{
			return 0;
		}

		// Token: 0x0601D1E8 RID: 119272 RVA: 0x000AA958 File Offset: 0x000A8B58
		[Token(Token = "0x601D1E8")]
		[Address(RVA = "0x1699B70", Offset = "0x1698770", VA = "0x181699B70", Slot = "11")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x0601D1E9 RID: 119273 RVA: 0x000AA970 File Offset: 0x000A8B70
		[Token(Token = "0x601D1E9")]
		[Address(RVA = "0x1699AE0", Offset = "0x16986E0", VA = "0x181699AE0", Slot = "12")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x0601D1EA RID: 119274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1EA")]
		[Address(RVA = "0x1699C00", Offset = "0x1698800", VA = "0x181699C00")]
		public CommonLimitInfoModel()
		{
		}

		// Token: 0x04026354 RID: 156500
		[Token(Token = "0x4026354")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_startTs;

		// Token: 0x04026355 RID: 156501
		[Token(Token = "0x4026355")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startTs;

		// Token: 0x04026356 RID: 156502
		[Token(Token = "0x4026356")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_endTs;

		// Token: 0x04026357 RID: 156503
		[Token(Token = "0x4026357")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_endTs;

		// Token: 0x04026358 RID: 156504
		[Token(Token = "0x4026358")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_canNotGainDesc;

		// Token: 0x04026359 RID: 156505
		[Token(Token = "0x4026359")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_canNotGainDesc;

		// Token: 0x0402635A RID: 156506
		[Token(Token = "0x402635A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402635B RID: 156507
		[Token(Token = "0x402635B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetStartTs;

		// Token: 0x0402635C RID: 156508
		[Token(Token = "0x402635C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEndTs;

		// Token: 0x0402635D RID: 156509
		[Token(Token = "0x402635D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
