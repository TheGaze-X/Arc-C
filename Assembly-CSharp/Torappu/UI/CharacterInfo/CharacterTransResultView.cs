using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F3D RID: 24381
	[Token(Token = "0x2005F3D")]
	public class CharacterTransResultView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060234E8 RID: 144616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E8")]
		[Address(RVA = "0x1DE01E0", Offset = "0x1DDEDE0", VA = "0x181DE01E0")]
		private void Awake()
		{
		}

		// Token: 0x060234E9 RID: 144617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E9")]
		[Address(RVA = "0x1DE03F0", Offset = "0x1DDEFF0", VA = "0x181DE03F0")]
		public void Setup(CharUISkinStruct illustSkin, int transIndex, Action endCB)
		{
		}

		// Token: 0x060234EA RID: 144618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234EA")]
		[Address(RVA = "0x1DE0AE0", Offset = "0x1DDF6E0", VA = "0x181DE0AE0")]
		private void _SetupIllustColorInst(UICharacterIllustLoader illustLoader, CharUISkinStruct illustSkin)
		{
		}

		// Token: 0x060234EB RID: 144619 RVA: 0x000C0870 File Offset: 0x000BEA70
		[Token(Token = "0x60234EB")]
		[Address(RVA = "0x1DE0A10", Offset = "0x1DDF610", VA = "0x181DE0A10")]
		private static bool _IsAlphaSplitMaterial(Material mat)
		{
			return default(bool);
		}

		// Token: 0x060234EC RID: 144620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234EC")]
		[Address(RVA = "0x1DE0830", Offset = "0x1DDF430", VA = "0x181DE0830")]
		public void StartMotion()
		{
		}

		// Token: 0x060234ED RID: 144621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234ED")]
		[Address(RVA = "0x1DE02B0", Offset = "0x1DDEEB0", VA = "0x181DE02B0")]
		public void OnBGPressed()
		{
		}

		// Token: 0x060234EE RID: 144622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234EE")]
		[Address(RVA = "0x1DE0330", Offset = "0x1DDEF30", VA = "0x181DE0330")]
		private void OnDestroy()
		{
		}

		// Token: 0x060234EF RID: 144623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234EF")]
		[Address(RVA = "0x1DE07B0", Offset = "0x1DDF3B0", VA = "0x181DE07B0")]
		public void ShowExtraEffect(bool show)
		{
		}

		// Token: 0x060234F0 RID: 144624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60234F0")]
		[Address(RVA = "0x1DE0960", Offset = "0x1DDF560", VA = "0x181DE0960")]
		private IEnumerator _EffectMotion()
		{
			return null;
		}

		// Token: 0x060234F1 RID: 144625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234F1")]
		[Address(RVA = "0x1DE0F30", Offset = "0x1DDFB30", VA = "0x181DE0F30")]
		public CharacterTransResultView()
		{
		}

		// Token: 0x04030B4C RID: 199500
		[Token(Token = "0x4030B4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x04030B4D RID: 199501
		[Token(Token = "0x4030B4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _illustColorContainer;

		// Token: 0x04030B4E RID: 199502
		[Token(Token = "0x4030B4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterTransResultView.TransMark[] _transMarks;

		// Token: 0x04030B4F RID: 199503
		[Token(Token = "0x4030B4F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hintPanel;

		// Token: 0x04030B50 RID: 199504
		[Token(Token = "0x4030B50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _yesImage;

		// Token: 0x04030B51 RID: 199505
		[Token(Token = "0x4030B51")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Material _pureColorMat;

		// Token: 0x04030B52 RID: 199506
		[Token(Token = "0x4030B52")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Graphic _hotspotImage;

		// Token: 0x04030B53 RID: 199507
		[Token(Token = "0x4030B53")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _background0;

		// Token: 0x04030B54 RID: 199508
		[Token(Token = "0x4030B54")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _background1;

		// Token: 0x04030B55 RID: 199509
		[Token(Token = "0x4030B55")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _whiteCover;

		// Token: 0x04030B56 RID: 199510
		[Token(Token = "0x4030B56")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _extraIconParticleSystem;

		// Token: 0x04030B57 RID: 199511
		[Token(Token = "0x4030B57")]
		[FieldOffset(Offset = "0x70")]
		private UICharacterIllust m_illustInst;

		// Token: 0x04030B58 RID: 199512
		[Token(Token = "0x4030B58")]
		[FieldOffset(Offset = "0x78")]
		private UICharacterIllust m_illustColorInst;

		// Token: 0x04030B59 RID: 199513
		[Token(Token = "0x4030B59")]
		[FieldOffset(Offset = "0x80")]
		private CharacterTransResultView.TransMark m_curTransMark;

		// Token: 0x04030B5A RID: 199514
		[Token(Token = "0x4030B5A")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine m_effectMotionCoroutine;

		// Token: 0x04030B5B RID: 199515
		[Token(Token = "0x4030B5B")]
		[FieldOffset(Offset = "0x90")]
		private Action m_endCB;

		// Token: 0x04030B5C RID: 199516
		[Token(Token = "0x4030B5C")]
		[FieldOffset(Offset = "0x98")]
		private CanvasGroup m_hintCanvasGroup;

		// Token: 0x04030B5D RID: 199517
		[Token(Token = "0x4030B5D")]
		[FieldOffset(Offset = "0xA0")]
		private Material m_illustNewMaterial;

		// Token: 0x04030B5E RID: 199518
		[Token(Token = "0x4030B5E")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 m_hintOriginPos;

		// Token: 0x04030B5F RID: 199519
		[Token(Token = "0x4030B5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04030B60 RID: 199520
		[Token(Token = "0x4030B60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04030B61 RID: 199521
		[Token(Token = "0x4030B61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetupIllustColorInst;

		// Token: 0x04030B62 RID: 199522
		[Token(Token = "0x4030B62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsAlphaSplitMaterial;

		// Token: 0x04030B63 RID: 199523
		[Token(Token = "0x4030B63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartMotion;

		// Token: 0x04030B64 RID: 199524
		[Token(Token = "0x4030B64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBGPressed;

		// Token: 0x04030B65 RID: 199525
		[Token(Token = "0x4030B65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04030B66 RID: 199526
		[Token(Token = "0x4030B66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowExtraEffect;

		// Token: 0x04030B67 RID: 199527
		[Token(Token = "0x4030B67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EffectMotion;

		// Token: 0x04030B68 RID: 199528
		[Token(Token = "0x4030B68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F3E RID: 24382
		[Token(Token = "0x2005F3E")]
		[Serializable]
		public class TransMark
		{
			// Token: 0x060234F2 RID: 144626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60234F2")]
			[Address(RVA = "0x1DE5890", Offset = "0x1DE4490", VA = "0x181DE5890")]
			public void SetVisible(bool visible)
			{
			}

			// Token: 0x060234F3 RID: 144627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60234F3")]
			[Address(RVA = "0x1DE58C0", Offset = "0x1DE44C0", VA = "0x181DE58C0")]
			public void TriggerEffect()
			{
			}

			// Token: 0x060234F4 RID: 144628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60234F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TransMark()
			{
			}

			// Token: 0x04030B69 RID: 199529
			[Token(Token = "0x4030B69")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x04030B6A RID: 199530
			[Token(Token = "0x4030B6A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _effect;
		}
	}
}
