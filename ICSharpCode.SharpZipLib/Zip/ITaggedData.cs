using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public interface ITaggedData
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000370 RID: 880
		[Token(Token = "0x170000C8")]
		short TagID { [Token(Token = "0x6000370")] get; }

		// Token: 0x06000371 RID: 881
		[Token(Token = "0x6000371")]
		void SetData(byte[] data, int offset, int count);

		// Token: 0x06000372 RID: 882
		[Token(Token = "0x6000372")]
		byte[] GetData();
	}
}
