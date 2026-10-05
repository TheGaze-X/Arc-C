using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007966 RID: 31078
	[Token(Token = "0x2007966")]
	public class Act1ArcadeSettlementScoreComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B994 RID: 178580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B994")]
		[Address(RVA = "0x27829B0", Offset = "0x27815B0", VA = "0x1827829B0")]
		public void RenderAndPlay(int startNum, int targetNum, float duration, float delay = 0f, [Optional] string audioSignal)
		{
		}

		// Token: 0x0602B995 RID: 178581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B995")]
		[Address(RVA = "0x2782D60", Offset = "0x2781960", VA = "0x182782D60")]
		private IEnumerator _PlayAudio(string audioSignal, float delay)
		{
			return null;
		}

		// Token: 0x0602B996 RID: 178582 RVA: 0x000DC8D8 File Offset: 0x000DAAD8
		[Token(Token = "0x602B996")]
		[Address(RVA = "0x2782E30", Offset = "0x2781A30", VA = "0x182782E30")]
		private int _TweenScoreGetter()
		{
			return 0;
		}

		// Token: 0x0602B997 RID: 178583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B997")]
		[Address(RVA = "0x2782E90", Offset = "0x2781A90", VA = "0x182782E90")]
		private void _TweenScoreSetter(int newScore)
		{
		}

		// Token: 0x0602B998 RID: 178584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B998")]
		[Address(RVA = "0x2782FA0", Offset = "0x2781BA0", VA = "0x182782FA0")]
		public Act1ArcadeSettlementScoreComp()
		{
		}

		// Token: 0x0403F117 RID: 258327
		[Token(Token = "0x403F117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textScore;

		// Token: 0x0403F118 RID: 258328
		[Token(Token = "0x403F118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_scoreShow;

		// Token: 0x0403F119 RID: 258329
		[Token(Token = "0x403F119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x0403F11A RID: 258330
		[Token(Token = "0x403F11A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderAndPlay;

		// Token: 0x0403F11B RID: 258331
		[Token(Token = "0x403F11B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAudio;

		// Token: 0x0403F11C RID: 258332
		[Token(Token = "0x403F11C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TweenScoreGetter;

		// Token: 0x0403F11D RID: 258333
		[Token(Token = "0x403F11D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TweenScoreSetter;

		// Token: 0x0403F11E RID: 258334
		[Token(Token = "0x403F11E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
