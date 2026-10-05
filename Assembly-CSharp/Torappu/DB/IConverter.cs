using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x0200168F RID: 5775
	[Token(Token = "0x200168F")]
	public interface IConverter
	{
		// Token: 0x06009259 RID: 37465
		[Token(Token = "0x6009259")]
		void Serialize(object obj, Stream stream);

		// Token: 0x0600925A RID: 37466
		[Token(Token = "0x600925A")]
		T Deserialize<T>(ConverterInput value);

		// Token: 0x0600925B RID: 37467
		[Token(Token = "0x600925B")]
		T Deserialize<T>(Stream stream);

		// Token: 0x0600925C RID: 37468
		[Token(Token = "0x600925C")]
		object Deserialize(ConverterInput value);

		// Token: 0x0600925D RID: 37469
		[Token(Token = "0x600925D")]
		object Deserialize(Stream stream);

		// Token: 0x0600925E RID: 37470
		[Token(Token = "0x600925E")]
		void Populate(TextAsset value, object target);

		// Token: 0x0600925F RID: 37471
		[Token(Token = "0x600925F")]
		void Populate(Stream stream, object target);

		// Token: 0x06009260 RID: 37472
		[Token(Token = "0x6009260")]
		void SerializeBytes(byte[] bytes, Stream stream);

		// Token: 0x06009261 RID: 37473
		[Token(Token = "0x6009261")]
		byte[] DeserializeBytes(Stream stream);

		// Token: 0x06009262 RID: 37474
		[Token(Token = "0x6009262")]
		bool PreprocessText(TextAsset textAsset, Stream outStream, ITableDataType table);
	}
}
