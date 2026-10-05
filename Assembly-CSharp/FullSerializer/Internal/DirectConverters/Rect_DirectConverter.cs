using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters
{
	// Token: 0x02007BA8 RID: 31656
	[Token(Token = "0x2007BA8")]
	public class Rect_DirectConverter : fsDirectConverter<Rect>
	{
		// Token: 0x0602C50E RID: 181518 RVA: 0x000DF8A8 File Offset: 0x000DDAA8
		[Token(Token = "0x602C50E")]
		[Address(RVA = "0x28635B0", Offset = "0x28621B0", VA = "0x1828635B0", Slot = "10")]
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		// Token: 0x0602C50F RID: 181519 RVA: 0x000DF8C0 File Offset: 0x000DDAC0
		[Token(Token = "0x602C50F")]
		[Address(RVA = "0x2863300", Offset = "0x2861F00", VA = "0x182863300", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
		{
			return default(fsResult);
		}

		// Token: 0x0602C510 RID: 181520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C510")]
		[Address(RVA = "0x28632C0", Offset = "0x2861EC0", VA = "0x1828632C0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C511 RID: 181521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C511")]
		[Address(RVA = "0x2863810", Offset = "0x2862410", VA = "0x182863810")]
		public Rect_DirectConverter()
		{
		}
	}
}
