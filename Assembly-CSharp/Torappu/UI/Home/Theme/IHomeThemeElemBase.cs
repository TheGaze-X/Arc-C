using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C5C RID: 19548
	[Token(Token = "0x2004C5C")]
	public interface IHomeThemeElemBase
	{
		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x0601D54D RID: 120141
		[Token(Token = "0x170044E3")]
		string elemName { [Token(Token = "0x601D54D")] get; }

		// Token: 0x0601D54E RID: 120142
		[Token(Token = "0x601D54E")]
		void Apply(string targetName, JObject jdata, HomeTheme theme);

		// Token: 0x0601D54F RID: 120143
		[Token(Token = "0x601D54F")]
		void ApplyEmpty();

		// Token: 0x0601D550 RID: 120144
		[Token(Token = "0x601D550")]
		HomeThemeElemData GenData(AssetPathConvertor pathConvertor);

		// Token: 0x0601D551 RID: 120145
		[Token(Token = "0x601D551")]
		void ClearReference();

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x0601D552 RID: 120146
		// (set) Token: 0x0601D553 RID: 120147
		[Token(Token = "0x170044E4")]
		bool configSerializable { [Token(Token = "0x601D552")] get; [Token(Token = "0x601D553")] set; }
	}
}
