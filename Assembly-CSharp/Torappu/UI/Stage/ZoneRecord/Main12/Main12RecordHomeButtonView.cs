using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A0C RID: 27148
	[Token(Token = "0x2006A0C")]
	public class Main12RecordHomeButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x06026CFC RID: 158972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026CFD RID: 158973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B9A")]
		public Action<string> onClickBtn
		{
			[Token(Token = "0x6026CFC")]
			[Address(RVA = "0x21D3360", Offset = "0x21D1F60", VA = "0x1821D3360")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026CFD")]
			[Address(RVA = "0x21D33C0", Offset = "0x21D1FC0", VA = "0x1821D33C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026CFE RID: 158974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CFE")]
		[Address(RVA = "0x21D2D50", Offset = "0x21D1950", VA = "0x1821D2D50")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026CFF RID: 158975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CFF")]
		[Address(RVA = "0x21D2C80", Offset = "0x21D1880", VA = "0x1821D2C80")]
		public void OnClickBtn()
		{
		}

		// Token: 0x06026D00 RID: 158976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D00")]
		[Address(RVA = "0x21D30D0", Offset = "0x21D1CD0", VA = "0x1821D30D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D01 RID: 158977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D01")]
		[Address(RVA = "0x21D32A0", Offset = "0x21D1EA0", VA = "0x1821D32A0")]
		public Main12RecordHomeButtonView()
		{
		}

		// Token: 0x04036D3F RID: 224575
		[Token(Token = "0x4036D3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04036D40 RID: 224576
		[Token(Token = "0x4036D40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main12RecordHomeButtonView.StageDiffImage[] _panelDiffGroup;

		// Token: 0x04036D41 RID: 224577
		[Token(Token = "0x4036D41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPointReward;

		// Token: 0x04036D42 RID: 224578
		[Token(Token = "0x4036D42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleName;

		// Token: 0x04036D43 RID: 224579
		[Token(Token = "0x4036D43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _back;

		// Token: 0x04036D44 RID: 224580
		[Token(Token = "0x4036D44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _lockIcon;

		// Token: 0x04036D45 RID: 224581
		[Token(Token = "0x4036D45")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _lockAlpha;

		// Token: 0x04036D46 RID: 224582
		[Token(Token = "0x4036D46")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isInited;

		// Token: 0x04036D47 RID: 224583
		[Token(Token = "0x4036D47")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedRecordId;

		// Token: 0x04036D48 RID: 224584
		[Token(Token = "0x4036D48")]
		[FieldOffset(Offset = "0x58")]
		private TrackPointViewProperty m_rewardTrackProperty;

		// Token: 0x04036D49 RID: 224585
		[Token(Token = "0x4036D49")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<ZoneRecordViewModel.RecordDiffIconType, GameObject> m_diffImgDict;

		// Token: 0x04036D4B RID: 224587
		[Token(Token = "0x4036D4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickBtn;

		// Token: 0x04036D4C RID: 224588
		[Token(Token = "0x4036D4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickBtn;

		// Token: 0x04036D4D RID: 224589
		[Token(Token = "0x4036D4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036D4E RID: 224590
		[Token(Token = "0x4036D4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickBtn;

		// Token: 0x04036D4F RID: 224591
		[Token(Token = "0x4036D4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036D50 RID: 224592
		[Token(Token = "0x4036D50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A0D RID: 27149
		[Token(Token = "0x2006A0D")]
		[Serializable]
		private struct StageDiffImage
		{
			// Token: 0x04036D51 RID: 224593
			[Token(Token = "0x4036D51")]
			[FieldOffset(Offset = "0x0")]
			public ZoneRecordViewModel.RecordDiffIconType stageDiff;

			// Token: 0x04036D52 RID: 224594
			[Token(Token = "0x4036D52")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelImage;
		}
	}
}
