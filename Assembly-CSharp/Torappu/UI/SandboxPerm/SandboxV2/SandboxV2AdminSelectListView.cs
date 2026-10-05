using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200404B RID: 16459
	[Token(Token = "0x200404B")]
	public class SandboxV2AdminSelectListView : DataBinder<SandboxV2CharListProperty>, IHotfixable
	{
		// Token: 0x06019767 RID: 104295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019767")]
		[Address(RVA = "0x1233270", Offset = "0x1231E70", VA = "0x181233270")]
		public void InitWithHolder(SandboxV2AdminCharSelectStateMode mode, ILoadAsset loadAsset)
		{
		}

		// Token: 0x06019768 RID: 104296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019768")]
		[Address(RVA = "0x12330D0", Offset = "0x1231CD0", VA = "0x1812330D0")]
		public void FocusOnInit(int focusIndex, int allCount)
		{
		}

		// Token: 0x06019769 RID: 104297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019769")]
		[Address(RVA = "0x12336B0", Offset = "0x12322B0", VA = "0x1812336B0", Slot = "7")]
		public override void OnValueChanged(SandboxV2CharListProperty property)
		{
		}

		// Token: 0x0601976A RID: 104298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601976A")]
		[Address(RVA = "0x1233B60", Offset = "0x1232760", VA = "0x181233B60")]
		private void _TryToSwitchPopView(SandboxV2CharListViewModel charListViewModel, bool isShow)
		{
		}

		// Token: 0x0601976B RID: 104299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601976B")]
		[Address(RVA = "0x1233E50", Offset = "0x1232A50", VA = "0x181233E50")]
		public SandboxV2AdminSelectListView()
		{
		}

		// Token: 0x0401FB6F RID: 129903
		[Token(Token = "0x401FB6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _leftContainer;

		// Token: 0x0401FB70 RID: 129904
		[Token(Token = "0x401FB70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _adatperContainer;

		// Token: 0x0401FB71 RID: 129905
		[Token(Token = "0x401FB71")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2AdminCharSelectAbstractLeftView m_leftView;

		// Token: 0x0401FB72 RID: 129906
		[Token(Token = "0x401FB72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _shuffleContainer;

		// Token: 0x0401FB73 RID: 129907
		[Token(Token = "0x401FB73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _ensureContainer;

		// Token: 0x0401FB74 RID: 129908
		[Token(Token = "0x401FB74")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _popContainer;

		// Token: 0x0401FB75 RID: 129909
		[Token(Token = "0x401FB75")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _noCharPrefab;

		// Token: 0x0401FB76 RID: 129910
		[Token(Token = "0x401FB76")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2AdminCharSelectStateMode m_charSelectMode;

		// Token: 0x0401FB77 RID: 129911
		[Token(Token = "0x401FB77")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2AdminCharAbstractShuffleView m_shuffleView;

		// Token: 0x0401FB78 RID: 129912
		[Token(Token = "0x401FB78")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2AdminCharAbstractEnsureView m_ensureView;

		// Token: 0x0401FB79 RID: 129913
		[Token(Token = "0x401FB79")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2AdminCharSelectAbstractPopView m_popView;

		// Token: 0x0401FB7A RID: 129914
		[Token(Token = "0x401FB7A")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2AdminCharSelectRecycleAdapter m_recycleAdapter;

		// Token: 0x0401FB7B RID: 129915
		[Token(Token = "0x401FB7B")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2CharSelectCharCardType m_cardType;

		// Token: 0x0401FB7C RID: 129916
		[Token(Token = "0x401FB7C")]
		[FieldOffset(Offset = "0x84")]
		private SandboxV2AdminCharSelectStateMode m_cacheMode;

		// Token: 0x0401FB7D RID: 129917
		[Token(Token = "0x401FB7D")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FB7E RID: 129918
		[Token(Token = "0x401FB7E")]
		private const int VER_LINE_PER = 4;

		// Token: 0x0401FB7F RID: 129919
		[Token(Token = "0x401FB7F")]
		private const int ADAPTER_START = 3;

		// Token: 0x0401FB80 RID: 129920
		[Token(Token = "0x401FB80")]
		[FieldOffset(Offset = "0x98")]
		private int m_focusSeq;

		// Token: 0x0401FB81 RID: 129921
		[Token(Token = "0x401FB81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitWithHolder;

		// Token: 0x0401FB82 RID: 129922
		[Token(Token = "0x401FB82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FocusOnInit;

		// Token: 0x0401FB83 RID: 129923
		[Token(Token = "0x401FB83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FB84 RID: 129924
		[Token(Token = "0x401FB84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryToSwitchPopView;

		// Token: 0x0401FB85 RID: 129925
		[Token(Token = "0x401FB85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
