using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI
{
	// Token: 0x02003848 RID: 14408
	[Token(Token = "0x2003848")]
	[Serializable]
	public class TrackPointViewProperty : DynamicBindProperty<TrackPointViewProperty, ITrackPointModel>
	{
		// Token: 0x06016D43 RID: 93507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D43")]
		public void UpdateState<T>([Optional] object param) where T : ITrackPointModel, new()
		{
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D44")]
		[Address(RVA = "0xF3C2D0", Offset = "0xF3AED0", VA = "0x180F3C2D0")]
		public TrackPointViewProperty()
		{
		}
	}
}
