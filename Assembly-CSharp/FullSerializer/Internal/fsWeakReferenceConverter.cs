using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B90 RID: 31632
	[Token(Token = "0x2007B90")]
	public class fsWeakReferenceConverter : fsConverter
	{
		// Token: 0x0602C482 RID: 181378 RVA: 0x000DF410 File Offset: 0x000DD610
		[Token(Token = "0x602C482")]
		[Address(RVA = "0x283C430", Offset = "0x283B030", VA = "0x18283C430", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C483 RID: 181379 RVA: 0x000DF428 File Offset: 0x000DD628
		[Token(Token = "0x602C483")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C484 RID: 181380 RVA: 0x000DF440 File Offset: 0x000DD640
		[Token(Token = "0x602C484")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C485 RID: 181381 RVA: 0x000DF458 File Offset: 0x000DD658
		[Token(Token = "0x602C485")]
		[Address(RVA = "0x283C9F0", Offset = "0x283B5F0", VA = "0x18283C9F0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C486 RID: 181382 RVA: 0x000DF470 File Offset: 0x000DD670
		[Token(Token = "0x602C486")]
		[Address(RVA = "0x283C510", Offset = "0x283B110", VA = "0x18283C510", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C487 RID: 181383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C487")]
		[Address(RVA = "0x283C4B0", Offset = "0x283B0B0", VA = "0x18283C4B0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C488 RID: 181384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C488")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsWeakReferenceConverter()
		{
		}
	}
}
