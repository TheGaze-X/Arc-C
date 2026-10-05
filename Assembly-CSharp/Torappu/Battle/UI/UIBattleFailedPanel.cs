using System;
using System.Collections;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x020032FA RID: 13050
	[Token(Token = "0x20032FA")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UIBattleFailedPanel : MonoBehaviour
	{
		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06014BAD RID: 84909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003115")]
		private CanvasGroup rootCanvasGroup
		{
			[Token(Token = "0x6014BAD")]
			[Address(RVA = "0xD1D120", Offset = "0xD1BD20", VA = "0x180D1D120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06014BAE RID: 84910 RVA: 0x00088260 File Offset: 0x00086460
		// (set) Token: 0x06014BAF RID: 84911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003116")]
		private bool isRaycastBlock
		{
			[Token(Token = "0x6014BAE")]
			[Address(RVA = "0xD1D0D0", Offset = "0xD1BCD0", VA = "0x180D1D0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014BAF")]
			[Address(RVA = "0xD1D1D0", Offset = "0xD1BDD0", VA = "0x180D1D1D0")]
			set
			{
			}
		}

		// Token: 0x06014BB0 RID: 84912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB0")]
		[Address(RVA = "0xD1C4B0", Offset = "0xD1B0B0", VA = "0x180D1C4B0")]
		public void Show()
		{
		}

		// Token: 0x06014BB1 RID: 84913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB1")]
		[Address(RVA = "0xCED460", Offset = "0xCEC060", VA = "0x180CED460")]
		public void Hide()
		{
		}

		// Token: 0x06014BB2 RID: 84914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB2")]
		[Address(RVA = "0xCED460", Offset = "0xCEC060", VA = "0x180CED460")]
		public void OnInit()
		{
		}

		// Token: 0x06014BB3 RID: 84915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB3")]
		[Address(RVA = "0xD1C3C0", Offset = "0xD1AFC0", VA = "0x180D1C3C0")]
		public void OnPanelClicked()
		{
		}

		// Token: 0x06014BB4 RID: 84916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB4")]
		[Address(RVA = "0xD1C6B0", Offset = "0xD1B2B0", VA = "0x180D1C6B0")]
		private void _LoadData()
		{
		}

		// Token: 0x06014BB5 RID: 84917 RVA: 0x00088278 File Offset: 0x00086478
		[Token(Token = "0x6014BB5")]
		[Address(RVA = "0xD1C9E0", Offset = "0xD1B5E0", VA = "0x180D1C9E0")]
		private UIBattleFailedPanel.Options _LoadOptions()
		{
			return default(UIBattleFailedPanel.Options);
		}

		// Token: 0x06014BB6 RID: 84918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB6")]
		[Address(RVA = "0xD1CDD0", Offset = "0xD1B9D0", VA = "0x180D1CDD0")]
		private void _ResetAll()
		{
		}

		// Token: 0x06014BB7 RID: 84919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB7")]
		[Address(RVA = "0xD1CE40", Offset = "0xD1BA40", VA = "0x180D1CE40")]
		private void _SwitchPage(CanvasGroup nextPage, bool useTween)
		{
		}

		// Token: 0x06014BB8 RID: 84920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014BB8")]
		[Address(RVA = "0xD1C610", Offset = "0xD1B210", VA = "0x180D1C610")]
		private IEnumerator _DoSwitchPageCoroutine(CanvasGroup nextPage, float duration)
		{
			return null;
		}

		// Token: 0x06014BB9 RID: 84921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BB9")]
		[Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0")]
		private void _ClearTween(bool complete)
		{
		}

		// Token: 0x06014BBA RID: 84922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BBA")]
		[Address(RVA = "0xD1C270", Offset = "0xD1AE70", VA = "0x180D1C270")]
		private void Awake()
		{
		}

		// Token: 0x06014BBB RID: 84923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BBB")]
		[Address(RVA = "0xD1D060", Offset = "0xD1BC60", VA = "0x180D1D060")]
		public UIBattleFailedPanel()
		{
		}

		// Token: 0x04018A38 RID: 100920
		[Token(Token = "0x4018A38")]
		private const int NUM_TIPS = 2;

		// Token: 0x04018A39 RID: 100921
		[Token(Token = "0x4018A39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x04018A3A RID: 100922
		[Token(Token = "0x4018A3A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _switchPageTime;

		// Token: 0x04018A3B RID: 100923
		[Token(Token = "0x4018A3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _raycastBtn;

		// Token: 0x04018A3C RID: 100924
		[Token(Token = "0x4018A3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _continueLabel;

		// Token: 0x04018A3D RID: 100925
		[Token(Token = "0x4018A3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _practiceHintPanel;

		// Token: 0x04018A3E RID: 100926
		[Token(Token = "0x4018A3E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Collection(2)]
		private Text[] _tips;

		// Token: 0x04018A3F RID: 100927
		[Token(Token = "0x4018A3F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Pages")]
		private CanvasGroup _defaultPage;

		// Token: 0x04018A40 RID: 100928
		[Token(Token = "0x4018A40")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Pages")]
		private CanvasGroup _apProtectPage;

		// Token: 0x04018A41 RID: 100929
		[Token(Token = "0x4018A41")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Pages")]
		private CanvasGroup _powerScoreNotEnoughPage;

		// Token: 0x04018A42 RID: 100930
		[Token(Token = "0x4018A42")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _onPanelClose;

		// Token: 0x04018A43 RID: 100931
		[Token(Token = "0x4018A43")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _apProtectText_firstTry;

		// Token: 0x04018A44 RID: 100932
		[Token(Token = "0x4018A44")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _apProtectText_period;

		// Token: 0x04018A45 RID: 100933
		[Token(Token = "0x4018A45")]
		[FieldOffset(Offset = "0x70")]
		private CanvasGroup[] m_pages;

		// Token: 0x04018A46 RID: 100934
		[Token(Token = "0x4018A46")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tween;

		// Token: 0x04018A47 RID: 100935
		[Token(Token = "0x4018A47")]
		[FieldOffset(Offset = "0x80")]
		private UIBattleFailedPanel.Options m_options;

		// Token: 0x04018A48 RID: 100936
		[Token(Token = "0x4018A48")]
		[FieldOffset(Offset = "0x88")]
		private CanvasGroup m_currentPage;

		// Token: 0x04018A49 RID: 100937
		[Token(Token = "0x4018A49")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isPageSwitching;

		// Token: 0x04018A4A RID: 100938
		[Token(Token = "0x4018A4A")]
		[FieldOffset(Offset = "0x98")]
		private CanvasGroup m_rootCanvasGroup;

		// Token: 0x020032FB RID: 13051
		[Token(Token = "0x20032FB")]
		private struct Options
		{
			// Token: 0x04018A4B RID: 100939
			[Token(Token = "0x4018A4B")]
			[FieldOffset(Offset = "0x0")]
			public bool isApProtect;

			// Token: 0x04018A4C RID: 100940
			[Token(Token = "0x4018A4C")]
			[FieldOffset(Offset = "0x1")]
			public bool notifyPracticeHint;

			// Token: 0x04018A4D RID: 100941
			[Token(Token = "0x4018A4D")]
			[FieldOffset(Offset = "0x2")]
			public bool notifyPowerScoreNotEnough;

			// Token: 0x04018A4E RID: 100942
			[Token(Token = "0x4018A4E")]
			[FieldOffset(Offset = "0x3")]
			public bool inApProtectPeriod;
		}
	}
}
