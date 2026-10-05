using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Serializable]
	public class CriAtomCueSheet
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x17000012")]
		public bool IsLoading
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x36B3FB0", Offset = "0x36B2BB0", VA = "0x1836B3FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000013")]
		public bool IsError
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x36B3F90", Offset = "0x36B2B90", VA = "0x1836B3F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x36B3F00", Offset = "0x36B2B00", VA = "0x1836B3F00")]
		public CriAtomCueSheet()
		{
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		public string acbFile;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		public string awbFile;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x28")]
		public CriAtomExAcb acb;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x30")]
		public CriAtomExAcbLoader.Status loaderStatus;
	}
}
