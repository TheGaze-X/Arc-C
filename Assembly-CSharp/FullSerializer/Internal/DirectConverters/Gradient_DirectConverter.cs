using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA2 RID: 31650
	[Token(Token = "0x2007BA2")]
	public class Gradient_DirectConverter : fsDirectConverter<Gradient>
	{
		// Token: 0x0602C4F6 RID: 181494 RVA: 0x000DF788 File Offset: 0x000DD988
		[Token(Token = "0x602C4F6")]
		[Address(RVA = "0x285A9B0", Offset = "0x28595B0", VA = "0x18285A9B0", Slot = "10")]
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4F7 RID: 181495 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
		[Token(Token = "0x602C4F7")]
		[Address(RVA = "0x285A7C0", Offset = "0x28593C0", VA = "0x18285A7C0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4F8 RID: 181496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4F8")]
		[Address(RVA = "0x285A770", Offset = "0x2859370", VA = "0x18285A770", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C4F9 RID: 181497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4F9")]
		[Address(RVA = "0x285AB50", Offset = "0x2859750", VA = "0x18285AB50")]
		public Gradient_DirectConverter()
		{
		}
	}
}
