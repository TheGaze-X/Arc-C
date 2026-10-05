using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004445 RID: 17477
	[Token(Token = "0x2004445")]
	public class SandboxV2SquadView : DataBinder<SandboxV2SquadGroupProp>
	{
		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0601AB52 RID: 109394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB53 RID: 109395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F65")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x601AB52")]
			[Address(RVA = "0x13D3CE0", Offset = "0x13D28E0", VA = "0x1813D3CE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB53")]
			[Address(RVA = "0x13D3EE0", Offset = "0x13D2AE0", VA = "0x1813D3EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0601AB54 RID: 109396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB55 RID: 109397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F66")]
		public Action<int> onCharDineClick
		{
			[Token(Token = "0x601AB54")]
			[Address(RVA = "0x13D3C80", Offset = "0x13D2880", VA = "0x1813D3C80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB55")]
			[Address(RVA = "0x13D3E60", Offset = "0x13D2A60", VA = "0x1813D3E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0601AB56 RID: 109398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB57 RID: 109399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F67")]
		public Action<int> onSlotClick
		{
			[Token(Token = "0x601AB56")]
			[Address(RVA = "0x13D3D40", Offset = "0x13D2940", VA = "0x1813D3D40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB57")]
			[Address(RVA = "0x13D3F60", Offset = "0x13D2B60", VA = "0x1813D3F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0601AB58 RID: 109400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB59 RID: 109401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F68")]
		public Action<int> onToolClick
		{
			[Token(Token = "0x601AB58")]
			[Address(RVA = "0x13D3E00", Offset = "0x13D2A00", VA = "0x1813D3E00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB59")]
			[Address(RVA = "0x13D4060", Offset = "0x13D2C60", VA = "0x1813D4060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0601AB5A RID: 109402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB5B RID: 109403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F69")]
		public Action<int> onToolBtnBuildClick
		{
			[Token(Token = "0x601AB5A")]
			[Address(RVA = "0x13D3DA0", Offset = "0x13D29A0", VA = "0x1813D3DA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB5B")]
			[Address(RVA = "0x13D3FE0", Offset = "0x13D2BE0", VA = "0x1813D3FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AB5C RID: 109404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB5C")]
		[Address(RVA = "0x13D3200", Offset = "0x13D1E00", VA = "0x1813D3200", Slot = "7")]
		public override void OnValueChanged(SandboxV2SquadGroupProp property)
		{
		}

		// Token: 0x0601AB5D RID: 109405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB5D")]
		[Address(RVA = "0x13D3600", Offset = "0x13D2200", VA = "0x1813D3600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AB5E RID: 109406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB5E")]
		[Address(RVA = "0x13D3A30", Offset = "0x13D2630", VA = "0x1813D3A30")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x0601AB5F RID: 109407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB5F")]
		[Address(RVA = "0x13D3B10", Offset = "0x13D2710", VA = "0x1813D3B10")]
		private void _ScrollToVal(int seqNum, float scrollTweenVal)
		{
		}

		// Token: 0x0601AB60 RID: 109408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB60")]
		[Address(RVA = "0x13D3C00", Offset = "0x13D2800", VA = "0x1813D3C00")]
		public SandboxV2SquadView()
		{
		}

		// Token: 0x040221B1 RID: 139697
		[Token(Token = "0x40221B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x040221B2 RID: 139698
		[Token(Token = "0x40221B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _toolList;

		// Token: 0x040221B3 RID: 139699
		[Token(Token = "0x40221B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _naviPanelGo;

		// Token: 0x040221B4 RID: 139700
		[Token(Token = "0x40221B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnNaviToolGo;

		// Token: 0x040221B5 RID: 139701
		[Token(Token = "0x40221B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040221B6 RID: 139702
		[Token(Token = "0x40221B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _fadeDuraton;

		// Token: 0x040221B7 RID: 139703
		[Token(Token = "0x40221B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect _squadScrollRect;

		// Token: 0x040221B8 RID: 139704
		[Token(Token = "0x40221B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _scrollDuration;

		// Token: 0x040221B9 RID: 139705
		[Token(Token = "0x40221B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _charUsedAlertGo;

		// Token: 0x040221BA RID: 139706
		[Token(Token = "0x40221BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _toolLackAlertGo;

		// Token: 0x040221BB RID: 139707
		[Token(Token = "0x40221BB")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x040221BC RID: 139708
		[Token(Token = "0x40221BC")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x040221BD RID: 139709
		[Token(Token = "0x40221BD")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2SquadView.CharListAdapter m_charListAdapter;

		// Token: 0x040221BE RID: 139710
		[Token(Token = "0x40221BE")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2SquadView.ToolListAdapter m_toolListAdapter;

		// Token: 0x040221BF RID: 139711
		[Token(Token = "0x40221BF")]
		[FieldOffset(Offset = "0x90")]
		private int m_cacheScrollSeq;

		// Token: 0x040221C0 RID: 139712
		[Token(Token = "0x40221C0")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_scrollTween;

		// Token: 0x040221C6 RID: 139718
		[Token(Token = "0x40221C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x040221C7 RID: 139719
		[Token(Token = "0x40221C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x040221C8 RID: 139720
		[Token(Token = "0x40221C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCharDineClick;

		// Token: 0x040221C9 RID: 139721
		[Token(Token = "0x40221C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCharDineClick;

		// Token: 0x040221CA RID: 139722
		[Token(Token = "0x40221CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onSlotClick;

		// Token: 0x040221CB RID: 139723
		[Token(Token = "0x40221CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onSlotClick;

		// Token: 0x040221CC RID: 139724
		[Token(Token = "0x40221CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onToolClick;

		// Token: 0x040221CD RID: 139725
		[Token(Token = "0x40221CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onToolClick;

		// Token: 0x040221CE RID: 139726
		[Token(Token = "0x40221CE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onToolBtnBuildClick;

		// Token: 0x040221CF RID: 139727
		[Token(Token = "0x40221CF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onToolBtnBuildClick;

		// Token: 0x040221D0 RID: 139728
		[Token(Token = "0x40221D0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040221D1 RID: 139729
		[Token(Token = "0x40221D1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040221D2 RID: 139730
		[Token(Token = "0x40221D2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x040221D3 RID: 139731
		[Token(Token = "0x40221D3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ScrollToVal;

		// Token: 0x040221D4 RID: 139732
		[Token(Token = "0x40221D4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004446 RID: 17478
		[Token(Token = "0x2004446")]
		private class ToolListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AB61 RID: 109409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AB61")]
			[Address(RVA = "0x13EB7B0", Offset = "0x13EA3B0", VA = "0x1813EB7B0")]
			public ToolListAdapter(Action<int> onToolClick, Action<int> onBtnBuildClick)
			{
			}

			// Token: 0x17003F6A RID: 16234
			// (get) Token: 0x0601AB62 RID: 109410 RVA: 0x000A3098 File Offset: 0x000A1298
			[Token(Token = "0x17003F6A")]
			public override int count
			{
				[Token(Token = "0x601AB62")]
				[Address(RVA = "0x13EB850", Offset = "0x13EA450", VA = "0x1813EB850", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AB63 RID: 109411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AB63")]
			[Address(RVA = "0x13EB520", Offset = "0x13EA120", VA = "0x1813EB520", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AB64 RID: 109412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AB64")]
			[Address(RVA = "0x13EB720", Offset = "0x13EA320", VA = "0x1813EB720")]
			public void UpdateData(SandboxV2SquadGroupModel squadGroupModel)
			{
			}

			// Token: 0x040221D5 RID: 139733
			[Token(Token = "0x40221D5")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2SquadModel m_squadModel;

			// Token: 0x040221D6 RID: 139734
			[Token(Token = "0x40221D6")]
			[FieldOffset(Offset = "0x28")]
			private Action<int> m_onToolClick;

			// Token: 0x040221D7 RID: 139735
			[Token(Token = "0x40221D7")]
			[FieldOffset(Offset = "0x30")]
			private Action<int> m_onBtnBuildClick;

			// Token: 0x040221D8 RID: 139736
			[Token(Token = "0x40221D8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040221D9 RID: 139737
			[Token(Token = "0x40221D9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040221DA RID: 139738
			[Token(Token = "0x40221DA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040221DB RID: 139739
			[Token(Token = "0x40221DB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateData;
		}

		// Token: 0x02004447 RID: 17479
		[Token(Token = "0x2004447")]
		private class CharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AB65 RID: 109413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AB65")]
			[Address(RVA = "0x13D51F0", Offset = "0x13D3DF0", VA = "0x1813D51F0")]
			public CharListAdapter(Action<int, string> onSkillSelect, Action<int> onCharDineClick, Action<int> onSlotClick)
			{
			}

			// Token: 0x17003F6B RID: 16235
			// (get) Token: 0x0601AB66 RID: 109414 RVA: 0x000A30B0 File Offset: 0x000A12B0
			[Token(Token = "0x17003F6B")]
			public override int count
			{
				[Token(Token = "0x601AB66")]
				[Address(RVA = "0x13D52B0", Offset = "0x13D3EB0", VA = "0x1813D52B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AB67 RID: 109415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AB67")]
			[Address(RVA = "0x13D4EF0", Offset = "0x13D3AF0", VA = "0x1813D4EF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601AB68 RID: 109416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AB68")]
			[Address(RVA = "0x13D5130", Offset = "0x13D3D30", VA = "0x1813D5130")]
			public void UpdateData(SandboxV2SquadGroupModel squadGroupModel)
			{
			}

			// Token: 0x040221DC RID: 139740
			[Token(Token = "0x40221DC")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2SquadGroupModel m_squadGroupModel;

			// Token: 0x040221DD RID: 139741
			[Token(Token = "0x40221DD")]
			[FieldOffset(Offset = "0x28")]
			private SandboxV2SquadModel m_squadModel;

			// Token: 0x040221DE RID: 139742
			[Token(Token = "0x40221DE")]
			[FieldOffset(Offset = "0x30")]
			private SandboxV2SquadModel.SquadScale m_squadScale;

			// Token: 0x040221DF RID: 139743
			[Token(Token = "0x40221DF")]
			[FieldOffset(Offset = "0x38")]
			private Action<int, string> m_onSkillSelect;

			// Token: 0x040221E0 RID: 139744
			[Token(Token = "0x40221E0")]
			[FieldOffset(Offset = "0x40")]
			private Action<int> m_onCharDineClick;

			// Token: 0x040221E1 RID: 139745
			[Token(Token = "0x40221E1")]
			[FieldOffset(Offset = "0x48")]
			private Action<int> m_onSlotClick;

			// Token: 0x040221E2 RID: 139746
			[Token(Token = "0x40221E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040221E3 RID: 139747
			[Token(Token = "0x40221E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040221E4 RID: 139748
			[Token(Token = "0x40221E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040221E5 RID: 139749
			[Token(Token = "0x40221E5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateData;
		}
	}
}
