using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067B6 RID: 26550
	[Token(Token = "0x20067B6")]
	public class StageZoneHomeEntryMedalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x0602611E RID: 155934 RVA: 0x000C9DB0 File Offset: 0x000C7FB0
		// (set) Token: 0x0602611F RID: 155935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A08")]
		public bool disableDarkBkg
		{
			[Token(Token = "0x602611E")]
			[Address(RVA = "0x2122780", Offset = "0x2121380", VA = "0x182122780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602611F")]
			[Address(RVA = "0x21227E0", Offset = "0x21213E0", VA = "0x1821227E0")]
			set
			{
			}
		}

		// Token: 0x06026120 RID: 155936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026120")]
		[Address(RVA = "0x2121E10", Offset = "0x2120A10", VA = "0x182121E10")]
		public void Render(ZoneHomeEntryMedalStatus newStatus)
		{
		}

		// Token: 0x06026121 RID: 155937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026121")]
		[Address(RVA = "0x2122510", Offset = "0x2121110", VA = "0x182122510")]
		private void _UpdateViewByStatus()
		{
		}

		// Token: 0x06026122 RID: 155938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026122")]
		[Address(RVA = "0x21222B0", Offset = "0x2120EB0", VA = "0x1821222B0")]
		private void _UpdateUncompleteStatus()
		{
		}

		// Token: 0x06026123 RID: 155939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026123")]
		[Address(RVA = "0x2122150", Offset = "0x2120D50", VA = "0x182122150")]
		private void _UpdateCompleteStatus()
		{
		}

		// Token: 0x06026124 RID: 155940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026124")]
		[Address(RVA = "0x2122240", Offset = "0x2120E40", VA = "0x182122240")]
		private void _UpdateDarkBkgStatus()
		{
		}

		// Token: 0x06026125 RID: 155941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026125")]
		[Address(RVA = "0x21226C0", Offset = "0x21212C0", VA = "0x1821226C0")]
		public StageZoneHomeEntryMedalView()
		{
		}

		// Token: 0x0403594E RID: 219470
		[Token(Token = "0x403594E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x0403594F RID: 219471
		[Token(Token = "0x403594F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgMedalProgress;

		// Token: 0x04035950 RID: 219472
		[Token(Token = "0x4035950")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04035951 RID: 219473
		[Token(Token = "0x4035951")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorCountHilight;

		// Token: 0x04035952 RID: 219474
		[Token(Token = "0x4035952")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04035953 RID: 219475
		[Token(Token = "0x4035953")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgMedal;

		// Token: 0x04035954 RID: 219476
		[Token(Token = "0x4035954")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelDarkBkg;

		// Token: 0x04035955 RID: 219477
		[Token(Token = "0x4035955")]
		[FieldOffset(Offset = "0x58")]
		private ZoneHomeEntryMedalStatus m_cachedStatus;

		// Token: 0x04035956 RID: 219478
		[Token(Token = "0x4035956")]
		[FieldOffset(Offset = "0x80")]
		private bool m_disableDarkBkg;

		// Token: 0x04035957 RID: 219479
		[Token(Token = "0x4035957")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableDarkBkg;

		// Token: 0x04035958 RID: 219480
		[Token(Token = "0x4035958")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_disableDarkBkg;

		// Token: 0x04035959 RID: 219481
		[Token(Token = "0x4035959")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403595A RID: 219482
		[Token(Token = "0x403595A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateViewByStatus;

		// Token: 0x0403595B RID: 219483
		[Token(Token = "0x403595B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateUncompleteStatus;

		// Token: 0x0403595C RID: 219484
		[Token(Token = "0x403595C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateCompleteStatus;

		// Token: 0x0403595D RID: 219485
		[Token(Token = "0x403595D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateDarkBkgStatus;

		// Token: 0x0403595E RID: 219486
		[Token(Token = "0x403595E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
