using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002118 RID: 8472
	[Token(Token = "0x2002118")]
	public class EmptyAnimator : UnitAnimator
	{
		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600CFA9 RID: 53161 RVA: 0x0004AF10 File Offset: 0x00049110
		// (set) Token: 0x0600CFAA RID: 53162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018B4")]
		public override Color color
		{
			[Token(Token = "0x600CFA9")]
			[Address(RVA = "0x350E930", Offset = "0x350D530", VA = "0x18350E930", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600CFAA")]
			[Address(RVA = "0x350EEC0", Offset = "0x350DAC0", VA = "0x18350EEC0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x0600CFAB RID: 53163 RVA: 0x0004AF28 File Offset: 0x00049128
		[Token(Token = "0x170018B5")]
		public override int faceSign
		{
			[Token(Token = "0x600CFAB")]
			[Address(RVA = "0x350EAD0", Offset = "0x350D6D0", VA = "0x18350EAD0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x0004AF40 File Offset: 0x00049140
		[Token(Token = "0x170018B6")]
		public bool enableWhiteList
		{
			[Token(Token = "0x600CFAC")]
			[Address(RVA = "0x350EA10", Offset = "0x350D610", VA = "0x18350EA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600CFAD RID: 53165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018B7")]
		public List<string> effectWhiteList
		{
			[Token(Token = "0x600CFAD")]
			[Address(RVA = "0x350E9B0", Offset = "0x350D5B0", VA = "0x18350E9B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600CFAE RID: 53166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018B8")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600CFAE")]
			[Address(RVA = "0x350EB90", Offset = "0x350D790", VA = "0x18350EB90", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600CFAF RID: 53167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018B9")]
		protected override Transform muzzleTransform
		{
			[Token(Token = "0x600CFAF")]
			[Address(RVA = "0x350ED50", Offset = "0x350D950", VA = "0x18350ED50", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600CFB0 RID: 53168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018BA")]
		public override Transform hitTransform
		{
			[Token(Token = "0x600CFB0")]
			[Address(RVA = "0x350ECA0", Offset = "0x350D8A0", VA = "0x18350ECA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600CFB1 RID: 53169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018BB")]
		public override Transform footTransform
		{
			[Token(Token = "0x600CFB1")]
			[Address(RVA = "0x350EB30", Offset = "0x350D730", VA = "0x18350EB30", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600CFB2 RID: 53170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018BC")]
		public override Transform headTransform
		{
			[Token(Token = "0x600CFB2")]
			[Address(RVA = "0x350EBF0", Offset = "0x350D7F0", VA = "0x18350EBF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x0600CFB3 RID: 53171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018BD")]
		public override Transform shadowTransform
		{
			[Token(Token = "0x600CFB3")]
			[Address(RVA = "0x350EE00", Offset = "0x350DA00", VA = "0x18350EE00", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600CFB4 RID: 53172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018BE")]
		public override CharacterSkinHooker skinHooker
		{
			[Token(Token = "0x600CFB4")]
			[Address(RVA = "0x350EE60", Offset = "0x350DA60", VA = "0x18350EE60", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFB5")]
		[Address(RVA = "0x350E140", Offset = "0x350CD40", VA = "0x18350E140", Slot = "46")]
		protected override void Awake()
		{
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFB6")]
		[Address(RVA = "0x350E5A0", Offset = "0x350D1A0", VA = "0x18350E5A0", Slot = "23")]
		public override void Stop()
		{
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x0004AF58 File Offset: 0x00049158
		[Token(Token = "0x600CFB7")]
		[Address(RVA = "0x350E510", Offset = "0x350D110", VA = "0x18350E510", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x0004AF70 File Offset: 0x00049170
		[Token(Token = "0x600CFB8")]
		[Address(RVA = "0x350E1D0", Offset = "0x350CDD0", VA = "0x18350E1D0", Slot = "41")]
		protected override bool ContainsAnimationInternal(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x0004AF88 File Offset: 0x00049188
		[Token(Token = "0x600CFB9")]
		[Address(RVA = "0x350E260", Offset = "0x350CE60", VA = "0x18350E260", Slot = "42")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[Token(Token = "0x600CFBA")]
		[Address(RVA = "0x350E2F0", Offset = "0x350CEF0", VA = "0x18350E2F0", Slot = "43")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFBB")]
		[Address(RVA = "0x350E410", Offset = "0x350D010", VA = "0x18350E410", Slot = "32")]
		public override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFBC")]
		[Address(RVA = "0x350E4B0", Offset = "0x350D0B0", VA = "0x18350E4B0", Slot = "33")]
		public override void OnTakeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600CFBD RID: 53181 RVA: 0x0004AFB8 File Offset: 0x000491B8
		[Token(Token = "0x600CFBD")]
		[Address(RVA = "0x350E390", Offset = "0x350CF90", VA = "0x18350E390", Slot = "39")]
		public override UnitAnimator.CurrentAniState GetCurrentAniState()
		{
			return default(UnitAnimator.CurrentAniState);
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x0004AFD0 File Offset: 0x000491D0
		[Token(Token = "0x600CFBE")]
		[Address(RVA = "0x350E600", Offset = "0x350D200", VA = "0x18350E600", Slot = "35")]
		public override bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600CFBF RID: 53183 RVA: 0x0004AFE8 File Offset: 0x000491E8
		[Token(Token = "0x600CFBF")]
		[Address(RVA = "0x350E710", Offset = "0x350D310", VA = "0x18350E710", Slot = "36")]
		public override bool TryIgnoreEffect(string originEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600CFC0 RID: 53184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFC0")]
		[Address(RVA = "0x350E8D0", Offset = "0x350D4D0", VA = "0x18350E8D0")]
		public EmptyAnimator()
		{
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x0004B000 File Offset: 0x00049200
		[Token(Token = "0x600CFC1")]
		[Address(RVA = "0x350BA20", Offset = "0x350A620", VA = "0x18350BA20")]
		private int <>xLuaBaseProxy_get_faceSign()
		{
			return 0;
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CFC2")]
		[Address(RVA = "0x350E8C0", Offset = "0x350D4C0", VA = "0x18350E8C0")]
		private CharacterSkinHooker <>xLuaBaseProxy_get_skinHooker()
		{
			return null;
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFC3")]
		[Address(RVA = "0x350E880", Offset = "0x350D480", VA = "0x18350E880")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0600CFC4 RID: 53188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFC4")]
		[Address(RVA = "0x350E890", Offset = "0x350D490", VA = "0x18350E890")]
		private void <>xLuaBaseProxy_Stop()
		{
		}

		// Token: 0x0600CFC5 RID: 53189 RVA: 0x0004B018 File Offset: 0x00049218
		[Token(Token = "0x600CFC5")]
		[Address(RVA = "0x350E8A0", Offset = "0x350D4A0", VA = "0x18350E8A0")]
		private bool <>xLuaBaseProxy_TryHookEffect(string P0, out string P1)
		{
			return default(bool);
		}

		// Token: 0x0600CFC6 RID: 53190 RVA: 0x0004B030 File Offset: 0x00049230
		[Token(Token = "0x600CFC6")]
		[Address(RVA = "0x350E8B0", Offset = "0x350D4B0", VA = "0x18350E8B0")]
		private bool <>xLuaBaseProxy_TryIgnoreEffect(string P0)
		{
			return default(bool);
		}

		// Token: 0x0400DDCF RID: 56783
		[Token(Token = "0x400DDCF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _hitTransform;

		// Token: 0x0400DDD0 RID: 56784
		[Token(Token = "0x400DDD0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _headTransform;

		// Token: 0x0400DDD1 RID: 56785
		[Token(Token = "0x400DDD1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _muzzle;

		// Token: 0x0400DDD2 RID: 56786
		[Token(Token = "0x400DDD2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<string> _effectWhiteList;

		// Token: 0x0400DDD3 RID: 56787
		[Token(Token = "0x400DDD3")]
		[FieldOffset(Offset = "0x60")]
		private CharacterSkinHooker m_skinHooker;

		// Token: 0x0400DDD4 RID: 56788
		[Token(Token = "0x400DDD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DDD5 RID: 56789
		[Token(Token = "0x400DDD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DDD6 RID: 56790
		[Token(Token = "0x400DDD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x0400DDD7 RID: 56791
		[Token(Token = "0x400DDD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableWhiteList;

		// Token: 0x0400DDD8 RID: 56792
		[Token(Token = "0x400DDD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_effectWhiteList;

		// Token: 0x0400DDD9 RID: 56793
		[Token(Token = "0x400DDD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400DDDA RID: 56794
		[Token(Token = "0x400DDDA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_muzzleTransform;

		// Token: 0x0400DDDB RID: 56795
		[Token(Token = "0x400DDDB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hitTransform;

		// Token: 0x0400DDDC RID: 56796
		[Token(Token = "0x400DDDC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_footTransform;

		// Token: 0x0400DDDD RID: 56797
		[Token(Token = "0x400DDDD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_headTransform;

		// Token: 0x0400DDDE RID: 56798
		[Token(Token = "0x400DDDE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_shadowTransform;

		// Token: 0x0400DDDF RID: 56799
		[Token(Token = "0x400DDDF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_skinHooker;

		// Token: 0x0400DDE0 RID: 56800
		[Token(Token = "0x400DDE0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400DDE1 RID: 56801
		[Token(Token = "0x400DDE1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400DDE2 RID: 56802
		[Token(Token = "0x400DDE2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DDE3 RID: 56803
		[Token(Token = "0x400DDE3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ContainsAnimationInternal;

		// Token: 0x0400DDE4 RID: 56804
		[Token(Token = "0x400DDE4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetAnimationTimeInternal;

		// Token: 0x0400DDE5 RID: 56805
		[Token(Token = "0x400DDE5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_GetAnimationTimeInternal;

		// Token: 0x0400DDE6 RID: 56806
		[Token(Token = "0x400DDE6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DDE7 RID: 56807
		[Token(Token = "0x400DDE7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x0400DDE8 RID: 56808
		[Token(Token = "0x400DDE8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCurrentAniState;

		// Token: 0x0400DDE9 RID: 56809
		[Token(Token = "0x400DDE9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400DDEA RID: 56810
		[Token(Token = "0x400DDEA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryIgnoreEffect;

		// Token: 0x0400DDEB RID: 56811
		[Token(Token = "0x400DDEB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
