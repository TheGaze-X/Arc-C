using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65
		[Token(Token = "0x1700000C")]
		bool IsArray { [Token(Token = "0x6000041")] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66
		[Token(Token = "0x1700000D")]
		bool IsBoolean { [Token(Token = "0x6000042")] get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000043 RID: 67
		[Token(Token = "0x1700000E")]
		bool IsDouble { [Token(Token = "0x6000043")] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68
		[Token(Token = "0x1700000F")]
		bool IsInt { [Token(Token = "0x6000044")] get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69
		[Token(Token = "0x17000010")]
		bool IsLong { [Token(Token = "0x6000045")] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000046 RID: 70
		[Token(Token = "0x17000011")]
		bool IsObject { [Token(Token = "0x6000046")] get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71
		[Token(Token = "0x17000012")]
		bool IsString { [Token(Token = "0x6000047")] get; }

		// Token: 0x06000048 RID: 72
		[Token(Token = "0x6000048")]
		bool GetBoolean();

		// Token: 0x06000049 RID: 73
		[Token(Token = "0x6000049")]
		double GetDouble();

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		int GetInt();

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		JsonType GetJsonType();

		// Token: 0x0600004C RID: 76
		[Token(Token = "0x600004C")]
		long GetLong();

		// Token: 0x0600004D RID: 77
		[Token(Token = "0x600004D")]
		string GetString();

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		void SetBoolean(bool val);

		// Token: 0x0600004F RID: 79
		[Token(Token = "0x600004F")]
		void SetDouble(double val);

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		void SetInt(int val);

		// Token: 0x06000051 RID: 81
		[Token(Token = "0x6000051")]
		void SetJsonType(JsonType type);

		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		void SetLong(long val);

		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		void SetString(string val);

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		string ToJson();

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		void ToJson(JsonWriter writer);
	}
}
