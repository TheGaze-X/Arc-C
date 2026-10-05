using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006706 RID: 26374
	[Token(Token = "0x2006706")]
	public class HandBookV2MapGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x06025D9D RID: 155037 RVA: 0x000C9360 File Offset: 0x000C7560
		[Token(Token = "0x170059A4")]
		public Vector2 deltaVector
		{
			[Token(Token = "0x6025D9D")]
			[Address(RVA = "0x20E1C40", Offset = "0x20E0840", VA = "0x1820E1C40")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06025D9E RID: 155038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D9E")]
		[Address(RVA = "0x20E1740", Offset = "0x20E0340", VA = "0x1820E1740")]
		private void _RenderLine(HandBookV2GroupPosData.LineData lineData)
		{
		}

		// Token: 0x06025D9F RID: 155039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D9F")]
		[Address(RVA = "0x20E04C0", Offset = "0x20DF0C0", VA = "0x1820E04C0")]
		public void ApplyViewModel(HandBookV2GroupViewModel viewModel, string mainForce)
		{
		}

		// Token: 0x06025DA0 RID: 155040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025DA0")]
		[Address(RVA = "0x20E1430", Offset = "0x20E0030", VA = "0x1820E1430")]
		public IEnumerator OnHideEffect(bool isScale = true)
		{
			return null;
		}

		// Token: 0x06025DA1 RID: 155041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025DA1")]
		[Address(RVA = "0x20E1370", Offset = "0x20DFF70", VA = "0x1820E1370")]
		public IEnumerator OnEnterEffect(bool isScale = true)
		{
			return null;
		}

		// Token: 0x06025DA2 RID: 155042 RVA: 0x000C9378 File Offset: 0x000C7578
		[Token(Token = "0x6025DA2")]
		[Address(RVA = "0x20E1670", Offset = "0x20E0270", VA = "0x1820E1670")]
		private bool _IsForceAvail(string forceId)
		{
			return default(bool);
		}

		// Token: 0x06025DA3 RID: 155043 RVA: 0x000C9390 File Offset: 0x000C7590
		[Token(Token = "0x6025DA3")]
		[Address(RVA = "0x20E14F0", Offset = "0x20E00F0", VA = "0x1820E14F0")]
		private bool _CanCharShowUp(HandBookV2GroupCharViewModel charViewModel)
		{
			return default(bool);
		}

		// Token: 0x06025DA4 RID: 155044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DA4")]
		[Address(RVA = "0x20E1930", Offset = "0x20E0530", VA = "0x1820E1930")]
		public HandBookV2MapGroupView()
		{
		}

		// Token: 0x04035382 RID: 217986
		[Token(Token = "0x4035382")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapCardView _cardView;

		// Token: 0x04035383 RID: 217987
		[Token(Token = "0x4035383")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2MapLineView _lineView;

		// Token: 0x04035384 RID: 217988
		[Token(Token = "0x4035384")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandBookV2MapGroupBackView _backView;

		// Token: 0x04035385 RID: 217989
		[Token(Token = "0x4035385")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookV2SixLineView _sixLineView;

		// Token: 0x04035386 RID: 217990
		[Token(Token = "0x4035386")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HandBookV2OtherForceView _otherForceView;

		// Token: 0x04035387 RID: 217991
		[Token(Token = "0x4035387")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HandBookV2MapGroupLogoView _forceLogoView;

		// Token: 0x04035388 RID: 217992
		[Token(Token = "0x4035388")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _backContainer;

		// Token: 0x04035389 RID: 217993
		[Token(Token = "0x4035389")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _lineContainer;

		// Token: 0x0403538A RID: 217994
		[Token(Token = "0x403538A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _sixLineContainer;

		// Token: 0x0403538B RID: 217995
		[Token(Token = "0x403538B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403538C RID: 217996
		[Token(Token = "0x403538C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _alphaContainer;

		// Token: 0x0403538D RID: 217997
		[Token(Token = "0x403538D")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public UIHandBookCardEvent clickEvent;

		// Token: 0x0403538E RID: 217998
		[Token(Token = "0x403538E")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UIStringEvent onForceClick;

		// Token: 0x0403538F RID: 217999
		[Token(Token = "0x403538F")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public HandBookV2MapGroupHolder holder;

		// Token: 0x04035390 RID: 218000
		[Token(Token = "0x4035390")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<string, HandBookV2MapCardView> m_cardView;

		// Token: 0x04035391 RID: 218001
		[Token(Token = "0x4035391")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<int, HandBookV2MapLineView> m_lineView;

		// Token: 0x04035392 RID: 218002
		[Token(Token = "0x4035392")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, HandBookV2MapGroupBackView> m_backView;

		// Token: 0x04035393 RID: 218003
		[Token(Token = "0x4035393")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<string, HandBookV2MapGroupBackView> m_colorBlockList;

		// Token: 0x04035394 RID: 218004
		[Token(Token = "0x4035394")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, HandBookV2OtherForceView> m_otherForceView;

		// Token: 0x04035395 RID: 218005
		[Token(Token = "0x4035395")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<string, HandBookV2MapGroupLogoView> m_forceLogoView;

		// Token: 0x04035396 RID: 218006
		[Token(Token = "0x4035396")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<string, HandBookV2SixLineView> m_sixLineGroupView;

		// Token: 0x04035397 RID: 218007
		[Token(Token = "0x4035397")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, bool> m_forceId2AvailMap;

		// Token: 0x04035398 RID: 218008
		[Token(Token = "0x4035398")]
		[FieldOffset(Offset = "0xC8")]
		private float m_maxX;

		// Token: 0x04035399 RID: 218009
		[Token(Token = "0x4035399")]
		[FieldOffset(Offset = "0xCC")]
		private float m_maxY;

		// Token: 0x0403539A RID: 218010
		[Token(Token = "0x403539A")]
		[FieldOffset(Offset = "0xD0")]
		private float m_minX;

		// Token: 0x0403539B RID: 218011
		[Token(Token = "0x403539B")]
		[FieldOffset(Offset = "0xD4")]
		private float m_minY;

		// Token: 0x0403539C RID: 218012
		[Token(Token = "0x403539C")]
		[FieldOffset(Offset = "0xD8")]
		private Vector2 m_deltaVector2;

		// Token: 0x0403539D RID: 218013
		[Token(Token = "0x403539D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_deltaVector;

		// Token: 0x0403539E RID: 218014
		[Token(Token = "0x403539E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderLine;

		// Token: 0x0403539F RID: 218015
		[Token(Token = "0x403539F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyViewModel;

		// Token: 0x040353A0 RID: 218016
		[Token(Token = "0x40353A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHideEffect;

		// Token: 0x040353A1 RID: 218017
		[Token(Token = "0x40353A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnterEffect;

		// Token: 0x040353A2 RID: 218018
		[Token(Token = "0x40353A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsForceAvail;

		// Token: 0x040353A3 RID: 218019
		[Token(Token = "0x40353A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CanCharShowUp;

		// Token: 0x040353A4 RID: 218020
		[Token(Token = "0x40353A4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
