using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005460 RID: 21600
	[Token(Token = "0x2005460")]
	public class RoguelikeSacrificeView : DataBinder<RoguelikeSacrificeProperty>
	{
		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0601FCB0 RID: 130224 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCB1 RID: 130225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A7F")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x601FCB0")]
			[Address(RVA = "0x19FC240", Offset = "0x19FAE40", VA = "0x1819FC240")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FCB1")]
			[Address(RVA = "0x19FC400", Offset = "0x19FB000", VA = "0x1819FC400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0601FCB2 RID: 130226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCB3 RID: 130227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A80")]
		public Action onConfirmClick
		{
			[Token(Token = "0x601FCB2")]
			[Address(RVA = "0x19FC1E0", Offset = "0x19FADE0", VA = "0x1819FC1E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FCB3")]
			[Address(RVA = "0x19FC380", Offset = "0x19FAF80", VA = "0x1819FC380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x0601FCB4 RID: 130228 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCB5 RID: 130229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A81")]
		public Action onBackClick
		{
			[Token(Token = "0x601FCB4")]
			[Address(RVA = "0x19FC180", Offset = "0x19FAD80", VA = "0x1819FC180")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FCB5")]
			[Address(RVA = "0x19FC300", Offset = "0x19FAF00", VA = "0x1819FC300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x0601FCB6 RID: 130230 RVA: 0x000B3358 File Offset: 0x000B1558
		[Token(Token = "0x17004A82")]
		public bool hasCustomBkg
		{
			[Token(Token = "0x601FCB6")]
			[Address(RVA = "0x19FC120", Offset = "0x19FAD20", VA = "0x1819FC120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x0601FCB7 RID: 130231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A83")]
		public RoguelikeSacrificePlugin plugin
		{
			[Token(Token = "0x601FCB7")]
			[Address(RVA = "0x19FC2A0", Offset = "0x19FAEA0", VA = "0x1819FC2A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FCB8 RID: 130232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCB8")]
		[Address(RVA = "0x19FBFC0", Offset = "0x19FABC0", VA = "0x1819FBFC0")]
		private void _UpdateSacrificeTypePanels(RoguelikeSacrificeType sacrificeType)
		{
		}

		// Token: 0x0601FCB9 RID: 130233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCB9")]
		[Address(RVA = "0x19FB7B0", Offset = "0x19FA3B0", VA = "0x1819FB7B0")]
		public void InitAfterEventsSet()
		{
		}

		// Token: 0x0601FCBA RID: 130234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCBA")]
		[Address(RVA = "0x19FBAD0", Offset = "0x19FA6D0", VA = "0x1819FBAD0", Slot = "7")]
		public override void OnValueChanged(RoguelikeSacrificeProperty property)
		{
		}

		// Token: 0x0601FCBB RID: 130235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCBB")]
		[Address(RVA = "0x19FBEF0", Offset = "0x19FAAF0", VA = "0x1819FBEF0")]
		public void ResetViews()
		{
		}

		// Token: 0x0601FCBC RID: 130236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCBC")]
		[Address(RVA = "0x19FB9C0", Offset = "0x19FA5C0", VA = "0x1819FB9C0")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0601FCBD RID: 130237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCBD")]
		[Address(RVA = "0x19FB8B0", Offset = "0x19FA4B0", VA = "0x1819FB8B0")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x0601FCBE RID: 130238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCBE")]
		[Address(RVA = "0x19FC0B0", Offset = "0x19FACB0", VA = "0x1819FC0B0")]
		public RoguelikeSacrificeView()
		{
		}

		// Token: 0x0402AD6A RID: 175466
		[Token(Token = "0x402AD6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _hasCustomBkg;

		// Token: 0x0402AD6B RID: 175467
		[Token(Token = "0x402AD6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402AD6C RID: 175468
		[Token(Token = "0x402AD6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeSacrificeViewScrollAdapter _scrollAdapter;

		// Token: 0x0402AD6D RID: 175469
		[Token(Token = "0x402AD6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeSacrificeSelectedView _selectedView;

		// Token: 0x0402AD6E RID: 175470
		[Token(Token = "0x402AD6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeSacrificePlugin _plugin;

		// Token: 0x0402AD6F RID: 175471
		[Token(Token = "0x402AD6F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<RoguelikeSacrificeView.SacrificeTypePanel> _sacrificeTypePanels;

		// Token: 0x0402AD70 RID: 175472
		[Token(Token = "0x402AD70")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeSacrificeConfirmView _confirmView;

		// Token: 0x0402AD71 RID: 175473
		[Token(Token = "0x402AD71")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedSelectedItem;

		// Token: 0x0402AD72 RID: 175474
		[Token(Token = "0x402AD72")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeSacrificeType m_cachedSacrificeType;

		// Token: 0x0402AD76 RID: 175478
		[Token(Token = "0x402AD76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402AD77 RID: 175479
		[Token(Token = "0x402AD77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402AD78 RID: 175480
		[Token(Token = "0x402AD78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onConfirmClick;

		// Token: 0x0402AD79 RID: 175481
		[Token(Token = "0x402AD79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirmClick;

		// Token: 0x0402AD7A RID: 175482
		[Token(Token = "0x402AD7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onBackClick;

		// Token: 0x0402AD7B RID: 175483
		[Token(Token = "0x402AD7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onBackClick;

		// Token: 0x0402AD7C RID: 175484
		[Token(Token = "0x402AD7C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasCustomBkg;

		// Token: 0x0402AD7D RID: 175485
		[Token(Token = "0x402AD7D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0402AD7E RID: 175486
		[Token(Token = "0x402AD7E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSacrificeTypePanels;

		// Token: 0x0402AD7F RID: 175487
		[Token(Token = "0x402AD7F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitAfterEventsSet;

		// Token: 0x0402AD80 RID: 175488
		[Token(Token = "0x402AD80")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402AD81 RID: 175489
		[Token(Token = "0x402AD81")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ResetViews;

		// Token: 0x0402AD82 RID: 175490
		[Token(Token = "0x402AD82")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x0402AD83 RID: 175491
		[Token(Token = "0x402AD83")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x0402AD84 RID: 175492
		[Token(Token = "0x402AD84")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005461 RID: 21601
		[Token(Token = "0x2005461")]
		[Serializable]
		public struct SacrificeTypePanel
		{
			// Token: 0x0402AD85 RID: 175493
			[Token(Token = "0x402AD85")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeSacrificeType sacrificeType;

			// Token: 0x0402AD86 RID: 175494
			[Token(Token = "0x402AD86")]
			[FieldOffset(Offset = "0x8")]
			public GameObject sacrificePanel;
		}
	}
}
