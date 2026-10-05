using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004144 RID: 16708
	[Token(Token = "0x2004144")]
	public class SandboxV2BasementUpgradePage : StateEnginePage
	{
		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x06019CDB RID: 105691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D82")]
		public string topicId
		{
			[Token(Token = "0x6019CDB")]
			[Address(RVA = "0x12A4260", Offset = "0x12A2E60", VA = "0x1812A4260")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019CDC RID: 105692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CDC")]
		[Address(RVA = "0x12A4030", Offset = "0x12A2C30", VA = "0x1812A4030", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06019CDD RID: 105693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CDD")]
		[Address(RVA = "0x12A40B0", Offset = "0x12A2CB0", VA = "0x1812A40B0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06019CDE RID: 105694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CDE")]
		[Address(RVA = "0x12A3F80", Offset = "0x12A2B80", VA = "0x1812A3F80", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06019CDF RID: 105695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CDF")]
		[Address(RVA = "0x12A3E60", Offset = "0x12A2A60", VA = "0x1812A3E60")]
		public void EventOnClosePage()
		{
		}

		// Token: 0x06019CE0 RID: 105696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CE0")]
		[Address(RVA = "0x12A4110", Offset = "0x12A2D10", VA = "0x1812A4110")]
		private void _ClosePage()
		{
		}

		// Token: 0x06019CE1 RID: 105697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CE1")]
		[Address(RVA = "0x12A4200", Offset = "0x12A2E00", VA = "0x1812A4200")]
		public SandboxV2BasementUpgradePage()
		{
		}

		// Token: 0x06019CE3 RID: 105699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CE3")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06019CE4 RID: 105700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CE4")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06019CE5 RID: 105701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CE5")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04020631 RID: 132657
		[Token(Token = "0x4020631")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020632 RID: 132658
		[Token(Token = "0x4020632")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04020633 RID: 132659
		[Token(Token = "0x4020633")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04020634 RID: 132660
		[Token(Token = "0x4020634")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04020635 RID: 132661
		[Token(Token = "0x4020635")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClosePage;

		// Token: 0x04020636 RID: 132662
		[Token(Token = "0x4020636")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClosePage;

		// Token: 0x04020637 RID: 132663
		[Token(Token = "0x4020637")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004145 RID: 16709
		[Token(Token = "0x2004145")]
		public class Param
		{
			// Token: 0x06019CE6 RID: 105702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019CE6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04020638 RID: 132664
			[Token(Token = "0x4020638")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
