using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200668C RID: 26252
	[Token(Token = "0x200668C")]
	[RequireComponent(typeof(Animator))]
	public class HandBookButtonTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700594E RID: 22862
		// (set) Token: 0x06025B3C RID: 154428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700594E")]
		private int m_state
		{
			[Token(Token = "0x6025B3C")]
			[Address(RVA = "0x208EF60", Offset = "0x208DB60", VA = "0x18208EF60")]
			set
			{
			}
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x06025B3D RID: 154429 RVA: 0x000C8C88 File Offset: 0x000C6E88
		// (set) Token: 0x06025B3E RID: 154430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700594F")]
		public bool isFast
		{
			[Token(Token = "0x6025B3D")]
			[Address(RVA = "0x208EAB0", Offset = "0x208D6B0", VA = "0x18208EAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025B3E")]
			[Address(RVA = "0x208ECC0", Offset = "0x208D8C0", VA = "0x18208ECC0")]
			set
			{
			}
		}

		// Token: 0x17005950 RID: 22864
		// (set) Token: 0x06025B3F RID: 154431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005950")]
		private int m_posID
		{
			[Token(Token = "0x6025B3F")]
			[Address(RVA = "0x208ED60", Offset = "0x208D960", VA = "0x18208ED60")]
			set
			{
			}
		}

		// Token: 0x06025B40 RID: 154432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B40")]
		[Address(RVA = "0x208DB30", Offset = "0x208C730", VA = "0x18208DB30", Slot = "4")]
		public virtual void Render(HandBookInfoStateBean.HandBookInfoViewModel viewModel)
		{
		}

		// Token: 0x06025B41 RID: 154433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B41")]
		[Address(RVA = "0x208E960", Offset = "0x208D560", VA = "0x18208E960")]
		private void OnEnable()
		{
		}

		// Token: 0x06025B42 RID: 154434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B42")]
		[Address(RVA = "0x208EBE0", Offset = "0x208D7E0", VA = "0x18208EBE0")]
		public void onState(int selectedID)
		{
		}

		// Token: 0x06025B43 RID: 154435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B43")]
		[Address(RVA = "0x208EB10", Offset = "0x208D710", VA = "0x18208EB10")]
		public void onClick()
		{
		}

		// Token: 0x06025B44 RID: 154436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B44")]
		[Address(RVA = "0x208EA50", Offset = "0x208D650", VA = "0x18208EA50")]
		public HandBookButtonTab()
		{
		}

		// Token: 0x04034F6F RID: 216943
		[Token(Token = "0x4034F6F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookInfoView _parentView;

		// Token: 0x04034F70 RID: 216944
		[Token(Token = "0x4034F70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _initPos;

		// Token: 0x04034F71 RID: 216945
		[Token(Token = "0x4034F71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _tabState;

		// Token: 0x04034F72 RID: 216946
		[Token(Token = "0x4034F72")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _availToggle;

		// Token: 0x04034F73 RID: 216947
		[Token(Token = "0x4034F73")]
		[FieldOffset(Offset = "0x38")]
		private float m_currentPos;

		// Token: 0x04034F74 RID: 216948
		[Token(Token = "0x4034F74")]
		private const string ISFAST_PARAM = "isFast";

		// Token: 0x04034F75 RID: 216949
		[Token(Token = "0x4034F75")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_finder;

		// Token: 0x04034F76 RID: 216950
		[Token(Token = "0x4034F76")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isFast;

		// Token: 0x04034F77 RID: 216951
		[Token(Token = "0x4034F77")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_posTween;

		// Token: 0x04034F78 RID: 216952
		[Token(Token = "0x4034F78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_m_state;

		// Token: 0x04034F79 RID: 216953
		[Token(Token = "0x4034F79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isFast;

		// Token: 0x04034F7A RID: 216954
		[Token(Token = "0x4034F7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isFast;

		// Token: 0x04034F7B RID: 216955
		[Token(Token = "0x4034F7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_m_posID;

		// Token: 0x04034F7C RID: 216956
		[Token(Token = "0x4034F7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034F7D RID: 216957
		[Token(Token = "0x4034F7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04034F7E RID: 216958
		[Token(Token = "0x4034F7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_onState;

		// Token: 0x04034F7F RID: 216959
		[Token(Token = "0x4034F7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_onClick;

		// Token: 0x04034F80 RID: 216960
		[Token(Token = "0x4034F80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
