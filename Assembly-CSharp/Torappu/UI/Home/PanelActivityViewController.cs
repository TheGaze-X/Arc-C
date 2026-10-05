using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C42 RID: 19522
	[Token(Token = "0x2004C42")]
	public class PanelActivityViewController : MonoBehaviour
	{
		// Token: 0x0601D4E7 RID: 120039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E7")]
		[Address(RVA = "0x16DBC70", Offset = "0x16DA870", VA = "0x1816DBC70")]
		public void OnToggleChanged(bool isSelected)
		{
		}

		// Token: 0x0601D4E8 RID: 120040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E8")]
		[Address(RVA = "0x16DBD50", Offset = "0x16DA950", VA = "0x1816DBD50")]
		public void Render()
		{
		}

		// Token: 0x0601D4E9 RID: 120041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4E9")]
		[Address(RVA = "0x16DC7E0", Offset = "0x16DB3E0", VA = "0x1816DC7E0")]
		private void _TryTweenToPage(int pageIndex)
		{
		}

		// Token: 0x0601D4EA RID: 120042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4EA")]
		[Address(RVA = "0x16DC740", Offset = "0x16DB340", VA = "0x1816DC740")]
		private void _PageSwitchCallback(int index)
		{
		}

		// Token: 0x0601D4EB RID: 120043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4EB")]
		[Address(RVA = "0x16DBA00", Offset = "0x16DA600", VA = "0x1816DBA00")]
		private void Awake()
		{
		}

		// Token: 0x0601D4EC RID: 120044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4EC")]
		[Address(RVA = "0x16DBBA0", Offset = "0x16DA7A0", VA = "0x1816DBBA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D4ED RID: 120045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4ED")]
		[Address(RVA = "0x16DC5B0", Offset = "0x16DB1B0", VA = "0x1816DC5B0")]
		private void Update()
		{
		}

		// Token: 0x0601D4EE RID: 120046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4EE")]
		[Address(RVA = "0x16DBAD0", Offset = "0x16DA6D0", VA = "0x1816DBAD0")]
		public static SpriteHub LoadBannerImageHub(string path)
		{
			return null;
		}

		// Token: 0x0601D4EF RID: 120047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D4EF")]
		[Address(RVA = "0x16DC690", Offset = "0x16DB290", VA = "0x1816DC690")]
		private ActivityViewEntry _AchieveBackupDefaultEntry()
		{
			return null;
		}

		// Token: 0x0601D4F0 RID: 120048 RVA: 0x000AB270 File Offset: 0x000A9470
		[Token(Token = "0x601D4F0")]
		[Address(RVA = "0x16DC700", Offset = "0x16DB300", VA = "0x1816DC700")]
		private static int _EvalActivityEntryType(ActivityEntryType type)
		{
			return 0;
		}

		// Token: 0x0601D4F1 RID: 120049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4F1")]
		[Address(RVA = "0x16DC840", Offset = "0x16DB440", VA = "0x1816DC840")]
		public PanelActivityViewController()
		{
		}

		// Token: 0x040268F2 RID: 157938
		[Token(Token = "0x40268F2")]
		private const float PAUSE_DURATION_WHEN_ACTION = 2f;

		// Token: 0x040268F3 RID: 157939
		[Token(Token = "0x40268F3")]
		private const float SWITCH_PAGE_PERIOD = 4f;

		// Token: 0x040268F4 RID: 157940
		[Token(Token = "0x40268F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _breakingNewsImage;

		// Token: 0x040268F5 RID: 157941
		[Token(Token = "0x40268F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollViewPager _viewPager;

		// Token: 0x040268F6 RID: 157942
		[Token(Token = "0x40268F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("scroll bar to disable drag")]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x040268F7 RID: 157943
		[Token(Token = "0x40268F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HomeActivityView _activityProto;

		// Token: 0x040268F8 RID: 157944
		[Token(Token = "0x40268F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _activityContainer;

		// Token: 0x040268F9 RID: 157945
		[Token(Token = "0x40268F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x040268FA RID: 157946
		[Token(Token = "0x40268FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Toggle _toggleProto;

		// Token: 0x040268FB RID: 157947
		[Token(Token = "0x40268FB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _defaultBreakingNews;

		// Token: 0x040268FC RID: 157948
		[Token(Token = "0x40268FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActivityViewEntryProvider[] _activityViewEntryProviders;

		// Token: 0x040268FD RID: 157949
		[Token(Token = "0x40268FD")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x040268FE RID: 157950
		[Token(Token = "0x40268FE")]
		[FieldOffset(Offset = "0x68")]
		private List<HomeActivityView> m_viewCache;

		// Token: 0x040268FF RID: 157951
		[Token(Token = "0x40268FF")]
		[FieldOffset(Offset = "0x70")]
		private List<Toggle> m_switchToggles;

		// Token: 0x04026900 RID: 157952
		[Token(Token = "0x4026900")]
		[FieldOffset(Offset = "0x78")]
		private List<ActivityViewEntry> m_sharedEntryList;

		// Token: 0x04026901 RID: 157953
		[Token(Token = "0x4026901")]
		[FieldOffset(Offset = "0x80")]
		private float m_switchCountDown;

		// Token: 0x04026902 RID: 157954
		[Token(Token = "0x4026902")]
		[FieldOffset(Offset = "0x84")]
		private bool m_autoToggleSwitch;
	}
}
