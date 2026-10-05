using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200228D RID: 8845
	[Token(Token = "0x200228D")]
	public class EnvFeverDuckingMusic : GlobalEnvSystem.EnvEventExecutor, IBattleBGMModule, IHotfixable, IDisposable
	{
		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x0600DE92 RID: 56978 RVA: 0x00051078 File Offset: 0x0004F278
		[Token(Token = "0x17001BF3")]
		public BattleBGMLevel level
		{
			[Token(Token = "0x600DE92")]
			[Address(RVA = "0x3652FD0", Offset = "0x3651BD0", VA = "0x183652FD0", Slot = "20")]
			get
			{
				return BattleBGMLevel.CHARACTER_FEVER;
			}
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE93")]
		[Address(RVA = "0x36522C0", Offset = "0x3650EC0", VA = "0x1836522C0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE94")]
		[Address(RVA = "0x3652530", Offset = "0x3651130", VA = "0x183652530", Slot = "19")]
		public override void OnEnvChanged(string status)
		{
		}

		// Token: 0x0600DE95 RID: 56981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE95")]
		[Address(RVA = "0x36527F0", Offset = "0x36513F0", VA = "0x1836527F0", Slot = "21")]
		public void OnMute(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}

		// Token: 0x0600DE96 RID: 56982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE96")]
		[Address(RVA = "0x3652900", Offset = "0x3651500", VA = "0x183652900", Slot = "22")]
		public void OnResume(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE97")]
		[Address(RVA = "0x3652710", Offset = "0x3651310", VA = "0x183652710", Slot = "23")]
		public void OnInterrupt(BattleBGMManager.BattleBGMInfo bgmInfo)
		{
		}

		// Token: 0x0600DE98 RID: 56984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE98")]
		[Address(RVA = "0x3652CD0", Offset = "0x36518D0", VA = "0x183652CD0")]
		private void _StopMainIfNot(bool isStoppedByModule = false)
		{
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE99")]
		[Address(RVA = "0x3652460", Offset = "0x3651060", VA = "0x183652460")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9A")]
		[Address(RVA = "0x3652DE0", Offset = "0x36519E0", VA = "0x183652DE0")]
		private void _StopSubDuckingIfValid()
		{
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9B")]
		[Address(RVA = "0x3652970", Offset = "0x3651570", VA = "0x183652970")]
		private void _PlayMainDuckingIfNot()
		{
		}

		// Token: 0x0600DE9C RID: 56988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9C")]
		[Address(RVA = "0x3652B00", Offset = "0x3651700", VA = "0x183652B00")]
		private void _PlaySubDuckingIfNot()
		{
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9D")]
		[Address(RVA = "0x3652230", Offset = "0x3650E30", VA = "0x183652230", Slot = "24")]
		public void Dispose()
		{
		}

		// Token: 0x0600DE9E RID: 56990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9E")]
		[Address(RVA = "0x3652E70", Offset = "0x3651A70", VA = "0x183652E70")]
		public EnvFeverDuckingMusic()
		{
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE9F")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA0")]
		[Address(RVA = "0x3652050", Offset = "0x3650C50", VA = "0x183652050")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0)
		{
		}

		// Token: 0x0400F177 RID: 61815
		[Token(Token = "0x400F177")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnvFeverDuckingMusic.DuckingSetting _mainDucking;

		// Token: 0x0400F178 RID: 61816
		[Token(Token = "0x400F178")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EnvFeverDuckingMusic.DuckingSetting _subDucking;

		// Token: 0x0400F179 RID: 61817
		[Token(Token = "0x400F179")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _mainStatus;

		// Token: 0x0400F17A RID: 61818
		[Token(Token = "0x400F17A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _subStatus;

		// Token: 0x0400F17B RID: 61819
		[Token(Token = "0x400F17B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _stopStatus;

		// Token: 0x0400F17C RID: 61820
		[Token(Token = "0x400F17C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _startStatus;

		// Token: 0x0400F17D RID: 61821
		[Token(Token = "0x400F17D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _maxPlayingTime;

		// Token: 0x0400F17E RID: 61822
		[Token(Token = "0x400F17E")]
		[FieldOffset(Offset = "0x68")]
		private string m_mainBankName;

		// Token: 0x0400F17F RID: 61823
		[Token(Token = "0x400F17F")]
		[FieldOffset(Offset = "0x70")]
		private string m_subBankName;

		// Token: 0x0400F180 RID: 61824
		[Token(Token = "0x400F180")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isMainDuckingValid;

		// Token: 0x0400F181 RID: 61825
		[Token(Token = "0x400F181")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isSubDuckingValid;

		// Token: 0x0400F182 RID: 61826
		[Token(Token = "0x400F182")]
		[FieldOffset(Offset = "0x80")]
		private UIMusicDuckingHelper m_subDuckingHelper;

		// Token: 0x0400F183 RID: 61827
		[Token(Token = "0x400F183")]
		[FieldOffset(Offset = "0x88")]
		private AudioMusicGroupHandler m_mainMusicDuckinghandler;

		// Token: 0x0400F184 RID: 61828
		[Token(Token = "0x400F184")]
		[FieldOffset(Offset = "0x90")]
		private AudioMusicGroupHandler m_subMusicDuckinghandler;

		// Token: 0x0400F185 RID: 61829
		[Token(Token = "0x400F185")]
		[FieldOffset(Offset = "0x98")]
		private string m_currentPlayingStatus;

		// Token: 0x0400F186 RID: 61830
		[Token(Token = "0x400F186")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isFeverDuckingValid;

		// Token: 0x0400F187 RID: 61831
		[Token(Token = "0x400F187")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0400F188 RID: 61832
		[Token(Token = "0x400F188")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F189 RID: 61833
		[Token(Token = "0x400F189")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F18A RID: 61834
		[Token(Token = "0x400F18A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMute;

		// Token: 0x0400F18B RID: 61835
		[Token(Token = "0x400F18B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400F18C RID: 61836
		[Token(Token = "0x400F18C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInterrupt;

		// Token: 0x0400F18D RID: 61837
		[Token(Token = "0x400F18D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StopMainIfNot;

		// Token: 0x0400F18E RID: 61838
		[Token(Token = "0x400F18E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F18F RID: 61839
		[Token(Token = "0x400F18F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopSubDuckingIfValid;

		// Token: 0x0400F190 RID: 61840
		[Token(Token = "0x400F190")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayMainDuckingIfNot;

		// Token: 0x0400F191 RID: 61841
		[Token(Token = "0x400F191")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlaySubDuckingIfNot;

		// Token: 0x0400F192 RID: 61842
		[Token(Token = "0x400F192")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400F193 RID: 61843
		[Token(Token = "0x400F193")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200228E RID: 8846
		[Token(Token = "0x200228E")]
		[Serializable]
		public class DuckingSetting
		{
			// Token: 0x0600DEA1 RID: 56993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEA1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DuckingSetting()
			{
			}

			// Token: 0x0400F194 RID: 61844
			[Token(Token = "0x400F194")]
			[FieldOffset(Offset = "0x10")]
			public string status;

			// Token: 0x0400F195 RID: 61845
			[Token(Token = "0x400F195")]
			[FieldOffset(Offset = "0x18")]
			public string bankName;
		}
	}
}
