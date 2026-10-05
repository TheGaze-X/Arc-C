using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB8 RID: 19384
	[Token(Token = "0x2004BB8")]
	public class OpenServerMissionPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700448F RID: 17551
		// (get) Token: 0x0601D225 RID: 119333 RVA: 0x000AAA90 File Offset: 0x000A8C90
		[Token(Token = "0x1700448F")]
		public bool isShow
		{
			[Token(Token = "0x601D225")]
			[Address(RVA = "0x16AD0F0", Offset = "0x16ABCF0", VA = "0x1816AD0F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D226 RID: 119334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D226")]
		[Address(RVA = "0x16AD030", Offset = "0x16ABC30", VA = "0x1816AD030", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D227")]
		[Address(RVA = "0x16AD090", Offset = "0x16ABC90", VA = "0x1816AD090")]
		public OpenServerMissionPointModel()
		{
		}

		// Token: 0x040263C5 RID: 156613
		[Token(Token = "0x40263C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040263C6 RID: 156614
		[Token(Token = "0x40263C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040263C7 RID: 156615
		[Token(Token = "0x40263C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
