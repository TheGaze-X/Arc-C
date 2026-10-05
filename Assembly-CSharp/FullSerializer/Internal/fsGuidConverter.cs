using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B89 RID: 31625
	[Token(Token = "0x2007B89")]
	public class fsGuidConverter : fsConverter
	{
		// Token: 0x0602C44F RID: 181327 RVA: 0x000DF0B0 File Offset: 0x000DD2B0
		[Token(Token = "0x602C44F")]
		[Address(RVA = "0x2829310", Offset = "0x2827F10", VA = "0x182829310", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C450 RID: 181328 RVA: 0x000DF0C8 File Offset: 0x000DD2C8
		[Token(Token = "0x602C450")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C451 RID: 181329 RVA: 0x000DF0E0 File Offset: 0x000DD2E0
		[Token(Token = "0x602C451")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C452 RID: 181330 RVA: 0x000DF0F8 File Offset: 0x000DD2F8
		[Token(Token = "0x602C452")]
		[Address(RVA = "0x2829550", Offset = "0x2828150", VA = "0x182829550", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C453 RID: 181331 RVA: 0x000DF110 File Offset: 0x000DD310
		[Token(Token = "0x602C453")]
		[Address(RVA = "0x28293D0", Offset = "0x2827FD0", VA = "0x1828293D0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C454 RID: 181332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C454")]
		[Address(RVA = "0x2829390", Offset = "0x2827F90", VA = "0x182829390", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C455 RID: 181333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C455")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsGuidConverter()
		{
		}
	}
}
