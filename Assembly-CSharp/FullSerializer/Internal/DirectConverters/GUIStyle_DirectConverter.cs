using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA4 RID: 31652
	[Token(Token = "0x2007BA4")]
	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
	{
		// Token: 0x0602C4FE RID: 181502 RVA: 0x000DF7E8 File Offset: 0x000DD9E8
		[Token(Token = "0x602C4FE")]
		[Address(RVA = "0x2859B20", Offset = "0x2858720", VA = "0x182859B20", Slot = "10")]
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4FF RID: 181503 RVA: 0x000DF800 File Offset: 0x000DDA00
		[Token(Token = "0x602C4FF")]
		[Address(RVA = "0x2858A50", Offset = "0x2857650", VA = "0x182858A50", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C500 RID: 181504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C500")]
		[Address(RVA = "0x2858A00", Offset = "0x2857600", VA = "0x182858A00", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C501 RID: 181505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C501")]
		[Address(RVA = "0x285A730", Offset = "0x2859330", VA = "0x18285A730")]
		public GUIStyle_DirectConverter()
		{
		}
	}
}
