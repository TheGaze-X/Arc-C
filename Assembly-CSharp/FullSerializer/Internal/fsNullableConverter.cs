using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8C RID: 31628
	[Token(Token = "0x2007B8C")]
	public class fsNullableConverter : fsConverter
	{
		// Token: 0x0602C467 RID: 181351 RVA: 0x000DF230 File Offset: 0x000DD430
		[Token(Token = "0x602C467")]
		[Address(RVA = "0x2832190", Offset = "0x2830D90", VA = "0x182832190", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C468 RID: 181352 RVA: 0x000DF248 File Offset: 0x000DD448
		[Token(Token = "0x602C468")]
		[Address(RVA = "0x2832320", Offset = "0x2830F20", VA = "0x182832320", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C469 RID: 181353 RVA: 0x000DF260 File Offset: 0x000DD460
		[Token(Token = "0x602C469")]
		[Address(RVA = "0x28322A0", Offset = "0x2830EA0", VA = "0x1828322A0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C46A RID: 181354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C46A")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C46B RID: 181355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C46B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsNullableConverter()
		{
		}
	}
}
