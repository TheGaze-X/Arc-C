using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005669 RID: 22121
	[Token(Token = "0x2005669")]
	public class RL04AlchemyImplViewModel : IHotfixable
	{
		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06020731 RID: 132913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020732 RID: 132914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0B")]
		public string topicId
		{
			[Token(Token = "0x6020731")]
			[Address(RVA = "0x1A9B0C0", Offset = "0x1A99CC0", VA = "0x181A9B0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020732")]
			[Address(RVA = "0x1A9B520", Offset = "0x1A9A120", VA = "0x181A9B520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x06020733 RID: 132915 RVA: 0x000B5FE0 File Offset: 0x000B41E0
		// (set) Token: 0x06020734 RID: 132916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0C")]
		public int maxAlchemyField
		{
			[Token(Token = "0x6020733")]
			[Address(RVA = "0x1A9AF40", Offset = "0x1A99B40", VA = "0x181A9AF40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020734")]
			[Address(RVA = "0x1A9B3C0", Offset = "0x1A99FC0", VA = "0x181A9B3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06020735 RID: 132917 RVA: 0x000B5FF8 File Offset: 0x000B41F8
		// (set) Token: 0x06020736 RID: 132918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0D")]
		public int maxAlchemyCount
		{
			[Token(Token = "0x6020735")]
			[Address(RVA = "0x1A9AEE0", Offset = "0x1A99AE0", VA = "0x181A9AEE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020736")]
			[Address(RVA = "0x1A9B350", Offset = "0x1A99F50", VA = "0x181A9B350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06020737 RID: 132919 RVA: 0x000B6010 File Offset: 0x000B4210
		// (set) Token: 0x06020738 RID: 132920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0E")]
		public int maxAlchemyPoolRarity
		{
			[Token(Token = "0x6020737")]
			[Address(RVA = "0x1A9AFA0", Offset = "0x1A99BA0", VA = "0x181A9AFA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020738")]
			[Address(RVA = "0x1A9B430", Offset = "0x1A9A030", VA = "0x181A9B430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06020739 RID: 132921 RVA: 0x000B6028 File Offset: 0x000B4228
		// (set) Token: 0x0602073A RID: 132922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C0F")]
		public bool isInDisaster
		{
			[Token(Token = "0x6020739")]
			[Address(RVA = "0x1A9ADC0", Offset = "0x1A999C0", VA = "0x181A9ADC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602073A")]
			[Address(RVA = "0x1A9B200", Offset = "0x1A99E00", VA = "0x181A9B200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x0602073B RID: 132923 RVA: 0x000B6040 File Offset: 0x000B4240
		// (set) Token: 0x0602073C RID: 132924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C10")]
		public RL04AlchemyImplViewModel.LeaveBtnStatus leaveBtnStatus
		{
			[Token(Token = "0x602073B")]
			[Address(RVA = "0x1A9AE80", Offset = "0x1A99A80", VA = "0x181A9AE80")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemyImplViewModel.LeaveBtnStatus.CLOSE_STATE;
			}
			[Token(Token = "0x602073C")]
			[Address(RVA = "0x1A9B2E0", Offset = "0x1A99EE0", VA = "0x181A9B2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x0602073D RID: 132925 RVA: 0x000B6058 File Offset: 0x000B4258
		// (set) Token: 0x0602073E RID: 132926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C11")]
		public bool isLeaving
		{
			[Token(Token = "0x602073D")]
			[Address(RVA = "0x1A9AE20", Offset = "0x1A99A20", VA = "0x181A9AE20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602073E")]
			[Address(RVA = "0x1A9B270", Offset = "0x1A99E70", VA = "0x181A9B270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0602073F RID: 132927 RVA: 0x000B6070 File Offset: 0x000B4270
		// (set) Token: 0x06020740 RID: 132928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C12")]
		public RL04AlchemyImplViewModel.ViewAlchemyStatus viewStatus
		{
			[Token(Token = "0x602073F")]
			[Address(RVA = "0x1A9B120", Offset = "0x1A99D20", VA = "0x181A9B120")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemyImplViewModel.ViewAlchemyStatus.NOT_MELD;
			}
			[Token(Token = "0x6020740")]
			[Address(RVA = "0x1A9B5A0", Offset = "0x1A9A1A0", VA = "0x181A9B5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x06020741 RID: 132929 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020742 RID: 132930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C13")]
		public RL04AlchemyForecastRandomViewModel emptyRandomViewModel
		{
			[Token(Token = "0x6020741")]
			[Address(RVA = "0x1A9AB60", Offset = "0x1A99760", VA = "0x181A9AB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020742")]
			[Address(RVA = "0x1A9B180", Offset = "0x1A99D80", VA = "0x181A9B180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06020743 RID: 132931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020744 RID: 132932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C14")]
		public RL04AlchemyResultViewModel resultViewModel
		{
			[Token(Token = "0x6020743")]
			[Address(RVA = "0x1A9B000", Offset = "0x1A99C00", VA = "0x181A9B000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020744")]
			[Address(RVA = "0x1A9B4A0", Offset = "0x1A9A0A0", VA = "0x181A9B4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06020745 RID: 132933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C15")]
		public RL04AlchemySlotListViewModel slotListViewModel
		{
			[Token(Token = "0x6020745")]
			[Address(RVA = "0x1A9B060", Offset = "0x1A99C60", VA = "0x181A9B060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06020746 RID: 132934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C16")]
		public RL04AlchemyForecastViewModel forecastViewModel
		{
			[Token(Token = "0x6020746")]
			[Address(RVA = "0x1A9AD00", Offset = "0x1A99900", VA = "0x181A9AD00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06020747 RID: 132935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C17")]
		public RL04AlchemyFragmentListViewModel fragmentStorageViewModel
		{
			[Token(Token = "0x6020747")]
			[Address(RVA = "0x1A9AD60", Offset = "0x1A99960", VA = "0x181A9AD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06020748 RID: 132936 RVA: 0x000B6088 File Offset: 0x000B4288
		[Token(Token = "0x17004C18")]
		public RL04AlchemyForecastViewModel.ForecastStatus forecastStatus
		{
			[Token(Token = "0x6020748")]
			[Address(RVA = "0x1A9ABC0", Offset = "0x1A997C0", VA = "0x181A9ABC0")]
			get
			{
				return RL04AlchemyForecastViewModel.ForecastStatus.NOT_READY;
			}
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06020749 RID: 132937 RVA: 0x000B60A0 File Offset: 0x000B42A0
		[Token(Token = "0x17004C19")]
		public RL04AlchemyForecastViewModel.ForecastType forecastType
		{
			[Token(Token = "0x6020749")]
			[Address(RVA = "0x1A9AC60", Offset = "0x1A99860", VA = "0x181A9AC60")]
			get
			{
				return RL04AlchemyForecastViewModel.ForecastType.NONE;
			}
		}

		// Token: 0x0602074A RID: 132938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602074A")]
		[Address(RVA = "0x1A960D0", Offset = "0x1A94CD0", VA = "0x181A960D0")]
		public void LoadData(string iTopicId)
		{
		}

		// Token: 0x0602074B RID: 132939 RVA: 0x000B60B8 File Offset: 0x000B42B8
		[Token(Token = "0x602074B")]
		[Address(RVA = "0x1A96330", Offset = "0x1A94F30", VA = "0x181A96330")]
		public bool RefreshFragmentItemSelectStatus(string fragmentInstId)
		{
			return default(bool);
		}

		// Token: 0x0602074C RID: 132940 RVA: 0x000B60D0 File Offset: 0x000B42D0
		[Token(Token = "0x602074C")]
		[Address(RVA = "0x1A96750", Offset = "0x1A95350", VA = "0x181A96750")]
		public bool TryUnloadSlotFragmentItem(int slotIndex)
		{
			return default(bool);
		}

		// Token: 0x0602074D RID: 132941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602074D")]
		[Address(RVA = "0x1A96530", Offset = "0x1A95130", VA = "0x181A96530")]
		public void RefreshLeaveBtnStatus(bool isSelect)
		{
		}

		// Token: 0x0602074E RID: 132942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602074E")]
		[Address(RVA = "0x1A96440", Offset = "0x1A95040", VA = "0x181A96440")]
		public void RefreshIsLeavingStatus(bool iIsLeaving)
		{
		}

		// Token: 0x0602074F RID: 132943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602074F")]
		[Address(RVA = "0x1A966B0", Offset = "0x1A952B0", VA = "0x181A966B0")]
		public void RefreshViewStatus(RL04AlchemyImplViewModel.ViewAlchemyStatus viewAlchemyStatus)
		{
		}

		// Token: 0x06020750 RID: 132944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020750")]
		[Address(RVA = "0x1A96240", Offset = "0x1A94E40", VA = "0x181A96240")]
		public void RefreshDataAfterClaimAlchemyReward()
		{
		}

		// Token: 0x06020751 RID: 132945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020751")]
		[Address(RVA = "0x1A96640", Offset = "0x1A95240", VA = "0x181A96640")]
		public void RefreshPlayerContent()
		{
		}

		// Token: 0x06020752 RID: 132946 RVA: 0x000B60E8 File Offset: 0x000B42E8
		[Token(Token = "0x6020752")]
		[Address(RVA = "0x1A95DE0", Offset = "0x1A949E0", VA = "0x181A95DE0")]
		public bool CheckIfCanStartAlchemy()
		{
			return default(bool);
		}

		// Token: 0x06020753 RID: 132947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020753")]
		[Address(RVA = "0x1A95F40", Offset = "0x1A94B40", VA = "0x181A95F40")]
		public List<string> GetSelectedFragmentInstIdList()
		{
			return null;
		}

		// Token: 0x06020754 RID: 132948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020754")]
		[Address(RVA = "0x1A97550", Offset = "0x1A96150", VA = "0x181A97550")]
		private void _LoadInAlchemyPending(string iTopicId)
		{
		}

		// Token: 0x06020755 RID: 132949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020755")]
		[Address(RVA = "0x1A975E0", Offset = "0x1A961E0", VA = "0x181A975E0")]
		private void _LoadInAlchemyRewardPending(string iTopicId)
		{
		}

		// Token: 0x06020756 RID: 132950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020756")]
		[Address(RVA = "0x1A97680", Offset = "0x1A96280", VA = "0x181A97680")]
		private void _LoadInternal(string iTopicId)
		{
		}

		// Token: 0x06020757 RID: 132951 RVA: 0x000B6100 File Offset: 0x000B4300
		[Token(Token = "0x6020757")]
		[Address(RVA = "0x1A96970", Offset = "0x1A95570", VA = "0x181A96970")]
		private bool _CheckIfCanOperate()
		{
			return default(bool);
		}

		// Token: 0x06020758 RID: 132952 RVA: 0x000B6118 File Offset: 0x000B4318
		[Token(Token = "0x6020758")]
		[Address(RVA = "0x1A96FD0", Offset = "0x1A95BD0", VA = "0x181A96FD0")]
		private int _GetMaxPoolRarity()
		{
			return 0;
		}

		// Token: 0x06020759 RID: 132953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020759")]
		[Address(RVA = "0x1A984B0", Offset = "0x1A970B0", VA = "0x181A984B0")]
		private void _RefreshPlayerAlchemyContent()
		{
		}

		// Token: 0x0602075A RID: 132954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602075A")]
		[Address(RVA = "0x1A986B0", Offset = "0x1A972B0", VA = "0x181A986B0")]
		private void _RefreshPlayerAlchemyRewardContent()
		{
		}

		// Token: 0x0602075B RID: 132955 RVA: 0x000B6130 File Offset: 0x000B4330
		[Token(Token = "0x602075B")]
		[Address(RVA = "0x1A992C0", Offset = "0x1A97EC0", VA = "0x181A992C0")]
		private bool _SelectFragmentItem(string fragmentInstId)
		{
			return default(bool);
		}

		// Token: 0x0602075C RID: 132956 RVA: 0x000B6148 File Offset: 0x000B4348
		[Token(Token = "0x602075C")]
		[Address(RVA = "0x1A9A620", Offset = "0x1A99220", VA = "0x181A9A620")]
		private bool _UnSelectFragmentItem(string fragmentInstId)
		{
			return default(bool);
		}

		// Token: 0x0602075D RID: 132957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602075D")]
		[Address(RVA = "0x1A97440", Offset = "0x1A96040", VA = "0x181A97440")]
		private void _InitSlotListData()
		{
		}

		// Token: 0x0602075E RID: 132958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602075E")]
		[Address(RVA = "0x1A98F40", Offset = "0x1A97B40", VA = "0x181A98F40")]
		private void _ResetSlotListData()
		{
		}

		// Token: 0x0602075F RID: 132959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602075F")]
		[Address(RVA = "0x1A98940", Offset = "0x1A97540", VA = "0x181A98940")]
		private void _RefreshSlotItemData(int slotIndex, string fragmentInstId)
		{
		}

		// Token: 0x06020760 RID: 132960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020760")]
		[Address(RVA = "0x1A9A490", Offset = "0x1A99090", VA = "0x181A9A490")]
		private RL04AlchemySlotItemViewModel _TryGetSlotItemByFragmentInstId(string fragmentInstId)
		{
			return null;
		}

		// Token: 0x06020761 RID: 132961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020761")]
		[Address(RVA = "0x1A98DB0", Offset = "0x1A979B0", VA = "0x181A98DB0")]
		private string _ResetSlotItem(int slotIndex)
		{
			return null;
		}

		// Token: 0x06020762 RID: 132962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020762")]
		[Address(RVA = "0x1A9A070", Offset = "0x1A98C70", VA = "0x181A9A070")]
		private RL04AlchemyFragmentItemViewModel _TryGetFragmentItemViewModelByInstId(string instId)
		{
			return null;
		}

		// Token: 0x06020763 RID: 132963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020763")]
		[Address(RVA = "0x1A96BC0", Offset = "0x1A957C0", VA = "0x181A96BC0")]
		private RL04AlchemySlotItemViewModel _GetFirstSlotItemCanBePut()
		{
			return null;
		}

		// Token: 0x06020764 RID: 132964 RVA: 0x000B6160 File Offset: 0x000B4360
		[Token(Token = "0x6020764")]
		[Address(RVA = "0x1A96B00", Offset = "0x1A95700", VA = "0x181A96B00")]
		private bool _CheckIfSlotListFull()
		{
			return default(bool);
		}

		// Token: 0x06020765 RID: 132965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020765")]
		[Address(RVA = "0x1A98B20", Offset = "0x1A97720", VA = "0x181A98B20")]
		private void _RefreshSlotListStatus()
		{
		}

		// Token: 0x06020766 RID: 132966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020766")]
		[Address(RVA = "0x1A97120", Offset = "0x1A95D20", VA = "0x181A97120")]
		private List<string> _GetSlotFragmentIdList()
		{
			return null;
		}

		// Token: 0x06020767 RID: 132967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020767")]
		[Address(RVA = "0x1A972B0", Offset = "0x1A95EB0", VA = "0x181A972B0")]
		private void _InitFragmentStorageData()
		{
		}

		// Token: 0x06020768 RID: 132968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020768")]
		[Address(RVA = "0x1A98390", Offset = "0x1A96F90", VA = "0x181A98390")]
		private void _RefreshFragmentItemSelectState(string instId, bool select)
		{
		}

		// Token: 0x06020769 RID: 132969 RVA: 0x000B6178 File Offset: 0x000B4378
		[Token(Token = "0x6020769")]
		[Address(RVA = "0x1A96A70", Offset = "0x1A95670", VA = "0x181A96A70")]
		private bool _CheckIfFragmentIsSelected(string fragmentInstId)
		{
			return default(bool);
		}

		// Token: 0x0602076A RID: 132970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602076A")]
		[Address(RVA = "0x1A98440", Offset = "0x1A97040", VA = "0x181A98440")]
		private void _RefreshFragmentStorageData()
		{
		}

		// Token: 0x0602076B RID: 132971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602076B")]
		[Address(RVA = "0x1A97CC0", Offset = "0x1A968C0", VA = "0x181A97CC0")]
		private void _RefreshForecastData()
		{
		}

		// Token: 0x0602076C RID: 132972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602076C")]
		[Address(RVA = "0x1A97E70", Offset = "0x1A96A70", VA = "0x181A97E70")]
		private void _RefreshForecastStatus()
		{
		}

		// Token: 0x0602076D RID: 132973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602076D")]
		[Address(RVA = "0x1A97FD0", Offset = "0x1A96BD0", VA = "0x181A97FD0")]
		private void _RefreshForecastType()
		{
		}

		// Token: 0x0602076E RID: 132974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602076E")]
		[Address(RVA = "0x1A99500", Offset = "0x1A98100", VA = "0x181A99500")]
		private RoguelikeAlchemyFormulationData _TryGetAlchemyFormulationData(List<string> fragmentIds)
		{
			return null;
		}

		// Token: 0x0602076F RID: 132975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602076F")]
		[Address(RVA = "0x1A99A20", Offset = "0x1A98620", VA = "0x181A99A20")]
		private RoguelikeAlchemyData _TryGetAlchemyRecipeData(List<RL04AlchemySlotItemViewModel> fragments)
		{
			return null;
		}

		// Token: 0x06020770 RID: 132976 RVA: 0x000B6190 File Offset: 0x000B4390
		[Token(Token = "0x6020770")]
		[Address(RVA = "0x1A9A130", Offset = "0x1A98D30", VA = "0x181A9A130")]
		private bool _TryGetOverrideAlchemyData(RoguelikeAlchemyData alchemyData, out RoguelikeAlchemyData overrideData)
		{
			return default(bool);
		}

		// Token: 0x06020771 RID: 132977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020771")]
		[Address(RVA = "0x1A96D10", Offset = "0x1A95910", VA = "0x181A96D10")]
		private PlayerRoguelikePendingEvent.AlchemyContent _GetGameAlchemyContent()
		{
			return null;
		}

		// Token: 0x06020772 RID: 132978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020772")]
		[Address(RVA = "0x1A96E70", Offset = "0x1A95A70", VA = "0x181A96E70")]
		private PlayerRoguelikePendingEvent.AlchemyRewardContent _GetGameAlchemyRewardContent()
		{
			return null;
		}

		// Token: 0x06020773 RID: 132979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020773")]
		[Address(RVA = "0x1A9A840", Offset = "0x1A99440", VA = "0x181A9A840")]
		public RL04AlchemyImplViewModel()
		{
		}

		// Token: 0x0402BF31 RID: 180017
		[Token(Token = "0x402BF31")]
		[FieldOffset(Offset = "0x48")]
		private RL04AlchemySlotListViewModel m_slotListViewModel;

		// Token: 0x0402BF32 RID: 180018
		[Token(Token = "0x402BF32")]
		[FieldOffset(Offset = "0x50")]
		private RL04AlchemyForecastViewModel m_forecastViewModel;

		// Token: 0x0402BF33 RID: 180019
		[Token(Token = "0x402BF33")]
		[FieldOffset(Offset = "0x58")]
		private RL04AlchemyFragmentListViewModel m_fragmentStorageViewModel;

		// Token: 0x0402BF34 RID: 180020
		[Token(Token = "0x402BF34")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, RoguelikeAlchemyFormulationData> m_alchemyFormulaDataDict;

		// Token: 0x0402BF35 RID: 180021
		[Token(Token = "0x402BF35")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<string, RoguelikeAlchemyData> m_alchemyDataDict;

		// Token: 0x0402BF36 RID: 180022
		[Token(Token = "0x402BF36")]
		[FieldOffset(Offset = "0x70")]
		private int m_sequenceNum;

		// Token: 0x0402BF37 RID: 180023
		[Token(Token = "0x402BF37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402BF38 RID: 180024
		[Token(Token = "0x402BF38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402BF39 RID: 180025
		[Token(Token = "0x402BF39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxAlchemyField;

		// Token: 0x0402BF3A RID: 180026
		[Token(Token = "0x402BF3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxAlchemyField;

		// Token: 0x0402BF3B RID: 180027
		[Token(Token = "0x402BF3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxAlchemyCount;

		// Token: 0x0402BF3C RID: 180028
		[Token(Token = "0x402BF3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxAlchemyCount;

		// Token: 0x0402BF3D RID: 180029
		[Token(Token = "0x402BF3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_maxAlchemyPoolRarity;

		// Token: 0x0402BF3E RID: 180030
		[Token(Token = "0x402BF3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_maxAlchemyPoolRarity;

		// Token: 0x0402BF3F RID: 180031
		[Token(Token = "0x402BF3F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isInDisaster;

		// Token: 0x0402BF40 RID: 180032
		[Token(Token = "0x402BF40")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isInDisaster;

		// Token: 0x0402BF41 RID: 180033
		[Token(Token = "0x402BF41")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_leaveBtnStatus;

		// Token: 0x0402BF42 RID: 180034
		[Token(Token = "0x402BF42")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_leaveBtnStatus;

		// Token: 0x0402BF43 RID: 180035
		[Token(Token = "0x402BF43")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isLeaving;

		// Token: 0x0402BF44 RID: 180036
		[Token(Token = "0x402BF44")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_isLeaving;

		// Token: 0x0402BF45 RID: 180037
		[Token(Token = "0x402BF45")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_viewStatus;

		// Token: 0x0402BF46 RID: 180038
		[Token(Token = "0x402BF46")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_viewStatus;

		// Token: 0x0402BF47 RID: 180039
		[Token(Token = "0x402BF47")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_emptyRandomViewModel;

		// Token: 0x0402BF48 RID: 180040
		[Token(Token = "0x402BF48")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_emptyRandomViewModel;

		// Token: 0x0402BF49 RID: 180041
		[Token(Token = "0x402BF49")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_resultViewModel;

		// Token: 0x0402BF4A RID: 180042
		[Token(Token = "0x402BF4A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_resultViewModel;

		// Token: 0x0402BF4B RID: 180043
		[Token(Token = "0x402BF4B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_slotListViewModel;

		// Token: 0x0402BF4C RID: 180044
		[Token(Token = "0x402BF4C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_forecastViewModel;

		// Token: 0x0402BF4D RID: 180045
		[Token(Token = "0x402BF4D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_fragmentStorageViewModel;

		// Token: 0x0402BF4E RID: 180046
		[Token(Token = "0x402BF4E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_forecastStatus;

		// Token: 0x0402BF4F RID: 180047
		[Token(Token = "0x402BF4F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_forecastType;

		// Token: 0x0402BF50 RID: 180048
		[Token(Token = "0x402BF50")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BF51 RID: 180049
		[Token(Token = "0x402BF51")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_RefreshFragmentItemSelectStatus;

		// Token: 0x0402BF52 RID: 180050
		[Token(Token = "0x402BF52")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_TryUnloadSlotFragmentItem;

		// Token: 0x0402BF53 RID: 180051
		[Token(Token = "0x402BF53")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RefreshLeaveBtnStatus;

		// Token: 0x0402BF54 RID: 180052
		[Token(Token = "0x402BF54")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RefreshIsLeavingStatus;

		// Token: 0x0402BF55 RID: 180053
		[Token(Token = "0x402BF55")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RefreshViewStatus;

		// Token: 0x0402BF56 RID: 180054
		[Token(Token = "0x402BF56")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_RefreshDataAfterClaimAlchemyReward;

		// Token: 0x0402BF57 RID: 180055
		[Token(Token = "0x402BF57")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RefreshPlayerContent;

		// Token: 0x0402BF58 RID: 180056
		[Token(Token = "0x402BF58")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfCanStartAlchemy;

		// Token: 0x0402BF59 RID: 180057
		[Token(Token = "0x402BF59")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetSelectedFragmentInstIdList;

		// Token: 0x0402BF5A RID: 180058
		[Token(Token = "0x402BF5A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadInAlchemyPending;

		// Token: 0x0402BF5B RID: 180059
		[Token(Token = "0x402BF5B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__LoadInAlchemyRewardPending;

		// Token: 0x0402BF5C RID: 180060
		[Token(Token = "0x402BF5C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__LoadInternal;

		// Token: 0x0402BF5D RID: 180061
		[Token(Token = "0x402BF5D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CheckIfCanOperate;

		// Token: 0x0402BF5E RID: 180062
		[Token(Token = "0x402BF5E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GetMaxPoolRarity;

		// Token: 0x0402BF5F RID: 180063
		[Token(Token = "0x402BF5F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__RefreshPlayerAlchemyContent;

		// Token: 0x0402BF60 RID: 180064
		[Token(Token = "0x402BF60")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__RefreshPlayerAlchemyRewardContent;

		// Token: 0x0402BF61 RID: 180065
		[Token(Token = "0x402BF61")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__SelectFragmentItem;

		// Token: 0x0402BF62 RID: 180066
		[Token(Token = "0x402BF62")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__UnSelectFragmentItem;

		// Token: 0x0402BF63 RID: 180067
		[Token(Token = "0x402BF63")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__InitSlotListData;

		// Token: 0x0402BF64 RID: 180068
		[Token(Token = "0x402BF64")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ResetSlotListData;

		// Token: 0x0402BF65 RID: 180069
		[Token(Token = "0x402BF65")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__RefreshSlotItemData;

		// Token: 0x0402BF66 RID: 180070
		[Token(Token = "0x402BF66")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__TryGetSlotItemByFragmentInstId;

		// Token: 0x0402BF67 RID: 180071
		[Token(Token = "0x402BF67")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ResetSlotItem;

		// Token: 0x0402BF68 RID: 180072
		[Token(Token = "0x402BF68")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__TryGetFragmentItemViewModelByInstId;

		// Token: 0x0402BF69 RID: 180073
		[Token(Token = "0x402BF69")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GetFirstSlotItemCanBePut;

		// Token: 0x0402BF6A RID: 180074
		[Token(Token = "0x402BF6A")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__CheckIfSlotListFull;

		// Token: 0x0402BF6B RID: 180075
		[Token(Token = "0x402BF6B")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__RefreshSlotListStatus;

		// Token: 0x0402BF6C RID: 180076
		[Token(Token = "0x402BF6C")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__GetSlotFragmentIdList;

		// Token: 0x0402BF6D RID: 180077
		[Token(Token = "0x402BF6D")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__InitFragmentStorageData;

		// Token: 0x0402BF6E RID: 180078
		[Token(Token = "0x402BF6E")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__RefreshFragmentItemSelectState;

		// Token: 0x0402BF6F RID: 180079
		[Token(Token = "0x402BF6F")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__CheckIfFragmentIsSelected;

		// Token: 0x0402BF70 RID: 180080
		[Token(Token = "0x402BF70")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__RefreshFragmentStorageData;

		// Token: 0x0402BF71 RID: 180081
		[Token(Token = "0x402BF71")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__RefreshForecastData;

		// Token: 0x0402BF72 RID: 180082
		[Token(Token = "0x402BF72")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__RefreshForecastStatus;

		// Token: 0x0402BF73 RID: 180083
		[Token(Token = "0x402BF73")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__RefreshForecastType;

		// Token: 0x0402BF74 RID: 180084
		[Token(Token = "0x402BF74")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__TryGetAlchemyFormulationData;

		// Token: 0x0402BF75 RID: 180085
		[Token(Token = "0x402BF75")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__TryGetAlchemyRecipeData;

		// Token: 0x0402BF76 RID: 180086
		[Token(Token = "0x402BF76")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__TryGetOverrideAlchemyData;

		// Token: 0x0402BF77 RID: 180087
		[Token(Token = "0x402BF77")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__GetGameAlchemyContent;

		// Token: 0x0402BF78 RID: 180088
		[Token(Token = "0x402BF78")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__GetGameAlchemyRewardContent;

		// Token: 0x0402BF79 RID: 180089
		[Token(Token = "0x402BF79")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200566A RID: 22122
		[Token(Token = "0x200566A")]
		public enum ViewAlchemyStatus
		{
			// Token: 0x0402BF7B RID: 180091
			[Token(Token = "0x402BF7B")]
			NOT_MELD,
			// Token: 0x0402BF7C RID: 180092
			[Token(Token = "0x402BF7C")]
			MELDING,
			// Token: 0x0402BF7D RID: 180093
			[Token(Token = "0x402BF7D")]
			MELDED
		}

		// Token: 0x0200566B RID: 22123
		[Token(Token = "0x200566B")]
		public enum LeaveBtnStatus
		{
			// Token: 0x0402BF7F RID: 180095
			[Token(Token = "0x402BF7F")]
			CLOSE_STATE,
			// Token: 0x0402BF80 RID: 180096
			[Token(Token = "0x402BF80")]
			OPEN_STATE
		}
	}
}
