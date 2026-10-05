using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Setting;

namespace Torappu.SDK
{
	// Token: 0x020014F2 RID: 5362
	[Token(Token = "0x20014F2")]
	public struct InjectSettingFeedbacks
	{
		// Token: 0x040079E6 RID: 31206
		[Token(Token = "0x40079E6")]
		[FieldOffset(Offset = "0x0")]
		public ICollection<SettingCategory> disableCategories;

		// Token: 0x040079E7 RID: 31207
		[Token(Token = "0x40079E7")]
		[FieldOffset(Offset = "0x8")]
		public Action openAccountCenter;
	}
}
