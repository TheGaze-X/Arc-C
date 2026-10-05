using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA6 RID: 31654
	[Token(Token = "0x2007BA6")]
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask>
	{
		// Token: 0x0602C506 RID: 181510 RVA: 0x000DF848 File Offset: 0x000DDA48
		[Token(Token = "0x602C506")]
		[Address(RVA = "0x2861F50", Offset = "0x2860B50", VA = "0x182861F50", Slot = "10")]
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C507 RID: 181511 RVA: 0x000DF860 File Offset: 0x000DDA60
		[Token(Token = "0x602C507")]
		[Address(RVA = "0x2861E20", Offset = "0x2860A20", VA = "0x182861E20", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C508 RID: 181512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C508")]
		[Address(RVA = "0x2861DE0", Offset = "0x28609E0", VA = "0x182861DE0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C509 RID: 181513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C509")]
		[Address(RVA = "0x2862060", Offset = "0x2860C60", VA = "0x182862060")]
		public LayerMask_DirectConverter()
		{
		}
	}
}
