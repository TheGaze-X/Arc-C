using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005741 RID: 22337
	[Token(Token = "0x2005741")]
	public class RL02BGMModuleWithSan : RoguelikeBGMModule
	{
		// Token: 0x06020BB7 RID: 134071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB7")]
		[Address(RVA = "0x1B04410", Offset = "0x1B03010", VA = "0x181B04410", Slot = "8")]
		protected override void OnTriggerSignal()
		{
		}

		// Token: 0x06020BB8 RID: 134072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020BB8")]
		[Address(RVA = "0x1B049B0", Offset = "0x1B035B0", VA = "0x181B049B0")]
		private string _GetBgmSignalWithLowSanByZoneId(string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x06020BB9 RID: 134073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB9")]
		[Address(RVA = "0x1B04B30", Offset = "0x1B03730", VA = "0x181B04B30")]
		public RL02BGMModuleWithSan()
		{
		}

		// Token: 0x0402C6F9 RID: 182009
		[Token(Token = "0x402C6F9")]
		[FieldOffset(Offset = "0x38")]
		private UIMusicManager.LowpassEffect m_musicEffect;

		// Token: 0x0402C6FA RID: 182010
		[Token(Token = "0x402C6FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerSignal;

		// Token: 0x0402C6FB RID: 182011
		[Token(Token = "0x402C6FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBgmSignalWithLowSanByZoneId;

		// Token: 0x0402C6FC RID: 182012
		[Token(Token = "0x402C6FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
