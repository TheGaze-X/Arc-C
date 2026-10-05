using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8F RID: 31631
	[Token(Token = "0x2007B8F")]
	public class fsTypeConverter : fsConverter
	{
		// Token: 0x0602C47B RID: 181371 RVA: 0x000DF398 File Offset: 0x000DD598
		[Token(Token = "0x602C47B")]
		[Address(RVA = "0x283BA10", Offset = "0x283A610", VA = "0x18283BA10", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C47C RID: 181372 RVA: 0x000DF3B0 File Offset: 0x000DD5B0
		[Token(Token = "0x602C47C")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C47D RID: 181373 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
		[Token(Token = "0x602C47D")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C47E RID: 181374 RVA: 0x000DF3E0 File Offset: 0x000DD5E0
		[Token(Token = "0x602C47E")]
		[Address(RVA = "0x283BC90", Offset = "0x283A890", VA = "0x18283BC90", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C47F RID: 181375 RVA: 0x000DF3F8 File Offset: 0x000DD5F8
		[Token(Token = "0x602C47F")]
		[Address(RVA = "0x283BAB0", Offset = "0x283A6B0", VA = "0x18283BAB0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C480 RID: 181376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C480")]
		[Address(RVA = "0x2832290", Offset = "0x2830E90", VA = "0x182832290", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C481 RID: 181377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C481")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsTypeConverter()
		{
		}
	}
}
