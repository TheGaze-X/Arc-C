using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FDC RID: 28636
	[Token(Token = "0x2006FDC")]
	public class ActMultiV3SquadTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028AC2 RID: 166594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC2")]
		[Address(RVA = "0x23FC810", Offset = "0x23FB410", VA = "0x1823FC810")]
		public void Render(ActMultiV3SquadModel squadModel, bool isSelect)
		{
		}

		// Token: 0x06028AC3 RID: 166595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC3")]
		[Address(RVA = "0x23FC6C0", Offset = "0x23FB2C0", VA = "0x1823FC6C0")]
		public void EventOnTabClick()
		{
		}

		// Token: 0x06028AC4 RID: 166596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC4")]
		[Address(RVA = "0x23FCB90", Offset = "0x23FB790", VA = "0x1823FCB90")]
		public ActMultiV3SquadTabItemView()
		{
		}

		// Token: 0x04039F22 RID: 237346
		[Token(Token = "0x4039F22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04039F23 RID: 237347
		[Token(Token = "0x4039F23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectPartGO;

		// Token: 0x04039F24 RID: 237348
		[Token(Token = "0x4039F24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unselectPartGO;

		// Token: 0x04039F25 RID: 237349
		[Token(Token = "0x4039F25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _charLackHintGO;

		// Token: 0x04039F26 RID: 237350
		[Token(Token = "0x4039F26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04039F27 RID: 237351
		[Token(Token = "0x4039F27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorNameSelect;

		// Token: 0x04039F28 RID: 237352
		[Token(Token = "0x4039F28")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorNameUnselect;

		// Token: 0x04039F29 RID: 237353
		[Token(Token = "0x4039F29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x04039F2A RID: 237354
		[Token(Token = "0x4039F2A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _lockIconGO;

		// Token: 0x04039F2B RID: 237355
		[Token(Token = "0x4039F2B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _alphaSquadLock;

		// Token: 0x04039F2C RID: 237356
		[Token(Token = "0x4039F2C")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Color _colorModeIconSelect;

		// Token: 0x04039F2D RID: 237357
		[Token(Token = "0x4039F2D")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Color _colorModeIconUnselect;

		// Token: 0x04039F2E RID: 237358
		[Token(Token = "0x4039F2E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _trackPointGO;

		// Token: 0x04039F2F RID: 237359
		[Token(Token = "0x4039F2F")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039F30 RID: 237360
		[Token(Token = "0x4039F30")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039F31 RID: 237361
		[Token(Token = "0x4039F31")]
		[FieldOffset(Offset = "0xC0")]
		private ActMultiV3SquadModel m_squadModel;

		// Token: 0x04039F32 RID: 237362
		[Token(Token = "0x4039F32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039F33 RID: 237363
		[Token(Token = "0x4039F33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnTabClick;

		// Token: 0x04039F34 RID: 237364
		[Token(Token = "0x4039F34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
