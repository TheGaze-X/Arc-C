using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	public abstract class BaseArchiveStorage : IArchiveStorage
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		protected BaseArchiveStorage(FileUpdateMode updateMode)
		{
		}

		// Token: 0x06000477 RID: 1143
		[Token(Token = "0x6000477")]
		public abstract Stream GetTemporaryOutput();

		// Token: 0x06000478 RID: 1144
		[Token(Token = "0x6000478")]
		public abstract Stream ConvertTemporaryToFinal();

		// Token: 0x06000479 RID: 1145
		[Token(Token = "0x6000479")]
		public abstract Stream MakeTemporaryCopy(Stream stream);

		// Token: 0x0600047A RID: 1146
		[Token(Token = "0x600047A")]
		public abstract Stream OpenForDirectUpdate(Stream stream);

		// Token: 0x0600047B RID: 1147
		[Token(Token = "0x600047B")]
		public abstract void Dispose();

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x17000106")]
		public FileUpdateMode UpdateMode
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			get
			{
				return FileUpdateMode.Safe;
			}
		}

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x10")]
		private FileUpdateMode updateMode_;
	}
}
