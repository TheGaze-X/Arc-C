using System;
using Il2CppDummyDll;
using UnityEngine.Timeline;

namespace Torappu.UI
{
	// Token: 0x020036D4 RID: 14036
	[Token(Token = "0x20036D4")]
	[Serializable]
	public class UIRingStateMarker : Marker, IMarker
	{
		// Token: 0x060164DD RID: 91357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164DD")]
		[Address(RVA = "0x4E4190", Offset = "0x4E2D90", VA = "0x1804E4190")]
		public UIRingStateMarker()
		{
		}

		// Token: 0x0401AD38 RID: 109880
		[Token(Token = "0x401AD38")]
		[FieldOffset(Offset = "0x28")]
		public string stateId;
	}
}
