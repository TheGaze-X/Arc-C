using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA5 RID: 31653
	[Token(Token = "0x2007BA5")]
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
	{
		// Token: 0x0602C502 RID: 181506 RVA: 0x000DF818 File Offset: 0x000DDA18
		[Token(Token = "0x602C502")]
		[Address(RVA = "0x2861AD0", Offset = "0x28606D0", VA = "0x182861AD0", Slot = "10")]
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C503 RID: 181507 RVA: 0x000DF830 File Offset: 0x000DDA30
		[Token(Token = "0x602C503")]
		[Address(RVA = "0x28617A0", Offset = "0x28603A0", VA = "0x1828617A0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C504 RID: 181508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C504")]
		[Address(RVA = "0x2861740", Offset = "0x2860340", VA = "0x182861740", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C505 RID: 181509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C505")]
		[Address(RVA = "0x2861DA0", Offset = "0x28609A0", VA = "0x182861DA0")]
		public Keyframe_DirectConverter()
		{
		}
	}
}
