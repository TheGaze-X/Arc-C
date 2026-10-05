using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A29 RID: 27177
	[Token(Token = "0x2006A29")]
	public class Main11RecordHomeView : DataBinder<Main11ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x06026D83 RID: 159107 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D84 RID: 159108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA8")]
		public Action<string> onBtnClicked
		{
			[Token(Token = "0x6026D83")]
			[Address(RVA = "0x21F0D50", Offset = "0x21EF950", VA = "0x1821F0D50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D84")]
			[Address(RVA = "0x21F0E30", Offset = "0x21EFA30", VA = "0x1821F0E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x06026D85 RID: 159109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D86 RID: 159110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA9")]
		public Action onAllRewardsClicked
		{
			[Token(Token = "0x6026D85")]
			[Address(RVA = "0x21F0CF0", Offset = "0x21EF8F0", VA = "0x1821F0CF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D86")]
			[Address(RVA = "0x21F0DB0", Offset = "0x21EF9B0", VA = "0x1821F0DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D87 RID: 159111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D87")]
		[Address(RVA = "0x21F07E0", Offset = "0x21EF3E0", VA = "0x1821F07E0", Slot = "7")]
		public override void OnValueChanged(Main11ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026D88 RID: 159112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D88")]
		[Address(RVA = "0x21F06D0", Offset = "0x21EF2D0", VA = "0x1821F06D0")]
		public void OnAllRewardsBtnClicked()
		{
		}

		// Token: 0x06026D89 RID: 159113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D89")]
		[Address(RVA = "0x21F0B50", Offset = "0x21EF750", VA = "0x1821F0B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D8A RID: 159114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D8A")]
		[Address(RVA = "0x21F0C80", Offset = "0x21EF880", VA = "0x1821F0C80")]
		public Main11RecordHomeView()
		{
		}

		// Token: 0x04036E7A RID: 224890
		[Token(Token = "0x4036E7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main11RecordHomeButtonView[] _buttonView;

		// Token: 0x04036E7B RID: 224891
		[Token(Token = "0x4036E7B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelHardStageBanned;

		// Token: 0x04036E7C RID: 224892
		[Token(Token = "0x4036E7C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04036E7D RID: 224893
		[Token(Token = "0x4036E7D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04036E7E RID: 224894
		[Token(Token = "0x4036E7E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04036E81 RID: 224897
		[Token(Token = "0x4036E81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnClicked;

		// Token: 0x04036E82 RID: 224898
		[Token(Token = "0x4036E82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnClicked;

		// Token: 0x04036E83 RID: 224899
		[Token(Token = "0x4036E83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onAllRewardsClicked;

		// Token: 0x04036E84 RID: 224900
		[Token(Token = "0x4036E84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onAllRewardsClicked;

		// Token: 0x04036E85 RID: 224901
		[Token(Token = "0x4036E85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036E86 RID: 224902
		[Token(Token = "0x4036E86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAllRewardsBtnClicked;

		// Token: 0x04036E87 RID: 224903
		[Token(Token = "0x4036E87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036E88 RID: 224904
		[Token(Token = "0x4036E88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
