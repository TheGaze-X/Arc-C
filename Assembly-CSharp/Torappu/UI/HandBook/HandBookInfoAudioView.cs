using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006692 RID: 26258
	[Token(Token = "0x2006692")]
	public class HandBookInfoAudioView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025B7B RID: 154491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7B")]
		[Address(RVA = "0x20A4AC0", Offset = "0x20A36C0", VA = "0x1820A4AC0")]
		public void PlayAudio()
		{
		}

		// Token: 0x06025B7C RID: 154492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7C")]
		[Address(RVA = "0x20A4C40", Offset = "0x20A3840", VA = "0x1820A4C40")]
		public void ShowText()
		{
		}

		// Token: 0x06025B7D RID: 154493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7D")]
		[Address(RVA = "0x20A49B0", Offset = "0x20A35B0", VA = "0x1820A49B0")]
		public void OnStopClick()
		{
		}

		// Token: 0x06025B7E RID: 154494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7E")]
		[Address(RVA = "0x20A4CC0", Offset = "0x20A38C0", VA = "0x1820A4CC0")]
		public void StopAudioUI()
		{
		}

		// Token: 0x06025B7F RID: 154495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7F")]
		[Address(RVA = "0x20A4A50", Offset = "0x20A3650", VA = "0x1820A4A50")]
		public void PlayAudioClick()
		{
		}

		// Token: 0x06025B80 RID: 154496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B80")]
		[Address(RVA = "0x20A4760", Offset = "0x20A3360", VA = "0x1820A4760")]
		public void Initalize(int id, HandBookInfoTextViewModel.InfoTextAudio viewModel, HandBookInfoView parentView)
		{
		}

		// Token: 0x06025B81 RID: 154497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B81")]
		[Address(RVA = "0x20A4D80", Offset = "0x20A3980", VA = "0x1820A4D80")]
		public void UpdateVoiceStatus()
		{
		}

		// Token: 0x06025B82 RID: 154498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B82")]
		[Address(RVA = "0x20A48D0", Offset = "0x20A34D0", VA = "0x1820A48D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06025B83 RID: 154499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B83")]
		[Address(RVA = "0x20A4EF0", Offset = "0x20A3AF0", VA = "0x1820A4EF0")]
		private void Update()
		{
		}

		// Token: 0x06025B84 RID: 154500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B84")]
		[Address(RVA = "0x20A5030", Offset = "0x20A3C30", VA = "0x1820A5030")]
		public HandBookInfoAudioView()
		{
		}

		// Token: 0x04034FCD RID: 217037
		[Token(Token = "0x4034FCD")]
		[FieldOffset(Offset = "0x18")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034FCE RID: 217038
		[Token(Token = "0x4034FCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _infoTextField;

		// Token: 0x04034FCF RID: 217039
		[Token(Token = "0x4034FCF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _play;

		// Token: 0x04034FD0 RID: 217040
		[Token(Token = "0x4034FD0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pause;

		// Token: 0x04034FD1 RID: 217041
		[Token(Token = "0x4034FD1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _slider;

		// Token: 0x04034FD2 RID: 217042
		[Token(Token = "0x4034FD2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _showText;

		// Token: 0x04034FD3 RID: 217043
		[Token(Token = "0x4034FD3")]
		[FieldOffset(Offset = "0x50")]
		private CharWordData m_sourceData;

		// Token: 0x04034FD4 RID: 217044
		[Token(Token = "0x4034FD4")]
		[FieldOffset(Offset = "0x58")]
		private VoiceLangType m_voiceLangType;

		// Token: 0x04034FD5 RID: 217045
		[Token(Token = "0x4034FD5")]
		[FieldOffset(Offset = "0x60")]
		private string m_infoText;

		// Token: 0x04034FD6 RID: 217046
		[Token(Token = "0x4034FD6")]
		[FieldOffset(Offset = "0x68")]
		private string m_infoTitle;

		// Token: 0x04034FD7 RID: 217047
		[Token(Token = "0x4034FD7")]
		[FieldOffset(Offset = "0x70")]
		private HandBookInfoView m_parentView;

		// Token: 0x04034FD8 RID: 217048
		[Token(Token = "0x4034FD8")]
		[FieldOffset(Offset = "0x78")]
		private int m_id;

		// Token: 0x04034FD9 RID: 217049
		[Token(Token = "0x4034FD9")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_onPlay;

		// Token: 0x04034FDA RID: 217050
		[Token(Token = "0x4034FDA")]
		[FieldOffset(Offset = "0x80")]
		private float m_allTime;

		// Token: 0x04034FDB RID: 217051
		[Token(Token = "0x4034FDB")]
		[FieldOffset(Offset = "0x84")]
		private float m_cacheTime;

		// Token: 0x04034FDC RID: 217052
		[Token(Token = "0x4034FDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAudio;

		// Token: 0x04034FDD RID: 217053
		[Token(Token = "0x4034FDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowText;

		// Token: 0x04034FDE RID: 217054
		[Token(Token = "0x4034FDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStopClick;

		// Token: 0x04034FDF RID: 217055
		[Token(Token = "0x4034FDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopAudioUI;

		// Token: 0x04034FE0 RID: 217056
		[Token(Token = "0x4034FE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayAudioClick;

		// Token: 0x04034FE1 RID: 217057
		[Token(Token = "0x4034FE1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Initalize;

		// Token: 0x04034FE2 RID: 217058
		[Token(Token = "0x4034FE2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateVoiceStatus;

		// Token: 0x04034FE3 RID: 217059
		[Token(Token = "0x4034FE3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04034FE4 RID: 217060
		[Token(Token = "0x4034FE4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04034FE5 RID: 217061
		[Token(Token = "0x4034FE5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
