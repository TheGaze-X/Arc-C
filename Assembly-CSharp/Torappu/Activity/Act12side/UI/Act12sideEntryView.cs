using System;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA5 RID: 31397
	[Token(Token = "0x2007AA5")]
	public class Act12sideEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BFBE RID: 180158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBE")]
		[Address(RVA = "0x27D8D10", Offset = "0x27D7910", VA = "0x1827D8D10")]
		public void Render(string activityId)
		{
		}

		// Token: 0x0602BFBF RID: 180159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBF")]
		[Address(RVA = "0x27D8F80", Offset = "0x27D7B80", VA = "0x1827D8F80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BFC0 RID: 180160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFC0")]
		[Address(RVA = "0x27D9020", Offset = "0x27D7C20", VA = "0x1827D9020")]
		private void _RefreshTimePanel()
		{
		}

		// Token: 0x0602BFC1 RID: 180161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFC1")]
		[Address(RVA = "0x27D9580", Offset = "0x27D8180", VA = "0x1827D9580")]
		public Act12sideEntryView()
		{
		}

		// Token: 0x0403FB52 RID: 260946
		[Token(Token = "0x403FB52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12sideCoinView _coinView;

		// Token: 0x0403FB53 RID: 260947
		[Token(Token = "0x403FB53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStageTimeCaption;

		// Token: 0x0403FB54 RID: 260948
		[Token(Token = "0x403FB54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRewardTimeCaption;

		// Token: 0x0403FB55 RID: 260949
		[Token(Token = "0x403FB55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEndTime;

		// Token: 0x0403FB56 RID: 260950
		[Token(Token = "0x403FB56")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0403FB57 RID: 260951
		[Token(Token = "0x403FB57")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnCharmNormalGo;

		// Token: 0x0403FB58 RID: 260952
		[Token(Token = "0x403FB58")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnCharmLockGo;

		// Token: 0x0403FB59 RID: 260953
		[Token(Token = "0x403FB59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCharmLockHint;

		// Token: 0x0403FB5A RID: 260954
		[Token(Token = "0x403FB5A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnCharm;

		// Token: 0x0403FB5B RID: 260955
		[Token(Token = "0x403FB5B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403FB5C RID: 260956
		[Token(Token = "0x403FB5C")]
		[FieldOffset(Offset = "0x68")]
		private string m_actId;

		// Token: 0x0403FB5D RID: 260957
		[Token(Token = "0x403FB5D")]
		[FieldOffset(Offset = "0x70")]
		private AudioClickPlayer m_btnCharmAudio;

		// Token: 0x0403FB5E RID: 260958
		[Token(Token = "0x403FB5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FB5F RID: 260959
		[Token(Token = "0x403FB5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FB60 RID: 260960
		[Token(Token = "0x403FB60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshTimePanel;

		// Token: 0x0403FB61 RID: 260961
		[Token(Token = "0x403FB61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
