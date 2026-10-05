using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA7 RID: 31655
	[Token(Token = "0x2007BA7")]
	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset>
	{
		// Token: 0x0602C50A RID: 181514 RVA: 0x000DF878 File Offset: 0x000DDA78
		[Token(Token = "0x602C50A")]
		[Address(RVA = "0x2863020", Offset = "0x2861C20", VA = "0x182863020", Slot = "10")]
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C50B RID: 181515 RVA: 0x000DF890 File Offset: 0x000DDA90
		[Token(Token = "0x602C50B")]
		[Address(RVA = "0x2862D30", Offset = "0x2861930", VA = "0x182862D30", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C50C RID: 181516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C50C")]
		[Address(RVA = "0x2862CE0", Offset = "0x28618E0", VA = "0x182862CE0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C50D RID: 181517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C50D")]
		[Address(RVA = "0x2863280", Offset = "0x2861E80", VA = "0x182863280")]
		public RectOffset_DirectConverter()
		{
		}
	}
}
