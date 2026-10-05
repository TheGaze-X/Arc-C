using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067B9 RID: 26553
	[Token(Token = "0x20067B9")]
	public class StageZoneHomeRecentView : DataBinder<ZoneHomeRecentViewProp>
	{
		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x06026142 RID: 155970 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026143 RID: 155971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0F")]
		public Action onClick
		{
			[Token(Token = "0x6026142")]
			[Address(RVA = "0x2123490", Offset = "0x2122090", VA = "0x182123490")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026143")]
			[Address(RVA = "0x21234F0", Offset = "0x21220F0", VA = "0x1821234F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026144 RID: 155972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026144")]
		[Address(RVA = "0x2122D40", Offset = "0x2121940", VA = "0x182122D40", Slot = "7")]
		public override void OnValueChanged(ZoneHomeRecentViewProp property)
		{
		}

		// Token: 0x06026145 RID: 155973 RVA: 0x000C9E70 File Offset: 0x000C8070
		[Token(Token = "0x6026145")]
		[Address(RVA = "0x2122E70", Offset = "0x2121A70", VA = "0x182122E70")]
		private bool _CheckIfDirty(ZoneHomeRecentViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06026146 RID: 155974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026146")]
		[Address(RVA = "0x21230D0", Offset = "0x2121CD0", VA = "0x1821230D0")]
		private void _Render(ZoneHomeRecentViewModel viewModel)
		{
		}

		// Token: 0x06026147 RID: 155975 RVA: 0x000C9E88 File Offset: 0x000C8088
		[Token(Token = "0x6026147")]
		[Address(RVA = "0x2122F20", Offset = "0x2121B20", VA = "0x182122F20")]
		private StageZoneHomeRecentView.TypeConfig _GetTypeConfig(HomeRecentStageType type)
		{
			return default(StageZoneHomeRecentView.TypeConfig);
		}

		// Token: 0x06026148 RID: 155976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026148")]
		[Address(RVA = "0x2122C30", Offset = "0x2121830", VA = "0x182122C30")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06026149 RID: 155977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026149")]
		[Address(RVA = "0x2123420", Offset = "0x2122020", VA = "0x182123420")]
		public StageZoneHomeRecentView()
		{
		}

		// Token: 0x04035980 RID: 219520
		[Token(Token = "0x4035980")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textType;

		// Token: 0x04035981 RID: 219521
		[Token(Token = "0x4035981")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgType;

		// Token: 0x04035982 RID: 219522
		[Token(Token = "0x4035982")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x04035983 RID: 219523
		[Token(Token = "0x4035983")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04035984 RID: 219524
		[Token(Token = "0x4035984")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelStage;

		// Token: 0x04035985 RID: 219525
		[Token(Token = "0x4035985")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<StageZoneHomeRecentView.TypeConfig> _typeConfigs;

		// Token: 0x04035986 RID: 219526
		[Token(Token = "0x4035986")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedStageId;

		// Token: 0x04035988 RID: 219528
		[Token(Token = "0x4035988")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04035989 RID: 219529
		[Token(Token = "0x4035989")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403598A RID: 219530
		[Token(Token = "0x403598A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403598B RID: 219531
		[Token(Token = "0x403598B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfDirty;

		// Token: 0x0403598C RID: 219532
		[Token(Token = "0x403598C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403598D RID: 219533
		[Token(Token = "0x403598D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTypeConfig;

		// Token: 0x0403598E RID: 219534
		[Token(Token = "0x403598E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403598F RID: 219535
		[Token(Token = "0x403598F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067BA RID: 26554
		[Token(Token = "0x20067BA")]
		[Serializable]
		private struct TypeConfig
		{
			// Token: 0x04035990 RID: 219536
			[Token(Token = "0x4035990")]
			[FieldOffset(Offset = "0x0")]
			public Color color;

			// Token: 0x04035991 RID: 219537
			[Token(Token = "0x4035991")]
			[FieldOffset(Offset = "0x10")]
			public Color text;

			// Token: 0x04035992 RID: 219538
			[Token(Token = "0x4035992")]
			[FieldOffset(Offset = "0x20")]
			public HomeRecentStageType type;
		}
	}
}
