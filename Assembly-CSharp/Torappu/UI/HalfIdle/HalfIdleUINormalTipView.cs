using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006767 RID: 26471
	[Token(Token = "0x2006767")]
	public class HalfIdleUINormalTipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025FA1 RID: 155553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FA1")]
		[Address(RVA = "0x20F9010", Offset = "0x20F7C10", VA = "0x1820F9010")]
		public void Render(HalfIdleBattleTipItemSubType type)
		{
		}

		// Token: 0x06025FA2 RID: 155554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FA2")]
		[Address(RVA = "0x20F93C0", Offset = "0x20F7FC0", VA = "0x1820F93C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025FA3 RID: 155555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FA3")]
		[Address(RVA = "0x20F9440", Offset = "0x20F8040", VA = "0x1820F9440")]
		public HalfIdleUINormalTipView()
		{
		}

		// Token: 0x04035711 RID: 218897
		[Token(Token = "0x4035711")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x04035712 RID: 218898
		[Token(Token = "0x4035712")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _dynamicText;

		// Token: 0x04035713 RID: 218899
		[Token(Token = "0x4035713")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x04035714 RID: 218900
		[Token(Token = "0x4035714")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<HalfIdleUINormalTipView.HalfIdleTipPair> _tipStrPairs;

		// Token: 0x04035715 RID: 218901
		[Token(Token = "0x4035715")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x04035716 RID: 218902
		[Token(Token = "0x4035716")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x04035717 RID: 218903
		[Token(Token = "0x4035717")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035718 RID: 218904
		[Token(Token = "0x4035718")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035719 RID: 218905
		[Token(Token = "0x4035719")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006768 RID: 26472
		[Token(Token = "0x2006768")]
		[Serializable]
		private class HalfIdleTipPair
		{
			// Token: 0x06025FA4 RID: 155556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025FA4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalfIdleTipPair()
			{
			}

			// Token: 0x0403571A RID: 218906
			[Token(Token = "0x403571A")]
			[FieldOffset(Offset = "0x10")]
			public HalfIdleBattleTipItemSubType key;

			// Token: 0x0403571B RID: 218907
			[Token(Token = "0x403571B")]
			[FieldOffset(Offset = "0x18")]
			public string value;
		}
	}
}
