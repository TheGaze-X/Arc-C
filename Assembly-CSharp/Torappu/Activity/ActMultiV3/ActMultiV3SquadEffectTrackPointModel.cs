using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FCD RID: 28621
	[Token(Token = "0x2006FCD")]
	public class ActMultiV3SquadEffectTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x06028A5B RID: 166491 RVA: 0x000D27E0 File Offset: 0x000D09E0
		[Token(Token = "0x17005FF2")]
		public bool isShow
		{
			[Token(Token = "0x6028A5B")]
			[Address(RVA = "0x23F5220", Offset = "0x23F3E20", VA = "0x1823F5220", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028A5C RID: 166492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A5C")]
		[Address(RVA = "0x23F50A0", Offset = "0x23F3CA0", VA = "0x1823F50A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06028A5D RID: 166493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A5D")]
		[Address(RVA = "0x23F51C0", Offset = "0x23F3DC0", VA = "0x1823F51C0")]
		public ActMultiV3SquadEffectTrackPointModel()
		{
		}

		// Token: 0x04039E9B RID: 237211
		[Token(Token = "0x4039E9B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04039E9C RID: 237212
		[Token(Token = "0x4039E9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04039E9D RID: 237213
		[Token(Token = "0x4039E9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04039E9E RID: 237214
		[Token(Token = "0x4039E9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FCE RID: 28622
		[Token(Token = "0x2006FCE")]
		public class Input
		{
			// Token: 0x06028A5E RID: 166494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028A5E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04039E9F RID: 237215
			[Token(Token = "0x4039E9F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
