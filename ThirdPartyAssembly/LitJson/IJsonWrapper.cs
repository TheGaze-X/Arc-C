using System;
using System.Collections;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000478 RID: 1144
	[Token(Token = "0x2000478")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002481 RID: 9345
		[Token(Token = "0x170004D9")]
		bool IsArray { [Token(Token = "0x6002481")] get; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002482 RID: 9346
		[Token(Token = "0x170004DA")]
		bool IsBoolean { [Token(Token = "0x6002482")] get; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06002483 RID: 9347
		[Token(Token = "0x170004DB")]
		bool IsDouble { [Token(Token = "0x6002483")] get; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002484 RID: 9348
		[Token(Token = "0x170004DC")]
		bool IsInt { [Token(Token = "0x6002484")] get; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002485 RID: 9349
		[Token(Token = "0x170004DD")]
		bool IsLong { [Token(Token = "0x6002485")] get; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002486 RID: 9350
		[Token(Token = "0x170004DE")]
		bool IsObject { [Token(Token = "0x6002486")] get; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002487 RID: 9351
		[Token(Token = "0x170004DF")]
		bool IsString { [Token(Token = "0x6002487")] get; }

		// Token: 0x06002488 RID: 9352
		[Token(Token = "0x6002488")]
		bool GetBoolean();

		// Token: 0x06002489 RID: 9353
		[Token(Token = "0x6002489")]
		double GetDouble();

		// Token: 0x0600248A RID: 9354
		[Token(Token = "0x600248A")]
		int GetInt();

		// Token: 0x0600248B RID: 9355
		[Token(Token = "0x600248B")]
		JsonType GetJsonType();

		// Token: 0x0600248C RID: 9356
		[Token(Token = "0x600248C")]
		long GetLong();

		// Token: 0x0600248D RID: 9357
		[Token(Token = "0x600248D")]
		string GetString();

		// Token: 0x0600248E RID: 9358
		[Token(Token = "0x600248E")]
		void SetBoolean(bool val);

		// Token: 0x0600248F RID: 9359
		[Token(Token = "0x600248F")]
		void SetDouble(double val);

		// Token: 0x06002490 RID: 9360
		[Token(Token = "0x6002490")]
		void SetInt(int val);

		// Token: 0x06002491 RID: 9361
		[Token(Token = "0x6002491")]
		void SetJsonType(JsonType type);

		// Token: 0x06002492 RID: 9362
		[Token(Token = "0x6002492")]
		void SetLong(long val);

		// Token: 0x06002493 RID: 9363
		[Token(Token = "0x6002493")]
		void SetString(string val);

		// Token: 0x06002494 RID: 9364
		[Token(Token = "0x6002494")]
		string ToJson();

		// Token: 0x06002495 RID: 9365
		[Token(Token = "0x6002495")]
		void ToJson(JsonWriter writer);
	}
}
