using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06001077 RID: 4215
		[Token(Token = "0x170001C7")]
		bool IsArray { [Token(Token = "0x6001077")] get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06001078 RID: 4216
		[Token(Token = "0x170001C8")]
		bool IsBoolean { [Token(Token = "0x6001078")] get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001079 RID: 4217
		[Token(Token = "0x170001C9")]
		bool IsDouble { [Token(Token = "0x6001079")] get; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600107A RID: 4218
		[Token(Token = "0x170001CA")]
		bool IsInt { [Token(Token = "0x600107A")] get; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600107B RID: 4219
		[Token(Token = "0x170001CB")]
		bool IsLong { [Token(Token = "0x600107B")] get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600107C RID: 4220
		[Token(Token = "0x170001CC")]
		bool IsObject { [Token(Token = "0x600107C")] get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600107D RID: 4221
		[Token(Token = "0x170001CD")]
		bool IsString { [Token(Token = "0x600107D")] get; }

		// Token: 0x0600107E RID: 4222
		[Token(Token = "0x600107E")]
		bool GetBoolean();

		// Token: 0x0600107F RID: 4223
		[Token(Token = "0x600107F")]
		double GetDouble();

		// Token: 0x06001080 RID: 4224
		[Token(Token = "0x6001080")]
		int GetInt();

		// Token: 0x06001081 RID: 4225
		[Token(Token = "0x6001081")]
		JsonType GetJsonType();

		// Token: 0x06001082 RID: 4226
		[Token(Token = "0x6001082")]
		long GetLong();

		// Token: 0x06001083 RID: 4227
		[Token(Token = "0x6001083")]
		string GetString();

		// Token: 0x06001084 RID: 4228
		[Token(Token = "0x6001084")]
		void SetBoolean(bool val);

		// Token: 0x06001085 RID: 4229
		[Token(Token = "0x6001085")]
		void SetDouble(double val);

		// Token: 0x06001086 RID: 4230
		[Token(Token = "0x6001086")]
		void SetInt(int val);

		// Token: 0x06001087 RID: 4231
		[Token(Token = "0x6001087")]
		void SetJsonType(JsonType type);

		// Token: 0x06001088 RID: 4232
		[Token(Token = "0x6001088")]
		void SetLong(long val);

		// Token: 0x06001089 RID: 4233
		[Token(Token = "0x6001089")]
		void SetString(string val);

		// Token: 0x0600108A RID: 4234
		[Token(Token = "0x600108A")]
		string ToJson();

		// Token: 0x0600108B RID: 4235
		[Token(Token = "0x600108B")]
		void ToJson(JsonWriter writer);
	}
}
