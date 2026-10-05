using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049AE RID: 18862
	[Token(Token = "0x20049AE")]
	public class MedalListStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x0601C6B9 RID: 116409 RVA: 0x000A8600 File Offset: 0x000A6800
		// (set) Token: 0x0601C6BA RID: 116410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004356")]
		public int lastSelectCount
		{
			[Token(Token = "0x601C6B9")]
			[Address(RVA = "0x15ECC40", Offset = "0x15EB840", VA = "0x1815ECC40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601C6BA")]
			[Address(RVA = "0x15ECD70", Offset = "0x15EB970", VA = "0x1815ECD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0601C6BB RID: 116411 RVA: 0x000A8618 File Offset: 0x000A6818
		// (set) Token: 0x0601C6BC RID: 116412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004357")]
		public bool isSelectionConfirmed
		{
			[Token(Token = "0x601C6BB")]
			[Address(RVA = "0x15ECBE0", Offset = "0x15EB7E0", VA = "0x1815ECBE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601C6BC")]
			[Address(RVA = "0x15ECD00", Offset = "0x15EB900", VA = "0x1815ECD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x0601C6BD RID: 116413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004358")]
		[Obsolete]
		public List<MedalTypeViewModel> typeViewModelInUsed
		{
			[Token(Token = "0x601C6BD")]
			[Address(RVA = "0x15ECCA0", Offset = "0x15EB8A0", VA = "0x1815ECCA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C6BE RID: 116414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6BE")]
		[Address(RVA = "0x15EBC90", Offset = "0x15EA890", VA = "0x1815EBC90")]
		public void RefreshData()
		{
		}

		// Token: 0x0601C6BF RID: 116415 RVA: 0x000A8630 File Offset: 0x000A6830
		[Token(Token = "0x601C6BF")]
		[Address(RVA = "0x15EB820", Offset = "0x15EA420", VA = "0x1815EB820")]
		public int GetTotalMedal()
		{
			return 0;
		}

		// Token: 0x0601C6C0 RID: 116416 RVA: 0x000A8648 File Offset: 0x000A6848
		[Token(Token = "0x601C6C0")]
		[Address(RVA = "0x15EB7B0", Offset = "0x15EA3B0", VA = "0x1815EB7B0")]
		public int GetAvailMedal()
		{
			return 0;
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C1")]
		[Address(RVA = "0x15EB890", Offset = "0x15EA490", VA = "0x1815EB890")]
		public void InitData(bool abortNotGetMedals = false)
		{
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C2")]
		[Address(RVA = "0x15EC0F0", Offset = "0x15EACF0", VA = "0x1815EC0F0")]
		public void ToggleSelection(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C3")]
		[Address(RVA = "0x15EBD00", Offset = "0x15EA900", VA = "0x1815EBD00")]
		public void SetSelectMedalInput(ICollection<string> selectedIds, int maxSelectCount)
		{
		}

		// Token: 0x0601C6C4 RID: 116420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C4")]
		[Address(RVA = "0x15EB560", Offset = "0x15EA160", VA = "0x1815EB560")]
		public void ClearAllSelection()
		{
		}

		// Token: 0x0601C6C5 RID: 116421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C5")]
		[Address(RVA = "0x15EB710", Offset = "0x15EA310", VA = "0x1815EB710")]
		public void ConfirmSelection()
		{
		}

		// Token: 0x0601C6C6 RID: 116422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C6")]
		[Address(RVA = "0x15EB990", Offset = "0x15EA590", VA = "0x1815EB990")]
		public void LoadSelectedMedals(ICollection<string> selectResult)
		{
		}

		// Token: 0x0601C6C7 RID: 116423 RVA: 0x000A8660 File Offset: 0x000A6860
		[Token(Token = "0x601C6C7")]
		[Address(RVA = "0x15EC380", Offset = "0x15EAF80", VA = "0x1815EC380")]
		private int _CountSelectedMedalsInUsedAndRestrict()
		{
			return 0;
		}

		// Token: 0x0601C6C8 RID: 116424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C8")]
		[Address(RVA = "0x15EC2E0", Offset = "0x15EAEE0", VA = "0x1815EC2E0")]
		private void _CountAndRestrictSelectionHandler(MedalCommonViewModel medalModel)
		{
		}

		// Token: 0x0601C6C9 RID: 116425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6C9")]
		[Address(RVA = "0x15EC7F0", Offset = "0x15EB3F0", VA = "0x1815EC7F0")]
		private void _SetSelectionHandler(MedalCommonViewModel medalModel)
		{
		}

		// Token: 0x0601C6CA RID: 116426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6CA")]
		[Address(RVA = "0x15EC6D0", Offset = "0x15EB2D0", VA = "0x1815EC6D0")]
		private void _LoadSelectionHanlder(MedalCommonViewModel medalModel)
		{
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6CB")]
		[Address(RVA = "0x15EC440", Offset = "0x15EB040", VA = "0x1815EC440")]
		private void _ForeachMedalInUsed(Action<MedalCommonViewModel> handler)
		{
		}

		// Token: 0x0601C6CC RID: 116428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6CC")]
		[Address(RVA = "0x15EC970", Offset = "0x15EB570", VA = "0x1815EC970")]
		public MedalListStateBean()
		{
		}

		// Token: 0x040253AA RID: 152490
		[Token(Token = "0x40253AA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public MedalListViewModel listViewModel;

		// Token: 0x040253AB RID: 152491
		[Token(Token = "0x40253AB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int maxSelectCount;

		// Token: 0x040253AE RID: 152494
		[Token(Token = "0x40253AE")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<string> m_sharedSet;

		// Token: 0x040253AF RID: 152495
		[Token(Token = "0x40253AF")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedSelectCount;

		// Token: 0x040253B0 RID: 152496
		[Token(Token = "0x40253B0")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x040253B1 RID: 152497
		[Token(Token = "0x40253B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lastSelectCount;

		// Token: 0x040253B2 RID: 152498
		[Token(Token = "0x40253B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_lastSelectCount;

		// Token: 0x040253B3 RID: 152499
		[Token(Token = "0x40253B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSelectionConfirmed;

		// Token: 0x040253B4 RID: 152500
		[Token(Token = "0x40253B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isSelectionConfirmed;

		// Token: 0x040253B5 RID: 152501
		[Token(Token = "0x40253B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_typeViewModelInUsed;

		// Token: 0x040253B6 RID: 152502
		[Token(Token = "0x40253B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040253B7 RID: 152503
		[Token(Token = "0x40253B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTotalMedal;

		// Token: 0x040253B8 RID: 152504
		[Token(Token = "0x40253B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetAvailMedal;

		// Token: 0x040253B9 RID: 152505
		[Token(Token = "0x40253B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040253BA RID: 152506
		[Token(Token = "0x40253BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ToggleSelection;

		// Token: 0x040253BB RID: 152507
		[Token(Token = "0x40253BB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetSelectMedalInput;

		// Token: 0x040253BC RID: 152508
		[Token(Token = "0x40253BC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ClearAllSelection;

		// Token: 0x040253BD RID: 152509
		[Token(Token = "0x40253BD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ConfirmSelection;

		// Token: 0x040253BE RID: 152510
		[Token(Token = "0x40253BE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadSelectedMedals;

		// Token: 0x040253BF RID: 152511
		[Token(Token = "0x40253BF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CountSelectedMedalsInUsedAndRestrict;

		// Token: 0x040253C0 RID: 152512
		[Token(Token = "0x40253C0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CountAndRestrictSelectionHandler;

		// Token: 0x040253C1 RID: 152513
		[Token(Token = "0x40253C1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetSelectionHandler;

		// Token: 0x040253C2 RID: 152514
		[Token(Token = "0x40253C2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadSelectionHanlder;

		// Token: 0x040253C3 RID: 152515
		[Token(Token = "0x40253C3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ForeachMedalInUsed;

		// Token: 0x040253C4 RID: 152516
		[Token(Token = "0x40253C4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
