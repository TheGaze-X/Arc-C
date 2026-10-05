using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Fx;
using UnityEngine;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x02001673 RID: 5747
	[Token(Token = "0x2001673")]
	public class GachaPhase1 : GachaController.GachaPhase
	{
		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06008251 RID: 33361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F7C")]
		public RectTransform interactivePanel
		{
			[Token(Token = "0x6008251")]
			[Address(RVA = "0x2B04150", Offset = "0x2B02D50", VA = "0x182B04150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x00038CB8 File Offset: 0x00036EB8
		[Token(Token = "0x17000F7D")]
		public override bool canSkip
		{
			[Token(Token = "0x6008252")]
			[Address(RVA = "0x2B040F0", Offset = "0x2B02CF0", VA = "0x182B040F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008253")]
		[Address(RVA = "0x2B02D50", Offset = "0x2B01950", VA = "0x182B02D50", Slot = "6")]
		public override IEnumerator Play(GachaController controller, GachaController.PlayMode playMode)
		{
			return null;
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008254")]
		[Address(RVA = "0x2B035B0", Offset = "0x2B021B0", VA = "0x182B035B0")]
		private IEnumerator _PlayWithDynEntrance(GachaController controller, GachaController.PlayMode playMode, CharUISkinStruct skin)
		{
			return null;
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008255")]
		[Address(RVA = "0x2B03060", Offset = "0x2B01C60", VA = "0x182B03060", Slot = "7")]
		public override void SkipToEnd(GachaController controller, GachaController.PlayMode playMode)
		{
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008256")]
		[Address(RVA = "0x2B02F70", Offset = "0x2B01B70", VA = "0x182B02F70", Slot = "8")]
		public override IEnumerator SkipToEndAsync(GachaController controller, GachaController.PlayMode playMode)
		{
			return null;
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008257")]
		[Address(RVA = "0x2B02E40", Offset = "0x2B01A40", VA = "0x182B02E40", Slot = "9")]
		public override void PreloadSounds(GachaController.PlayMode playMode, RarityRank rarity, bool isMultipleGacha)
		{
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008258")]
		[Address(RVA = "0x2B02A60", Offset = "0x2B01660", VA = "0x182B02A60", Slot = "11")]
		public override void OnInit()
		{
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008259")]
		[Address(RVA = "0x2B02C50", Offset = "0x2B01850", VA = "0x182B02C50")]
		public void OnSkipAllBtnClicked()
		{
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825A")]
		[Address(RVA = "0x2B032B0", Offset = "0x2B01EB0", VA = "0x182B032B0")]
		private void _DoSkipToDialog(GachaController controller, GachaController.PlayMode playMode)
		{
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825B")]
		[Address(RVA = "0x2B037F0", Offset = "0x2B023F0", VA = "0x182B037F0")]
		private void _Reset()
		{
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825C")]
		[Address(RVA = "0x2B03930", Offset = "0x2B02530", VA = "0x182B03930")]
		private void _SetData(GachaController.CharacterConfig charConfig, CharacterData character, ItemBundle[] items, bool isNew)
		{
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600825D")]
		[Address(RVA = "0x2B034E0", Offset = "0x2B020E0", VA = "0x182B034E0")]
		private Texture2D _GetDisplayLogo(string powerId)
		{
			return null;
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825E")]
		[Address(RVA = "0x2B03870", Offset = "0x2B02470", VA = "0x182B03870")]
		private void _SetCanSkip(bool canSkip)
		{
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600825F")]
		[Address(RVA = "0x2B036E0", Offset = "0x2B022E0", VA = "0x182B036E0")]
		private void _ResetPopStars()
		{
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008260")]
		[Address(RVA = "0x2B028A0", Offset = "0x2B014A0", VA = "0x182B028A0", Slot = "12")]
		protected override void OnDisposeForReuse()
		{
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008261")]
		[Address(RVA = "0x2B03FB0", Offset = "0x2B02BB0", VA = "0x182B03FB0")]
		public GachaPhase1()
		{
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008262")]
		[Address(RVA = "0x2B031D0", Offset = "0x2B01DD0", VA = "0x182B031D0")]
		private IEnumerator <>xLuaBaseProxy_SkipToEndAsync(GachaController P0, GachaController.PlayMode P1)
		{
			return null;
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008263")]
		[Address(RVA = "0x2B02020", Offset = "0x2B00C20", VA = "0x182B02020")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008264")]
		[Address(RVA = "0x2B01FC0", Offset = "0x2B00BC0", VA = "0x182B01FC0")]
		private void <>xLuaBaseProxy_OnDisposeForReuse()
		{
		}

		// Token: 0x0400847D RID: 33917
		[Token(Token = "0x400847D")]
		private const string MASK_TEXTURE = "_MaskTex";

		// Token: 0x0400847E RID: 33918
		[Token(Token = "0x400847E")]
		private const float FORWARD_PARTICLE_SYSTEM_SIMULATE_TIME_ON_SKIP = 30f;

		// Token: 0x0400847F RID: 33919
		[Token(Token = "0x400847F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _playTime;

		// Token: 0x04008480 RID: 33920
		[Token(Token = "0x4008480")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04008481 RID: 33921
		[Token(Token = "0x4008481")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Replacement")]
		private Renderer[] _campRenderers;

		// Token: 0x04008482 RID: 33922
		[Token(Token = "0x4008482")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Replacement")]
		private Renderer[] _characterMaskRenderers;

		// Token: 0x04008483 RID: 33923
		[Token(Token = "0x4008483")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("UI")]
		private PanelCharacterIllust _characterillust;

		// Token: 0x04008484 RID: 33924
		[Token(Token = "0x4008484")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("UI")]
		private PanelCharacterInfo _characterInfo;

		// Token: 0x04008485 RID: 33925
		[Token(Token = "0x4008485")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("UI")]
		private PanelCharacterDialog _characterDialog;

		// Token: 0x04008486 RID: 33926
		[Token(Token = "0x4008486")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("UI")]
		private RectTransform _interactivePanel;

		// Token: 0x04008487 RID: 33927
		[Token(Token = "0x4008487")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("UI")]
		private RectTransform _skipAllBtn;

		// Token: 0x04008488 RID: 33928
		[Token(Token = "0x4008488")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Animation")]
		private Animation _animation;

		// Token: 0x04008489 RID: 33929
		[Token(Token = "0x4008489")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Animation")]
		[Collection(typeof(RarityRank))]
		private AnimationClip[] _rarityAnimations;

		// Token: 0x0400848A RID: 33930
		[Token(Token = "0x400848A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FxDelay _imageIllust;

		// Token: 0x0400848B RID: 33931
		[Token(Token = "0x400848B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _inactiveWhenSkip;

		// Token: 0x0400848C RID: 33932
		[Token(Token = "0x400848C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _popStarsToReset;

		// Token: 0x0400848D RID: 33933
		[Token(Token = "0x400848D")]
		[FieldOffset(Offset = "0x88")]
		private GachaController m_controller;

		// Token: 0x0400848E RID: 33934
		[Token(Token = "0x400848E")]
		[FieldOffset(Offset = "0x90")]
		private CharacterData m_character;

		// Token: 0x0400848F RID: 33935
		[Token(Token = "0x400848F")]
		[FieldOffset(Offset = "0x98")]
		private bool m_canSkip;

		// Token: 0x04008490 RID: 33936
		[Token(Token = "0x4008490")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interactivePanel;

		// Token: 0x04008491 RID: 33937
		[Token(Token = "0x4008491")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canSkip;

		// Token: 0x04008492 RID: 33938
		[Token(Token = "0x4008492")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x04008493 RID: 33939
		[Token(Token = "0x4008493")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayWithDynEntrance;

		// Token: 0x04008494 RID: 33940
		[Token(Token = "0x4008494")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SkipToEnd;

		// Token: 0x04008495 RID: 33941
		[Token(Token = "0x4008495")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SkipToEndAsync;

		// Token: 0x04008496 RID: 33942
		[Token(Token = "0x4008496")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreloadSounds;

		// Token: 0x04008497 RID: 33943
		[Token(Token = "0x4008497")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008498 RID: 33944
		[Token(Token = "0x4008498")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSkipAllBtnClicked;

		// Token: 0x04008499 RID: 33945
		[Token(Token = "0x4008499")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoSkipToDialog;

		// Token: 0x0400849A RID: 33946
		[Token(Token = "0x400849A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400849B RID: 33947
		[Token(Token = "0x400849B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x0400849C RID: 33948
		[Token(Token = "0x400849C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetDisplayLogo;

		// Token: 0x0400849D RID: 33949
		[Token(Token = "0x400849D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetCanSkip;

		// Token: 0x0400849E RID: 33950
		[Token(Token = "0x400849E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetPopStars;

		// Token: 0x0400849F RID: 33951
		[Token(Token = "0x400849F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisposeForReuse;

		// Token: 0x040084A0 RID: 33952
		[Token(Token = "0x40084A0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
