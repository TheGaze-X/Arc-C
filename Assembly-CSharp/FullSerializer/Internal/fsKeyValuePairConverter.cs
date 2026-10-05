using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8B RID: 31627
	[Token(Token = "0x2007B8B")]
	public class fsKeyValuePairConverter : fsConverter
	{
		// Token: 0x0602C461 RID: 181345 RVA: 0x000DF1B8 File Offset: 0x000DD3B8
		[Token(Token = "0x602C461")]
		[Address(RVA = "0x282F3F0", Offset = "0x282DFF0", VA = "0x18282F3F0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C462 RID: 181346 RVA: 0x000DF1D0 File Offset: 0x000DD3D0
		[Token(Token = "0x602C462")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C463 RID: 181347 RVA: 0x000DF1E8 File Offset: 0x000DD3E8
		[Token(Token = "0x602C463")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C464 RID: 181348 RVA: 0x000DF200 File Offset: 0x000DD400
		[Token(Token = "0x602C464")]
		[Address(RVA = "0x282F4F0", Offset = "0x282E0F0", VA = "0x18282F4F0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C465 RID: 181349 RVA: 0x000DF218 File Offset: 0x000DD418
		[Token(Token = "0x602C465")]
		[Address(RVA = "0x282FA70", Offset = "0x282E670", VA = "0x18282FA70", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C466 RID: 181350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C466")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsKeyValuePairConverter()
		{
		}
	}
}
