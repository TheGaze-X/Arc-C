using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002121 RID: 8481
	[Token(Token = "0x2002121")]
	public class MultiSpineAnimator : SpineAnimator
	{
		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x0600D01B RID: 53275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D1")]
		private MultiSpineAnimator.SubSpineConfig activeFace
		{
			[Token(Token = "0x600D01B")]
			[Address(RVA = "0x3517FE0", Offset = "0x3516BE0", VA = "0x183517FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600D01C RID: 53276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D2")]
		public List<MultiSpineAnimator.SubSpineConfig> faces
		{
			[Token(Token = "0x600D01C")]
			[Address(RVA = "0x3518240", Offset = "0x3516E40", VA = "0x183518240")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600D01D RID: 53277 RVA: 0x0004B1C8 File Offset: 0x000493C8
		[Token(Token = "0x170018D3")]
		public int activeSpineIndex
		{
			[Token(Token = "0x600D01D")]
			[Address(RVA = "0x3518060", Offset = "0x3516C60", VA = "0x183518060")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600D01E RID: 53278 RVA: 0x0004B1E0 File Offset: 0x000493E0
		// (set) Token: 0x0600D01F RID: 53279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018D4")]
		public override Color color
		{
			[Token(Token = "0x600D01E")]
			[Address(RVA = "0x3518160", Offset = "0x3516D60", VA = "0x183518160", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600D01F")]
			[Address(RVA = "0x35187B0", Offset = "0x35173B0", VA = "0x1835187B0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x0600D020 RID: 53280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D5")]
		public override SkeletonAnimation skeleton
		{
			[Token(Token = "0x600D020")]
			[Address(RVA = "0x3518740", Offset = "0x3517340", VA = "0x183518740", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x0600D021 RID: 53281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D6")]
		public override string bakedDataKey
		{
			[Token(Token = "0x600D021")]
			[Address(RVA = "0x35180C0", Offset = "0x3516CC0", VA = "0x1835180C0", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600D022 RID: 53282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D7")]
		public override FaceSwitcher faceSwitcher
		{
			[Token(Token = "0x600D022")]
			[Address(RVA = "0x35181E0", Offset = "0x3516DE0", VA = "0x1835181E0", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x0600D023 RID: 53283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D8")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600D023")]
			[Address(RVA = "0x3518320", Offset = "0x3516F20", VA = "0x183518320", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x0600D024 RID: 53284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018D9")]
		public override Transform hitTransform
		{
			[Token(Token = "0x600D024")]
			[Address(RVA = "0x3518470", Offset = "0x3517070", VA = "0x183518470", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600D025 RID: 53285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018DA")]
		public override Transform footTransform
		{
			[Token(Token = "0x600D025")]
			[Address(RVA = "0x35182A0", Offset = "0x3516EA0", VA = "0x1835182A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600D026 RID: 53286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018DB")]
		public override Transform headTransform
		{
			[Token(Token = "0x600D026")]
			[Address(RVA = "0x3518380", Offset = "0x3516F80", VA = "0x183518380", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600D027 RID: 53287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018DC")]
		public override Transform shadowTransform
		{
			[Token(Token = "0x600D027")]
			[Address(RVA = "0x3518650", Offset = "0x3517250", VA = "0x183518650", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x0600D028 RID: 53288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018DD")]
		protected override Transform muzzleTransform
		{
			[Token(Token = "0x600D028")]
			[Address(RVA = "0x3518560", Offset = "0x3517160", VA = "0x183518560", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D029 RID: 53289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D029")]
		[Address(RVA = "0x35161A0", Offset = "0x3514DA0", VA = "0x1835161A0", Slot = "34")]
		public override Transform GetMountPoint(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D02A")]
		[Address(RVA = "0x3516FD0", Offset = "0x3515BD0", VA = "0x183516FD0")]
		public void SwitchSpine(int index)
		{
		}

		// Token: 0x0600D02B RID: 53291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D02B")]
		[Address(RVA = "0x3516F60", Offset = "0x3515B60", VA = "0x183516F60")]
		[Inspect]
		public void SwitchNextSpine()
		{
		}

		// Token: 0x0600D02C RID: 53292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D02C")]
		[Address(RVA = "0x35167B0", Offset = "0x35153B0", VA = "0x1835167B0", Slot = "21")]
		public override void Init(Unit unit)
		{
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D02D")]
		[Address(RVA = "0x3516070", Offset = "0x3514C70", VA = "0x183516070", Slot = "53")]
		public override string GetFaceKey(IFaceConfiguration faceConfig)
		{
			return null;
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D02E")]
		[Address(RVA = "0x3515F90", Offset = "0x3514B90", VA = "0x183515F90", Slot = "54")]
		public override IFaceConfiguration GetFaceConfiguration(string faceKey)
		{
			return null;
		}

		// Token: 0x0600D02F RID: 53295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D02F")]
		[Address(RVA = "0x3515E20", Offset = "0x3514A20", VA = "0x183515E20", Slot = "55")]
		public override IFaceConfiguration GetActiveFace()
		{
			return null;
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D030")]
		[Address(RVA = "0x3516C90", Offset = "0x3515890", VA = "0x183516C90", Slot = "26")]
		public override void OnReset(UnitAnimator old)
		{
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D031")]
		[Address(RVA = "0x3516AA0", Offset = "0x35156A0", VA = "0x183516AA0", Slot = "32")]
		public override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600D032 RID: 53298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D032")]
		[Address(RVA = "0x3516520", Offset = "0x3515120", VA = "0x183516520", Slot = "58")]
		protected override void InitAnimationDataIfNot()
		{
		}

		// Token: 0x0600D033 RID: 53299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D033")]
		[Address(RVA = "0x35171C0", Offset = "0x3515DC0", VA = "0x1835171C0", Slot = "59")]
		protected override void UpdateAnimationData(bool checkMissing)
		{
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D034")]
		[Address(RVA = "0x3515E80", Offset = "0x3514A80", VA = "0x183515E80", Slot = "57")]
		protected override SpineAnimator.AnimationData GetAnimationData(string animKey, bool ignoreInvalid)
		{
			return null;
		}

		// Token: 0x0600D035 RID: 53301 RVA: 0x0004B1F8 File Offset: 0x000493F8
		[Token(Token = "0x600D035")]
		[Address(RVA = "0x3516EA0", Offset = "0x3515AA0", VA = "0x183516EA0", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D036")]
		[Address(RVA = "0x35159F0", Offset = "0x35145F0", VA = "0x1835159F0", Slot = "45")]
		protected override void DoUpdateFaceSign(int sign)
		{
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D037")]
		[Address(RVA = "0x3515CC0", Offset = "0x35148C0", VA = "0x183515CC0", Slot = "66")]
		protected override void ForEachSkeleton(Action<SkeletonAnimation> func)
		{
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D038")]
		[Address(RVA = "0x3515B70", Offset = "0x3514770", VA = "0x183515B70", Slot = "67")]
		public override void ForEachFaceConfiguration(Action<IFaceConfiguration> func)
		{
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D039")]
		[Address(RVA = "0x3517850", Offset = "0x3516450", VA = "0x183517850")]
		private void _SwapConfiguration(int toIndex, bool needSync = true, bool force = false)
		{
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D03A")]
		[Address(RVA = "0x3517B10", Offset = "0x3516710", VA = "0x183517B10")]
		private void _SyncAnimationState(MultiSpineAnimator.SubSpineConfig toSpine, MultiSpineAnimator.SubSpineConfig fromSpine)
		{
		}

		// Token: 0x0600D03B RID: 53307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D03B")]
		[Address(RVA = "0x3517670", Offset = "0x3516270", VA = "0x183517670")]
		private void _ResetSkeletonToDefaultPose(MultiSpineAnimator.SubSpineConfig spine)
		{
		}

		// Token: 0x0600D03C RID: 53308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D03C")]
		[Address(RVA = "0x3517590", Offset = "0x3516190", VA = "0x183517590")]
		private static SpineAnimator.AnimationData _GetAnimationData(string animKey, bool ignoreInvalid, MultiSpineAnimator.SubSpineConfig spine)
		{
			return null;
		}

		// Token: 0x0600D03D RID: 53309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D03D")]
		[Address(RVA = "0x3517EE0", Offset = "0x3516AE0", VA = "0x183517EE0")]
		private void _UpdateDirection(SharedConsts.Direction lOrR, SharedConsts.Direction fourDir)
		{
		}

		// Token: 0x0600D03E RID: 53310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D03E")]
		[Address(RVA = "0x3517F70", Offset = "0x3516B70", VA = "0x183517F70")]
		public MultiSpineAnimator()
		{
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x0004B210 File Offset: 0x00049410
		[Token(Token = "0x600D03F")]
		[Address(RVA = "0x350B960", Offset = "0x350A560", VA = "0x18350B960")]
		private Color <>xLuaBaseProxy_get_color()
		{
			return default(Color);
		}

		// Token: 0x0600D040 RID: 53312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D040")]
		[Address(RVA = "0x350BAC0", Offset = "0x350A6C0", VA = "0x18350BAC0")]
		private void <>xLuaBaseProxy_set_color(Color P0)
		{
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D041")]
		[Address(RVA = "0x350B740", Offset = "0x350A340", VA = "0x18350B740")]
		private Transform <>xLuaBaseProxy_GetMountPoint(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D042")]
		[Address(RVA = "0x350B750", Offset = "0x350A350", VA = "0x18350B750")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D043 RID: 53315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D043")]
		[Address(RVA = "0x350B760", Offset = "0x350A360", VA = "0x18350B760")]
		private void <>xLuaBaseProxy_OnReset(UnitAnimator P0)
		{
		}

		// Token: 0x0600D044 RID: 53316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D044")]
		[Address(RVA = "0x35171A0", Offset = "0x3515DA0", VA = "0x1835171A0")]
		private void <>xLuaBaseProxy_InitAnimationDataIfNot()
		{
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D045")]
		[Address(RVA = "0x35171B0", Offset = "0x3515DB0", VA = "0x1835171B0")]
		private void <>xLuaBaseProxy_UpdateAnimationData(bool P0)
		{
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D046")]
		[Address(RVA = "0x35170C0", Offset = "0x3515CC0", VA = "0x1835170C0")]
		private SpineAnimator.AnimationData <>xLuaBaseProxy_GetAnimationData(string P0, bool P1)
		{
			return null;
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x0004B228 File Offset: 0x00049428
		[Token(Token = "0x600D047")]
		[Address(RVA = "0x350B770", Offset = "0x350A370", VA = "0x18350B770")]
		private float <>xLuaBaseProxy_PlayAnimationInternal(string P0, bool P1, float P2)
		{
			return 0f;
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D048")]
		[Address(RVA = "0x350B730", Offset = "0x350A330", VA = "0x18350B730")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0400DE61 RID: 56929
		[Token(Token = "0x400DE61")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private List<MultiSpineAnimator.SubSpineConfig> _faces;

		// Token: 0x0400DE62 RID: 56930
		[Token(Token = "0x400DE62")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private FaceSwitcher _faceSwitcher;

		// Token: 0x0400DE63 RID: 56931
		[Token(Token = "0x400DE63")]
		[FieldOffset(Offset = "0xF0")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private int m_activeSpineIndex;

		// Token: 0x0400DE64 RID: 56932
		[Token(Token = "0x400DE64")]
		[FieldOffset(Offset = "0xF4")]
		public int nextSpineIndex;

		// Token: 0x0400DE65 RID: 56933
		[Token(Token = "0x400DE65")]
		[FieldOffset(Offset = "0xF8")]
		private Color m_color;

		// Token: 0x0400DE66 RID: 56934
		[Token(Token = "0x400DE66")]
		[FieldOffset(Offset = "0x108")]
		private Action<SharedConsts.Direction, SharedConsts.Direction> m_updateDir;

		// Token: 0x0400DE67 RID: 56935
		[Token(Token = "0x400DE67")]
		[FieldOffset(Offset = "0x110")]
		private string m_currentAnimKey;

		// Token: 0x0400DE68 RID: 56936
		[Token(Token = "0x400DE68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeFace;

		// Token: 0x0400DE69 RID: 56937
		[Token(Token = "0x400DE69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_faces;

		// Token: 0x0400DE6A RID: 56938
		[Token(Token = "0x400DE6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activeSpineIndex;

		// Token: 0x0400DE6B RID: 56939
		[Token(Token = "0x400DE6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DE6C RID: 56940
		[Token(Token = "0x400DE6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DE6D RID: 56941
		[Token(Token = "0x400DE6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x0400DE6E RID: 56942
		[Token(Token = "0x400DE6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bakedDataKey;

		// Token: 0x0400DE6F RID: 56943
		[Token(Token = "0x400DE6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_faceSwitcher;

		// Token: 0x0400DE70 RID: 56944
		[Token(Token = "0x400DE70")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400DE71 RID: 56945
		[Token(Token = "0x400DE71")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hitTransform;

		// Token: 0x0400DE72 RID: 56946
		[Token(Token = "0x400DE72")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_footTransform;

		// Token: 0x0400DE73 RID: 56947
		[Token(Token = "0x400DE73")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_headTransform;

		// Token: 0x0400DE74 RID: 56948
		[Token(Token = "0x400DE74")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_shadowTransform;

		// Token: 0x0400DE75 RID: 56949
		[Token(Token = "0x400DE75")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_muzzleTransform;

		// Token: 0x0400DE76 RID: 56950
		[Token(Token = "0x400DE76")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400DE77 RID: 56951
		[Token(Token = "0x400DE77")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SwitchSpine;

		// Token: 0x0400DE78 RID: 56952
		[Token(Token = "0x400DE78")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SwitchNextSpine;

		// Token: 0x0400DE79 RID: 56953
		[Token(Token = "0x400DE79")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DE7A RID: 56954
		[Token(Token = "0x400DE7A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetFaceKey;

		// Token: 0x0400DE7B RID: 56955
		[Token(Token = "0x400DE7B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetFaceConfiguration;

		// Token: 0x0400DE7C RID: 56956
		[Token(Token = "0x400DE7C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetActiveFace;

		// Token: 0x0400DE7D RID: 56957
		[Token(Token = "0x400DE7D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400DE7E RID: 56958
		[Token(Token = "0x400DE7E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DE7F RID: 56959
		[Token(Token = "0x400DE7F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InitAnimationDataIfNot;

		// Token: 0x0400DE80 RID: 56960
		[Token(Token = "0x400DE80")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UpdateAnimationData;

		// Token: 0x0400DE81 RID: 56961
		[Token(Token = "0x400DE81")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetAnimationData;

		// Token: 0x0400DE82 RID: 56962
		[Token(Token = "0x400DE82")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DE83 RID: 56963
		[Token(Token = "0x400DE83")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DE84 RID: 56964
		[Token(Token = "0x400DE84")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ForEachSkeleton;

		// Token: 0x0400DE85 RID: 56965
		[Token(Token = "0x400DE85")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ForEachFaceConfiguration;

		// Token: 0x0400DE86 RID: 56966
		[Token(Token = "0x400DE86")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SwapConfiguration;

		// Token: 0x0400DE87 RID: 56967
		[Token(Token = "0x400DE87")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SyncAnimationState;

		// Token: 0x0400DE88 RID: 56968
		[Token(Token = "0x400DE88")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ResetSkeletonToDefaultPose;

		// Token: 0x0400DE89 RID: 56969
		[Token(Token = "0x400DE89")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetAnimationData;

		// Token: 0x0400DE8A RID: 56970
		[Token(Token = "0x400DE8A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UpdateDirection;

		// Token: 0x0400DE8B RID: 56971
		[Token(Token = "0x400DE8B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002122 RID: 8482
		[Token(Token = "0x2002122")]
		[Serializable]
		public class SubSpineConfig : IFaceConfiguration
		{
			// Token: 0x170018DE RID: 6366
			// (get) Token: 0x0600D049 RID: 53321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170018DE")]
			public Renderer renderer
			{
				[Token(Token = "0x600D049")]
				[Address(RVA = "0x3522D40", Offset = "0x3521940", VA = "0x183522D40", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D04A RID: 53322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D04A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public SkeletonAnimation GetSkeleton()
			{
				return null;
			}

			// Token: 0x0600D04B RID: 53323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D04B")]
			[Address(RVA = "0x3522B20", Offset = "0x3521720", VA = "0x183522B20", Slot = "5")]
			public Transform GetFaceMountPointTransform(Entity.MountPointType mountPointType)
			{
				return null;
			}

			// Token: 0x0600D04C RID: 53324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D04C")]
			[Address(RVA = "0x3522C90", Offset = "0x3521890", VA = "0x183522C90")]
			public SubSpineConfig()
			{
			}

			// Token: 0x0400DE8C RID: 56972
			[Token(Token = "0x400DE8C")]
			[FieldOffset(Offset = "0x10")]
			public SkeletonAnimation skeleton;

			// Token: 0x0400DE8D RID: 56973
			[Token(Token = "0x400DE8D")]
			[FieldOffset(Offset = "0x18")]
			public SpineAnimator.AnimationData[] animations;

			// Token: 0x0400DE8E RID: 56974
			[Token(Token = "0x400DE8E")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, SpineAnimator.AnimationData> animationDict;

			// Token: 0x0400DE8F RID: 56975
			[Token(Token = "0x400DE8F")]
			[FieldOffset(Offset = "0x28")]
			public Transform muzzleTransform;

			// Token: 0x0400DE90 RID: 56976
			[Token(Token = "0x400DE90")]
			[FieldOffset(Offset = "0x30")]
			public Transform hitTransform;

			// Token: 0x0400DE91 RID: 56977
			[Token(Token = "0x400DE91")]
			[FieldOffset(Offset = "0x38")]
			public Transform headTransform;

			// Token: 0x0400DE92 RID: 56978
			[Token(Token = "0x400DE92")]
			[FieldOffset(Offset = "0x40")]
			public Transform shadowTransform;

			// Token: 0x0400DE93 RID: 56979
			[Token(Token = "0x400DE93")]
			[FieldOffset(Offset = "0x48")]
			public Transform specialPoint0;

			// Token: 0x0400DE94 RID: 56980
			[Token(Token = "0x400DE94")]
			[FieldOffset(Offset = "0x50")]
			public Transform specialPoint1;

			// Token: 0x0400DE95 RID: 56981
			[Token(Token = "0x400DE95")]
			[FieldOffset(Offset = "0x58")]
			public Transform specialPoint2;

			// Token: 0x0400DE96 RID: 56982
			[Token(Token = "0x400DE96")]
			[FieldOffset(Offset = "0x60")]
			public Transform specialPoint3;

			// Token: 0x0400DE97 RID: 56983
			[Token(Token = "0x400DE97")]
			[FieldOffset(Offset = "0x68")]
			public Transform specialPoint4;

			// Token: 0x0400DE98 RID: 56984
			[Token(Token = "0x400DE98")]
			[FieldOffset(Offset = "0x70")]
			public Transform specialPoint5;

			// Token: 0x0400DE99 RID: 56985
			[Token(Token = "0x400DE99")]
			[FieldOffset(Offset = "0x78")]
			public Transform specialPoint6;

			// Token: 0x0400DE9A RID: 56986
			[Token(Token = "0x400DE9A")]
			[FieldOffset(Offset = "0x80")]
			public Transform specialPoint7;

			// Token: 0x0400DE9B RID: 56987
			[Token(Token = "0x400DE9B")]
			[FieldOffset(Offset = "0x88")]
			public Transform specialPoint8;

			// Token: 0x0400DE9C RID: 56988
			[Token(Token = "0x400DE9C")]
			[FieldOffset(Offset = "0x90")]
			public Transform specialPoint9;

			// Token: 0x0400DE9D RID: 56989
			[Token(Token = "0x400DE9D")]
			[FieldOffset(Offset = "0x98")]
			public Transform specialPoint10;

			// Token: 0x0400DE9E RID: 56990
			[Token(Token = "0x400DE9E")]
			[FieldOffset(Offset = "0xA0")]
			public Transform specialPoint11;

			// Token: 0x0400DE9F RID: 56991
			[Token(Token = "0x400DE9F")]
			[FieldOffset(Offset = "0xA8")]
			public Transform specialPoint12;

			// Token: 0x0400DEA0 RID: 56992
			[Token(Token = "0x400DEA0")]
			[FieldOffset(Offset = "0xB0")]
			public Transform specialPoint13;

			// Token: 0x0400DEA1 RID: 56993
			[Token(Token = "0x400DEA1")]
			[FieldOffset(Offset = "0xB8")]
			public Transform specialPoint14;

			// Token: 0x0400DEA2 RID: 56994
			[Token(Token = "0x400DEA2")]
			[FieldOffset(Offset = "0xC0")]
			public Transform specialPoint15;

			// Token: 0x0400DEA3 RID: 56995
			[Token(Token = "0x400DEA3")]
			[FieldOffset(Offset = "0xC8")]
			private Renderer m_renderer;
		}
	}
}
