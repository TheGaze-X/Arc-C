using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F93 RID: 28563
	[Token(Token = "0x2006F93")]
	public class ActMultiV3MatchPosItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060288A9 RID: 166057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288A9")]
		[Address(RVA = "0x23D8A20", Offset = "0x23D7620", VA = "0x1823D8A20")]
		public void Render(ActMultiV3MatchPosModel posModel, bool isSelect)
		{
		}

		// Token: 0x060288AA RID: 166058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AA")]
		[Address(RVA = "0x23D88C0", Offset = "0x23D74C0", VA = "0x1823D88C0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060288AB RID: 166059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288AB")]
		[Address(RVA = "0x23D8C80", Offset = "0x23D7880", VA = "0x1823D8C80")]
		public ActMultiV3MatchPosItemView()
		{
		}

		// Token: 0x04039BAC RID: 236460
		[Token(Token = "0x4039BAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unselectPartGO;

		// Token: 0x04039BAD RID: 236461
		[Token(Token = "0x4039BAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectPartGO;

		// Token: 0x04039BAE RID: 236462
		[Token(Token = "0x4039BAE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPartGO;

		// Token: 0x04039BAF RID: 236463
		[Token(Token = "0x4039BAF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04039BB0 RID: 236464
		[Token(Token = "0x4039BB0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorTextUnselect;

		// Token: 0x04039BB1 RID: 236465
		[Token(Token = "0x4039BB1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorTextSelect;

		// Token: 0x04039BB2 RID: 236466
		[Token(Token = "0x4039BB2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgIconUnselect;

		// Token: 0x04039BB3 RID: 236467
		[Token(Token = "0x4039BB3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgIconSelect;

		// Token: 0x04039BB4 RID: 236468
		[Token(Token = "0x4039BB4")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039BB5 RID: 236469
		[Token(Token = "0x4039BB5")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039BB6 RID: 236470
		[Token(Token = "0x4039BB6")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3MatchPosModel m_posModel;

		// Token: 0x04039BB7 RID: 236471
		[Token(Token = "0x4039BB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039BB8 RID: 236472
		[Token(Token = "0x4039BB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04039BB9 RID: 236473
		[Token(Token = "0x4039BB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
