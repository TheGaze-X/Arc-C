using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C64 RID: 19556
	[Token(Token = "0x2004C64")]
	public class HomeThemePrefabData : HomeThemeUIElemData
	{
		// Token: 0x0601D567 RID: 120167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D567")]
		[Address(RVA = "0x16E7E20", Offset = "0x16E6A20", VA = "0x1816E7E20", Slot = "5")]
		protected override void OnParseFromJson(JObject jdata)
		{
		}

		// Token: 0x0601D568 RID: 120168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D568")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HomeThemePrefabData()
		{
		}

		// Token: 0x04026995 RID: 158101
		[Token(Token = "0x4026995")]
		[FieldOffset(Offset = "0x28")]
		public string prefabPath;
	}
}
