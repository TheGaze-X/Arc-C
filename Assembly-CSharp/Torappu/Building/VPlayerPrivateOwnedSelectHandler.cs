using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017E8 RID: 6120
	[Token(Token = "0x20017E8")]
	public class VPlayerPrivateOwnedSelectHandler : IBuildingBindTools, IHotfixable, IDisposable
	{
		// Token: 0x06009AAA RID: 39594 RVA: 0x0003C120 File Offset: 0x0003A320
		[Token(Token = "0x6009AAA")]
		[Address(RVA = "0x3169B70", Offset = "0x3168770", VA = "0x183169B70", Slot = "4")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAB")]
		[Address(RVA = "0x3169940", Offset = "0x3168540", VA = "0x183169940", Slot = "5")]
		public void BindController(BuildingController controller)
		{
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAC")]
		[Address(RVA = "0x3169FC0", Offset = "0x3168BC0", VA = "0x183169FC0")]
		private void _UnbindEventAndClearCache()
		{
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAD")]
		[Address(RVA = "0x3169EA0", Offset = "0x3168AA0", VA = "0x183169EA0")]
		private void _OnObjectSelected(object obj)
		{
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AAE")]
		[Address(RVA = "0x3169AB0", Offset = "0x31686B0", VA = "0x183169AB0", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x0003C138 File Offset: 0x0003A338
		[Token(Token = "0x6009AAF")]
		[Address(RVA = "0x3169A50", Offset = "0x3168650", VA = "0x183169A50", Slot = "7")]
		public bool CheckNeedActiveWithoutController()
		{
			return default(bool);
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x0003C150 File Offset: 0x0003A350
		[Token(Token = "0x6009AB0")]
		[Address(RVA = "0x3169C60", Offset = "0x3168860", VA = "0x183169C60")]
		private bool _CheckPrivateChar()
		{
			return default(bool);
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB1")]
		[Address(RVA = "0x3169BD0", Offset = "0x31687D0", VA = "0x183169BD0", Slot = "6")]
		public void Tick(float ts)
		{
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB2")]
		[Address(RVA = "0x3169B10", Offset = "0x3168710", VA = "0x183169B10", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB3")]
		[Address(RVA = "0x316A100", Offset = "0x3168D00", VA = "0x18316A100")]
		public VPlayerPrivateOwnedSelectHandler()
		{
		}

		// Token: 0x040090EE RID: 37102
		[Token(Token = "0x40090EE")]
		[FieldOffset(Offset = "0x10")]
		private BuildingController m_controller;

		// Token: 0x040090EF RID: 37103
		[Token(Token = "0x40090EF")]
		[FieldOffset(Offset = "0x18")]
		private VCharacter m_vchar;

		// Token: 0x040090F0 RID: 37104
		[Token(Token = "0x40090F0")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isActive;

		// Token: 0x040090F1 RID: 37105
		[Token(Token = "0x40090F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x040090F2 RID: 37106
		[Token(Token = "0x40090F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x040090F3 RID: 37107
		[Token(Token = "0x40090F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UnbindEventAndClearCache;

		// Token: 0x040090F4 RID: 37108
		[Token(Token = "0x40090F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnObjectSelected;

		// Token: 0x040090F5 RID: 37109
		[Token(Token = "0x40090F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040090F6 RID: 37110
		[Token(Token = "0x40090F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckNeedActiveWithoutController;

		// Token: 0x040090F7 RID: 37111
		[Token(Token = "0x40090F7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckPrivateChar;

		// Token: 0x040090F8 RID: 37112
		[Token(Token = "0x40090F8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x040090F9 RID: 37113
		[Token(Token = "0x40090F9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x040090FA RID: 37114
		[Token(Token = "0x40090FA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
