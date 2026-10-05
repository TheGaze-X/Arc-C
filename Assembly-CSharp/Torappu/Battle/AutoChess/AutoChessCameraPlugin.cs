using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using UnityEngine;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200278A RID: 10122
	[Token(Token = "0x200278A")]
	public class AutoChessCameraPlugin : CameraController.Plugin
	{
		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x06010845 RID: 67653 RVA: 0x00064C08 File Offset: 0x00062E08
		[Token(Token = "0x1700241E")]
		public Vector3 battletCameraPos
		{
			[Token(Token = "0x6010845")]
			[Address(RVA = "0x84C2A0", Offset = "0x84AEA0", VA = "0x18084C2A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06010846 RID: 67654 RVA: 0x00064C20 File Offset: 0x00062E20
		[Token(Token = "0x1700241F")]
		public bool isMoving
		{
			[Token(Token = "0x6010846")]
			[Address(RVA = "0x84C3C0", Offset = "0x84AFC0", VA = "0x18084C3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06010847 RID: 67655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010847")]
		[Address(RVA = "0x84AC00", Offset = "0x849800", VA = "0x18084AC00")]
		public void Init(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06010848 RID: 67656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010848")]
		[Address(RVA = "0x84AEF0", Offset = "0x849AF0", VA = "0x18084AEF0")]
		private void _InitOption(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06010849 RID: 67657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010849")]
		[Address(RVA = "0x84BD20", Offset = "0x84A920", VA = "0x18084BD20")]
		private void _SetOption(AutoChessCameraPlugin.PositionType positionType, string param)
		{
		}

		// Token: 0x0601084A RID: 67658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084A")]
		[Address(RVA = "0x84AD30", Offset = "0x849930", VA = "0x18084AD30")]
		private void _HandleDataChanged(object arg)
		{
		}

		// Token: 0x0601084B RID: 67659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084B")]
		[Address(RVA = "0x84BA50", Offset = "0x84A650", VA = "0x18084BA50")]
		private void _RefreshPosition()
		{
		}

		// Token: 0x0601084C RID: 67660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084C")]
		[Address(RVA = "0x84BC50", Offset = "0x84A850", VA = "0x18084BC50")]
		private void _RefreshSideBy()
		{
		}

		// Token: 0x0601084D RID: 67661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084D")]
		[Address(RVA = "0x84B760", Offset = "0x84A360", VA = "0x18084B760")]
		private void _RefreshPositionInNoBattleState()
		{
		}

		// Token: 0x0601084E RID: 67662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084E")]
		[Address(RVA = "0x84B660", Offset = "0x84A260", VA = "0x18084B660")]
		private void _RefreshPositionInBattleState()
		{
		}

		// Token: 0x0601084F RID: 67663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601084F")]
		[Address(RVA = "0x84B3B0", Offset = "0x849FB0", VA = "0x18084B3B0")]
		private void _MoveTo(AutoChessCameraPlugin.PositionType pos, bool tween, bool force = false)
		{
		}

		// Token: 0x06010850 RID: 67664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010850")]
		[Address(RVA = "0x84B2A0", Offset = "0x849EA0", VA = "0x18084B2A0")]
		private void _MoveTo(Vector3 targetPos, float size, bool tween = true)
		{
		}

		// Token: 0x06010851 RID: 67665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010851")]
		[Address(RVA = "0x84C110", Offset = "0x84AD10", VA = "0x18084C110")]
		public AutoChessCameraPlugin()
		{
		}

		// Token: 0x04012878 RID: 75896
		[Token(Token = "0x4012878")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ease _moveTween;

		// Token: 0x04012879 RID: 75897
		[Token(Token = "0x4012879")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Ease _scaleTween;

		// Token: 0x0401287A RID: 75898
		[Token(Token = "0x401287A")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessMapInfoChecker m_mapInfoChecker;

		// Token: 0x0401287B RID: 75899
		[Token(Token = "0x401287B")]
		[FieldOffset(Offset = "0x30")]
		private AutoChessGameStatus.UIStateChecker m_uIStateChecker;

		// Token: 0x0401287C RID: 75900
		[Token(Token = "0x401287C")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessGameStatus.GameStateChecker m_gameStateChecker;

		// Token: 0x0401287D RID: 75901
		[Token(Token = "0x401287D")]
		[FieldOffset(Offset = "0x0")]
		private static Regex PARAM_REGEX;

		// Token: 0x0401287E RID: 75902
		[Token(Token = "0x401287E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<AutoChessCameraPlugin.PositionType, AutoChessCameraPlugin.Param> m_option;

		// Token: 0x0401287F RID: 75903
		[Token(Token = "0x401287F")]
		[FieldOffset(Offset = "0x48")]
		private float m_moveTime;

		// Token: 0x04012880 RID: 75904
		[Token(Token = "0x4012880")]
		[FieldOffset(Offset = "0x4C")]
		private AutoChessCameraPlugin.PositionType m_positionType;

		// Token: 0x04012881 RID: 75905
		[Token(Token = "0x4012881")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_battletCameraPos;

		// Token: 0x04012882 RID: 75906
		[Token(Token = "0x4012882")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMoving;

		// Token: 0x04012883 RID: 75907
		[Token(Token = "0x4012883")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04012884 RID: 75908
		[Token(Token = "0x4012884")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitOption;

		// Token: 0x04012885 RID: 75909
		[Token(Token = "0x4012885")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetOption;

		// Token: 0x04012886 RID: 75910
		[Token(Token = "0x4012886")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleDataChanged;

		// Token: 0x04012887 RID: 75911
		[Token(Token = "0x4012887")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshPosition;

		// Token: 0x04012888 RID: 75912
		[Token(Token = "0x4012888")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshSideBy;

		// Token: 0x04012889 RID: 75913
		[Token(Token = "0x4012889")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshPositionInNoBattleState;

		// Token: 0x0401288A RID: 75914
		[Token(Token = "0x401288A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshPositionInBattleState;

		// Token: 0x0401288B RID: 75915
		[Token(Token = "0x401288B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__MoveTo;

		// Token: 0x0401288C RID: 75916
		[Token(Token = "0x401288C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1__MoveTo;

		// Token: 0x0401288D RID: 75917
		[Token(Token = "0x401288D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200278B RID: 10123
		[Token(Token = "0x200278B")]
		public enum PositionType
		{
			// Token: 0x0401288F RID: 75919
			[Token(Token = "0x401288F")]
			NONE,
			// Token: 0x04012890 RID: 75920
			[Token(Token = "0x4012890")]
			LEFT_PREPARE,
			// Token: 0x04012891 RID: 75921
			[Token(Token = "0x4012891")]
			LEFT_SHOP,
			// Token: 0x04012892 RID: 75922
			[Token(Token = "0x4012892")]
			LEFT_BATTLE,
			// Token: 0x04012893 RID: 75923
			[Token(Token = "0x4012893")]
			RIGHT_BATTLE,
			// Token: 0x04012894 RID: 75924
			[Token(Token = "0x4012894")]
			MID_BATTLE,
			// Token: 0x04012895 RID: 75925
			[Token(Token = "0x4012895")]
			LEFT_BOSS_PREPARE,
			// Token: 0x04012896 RID: 75926
			[Token(Token = "0x4012896")]
			RIGHT_BOSS_PREPARE,
			// Token: 0x04012897 RID: 75927
			[Token(Token = "0x4012897")]
			LEFT_BOSS_SHOP,
			// Token: 0x04012898 RID: 75928
			[Token(Token = "0x4012898")]
			RIGHT_BOSS_SHOP,
			// Token: 0x04012899 RID: 75929
			[Token(Token = "0x4012899")]
			LEFT_BOSS_BATTLE,
			// Token: 0x0401289A RID: 75930
			[Token(Token = "0x401289A")]
			RIGHT_BOSS_BATTLE,
			// Token: 0x0401289B RID: 75931
			[Token(Token = "0x401289B")]
			MID_BOSS_BATTLE,
			// Token: 0x0401289C RID: 75932
			[Token(Token = "0x401289C")]
			ENEMY_PREVIEW,
			// Token: 0x0401289D RID: 75933
			[Token(Token = "0x401289D")]
			CUSTOM_CHARACTER
		}

		// Token: 0x0200278C RID: 10124
		[Token(Token = "0x200278C")]
		private struct Param
		{
			// Token: 0x0401289E RID: 75934
			[Token(Token = "0x401289E")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x0401289F RID: 75935
			[Token(Token = "0x401289F")]
			[FieldOffset(Offset = "0xC")]
			public float size;
		}
	}
}
