using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B87 RID: 31623
	[Token(Token = "0x2007B87")]
	public class fsEnumConverter : fsConverter
	{
		// Token: 0x0602C441 RID: 181313 RVA: 0x000DEFC0 File Offset: 0x000DD1C0
		[Token(Token = "0x602C441")]
		[Address(RVA = "0x2827EF0", Offset = "0x2826AF0", VA = "0x182827EF0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C442 RID: 181314 RVA: 0x000DEFD8 File Offset: 0x000DD1D8
		[Token(Token = "0x602C442")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C443 RID: 181315 RVA: 0x000DEFF0 File Offset: 0x000DD1F0
		[Token(Token = "0x602C443")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C444 RID: 181316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C444")]
		[Address(RVA = "0x2827F70", Offset = "0x2826B70", VA = "0x182827F70", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C445 RID: 181317 RVA: 0x000DF008 File Offset: 0x000DD208
		[Token(Token = "0x602C445")]
		[Address(RVA = "0x28284D0", Offset = "0x28270D0", VA = "0x1828284D0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C446 RID: 181318 RVA: 0x000DF020 File Offset: 0x000DD220
		[Token(Token = "0x602C446")]
		[Address(RVA = "0x2827FF0", Offset = "0x2826BF0", VA = "0x182827FF0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C447 RID: 181319 RVA: 0x000DF038 File Offset: 0x000DD238
		[Token(Token = "0x602C447")]
		private static bool ArrayContains<T>(T[] values, T value)
		{
			return default(bool);
		}

		// Token: 0x0602C448 RID: 181320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C448")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsEnumConverter()
		{
		}
	}
}
