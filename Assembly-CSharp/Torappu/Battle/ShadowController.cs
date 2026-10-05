using System;
using DG.Tweening;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200266A RID: 9834
	[Token(Token = "0x200266A")]
	public class ShadowController : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06010159 RID: 65881 RVA: 0x00062310 File Offset: 0x00060510
		[Token(Token = "0x1700230F")]
		private bool EnableAdvanced
		{
			[Token(Token = "0x6010159")]
			[Address(RVA = "0x7D0CE0", Offset = "0x7CF8E0", VA = "0x1807D0CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601015A RID: 65882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015A")]
		[Address(RVA = "0x7D0500", Offset = "0x7CF100", VA = "0x1807D0500")]
		public void Reset(Entity owner)
		{
		}

		// Token: 0x0601015B RID: 65883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015B")]
		[Address(RVA = "0x7D0A90", Offset = "0x7CF690", VA = "0x1807D0A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601015C RID: 65884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015C")]
		[Address(RVA = "0x7D0010", Offset = "0x7CEC10", VA = "0x1807D0010")]
		public void OnUpdate()
		{
		}

		// Token: 0x0601015D RID: 65885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015D")]
		[Address(RVA = "0x7CFEA0", Offset = "0x7CEAA0", VA = "0x1807CFEA0")]
		public void MakeScaleTween(float scale, float duration)
		{
		}

		// Token: 0x0601015E RID: 65886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015E")]
		[Address(RVA = "0x7D0600", Offset = "0x7CF200", VA = "0x1807D0600")]
		private void _AttachToGround()
		{
		}

		// Token: 0x0601015F RID: 65887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601015F")]
		[Address(RVA = "0x7CFFB0", Offset = "0x7CEBB0", VA = "0x1807CFFB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06010160 RID: 65888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010160")]
		[Address(RVA = "0x7D0A10", Offset = "0x7CF610", VA = "0x1807D0A10")]
		private void _FinishTweenIfNotNull()
		{
		}

		// Token: 0x06010161 RID: 65889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010161")]
		[Address(RVA = "0x7D0C70", Offset = "0x7CF870", VA = "0x1807D0C70")]
		public ShadowController()
		{
		}

		// Token: 0x04011E2D RID: 73261
		[Token(Token = "0x4011E2D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _autoAttachToGround;

		// Token: 0x04011E2E RID: 73262
		[Token(Token = "0x4011E2E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _attachOffset;

		// Token: 0x04011E2F RID: 73263
		[Token(Token = "0x4011E2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _simplyUseTileHeight;

		// Token: 0x04011E30 RID: 73264
		[Token(Token = "0x4011E30")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _enableAdvanced;

		// Token: 0x04011E31 RID: 73265
		[Token(Token = "0x4011E31")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _alwaysUseSpineOffset;

		// Token: 0x04011E32 RID: 73266
		[Token(Token = "0x4011E32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SpriteRenderer _sprite;

		// Token: 0x04011E33 RID: 73267
		[Token(Token = "0x4011E33")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _graphic;

		// Token: 0x04011E34 RID: 73268
		[Token(Token = "0x4011E34")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FaceSwitcher _faceSwitcher;

		// Token: 0x04011E35 RID: 73269
		[Token(Token = "0x4011E35")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BoneFollower _boneToFollow;

		// Token: 0x04011E36 RID: 73270
		[Token(Token = "0x4011E36")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _specialInit;

		// Token: 0x04011E37 RID: 73271
		[Token(Token = "0x4011E37")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _simpleFollow;

		// Token: 0x04011E38 RID: 73272
		[Token(Token = "0x4011E38")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x04011E39 RID: 73273
		[Token(Token = "0x4011E39")]
		[FieldOffset(Offset = "0x50")]
		private Tile m_currentTile;

		// Token: 0x04011E3A RID: 73274
		[Token(Token = "0x4011E3A")]
		[FieldOffset(Offset = "0x58")]
		private Entity m_owner;

		// Token: 0x04011E3B RID: 73275
		[Token(Token = "0x4011E3B")]
		[FieldOffset(Offset = "0x60")]
		private float m_defaultAlpha;

		// Token: 0x04011E3C RID: 73276
		[Token(Token = "0x4011E3C")]
		[FieldOffset(Offset = "0x64")]
		private float m_curHeight;

		// Token: 0x04011E3D RID: 73277
		[Token(Token = "0x4011E3D")]
		[FieldOffset(Offset = "0x68")]
		private float m_attachOffset;

		// Token: 0x04011E3E RID: 73278
		[Token(Token = "0x4011E3E")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_isInitialized;

		// Token: 0x04011E3F RID: 73279
		[Token(Token = "0x4011E3F")]
		[FieldOffset(Offset = "0x70")]
		private CharacterAnimator m_characterAnimator;

		// Token: 0x04011E40 RID: 73280
		[Token(Token = "0x4011E40")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_scaleTween;

		// Token: 0x04011E41 RID: 73281
		[Token(Token = "0x4011E41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_EnableAdvanced;

		// Token: 0x04011E42 RID: 73282
		[Token(Token = "0x4011E42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011E43 RID: 73283
		[Token(Token = "0x4011E43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04011E44 RID: 73284
		[Token(Token = "0x4011E44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04011E45 RID: 73285
		[Token(Token = "0x4011E45")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MakeScaleTween;

		// Token: 0x04011E46 RID: 73286
		[Token(Token = "0x4011E46")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AttachToGround;

		// Token: 0x04011E47 RID: 73287
		[Token(Token = "0x4011E47")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04011E48 RID: 73288
		[Token(Token = "0x4011E48")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FinishTweenIfNotNull;

		// Token: 0x04011E49 RID: 73289
		[Token(Token = "0x4011E49")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
