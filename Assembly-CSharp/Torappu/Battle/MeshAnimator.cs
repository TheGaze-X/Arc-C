using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200211D RID: 8477
	[Token(Token = "0x200211D")]
	public class MeshAnimator : UnitAnimator
	{
		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600CFE0 RID: 53216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018C2")]
		public override CharacterSkinHooker skinHooker
		{
			[Token(Token = "0x600CFE0")]
			[Address(RVA = "0x3515440", Offset = "0x3514040", VA = "0x183515440", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600CFE1 RID: 53217 RVA: 0x0004B0A8 File Offset: 0x000492A8
		// (set) Token: 0x0600CFE2 RID: 53218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018C3")]
		public override Color color
		{
			[Token(Token = "0x600CFE1")]
			[Address(RVA = "0x3514B70", Offset = "0x3513770", VA = "0x183514B70", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600CFE2")]
			[Address(RVA = "0x35154A0", Offset = "0x35140A0", VA = "0x1835154A0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x0600CFE3 RID: 53219 RVA: 0x0004B0C0 File Offset: 0x000492C0
		[Token(Token = "0x170018C4")]
		protected bool enableRotate
		{
			[Token(Token = "0x600CFE3")]
			[Address(RVA = "0x3514C70", Offset = "0x3513870", VA = "0x183514C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x0004B0D8 File Offset: 0x000492D8
		[Token(Token = "0x170018C5")]
		protected bool rotateMeshOnly
		{
			[Token(Token = "0x600CFE4")]
			[Address(RVA = "0x3515350", Offset = "0x3513F50", VA = "0x183515350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x0600CFE5 RID: 53221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018C6")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600CFE5")]
			[Address(RVA = "0x3514E90", Offset = "0x3513A90", VA = "0x183514E90", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018C7")]
		protected override Transform muzzleTransform
		{
			[Token(Token = "0x600CFE6")]
			[Address(RVA = "0x3515100", Offset = "0x3513D00", VA = "0x183515100", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x0600CFE7 RID: 53223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018C8")]
		public override Transform hitTransform
		{
			[Token(Token = "0x600CFE7")]
			[Address(RVA = "0x3514FC0", Offset = "0x3513BC0", VA = "0x183514FC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018C9")]
		public override Transform footTransform
		{
			[Token(Token = "0x600CFE8")]
			[Address(RVA = "0x3514CD0", Offset = "0x35138D0", VA = "0x183514CD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600CFE9 RID: 53225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CA")]
		public override Transform graphicFootTransform
		{
			[Token(Token = "0x600CFE9")]
			[Address(RVA = "0x3514DE0", Offset = "0x35139E0", VA = "0x183514DE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600CFEA RID: 53226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CB")]
		public override Transform headTransform
		{
			[Token(Token = "0x600CFEA")]
			[Address(RVA = "0x3514EF0", Offset = "0x3513AF0", VA = "0x183514EF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600CFEB RID: 53227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CC")]
		public override Transform shadowTransform
		{
			[Token(Token = "0x600CFEB")]
			[Address(RVA = "0x35153C0", Offset = "0x3513FC0", VA = "0x1835153C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x0600CFEC RID: 53228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CD")]
		protected Renderer renderer
		{
			[Token(Token = "0x600CFEC")]
			[Address(RVA = "0x35151D0", Offset = "0x3513DD0", VA = "0x1835151D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x0600CFED RID: 53229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CE")]
		protected virtual Animation animation
		{
			[Token(Token = "0x600CFED")]
			[Address(RVA = "0x3507D40", Offset = "0x3506940", VA = "0x183507D40", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018CF")]
		protected MeshAnimator.AnimationData[] animations
		{
			[Token(Token = "0x600CFEE")]
			[Address(RVA = "0x3514B10", Offset = "0x3513710", VA = "0x183514B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x0600CFEF RID: 53231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D0")]
		protected RotateHandlerAnimatorBehaviour[] rotateHandlers
		{
			[Token(Token = "0x600CFEF")]
			[Address(RVA = "0x3515250", Offset = "0x3513E50", VA = "0x183515250")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CFF0 RID: 53232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFF0")]
		[Address(RVA = "0x35132B0", Offset = "0x3511EB0", VA = "0x1835132B0", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFF1")]
		[Address(RVA = "0x3512B70", Offset = "0x3511770", VA = "0x183512B70", Slot = "22")]
		public override void EnableVisualPart(bool enable)
		{
		}

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x0004B0F0 File Offset: 0x000492F0
		[Token(Token = "0x600CFF2")]
		[Address(RVA = "0x3512EB0", Offset = "0x3511AB0", VA = "0x183512EB0", Slot = "39")]
		public override UnitAnimator.CurrentAniState GetCurrentAniState()
		{
			return default(UnitAnimator.CurrentAniState);
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFF3")]
		[Address(RVA = "0x3512A00", Offset = "0x3511600", VA = "0x183512A00", Slot = "44")]
		protected override void DoResetColor(UnitAnimator oldAnimator)
		{
		}

		// Token: 0x0600CFF4 RID: 53236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFF4")]
		[Address(RVA = "0x3513F00", Offset = "0x3512B00", VA = "0x183513F00", Slot = "23")]
		public override void Stop()
		{
		}

		// Token: 0x0600CFF5 RID: 53237 RVA: 0x0004B108 File Offset: 0x00049308
		[Token(Token = "0x600CFF5")]
		[Address(RVA = "0x3507C80", Offset = "0x3506880", VA = "0x183507C80", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600CFF6 RID: 53238 RVA: 0x0004B120 File Offset: 0x00049320
		[Token(Token = "0x600CFF6")]
		[Address(RVA = "0x3512920", Offset = "0x3511520", VA = "0x183512920", Slot = "41")]
		protected override bool ContainsAnimationInternal(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x0004B138 File Offset: 0x00049338
		[Token(Token = "0x600CFF7")]
		[Address(RVA = "0x3512DE0", Offset = "0x35119E0", VA = "0x183512DE0", Slot = "42")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x0004B150 File Offset: 0x00049350
		[Token(Token = "0x600CFF8")]
		[Address(RVA = "0x3512D10", Offset = "0x3511910", VA = "0x183512D10", Slot = "43")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFF9")]
		[Address(RVA = "0x35139A0", Offset = "0x35125A0", VA = "0x1835139A0", Slot = "33")]
		public override void OnTakeDamage(ref Modifier modifier)
		{
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFFA")]
		[Address(RVA = "0x35138A0", Offset = "0x35124A0", VA = "0x1835138A0", Slot = "27")]
		public override void OnFinish()
		{
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CFFB")]
		[Address(RVA = "0x3512F40", Offset = "0x3511B40", VA = "0x183512F40", Slot = "34")]
		public override Transform GetMountPoint(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x0004B168 File Offset: 0x00049368
		[Token(Token = "0x600CFFC")]
		[Address(RVA = "0x3514010", Offset = "0x3512C10", VA = "0x183514010", Slot = "35")]
		public override bool TryHookEffect(string originEffectKey, out string newEffectKey)
		{
			return default(bool);
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFFD")]
		[Address(RVA = "0x3512890", Offset = "0x3511490", VA = "0x183512890", Slot = "46")]
		protected override void Awake()
		{
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x0004B180 File Offset: 0x00049380
		[Token(Token = "0x600CFFE")]
		[Address(RVA = "0x3513CE0", Offset = "0x35128E0", VA = "0x183513CE0")]
		protected float PlayAnimation(MeshAnimator.AnimationData data, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600CFFF RID: 53247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CFFF")]
		[Address(RVA = "0x3512C30", Offset = "0x3511830", VA = "0x183512C30")]
		protected MeshAnimator.AnimationData GetAnimationData(string animKey, bool ignoreInvalid)
		{
			return null;
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D000")]
		[Address(RVA = "0x35131A0", Offset = "0x3511DA0", VA = "0x1835131A0")]
		protected void InitAnimationDataIfNot()
		{
		}

		// Token: 0x0600D001 RID: 53249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D001")]
		[Address(RVA = "0x3514190", Offset = "0x3512D90", VA = "0x183514190")]
		protected void UpdateAnimationData(bool checkMissing)
		{
		}

		// Token: 0x0600D002 RID: 53250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D002")]
		[Address(RVA = "0x3512B10", Offset = "0x3511710", VA = "0x183512B10", Slot = "45")]
		protected override void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D003")]
		[Address(RVA = "0x35144A0", Offset = "0x35130A0", VA = "0x1835144A0")]
		private void _InitRenderersIfNot()
		{
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D004")]
		[Address(RVA = "0x3513430", Offset = "0x3512030", VA = "0x183513430", Slot = "32")]
		public override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D005")]
		[Address(RVA = "0x3514940", Offset = "0x3513540", VA = "0x183514940")]
		private void _InitRotateHandlerIfNot()
		{
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D006")]
		[Address(RVA = "0x35149E0", Offset = "0x35135E0", VA = "0x1835149E0")]
		public MeshAnimator()
		{
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D007")]
		[Address(RVA = "0x350E8C0", Offset = "0x350D4C0", VA = "0x18350E8C0")]
		private CharacterSkinHooker <>xLuaBaseProxy_get_skinHooker()
		{
			return null;
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D008")]
		[Address(RVA = "0x3514180", Offset = "0x3512D80", VA = "0x183514180")]
		private Transform <>xLuaBaseProxy_get_graphicFootTransform()
		{
			return null;
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D009")]
		[Address(RVA = "0x3514160", Offset = "0x3512D60", VA = "0x183514160")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D00A RID: 53258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D00A")]
		[Address(RVA = "0x3514150", Offset = "0x3512D50", VA = "0x183514150")]
		private void <>xLuaBaseProxy_EnableVisualPart(bool P0)
		{
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D00B")]
		[Address(RVA = "0x3514130", Offset = "0x3512D30", VA = "0x183514130")]
		private void <>xLuaBaseProxy_DoResetColor(UnitAnimator P0)
		{
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D00C")]
		[Address(RVA = "0x350E890", Offset = "0x350D490", VA = "0x18350E890")]
		private void <>xLuaBaseProxy_Stop()
		{
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D00D")]
		[Address(RVA = "0x3514170", Offset = "0x3512D70", VA = "0x183514170")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600D00E RID: 53262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D00E")]
		[Address(RVA = "0x350B740", Offset = "0x350A340", VA = "0x18350B740")]
		private Transform <>xLuaBaseProxy_GetMountPoint(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x0004B198 File Offset: 0x00049398
		[Token(Token = "0x600D00F")]
		[Address(RVA = "0x350E8A0", Offset = "0x350D4A0", VA = "0x18350E8A0")]
		private bool <>xLuaBaseProxy_TryHookEffect(string P0, out string P1)
		{
			return default(bool);
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D010")]
		[Address(RVA = "0x350E880", Offset = "0x350D480", VA = "0x18350E880")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D011")]
		[Address(RVA = "0x3514140", Offset = "0x3512D40", VA = "0x183514140")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0400DE05 RID: 56837
		[Token(Token = "0x400DE05")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animation _animation;

		// Token: 0x0400DE06 RID: 56838
		[Token(Token = "0x400DE06")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _muzzleTransform;

		// Token: 0x0400DE07 RID: 56839
		[Token(Token = "0x400DE07")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _hitTransform;

		// Token: 0x0400DE08 RID: 56840
		[Token(Token = "0x400DE08")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _headTransform;

		// Token: 0x0400DE09 RID: 56841
		[Token(Token = "0x400DE09")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _graphicFootTransform;

		// Token: 0x0400DE0A RID: 56842
		[Token(Token = "0x400DE0A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _specialPoint0;

		// Token: 0x0400DE0B RID: 56843
		[Token(Token = "0x400DE0B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _specialPoint1;

		// Token: 0x0400DE0C RID: 56844
		[Token(Token = "0x400DE0C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _specialPoint2;

		// Token: 0x0400DE0D RID: 56845
		[Token(Token = "0x400DE0D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _specialPoint3;

		// Token: 0x0400DE0E RID: 56846
		[Token(Token = "0x400DE0E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _specialPoint4;

		// Token: 0x0400DE0F RID: 56847
		[Token(Token = "0x400DE0F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _specialPoint5;

		// Token: 0x0400DE10 RID: 56848
		[Token(Token = "0x400DE10")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _specialPoint6;

		// Token: 0x0400DE11 RID: 56849
		[Token(Token = "0x400DE11")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _specialPoint7;

		// Token: 0x0400DE12 RID: 56850
		[Token(Token = "0x400DE12")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _specialPoint8;

		// Token: 0x0400DE13 RID: 56851
		[Token(Token = "0x400DE13")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _specialPoint9;

		// Token: 0x0400DE14 RID: 56852
		[Token(Token = "0x400DE14")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _specialPoint10;

		// Token: 0x0400DE15 RID: 56853
		[Token(Token = "0x400DE15")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _specialPoint11;

		// Token: 0x0400DE16 RID: 56854
		[Token(Token = "0x400DE16")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform _specialPoint12;

		// Token: 0x0400DE17 RID: 56855
		[Token(Token = "0x400DE17")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _specialPoint13;

		// Token: 0x0400DE18 RID: 56856
		[Token(Token = "0x400DE18")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Transform _specialPoint14;

		// Token: 0x0400DE19 RID: 56857
		[Token(Token = "0x400DE19")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Transform _specialPoint15;

		// Token: 0x0400DE1A RID: 56858
		[Token(Token = "0x400DE1A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private MeshAnimator.AnimationData[] _animations;

		// Token: 0x0400DE1B RID: 56859
		[Token(Token = "0x400DE1B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _enableShowDamageFlash;

		// Token: 0x0400DE1C RID: 56860
		[Token(Token = "0x400DE1C")]
		[FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _enableRotate;

		// Token: 0x0400DE1D RID: 56861
		[Token(Token = "0x400DE1D")]
		[FieldOffset(Offset = "0xF2")]
		[SerializeField]
		private bool _rotateMeshOnly;

		// Token: 0x0400DE1E RID: 56862
		[Token(Token = "0x400DE1E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _meshTransform;

		// Token: 0x0400DE1F RID: 56863
		[Token(Token = "0x400DE1F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _justRotateHandler;

		// Token: 0x0400DE20 RID: 56864
		[Token(Token = "0x400DE20")]
		[FieldOffset(Offset = "0x101")]
		[SerializeField]
		private bool _useMaterialTintColorAsDefaultColor;

		// Token: 0x0400DE21 RID: 56865
		[Token(Token = "0x400DE21")]
		[FieldOffset(Offset = "0x102")]
		[SerializeField]
		private bool _fixedTweenEndColor;

		// Token: 0x0400DE22 RID: 56866
		[Token(Token = "0x400DE22")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Tooltip("Renderers whose materials do not change with color property")]
		private Renderer[] _constRenders;

		// Token: 0x0400DE23 RID: 56867
		[Token(Token = "0x400DE23")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Tooltip("A fixable flag, some trap's render part is found to be unstable. The trap used in online mode must be |TRUE|")]
		private bool _hitTransformStable;

		// Token: 0x0400DE24 RID: 56868
		[Token(Token = "0x400DE24")]
		[FieldOffset(Offset = "0x111")]
		[SerializeField]
		private bool _enableThemeTintColor;

		// Token: 0x0400DE25 RID: 56869
		[Token(Token = "0x400DE25")]
		[FieldOffset(Offset = "0x112")]
		[SerializeField]
		private bool _checkMissing;

		// Token: 0x0400DE26 RID: 56870
		[Token(Token = "0x400DE26")]
		[FieldOffset(Offset = "0x113")]
		[SerializeField]
		private bool _useGraphicFootAsFootTransform;

		// Token: 0x0400DE27 RID: 56871
		[Token(Token = "0x400DE27")]
		[FieldOffset(Offset = "0x118")]
		private CharacterSkinHooker m_skinHooker;

		// Token: 0x0400DE28 RID: 56872
		[Token(Token = "0x400DE28")]
		[FieldOffset(Offset = "0x120")]
		private Color m_defaultColor;

		// Token: 0x0400DE29 RID: 56873
		[Token(Token = "0x400DE29")]
		[FieldOffset(Offset = "0x130")]
		private Renderer[] m_renderers;

		// Token: 0x0400DE2A RID: 56874
		[Token(Token = "0x400DE2A")]
		[FieldOffset(Offset = "0x138")]
		private bool m_initDataFlag;

		// Token: 0x0400DE2B RID: 56875
		[Token(Token = "0x400DE2B")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<string, MeshAnimator.AnimationData> m_animationDict;

		// Token: 0x0400DE2C RID: 56876
		[Token(Token = "0x400DE2C")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_lastTween;

		// Token: 0x0400DE2D RID: 56877
		[Token(Token = "0x400DE2D")]
		[FieldOffset(Offset = "0x150")]
		private Material m_material;

		// Token: 0x0400DE2E RID: 56878
		[Token(Token = "0x400DE2E")]
		[FieldOffset(Offset = "0x158")]
		private UnitAnimator.CurrentAniState m_currentAniState;

		// Token: 0x0400DE2F RID: 56879
		[Token(Token = "0x400DE2F")]
		[FieldOffset(Offset = "0x168")]
		private RotateHandlerAnimatorBehaviour[] m_rotateHandlers;

		// Token: 0x0400DE30 RID: 56880
		[Token(Token = "0x400DE30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skinHooker;

		// Token: 0x0400DE31 RID: 56881
		[Token(Token = "0x400DE31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DE32 RID: 56882
		[Token(Token = "0x400DE32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DE33 RID: 56883
		[Token(Token = "0x400DE33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableRotate;

		// Token: 0x0400DE34 RID: 56884
		[Token(Token = "0x400DE34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rotateMeshOnly;

		// Token: 0x0400DE35 RID: 56885
		[Token(Token = "0x400DE35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400DE36 RID: 56886
		[Token(Token = "0x400DE36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_muzzleTransform;

		// Token: 0x0400DE37 RID: 56887
		[Token(Token = "0x400DE37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hitTransform;

		// Token: 0x0400DE38 RID: 56888
		[Token(Token = "0x400DE38")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_footTransform;

		// Token: 0x0400DE39 RID: 56889
		[Token(Token = "0x400DE39")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_graphicFootTransform;

		// Token: 0x0400DE3A RID: 56890
		[Token(Token = "0x400DE3A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_headTransform;

		// Token: 0x0400DE3B RID: 56891
		[Token(Token = "0x400DE3B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_shadowTransform;

		// Token: 0x0400DE3C RID: 56892
		[Token(Token = "0x400DE3C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_renderer;

		// Token: 0x0400DE3D RID: 56893
		[Token(Token = "0x400DE3D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_animation;

		// Token: 0x0400DE3E RID: 56894
		[Token(Token = "0x400DE3E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_animations;

		// Token: 0x0400DE3F RID: 56895
		[Token(Token = "0x400DE3F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_rotateHandlers;

		// Token: 0x0400DE40 RID: 56896
		[Token(Token = "0x400DE40")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DE41 RID: 56897
		[Token(Token = "0x400DE41")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EnableVisualPart;

		// Token: 0x0400DE42 RID: 56898
		[Token(Token = "0x400DE42")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCurrentAniState;

		// Token: 0x0400DE43 RID: 56899
		[Token(Token = "0x400DE43")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_DoResetColor;

		// Token: 0x0400DE44 RID: 56900
		[Token(Token = "0x400DE44")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400DE45 RID: 56901
		[Token(Token = "0x400DE45")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DE46 RID: 56902
		[Token(Token = "0x400DE46")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ContainsAnimationInternal;

		// Token: 0x0400DE47 RID: 56903
		[Token(Token = "0x400DE47")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetAnimationTimeInternal;

		// Token: 0x0400DE48 RID: 56904
		[Token(Token = "0x400DE48")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_GetAnimationTimeInternal;

		// Token: 0x0400DE49 RID: 56905
		[Token(Token = "0x400DE49")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x0400DE4A RID: 56906
		[Token(Token = "0x400DE4A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400DE4B RID: 56907
		[Token(Token = "0x400DE4B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400DE4C RID: 56908
		[Token(Token = "0x400DE4C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TryHookEffect;

		// Token: 0x0400DE4D RID: 56909
		[Token(Token = "0x400DE4D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400DE4E RID: 56910
		[Token(Token = "0x400DE4E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_PlayAnimation;

		// Token: 0x0400DE4F RID: 56911
		[Token(Token = "0x400DE4F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetAnimationData;

		// Token: 0x0400DE50 RID: 56912
		[Token(Token = "0x400DE50")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_InitAnimationDataIfNot;

		// Token: 0x0400DE51 RID: 56913
		[Token(Token = "0x400DE51")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UpdateAnimationData;

		// Token: 0x0400DE52 RID: 56914
		[Token(Token = "0x400DE52")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DE53 RID: 56915
		[Token(Token = "0x400DE53")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__InitRenderersIfNot;

		// Token: 0x0400DE54 RID: 56916
		[Token(Token = "0x400DE54")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DE55 RID: 56917
		[Token(Token = "0x400DE55")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__InitRotateHandlerIfNot;

		// Token: 0x0400DE56 RID: 56918
		[Token(Token = "0x400DE56")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200211E RID: 8478
		[Token(Token = "0x200211E")]
		[Serializable]
		public class AnimationData
		{
			// Token: 0x0600D012 RID: 53266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D012")]
			[Address(RVA = "0x3509430", Offset = "0x3508030", VA = "0x183509430")]
			public string GetAnimName()
			{
				return null;
			}

			// Token: 0x0600D013 RID: 53267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D013")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600D014 RID: 53268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D014")]
			[Address(RVA = "0x3509460", Offset = "0x3508060", VA = "0x183509460")]
			public AnimationData()
			{
			}

			// Token: 0x0400DE57 RID: 56919
			[Token(Token = "0x400DE57")]
			[FieldOffset(Offset = "0x10")]
			public string animKey;

			// Token: 0x0400DE58 RID: 56920
			[Token(Token = "0x400DE58")]
			[FieldOffset(Offset = "0x18")]
			public string animName;

			// Token: 0x0400DE59 RID: 56921
			[Token(Token = "0x400DE59")]
			[FieldOffset(Offset = "0x20")]
			public float speed;

			// Token: 0x0400DE5A RID: 56922
			[Token(Token = "0x400DE5A")]
			[FieldOffset(Offset = "0x24")]
			[NonSerialized]
			public float time;

			// Token: 0x0400DE5B RID: 56923
			[Token(Token = "0x400DE5B")]
			[FieldOffset(Offset = "0x28")]
			[NonSerialized]
			public bool valid;

			// Token: 0x0400DE5C RID: 56924
			[Token(Token = "0x400DE5C")]
			[FieldOffset(Offset = "0x30")]
			[NonSerialized]
			public AnimationClip clip;
		}
	}
}
