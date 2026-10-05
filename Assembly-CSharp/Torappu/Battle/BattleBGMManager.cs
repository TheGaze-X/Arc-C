using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002176 RID: 8566
	[Token(Token = "0x2002176")]
	public class BattleBGMManager : IHotfixable, IDisposable
	{
		// Token: 0x0600D2FA RID: 54010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2FA")]
		[Address(RVA = "0x3583830", Offset = "0x3582430", VA = "0x183583830")]
		public BattleBGMManager()
		{
		}

		// Token: 0x0600D2FB RID: 54011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2FB")]
		[Address(RVA = "0x35834A0", Offset = "0x35820A0", VA = "0x1835834A0")]
		public void Play(string signal, string subSignal, [Optional] IBattleBGMModule module)
		{
		}

		// Token: 0x0600D2FC RID: 54012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2FC")]
		[Address(RVA = "0x35827B0", Offset = "0x35813B0", VA = "0x1835827B0")]
		public void NotifyPlayByModule(IBattleBGMModule module, BattleBGMManager.BattleBGMInfo info)
		{
		}

		// Token: 0x0600D2FD RID: 54013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2FD")]
		[Address(RVA = "0x3582DE0", Offset = "0x35819E0", VA = "0x183582DE0")]
		public void NotifyStopByModule(IBattleBGMModule module, BattleBGMManager.BattleBGMInfo info)
		{
		}

		// Token: 0x0600D2FE RID: 54014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2FE")]
		[Address(RVA = "0x35835C0", Offset = "0x35821C0", VA = "0x1835835C0")]
		private void _RegisterModule(IBattleBGMModule module)
		{
		}

		// Token: 0x0600D2FF RID: 54015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D2FF")]
		[Address(RVA = "0x3583680", Offset = "0x3582280", VA = "0x183583680")]
		private IEnumerator _StopModuleAfterMaxPlayTime(IBattleBGMModule module, BattleBGMManager.BattleBGMInfo info)
		{
			return null;
		}

		// Token: 0x0600D300 RID: 54016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D300")]
		[Address(RVA = "0x3583790", Offset = "0x3582390", VA = "0x183583790")]
		private void _UnregisterModule(IBattleBGMModule module)
		{
		}

		// Token: 0x0600D301 RID: 54017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D301")]
		[Address(RVA = "0x35825A0", Offset = "0x35811A0", VA = "0x1835825A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400E1FB RID: 57851
		[Token(Token = "0x400E1FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<IBattleBGMModule> m_modules;

		// Token: 0x0400E1FC RID: 57852
		[Token(Token = "0x400E1FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IBattleBGMModule m_defaultModule;

		// Token: 0x0400E1FD RID: 57853
		[Token(Token = "0x400E1FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Coroutine m_stopModuleCoroutine;

		// Token: 0x0400E1FE RID: 57854
		[Token(Token = "0x400E1FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400E1FF RID: 57855
		[Token(Token = "0x400E1FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400E200 RID: 57856
		[Token(Token = "0x400E200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyPlayByModule;

		// Token: 0x0400E201 RID: 57857
		[Token(Token = "0x400E201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyStopByModule;

		// Token: 0x0400E202 RID: 57858
		[Token(Token = "0x400E202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterModule;

		// Token: 0x0400E203 RID: 57859
		[Token(Token = "0x400E203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StopModuleAfterMaxPlayTime;

		// Token: 0x0400E204 RID: 57860
		[Token(Token = "0x400E204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UnregisterModule;

		// Token: 0x0400E205 RID: 57861
		[Token(Token = "0x400E205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x02002177 RID: 8567
		[Token(Token = "0x2002177")]
		private class BattleBGMDefaultModule : IBattleBGMModule, IHotfixable, IDisposable
		{
			// Token: 0x1700195C RID: 6492
			// (get) Token: 0x0600D302 RID: 54018 RVA: 0x0004C098 File Offset: 0x0004A298
			[Token(Token = "0x1700195C")]
			public BattleBGMLevel level
			{
				[Token(Token = "0x600D302")]
				[Address(RVA = "0x3582540", Offset = "0x3581140", VA = "0x183582540", Slot = "4")]
				get
				{
					return BattleBGMLevel.CHARACTER_FEVER;
				}
			}

			// Token: 0x0600D303 RID: 54019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D303")]
			[Address(RVA = "0x3582380", Offset = "0x3580F80", VA = "0x183582380", Slot = "5")]
			public void OnMute(BattleBGMManager.BattleBGMInfo bgmInfo)
			{
			}

			// Token: 0x0600D304 RID: 54020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D304")]
			[Address(RVA = "0x3582410", Offset = "0x3581010", VA = "0x183582410", Slot = "6")]
			public void OnResume(BattleBGMManager.BattleBGMInfo bgmInfo)
			{
			}

			// Token: 0x0600D305 RID: 54021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D305")]
			[Address(RVA = "0x3582310", Offset = "0x3580F10", VA = "0x183582310", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x0600D306 RID: 54022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D306")]
			[Address(RVA = "0x35824A0", Offset = "0x35810A0", VA = "0x1835824A0")]
			public BattleBGMDefaultModule()
			{
			}

			// Token: 0x0400E206 RID: 57862
			[Token(Token = "0x400E206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UIMusicDuckingHelper m_musicDuckingHelper;

			// Token: 0x0400E207 RID: 57863
			[Token(Token = "0x400E207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_level;

			// Token: 0x0400E208 RID: 57864
			[Token(Token = "0x400E208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnMute;

			// Token: 0x0400E209 RID: 57865
			[Token(Token = "0x400E209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnResume;

			// Token: 0x0400E20A RID: 57866
			[Token(Token = "0x400E20A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0400E20B RID: 57867
			[Token(Token = "0x400E20B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002178 RID: 8568
		[Token(Token = "0x2002178")]
		public struct BattleBGMInfo
		{
			// Token: 0x0400E20C RID: 57868
			[Token(Token = "0x400E20C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string duckingBankName;

			// Token: 0x0400E20D RID: 57869
			[Token(Token = "0x400E20D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool useMaxTime;

			// Token: 0x0400E20E RID: 57870
			[Token(Token = "0x400E20E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxTime;
		}
	}
}
