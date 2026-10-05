using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.SDK
{
	// Token: 0x020014F1 RID: 5361
	[Token(Token = "0x20014F1")]
	public struct InjectSettingOptions
	{
		// Token: 0x040079E3 RID: 31203
		[Token(Token = "0x40079E3")]
		[FieldOffset(Offset = "0x0")]
		public Transform panelAccount;

		// Token: 0x040079E4 RID: 31204
		[Token(Token = "0x40079E4")]
		[FieldOffset(Offset = "0x8")]
		public Transform panelOthers;

		// Token: 0x040079E5 RID: 31205
		[Token(Token = "0x40079E5")]
		[FieldOffset(Offset = "0x10")]
		public Action<InjectSettingFeedbacks> feedback;
	}
}
