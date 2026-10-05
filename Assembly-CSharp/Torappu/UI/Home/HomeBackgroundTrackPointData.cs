using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B98 RID: 19352
	[Token(Token = "0x2004B98")]
	public struct HomeBackgroundTrackPointData
	{
		// Token: 0x0601D1D1 RID: 119249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1D1")]
		[Address(RVA = "0x169B370", Offset = "0x1699F70", VA = "0x18169B370")]
		public void LoadData(string bgId)
		{
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x0601D1D2 RID: 119250 RVA: 0x000AA8B0 File Offset: 0x000A8AB0
		[Token(Token = "0x1700447F")]
		public bool hasTrackPoint
		{
			[Token(Token = "0x601D1D2")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04026347 RID: 156487
		[Token(Token = "0x4026347")]
		[FieldOffset(Offset = "0x0")]
		private bool _hasNewBackgroundTag;
	}
}
