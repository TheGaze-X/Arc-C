using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006965 RID: 26981
	[Token(Token = "0x2006965")]
	[Serializable]
	public struct StageFogPatch
	{
		// Token: 0x060269CF RID: 158159 RVA: 0x000CBD30 File Offset: 0x000C9F30
		[Token(Token = "0x60269CF")]
		[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040367D3 RID: 223187
		[Token(Token = "0x40367D3")]
		[FieldOffset(Offset = "0x0")]
		public string fogId;

		// Token: 0x040367D4 RID: 223188
		[Token(Token = "0x40367D4")]
		[FieldOffset(Offset = "0x8")]
		public string stageId;

		// Token: 0x040367D5 RID: 223189
		[Token(Token = "0x40367D5")]
		[FieldOffset(Offset = "0x10")]
		public float posX;

		// Token: 0x040367D6 RID: 223190
		[Token(Token = "0x40367D6")]
		[FieldOffset(Offset = "0x14")]
		public float posY;

		// Token: 0x040367D7 RID: 223191
		[Token(Token = "0x40367D7")]
		[FieldOffset(Offset = "0x18")]
		public string fogRes;

		// Token: 0x040367D8 RID: 223192
		[Token(Token = "0x40367D8")]
		[FieldOffset(Offset = "0x20")]
		public string fogBkgRes;
	}
}
