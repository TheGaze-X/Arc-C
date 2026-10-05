using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017F6 RID: 6134
	[Token(Token = "0x20017F6")]
	public abstract class BuildingFuncFurniBtnModel : IHotfixable
	{
		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x0003C480 File Offset: 0x0003A680
		[Token(Token = "0x170010E6")]
		public bool showTrackPoint
		{
			[Token(Token = "0x6009AF0")]
			[Address(RVA = "0x3153220", Offset = "0x3151E20", VA = "0x183153220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x0003C498 File Offset: 0x0003A698
		[Token(Token = "0x170010E7")]
		public bool funcInUse
		{
			[Token(Token = "0x6009AF1")]
			[Address(RVA = "0x31531C0", Offset = "0x3151DC0", VA = "0x1831531C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF2")]
		[Address(RVA = "0x3152FC0", Offset = "0x3151BC0", VA = "0x183152FC0")]
		public void UpdateData()
		{
		}

		// Token: 0x06009AF3 RID: 39667
		[Token(Token = "0x6009AF3")]
		protected abstract void _UpdateDataPlayerMode();

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF4")]
		[Address(RVA = "0x3153100", Offset = "0x3151D00", VA = "0x183153100", Slot = "5")]
		protected virtual void _UpdateDataVisitorMode()
		{
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF5")]
		[Address(RVA = "0x3153160", Offset = "0x3151D60", VA = "0x183153160")]
		protected BuildingFuncFurniBtnModel()
		{
		}

		// Token: 0x0400914B RID: 37195
		[Token(Token = "0x400914B")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_showTrackPoint;

		// Token: 0x0400914C RID: 37196
		[Token(Token = "0x400914C")]
		[FieldOffset(Offset = "0x11")]
		protected bool m_funcInUse;

		// Token: 0x0400914D RID: 37197
		[Token(Token = "0x400914D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showTrackPoint;

		// Token: 0x0400914E RID: 37198
		[Token(Token = "0x400914E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_funcInUse;

		// Token: 0x0400914F RID: 37199
		[Token(Token = "0x400914F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04009150 RID: 37200
		[Token(Token = "0x4009150")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateDataVisitorMode;

		// Token: 0x04009151 RID: 37201
		[Token(Token = "0x4009151")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
