using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007665 RID: 30309
	[Token(Token = "0x2007665")]
	public class Act20sideCartShowState : State
	{
		// Token: 0x0602AA0D RID: 174605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA0D")]
		[Address(RVA = "0x26578A0", Offset = "0x26564A0", VA = "0x1826578A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA0E RID: 174606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA0E")]
		[Address(RVA = "0x2656670", Offset = "0x2655270", VA = "0x182656670", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA0F RID: 174607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA0F")]
		[Address(RVA = "0x2657620", Offset = "0x2656220", VA = "0x182657620", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AA10 RID: 174608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA10")]
		[Address(RVA = "0x2657440", Offset = "0x2656040", VA = "0x182657440")]
		public void OnSelectCompState()
		{
		}

		// Token: 0x0602AA11 RID: 174609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA11")]
		[Address(RVA = "0x2656D90", Offset = "0x2655990", VA = "0x182656D90")]
		public void OnEntertainCompetitionState()
		{
		}

		// Token: 0x0602AA12 RID: 174610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA12")]
		[Address(RVA = "0x26574D0", Offset = "0x26560D0", VA = "0x1826574D0")]
		public void OnVoteState()
		{
		}

		// Token: 0x0602AA13 RID: 174611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA13")]
		[Address(RVA = "0x2656870", Offset = "0x2655470", VA = "0x182656870")]
		public void OnEnterMilestoneState()
		{
		}

		// Token: 0x0602AA14 RID: 174612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA14")]
		[Address(RVA = "0x26569D0", Offset = "0x26555D0", VA = "0x1826569D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA15 RID: 174613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA15")]
		[Address(RVA = "0x26573C0", Offset = "0x2655FC0", VA = "0x1826573C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AA16 RID: 174614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA16")]
		[Address(RVA = "0x2656E20", Offset = "0x2655A20", VA = "0x182656E20")]
		public void OnRender()
		{
		}

		// Token: 0x0602AA17 RID: 174615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA17")]
		[Address(RVA = "0x26566D0", Offset = "0x26552D0", VA = "0x1826566D0")]
		public void OnCarDetailClick()
		{
		}

		// Token: 0x0602AA18 RID: 174616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA18")]
		[Address(RVA = "0x2657A40", Offset = "0x2656640", VA = "0x182657A40")]
		public Act20sideCartShowState()
		{
		}

		// Token: 0x0602AA1A RID: 174618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA1A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602AA1B RID: 174619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA1B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602AA1C RID: 174620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA1C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403D654 RID: 251476
		[Token(Token = "0x403D654")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _carCont;

		// Token: 0x0403D655 RID: 251477
		[Token(Token = "0x403D655")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act20sideCarObject _carObj;

		// Token: 0x0403D656 RID: 251478
		[Token(Token = "0x403D656")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Act20sideCarCompObj> _carObjList;

		// Token: 0x0403D657 RID: 251479
		[Token(Token = "0x403D657")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _coloredImage;

		// Token: 0x0403D658 RID: 251480
		[Token(Token = "0x403D658")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _scaleFloat;

		// Token: 0x0403D659 RID: 251481
		[Token(Token = "0x403D659")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act20sideCarShowBtnHolder _btnHolder;

		// Token: 0x0403D65A RID: 251482
		[Token(Token = "0x403D65A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _trackPointDraw;

		// Token: 0x0403D65B RID: 251483
		[Token(Token = "0x403D65B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICommonTrackPoint _trackPointVote;

		// Token: 0x0403D65C RID: 251484
		[Token(Token = "0x403D65C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonTrackPoint _trackPointFunGame;

		// Token: 0x0403D65D RID: 251485
		[Token(Token = "0x403D65D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403D65E RID: 251486
		[Token(Token = "0x403D65E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelRetro;

		// Token: 0x0403D65F RID: 251487
		[Token(Token = "0x403D65F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelHandBook;

		// Token: 0x0403D660 RID: 251488
		[Token(Token = "0x403D660")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_trackPointDraw;

		// Token: 0x0403D661 RID: 251489
		[Token(Token = "0x403D661")]
		[FieldOffset(Offset = "0xB8")]
		private TrackPointViewProperty m_trackPointFunGame;

		// Token: 0x0403D662 RID: 251490
		[Token(Token = "0x403D662")]
		[FieldOffset(Offset = "0xC0")]
		private TrackPointViewProperty m_trackPointVote;

		// Token: 0x0403D663 RID: 251491
		[Token(Token = "0x403D663")]
		[FieldOffset(Offset = "0xC8")]
		private Act20sideCarObject m_carObj;

		// Token: 0x0403D664 RID: 251492
		[Token(Token = "0x403D664")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isRetro;

		// Token: 0x0403D665 RID: 251493
		[Token(Token = "0x403D665")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_isInited;

		// Token: 0x0403D666 RID: 251494
		[Token(Token = "0x403D666")]
		[FieldOffset(Offset = "0xD8")]
		private Act20sideCartShowStateBean m_stateBean;

		// Token: 0x0403D667 RID: 251495
		[Token(Token = "0x403D667")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D668 RID: 251496
		[Token(Token = "0x403D668")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D669 RID: 251497
		[Token(Token = "0x403D669")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403D66A RID: 251498
		[Token(Token = "0x403D66A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelectCompState;

		// Token: 0x0403D66B RID: 251499
		[Token(Token = "0x403D66B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEntertainCompetitionState;

		// Token: 0x0403D66C RID: 251500
		[Token(Token = "0x403D66C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnVoteState;

		// Token: 0x0403D66D RID: 251501
		[Token(Token = "0x403D66D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnterMilestoneState;

		// Token: 0x0403D66E RID: 251502
		[Token(Token = "0x403D66E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D66F RID: 251503
		[Token(Token = "0x403D66F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403D670 RID: 251504
		[Token(Token = "0x403D670")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403D671 RID: 251505
		[Token(Token = "0x403D671")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCarDetailClick;

		// Token: 0x0403D672 RID: 251506
		[Token(Token = "0x403D672")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
