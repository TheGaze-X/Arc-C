using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AD1 RID: 23249
	[Token(Token = "0x2005AD1")]
	public class ShopGPCommonItemView : MonoBehaviour, IExposure, IHotfixable
	{
		// Token: 0x06021CAE RID: 138414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CAE")]
		[Address(RVA = "0x1C4BD10", Offset = "0x1C4A910", VA = "0x181C4BD10", Slot = "13")]
		public virtual void ApplyData(ShopGPCommonItemViewModel commonViewModel)
		{
		}

		// Token: 0x06021CAF RID: 138415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CAF")]
		[Address(RVA = "0x1C4D600", Offset = "0x1C4C200", VA = "0x181C4D600")]
		private void _ApplyGpTicketPart(ShopGPCommonItemViewModel viewModel)
		{
		}

		// Token: 0x06021CB0 RID: 138416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB0")]
		[Address(RVA = "0x1C4D6A0", Offset = "0x1C4C2A0", VA = "0x181C4D6A0")]
		private void _ApplyNormalPart(NormalGPItem obj, ShopCashInfo cashInfo)
		{
		}

		// Token: 0x06021CB1 RID: 138417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB1")]
		[Address(RVA = "0x1C4CD50", Offset = "0x1C4B950", VA = "0x181C4CD50")]
		private void _ApplyData(ShopGPChooseItemViewModel chooseViewModel)
		{
		}

		// Token: 0x06021CB2 RID: 138418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB2")]
		[Address(RVA = "0x1C4C9B0", Offset = "0x1C4B5B0", VA = "0x181C4C9B0")]
		private void _ApplyData(ShopGPCondTrigItemViewModel viewModel)
		{
		}

		// Token: 0x06021CB3 RID: 138419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB3")]
		[Address(RVA = "0x1C4C6D0", Offset = "0x1C4B2D0", VA = "0x181C4C6D0")]
		private void _ApplyData(ShopGPPeriodItemViewModel periodViewModel)
		{
		}

		// Token: 0x06021CB4 RID: 138420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB4")]
		[Address(RVA = "0x1C4D310", Offset = "0x1C4BF10", VA = "0x181C4D310")]
		private void _ApplyData(ShopGPOnceItemViewModel onceViewModel)
		{
		}

		// Token: 0x06021CB5 RID: 138421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB5")]
		[Address(RVA = "0x1C4D040", Offset = "0x1C4BC40", VA = "0x181C4D040")]
		private void _ApplyData(ShopGPLevelItemViewModel levelViewModel)
		{
		}

		// Token: 0x06021CB6 RID: 138422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB6")]
		[Address(RVA = "0x1C4DCA0", Offset = "0x1C4C8A0", VA = "0x181C4DCA0")]
		private void _OpenDetailEvent()
		{
		}

		// Token: 0x06021CB7 RID: 138423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB7")]
		[Address(RVA = "0x1C4DE50", Offset = "0x1C4CA50", VA = "0x181C4DE50")]
		private void _UpdateRemainCountInfo(ShopGPCommonItemViewModel commonViewModel)
		{
		}

		// Token: 0x06021CB8 RID: 138424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB8")]
		[Address(RVA = "0x1C4DFC0", Offset = "0x1C4CBC0", VA = "0x181C4DFC0")]
		private void _UpdateTrackPoint(ShopGPCommonItemViewModel commonViewModel)
		{
		}

		// Token: 0x06021CB9 RID: 138425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CB9")]
		[Address(RVA = "0x1C4DB90", Offset = "0x1C4C790", VA = "0x181C4DB90")]
		private void _OnExpose()
		{
		}

		// Token: 0x06021CBA RID: 138426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CBA")]
		[Address(RVA = "0x1C4C610", Offset = "0x1C4B210", VA = "0x181C4C610")]
		private void OnEnable()
		{
		}

		// Token: 0x06021CBB RID: 138427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CBB")]
		[Address(RVA = "0x1C4C550", Offset = "0x1C4B150", VA = "0x181C4C550")]
		private void OnDisable()
		{
		}

		// Token: 0x06021CBC RID: 138428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CBC")]
		[Address(RVA = "0x1C4C3E0", Offset = "0x1C4AFE0", VA = "0x181C4C3E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021CBD RID: 138429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CBD")]
		[Address(RVA = "0x1C4C2C0", Offset = "0x1C4AEC0", VA = "0x181C4C2C0")]
		public void EnterDetailEvent()
		{
		}

		// Token: 0x06021CBE RID: 138430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CBE")]
		[Address(RVA = "0x1C4C320", Offset = "0x1C4AF20", VA = "0x181C4C320")]
		public void OnClick()
		{
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x06021CBF RID: 138431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F1E")]
		public string exposureId
		{
			[Token(Token = "0x6021CBF")]
			[Address(RVA = "0x1C4E260", Offset = "0x1C4CE60", VA = "0x181C4E260", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x06021CC0 RID: 138432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F1F")]
		public Action onExpose
		{
			[Token(Token = "0x6021CC0")]
			[Address(RVA = "0x1C4E380", Offset = "0x1C4CF80", VA = "0x181C4E380", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x06021CC1 RID: 138433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F20")]
		public RectTransform exposureRectTransform
		{
			[Token(Token = "0x6021CC1")]
			[Address(RVA = "0x1C4E2F0", Offset = "0x1C4CEF0", VA = "0x181C4E2F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x06021CC2 RID: 138434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021CC3 RID: 138435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F21")]
		public Action<IExposure> registerExposure
		{
			[Token(Token = "0x6021CC2")]
			[Address(RVA = "0x1C4E430", Offset = "0x1C4D030", VA = "0x181C4E430", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021CC3")]
			[Address(RVA = "0x1C4E550", Offset = "0x1C4D150", VA = "0x181C4E550", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x06021CC4 RID: 138436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021CC5 RID: 138437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F22")]
		public Action<IExposure> unregisterExposure
		{
			[Token(Token = "0x6021CC4")]
			[Address(RVA = "0x1C4E4F0", Offset = "0x1C4D0F0", VA = "0x181C4E4F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021CC5")]
			[Address(RVA = "0x1C4E650", Offset = "0x1C4D250", VA = "0x181C4E650", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x06021CC6 RID: 138438 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021CC7 RID: 138439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F23")]
		public Action tickExposure
		{
			[Token(Token = "0x6021CC6")]
			[Address(RVA = "0x1C4E490", Offset = "0x1C4D090", VA = "0x181C4E490", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021CC7")]
			[Address(RVA = "0x1C4E5D0", Offset = "0x1C4D1D0", VA = "0x181C4E5D0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021CC8 RID: 138440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CC8")]
		[Address(RVA = "0x1C4E1F0", Offset = "0x1C4CDF0", VA = "0x181C4E1F0")]
		public ShopGPCommonItemView()
		{
		}

		// Token: 0x0402E414 RID: 189460
		[Token(Token = "0x402E414")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Text _displayName;

		// Token: 0x0402E415 RID: 189461
		[Token(Token = "0x402E415")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Text _endTimeText;

		// Token: 0x0402E416 RID: 189462
		[Token(Token = "0x402E416")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _soldOutPart;

		// Token: 0x0402E417 RID: 189463
		[Token(Token = "0x402E417")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected CanvasGroup _soldOutCanvas;

		// Token: 0x0402E418 RID: 189464
		[Token(Token = "0x402E418")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Text _offsetPercent;

		// Token: 0x0402E419 RID: 189465
		[Token(Token = "0x402E419")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected GameObject _offsetPart;

		// Token: 0x0402E41A RID: 189466
		[Token(Token = "0x402E41A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject _diamondPart;

		// Token: 0x0402E41B RID: 189467
		[Token(Token = "0x402E41B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected GameObject[] _cashPart;

		// Token: 0x0402E41C RID: 189468
		[Token(Token = "0x402E41C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected GameObject _freePart;

		// Token: 0x0402E41D RID: 189469
		[Token(Token = "0x402E41D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Text _diamondPrice;

		// Token: 0x0402E41E RID: 189470
		[Token(Token = "0x402E41E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Text _diamondOriginPrice;

		// Token: 0x0402E41F RID: 189471
		[Token(Token = "0x402E41F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GameObject _diamondOffsetPart;

		// Token: 0x0402E420 RID: 189472
		[Token(Token = "0x402E420")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Text[] _cashPrice;

		// Token: 0x0402E421 RID: 189473
		[Token(Token = "0x402E421")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Text[] _cashCurrency;

		// Token: 0x0402E422 RID: 189474
		[Token(Token = "0x402E422")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Text _cashOriginPrice;

		// Token: 0x0402E423 RID: 189475
		[Token(Token = "0x402E423")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected GameObject _cashOffsetPart;

		// Token: 0x0402E424 RID: 189476
		[Token(Token = "0x402E424")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Check In")]
		private GameObject _panelCheckIn;

		// Token: 0x0402E425 RID: 189477
		[Token(Token = "0x402E425")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Check In")]
		private Text _textCheckInProgress;

		// Token: 0x0402E426 RID: 189478
		[Token(Token = "0x402E426")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelGpTicket;

		// Token: 0x0402E427 RID: 189479
		[Token(Token = "0x402E427")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelNormalBuy;

		// Token: 0x0402E428 RID: 189480
		[Token(Token = "0x402E428")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0402E429 RID: 189481
		[Token(Token = "0x402E429")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _lockedText;

		// Token: 0x0402E42A RID: 189482
		[Token(Token = "0x402E42A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image _spriteImage;

		// Token: 0x0402E42B RID: 189483
		[Token(Token = "0x402E42B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Track Point")]
		private GameObject _trackPointPrefab;

		// Token: 0x0402E42C RID: 189484
		[Token(Token = "0x402E42C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Track Point")]
		private RectTransform _trackPointContainer;

		// Token: 0x0402E42D RID: 189485
		[Token(Token = "0x402E42D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E42E RID: 189486
		[Token(Token = "0x402E42E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E42F RID: 189487
		[Token(Token = "0x402E42F")]
		[FieldOffset(Offset = "0xF0")]
		private ShopGPCommonItemViewModel m_cacheViewModel;

		// Token: 0x0402E430 RID: 189488
		[Token(Token = "0x402E430")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject m_trackPointInst;

		// Token: 0x0402E431 RID: 189489
		[Token(Token = "0x402E431")]
		[FieldOffset(Offset = "0x100")]
		private long m_cacheEndTime;

		// Token: 0x0402E435 RID: 189493
		[Token(Token = "0x402E435")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E436 RID: 189494
		[Token(Token = "0x402E436")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyGpTicketPart;

		// Token: 0x0402E437 RID: 189495
		[Token(Token = "0x402E437")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyNormalPart;

		// Token: 0x0402E438 RID: 189496
		[Token(Token = "0x402E438")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyData;

		// Token: 0x0402E439 RID: 189497
		[Token(Token = "0x402E439")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1__ApplyData;

		// Token: 0x0402E43A RID: 189498
		[Token(Token = "0x402E43A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix2__ApplyData;

		// Token: 0x0402E43B RID: 189499
		[Token(Token = "0x402E43B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix3__ApplyData;

		// Token: 0x0402E43C RID: 189500
		[Token(Token = "0x402E43C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix4__ApplyData;

		// Token: 0x0402E43D RID: 189501
		[Token(Token = "0x402E43D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenDetailEvent;

		// Token: 0x0402E43E RID: 189502
		[Token(Token = "0x402E43E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRemainCountInfo;

		// Token: 0x0402E43F RID: 189503
		[Token(Token = "0x402E43F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x0402E440 RID: 189504
		[Token(Token = "0x402E440")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnExpose;

		// Token: 0x0402E441 RID: 189505
		[Token(Token = "0x402E441")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402E442 RID: 189506
		[Token(Token = "0x402E442")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402E443 RID: 189507
		[Token(Token = "0x402E443")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E444 RID: 189508
		[Token(Token = "0x402E444")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EnterDetailEvent;

		// Token: 0x0402E445 RID: 189509
		[Token(Token = "0x402E445")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E446 RID: 189510
		[Token(Token = "0x402E446")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_exposureId;

		// Token: 0x0402E447 RID: 189511
		[Token(Token = "0x402E447")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_onExpose;

		// Token: 0x0402E448 RID: 189512
		[Token(Token = "0x402E448")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_exposureRectTransform;

		// Token: 0x0402E449 RID: 189513
		[Token(Token = "0x402E449")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_registerExposure;

		// Token: 0x0402E44A RID: 189514
		[Token(Token = "0x402E44A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_registerExposure;

		// Token: 0x0402E44B RID: 189515
		[Token(Token = "0x402E44B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_unregisterExposure;

		// Token: 0x0402E44C RID: 189516
		[Token(Token = "0x402E44C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_unregisterExposure;

		// Token: 0x0402E44D RID: 189517
		[Token(Token = "0x402E44D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_tickExposure;

		// Token: 0x0402E44E RID: 189518
		[Token(Token = "0x402E44E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_tickExposure;

		// Token: 0x0402E44F RID: 189519
		[Token(Token = "0x402E44F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AD2 RID: 23250
		[Token(Token = "0x2005AD2")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<ShopGPCommonItemView>
		{
			// Token: 0x17004F24 RID: 20260
			// (get) Token: 0x06021CC9 RID: 138441 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06021CCA RID: 138442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004F24")]
			public ExposureTracker exposureTracker
			{
				[Token(Token = "0x6021CC9")]
				[Address(RVA = "0x1C57CA0", Offset = "0x1C568A0", VA = "0x181C57CA0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6021CCA")]
				[Address(RVA = "0x1C57D00", Offset = "0x1C56900", VA = "0x181C57D00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06021CCB RID: 138443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CCB")]
			[Address(RVA = "0x1C57BF0", Offset = "0x1C567F0", VA = "0x181C57BF0")]
			public VirtualView(ShopGPCommonItemViewModel viewModel, ShopGPCommonItemView prefab)
			{
			}

			// Token: 0x06021CCC RID: 138444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CCC")]
			[Address(RVA = "0x1C578C0", Offset = "0x1C564C0", VA = "0x181C578C0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06021CCD RID: 138445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021CCD")]
			[Address(RVA = "0x1C57AE0", Offset = "0x1C566E0", VA = "0x181C57AE0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06021CCE RID: 138446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021CCE")]
			[Address(RVA = "0x1C57640", Offset = "0x1C56240", VA = "0x181C57640", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06021CCF RID: 138447 RVA: 0x000BB4A0 File Offset: 0x000B96A0
			[Token(Token = "0x6021CCF")]
			[Address(RVA = "0x1C577F0", Offset = "0x1C563F0", VA = "0x181C577F0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402E450 RID: 189520
			[Token(Token = "0x402E450")]
			[FieldOffset(Offset = "0x20")]
			private ShopGPCommonItemViewModel m_viewModel;

			// Token: 0x0402E451 RID: 189521
			[Token(Token = "0x402E451")]
			[FieldOffset(Offset = "0x28")]
			private ShopGPCommonItemView m_prefab;

			// Token: 0x0402E453 RID: 189523
			[Token(Token = "0x402E453")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_exposureTracker;

			// Token: 0x0402E454 RID: 189524
			[Token(Token = "0x402E454")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_exposureTracker;

			// Token: 0x0402E455 RID: 189525
			[Token(Token = "0x402E455")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E456 RID: 189526
			[Token(Token = "0x402E456")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402E457 RID: 189527
			[Token(Token = "0x402E457")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402E458 RID: 189528
			[Token(Token = "0x402E458")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402E459 RID: 189529
			[Token(Token = "0x402E459")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
