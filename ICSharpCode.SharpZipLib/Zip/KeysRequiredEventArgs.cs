using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public class KeysRequiredEventArgs : EventArgs
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x4A5D5F0", Offset = "0x4A5C1F0", VA = "0x184A5D5F0")]
		public KeysRequiredEventArgs(string name)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x4A5D660", Offset = "0x4A5C260", VA = "0x184A5D660")]
		public KeysRequiredEventArgs(string name, byte[] keyValue)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000D8")]
		public string FileName
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		public byte[] Key
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x10")]
		private string fileName;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x18")]
		private byte[] key;
	}
}
