using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A1A RID: 27162
	[Token(Token = "0x2006A1A")]
	public class Main12RecordRewardBuffBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x06026D4A RID: 159050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D4B RID: 159051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA5")]
		public Action onTimeOut
		{
			[Token(Token = "0x6026D4A")]
			[Address(RVA = "0x21F94A0", Offset = "0x21F80A0", VA = "0x1821F94A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D4B")]
			[Address(RVA = "0x21F9500", Offset = "0x21F8100", VA = "0x1821F9500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D4C RID: 159052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D4C")]
		[Address(RVA = "0x21F8A90", Offset = "0x21F7690", VA = "0x1821F8A90")]
		public void Render(Main12RecordRewardBuffBtnView.Options options)
		{
		}

		// Token: 0x06026D4D RID: 159053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D4D")]
		[Address(RVA = "0x21F9180", Offset = "0x21F7D80", VA = "0x1821F9180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D4E RID: 159054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D4E")]
		[Address(RVA = "0x21F92F0", Offset = "0x21F7EF0", VA = "0x1821F92F0")]
		private void _OnTimeOut()
		{
		}

		// Token: 0x06026D4F RID: 159055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D4F")]
		[Address(RVA = "0x21F9000", Offset = "0x21F7C00", VA = "0x1821F9000")]
		public void ShowRewardBuffDialog()
		{
		}

		// Token: 0x06026D50 RID: 159056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D50")]
		[Address(RVA = "0x21F9430", Offset = "0x21F8030", VA = "0x1821F9430")]
		public Main12RecordRewardBuffBtnView()
		{
		}

		// Token: 0x04036E10 RID: 224784
		[Token(Token = "0x4036E10")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _timeContainer;

		// Token: 0x04036E11 RID: 224785
		[Token(Token = "0x4036E11")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _timeScaler;

		// Token: 0x04036E12 RID: 224786
		[Token(Token = "0x4036E12")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _back;

		// Token: 0x04036E13 RID: 224787
		[Token(Token = "0x4036E13")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _emptyAlphaBack;

		// Token: 0x04036E14 RID: 224788
		[Token(Token = "0x4036E14")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _newObj;

		// Token: 0x04036E15 RID: 224789
		[Token(Token = "0x4036E15")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightDescObj;

		// Token: 0x04036E16 RID: 224790
		[Token(Token = "0x4036E16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lightYellow;

		// Token: 0x04036E17 RID: 224791
		[Token(Token = "0x4036E17")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lightBlack;

		// Token: 0x04036E18 RID: 224792
		[Token(Token = "0x4036E18")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _todayCanUse;

		// Token: 0x04036E19 RID: 224793
		[Token(Token = "0x4036E19")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _todayNoUse;

		// Token: 0x04036E1A RID: 224794
		[Token(Token = "0x4036E1A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemNameDes;

		// Token: 0x04036E1B RID: 224795
		[Token(Token = "0x4036E1B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _arrow;

		// Token: 0x04036E1C RID: 224796
		[Token(Token = "0x4036E1C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _itemUseTimeNum;

		// Token: 0x04036E1D RID: 224797
		[Token(Token = "0x4036E1D")]
		[FieldOffset(Offset = "0x80")]
		private string m_itemId;

		// Token: 0x04036E1E RID: 224798
		[Token(Token = "0x4036E1E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04036E1F RID: 224799
		[Token(Token = "0x4036E1F")]
		[FieldOffset(Offset = "0x90")]
		private UIItemTimeCountDown m_timeOut;

		// Token: 0x04036E20 RID: 224800
		[Token(Token = "0x4036E20")]
		[FieldOffset(Offset = "0x98")]
		private ZoneRewardBuffViewModel m_cachedViewModel;

		// Token: 0x04036E21 RID: 224801
		[Token(Token = "0x4036E21")]
		[FieldOffset(Offset = "0xA0")]
		private Main12RecordRewardBuffBtnView.Options m_options;

		// Token: 0x04036E23 RID: 224803
		[Token(Token = "0x4036E23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTimeOut;

		// Token: 0x04036E24 RID: 224804
		[Token(Token = "0x4036E24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTimeOut;

		// Token: 0x04036E25 RID: 224805
		[Token(Token = "0x4036E25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036E26 RID: 224806
		[Token(Token = "0x4036E26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036E27 RID: 224807
		[Token(Token = "0x4036E27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTimeOut;

		// Token: 0x04036E28 RID: 224808
		[Token(Token = "0x4036E28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowRewardBuffDialog;

		// Token: 0x04036E29 RID: 224809
		[Token(Token = "0x4036E29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A1B RID: 27163
		[Token(Token = "0x2006A1B")]
		public class Options
		{
			// Token: 0x06026D51 RID: 159057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D51")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04036E2A RID: 224810
			[Token(Token = "0x4036E2A")]
			[FieldOffset(Offset = "0x10")]
			public bool isOnStage;

			// Token: 0x04036E2B RID: 224811
			[Token(Token = "0x4036E2B")]
			[FieldOffset(Offset = "0x18")]
			public ZoneRewardBuffViewModel viewModel;
		}
	}
}
