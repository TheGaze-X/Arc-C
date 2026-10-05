using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007239 RID: 29241
	[Token(Token = "0x2007239")]
	public class Act5D1RuneStageDetailText : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296FA RID: 169722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296FA")]
		[Address(RVA = "0x24CBE00", Offset = "0x24CAA00", VA = "0x1824CBE00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060296FB RID: 169723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296FB")]
		[Address(RVA = "0x24CBE60", Offset = "0x24CAA60", VA = "0x1824CBE60")]
		public void RenderInfo(RuneInfo runeInfo)
		{
		}

		// Token: 0x060296FC RID: 169724 RVA: 0x000D5AE0 File Offset: 0x000D3CE0
		[Token(Token = "0x60296FC")]
		[Address(RVA = "0x24CC370", Offset = "0x24CAF70", VA = "0x1824CC370")]
		private bool _ResetTween()
		{
			return default(bool);
		}

		// Token: 0x060296FD RID: 169725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296FD")]
		[Address(RVA = "0x24CC410", Offset = "0x24CB010", VA = "0x1824CC410")]
		private void _TransitionFirst()
		{
		}

		// Token: 0x060296FE RID: 169726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296FE")]
		[Address(RVA = "0x24CC550", Offset = "0x24CB150", VA = "0x1824CC550")]
		private void _TransitionSecond(float delay = 0f)
		{
		}

		// Token: 0x060296FF RID: 169727 RVA: 0x000D5AF8 File Offset: 0x000D3CF8
		[Token(Token = "0x60296FF")]
		[Address(RVA = "0x24CC140", Offset = "0x24CAD40", VA = "0x1824CC140")]
		private bool _RenderStatus()
		{
			return default(bool);
		}

		// Token: 0x06029700 RID: 169728 RVA: 0x000D5B10 File Offset: 0x000D3D10
		[Token(Token = "0x6029700")]
		[Address(RVA = "0x24CC690", Offset = "0x24CB290", VA = "0x1824CC690")]
		private bool _ValidateComps()
		{
			return default(bool);
		}

		// Token: 0x06029701 RID: 169729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029701")]
		[Address(RVA = "0x24CC750", Offset = "0x24CB350", VA = "0x1824CC750")]
		public Act5D1RuneStageDetailText()
		{
		}

		// Token: 0x0403B325 RID: 242469
		[Token(Token = "0x403B325")]
		private const float FADE_DUR = 0.16f;

		// Token: 0x0403B326 RID: 242470
		[Token(Token = "0x403B326")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403B327 RID: 242471
		[Token(Token = "0x403B327")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0403B328 RID: 242472
		[Token(Token = "0x403B328")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403B329 RID: 242473
		[Token(Token = "0x403B329")]
		[FieldOffset(Offset = "0x30")]
		private Act5D1RuneStageDetailText.Status m_status;

		// Token: 0x0403B32A RID: 242474
		[Token(Token = "0x403B32A")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0403B32B RID: 242475
		[Token(Token = "0x403B32B")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInterruptedTween;

		// Token: 0x0403B32C RID: 242476
		[Token(Token = "0x403B32C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403B32D RID: 242477
		[Token(Token = "0x403B32D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403B32E RID: 242478
		[Token(Token = "0x403B32E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetTween;

		// Token: 0x0403B32F RID: 242479
		[Token(Token = "0x403B32F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TransitionFirst;

		// Token: 0x0403B330 RID: 242480
		[Token(Token = "0x403B330")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TransitionSecond;

		// Token: 0x0403B331 RID: 242481
		[Token(Token = "0x403B331")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderStatus;

		// Token: 0x0403B332 RID: 242482
		[Token(Token = "0x403B332")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ValidateComps;

		// Token: 0x0403B333 RID: 242483
		[Token(Token = "0x403B333")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200723A RID: 29242
		[Token(Token = "0x200723A")]
		private struct Status
		{
			// Token: 0x06029703 RID: 169731 RVA: 0x000D5B28 File Offset: 0x000D3D28
			[Token(Token = "0x6029703")]
			[Address(RVA = "0x24D6130", Offset = "0x24D4D30", VA = "0x1824D6130")]
			public static Act5D1RuneStageDetailText.Status Create(RuneInfo runeInfo)
			{
				return default(Act5D1RuneStageDetailText.Status);
			}

			// Token: 0x0403B334 RID: 242484
			[Token(Token = "0x403B334")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Act5D1RuneStageDetailText.Status EMPTY;

			// Token: 0x0403B335 RID: 242485
			[Token(Token = "0x403B335")]
			[FieldOffset(Offset = "0x0")]
			public string desc;

			// Token: 0x0403B336 RID: 242486
			[Token(Token = "0x403B336")]
			[FieldOffset(Offset = "0x8")]
			public bool isNewHand;
		}
	}
}
