using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B8E RID: 31630
	[Token(Token = "0x2007B8E")]
	public class fsReflectedConverter : fsConverter
	{
		// Token: 0x0602C476 RID: 181366 RVA: 0x000DF350 File Offset: 0x000DD550
		[Token(Token = "0x602C476")]
		[Address(RVA = "0x28350E0", Offset = "0x2833CE0", VA = "0x1828350E0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C477 RID: 181367 RVA: 0x000DF368 File Offset: 0x000DD568
		[Token(Token = "0x602C477")]
		[Address(RVA = "0x28355B0", Offset = "0x28341B0", VA = "0x1828355B0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C478 RID: 181368 RVA: 0x000DF380 File Offset: 0x000DD580
		[Token(Token = "0x602C478")]
		[Address(RVA = "0x2835250", Offset = "0x2833E50", VA = "0x182835250", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C479 RID: 181369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C479")]
		[Address(RVA = "0x28351D0", Offset = "0x2833DD0", VA = "0x1828351D0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C47A RID: 181370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C47A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsReflectedConverter()
		{
		}
	}
}
