using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B89 RID: 19337
	[Token(Token = "0x2004B89")]
	public class BuildingTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x0601D193 RID: 119187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700446E")]
		public BuildingToDoNotifyModel viewModel
		{
			[Token(Token = "0x601D193")]
			[Address(RVA = "0x1699430", Offset = "0x1698030", VA = "0x181699430")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x0601D194 RID: 119188 RVA: 0x000AA6D0 File Offset: 0x000A88D0
		[Token(Token = "0x1700446F")]
		public bool isShow
		{
			[Token(Token = "0x601D194")]
			[Address(RVA = "0x1699390", Offset = "0x1697F90", VA = "0x181699390", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D195 RID: 119189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D195")]
		[Address(RVA = "0x1699260", Offset = "0x1697E60", VA = "0x181699260", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D196 RID: 119190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D196")]
		[Address(RVA = "0x16992F0", Offset = "0x1697EF0", VA = "0x1816992F0")]
		public BuildingTrackPointModel()
		{
		}

		// Token: 0x04026304 RID: 156420
		[Token(Token = "0x4026304")]
		[FieldOffset(Offset = "0x10")]
		private BuildingToDoNotifyModel m_viewModel;

		// Token: 0x04026305 RID: 156421
		[Token(Token = "0x4026305")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isUnlocked;

		// Token: 0x04026306 RID: 156422
		[Token(Token = "0x4026306")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x04026307 RID: 156423
		[Token(Token = "0x4026307")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026308 RID: 156424
		[Token(Token = "0x4026308")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026309 RID: 156425
		[Token(Token = "0x4026309")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
