using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069B0 RID: 27056
	[Token(Token = "0x20069B0")]
	public class StageZoneNeedUnlockStoryPlugin : StageButtonHolderPlugin, ICompDialogCallBack
	{
		// Token: 0x06026B8B RID: 158603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B8B")]
		[Address(RVA = "0x21CB130", Offset = "0x21C9D30", VA = "0x1821CB130", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06026B8C RID: 158604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B8C")]
		[Address(RVA = "0x21CB2C0", Offset = "0x21C9EC0", VA = "0x1821CB2C0", Slot = "5")]
		protected override void OnRenderStage(StageViewModel viewModel)
		{
		}

		// Token: 0x06026B8D RID: 158605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B8D")]
		[Address(RVA = "0x21CAF40", Offset = "0x21C9B40", VA = "0x1821CAF40")]
		public void OnClickUnknown()
		{
		}

		// Token: 0x06026B8E RID: 158606 RVA: 0x000CC198 File Offset: 0x000CA398
		[Token(Token = "0x6026B8E")]
		[Address(RVA = "0x21CB6F0", Offset = "0x21CA2F0", VA = "0x1821CB6F0")]
		private bool _CheckOwnKeyItem()
		{
			return default(bool);
		}

		// Token: 0x06026B8F RID: 158607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B8F")]
		[Address(RVA = "0x21CADD0", Offset = "0x21C99D0", VA = "0x1821CADD0", Slot = "6")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06026B90 RID: 158608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B90")]
		[Address(RVA = "0x21CB7E0", Offset = "0x21CA3E0", VA = "0x1821CB7E0")]
		public StageZoneNeedUnlockStoryPlugin()
		{
		}

		// Token: 0x04036AAB RID: 223915
		[Token(Token = "0x4036AAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockingObj;

		// Token: 0x04036AAC RID: 223916
		[Token(Token = "0x4036AAC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04036AAD RID: 223917
		[Token(Token = "0x4036AAD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _progressIfShowStage;

		// Token: 0x04036AAE RID: 223918
		[Token(Token = "0x4036AAE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _needUnlockStoryObj;

		// Token: 0x04036AAF RID: 223919
		[Token(Token = "0x4036AAF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _arrowCanvas;

		// Token: 0x04036AB0 RID: 223920
		[Token(Token = "0x4036AB0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _hiddenColor;

		// Token: 0x04036AB1 RID: 223921
		[Token(Token = "0x4036AB1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _showColor;

		// Token: 0x04036AB2 RID: 223922
		[Token(Token = "0x4036AB2")]
		private const float ANIMATION_ORIGIN_ALPHA = 0f;

		// Token: 0x04036AB3 RID: 223923
		[Token(Token = "0x4036AB3")]
		private const float ANIMATION_TARGET_ALPHA = 1f;

		// Token: 0x04036AB4 RID: 223924
		[Token(Token = "0x4036AB4")]
		private const float ANIMATION_DURATION = 10f;

		// Token: 0x04036AB5 RID: 223925
		[Token(Token = "0x4036AB5")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_arrowTween;

		// Token: 0x04036AB6 RID: 223926
		[Token(Token = "0x4036AB6")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x04036AB7 RID: 223927
		[Token(Token = "0x4036AB7")]
		[FieldOffset(Offset = "0x80")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x04036AB8 RID: 223928
		[Token(Token = "0x4036AB8")]
		[FieldOffset(Offset = "0x88")]
		private string m_stageId;

		// Token: 0x04036AB9 RID: 223929
		[Token(Token = "0x4036AB9")]
		[FieldOffset(Offset = "0x90")]
		private string m_keyItemId;

		// Token: 0x04036ABA RID: 223930
		[Token(Token = "0x4036ABA")]
		[FieldOffset(Offset = "0x98")]
		private bool m_ableToUnlock;

		// Token: 0x04036ABB RID: 223931
		[Token(Token = "0x4036ABB")]
		[FieldOffset(Offset = "0xA0")]
		private string m_stageCode;

		// Token: 0x04036ABC RID: 223932
		[Token(Token = "0x4036ABC")]
		[FieldOffset(Offset = "0xA8")]
		private string m_stageName;

		// Token: 0x04036ABD RID: 223933
		[Token(Token = "0x4036ABD")]
		[FieldOffset(Offset = "0xB0")]
		private string m_unlockDesc;

		// Token: 0x04036ABE RID: 223934
		[Token(Token = "0x4036ABE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04036ABF RID: 223935
		[Token(Token = "0x4036ABF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x04036AC0 RID: 223936
		[Token(Token = "0x4036AC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickUnknown;

		// Token: 0x04036AC1 RID: 223937
		[Token(Token = "0x4036AC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckOwnKeyItem;

		// Token: 0x04036AC2 RID: 223938
		[Token(Token = "0x4036AC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04036AC3 RID: 223939
		[Token(Token = "0x4036AC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069B1 RID: 27057
		[Token(Token = "0x20069B1")]
		public class StageUnlockTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x06026B91 RID: 158609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B91")]
			[Address(RVA = "0x21BD7F0", Offset = "0x21BC3F0", VA = "0x1821BD7F0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17005B6E RID: 23406
			// (get) Token: 0x06026B92 RID: 158610 RVA: 0x000CC1B0 File Offset: 0x000CA3B0
			[Token(Token = "0x17005B6E")]
			public bool isShow
			{
				[Token(Token = "0x6026B92")]
				[Address(RVA = "0x21BD920", Offset = "0x21BC520", VA = "0x1821BD920", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06026B93 RID: 158611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B93")]
			[Address(RVA = "0x21BD8C0", Offset = "0x21BC4C0", VA = "0x1821BD8C0")]
			public StageUnlockTrackPointModel()
			{
			}

			// Token: 0x04036AC4 RID: 223940
			[Token(Token = "0x4036AC4")]
			[FieldOffset(Offset = "0x10")]
			private bool m_ableToUnlock;

			// Token: 0x04036AC5 RID: 223941
			[Token(Token = "0x4036AC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04036AC6 RID: 223942
			[Token(Token = "0x4036AC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04036AC7 RID: 223943
			[Token(Token = "0x4036AC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020069B2 RID: 27058
			[Token(Token = "0x20069B2")]
			public class Param
			{
				// Token: 0x06026B94 RID: 158612 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6026B94")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04036AC8 RID: 223944
				[Token(Token = "0x4036AC8")]
				[FieldOffset(Offset = "0x10")]
				public bool ableToUnlock;
			}
		}
	}
}
