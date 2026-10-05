using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA3 RID: 24483
	[Token(Token = "0x2005FA3")]
	public class CharacterInfoProfUniEquipView : CharacterInfoRightProfObj
	{
		// Token: 0x060236BC RID: 145084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236BC")]
		[Address(RVA = "0x1E036B0", Offset = "0x1E022B0", VA = "0x181E036B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060236BD RID: 145085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236BD")]
		[Address(RVA = "0x1E03400", Offset = "0x1E02000", VA = "0x181E03400")]
		public void OnSelectEquip()
		{
		}

		// Token: 0x060236BE RID: 145086 RVA: 0x000C0D38 File Offset: 0x000BEF38
		[Token(Token = "0x60236BE")]
		[Address(RVA = "0x1E03230", Offset = "0x1E01E30", VA = "0x181E03230", Slot = "5")]
		public override bool CheckAvailInfo(CharacterInfoHolderBean.CharViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x060236BF RID: 145087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236BF")]
		[Address(RVA = "0x1E03AC0", Offset = "0x1E026C0", VA = "0x181E03AC0")]
		private void _OnSelectEquipId(string equipId)
		{
		}

		// Token: 0x060236C0 RID: 145088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236C0")]
		[Address(RVA = "0x1E03840", Offset = "0x1E02440", VA = "0x181E03840")]
		private void _OnRefreshEquipInfo(string equipId)
		{
		}

		// Token: 0x060236C1 RID: 145089 RVA: 0x000C0D50 File Offset: 0x000BEF50
		[Token(Token = "0x60236C1")]
		[Address(RVA = "0x1E03370", Offset = "0x1E01F70", VA = "0x181E03370", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236C2 RID: 145090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236C2")]
		[Address(RVA = "0x1E03480", Offset = "0x1E02080", VA = "0x181E03480", Slot = "6")]
		public override void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236C3 RID: 145091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236C3")]
		[Address(RVA = "0x1E032F0", Offset = "0x1E01EF0", VA = "0x181E032F0")]
		public void CheckIsNeedRefreshScroll(int inputSequenceNum)
		{
		}

		// Token: 0x060236C4 RID: 145092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236C4")]
		[Address(RVA = "0x1E03B50", Offset = "0x1E02750", VA = "0x181E03B50")]
		public CharacterInfoProfUniEquipView()
		{
		}

		// Token: 0x060236C5 RID: 145093 RVA: 0x000C0D68 File Offset: 0x000BEF68
		[Token(Token = "0x60236C5")]
		[Address(RVA = "0x1E030C0", Offset = "0x1E01CC0", VA = "0x181E030C0")]
		private bool <>xLuaBaseProxy_CheckAvailInfo(CharacterInfoHolderBean.CharViewModel P0)
		{
			return default(bool);
		}

		// Token: 0x060236C6 RID: 145094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236C6")]
		[Address(RVA = "0x1E03130", Offset = "0x1E01D30", VA = "0x181E03130")]
		private void <>xLuaBaseProxy_Render(CharacterInfoHolderBean.CharViewModel P0)
		{
		}

		// Token: 0x04030F0D RID: 200461
		[Token(Token = "0x4030F0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _uniequipContent;

		// Token: 0x04030F0E RID: 200462
		[Token(Token = "0x4030F0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _onCurrentPart;

		// Token: 0x04030F0F RID: 200463
		[Token(Token = "0x4030F0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _onSelectPart;

		// Token: 0x04030F10 RID: 200464
		[Token(Token = "0x4030F10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _onChangeEquip;

		// Token: 0x04030F11 RID: 200465
		[Token(Token = "0x4030F11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _onSelectEquipEvent;

		// Token: 0x04030F12 RID: 200466
		[Token(Token = "0x4030F12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _selectedName;

		// Token: 0x04030F13 RID: 200467
		[Token(Token = "0x4030F13")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _equipLevel;

		// Token: 0x04030F14 RID: 200468
		[Token(Token = "0x4030F14")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _equipLimitContentWidth;

		// Token: 0x04030F15 RID: 200469
		[Token(Token = "0x4030F15")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _equipMaxContentWidth;

		// Token: 0x04030F16 RID: 200470
		[Token(Token = "0x4030F16")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIWrappedScrollRect _equipScrollRect;

		// Token: 0x04030F17 RID: 200471
		[Token(Token = "0x4030F17")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _equipScrollContentRectTransform;

		// Token: 0x04030F18 RID: 200472
		[Token(Token = "0x4030F18")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _rightScrollRect;

		// Token: 0x04030F19 RID: 200473
		[Token(Token = "0x4030F19")]
		[FieldOffset(Offset = "0x78")]
		private CharacterInfoProfUniEquipView.Adapter m_adapter;

		// Token: 0x04030F1A RID: 200474
		[Token(Token = "0x4030F1A")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04030F1B RID: 200475
		[Token(Token = "0x4030F1B")]
		[FieldOffset(Offset = "0x84")]
		private int m_sequenceNum;

		// Token: 0x04030F1C RID: 200476
		[Token(Token = "0x4030F1C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_needRefreshScroll;

		// Token: 0x04030F1D RID: 200477
		[Token(Token = "0x4030F1D")]
		[FieldOffset(Offset = "0x90")]
		private CharacterInfoHolderBean.CharViewModel m_viewModel;

		// Token: 0x04030F1E RID: 200478
		[Token(Token = "0x4030F1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030F1F RID: 200479
		[Token(Token = "0x4030F1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectEquip;

		// Token: 0x04030F20 RID: 200480
		[Token(Token = "0x4030F20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAvailInfo;

		// Token: 0x04030F21 RID: 200481
		[Token(Token = "0x4030F21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSelectEquipId;

		// Token: 0x04030F22 RID: 200482
		[Token(Token = "0x4030F22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnRefreshEquipInfo;

		// Token: 0x04030F23 RID: 200483
		[Token(Token = "0x4030F23")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F24 RID: 200484
		[Token(Token = "0x4030F24")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F25 RID: 200485
		[Token(Token = "0x4030F25")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIsNeedRefreshScroll;

		// Token: 0x04030F26 RID: 200486
		[Token(Token = "0x4030F26")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FA4 RID: 24484
		[Token(Token = "0x2005FA4")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170053A0 RID: 21408
			// (get) Token: 0x060236C7 RID: 145095 RVA: 0x000C0D80 File Offset: 0x000BEF80
			[Token(Token = "0x170053A0")]
			public override int count
			{
				[Token(Token = "0x60236C7")]
				[Address(RVA = "0x1DFDFA0", Offset = "0x1DFCBA0", VA = "0x181DFDFA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060236C8 RID: 145096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60236C8")]
			[Address(RVA = "0x1DFD2D0", Offset = "0x1DFBED0", VA = "0x181DFD2D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060236C9 RID: 145097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60236C9")]
			[Address(RVA = "0x1DFDCD0", Offset = "0x1DFC8D0", VA = "0x181DFDCD0")]
			public Adapter()
			{
			}

			// Token: 0x04030F27 RID: 200487
			[Token(Token = "0x4030F27")]
			private const int EQUIP_MIN_SHOW_CNT = 3;

			// Token: 0x04030F28 RID: 200488
			[Token(Token = "0x4030F28")]
			[FieldOffset(Offset = "0x20")]
			public List<CharacterUniEquipViewModel> uniEquipViewModel;

			// Token: 0x04030F29 RID: 200489
			[Token(Token = "0x4030F29")]
			[FieldOffset(Offset = "0x28")]
			public string selectEquipId;

			// Token: 0x04030F2A RID: 200490
			[Token(Token = "0x4030F2A")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> selectEquipEvent;

			// Token: 0x04030F2B RID: 200491
			[Token(Token = "0x4030F2B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030F2C RID: 200492
			[Token(Token = "0x4030F2C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030F2D RID: 200493
			[Token(Token = "0x4030F2D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
