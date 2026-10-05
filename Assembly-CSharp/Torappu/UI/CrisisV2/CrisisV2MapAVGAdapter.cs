using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A5 RID: 22949
	[Token(Token = "0x20059A5")]
	public class CrisisV2MapAVGAdapter : ExecutorComponent, IHotfixable
	{
		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x0602173E RID: 137022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602173F RID: 137023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EAB")]
		public Func<CrisisV2MapAVGAdapter.FocusSlotType, int> onSlotFocus
		{
			[Token(Token = "0x602173E")]
			[Address(RVA = "0x1BC2640", Offset = "0x1BC1240", VA = "0x181BC2640")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602173F")]
			[Address(RVA = "0x1BC27A0", Offset = "0x1BC13A0", VA = "0x181BC27A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x06021740 RID: 137024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021741 RID: 137025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EAC")]
		public Func<CrisisV2MapAVGAdapter.MapType, int> onMapSwitch
		{
			[Token(Token = "0x6021740")]
			[Address(RVA = "0x1BC25E0", Offset = "0x1BC11E0", VA = "0x181BC25E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021741")]
			[Address(RVA = "0x1BC2720", Offset = "0x1BC1320", VA = "0x181BC2720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x06021742 RID: 137026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021743 RID: 137027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EAD")]
		public Func<int> onHidePreview
		{
			[Token(Token = "0x6021742")]
			[Address(RVA = "0x1BC2580", Offset = "0x1BC1180", VA = "0x181BC2580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021743")]
			[Address(RVA = "0x1BC26A0", Offset = "0x1BC12A0", VA = "0x181BC26A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021744 RID: 137028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021744")]
		[Address(RVA = "0x1BC1AF0", Offset = "0x1BC06F0", VA = "0x181BC1AF0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06021745 RID: 137029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021745")]
		[Address(RVA = "0x1BC1A90", Offset = "0x1BC0690", VA = "0x181BC1A90", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06021746 RID: 137030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021746")]
		[Address(RVA = "0x1BC1F70", Offset = "0x1BC0B70", VA = "0x181BC1F70")]
		public void OnMapFocusComplete(int seqNum)
		{
		}

		// Token: 0x06021747 RID: 137031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021747")]
		[Address(RVA = "0x1BC2040", Offset = "0x1BC0C40", VA = "0x181BC2040")]
		public void OnMapSwitchComplete(int seqNum)
		{
		}

		// Token: 0x06021748 RID: 137032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021748")]
		[Address(RVA = "0x1BC1EA0", Offset = "0x1BC0AA0", VA = "0x181BC1EA0")]
		public void OnHidePreviewComplete(int seqNum)
		{
		}

		// Token: 0x06021749 RID: 137033 RVA: 0x000BA570 File Offset: 0x000B8770
		[Token(Token = "0x6021749")]
		[Address(RVA = "0x1BC2110", Offset = "0x1BC0D10", VA = "0x181BC2110")]
		private bool _OnFocusToSlot(Command command)
		{
			return default(bool);
		}

		// Token: 0x0602174A RID: 137034 RVA: 0x000BA588 File Offset: 0x000B8788
		[Token(Token = "0x602174A")]
		[Address(RVA = "0x1BC2380", Offset = "0x1BC0F80", VA = "0x181BC2380")]
		private bool _OnMapSwitch(Command command)
		{
			return default(bool);
		}

		// Token: 0x0602174B RID: 137035 RVA: 0x000BA5A0 File Offset: 0x000B87A0
		[Token(Token = "0x602174B")]
		[Address(RVA = "0x1BC2250", Offset = "0x1BC0E50", VA = "0x181BC2250")]
		private bool _OnHidePreview(Command command)
		{
			return default(bool);
		}

		// Token: 0x0602174C RID: 137036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602174C")]
		[Address(RVA = "0x1BC1DF0", Offset = "0x1BC09F0", VA = "0x181BC1DF0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602174D RID: 137037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602174D")]
		[Address(RVA = "0x1BC1D40", Offset = "0x1BC0940", VA = "0x181BC1D40")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602174E RID: 137038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602174E")]
		[Address(RVA = "0x1BC2510", Offset = "0x1BC1110", VA = "0x181BC2510")]
		public CrisisV2MapAVGAdapter()
		{
		}

		// Token: 0x0402DA71 RID: 186993
		[Token(Token = "0x402DA71")]
		private const string PARAM_SLOT_TYPE = "slotType";

		// Token: 0x0402DA72 RID: 186994
		[Token(Token = "0x402DA72")]
		private const string PARAM_MAP_TYPE = "mapType";

		// Token: 0x0402DA76 RID: 186998
		[Token(Token = "0x402DA76")]
		[FieldOffset(Offset = "0x68")]
		private int m_lastFocusSequenceId;

		// Token: 0x0402DA77 RID: 186999
		[Token(Token = "0x402DA77")]
		[FieldOffset(Offset = "0x6C")]
		private int m_lastSwitchSequenceId;

		// Token: 0x0402DA78 RID: 187000
		[Token(Token = "0x402DA78")]
		[FieldOffset(Offset = "0x70")]
		private int m_lastHidePreviewSequenceId;

		// Token: 0x0402DA79 RID: 187001
		[Token(Token = "0x402DA79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotFocus;

		// Token: 0x0402DA7A RID: 187002
		[Token(Token = "0x402DA7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotFocus;

		// Token: 0x0402DA7B RID: 187003
		[Token(Token = "0x402DA7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onMapSwitch;

		// Token: 0x0402DA7C RID: 187004
		[Token(Token = "0x402DA7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onMapSwitch;

		// Token: 0x0402DA7D RID: 187005
		[Token(Token = "0x402DA7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onHidePreview;

		// Token: 0x0402DA7E RID: 187006
		[Token(Token = "0x402DA7E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onHidePreview;

		// Token: 0x0402DA7F RID: 187007
		[Token(Token = "0x402DA7F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0402DA80 RID: 187008
		[Token(Token = "0x402DA80")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0402DA81 RID: 187009
		[Token(Token = "0x402DA81")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMapFocusComplete;

		// Token: 0x0402DA82 RID: 187010
		[Token(Token = "0x402DA82")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMapSwitchComplete;

		// Token: 0x0402DA83 RID: 187011
		[Token(Token = "0x402DA83")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnHidePreviewComplete;

		// Token: 0x0402DA84 RID: 187012
		[Token(Token = "0x402DA84")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnFocusToSlot;

		// Token: 0x0402DA85 RID: 187013
		[Token(Token = "0x402DA85")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnMapSwitch;

		// Token: 0x0402DA86 RID: 187014
		[Token(Token = "0x402DA86")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnHidePreview;

		// Token: 0x0402DA87 RID: 187015
		[Token(Token = "0x402DA87")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402DA88 RID: 187016
		[Token(Token = "0x402DA88")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DA89 RID: 187017
		[Token(Token = "0x402DA89")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059A6 RID: 22950
		[Token(Token = "0x20059A6")]
		public enum MapType
		{
			// Token: 0x0402DA8B RID: 187019
			[Token(Token = "0x402DA8B")]
			NONE,
			// Token: 0x0402DA8C RID: 187020
			[Token(Token = "0x402DA8C")]
			BAG_VIEW,
			// Token: 0x0402DA8D RID: 187021
			[Token(Token = "0x402DA8D")]
			NODE_VIEW
		}

		// Token: 0x020059A7 RID: 22951
		[Token(Token = "0x20059A7")]
		public enum FocusSlotType
		{
			// Token: 0x0402DA8F RID: 187023
			[Token(Token = "0x402DA8F")]
			NONE,
			// Token: 0x0402DA90 RID: 187024
			[Token(Token = "0x402DA90")]
			BAG_VIEW_BAG,
			// Token: 0x0402DA91 RID: 187025
			[Token(Token = "0x402DA91")]
			SLOT_VIEW_BAG,
			// Token: 0x0402DA92 RID: 187026
			[Token(Token = "0x402DA92")]
			RUNE,
			// Token: 0x0402DA93 RID: 187027
			[Token(Token = "0x402DA93")]
			TREASURE,
			// Token: 0x0402DA94 RID: 187028
			[Token(Token = "0x402DA94")]
			KEYPOINT
		}
	}
}
