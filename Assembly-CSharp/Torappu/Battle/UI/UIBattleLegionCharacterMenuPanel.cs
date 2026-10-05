using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Legion;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D6 RID: 13014
	[Token(Token = "0x20032D6")]
	public class UIBattleLegionCharacterMenuPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06014B19 RID: 84761 RVA: 0x00087FF0 File Offset: 0x000861F0
		// (set) Token: 0x06014B1A RID: 84762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003104")]
		public bool isOpen
		{
			[Token(Token = "0x6014B19")]
			[Address(RVA = "0xD1FFE0", Offset = "0xD1EBE0", VA = "0x180D1FFE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014B1A")]
			[Address(RVA = "0xD20040", Offset = "0xD1EC40", VA = "0x180D20040")]
			private set
			{
			}
		}

		// Token: 0x06014B1B RID: 84763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B1B")]
		[Address(RVA = "0xD1EB80", Offset = "0xD1D780", VA = "0x180D1EB80")]
		private void Awake()
		{
		}

		// Token: 0x06014B1C RID: 84764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B1C")]
		[Address(RVA = "0xD1F250", Offset = "0xD1DE50", VA = "0x180D1F250")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B1D RID: 84765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B1D")]
		[Address(RVA = "0xD1F2E0", Offset = "0xD1DEE0", VA = "0x180D1F2E0")]
		public void SetData(Character character, List<LegionModeProfessionBuffStatus> legionStatus, Tile followTile, int maxLevel, bool isDummy)
		{
		}

		// Token: 0x06014B1E RID: 84766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B1E")]
		[Address(RVA = "0xD1FB20", Offset = "0xD1E720", VA = "0x180D1FB20")]
		private void _ApplyMaxLevelTween()
		{
		}

		// Token: 0x06014B1F RID: 84767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B1F")]
		[Address(RVA = "0xD1F140", Offset = "0xD1DD40", VA = "0x180D1F140")]
		public void Hide()
		{
		}

		// Token: 0x06014B20 RID: 84768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B20")]
		[Address(RVA = "0xD1F9A0", Offset = "0xD1E5A0", VA = "0x180D1F9A0")]
		public void ShowHighLightProfessions(List<ProfessionCategory> hlList)
		{
		}

		// Token: 0x06014B21 RID: 84769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B21")]
		[Address(RVA = "0xD1FE60", Offset = "0xD1EA60", VA = "0x180D1FE60")]
		public UIBattleLegionCharacterMenuPanel()
		{
		}

		// Token: 0x040188F5 RID: 100597
		[Token(Token = "0x40188F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EasyInstancePool _characterMenuDetailList;

		// Token: 0x040188F6 RID: 100598
		[Token(Token = "0x40188F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x040188F7 RID: 100599
		[Token(Token = "0x40188F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _levelMaxImage;

		// Token: 0x040188F8 RID: 100600
		[Token(Token = "0x40188F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _levelMaxImageHL;

		// Token: 0x040188F9 RID: 100601
		[Token(Token = "0x40188F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_openTweenTime;

		// Token: 0x040188FA RID: 100602
		[Token(Token = "0x40188FA")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ProfessionCategory, int> m_cachedLegionStatus;

		// Token: 0x040188FB RID: 100603
		[Token(Token = "0x40188FB")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_canvasTween;

		// Token: 0x040188FC RID: 100604
		[Token(Token = "0x40188FC")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_maxLevelTween;

		// Token: 0x040188FD RID: 100605
		[Token(Token = "0x40188FD")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_maxLevelBgTween;

		// Token: 0x040188FE RID: 100606
		[Token(Token = "0x40188FE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isMaxLevel;

		// Token: 0x040188FF RID: 100607
		[Token(Token = "0x40188FF")]
		[FieldOffset(Offset = "0x61")]
		private bool m_isDummy;

		// Token: 0x04018900 RID: 100608
		[Token(Token = "0x4018900")]
		[FieldOffset(Offset = "0x62")]
		private bool m_isOpen;

		// Token: 0x04018901 RID: 100609
		[Token(Token = "0x4018901")]
		[FieldOffset(Offset = "0x64")]
		private readonly Vector3 TWEEN_MAXLEVEL_ICON_START_POS;

		// Token: 0x04018902 RID: 100610
		[Token(Token = "0x4018902")]
		[FieldOffset(Offset = "0x70")]
		private readonly float TWEEN_MAXLEVEL_ICON_CHECK_POINT_POS_Y;

		// Token: 0x04018903 RID: 100611
		[Token(Token = "0x4018903")]
		[FieldOffset(Offset = "0x74")]
		private readonly float TWEEN_MAXLEVEL_ICON_CHECK_POINT_DURATION;

		// Token: 0x04018904 RID: 100612
		[Token(Token = "0x4018904")]
		[FieldOffset(Offset = "0x78")]
		private readonly float TWEEN_MAXLEVEL_ICON_END_POS_Y;

		// Token: 0x04018905 RID: 100613
		[Token(Token = "0x4018905")]
		[FieldOffset(Offset = "0x7C")]
		private readonly float TWEEN_MAXLEVEL_ICON_END_DURATION;

		// Token: 0x04018906 RID: 100614
		[Token(Token = "0x4018906")]
		[FieldOffset(Offset = "0x80")]
		private readonly Vector3 TWEEN_MAXLEVEL_BACK_START_SCALE;

		// Token: 0x04018907 RID: 100615
		[Token(Token = "0x4018907")]
		[FieldOffset(Offset = "0x8C")]
		private readonly float TWEEN_MAXLEVEL_BACK_FINAL_SCALE;

		// Token: 0x04018908 RID: 100616
		[Token(Token = "0x4018908")]
		[FieldOffset(Offset = "0x90")]
		private readonly float TWEEN_MAXLEVEL_BACK_FINAL_SCALE_DURATION;

		// Token: 0x04018909 RID: 100617
		[Token(Token = "0x4018909")]
		[FieldOffset(Offset = "0x94")]
		private readonly float TWEEN_MAXLEVEL_BACK_END_FADE_DURATION;

		// Token: 0x0401890A RID: 100618
		[Token(Token = "0x401890A")]
		[FieldOffset(Offset = "0x98")]
		private readonly float TWEEN_START_CANVSE_ALPHA_STEP1;

		// Token: 0x0401890B RID: 100619
		[Token(Token = "0x401890B")]
		[FieldOffset(Offset = "0x9C")]
		private readonly float TWEEN_START_CANVSE_ALPHA_STEP2;

		// Token: 0x0401890C RID: 100620
		[Token(Token = "0x401890C")]
		[FieldOffset(Offset = "0xA0")]
		private readonly float TWEEN_START_CANVSE_ALPHA_STEP3;

		// Token: 0x0401890D RID: 100621
		[Token(Token = "0x401890D")]
		[FieldOffset(Offset = "0xA4")]
		private readonly float TWEEN_START_CANVSE_ALPHA_END;

		// Token: 0x0401890E RID: 100622
		[Token(Token = "0x401890E")]
		[FieldOffset(Offset = "0xA8")]
		private readonly float TWEEN_START_CANVSE_ALPHA_STEP1_PERCENT;

		// Token: 0x0401890F RID: 100623
		[Token(Token = "0x401890F")]
		[FieldOffset(Offset = "0xAC")]
		private readonly float TWEEN_START_CANVSE_ALPHA_STEP2_PERCENT;

		// Token: 0x04018910 RID: 100624
		[Token(Token = "0x4018910")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOpen;

		// Token: 0x04018911 RID: 100625
		[Token(Token = "0x4018911")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOpen;

		// Token: 0x04018912 RID: 100626
		[Token(Token = "0x4018912")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018913 RID: 100627
		[Token(Token = "0x4018913")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018914 RID: 100628
		[Token(Token = "0x4018914")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018915 RID: 100629
		[Token(Token = "0x4018915")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyMaxLevelTween;

		// Token: 0x04018916 RID: 100630
		[Token(Token = "0x4018916")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04018917 RID: 100631
		[Token(Token = "0x4018917")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowHighLightProfessions;

		// Token: 0x04018918 RID: 100632
		[Token(Token = "0x4018918")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
