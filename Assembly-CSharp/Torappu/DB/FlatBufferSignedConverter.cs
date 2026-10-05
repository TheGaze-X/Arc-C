using System;
using System.IO;
using Google.FlatBuffers;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x0200168B RID: 5771
	[Token(Token = "0x200168B")]
	public class FlatBufferSignedConverter : CrypticConverter_WithSign
	{
		// Token: 0x0600924D RID: 37453 RVA: 0x00038FA0 File Offset: 0x000371A0
		[Token(Token = "0x600924D")]
		[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "22")]
		protected override CrypticConverter_WithSign.CodeOpt EnableCodeOpts()
		{
			return CrypticConverter_WithSign.CodeOpt.NONE;
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600924E")]
		protected override T DeserializeInternal<T>(MemoryStream stream)
		{
			return null;
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600924F")]
		[Address(RVA = "0x2B35CC0", Offset = "0x2B348C0", VA = "0x182B35CC0")]
		private object _DeserializeInternal(MemoryStream stream, Type type)
		{
			return null;
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009250")]
		[Address(RVA = "0x2B35C60", Offset = "0x2B34860", VA = "0x182B35C60", Slot = "18")]
		protected override byte[] SerializeInternal(object value)
		{
			return null;
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00038FB8 File Offset: 0x000371B8
		[Token(Token = "0x6009251")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "15")]
		public override bool PreprocessText(TextAsset textAsset, Stream stream, ITableDataType table)
		{
			return default(bool);
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009252")]
		[Address(RVA = "0x2B283E0", Offset = "0x2B26FE0", VA = "0x182B283E0")]
		public FlatBufferSignedConverter()
		{
		}

		// Token: 0x04008821 RID: 34849
		[Token(Token = "0x4008821")]
		[FieldOffset(Offset = "0x0")]
		private static FlatBufferBuilder s_builder;

		// Token: 0x0200168C RID: 5772
		[Token(Token = "0x200168C")]
		public interface IPreprocessTextData
		{
			// Token: 0x06009254 RID: 37460
			[Token(Token = "0x6009254")]
			object Preprocess(object data, JsonNetConverter jsonConverter);
		}
	}
}
