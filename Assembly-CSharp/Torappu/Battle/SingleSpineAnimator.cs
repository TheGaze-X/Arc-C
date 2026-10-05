using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002127 RID: 8487
	[Token(Token = "0x2002127")]
	public class SingleSpineAnimator : SpineAnimator, IFaceConfiguration
	{
		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600D056 RID: 53334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018DF")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600D056")]
			[Address(RVA = "0x351A650", Offset = "0x3519250", VA = "0x18351A650", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600D057 RID: 53335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E0")]
		protected override Transform muzzleTransform
		{
			[Token(Token = "0x600D057")]
			[Address(RVA = "0x351AA10", Offset = "0x3519610", VA = "0x18351AA10", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600D058 RID: 53336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E1")]
		public override Transform hitTransform
		{
			[Token(Token = "0x600D058")]
			[Address(RVA = "0x351A780", Offset = "0x3519380", VA = "0x18351A780", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600D059 RID: 53337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E2")]
		public override Transform footTransform
		{
			[Token(Token = "0x600D059")]
			[Address(RVA = "0x351A5E0", Offset = "0x35191E0", VA = "0x18351A5E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x0600D05A RID: 53338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E3")]
		public override Transform headTransform
		{
			[Token(Token = "0x600D05A")]
			[Address(RVA = "0x351A6B0", Offset = "0x35192B0", VA = "0x18351A6B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x0600D05B RID: 53339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E4")]
		public override Transform shadowTransform
		{
			[Token(Token = "0x600D05B")]
			[Address(RVA = "0x351ABC0", Offset = "0x35197C0", VA = "0x18351ABC0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x0600D05C RID: 53340 RVA: 0x0004B270 File Offset: 0x00049470
		[Token(Token = "0x170018E5")]
		public override int faceSign
		{
			[Token(Token = "0x600D05C")]
			[Address(RVA = "0x351A4B0", Offset = "0x35190B0", VA = "0x18351A4B0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600D05D RID: 53341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E6")]
		public override SkeletonAnimation skeleton
		{
			[Token(Token = "0x600D05D")]
			[Address(RVA = "0x351AC40", Offset = "0x3519840", VA = "0x18351AC40", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600D05E RID: 53342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E7")]
		public override string bakedDataKey
		{
			[Token(Token = "0x600D05E")]
			[Address(RVA = "0x351A430", Offset = "0x3519030", VA = "0x18351A430", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600D05F RID: 53343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E8")]
		public override FaceSwitcher faceSwitcher
		{
			[Token(Token = "0x600D05F")]
			[Address(RVA = "0x351A580", Offset = "0x3519180", VA = "0x18351A580", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600D060 RID: 53344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018E9")]
		public Renderer renderer
		{
			[Token(Token = "0x600D060")]
			[Address(RVA = "0x351AAE0", Offset = "0x35196E0", VA = "0x18351AAE0", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600D061 RID: 53345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018EA")]
		public override Renderer meshRenderer
		{
			[Token(Token = "0x600D061")]
			[Address(RVA = "0x351A930", Offset = "0x3519530", VA = "0x18351A930", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600D062 RID: 53346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018EB")]
		public override MeshFilter meshFilter
		{
			[Token(Token = "0x600D062")]
			[Address(RVA = "0x351A850", Offset = "0x3519450", VA = "0x18351A850", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D063")]
		[Address(RVA = "0x3519B60", Offset = "0x3518760", VA = "0x183519B60", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D064")]
		[Address(RVA = "0x3519730", Offset = "0x3518330", VA = "0x183519730", Slot = "53")]
		public override string GetFaceKey(IFaceConfiguration faceConfig)
		{
			return null;
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D065")]
		[Address(RVA = "0x35196C0", Offset = "0x35182C0", VA = "0x1835196C0", Slot = "54")]
		public override IFaceConfiguration GetFaceConfiguration(string faceKey)
		{
			return null;
		}

		// Token: 0x0600D066 RID: 53350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D066")]
		[Address(RVA = "0x3519660", Offset = "0x3518260", VA = "0x183519660", Slot = "55")]
		public override IFaceConfiguration GetActiveFace()
		{
			return null;
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D067")]
		[Address(RVA = "0x351A210", Offset = "0x3518E10", VA = "0x18351A210", Slot = "24")]
		public override void SyncFrom(UnitAnimator fromAnimator)
		{
		}

		// Token: 0x0600D068 RID: 53352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D068")]
		[Address(RVA = "0x3519890", Offset = "0x3518490", VA = "0x183519890", Slot = "34")]
		public override Transform GetMountPoint(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D069")]
		[Address(RVA = "0x3519B00", Offset = "0x3518700", VA = "0x183519B00", Slot = "69")]
		public SkeletonAnimation GetSkeleton()
		{
			return null;
		}

		// Token: 0x0600D06A RID: 53354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D06A")]
		[Address(RVA = "0x35197B0", Offset = "0x35183B0", VA = "0x1835197B0", Slot = "70")]
		public Transform GetFaceMountPointTransform(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D06B")]
		[Address(RVA = "0x3519EE0", Offset = "0x3518AE0", VA = "0x183519EE0", Slot = "26")]
		public override void OnReset(UnitAnimator old)
		{
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D06C")]
		[Address(RVA = "0x3519CF0", Offset = "0x35188F0", VA = "0x183519CF0", Slot = "32")]
		public override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600D06D RID: 53357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D06D")]
		[Address(RVA = "0x351A050", Offset = "0x3518C50", VA = "0x18351A050", Slot = "62")]
		public override void ReplaceShader()
		{
		}

		// Token: 0x0600D06E RID: 53358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D06E")]
		[Address(RVA = "0x3519470", Offset = "0x3518070", VA = "0x183519470", Slot = "45")]
		protected override void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D06F")]
		[Address(RVA = "0x35195B0", Offset = "0x35181B0", VA = "0x1835195B0", Slot = "66")]
		protected override void ForEachSkeleton(Action<SkeletonAnimation> func)
		{
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D070")]
		[Address(RVA = "0x3519520", Offset = "0x3518120", VA = "0x183519520", Slot = "67")]
		public override void ForEachFaceConfiguration(Action<IFaceConfiguration> func)
		{
		}

		// Token: 0x0600D071 RID: 53361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D071")]
		[Address(RVA = "0x351A340", Offset = "0x3518F40", VA = "0x18351A340")]
		private void _UpdateDirection(SharedConsts.Direction lOrR, SharedConsts.Direction fourDir)
		{
		}

		// Token: 0x0600D072 RID: 53362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D072")]
		[Address(RVA = "0x351A3D0", Offset = "0x3518FD0", VA = "0x18351A3D0")]
		public SingleSpineAnimator()
		{
		}

		// Token: 0x0600D073 RID: 53363 RVA: 0x0004B288 File Offset: 0x00049488
		[Token(Token = "0x600D073")]
		[Address(RVA = "0x350BA20", Offset = "0x350A620", VA = "0x18350BA20")]
		private int <>xLuaBaseProxy_get_faceSign()
		{
			return 0;
		}

		// Token: 0x0600D074 RID: 53364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D074")]
		[Address(RVA = "0x350BA50", Offset = "0x350A650", VA = "0x18350BA50")]
		private Renderer <>xLuaBaseProxy_get_meshRenderer()
		{
			return null;
		}

		// Token: 0x0600D075 RID: 53365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D075")]
		[Address(RVA = "0x350BA40", Offset = "0x350A640", VA = "0x18350BA40")]
		private MeshFilter <>xLuaBaseProxy_get_meshFilter()
		{
			return null;
		}

		// Token: 0x0600D076 RID: 53366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D076")]
		[Address(RVA = "0x350B750", Offset = "0x350A350", VA = "0x18350B750")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D077")]
		[Address(RVA = "0x351A330", Offset = "0x3518F30", VA = "0x18351A330")]
		private void <>xLuaBaseProxy_SyncFrom(UnitAnimator P0)
		{
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D078")]
		[Address(RVA = "0x350B740", Offset = "0x350A340", VA = "0x18350B740")]
		private Transform <>xLuaBaseProxy_GetMountPoint(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D079")]
		[Address(RVA = "0x350B760", Offset = "0x350A360", VA = "0x18350B760")]
		private void <>xLuaBaseProxy_OnReset(UnitAnimator P0)
		{
		}

		// Token: 0x0600D07A RID: 53370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D07A")]
		[Address(RVA = "0x350B780", Offset = "0x350A380", VA = "0x18350B780")]
		private void <>xLuaBaseProxy_ReplaceShader()
		{
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D07B")]
		[Address(RVA = "0x350B730", Offset = "0x350A330", VA = "0x18350B730")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0400DEAD RID: 57005
		[Token(Token = "0x400DEAD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SkeletonAnimation _skeleton;

		// Token: 0x0400DEAE RID: 57006
		[Token(Token = "0x400DEAE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private FaceSwitcher _faceSwitcher;

		// Token: 0x0400DEAF RID: 57007
		[Token(Token = "0x400DEAF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _muzzleTransform;

		// Token: 0x0400DEB0 RID: 57008
		[Token(Token = "0x400DEB0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _hitTransform;

		// Token: 0x0400DEB1 RID: 57009
		[Token(Token = "0x400DEB1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Transform _headTransform;

		// Token: 0x0400DEB2 RID: 57010
		[Token(Token = "0x400DEB2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _specialPoint0;

		// Token: 0x0400DEB3 RID: 57011
		[Token(Token = "0x400DEB3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform _specialPoint1;

		// Token: 0x0400DEB4 RID: 57012
		[Token(Token = "0x400DEB4")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Transform _specialPoint2;

		// Token: 0x0400DEB5 RID: 57013
		[Token(Token = "0x400DEB5")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Transform _specialPoint3;

		// Token: 0x0400DEB6 RID: 57014
		[Token(Token = "0x400DEB6")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Transform _specialPoint4;

		// Token: 0x0400DEB7 RID: 57015
		[Token(Token = "0x400DEB7")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Transform _specialPoint5;

		// Token: 0x0400DEB8 RID: 57016
		[Token(Token = "0x400DEB8")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Transform _specialPoint6;

		// Token: 0x0400DEB9 RID: 57017
		[Token(Token = "0x400DEB9")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Transform _specialPoint7;

		// Token: 0x0400DEBA RID: 57018
		[Token(Token = "0x400DEBA")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Transform _specialPoint8;

		// Token: 0x0400DEBB RID: 57019
		[Token(Token = "0x400DEBB")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Transform _specialPoint9;

		// Token: 0x0400DEBC RID: 57020
		[Token(Token = "0x400DEBC")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Transform _specialPoint10;

		// Token: 0x0400DEBD RID: 57021
		[Token(Token = "0x400DEBD")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Transform _specialPoint11;

		// Token: 0x0400DEBE RID: 57022
		[Token(Token = "0x400DEBE")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Transform _specialPoint12;

		// Token: 0x0400DEBF RID: 57023
		[Token(Token = "0x400DEBF")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Transform _specialPoint13;

		// Token: 0x0400DEC0 RID: 57024
		[Token(Token = "0x400DEC0")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Transform _specialPoint14;

		// Token: 0x0400DEC1 RID: 57025
		[Token(Token = "0x400DEC1")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Transform _specialPoint15;

		// Token: 0x0400DEC2 RID: 57026
		[Token(Token = "0x400DEC2")]
		[FieldOffset(Offset = "0x188")]
		private Renderer m_renderer;

		// Token: 0x0400DEC3 RID: 57027
		[Token(Token = "0x400DEC3")]
		[FieldOffset(Offset = "0x190")]
		private MeshFilter m_meshFilter;

		// Token: 0x0400DEC4 RID: 57028
		[Token(Token = "0x400DEC4")]
		[FieldOffset(Offset = "0x198")]
		private Action<SharedConsts.Direction, SharedConsts.Direction> m_UpdateDir;

		// Token: 0x0400DEC5 RID: 57029
		[Token(Token = "0x400DEC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400DEC6 RID: 57030
		[Token(Token = "0x400DEC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_muzzleTransform;

		// Token: 0x0400DEC7 RID: 57031
		[Token(Token = "0x400DEC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hitTransform;

		// Token: 0x0400DEC8 RID: 57032
		[Token(Token = "0x400DEC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_footTransform;

		// Token: 0x0400DEC9 RID: 57033
		[Token(Token = "0x400DEC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_headTransform;

		// Token: 0x0400DECA RID: 57034
		[Token(Token = "0x400DECA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_shadowTransform;

		// Token: 0x0400DECB RID: 57035
		[Token(Token = "0x400DECB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x0400DECC RID: 57036
		[Token(Token = "0x400DECC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x0400DECD RID: 57037
		[Token(Token = "0x400DECD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bakedDataKey;

		// Token: 0x0400DECE RID: 57038
		[Token(Token = "0x400DECE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_faceSwitcher;

		// Token: 0x0400DECF RID: 57039
		[Token(Token = "0x400DECF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_renderer;

		// Token: 0x0400DED0 RID: 57040
		[Token(Token = "0x400DED0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_meshRenderer;

		// Token: 0x0400DED1 RID: 57041
		[Token(Token = "0x400DED1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_meshFilter;

		// Token: 0x0400DED2 RID: 57042
		[Token(Token = "0x400DED2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DED3 RID: 57043
		[Token(Token = "0x400DED3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetFaceKey;

		// Token: 0x0400DED4 RID: 57044
		[Token(Token = "0x400DED4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetFaceConfiguration;

		// Token: 0x0400DED5 RID: 57045
		[Token(Token = "0x400DED5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetActiveFace;

		// Token: 0x0400DED6 RID: 57046
		[Token(Token = "0x400DED6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SyncFrom;

		// Token: 0x0400DED7 RID: 57047
		[Token(Token = "0x400DED7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400DED8 RID: 57048
		[Token(Token = "0x400DED8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetSkeleton;

		// Token: 0x0400DED9 RID: 57049
		[Token(Token = "0x400DED9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetFaceMountPointTransform;

		// Token: 0x0400DEDA RID: 57050
		[Token(Token = "0x400DEDA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400DEDB RID: 57051
		[Token(Token = "0x400DEDB")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DEDC RID: 57052
		[Token(Token = "0x400DEDC")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ReplaceShader;

		// Token: 0x0400DEDD RID: 57053
		[Token(Token = "0x400DEDD")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DEDE RID: 57054
		[Token(Token = "0x400DEDE")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ForEachSkeleton;

		// Token: 0x0400DEDF RID: 57055
		[Token(Token = "0x400DEDF")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ForEachFaceConfiguration;

		// Token: 0x0400DEE0 RID: 57056
		[Token(Token = "0x400DEE0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateDirection;

		// Token: 0x0400DEE1 RID: 57057
		[Token(Token = "0x400DEE1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
