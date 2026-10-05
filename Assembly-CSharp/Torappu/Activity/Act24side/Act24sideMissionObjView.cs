using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075D9 RID: 30169
	[Token(Token = "0x20075D9")]
	public class Act24sideMissionObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A7A5 RID: 173989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A5")]
		[Address(RVA = "0x2627BE0", Offset = "0x26267E0", VA = "0x182627BE0")]
		public void Render(Act24sideMissionObjViewModel model)
		{
		}

		// Token: 0x0602A7A6 RID: 173990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A6")]
		[Address(RVA = "0x2627AF0", Offset = "0x26266F0", VA = "0x182627AF0")]
		public void OnClickCompleteBtn()
		{
		}

		// Token: 0x0602A7A7 RID: 173991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A7")]
		[Address(RVA = "0x2627B70", Offset = "0x2626770", VA = "0x182627B70")]
		public void OnClickDetailBtn()
		{
		}

		// Token: 0x0602A7A8 RID: 173992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A8")]
		[Address(RVA = "0x2627D80", Offset = "0x2626980", VA = "0x182627D80")]
		public Act24sideMissionObjView()
		{
		}

		// Token: 0x0403D233 RID: 250419
		[Token(Token = "0x403D233")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionTitle;

		// Token: 0x0403D234 RID: 250420
		[Token(Token = "0x403D234")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x0403D235 RID: 250421
		[Token(Token = "0x403D235")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCompleted;

		// Token: 0x0403D236 RID: 250422
		[Token(Token = "0x403D236")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completeBtn;

		// Token: 0x0403D237 RID: 250423
		[Token(Token = "0x403D237")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act24sideMissionStampView _stampView;

		// Token: 0x0403D238 RID: 250424
		[Token(Token = "0x403D238")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act24sideMissionAbstractDelegateTileView _delegateView;

		// Token: 0x0403D239 RID: 250425
		[Token(Token = "0x403D239")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act24sideMissionRewardListView _rewardListView;

		// Token: 0x0403D23A RID: 250426
		[Token(Token = "0x403D23A")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onClickCompleleBtn;

		// Token: 0x0403D23B RID: 250427
		[Token(Token = "0x403D23B")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<string> onClickDetailBtn;

		// Token: 0x0403D23C RID: 250428
		[Token(Token = "0x403D23C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isCanComplete;

		// Token: 0x0403D23D RID: 250429
		[Token(Token = "0x403D23D")]
		[FieldOffset(Offset = "0x68")]
		private string m_missionId;

		// Token: 0x0403D23E RID: 250430
		[Token(Token = "0x403D23E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D23F RID: 250431
		[Token(Token = "0x403D23F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickCompleteBtn;

		// Token: 0x0403D240 RID: 250432
		[Token(Token = "0x403D240")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickDetailBtn;

		// Token: 0x0403D241 RID: 250433
		[Token(Token = "0x403D241")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
