using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8D RID: 31629
	[Token(Token = "0x2007B8D")]
	public class fsPrimitiveConverter : fsConverter
	{
		// Token: 0x0602C46C RID: 181356 RVA: 0x000DF278 File Offset: 0x000DD478
		[Token(Token = "0x602C46C")]
		[Address(RVA = "0x2833A30", Offset = "0x2832630", VA = "0x182833A30", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C46D RID: 181357 RVA: 0x000DF290 File Offset: 0x000DD490
		[Token(Token = "0x602C46D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C46E RID: 181358 RVA: 0x000DF2A8 File Offset: 0x000DD4A8
		[Token(Token = "0x602C46E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C46F RID: 181359 RVA: 0x000DF2C0 File Offset: 0x000DD4C0
		[Token(Token = "0x602C46F")]
		[Address(RVA = "0x2834BB0", Offset = "0x28337B0", VA = "0x182834BB0")]
		private static bool UseBool(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C470 RID: 181360 RVA: 0x000DF2D8 File Offset: 0x000DD4D8
		[Token(Token = "0x602C470")]
		[Address(RVA = "0x2834D40", Offset = "0x2833940", VA = "0x182834D40")]
		private static bool UseInt64(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C471 RID: 181361 RVA: 0x000DF2F0 File Offset: 0x000DD4F0
		[Token(Token = "0x602C471")]
		[Address(RVA = "0x2834C30", Offset = "0x2833830", VA = "0x182834C30")]
		private static bool UseDouble(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C472 RID: 181362 RVA: 0x000DF308 File Offset: 0x000DD508
		[Token(Token = "0x602C472")]
		[Address(RVA = "0x2834FB0", Offset = "0x2833BB0", VA = "0x182834FB0")]
		private static bool UseString(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C473 RID: 181363 RVA: 0x000DF320 File Offset: 0x000DD520
		[Token(Token = "0x602C473")]
		[Address(RVA = "0x28343C0", Offset = "0x2832FC0", VA = "0x1828343C0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C474 RID: 181364 RVA: 0x000DF338 File Offset: 0x000DD538
		[Token(Token = "0x602C474")]
		[Address(RVA = "0x2833B40", Offset = "0x2832740", VA = "0x182833B40", Slot = "8")]
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C475 RID: 181365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C475")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsPrimitiveConverter()
		{
		}
	}
}
