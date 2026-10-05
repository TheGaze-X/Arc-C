using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B84 RID: 31620
	[Token(Token = "0x2007B84")]
	public class fsArrayConverter : fsConverter
	{
		// Token: 0x0602C42E RID: 181294 RVA: 0x000DEEA0 File Offset: 0x000DD0A0
		[Token(Token = "0x602C42E")]
		[Address(RVA = "0x28210F0", Offset = "0x281FCF0", VA = "0x1828210F0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C42F RID: 181295 RVA: 0x000DEEB8 File Offset: 0x000DD0B8
		[Token(Token = "0x602C42F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C430 RID: 181296 RVA: 0x000DEED0 File Offset: 0x000DD0D0
		[Token(Token = "0x602C430")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		// Token: 0x0602C431 RID: 181297 RVA: 0x000DEEE8 File Offset: 0x000DD0E8
		[Token(Token = "0x602C431")]
		[Address(RVA = "0x28215C0", Offset = "0x28201C0", VA = "0x1828215C0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C432 RID: 181298 RVA: 0x000DEF00 File Offset: 0x000DD100
		[Token(Token = "0x602C432")]
		[Address(RVA = "0x2821190", Offset = "0x281FD90", VA = "0x182821190", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C433 RID: 181299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C433")]
		[Address(RVA = "0x2821110", Offset = "0x281FD10", VA = "0x182821110", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C434 RID: 181300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C434")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsArrayConverter()
		{
		}
	}
}
