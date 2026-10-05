using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FF4 RID: 16372
	[Token(Token = "0x2003FF4")]
	public class PCKeySettingCategoryPlugin : SettingCategoryPlugin, IHotfixable
	{
		// Token: 0x060195C1 RID: 103873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195C1")]
		[Address(RVA = "0x1213B10", Offset = "0x1212710", VA = "0x181213B10", Slot = "4")]
		public override void Init(SettingCategory category, Action<SettingCategory> onClicked)
		{
		}

		// Token: 0x060195C2 RID: 103874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195C2")]
		[Address(RVA = "0x1213A40", Offset = "0x1212640", VA = "0x181213A40", Slot = "5")]
		public override void ApplyState(bool isSelected)
		{
		}

		// Token: 0x060195C3 RID: 103875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195C3")]
		[Address(RVA = "0x1213BE0", Offset = "0x12127E0", VA = "0x181213BE0")]
		public PCKeySettingCategoryPlugin()
		{
		}

		// Token: 0x0401F8BD RID: 129213
		[Token(Token = "0x401F8BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0401F8BE RID: 129214
		[Token(Token = "0x401F8BE")]
		[FieldOffset(Offset = "0x20")]
		private TrackPointViewProperty m_property;

		// Token: 0x0401F8BF RID: 129215
		[Token(Token = "0x401F8BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F8C0 RID: 129216
		[Token(Token = "0x401F8C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401F8C1 RID: 129217
		[Token(Token = "0x401F8C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FF5 RID: 16373
		[Token(Token = "0x2003FF5")]
		public class TrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x060195C4 RID: 103876 RVA: 0x0009DD88 File Offset: 0x0009BF88
			// (set) Token: 0x060195C5 RID: 103877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C7E")]
			public bool isShow
			{
				[Token(Token = "0x60195C4")]
				[Address(RVA = "0x1227F90", Offset = "0x1226B90", VA = "0x181227F90", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60195C5")]
				[Address(RVA = "0x1227FF0", Offset = "0x1226BF0", VA = "0x181227FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060195C6 RID: 103878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195C6")]
			[Address(RVA = "0x1227E10", Offset = "0x1226A10", VA = "0x181227E10", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060195C7 RID: 103879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60195C7")]
			[Address(RVA = "0x1227F30", Offset = "0x1226B30", VA = "0x181227F30")]
			public TrackPointModel()
			{
			}

			// Token: 0x0401F8C3 RID: 129219
			[Token(Token = "0x401F8C3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0401F8C4 RID: 129220
			[Token(Token = "0x401F8C4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0401F8C5 RID: 129221
			[Token(Token = "0x401F8C5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0401F8C6 RID: 129222
			[Token(Token = "0x401F8C6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
