using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010F7 RID: 4343
	[Token(Token = "0x20010F7")]
	[Serializable]
	public class CommonAvailCheck : ITimeValidInfo
	{
		// Token: 0x06006EA1 RID: 28321 RVA: 0x00032208 File Offset: 0x00030408
		[Token(Token = "0x6006EA1")]
		[Address(RVA = "0x780A70", Offset = "0x77F670", VA = "0x180780A70")]
		public bool ShouldSerializestageUnlockParam()
		{
			return default(bool);
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x00032220 File Offset: 0x00030420
		[Token(Token = "0x6006EA2")]
		[Address(RVA = "0x21005D0", Offset = "0x20FF1D0", VA = "0x1821005D0")]
		public bool ShouldSerializecharUnlockParam()
		{
			return default(bool);
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x00032238 File Offset: 0x00030438
		[Token(Token = "0x6006EA3")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06006EA4 RID: 28324 RVA: 0x00032250 File Offset: 0x00030450
		[Token(Token = "0x6006EA4")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06006EA5 RID: 28325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonAvailCheck()
		{
		}

		// Token: 0x04005D0E RID: 23822
		[Token(Token = "0x4005D0E")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04005D0F RID: 23823
		[Token(Token = "0x4005D0F")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;

		// Token: 0x04005D10 RID: 23824
		[Token(Token = "0x4005D10")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public CommonUnlockType type;

		// Token: 0x04005D11 RID: 23825
		[Token(Token = "0x4005D11")]
		[FieldOffset(Offset = "0x24")]
		public float rate;

		// Token: 0x04005D12 RID: 23826
		[Token(Token = "0x4005D12")]
		[FieldOffset(Offset = "0x28")]
		public StageUnlockParam stageUnlockParam;

		// Token: 0x04005D13 RID: 23827
		[Token(Token = "0x4005D13")]
		[FieldOffset(Offset = "0x30")]
		public CharUnlockParam charUnlockParam;
	}
}
