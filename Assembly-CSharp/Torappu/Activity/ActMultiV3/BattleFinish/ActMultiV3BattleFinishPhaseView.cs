using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007090 RID: 28816
	[Token(Token = "0x2007090")]
	public abstract class ActMultiV3BattleFinishPhaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x06028EF8 RID: 167672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028EF9 RID: 167673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060DE")]
		public Action onBtnReprotClick
		{
			[Token(Token = "0x6028EF8")]
			[Address(RVA = "0x244DCD0", Offset = "0x244C8D0", VA = "0x18244DCD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028EF9")]
			[Address(RVA = "0x244DD30", Offset = "0x244C930", VA = "0x18244DD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028EFA RID: 167674
		[Token(Token = "0x6028EFA")]
		protected abstract void OnInit();

		// Token: 0x06028EFB RID: 167675
		[Token(Token = "0x6028EFB")]
		public abstract IEnumerator ShowCoroutine();

		// Token: 0x06028EFC RID: 167676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EFC")]
		[Address(RVA = "0x244D950", Offset = "0x244C550", VA = "0x18244D950")]
		public void TriggerInit(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028EFD RID: 167677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EFD")]
		[Address(RVA = "0x244DBC0", Offset = "0x244C7C0", VA = "0x18244DBC0")]
		public void UpdateReportStatus(bool canReport, bool hasReported)
		{
		}

		// Token: 0x06028EFE RID: 167678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EFE")]
		[Address(RVA = "0x244D840", Offset = "0x244C440", VA = "0x18244D840")]
		public void EventOnBtnReprotClick()
		{
		}

		// Token: 0x06028EFF RID: 167679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EFF")]
		[Address(RVA = "0x244DC70", Offset = "0x244C870", VA = "0x18244DC70")]
		protected ActMultiV3BattleFinishPhaseView()
		{
		}

		// Token: 0x0403A69F RID: 239263
		[Token(Token = "0x403A69F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnReportGO;

		// Token: 0x0403A6A0 RID: 239264
		[Token(Token = "0x403A6A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _reportSuccGO;

		// Token: 0x0403A6A1 RID: 239265
		[Token(Token = "0x403A6A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3CommonBottomBar _bottomBarPrefab;

		// Token: 0x0403A6A2 RID: 239266
		[Token(Token = "0x403A6A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _bottomBarContainer;

		// Token: 0x0403A6A3 RID: 239267
		[Token(Token = "0x403A6A3")]
		[FieldOffset(Offset = "0x38")]
		protected ActMultiV3BattleFinishViewModel m_viewModel;

		// Token: 0x0403A6A4 RID: 239268
		[Token(Token = "0x403A6A4")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3CommonBottomBar m_bottomBar;

		// Token: 0x0403A6A6 RID: 239270
		[Token(Token = "0x403A6A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnReprotClick;

		// Token: 0x0403A6A7 RID: 239271
		[Token(Token = "0x403A6A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnReprotClick;

		// Token: 0x0403A6A8 RID: 239272
		[Token(Token = "0x403A6A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerInit;

		// Token: 0x0403A6A9 RID: 239273
		[Token(Token = "0x403A6A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateReportStatus;

		// Token: 0x0403A6AA RID: 239274
		[Token(Token = "0x403A6AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnReprotClick;

		// Token: 0x0403A6AB RID: 239275
		[Token(Token = "0x403A6AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
