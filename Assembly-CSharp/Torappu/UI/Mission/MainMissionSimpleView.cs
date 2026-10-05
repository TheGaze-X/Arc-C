using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004891 RID: 18577
	[Token(Token = "0x2004891")]
	public class MainMissionSimpleView : MissionSinglePage
	{
		// Token: 0x0601C0A5 RID: 114853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A5")]
		[Address(RVA = "0x1565BF0", Offset = "0x15647F0", VA = "0x181565BF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C0A6 RID: 114854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A6")]
		[Address(RVA = "0x1565A80", Offset = "0x1564680", VA = "0x181565A80")]
		public void OnSpreadFold(string foldId)
		{
		}

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A7")]
		[Address(RVA = "0x15659C0", Offset = "0x15645C0", VA = "0x1815659C0")]
		public void OnHideFold(string foldId)
		{
		}

		// Token: 0x0601C0A8 RID: 114856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A8")]
		[Address(RVA = "0x15668F0", Offset = "0x15654F0", VA = "0x1815668F0")]
		private void _UpdateMainMission(MissionModel stateBean)
		{
		}

		// Token: 0x0601C0A9 RID: 114857 RVA: 0x000A7088 File Offset: 0x000A5288
		[Token(Token = "0x601C0A9")]
		[Address(RVA = "0x1566790", Offset = "0x1565390", VA = "0x181566790")]
		private int _SortSubMission(MainMissionTaskDataWrapper lhs, MainMissionTaskDataWrapper rhs)
		{
			return 0;
		}

		// Token: 0x0601C0AA RID: 114858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0AA")]
		[Address(RVA = "0x1565B40", Offset = "0x1564740", VA = "0x181565B40", Slot = "5")]
		protected override void RefreshView()
		{
		}

		// Token: 0x0601C0AB RID: 114859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0AB")]
		[Address(RVA = "0x1565DD0", Offset = "0x15649D0", VA = "0x181565DD0")]
		private void _RefreshView()
		{
		}

		// Token: 0x0601C0AC RID: 114860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0AC")]
		[Address(RVA = "0x1566C90", Offset = "0x1565890", VA = "0x181566C90")]
		public MainMissionSimpleView()
		{
		}

		// Token: 0x0601C0AD RID: 114861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0AD")]
		[Address(RVA = "0x1564280", Offset = "0x1562E80", VA = "0x181564280")]
		private void <>xLuaBaseProxy_RefreshView()
		{
		}

		// Token: 0x04024993 RID: 149907
		[Token(Token = "0x4024993")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MainMissionTask _mainMissionTask;

		// Token: 0x04024994 RID: 149908
		[Token(Token = "0x4024994")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04024995 RID: 149909
		[Token(Token = "0x4024995")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Confirm All")]
		private Transform _rightPanel;

		// Token: 0x04024996 RID: 149910
		[Token(Token = "0x4024996")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Confirm All")]
		private RectTransform _backPanel;

		// Token: 0x04024997 RID: 149911
		[Token(Token = "0x4024997")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Confirm All")]
		private MainMissionConfirmAllTask _confirmAll;

		// Token: 0x04024998 RID: 149912
		[Token(Token = "0x4024998")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Top of Right_panel when player cannot confirm all.")]
		[Group("Confirm All")]
		private float _defaultTop;

		// Token: 0x04024999 RID: 149913
		[Token(Token = "0x4024999")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Top of Right_panel when player can confirm all.")]
		[Group("Confirm All")]
		[SerializeField]
		private float _confirmAllTop;

		// Token: 0x0402499A RID: 149914
		[Token(Token = "0x402499A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("BranchMission")]
		private GameObject _noSubMissionHint;

		// Token: 0x0402499B RID: 149915
		[Token(Token = "0x402499B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("BranchMission")]
		private GameObject _haveUnlockedSubMission;

		// Token: 0x0402499C RID: 149916
		[Token(Token = "0x402499C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MainMissionTask _taskPrefab;

		// Token: 0x0402499D RID: 149917
		[Token(Token = "0x402499D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MainMissionLockedTask _lockedTaskPrefab;

		// Token: 0x0402499E RID: 149918
		[Token(Token = "0x402499E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRecycleLayoutGroup _layoutGroup;

		// Token: 0x0402499F RID: 149919
		[Token(Token = "0x402499F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIStringEvent _onSpreadFold;

		// Token: 0x040249A0 RID: 149920
		[Token(Token = "0x40249A0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIStringEvent _onHideFold;

		// Token: 0x040249A1 RID: 149921
		[Token(Token = "0x40249A1")]
		[FieldOffset(Offset = "0x98")]
		private MainMissionTaskLoopAdapter m_adapter;

		// Token: 0x040249A2 RID: 149922
		[Token(Token = "0x40249A2")]
		[FieldOffset(Offset = "0xA0")]
		private string m_imagePathCache;

		// Token: 0x040249A3 RID: 149923
		[Token(Token = "0x40249A3")]
		[FieldOffset(Offset = "0xA8")]
		private MainMissionConfirmAllTask m_confirmAll;

		// Token: 0x040249A4 RID: 149924
		[Token(Token = "0x40249A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040249A5 RID: 149925
		[Token(Token = "0x40249A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSpreadFold;

		// Token: 0x040249A6 RID: 149926
		[Token(Token = "0x40249A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHideFold;

		// Token: 0x040249A7 RID: 149927
		[Token(Token = "0x40249A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateMainMission;

		// Token: 0x040249A8 RID: 149928
		[Token(Token = "0x40249A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SortSubMission;

		// Token: 0x040249A9 RID: 149929
		[Token(Token = "0x40249A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x040249AA RID: 149930
		[Token(Token = "0x40249AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040249AB RID: 149931
		[Token(Token = "0x40249AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
