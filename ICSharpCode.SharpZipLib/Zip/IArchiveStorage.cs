using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public interface IArchiveStorage
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000470 RID: 1136
		[Token(Token = "0x17000105")]
		FileUpdateMode UpdateMode { [Token(Token = "0x6000470")] get; }

		// Token: 0x06000471 RID: 1137
		[Token(Token = "0x6000471")]
		Stream GetTemporaryOutput();

		// Token: 0x06000472 RID: 1138
		[Token(Token = "0x6000472")]
		Stream ConvertTemporaryToFinal();

		// Token: 0x06000473 RID: 1139
		[Token(Token = "0x6000473")]
		Stream MakeTemporaryCopy(Stream stream);

		// Token: 0x06000474 RID: 1140
		[Token(Token = "0x6000474")]
		Stream OpenForDirectUpdate(Stream stream);

		// Token: 0x06000475 RID: 1141
		[Token(Token = "0x6000475")]
		void Dispose();
	}
}
