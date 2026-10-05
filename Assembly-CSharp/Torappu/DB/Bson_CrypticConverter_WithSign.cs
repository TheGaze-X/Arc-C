using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x0200168A RID: 5770
	[Token(Token = "0x200168A")]
	public class Bson_CrypticConverter_WithSign : CrypticConverter_WithSign
	{
		// Token: 0x06009248 RID: 37448 RVA: 0x00038F88 File Offset: 0x00037188
		[Token(Token = "0x6009248")]
		[Address(RVA = "0x2B27FE0", Offset = "0x2B26BE0", VA = "0x182B27FE0", Slot = "15")]
		public override bool PreprocessText(TextAsset textAsset, Stream outStream, ITableDataType table)
		{
			return default(bool);
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009249")]
		[Address(RVA = "0x2B28270", Offset = "0x2B26E70", VA = "0x182B28270", Slot = "18")]
		protected override byte[] SerializeInternal(object value)
		{
			return null;
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600924A")]
		protected override T DeserializeInternal<T>(MemoryStream jsonStream)
		{
			return null;
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924B")]
		[Address(RVA = "0x2B27ED0", Offset = "0x2B26AD0", VA = "0x182B27ED0", Slot = "20")]
		protected override void PopulateInternal(MemoryStream jsonStream, object target)
		{
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600924C")]
		[Address(RVA = "0x2B283E0", Offset = "0x2B26FE0", VA = "0x182B283E0")]
		public Bson_CrypticConverter_WithSign()
		{
		}
	}
}
