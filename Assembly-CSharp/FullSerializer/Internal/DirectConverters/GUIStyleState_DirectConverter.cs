using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA3 RID: 31651
	[Token(Token = "0x2007BA3")]
	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
	{
		// Token: 0x0602C4FA RID: 181498 RVA: 0x000DF7B8 File Offset: 0x000DD9B8
		[Token(Token = "0x602C4FA")]
		[Address(RVA = "0x28587F0", Offset = "0x28573F0", VA = "0x1828587F0", Slot = "10")]
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4FB RID: 181499 RVA: 0x000DF7D0 File Offset: 0x000DD9D0
		[Token(Token = "0x602C4FB")]
		[Address(RVA = "0x28585E0", Offset = "0x28571E0", VA = "0x1828585E0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C4FC RID: 181500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C4FC")]
		[Address(RVA = "0x2858590", Offset = "0x2857190", VA = "0x182858590", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C4FD RID: 181501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4FD")]
		[Address(RVA = "0x28589C0", Offset = "0x28575C0", VA = "0x1828589C0")]
		public GUIStyleState_DirectConverter()
		{
		}
	}
}
