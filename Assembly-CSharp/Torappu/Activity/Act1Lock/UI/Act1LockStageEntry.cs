using System;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007881 RID: 30849
	[Token(Token = "0x2007881")]
	public class Act1LockStageEntry : ActivityStageSingleComponent
	{
		// Token: 0x0602B3CA RID: 177098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3CA")]
		[Address(RVA = "0x2718050", Offset = "0x2716C50", VA = "0x182718050", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602B3CB RID: 177099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3CB")]
		[Address(RVA = "0x2717FD0", Offset = "0x2716BD0", VA = "0x182717FD0")]
		private void OnDisable()
		{
		}

		// Token: 0x0602B3CC RID: 177100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3CC")]
		[Address(RVA = "0x2718680", Offset = "0x2717280", VA = "0x182718680")]
		private void _InifIfNot()
		{
		}

		// Token: 0x0602B3CD RID: 177101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3CD")]
		[Address(RVA = "0x2718880", Offset = "0x2717480", VA = "0x182718880")]
		private void _TriggerInterlockAVG()
		{
		}

		// Token: 0x0602B3CE RID: 177102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3CE")]
		[Address(RVA = "0x27187E0", Offset = "0x27173E0", VA = "0x1827187E0")]
		private void _OnSysAvgFinish(Story story)
		{
		}

		// Token: 0x0602B3CF RID: 177103 RVA: 0x000DB3D8 File Offset: 0x000D95D8
		[Token(Token = "0x602B3CF")]
		[Address(RVA = "0x27189B0", Offset = "0x27175B0", VA = "0x1827189B0")]
		private bool _TryTrigSeasonAVG()
		{
			return default(bool);
		}

		// Token: 0x0602B3D0 RID: 177104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3D0")]
		[Address(RVA = "0x2718B70", Offset = "0x2717770", VA = "0x182718B70")]
		public Act1LockStageEntry()
		{
		}

		// Token: 0x0602B3D1 RID: 177105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3D1")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403E7F9 RID: 255993
		[Token(Token = "0x403E7F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E7FA RID: 255994
		[Token(Token = "0x403E7FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403E7FB RID: 255995
		[Token(Token = "0x403E7FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1LockMainView _mainView;

		// Token: 0x0403E7FC RID: 255996
		[Token(Token = "0x403E7FC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _milestoneTrack;

		// Token: 0x0403E7FD RID: 255997
		[Token(Token = "0x403E7FD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _missionTrack;

		// Token: 0x0403E7FE RID: 255998
		[Token(Token = "0x403E7FE")]
		private const string START_ANIM_NAME = "activity_main_entry";

		// Token: 0x0403E7FF RID: 255999
		[Token(Token = "0x403E7FF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403E800 RID: 256000
		[Token(Token = "0x403E800")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403E801 RID: 256001
		[Token(Token = "0x403E801")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403E802 RID: 256002
		[Token(Token = "0x403E802")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InifIfNot;

		// Token: 0x0403E803 RID: 256003
		[Token(Token = "0x403E803")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerInterlockAVG;

		// Token: 0x0403E804 RID: 256004
		[Token(Token = "0x403E804")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSysAvgFinish;

		// Token: 0x0403E805 RID: 256005
		[Token(Token = "0x403E805")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTrigSeasonAVG;

		// Token: 0x0403E806 RID: 256006
		[Token(Token = "0x403E806")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
