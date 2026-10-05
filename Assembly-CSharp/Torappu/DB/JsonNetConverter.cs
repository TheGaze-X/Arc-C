using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x02001690 RID: 5776
	[Token(Token = "0x2001690")]
	public class JsonNetConverter : IConverter
	{
		// Token: 0x06009263 RID: 37475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009263")]
		[Address(RVA = "0x2B3B4B0", Offset = "0x2B3A0B0", VA = "0x182B3B4B0")]
		public JsonNetConverter(Formatting format = Formatting.Indented)
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06009264 RID: 37476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F8A")]
		protected virtual JsonSerializerSettings serializerSetting
		{
			[Token(Token = "0x6009264")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009265")]
		[Address(RVA = "0x2B3B230", Offset = "0x2B39E30", VA = "0x182B3B230", Slot = "4")]
		public void Serialize(object value, Stream stream)
		{
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009266")]
		[Address(RVA = "0x2B3B410", Offset = "0x2B3A010", VA = "0x182B3B410")]
		public string Serialize(object value)
		{
			return null;
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009267")]
		public virtual T Deserialize<T>(ConverterInput value)
		{
			return null;
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009268")]
		public T Deserialize<T>(Stream stream)
		{
			return null;
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009269")]
		[Address(RVA = "0x2B3AD40", Offset = "0x2B39940", VA = "0x182B3AD40", Slot = "16")]
		public virtual object Deserialize(ConverterInput value)
		{
			return null;
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600926A")]
		[Address(RVA = "0x2B3AAE0", Offset = "0x2B396E0", VA = "0x182B3AAE0")]
		public object DeserializeWithType(ConverterInput value, Type type)
		{
			return null;
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600926B")]
		[Address(RVA = "0x2B3AB80", Offset = "0x2B39780", VA = "0x182B3AB80", Slot = "8")]
		public object Deserialize(Stream stream)
		{
			return null;
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600926C")]
		[Address(RVA = "0x2B3ADD0", Offset = "0x2B399D0", VA = "0x182B3ADD0", Slot = "9")]
		public void Populate(TextAsset value, object target)
		{
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600926D")]
		[Address(RVA = "0x2B3AE80", Offset = "0x2B39A80", VA = "0x182B3AE80", Slot = "10")]
		public void Populate(Stream stream, object target)
		{
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600926E")]
		[Address(RVA = "0x2B3B030", Offset = "0x2B39C30", VA = "0x182B3B030", Slot = "11")]
		public void SerializeBytes(byte[] bytes, Stream stream)
		{
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600926F")]
		[Address(RVA = "0x2B3A980", Offset = "0x2B39580", VA = "0x182B3A980", Slot = "12")]
		public byte[] DeserializeBytes(Stream stream)
		{
			return null;
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00038FE8 File Offset: 0x000371E8
		[Token(Token = "0x6009270")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
		public bool PreprocessText(TextAsset textAsset, Stream outStream, ITableDataType table)
		{
			return default(bool);
		}

		// Token: 0x04008828 RID: 34856
		[Token(Token = "0x4008828")]
		[FieldOffset(Offset = "0x10")]
		private JsonSerializerSettings m_settings;

		// Token: 0x04008829 RID: 34857
		[Token(Token = "0x4008829")]
		[FieldOffset(Offset = "0x18")]
		private Formatting m_format;

		// Token: 0x0400882A RID: 34858
		[Token(Token = "0x400882A")]
		[FieldOffset(Offset = "0x20")]
		private JsonSerializer m_serializer;
	}
}
