using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x02001685 RID: 5765
	[Token(Token = "0x2001685")]
	public abstract class CrypticConverter : IConverter
	{
		// Token: 0x06009223 RID: 37411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009223")]
		[Address(RVA = "0x2B30360", Offset = "0x2B2EF60", VA = "0x182B30360")]
		public CrypticConverter()
		{
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009224")]
		[Address(RVA = "0x2B2FC00", Offset = "0x2B2E800", VA = "0x182B2FC00", Slot = "4")]
		public void Serialize(object value, Stream stream)
		{
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009225")]
		public T Deserialize<T>(ConverterInput value)
		{
			return null;
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009226")]
		private T _Deserialize<T>(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009227")]
		public T Deserialize<T>(Stream stream)
		{
			return null;
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009228")]
		[Address(RVA = "0x2B2F160", Offset = "0x2B2DD60", VA = "0x182B2F160", Slot = "7")]
		public object Deserialize(ConverterInput value)
		{
			return null;
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009229")]
		[Address(RVA = "0x2B2F2C0", Offset = "0x2B2DEC0", VA = "0x182B2F2C0", Slot = "8")]
		public object Deserialize(Stream stream)
		{
			return null;
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600922A")]
		[Address(RVA = "0x2B2F7C0", Offset = "0x2B2E3C0", VA = "0x182B2F7C0", Slot = "9")]
		public void Populate(TextAsset value, object target)
		{
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600922B")]
		[Address(RVA = "0x2B2F630", Offset = "0x2B2E230", VA = "0x182B2F630", Slot = "10")]
		public void Populate(Stream stream, object target)
		{
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600922C")]
		[Address(RVA = "0x2B2F940", Offset = "0x2B2E540", VA = "0x182B2F940", Slot = "14")]
		public virtual void SerializeBytes(byte[] bytes, Stream stream)
		{
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600922D")]
		[Address(RVA = "0x2B2F000", Offset = "0x2B2DC00", VA = "0x182B2F000", Slot = "12")]
		public byte[] DeserializeBytes(Stream stream)
		{
			return null;
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x00038EF8 File Offset: 0x000370F8
		[Token(Token = "0x600922E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "15")]
		public virtual bool PreprocessText(TextAsset textAsset, Stream outStream, ITableDataType table)
		{
			return default(bool);
		}

		// Token: 0x0600922F RID: 37423
		[Token(Token = "0x600922F")]
		protected abstract byte[] EncodeInternal(byte[] src);

		// Token: 0x06009230 RID: 37424
		[Token(Token = "0x6009230")]
		protected abstract void DecodeInternal(Stream src, Stream dst);

		// Token: 0x06009231 RID: 37425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009231")]
		[Address(RVA = "0x2B2F9E0", Offset = "0x2B2E5E0", VA = "0x182B2F9E0", Slot = "18")]
		protected virtual byte[] SerializeInternal(object value)
		{
			return null;
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009232")]
		protected virtual T DeserializeInternal<T>(MemoryStream jsonStream)
		{
			return null;
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009233")]
		[Address(RVA = "0x2B2F480", Offset = "0x2B2E080", VA = "0x182B2F480", Slot = "20")]
		protected virtual void PopulateInternal(MemoryStream jsonStream, object target)
		{
		}

		// Token: 0x04008811 RID: 34833
		[Token(Token = "0x4008811")]
		[FieldOffset(Offset = "0x10")]
		protected JsonSerializerSettings m_settings;

		// Token: 0x04008812 RID: 34834
		[Token(Token = "0x4008812")]
		[FieldOffset(Offset = "0x18")]
		protected JsonSerializer m_serializer;
	}
}
