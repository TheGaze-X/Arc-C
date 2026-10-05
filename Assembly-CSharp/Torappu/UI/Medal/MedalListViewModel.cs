using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A8 RID: 18856
	[Token(Token = "0x20049A8")]
	public class MedalListViewModel : IHotfixable
	{
		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x0601C689 RID: 116361 RVA: 0x000A8420 File Offset: 0x000A6620
		[Token(Token = "0x17004349")]
		public int haveCount
		{
			[Token(Token = "0x601C689")]
			[Address(RVA = "0x15EF280", Offset = "0x15EDE80", VA = "0x1815EF280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x0601C68A RID: 116362 RVA: 0x000A8438 File Offset: 0x000A6638
		[Token(Token = "0x1700434A")]
		public int totalCount
		{
			[Token(Token = "0x601C68A")]
			[Address(RVA = "0x15EF480", Offset = "0x15EE080", VA = "0x1815EF480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x0601C68B RID: 116363 RVA: 0x000A8450 File Offset: 0x000A6650
		[Token(Token = "0x1700434B")]
		public int haveOneCount
		{
			[Token(Token = "0x601C68B")]
			[Address(RVA = "0x15EF300", Offset = "0x15EDF00", VA = "0x1815EF300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x0601C68C RID: 116364 RVA: 0x000A8468 File Offset: 0x000A6668
		[Token(Token = "0x1700434C")]
		public int totalOneCount
		{
			[Token(Token = "0x601C68C")]
			[Address(RVA = "0x15EF500", Offset = "0x15EE100", VA = "0x1815EF500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x0601C68D RID: 116365 RVA: 0x000A8480 File Offset: 0x000A6680
		[Token(Token = "0x1700434D")]
		public int haveTwoCount
		{
			[Token(Token = "0x601C68D")]
			[Address(RVA = "0x15EF400", Offset = "0x15EE000", VA = "0x1815EF400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x0601C68E RID: 116366 RVA: 0x000A8498 File Offset: 0x000A6698
		[Token(Token = "0x1700434E")]
		public int totalTwoCount
		{
			[Token(Token = "0x601C68E")]
			[Address(RVA = "0x15EF600", Offset = "0x15EE200", VA = "0x1815EF600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x0601C68F RID: 116367 RVA: 0x000A84B0 File Offset: 0x000A66B0
		[Token(Token = "0x1700434F")]
		public int haveThreeCount
		{
			[Token(Token = "0x601C68F")]
			[Address(RVA = "0x15EF380", Offset = "0x15EDF80", VA = "0x1815EF380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x0601C690 RID: 116368 RVA: 0x000A84C8 File Offset: 0x000A66C8
		[Token(Token = "0x17004350")]
		public int totalThreeCount
		{
			[Token(Token = "0x601C690")]
			[Address(RVA = "0x15EF580", Offset = "0x15EE180", VA = "0x1815EF580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C691 RID: 116369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C691")]
		[Address(RVA = "0x15ECF10", Offset = "0x15EBB10", VA = "0x1815ECF10")]
		public List<MedalBarListItemModel> GetBarListModels4Display()
		{
			return null;
		}

		// Token: 0x0601C692 RID: 116370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C692")]
		[Address(RVA = "0x15EE760", Offset = "0x15ED360", VA = "0x1815EE760")]
		private void _LoadBarListModelsIfNot()
		{
		}

		// Token: 0x0601C693 RID: 116371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C693")]
		[Address(RVA = "0x15ED340", Offset = "0x15EBF40", VA = "0x1815ED340")]
		public List<MedalTypeViewModel> GetTypeList4Display()
		{
			return null;
		}

		// Token: 0x0601C694 RID: 116372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C694")]
		[Address(RVA = "0x15ECF70", Offset = "0x15EBB70", VA = "0x1815ECF70")]
		public List<MedalGroupListItemModel> GetGroupList4Display()
		{
			return null;
		}

		// Token: 0x0601C695 RID: 116373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C695")]
		[Address(RVA = "0x15EDFD0", Offset = "0x15ECBD0", VA = "0x1815EDFD0")]
		private void _InitGroupListIfNeeded()
		{
		}

		// Token: 0x0601C696 RID: 116374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C696")]
		[Address(RVA = "0x15ECFD0", Offset = "0x15EBBD0", VA = "0x1815ECFD0")]
		public List<MedalGroupViewModel> GetGroupTemplates4Display()
		{
			return null;
		}

		// Token: 0x0601C697 RID: 116375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C697")]
		[Address(RVA = "0x15EE3D0", Offset = "0x15ECFD0", VA = "0x1815EE3D0")]
		private void _InitGroupTemplatesIfNeeded()
		{
		}

		// Token: 0x0601C698 RID: 116376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C698")]
		[Address(RVA = "0x15EF050", Offset = "0x15EDC50", VA = "0x1815EF050")]
		private void _ResetListsForDisplay()
		{
		}

		// Token: 0x0601C699 RID: 116377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C699")]
		[Address(RVA = "0x15ED160", Offset = "0x15EBD60", VA = "0x1815ED160")]
		public MedalGroupViewModel GetMostRecentNonDefaultGroup()
		{
			return null;
		}

		// Token: 0x0601C69A RID: 116378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C69A")]
		[Address(RVA = "0x15ED5D0", Offset = "0x15EC1D0", VA = "0x1815ED5D0")]
		public void ReloadData(bool abortNotGetMedals)
		{
		}

		// Token: 0x0601C69B RID: 116379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C69B")]
		[Address(RVA = "0x15EDBB0", Offset = "0x15EC7B0", VA = "0x1815EDBB0")]
		public void UpdatePlayerStatus()
		{
		}

		// Token: 0x0601C69C RID: 116380 RVA: 0x000A84E0 File Offset: 0x000A66E0
		[Token(Token = "0x601C69C")]
		[Address(RVA = "0x15ED030", Offset = "0x15EBC30", VA = "0x1815ED030")]
		public MedalListViewModel.ListFilter GetListFilter()
		{
			return default(MedalListViewModel.ListFilter);
		}

		// Token: 0x0601C69D RID: 116381 RVA: 0x000A84F8 File Offset: 0x000A66F8
		[Token(Token = "0x601C69D")]
		[Address(RVA = "0x15ECDE0", Offset = "0x15EB9E0", VA = "0x1815ECDE0")]
		public bool ChangeFilterStatus(MedalListViewModel.ListFilter targetFilter)
		{
			return default(bool);
		}

		// Token: 0x0601C69E RID: 116382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C69E")]
		[Address(RVA = "0x15EEB20", Offset = "0x15ED720", VA = "0x1815EEB20")]
		private void _PostUpdateTypeAndGroupStatus(long curTs)
		{
		}

		// Token: 0x0601C69F RID: 116383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C69F")]
		[Address(RVA = "0x15ED0B0", Offset = "0x15EBCB0", VA = "0x1815ED0B0")]
		public IEnumerator<MedalCommonViewModel> GetMedalEnumerator()
		{
			return null;
		}

		// Token: 0x0601C6A0 RID: 116384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6A0")]
		[Address(RVA = "0x15EDED0", Offset = "0x15ECAD0", VA = "0x1815EDED0")]
		private static IEnumerator<MedalListViewModel.MedalItemWrapper> _GetWrappedMedalEnumerator(ListDict<string, MedalTypeViewModel> typeList)
		{
			return null;
		}

		// Token: 0x0601C6A1 RID: 116385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6A1")]
		[Address(RVA = "0x15EF0F0", Offset = "0x15EDCF0", VA = "0x1815EF0F0")]
		public MedalListViewModel()
		{
		}

		// Token: 0x04025369 RID: 152425
		[Token(Token = "0x4025369")]
		[FieldOffset(Offset = "0x10")]
		private long m_lastReloadTs;

		// Token: 0x0402536A RID: 152426
		[Token(Token = "0x402536A")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, MedalTypeViewModel> m_rawMedalData;

		// Token: 0x0402536B RID: 152427
		[Token(Token = "0x402536B")]
		[FieldOffset(Offset = "0x20")]
		private MedalCount m_allMedalCount;

		// Token: 0x0402536C RID: 152428
		[Token(Token = "0x402536C")]
		[FieldOffset(Offset = "0x2C")]
		private MedalCount m_oneMedalCount;

		// Token: 0x0402536D RID: 152429
		[Token(Token = "0x402536D")]
		[FieldOffset(Offset = "0x38")]
		private MedalCount m_twoMedalCount;

		// Token: 0x0402536E RID: 152430
		[Token(Token = "0x402536E")]
		[FieldOffset(Offset = "0x44")]
		private MedalCount m_threeMedalCount;

		// Token: 0x0402536F RID: 152431
		[Token(Token = "0x402536F")]
		[FieldOffset(Offset = "0x50")]
		private MedalListViewModel.ListFilter m_listFilter;

		// Token: 0x04025370 RID: 152432
		[Token(Token = "0x4025370")]
		[FieldOffset(Offset = "0x60")]
		private List<MedalBarListItemModel> m_barList4Display;

		// Token: 0x04025371 RID: 152433
		[Token(Token = "0x4025371")]
		[FieldOffset(Offset = "0x68")]
		private List<MedalTypeViewModel> m_typeList4Display;

		// Token: 0x04025372 RID: 152434
		[Token(Token = "0x4025372")]
		[FieldOffset(Offset = "0x70")]
		private List<MedalGroupListItemModel> m_groupList4Display;

		// Token: 0x04025373 RID: 152435
		[Token(Token = "0x4025373")]
		[FieldOffset(Offset = "0x78")]
		private List<MedalGroupViewModel> m_groupTemplates4Display;

		// Token: 0x04025374 RID: 152436
		[Token(Token = "0x4025374")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_haveCount;

		// Token: 0x04025375 RID: 152437
		[Token(Token = "0x4025375")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04025376 RID: 152438
		[Token(Token = "0x4025376")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_haveOneCount;

		// Token: 0x04025377 RID: 152439
		[Token(Token = "0x4025377")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_totalOneCount;

		// Token: 0x04025378 RID: 152440
		[Token(Token = "0x4025378")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_haveTwoCount;

		// Token: 0x04025379 RID: 152441
		[Token(Token = "0x4025379")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_totalTwoCount;

		// Token: 0x0402537A RID: 152442
		[Token(Token = "0x402537A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_haveThreeCount;

		// Token: 0x0402537B RID: 152443
		[Token(Token = "0x402537B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_totalThreeCount;

		// Token: 0x0402537C RID: 152444
		[Token(Token = "0x402537C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetBarListModels4Display;

		// Token: 0x0402537D RID: 152445
		[Token(Token = "0x402537D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadBarListModelsIfNot;

		// Token: 0x0402537E RID: 152446
		[Token(Token = "0x402537E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTypeList4Display;

		// Token: 0x0402537F RID: 152447
		[Token(Token = "0x402537F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetGroupList4Display;

		// Token: 0x04025380 RID: 152448
		[Token(Token = "0x4025380")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitGroupListIfNeeded;

		// Token: 0x04025381 RID: 152449
		[Token(Token = "0x4025381")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetGroupTemplates4Display;

		// Token: 0x04025382 RID: 152450
		[Token(Token = "0x4025382")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitGroupTemplatesIfNeeded;

		// Token: 0x04025383 RID: 152451
		[Token(Token = "0x4025383")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetListsForDisplay;

		// Token: 0x04025384 RID: 152452
		[Token(Token = "0x4025384")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetMostRecentNonDefaultGroup;

		// Token: 0x04025385 RID: 152453
		[Token(Token = "0x4025385")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ReloadData;

		// Token: 0x04025386 RID: 152454
		[Token(Token = "0x4025386")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdatePlayerStatus;

		// Token: 0x04025387 RID: 152455
		[Token(Token = "0x4025387")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetListFilter;

		// Token: 0x04025388 RID: 152456
		[Token(Token = "0x4025388")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ChangeFilterStatus;

		// Token: 0x04025389 RID: 152457
		[Token(Token = "0x4025389")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PostUpdateTypeAndGroupStatus;

		// Token: 0x0402538A RID: 152458
		[Token(Token = "0x402538A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetMedalEnumerator;

		// Token: 0x0402538B RID: 152459
		[Token(Token = "0x402538B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetWrappedMedalEnumerator;

		// Token: 0x0402538C RID: 152460
		[Token(Token = "0x402538C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049A9 RID: 18857
		[Token(Token = "0x20049A9")]
		private struct MedalItemWrapper
		{
			// Token: 0x0402538D RID: 152461
			[Token(Token = "0x402538D")]
			[FieldOffset(Offset = "0x0")]
			public MedalTypeViewModel typeModel;

			// Token: 0x0402538E RID: 152462
			[Token(Token = "0x402538E")]
			[FieldOffset(Offset = "0x8")]
			public MedalGroupViewModel groupModel;

			// Token: 0x0402538F RID: 152463
			[Token(Token = "0x402538F")]
			[FieldOffset(Offset = "0x10")]
			public MedalCommonViewModel medalModel;
		}

		// Token: 0x020049AA RID: 18858
		[Token(Token = "0x20049AA")]
		public struct ListFilter : IHotfixable
		{
			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0601C6A2 RID: 116386 RVA: 0x000A8510 File Offset: 0x000A6710
			// (set) Token: 0x0601C6A3 RID: 116387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004351")]
			public bool isEmpty
			{
				[Token(Token = "0x601C6A2")]
				[Address(RVA = "0x15DE590", Offset = "0x15DD190", VA = "0x1815DE590")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601C6A3")]
				[Address(RVA = "0x15DE610", Offset = "0x15DD210", VA = "0x1815DE610")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601C6A4 RID: 116388 RVA: 0x000A8528 File Offset: 0x000A6728
			[Token(Token = "0x601C6A4")]
			[Address(RVA = "0x15DDFA0", Offset = "0x15DCBA0", VA = "0x1815DDFA0")]
			public bool CheckIfBarListMedalValid(MedalCommonViewModel medalModel)
			{
				return default(bool);
			}

			// Token: 0x0601C6A5 RID: 116389 RVA: 0x000A8540 File Offset: 0x000A6740
			[Token(Token = "0x601C6A5")]
			[Address(RVA = "0x15DE060", Offset = "0x15DCC60", VA = "0x1815DE060")]
			public bool CheckIfGroupListMedalValid(MedalCommonViewModel medalModel)
			{
				return default(bool);
			}

			// Token: 0x0601C6A6 RID: 116390 RVA: 0x000A8558 File Offset: 0x000A6758
			[Token(Token = "0x601C6A6")]
			[Address(RVA = "0x15DE120", Offset = "0x15DCD20", VA = "0x1815DE120")]
			public bool CheckIfGroupValid(MedalGroupViewModel groupModel)
			{
				return default(bool);
			}

			// Token: 0x0601C6A7 RID: 116391 RVA: 0x000A8570 File Offset: 0x000A6770
			[Token(Token = "0x601C6A7")]
			[Address(RVA = "0x15DE350", Offset = "0x15DCF50", VA = "0x1815DE350")]
			private static bool _CheckIfMedalValid(MedalCommonViewModel medalModel, MedalBarListShowType showType, bool showNotGetExpired)
			{
				return default(bool);
			}

			// Token: 0x04025390 RID: 152464
			[Token(Token = "0x4025390")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MedalListViewModel.ListFilter EMPTY;

			// Token: 0x04025392 RID: 152466
			[Token(Token = "0x4025392")]
			[FieldOffset(Offset = "0x1")]
			public bool showNotGetExpired;

			// Token: 0x04025393 RID: 152467
			[Token(Token = "0x4025393")]
			[FieldOffset(Offset = "0x4")]
			public MedalBarListShowType showType;

			// Token: 0x04025394 RID: 152468
			[Token(Token = "0x4025394")]
			[FieldOffset(Offset = "0x8")]
			public long filterVersion;

			// Token: 0x04025395 RID: 152469
			[Token(Token = "0x4025395")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x04025396 RID: 152470
			[Token(Token = "0x4025396")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_isEmpty;

			// Token: 0x04025397 RID: 152471
			[Token(Token = "0x4025397")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckIfBarListMedalValid;

			// Token: 0x04025398 RID: 152472
			[Token(Token = "0x4025398")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_CheckIfGroupListMedalValid;

			// Token: 0x04025399 RID: 152473
			[Token(Token = "0x4025399")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CheckIfGroupValid;

			// Token: 0x0402539A RID: 152474
			[Token(Token = "0x402539A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CheckIfMedalValid;
		}
	}
}
