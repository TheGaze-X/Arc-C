using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017F7 RID: 6135
	[Token(Token = "0x20017F7")]
	public class BuildingMessageBoardBtnModel : BuildingFuncFurniBtnModel
	{
		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		[Token(Token = "0x170010E8")]
		public bool forceShowBtn
		{
			[Token(Token = "0x6009AF6")]
			[Address(RVA = "0x3154C70", Offset = "0x3153870", VA = "0x183154C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF7")]
		[Address(RVA = "0x3154A10", Offset = "0x3153610", VA = "0x183154A10", Slot = "4")]
		protected override void _UpdateDataPlayerMode()
		{
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF8")]
		[Address(RVA = "0x3154B30", Offset = "0x3153730", VA = "0x183154B30", Slot = "5")]
		protected override void _UpdateDataVisitorMode()
		{
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AF9")]
		[Address(RVA = "0x3154BD0", Offset = "0x31537D0", VA = "0x183154BD0")]
		public BuildingMessageBoardBtnModel()
		{
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AFA")]
		[Address(RVA = "0x3153100", Offset = "0x3151D00", VA = "0x183153100")]
		private void <>xLuaBaseProxy__UpdateDataVisitorMode()
		{
		}

		// Token: 0x04009152 RID: 37202
		[Token(Token = "0x4009152")]
		[FieldOffset(Offset = "0x18")]
		private bool m_forceShowBtn;

		// Token: 0x04009153 RID: 37203
		[Token(Token = "0x4009153")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_forceShowBtn;

		// Token: 0x04009154 RID: 37204
		[Token(Token = "0x4009154")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDataPlayerMode;

		// Token: 0x04009155 RID: 37205
		[Token(Token = "0x4009155")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateDataVisitorMode;

		// Token: 0x04009156 RID: 37206
		[Token(Token = "0x4009156")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
