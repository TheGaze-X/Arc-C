using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B7A RID: 27514
	[Token(Token = "0x2006B7A")]
	public class ArchiveEndbookListDataBinder : DataBinder<EndbookProperty>
	{
		// Token: 0x17005CDE RID: 23774
		// (get) Token: 0x06027501 RID: 161025 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027502 RID: 161026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CDE")]
		public ActArchiveController controller
		{
			[Token(Token = "0x6027501")]
			[Address(RVA = "0x2280E30", Offset = "0x227FA30", VA = "0x182280E30")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027502")]
			[Address(RVA = "0x2280E90", Offset = "0x227FA90", VA = "0x182280E90")]
			set
			{
			}
		}

		// Token: 0x06027503 RID: 161027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027503")]
		[Address(RVA = "0x2280100", Offset = "0x227ED00", VA = "0x182280100", Slot = "7")]
		public override void OnValueChanged(EndbookProperty property)
		{
		}

		// Token: 0x06027504 RID: 161028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027504")]
		[Address(RVA = "0x22806F0", Offset = "0x227F2F0", VA = "0x1822806F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027505 RID: 161029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027505")]
		[Address(RVA = "0x2280CC0", Offset = "0x227F8C0", VA = "0x182280CC0")]
		private void _PlaySwitchAnim()
		{
		}

		// Token: 0x06027506 RID: 161030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027506")]
		[Address(RVA = "0x22809B0", Offset = "0x227F5B0", VA = "0x1822809B0")]
		private void _OnIndexUpdate(int index)
		{
		}

		// Token: 0x06027507 RID: 161031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027507")]
		[Address(RVA = "0x2280DB0", Offset = "0x227F9B0", VA = "0x182280DB0")]
		public ArchiveEndbookListDataBinder()
		{
		}

		// Token: 0x04037AD7 RID: 228055
		[Token(Token = "0x4037AD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveEndbookEntryPickerView _pickerView;

		// Token: 0x04037AD8 RID: 228056
		[Token(Token = "0x4037AD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _blurbg;

		// Token: 0x04037AD9 RID: 228057
		[Token(Token = "0x4037AD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedBg;

		// Token: 0x04037ADA RID: 228058
		[Token(Token = "0x4037ADA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _circleContent;

		// Token: 0x04037ADB RID: 228059
		[Token(Token = "0x4037ADB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _switchAnimLocation;

		// Token: 0x04037ADC RID: 228060
		[Token(Token = "0x4037ADC")]
		[FieldOffset(Offset = "0x50")]
		private ActArchiveController m_controller;

		// Token: 0x04037ADD RID: 228061
		[Token(Token = "0x4037ADD")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04037ADE RID: 228062
		[Token(Token = "0x4037ADE")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedIndex;

		// Token: 0x04037ADF RID: 228063
		[Token(Token = "0x4037ADF")]
		[FieldOffset(Offset = "0x60")]
		private ArchiveEndbookListDataBinder.CircleAdapter m_circleAdapter;

		// Token: 0x04037AE0 RID: 228064
		[Token(Token = "0x4037AE0")]
		[FieldOffset(Offset = "0x68")]
		private EndbookModel m_cachedViewModel;

		// Token: 0x04037AE1 RID: 228065
		[Token(Token = "0x4037AE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037AE2 RID: 228066
		[Token(Token = "0x4037AE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037AE3 RID: 228067
		[Token(Token = "0x4037AE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037AE4 RID: 228068
		[Token(Token = "0x4037AE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037AE5 RID: 228069
		[Token(Token = "0x4037AE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnim;

		// Token: 0x04037AE6 RID: 228070
		[Token(Token = "0x4037AE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnIndexUpdate;

		// Token: 0x04037AE7 RID: 228071
		[Token(Token = "0x4037AE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B7B RID: 27515
		[Token(Token = "0x2006B7B")]
		public class EndItemViewModel
		{
			// Token: 0x06027508 RID: 161032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027508")]
			[Address(RVA = "0x22880A0", Offset = "0x2286CA0", VA = "0x1822880A0")]
			public void LoadData(EndbookProxy proxy, string Id, ArchiveEndbookEndModel endModel)
			{
			}

			// Token: 0x06027509 RID: 161033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027509")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EndItemViewModel()
			{
			}

			// Token: 0x04037AE8 RID: 228072
			[Token(Token = "0x4037AE8")]
			[FieldOffset(Offset = "0x10")]
			public string endId;

			// Token: 0x04037AE9 RID: 228073
			[Token(Token = "0x4037AE9")]
			[FieldOffset(Offset = "0x18")]
			public Sprite endCard;

			// Token: 0x04037AEA RID: 228074
			[Token(Token = "0x4037AEA")]
			[FieldOffset(Offset = "0x20")]
			public Sprite cardTitle;

			// Token: 0x04037AEB RID: 228075
			[Token(Token = "0x4037AEB")]
			[FieldOffset(Offset = "0x28")]
			public float collectPercent;

			// Token: 0x04037AEC RID: 228076
			[Token(Token = "0x4037AEC")]
			[FieldOffset(Offset = "0x2C")]
			public bool hasNew;

			// Token: 0x04037AED RID: 228077
			[Token(Token = "0x4037AED")]
			[FieldOffset(Offset = "0x2D")]
			public bool unlocked;
		}

		// Token: 0x02006B7C RID: 27516
		[Token(Token = "0x2006B7C")]
		public class CircleAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602750A RID: 161034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602750A")]
			[Address(RVA = "0x2286BA0", Offset = "0x22857A0", VA = "0x182286BA0")]
			public CircleAdapter(ArchiveEndbookListDataBinder closure)
			{
			}

			// Token: 0x17005CDF RID: 23775
			// (get) Token: 0x0602750B RID: 161035 RVA: 0x000CDFC8 File Offset: 0x000CC1C8
			[Token(Token = "0x17005CDF")]
			public override int count
			{
				[Token(Token = "0x602750B")]
				[Address(RVA = "0x2286C20", Offset = "0x2285820", VA = "0x182286C20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602750C RID: 161036 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602750C")]
			[Address(RVA = "0x22869C0", Offset = "0x22855C0", VA = "0x1822869C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037AEE RID: 228078
			[Token(Token = "0x4037AEE")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveEndbookListDataBinder m_closure;

			// Token: 0x04037AEF RID: 228079
			[Token(Token = "0x4037AEF")]
			[FieldOffset(Offset = "0x28")]
			public int circleCount;

			// Token: 0x04037AF0 RID: 228080
			[Token(Token = "0x4037AF0")]
			[FieldOffset(Offset = "0x2C")]
			public int selectedIndex;

			// Token: 0x04037AF1 RID: 228081
			[Token(Token = "0x4037AF1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037AF2 RID: 228082
			[Token(Token = "0x4037AF2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037AF3 RID: 228083
			[Token(Token = "0x4037AF3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
