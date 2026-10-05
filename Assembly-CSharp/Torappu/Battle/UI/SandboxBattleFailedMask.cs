using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328A RID: 12938
	[Token(Token = "0x200328A")]
	public class SandboxBattleFailedMask : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0601488B RID: 84107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700309C")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x601488B")]
			[Address(RVA = "0xCD4880", Offset = "0xCD3480", VA = "0x180CD4880")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601488C RID: 84108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601488C")]
		[Address(RVA = "0xCD4440", Offset = "0xCD3040", VA = "0x180CD4440")]
		public void OnPanelClick()
		{
		}

		// Token: 0x0601488D RID: 84109 RVA: 0x00087600 File Offset: 0x00085800
		[Token(Token = "0x601488D")]
		[Address(RVA = "0xCD3F60", Offset = "0xCD2B60", VA = "0x180CD3F60")]
		public bool BattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x0601488E RID: 84110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601488E")]
		[Address(RVA = "0xCD3FE0", Offset = "0xCD2BE0", VA = "0x180CD3FE0")]
		public RectTransform BattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x0601488F RID: 84111 RVA: 0x00087618 File Offset: 0x00085818
		[Token(Token = "0x601488F")]
		[Address(RVA = "0xCD4050", Offset = "0xCD2C50", VA = "0x180CD4050")]
		public bool BattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014890 RID: 84112 RVA: 0x00087630 File Offset: 0x00085830
		[Token(Token = "0x6014890")]
		[Address(RVA = "0xCD4700", Offset = "0xCD3300", VA = "0x180CD4700")]
		private bool _NeedShowBattleFail()
		{
			return default(bool);
		}

		// Token: 0x06014891 RID: 84113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014891")]
		[Address(RVA = "0xCD45E0", Offset = "0xCD31E0", VA = "0x180CD45E0")]
		public void PlayAnim(string stateName, Action<string> onAnimEnd)
		{
		}

		// Token: 0x06014892 RID: 84114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014892")]
		[Address(RVA = "0xCD4820", Offset = "0xCD3420", VA = "0x180CD4820")]
		public SandboxBattleFailedMask()
		{
		}

		// Token: 0x04018469 RID: 99433
		[Token(Token = "0x4018469")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _basementStatusView;

		// Token: 0x0401846A RID: 99434
		[Token(Token = "0x401846A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _mobileBasementStatusView;

		// Token: 0x0401846B RID: 99435
		[Token(Token = "0x401846B")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2NodeType m_currentNodeType;

		// Token: 0x0401846C RID: 99436
		[Token(Token = "0x401846C")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_hooked;

		// Token: 0x0401846D RID: 99437
		[Token(Token = "0x401846D")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_statusView;

		// Token: 0x0401846E RID: 99438
		[Token(Token = "0x401846E")]
		[FieldOffset(Offset = "0x38")]
		private AnimationWrapper m_statusViewAnimation;

		// Token: 0x0401846F RID: 99439
		[Token(Token = "0x401846F")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x04018470 RID: 99440
		[Token(Token = "0x4018470")]
		private const string ENTRY = "sandboxv2_basement_status_entry";

		// Token: 0x04018471 RID: 99441
		[Token(Token = "0x4018471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x04018472 RID: 99442
		[Token(Token = "0x4018472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPanelClick;

		// Token: 0x04018473 RID: 99443
		[Token(Token = "0x4018473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelHide;

		// Token: 0x04018474 RID: 99444
		[Token(Token = "0x4018474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelInit;

		// Token: 0x04018475 RID: 99445
		[Token(Token = "0x4018475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelShow;

		// Token: 0x04018476 RID: 99446
		[Token(Token = "0x4018476")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NeedShowBattleFail;

		// Token: 0x04018477 RID: 99447
		[Token(Token = "0x4018477")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04018478 RID: 99448
		[Token(Token = "0x4018478")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
