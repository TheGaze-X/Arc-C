using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003923 RID: 14627
	[Token(Token = "0x2003923")]
	public class UISliderPager : MonoBehaviour, IHotfixable, ITimeWatcher
	{
		// Token: 0x060171ED RID: 94701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171ED")]
		[Address(RVA = "0xF989C0", Offset = "0xF975C0", VA = "0x180F989C0")]
		private void OnEnable()
		{
		}

		// Token: 0x060171EE RID: 94702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171EE")]
		[Address(RVA = "0xF98960", Offset = "0xF97560", VA = "0x180F98960")]
		private void OnDisable()
		{
		}

		// Token: 0x060171EF RID: 94703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171EF")]
		[Address(RVA = "0xF98C00", Offset = "0xF97800", VA = "0x180F98C00", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x060171F0 RID: 94704 RVA: 0x00094E48 File Offset: 0x00093048
		[Token(Token = "0x17003738")]
		public UISliderPager.State currentState
		{
			[Token(Token = "0x60171F0")]
			[Address(RVA = "0xF99A90", Offset = "0xF98690", VA = "0x180F99A90")]
			get
			{
				return UISliderPager.State.IDLE;
			}
		}

		// Token: 0x060171F1 RID: 94705 RVA: 0x00094E60 File Offset: 0x00093060
		[Token(Token = "0x60171F1")]
		[Address(RVA = "0xF98800", Offset = "0xF97400", VA = "0x180F98800")]
		public bool IsAutoPaging()
		{
			return default(bool);
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x060171F2 RID: 94706 RVA: 0x00094E78 File Offset: 0x00093078
		// (set) Token: 0x060171F3 RID: 94707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003739")]
		public int pageCount
		{
			[Token(Token = "0x60171F2")]
			[Address(RVA = "0xF99AF0", Offset = "0xF986F0", VA = "0x180F99AF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60171F3")]
			[Address(RVA = "0xF99BF0", Offset = "0xF987F0", VA = "0x180F99BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x060171F4 RID: 94708 RVA: 0x00094E90 File Offset: 0x00093090
		// (set) Token: 0x060171F5 RID: 94709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700373A")]
		public int currentPage
		{
			[Token(Token = "0x60171F4")]
			[Address(RVA = "0xF99A30", Offset = "0xF98630", VA = "0x180F99A30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60171F5")]
			[Address(RVA = "0xF99B50", Offset = "0xF98750", VA = "0x180F99B50")]
			set
			{
			}
		}

		// Token: 0x060171F6 RID: 94710 RVA: 0x00094EA8 File Offset: 0x000930A8
		[Token(Token = "0x60171F6")]
		[Address(RVA = "0xF98620", Offset = "0xF97220", VA = "0x180F98620")]
		public float GetDisplayPageIndex()
		{
			return 0f;
		}

		// Token: 0x060171F7 RID: 94711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171F7")]
		[Address(RVA = "0xF988C0", Offset = "0xF974C0", VA = "0x180F988C0")]
		public void MoveToPage(int pageIndex)
		{
		}

		// Token: 0x060171F8 RID: 94712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171F8")]
		[Address(RVA = "0xF986C0", Offset = "0xF972C0", VA = "0x180F986C0")]
		public void Init(UISliderPager.InitOptions callbacks)
		{
		}

		// Token: 0x060171F9 RID: 94713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171F9")]
		[Address(RVA = "0xF98AA0", Offset = "0xF976A0", VA = "0x180F98AA0")]
		public void SetScrollEffect(ViewPagerUtils.ScrollEffectConfig config)
		{
		}

		// Token: 0x060171FA RID: 94714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171FA")]
		[Address(RVA = "0xF98550", Offset = "0xF97150", VA = "0x180F98550")]
		public void ChangePageCount(int pageCount)
		{
		}

		// Token: 0x060171FB RID: 94715 RVA: 0x00094EC0 File Offset: 0x000930C0
		[Token(Token = "0x60171FB")]
		[Address(RVA = "0xF98860", Offset = "0xF97460", VA = "0x180F98860")]
		public static bool IsScrollStableState(UISliderPager.State state)
		{
			return default(bool);
		}

		// Token: 0x060171FC RID: 94716 RVA: 0x00094ED8 File Offset: 0x000930D8
		[Token(Token = "0x60171FC")]
		[Address(RVA = "0xF99640", Offset = "0xF98240", VA = "0x180F99640")]
		private float _Value2PageIndex(float value)
		{
			return 0f;
		}

		// Token: 0x060171FD RID: 94717 RVA: 0x00094EF0 File Offset: 0x000930F0
		[Token(Token = "0x60171FD")]
		[Address(RVA = "0xF99210", Offset = "0xF97E10", VA = "0x180F99210")]
		private float _PageIndex2Value(float index)
		{
			return 0f;
		}

		// Token: 0x060171FE RID: 94718 RVA: 0x00094F08 File Offset: 0x00093108
		[Token(Token = "0x60171FE")]
		[Address(RVA = "0xF99780", Offset = "0xF98380", VA = "0x180F99780")]
		private int _ValueAlignToPage(float value)
		{
			return 0;
		}

		// Token: 0x060171FF RID: 94719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171FF")]
		[Address(RVA = "0xF99340", Offset = "0xF97F40", VA = "0x180F99340")]
		private void _SwitchToPage(int target, bool useTween)
		{
		}

		// Token: 0x06017200 RID: 94720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017200")]
		[Address(RVA = "0xF98F20", Offset = "0xF97B20", VA = "0x180F98F20")]
		private void _AutoAlign()
		{
		}

		// Token: 0x06017201 RID: 94721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017201")]
		[Address(RVA = "0xF990E0", Offset = "0xF97CE0", VA = "0x180F990E0")]
		private void _OnStateChanged(UISliderPager.State from, UISliderPager.State to)
		{
		}

		// Token: 0x06017202 RID: 94722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017202")]
		[Address(RVA = "0xF998B0", Offset = "0xF984B0", VA = "0x180F998B0")]
		public UISliderPager()
		{
		}

		// Token: 0x0401BE94 RID: 114324
		[Token(Token = "0x401BE94")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIWrappedSlider _slider;

		// Token: 0x0401BE95 RID: 114325
		[Token(Token = "0x401BE95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _alignDuration;

		// Token: 0x0401BE96 RID: 114326
		[Token(Token = "0x401BE96")]
		[FieldOffset(Offset = "0x24")]
		private UISliderPager.State m_state;

		// Token: 0x0401BE97 RID: 114327
		[Token(Token = "0x401BE97")]
		[FieldOffset(Offset = "0x28")]
		private float m_pageUpdatingCacheValue;

		// Token: 0x0401BE98 RID: 114328
		[Token(Token = "0x401BE98")]
		[FieldOffset(Offset = "0x30")]
		private UISliderPager.InitOptions m_options;

		// Token: 0x0401BE99 RID: 114329
		[Token(Token = "0x401BE99")]
		[FieldOffset(Offset = "0x50")]
		private int m_currentPage;

		// Token: 0x0401BE9A RID: 114330
		[Token(Token = "0x401BE9A")]
		[FieldOffset(Offset = "0x58")]
		private TweenUtils.SmoothStep m_alignTween;

		// Token: 0x0401BE9B RID: 114331
		[Token(Token = "0x401BE9B")]
		[FieldOffset(Offset = "0x90")]
		private LatchUtils.InvokeWhenUnlock m_startUpdateWhenInited;

		// Token: 0x0401BE9C RID: 114332
		[Token(Token = "0x401BE9C")]
		[FieldOffset(Offset = "0x98")]
		private ViewPagerUtils.ScrollEffectTrigger m_effectTrigger;

		// Token: 0x0401BE9E RID: 114334
		[Token(Token = "0x401BE9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401BE9F RID: 114335
		[Token(Token = "0x401BE9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401BEA0 RID: 114336
		[Token(Token = "0x401BEA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401BEA1 RID: 114337
		[Token(Token = "0x401BEA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x0401BEA2 RID: 114338
		[Token(Token = "0x401BEA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsAutoPaging;

		// Token: 0x0401BEA3 RID: 114339
		[Token(Token = "0x401BEA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pageCount;

		// Token: 0x0401BEA4 RID: 114340
		[Token(Token = "0x401BEA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_pageCount;

		// Token: 0x0401BEA5 RID: 114341
		[Token(Token = "0x401BEA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentPage;

		// Token: 0x0401BEA6 RID: 114342
		[Token(Token = "0x401BEA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_currentPage;

		// Token: 0x0401BEA7 RID: 114343
		[Token(Token = "0x401BEA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetDisplayPageIndex;

		// Token: 0x0401BEA8 RID: 114344
		[Token(Token = "0x401BEA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_MoveToPage;

		// Token: 0x0401BEA9 RID: 114345
		[Token(Token = "0x401BEA9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401BEAA RID: 114346
		[Token(Token = "0x401BEAA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetScrollEffect;

		// Token: 0x0401BEAB RID: 114347
		[Token(Token = "0x401BEAB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ChangePageCount;

		// Token: 0x0401BEAC RID: 114348
		[Token(Token = "0x401BEAC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsScrollStableState;

		// Token: 0x0401BEAD RID: 114349
		[Token(Token = "0x401BEAD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__Value2PageIndex;

		// Token: 0x0401BEAE RID: 114350
		[Token(Token = "0x401BEAE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PageIndex2Value;

		// Token: 0x0401BEAF RID: 114351
		[Token(Token = "0x401BEAF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ValueAlignToPage;

		// Token: 0x0401BEB0 RID: 114352
		[Token(Token = "0x401BEB0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwitchToPage;

		// Token: 0x0401BEB1 RID: 114353
		[Token(Token = "0x401BEB1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__AutoAlign;

		// Token: 0x0401BEB2 RID: 114354
		[Token(Token = "0x401BEB2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x0401BEB3 RID: 114355
		[Token(Token = "0x401BEB3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003924 RID: 14628
		[Token(Token = "0x2003924")]
		public enum State
		{
			// Token: 0x0401BEB5 RID: 114357
			[Token(Token = "0x401BEB5")]
			IDLE,
			// Token: 0x0401BEB6 RID: 114358
			[Token(Token = "0x401BEB6")]
			DRAGING,
			// Token: 0x0401BEB7 RID: 114359
			[Token(Token = "0x401BEB7")]
			ALIGNING
		}

		// Token: 0x02003925 RID: 14629
		[Token(Token = "0x2003925")]
		public struct InitOptions
		{
			// Token: 0x0401BEB8 RID: 114360
			[Token(Token = "0x401BEB8")]
			[FieldOffset(Offset = "0x0")]
			public int pageCount;

			// Token: 0x0401BEB9 RID: 114361
			[Token(Token = "0x401BEB9")]
			[FieldOffset(Offset = "0x8")]
			public Action<UISliderPager.State> onStateChanged;

			// Token: 0x0401BEBA RID: 114362
			[Token(Token = "0x401BEBA")]
			[FieldOffset(Offset = "0x10")]
			public Action<int> onPageIndexChanged;

			// Token: 0x0401BEBB RID: 114363
			[Token(Token = "0x401BEBB")]
			[FieldOffset(Offset = "0x18")]
			public Action<float> onPageUpdating;
		}

		// Token: 0x02003926 RID: 14630
		[Token(Token = "0x2003926")]
		public struct EffectConfig
		{
			// Token: 0x0401BEBC RID: 114364
			[Token(Token = "0x401BEBC")]
			[FieldOffset(Offset = "0x0")]
			public Action onScrollToItem;

			// Token: 0x0401BEBD RID: 114365
			[Token(Token = "0x401BEBD")]
			[FieldOffset(Offset = "0x8")]
			public Action onAlignToItem;
		}
	}
}
