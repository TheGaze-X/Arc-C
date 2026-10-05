using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA6 RID: 24486
	[Token(Token = "0x2005FA6")]
	public class CharacterInfoRightProfMasterView : CharacterInfoRightProfObj
	{
		// Token: 0x060236CF RID: 145103 RVA: 0x000C0DB0 File Offset: 0x000BEFB0
		[Token(Token = "0x60236CF")]
		[Address(RVA = "0x1E061C0", Offset = "0x1E04DC0", VA = "0x181E061C0", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236D0 RID: 145104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236D0")]
		[Address(RVA = "0x1E062A0", Offset = "0x1E04EA0", VA = "0x181E062A0")]
		public void Render(CharacterMasterViewModel viewModel)
		{
		}

		// Token: 0x060236D1 RID: 145105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60236D1")]
		[Address(RVA = "0x1E06730", Offset = "0x1E05330", VA = "0x181E06730")]
		private string _GetNotifyText(MasterUnlockType unlockType)
		{
			return null;
		}

		// Token: 0x060236D2 RID: 145106 RVA: 0x000C0DC8 File Offset: 0x000BEFC8
		[Token(Token = "0x60236D2")]
		[Address(RVA = "0x1E06840", Offset = "0x1E05440", VA = "0x181E06840")]
		private CharacterInfoRightProfMasterView.UnlockIconConfig _GetUnlockConfig(EvolvePhase unlockPhase, MasterUnlockType unlockType)
		{
			return default(CharacterInfoRightProfMasterView.UnlockIconConfig);
		}

		// Token: 0x060236D3 RID: 145107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236D3")]
		[Address(RVA = "0x1E069F0", Offset = "0x1E055F0", VA = "0x181E069F0")]
		public CharacterInfoRightProfMasterView()
		{
		}

		// Token: 0x04030F35 RID: 200501
		[Token(Token = "0x4030F35")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _masterName;

		// Token: 0x04030F36 RID: 200502
		[Token(Token = "0x4030F36")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _masterContent;

		// Token: 0x04030F37 RID: 200503
		[Token(Token = "0x4030F37")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unlockNotifyGo;

		// Token: 0x04030F38 RID: 200504
		[Token(Token = "0x4030F38")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _unlockIcon;

		// Token: 0x04030F39 RID: 200505
		[Token(Token = "0x4030F39")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterInfoRightProfMasterView.UnlockIconConfig[] _unlockIconConfigs;

		// Token: 0x04030F3A RID: 200506
		[Token(Token = "0x4030F3A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _unlockNotifyText;

		// Token: 0x04030F3B RID: 200507
		[Token(Token = "0x4030F3B")]
		[FieldOffset(Offset = "0x50")]
		private TextGenerator m_textGenerate;

		// Token: 0x04030F3C RID: 200508
		[Token(Token = "0x4030F3C")]
		[FieldOffset(Offset = "0x58")]
		private CharacterMasterViewModel m_viewModel;

		// Token: 0x04030F3D RID: 200509
		[Token(Token = "0x4030F3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F3E RID: 200510
		[Token(Token = "0x4030F3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F3F RID: 200511
		[Token(Token = "0x4030F3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetNotifyText;

		// Token: 0x04030F40 RID: 200512
		[Token(Token = "0x4030F40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetUnlockConfig;

		// Token: 0x04030F41 RID: 200513
		[Token(Token = "0x4030F41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FA7 RID: 24487
		[Token(Token = "0x2005FA7")]
		[Serializable]
		private struct UnlockIconConfig
		{
			// Token: 0x04030F42 RID: 200514
			[Token(Token = "0x4030F42")]
			[FieldOffset(Offset = "0x0")]
			public EvolvePhase unlockPhase;

			// Token: 0x04030F43 RID: 200515
			[Token(Token = "0x4030F43")]
			[FieldOffset(Offset = "0x4")]
			public MasterUnlockType unlockType;

			// Token: 0x04030F44 RID: 200516
			[Token(Token = "0x4030F44")]
			[FieldOffset(Offset = "0x8")]
			public Sprite iconSprite;

			// Token: 0x04030F45 RID: 200517
			[Token(Token = "0x4030F45")]
			[FieldOffset(Offset = "0x10")]
			public Color iconColor;
		}
	}
}
