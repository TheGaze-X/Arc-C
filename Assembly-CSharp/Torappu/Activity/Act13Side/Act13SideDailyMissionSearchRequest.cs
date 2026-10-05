using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D0 RID: 31184
	[Token(Token = "0x20079D0")]
	public class Act13SideDailyMissionSearchRequest
	{
		// Token: 0x0602BBDB RID: 179163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBDB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13SideDailyMissionSearchRequest()
		{
		}

		// Token: 0x0403F477 RID: 259191
		[Token(Token = "0x403F477")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403F478 RID: 259192
		[Token(Token = "0x403F478")]
		[FieldOffset(Offset = "0x18")]
		public string orgId;

		// Token: 0x0403F479 RID: 259193
		[Token(Token = "0x403F479")]
		[FieldOffset(Offset = "0x20")]
		public Act13SideDailyMissionSearchRequest.Act13SideRewardCondition reward;

		// Token: 0x020079D1 RID: 31185
		[Token(Token = "0x20079D1")]
		public class Act13SideRewardCondition
		{
			// Token: 0x0602BBDC RID: 179164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBDC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act13SideRewardCondition()
			{
			}

			// Token: 0x0403F47A RID: 259194
			[Token(Token = "0x403F47A")]
			[FieldOffset(Offset = "0x10")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x0403F47B RID: 259195
			[Token(Token = "0x403F47B")]
			[FieldOffset(Offset = "0x18")]
			public string id;
		}
	}
}
