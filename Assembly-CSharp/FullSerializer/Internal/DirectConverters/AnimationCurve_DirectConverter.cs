using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA0 RID: 31648
	[Token(Token = "0x2007BA0")]
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
	{
		// Token: 0x0602C4EE RID: 181486 RVA: 0x000DF728 File Offset: 0x000DD928
		[Token(Token = "0x602C4EE")]
		[Address(RVA = "0x2853870", Offset = "0x2852470", VA = "0x182853870", Slot = "10")]
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4EF RID: 181487 RVA: 0x000DF740 File Offset: 0x000DD940
		[Token(Token = "0x602C4EF")]
		[Address(RVA = "0x2853600", Offset = "0x2852200", VA = "0x182853600", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4F0 RID: 181488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4F0")]
		[Address(RVA = "0x28535B0", Offset = "0x28521B0", VA = "0x1828535B0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C4F1 RID: 181489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4F1")]
		[Address(RVA = "0x2853A80", Offset = "0x2852680", VA = "0x182853A80")]
		public AnimationCurve_DirectConverter()
		{
		}
	}
}
