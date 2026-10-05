using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070DA RID: 28890
	[Token(Token = "0x20070DA")]
	public class BossRushWaveStartPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602910A RID: 168202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602910A")]
		[Address(RVA = "0x2479750", Offset = "0x2478350", VA = "0x182479750")]
		public void OnUpdateWaveInfo(int currWaveCnt, int maxWaveCnt)
		{
		}

		// Token: 0x0602910B RID: 168203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602910B")]
		[Address(RVA = "0x2479980", Offset = "0x2478580", VA = "0x182479980")]
		private void _UpdateWaveImages(bool isLastWave)
		{
		}

		// Token: 0x0602910C RID: 168204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602910C")]
		[Address(RVA = "0x2479AB0", Offset = "0x24786B0", VA = "0x182479AB0")]
		public BossRushWaveStartPanel()
		{
		}

		// Token: 0x0403A9C5 RID: 240069
		[Token(Token = "0x403A9C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _waveNumTexts;

		// Token: 0x0403A9C6 RID: 240070
		[Token(Token = "0x403A9C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _waveTexts;

		// Token: 0x0403A9C7 RID: 240071
		[Token(Token = "0x403A9C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _finalWaveTexts;

		// Token: 0x0403A9C8 RID: 240072
		[Token(Token = "0x403A9C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public UIPerform uiPerform;

		// Token: 0x0403A9C9 RID: 240073
		[Token(Token = "0x403A9C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdateWaveInfo;

		// Token: 0x0403A9CA RID: 240074
		[Token(Token = "0x403A9CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateWaveImages;

		// Token: 0x0403A9CB RID: 240075
		[Token(Token = "0x403A9CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
