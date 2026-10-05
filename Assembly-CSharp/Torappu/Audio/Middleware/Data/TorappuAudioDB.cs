using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FC2 RID: 8130
	[Token(Token = "0x2001FC2")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/TorappuAudioDB")]
	[Serializable]
	public class TorappuAudioDB : ConstTable<TorappuAudioData, TorappuAudioDB>
	{
		// Token: 0x0600C9F2 RID: 51698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9F2")]
		[Address(RVA = "0x34B40F0", Offset = "0x34B2CF0", VA = "0x1834B40F0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600C9F3 RID: 51699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9F3")]
		[Address(RVA = "0x34B3F30", Offset = "0x34B2B30", VA = "0x1834B3F30")]
		public MusicData GetMusicByBankName(string bankName)
		{
			return null;
		}

		// Token: 0x0600C9F4 RID: 51700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9F4")]
		[Address(RVA = "0x34B4040", Offset = "0x34B2C40", VA = "0x1834B4040")]
		public MusicData GetMusicById(string musicId)
		{
			return null;
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9F5")]
		[Address(RVA = "0x34B3C90", Offset = "0x34B2890", VA = "0x1834B3C90")]
		public BGMBank GetBgmBankByName(string bgmBankName)
		{
			return null;
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9F6")]
		[Address(RVA = "0x34B3D70", Offset = "0x34B2970", VA = "0x1834B3D70")]
		public DuckingData GetDuckingDataByBankName(string bankName)
		{
			return null;
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C9F7")]
		[Address(RVA = "0x34B3E50", Offset = "0x34B2A50", VA = "0x1834B3E50")]
		public FadeStyleData GetFadeStyleDataByName(string styleName)
		{
			return null;
		}

		// Token: 0x0600C9F8 RID: 51704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9F8")]
		[Address(RVA = "0x34B3930", Offset = "0x34B2530", VA = "0x1834B3930")]
		public void GetBanks(Dictionary<string, List<Bank>> banks)
		{
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9F9")]
		[Address(RVA = "0x34B4570", Offset = "0x34B3170", VA = "0x1834B4570")]
		private void _TryAddBank(Dictionary<string, List<Bank>> dict, Bank bank)
		{
		}

		// Token: 0x0600C9FA RID: 51706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9FA")]
		[Address(RVA = "0x34B46D0", Offset = "0x34B32D0", VA = "0x1834B46D0")]
		public TorappuAudioDB()
		{
		}

		// Token: 0x0400D26A RID: 53866
		[Token(Token = "0x400D26A")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, MusicData> m_srcBankToMusic;

		// Token: 0x0400D26B RID: 53867
		[Token(Token = "0x400D26B")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<string, MusicData> m_musicSearchTable;

		// Token: 0x0400D26C RID: 53868
		[Token(Token = "0x400D26C")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, BGMBank> m_bgmBankTable;

		// Token: 0x0400D26D RID: 53869
		[Token(Token = "0x400D26D")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Dictionary<string, DuckingData> m_duckingDataTable;

		// Token: 0x0400D26E RID: 53870
		[Token(Token = "0x400D26E")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private Dictionary<string, FadeStyleData> m_fadeStyleTable;

		// Token: 0x0400D26F RID: 53871
		[Token(Token = "0x400D26F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D270 RID: 53872
		[Token(Token = "0x400D270")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMusicByBankName;

		// Token: 0x0400D271 RID: 53873
		[Token(Token = "0x400D271")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMusicById;

		// Token: 0x0400D272 RID: 53874
		[Token(Token = "0x400D272")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBgmBankByName;

		// Token: 0x0400D273 RID: 53875
		[Token(Token = "0x400D273")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDuckingDataByBankName;

		// Token: 0x0400D274 RID: 53876
		[Token(Token = "0x400D274")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFadeStyleDataByName;

		// Token: 0x0400D275 RID: 53877
		[Token(Token = "0x400D275")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBanks;

		// Token: 0x0400D276 RID: 53878
		[Token(Token = "0x400D276")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryAddBank;

		// Token: 0x0400D277 RID: 53879
		[Token(Token = "0x400D277")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
