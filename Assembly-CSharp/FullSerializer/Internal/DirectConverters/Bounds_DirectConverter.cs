using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA1 RID: 31649
	[Token(Token = "0x2007BA1")]
	public class Bounds_DirectConverter : fsDirectConverter<Bounds>
	{
		// Token: 0x0602C4F2 RID: 181490 RVA: 0x000DF758 File Offset: 0x000DD958
		[Token(Token = "0x602C4F2")]
		[Address(RVA = "0x28550F0", Offset = "0x2853CF0", VA = "0x1828550F0", Slot = "10")]
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4F3 RID: 181491 RVA: 0x000DF770 File Offset: 0x000DD970
		[Token(Token = "0x602C4F3")]
		[Address(RVA = "0x2854F00", Offset = "0x2853B00", VA = "0x182854F00", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4F4 RID: 181492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4F4")]
		[Address(RVA = "0x2854EA0", Offset = "0x2853AA0", VA = "0x182854EA0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C4F5 RID: 181493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4F5")]
		[Address(RVA = "0x28552C0", Offset = "0x2853EC0", VA = "0x1828552C0")]
		public Bounds_DirectConverter()
		{
		}
	}
}
