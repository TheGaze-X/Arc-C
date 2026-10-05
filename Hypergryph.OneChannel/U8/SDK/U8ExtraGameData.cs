using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Preserve]
	public class U8ExtraGameData
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ExtraGameData()
		{
		}

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		public const int TYPE_SELECT_SERVER = 1;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		public const int TYPE_CREATE_ROLE = 2;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		public const int TYPE_ENTER_GAME = 3;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		public const int TYPE_LEVEL_UP = 4;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		public const int TYPE_EXIT_GAME = 5;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		public const int TYPE_STOP_GAME = 6;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		public const int TYPE_APP_START = 7;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		public const int TYPE_USER_LOGIN = 8;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		public const int TYPE_USER_LOGOUT = 9;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		public const int TYPE_PAY_SUCCESS = 10;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		public const int TYPE_CUSTOM_EVENT = 11;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("dataType")]
		public int dataType;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("uid")]
		public string uid;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("roleID")]
		public string roleID;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("roleName")]
		public string roleName;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("roleLevel")]
		public string roleLevel;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("serverID")]
		public int serverID;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("serverName")]
		public string serverName;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("channel")]
		public string channel;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("subChannel")]
		public string subChannel;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("isNewUser")]
		public bool isNewUser;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("revenue")]
		public long revenue;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("customEventName")]
		public string customEventName;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("customEventParams")]
		public string customEventParams;
	}
}
