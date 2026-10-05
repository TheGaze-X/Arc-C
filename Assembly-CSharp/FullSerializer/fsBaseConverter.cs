using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B66 RID: 31590
	[Token(Token = "0x2007B66")]
	public abstract class fsBaseConverter
	{
		// Token: 0x0602C365 RID: 181093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C365")]
		[Address(RVA = "0x28222B0", Offset = "0x2820EB0", VA = "0x1828222B0", Slot = "4")]
		public virtual object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C366 RID: 181094 RVA: 0x000DE648 File Offset: 0x000DC848
		[Token(Token = "0x602C366")]
		[Address(RVA = "0x2822A30", Offset = "0x2821630", VA = "0x182822A30", Slot = "5")]
		public virtual bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C367 RID: 181095 RVA: 0x000DE660 File Offset: 0x000DC860
		[Token(Token = "0x602C367")]
		[Address(RVA = "0x2822B20", Offset = "0x2821720", VA = "0x182822B20", Slot = "6")]
		public virtual bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C368 RID: 181096
		[Token(Token = "0x602C368")]
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

		// Token: 0x0602C369 RID: 181097
		[Token(Token = "0x602C369")]
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

		// Token: 0x0602C36A RID: 181098 RVA: 0x000DE678 File Offset: 0x000DC878
		[Token(Token = "0x602C36A")]
		[Address(RVA = "0x28224B0", Offset = "0x28210B0", VA = "0x1828224B0")]
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types)
		{
			return default(fsResult);
		}

		// Token: 0x0602C36B RID: 181099 RVA: 0x000DE690 File Offset: 0x000DC890
		[Token(Token = "0x602C36B")]
		[Address(RVA = "0x2821E70", Offset = "0x2820A70", VA = "0x182821E70")]
		protected fsResult CheckType(fsData data, fsDataType type)
		{
			return default(fsResult);
		}

		// Token: 0x0602C36C RID: 181100 RVA: 0x000DE6A8 File Offset: 0x000DC8A8
		[Token(Token = "0x602C36C")]
		[Address(RVA = "0x2821DD0", Offset = "0x28209D0", VA = "0x182821DD0")]
		protected fsResult CheckKey(fsData data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		// Token: 0x0602C36D RID: 181101 RVA: 0x000DE6C0 File Offset: 0x000DC8C0
		[Token(Token = "0x602C36D")]
		[Address(RVA = "0x2821AA0", Offset = "0x28206A0", VA = "0x182821AA0")]
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		// Token: 0x0602C36E RID: 181102 RVA: 0x000DE6D8 File Offset: 0x000DC8D8
		[Token(Token = "0x602C36E")]
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
		{
			return default(fsResult);
		}

		// Token: 0x0602C36F RID: 181103 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
		[Token(Token = "0x602C36F")]
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
		{
			return default(fsResult);
		}

		// Token: 0x0602C370 RID: 181104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C370")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected fsBaseConverter()
		{
		}

		// Token: 0x0404018A RID: 262538
		[Token(Token = "0x404018A")]
		[FieldOffset(Offset = "0x10")]
		public fsSerializer Serializer;
	}
}
