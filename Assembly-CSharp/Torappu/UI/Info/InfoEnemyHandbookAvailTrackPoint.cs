using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Info
{
	// Token: 0x02004A4C RID: 19020
	[Token(Token = "0x2004A4C")]
	public class InfoEnemyHandbookAvailTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x0601C97F RID: 117119 RVA: 0x000A8B58 File Offset: 0x000A6D58
		[Token(Token = "0x17004377")]
		public bool isShow
		{
			[Token(Token = "0x601C97F")]
			[Address(RVA = "0x1612500", Offset = "0x1611100", VA = "0x181612500", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C980 RID: 117120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C980")]
		[Address(RVA = "0x1612230", Offset = "0x1610E30", VA = "0x181612230", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C981 RID: 117121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C981")]
		[Address(RVA = "0x16124A0", Offset = "0x16110A0", VA = "0x1816124A0")]
		public InfoEnemyHandbookAvailTrackPoint()
		{
		}

		// Token: 0x040258B2 RID: 153778
		[Token(Token = "0x40258B2")]
		[FieldOffset(Offset = "0x10")]
		private bool m_availFlag;

		// Token: 0x040258B3 RID: 153779
		[Token(Token = "0x40258B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040258B4 RID: 153780
		[Token(Token = "0x40258B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040258B5 RID: 153781
		[Token(Token = "0x40258B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
