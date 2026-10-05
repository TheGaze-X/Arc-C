using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C17 RID: 23575
	[Token(Token = "0x2005C17")]
	public class CommonCharSelectPoolViewModel : TemplateCharSelectPoolViewModel
	{
		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x060222D6 RID: 139990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005022")]
		public override List<TemplateCharSelectCardViewModel> selectedCharList
		{
			[Token(Token = "0x60222D6")]
			[Address(RVA = "0x1CAE9D0", Offset = "0x1CAD5D0", VA = "0x181CAE9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x060222D7 RID: 139991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005023")]
		public override TemplateCharSelectCardViewModel lastSelectedChar
		{
			[Token(Token = "0x60222D7")]
			[Address(RVA = "0x1CAE910", Offset = "0x1CAD510", VA = "0x181CAE910", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x060222D8 RID: 139992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005024")]
		public override HashSet<string> validSubProfessionIds
		{
			[Token(Token = "0x60222D8")]
			[Address(RVA = "0x1CAEA90", Offset = "0x1CAD690", VA = "0x181CAEA90", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x060222D9 RID: 139993 RVA: 0x000BC898 File Offset: 0x000BAA98
		// (set) Token: 0x060222DA RID: 139994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005025")]
		public TemplateCharSelectMode selectMode
		{
			[Token(Token = "0x60222D9")]
			[Address(RVA = "0x1CAE970", Offset = "0x1CAD570", VA = "0x181CAE970")]
			[CompilerGenerated]
			get
			{
				return TemplateCharSelectMode.MULTI;
			}
			[Token(Token = "0x60222DA")]
			[Address(RVA = "0x1CAECD0", Offset = "0x1CAD8D0", VA = "0x181CAECD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x060222DB RID: 139995 RVA: 0x000BC8B0 File Offset: 0x000BAAB0
		[Token(Token = "0x17005026")]
		public bool isSingle
		{
			[Token(Token = "0x60222DB")]
			[Address(RVA = "0x1CAE860", Offset = "0x1CAD460", VA = "0x181CAE860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x060222DC RID: 139996 RVA: 0x000BC8C8 File Offset: 0x000BAAC8
		// (set) Token: 0x060222DD RID: 139997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005027")]
		public int focusIndex
		{
			[Token(Token = "0x60222DC")]
			[Address(RVA = "0x1CAE800", Offset = "0x1CAD400", VA = "0x181CAE800")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60222DD")]
			[Address(RVA = "0x1CAEC60", Offset = "0x1CAD860", VA = "0x181CAEC60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x060222DE RID: 139998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060222DF RID: 139999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005028")]
		public List<TemplateCharSelectCardViewModel> shuffleResult
		{
			[Token(Token = "0x60222DE")]
			[Address(RVA = "0x1CAEA30", Offset = "0x1CAD630", VA = "0x181CAEA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60222DF")]
			[Address(RVA = "0x1CAED40", Offset = "0x1CAD940", VA = "0x181CAED40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060222E0 RID: 140000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222E0")]
		[Address(RVA = "0x1CAD550", Offset = "0x1CAC150", VA = "0x181CAD550", Slot = "7")]
		public override void Reset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x060222E1 RID: 140001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222E1")]
		[Address(RVA = "0x1CADD80", Offset = "0x1CAC980", VA = "0x181CADD80", Slot = "8")]
		public override void Resume()
		{
		}

		// Token: 0x060222E2 RID: 140002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222E2")]
		[Address(RVA = "0x1CAE010", Offset = "0x1CACC10", VA = "0x181CAE010")]
		protected void _AddToCharCollection(TemplateCharSelectCardViewModel charModel, bool canSelect)
		{
		}

		// Token: 0x060222E3 RID: 140003 RVA: 0x000BC8E0 File Offset: 0x000BAAE0
		[Token(Token = "0x60222E3")]
		[Address(RVA = "0x1CADE30", Offset = "0x1CACA30", VA = "0x181CADE30", Slot = "9")]
		public override bool SelectChar(int instId)
		{
			return default(bool);
		}

		// Token: 0x060222E4 RID: 140004 RVA: 0x000BC8F8 File Offset: 0x000BAAF8
		[Token(Token = "0x60222E4")]
		[Address(RVA = "0x1CAE3C0", Offset = "0x1CACFC0", VA = "0x181CAE3C0")]
		private bool _DoSingleSelect(int instId)
		{
			return default(bool);
		}

		// Token: 0x060222E5 RID: 140005 RVA: 0x000BC910 File Offset: 0x000BAB10
		[Token(Token = "0x60222E5")]
		[Address(RVA = "0x1CAE1E0", Offset = "0x1CACDE0", VA = "0x181CAE1E0")]
		private bool _DoMultiSelect(int instId)
		{
			return default(bool);
		}

		// Token: 0x060222E6 RID: 140006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222E6")]
		[Address(RVA = "0x1CAD160", Offset = "0x1CABD60", VA = "0x181CAD160", Slot = "10")]
		public override void ClearAllSelect()
		{
		}

		// Token: 0x060222E7 RID: 140007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60222E7")]
		[Address(RVA = "0x1CAD3C0", Offset = "0x1CABFC0", VA = "0x181CAD3C0")]
		protected TemplateCharSelectCardViewModel GetCharViewModelByInstId(int instId)
		{
			return null;
		}

		// Token: 0x060222E8 RID: 140008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60222E8")]
		[Address(RVA = "0x1CAD2E0", Offset = "0x1CABEE0", VA = "0x181CAD2E0", Slot = "13")]
		public sealed override string GetCharIdByInstId(int instId)
		{
			return null;
		}

		// Token: 0x060222E9 RID: 140009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222E9")]
		[Address(RVA = "0x1CACDB0", Offset = "0x1CAB9B0", VA = "0x181CACDB0", Slot = "11")]
		public sealed override void ApplyShuffle(TemplateCharSelectShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x060222EA RID: 140010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60222EA")]
		[Address(RVA = "0x1CAD4C0", Offset = "0x1CAC0C0", VA = "0x181CAD4C0", Slot = "12")]
		public sealed override List<TemplateCharSelectCardViewModel> GetShuffleResult()
		{
			return null;
		}

		// Token: 0x060222EB RID: 140011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222EB")]
		[Address(RVA = "0x1CAE5F0", Offset = "0x1CAD1F0", VA = "0x181CAE5F0")]
		public CommonCharSelectPoolViewModel()
		{
		}

		// Token: 0x0402EDFA RID: 191994
		[Token(Token = "0x402EDFA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, TemplateCharSelectCardViewModel> charDict;

		// Token: 0x0402EDFB RID: 191995
		[Token(Token = "0x402EDFB")]
		[FieldOffset(Offset = "0x18")]
		public List<TemplateCharSelectCardViewModel> charList;

		// Token: 0x0402EDFC RID: 191996
		[Token(Token = "0x402EDFC")]
		[FieldOffset(Offset = "0x20")]
		public List<TemplateCharSelectCardViewModel> selectedList;

		// Token: 0x0402EDFD RID: 191997
		[Token(Token = "0x402EDFD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<int, TemplateCharSelectCardViewModel> selectedDict;

		// Token: 0x0402EDFE RID: 191998
		[Token(Token = "0x402EDFE")]
		[FieldOffset(Offset = "0x30")]
		public List<int> selectedInsts;

		// Token: 0x0402EDFF RID: 191999
		[Token(Token = "0x402EDFF")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_validSubProfs;

		// Token: 0x0402EE00 RID: 192000
		[Token(Token = "0x402EE00")]
		[FieldOffset(Offset = "0x40")]
		protected TemplateCharSelectCardViewModel m_lastSelectChar;

		// Token: 0x0402EE02 RID: 192002
		[Token(Token = "0x402EE02")]
		[FieldOffset(Offset = "0x4C")]
		public bool ensured;

		// Token: 0x0402EE03 RID: 192003
		[Token(Token = "0x402EE03")]
		[FieldOffset(Offset = "0x50")]
		public int focusSeqNum;

		// Token: 0x0402EE06 RID: 192006
		[Token(Token = "0x402EE06")]
		[FieldOffset(Offset = "0x60")]
		protected TemplateCharSelectController.InputParam m_cacheInput;

		// Token: 0x0402EE07 RID: 192007
		[Token(Token = "0x402EE07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedCharList;

		// Token: 0x0402EE08 RID: 192008
		[Token(Token = "0x402EE08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lastSelectedChar;

		// Token: 0x0402EE09 RID: 192009
		[Token(Token = "0x402EE09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_validSubProfessionIds;

		// Token: 0x0402EE0A RID: 192010
		[Token(Token = "0x402EE0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectMode;

		// Token: 0x0402EE0B RID: 192011
		[Token(Token = "0x402EE0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_selectMode;

		// Token: 0x0402EE0C RID: 192012
		[Token(Token = "0x402EE0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isSingle;

		// Token: 0x0402EE0D RID: 192013
		[Token(Token = "0x402EE0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_focusIndex;

		// Token: 0x0402EE0E RID: 192014
		[Token(Token = "0x402EE0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_focusIndex;

		// Token: 0x0402EE0F RID: 192015
		[Token(Token = "0x402EE0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_shuffleResult;

		// Token: 0x0402EE10 RID: 192016
		[Token(Token = "0x402EE10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_shuffleResult;

		// Token: 0x0402EE11 RID: 192017
		[Token(Token = "0x402EE11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402EE12 RID: 192018
		[Token(Token = "0x402EE12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Resume;

		// Token: 0x0402EE13 RID: 192019
		[Token(Token = "0x402EE13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AddToCharCollection;

		// Token: 0x0402EE14 RID: 192020
		[Token(Token = "0x402EE14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SelectChar;

		// Token: 0x0402EE15 RID: 192021
		[Token(Token = "0x402EE15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoSingleSelect;

		// Token: 0x0402EE16 RID: 192022
		[Token(Token = "0x402EE16")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoMultiSelect;

		// Token: 0x0402EE17 RID: 192023
		[Token(Token = "0x402EE17")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ClearAllSelect;

		// Token: 0x0402EE18 RID: 192024
		[Token(Token = "0x402EE18")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCharViewModelByInstId;

		// Token: 0x0402EE19 RID: 192025
		[Token(Token = "0x402EE19")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCharIdByInstId;

		// Token: 0x0402EE1A RID: 192026
		[Token(Token = "0x402EE1A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ApplyShuffle;

		// Token: 0x0402EE1B RID: 192027
		[Token(Token = "0x402EE1B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetShuffleResult;

		// Token: 0x0402EE1C RID: 192028
		[Token(Token = "0x402EE1C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
