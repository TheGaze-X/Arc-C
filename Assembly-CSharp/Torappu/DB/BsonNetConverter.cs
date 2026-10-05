using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x02001680 RID: 5760
	[Token(Token = "0x2001680")]
	public class BsonNetConverter : IConverter
	{
		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x0600920E RID: 37390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F87")]
		protected virtual JsonSerializerSettings serializerSetting
		{
			[Token(Token = "0x600920E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F88")]
		protected JsonSerializer serializer
		{
			[Token(Token = "0x600920F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009210")]
		[Address(RVA = "0x2B27E60", Offset = "0x2B26A60", VA = "0x182B27E60")]
		public BsonNetConverter(Formatting format = Formatting.None)
		{
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009211")]
		[Address(RVA = "0x2B27980", Offset = "0x2B26580", VA = "0x182B27980", Slot = "15")]
		public virtual void Serialize(object value, Stream stream)
		{
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009212")]
		public T Deserialize<T>(Stream stream)
		{
			return null;
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009213")]
		protected virtual T DeserializeInternal<T>(Stream stream)
		{
			return null;
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009214")]
		public T Deserialize<T>(ConverterInput text)
		{
			return null;
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009215")]
		[Address(RVA = "0x2B27320", Offset = "0x2B25F20", VA = "0x182B27320", Slot = "8")]
		public object Deserialize(Stream stream)
		{
			return null;
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009216")]
		[Address(RVA = "0x2B273C0", Offset = "0x2B25FC0", VA = "0x182B273C0", Slot = "7")]
		public object Deserialize(ConverterInput text)
		{
			return null;
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009217")]
		[Address(RVA = "0x2B274C0", Offset = "0x2B260C0", VA = "0x182B274C0", Slot = "10")]
		public void Populate(Stream stream, object target)
		{
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009218")]
		[Address(RVA = "0x2B275D0", Offset = "0x2B261D0", VA = "0x182B275D0", Slot = "9")]
		public void Populate(TextAsset text, object target)
		{
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009219")]
		[Address(RVA = "0x2B27760", Offset = "0x2B26360", VA = "0x182B27760", Slot = "11")]
		public void SerializeBytes(byte[] bytes, Stream stream)
		{
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600921A")]
		[Address(RVA = "0x2B27C90", Offset = "0x2B26890", VA = "0x182B27C90")]
		private JContainer _DeserializePlainJSON(Stream input)
		{
			return null;
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600921B")]
		[Address(RVA = "0x2B271A0", Offset = "0x2B25DA0", VA = "0x182B271A0", Slot = "12")]
		public byte[] DeserializeBytes(Stream stream)
		{
			return null;
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x00038EE0 File Offset: 0x000370E0
		[Token(Token = "0x600921C")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
		public bool PreprocessText(TextAsset textAsset, Stream outStream, ITableDataType table)
		{
			return default(bool);
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600921D")]
		[Address(RVA = "0x2B276E0", Offset = "0x2B262E0", VA = "0x182B276E0", Slot = "17")]
		protected virtual void ProcessStreamAfterSerialize(Stream inStream, Stream outStream)
		{
		}

		// Token: 0x040087FE RID: 34814
		[Token(Token = "0x40087FE")]
		[FieldOffset(Offset = "0x10")]
		private JsonSerializerSettings m_settings;

		// Token: 0x040087FF RID: 34815
		[Token(Token = "0x40087FF")]
		[FieldOffset(Offset = "0x18")]
		private Formatting m_format;

		// Token: 0x04008800 RID: 34816
		[Token(Token = "0x4008800")]
		[FieldOffset(Offset = "0x20")]
		private JsonSerializer m_serializer;
	}
}
