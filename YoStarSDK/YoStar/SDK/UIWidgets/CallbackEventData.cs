using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public class CallbackEventData
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x5C25770", Offset = "0x5C24370", VA = "0x185C25770")]
		public CallbackEventData()
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x5C25620", Offset = "0x5C24220", VA = "0x185C25620")]
		public void AddData(string key, object value)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x5C256E0", Offset = "0x5C242E0", VA = "0x185C256E0")]
		public object GetData(string key)
		{
			return null;
		}

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> properties;
	}
}
