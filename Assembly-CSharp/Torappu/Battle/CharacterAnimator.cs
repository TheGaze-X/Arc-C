using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002116 RID: 8470
	[Token(Token = "0x2002116")]
	public class CharacterAnimator : SpineAnimator
	{
		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600CF67 RID: 53095 RVA: 0x0004AD90 File Offset: 0x00048F90
		[Token(Token = "0x1700189E")]
		protected override bool useNewSpineFormat
		{
			[Token(Token = "0x600CF67")]
			[Address(RVA = "0x350CFF0", Offset = "0x350BBF0", VA = "0x18350CFF0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x0600CF68 RID: 53096 RVA: 0x0004ADA8 File Offset: 0x00048FA8
		// (set) Token: 0x0600CF69 RID: 53097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700189F")]
		public bool forceFaceFront
		{
			[Token(Token = "0x600CF68")]
			[Address(RVA = "0x350C920", Offset = "0x350B520", VA = "0x18350C920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CF69")]
			[Address(RVA = "0x350D190", Offset = "0x350BD90", VA = "0x18350D190")]
			set
			{
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A0")]
		public CharacterAnimator.FaceConfiguration front
		{
			[Token(Token = "0x600CF6A")]
			[Address(RVA = "0x350C980", Offset = "0x350B580", VA = "0x18350C980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600CF6B RID: 53099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A1")]
		public CharacterAnimator.FaceConfiguration back
		{
			[Token(Token = "0x600CF6B")]
			[Address(RVA = "0x350C480", Offset = "0x350B080", VA = "0x18350C480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A2")]
		public override Renderer meshRenderer
		{
			[Token(Token = "0x600CF6C")]
			[Address(RVA = "0x350CD30", Offset = "0x350B930", VA = "0x18350CD30", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600CF6D RID: 53101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A3")]
		public override MeshFilter meshFilter
		{
			[Token(Token = "0x600CF6D")]
			[Address(RVA = "0x350CC20", Offset = "0x350B820", VA = "0x18350CC20", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x0600CF6E RID: 53102 RVA: 0x0004ADC0 File Offset: 0x00048FC0
		// (set) Token: 0x0600CF6F RID: 53103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170018A4")]
		public override Color color
		{
			[Token(Token = "0x600CF6E")]
			[Address(RVA = "0x350C5C0", Offset = "0x350B1C0", VA = "0x18350C5C0", Slot = "5")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600CF6F")]
			[Address(RVA = "0x350D050", Offset = "0x350BC50", VA = "0x18350D050", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600CF70 RID: 53104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A5")]
		public override Transform graphicTransform
		{
			[Token(Token = "0x600CF70")]
			[Address(RVA = "0x350C9E0", Offset = "0x350B5E0", VA = "0x18350C9E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600CF71 RID: 53105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A6")]
		protected override Transform muzzleTransform
		{
			[Token(Token = "0x600CF71")]
			[Address(RVA = "0x350CDA0", Offset = "0x350B9A0", VA = "0x18350CDA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A7")]
		public override Transform hitTransform
		{
			[Token(Token = "0x600CF72")]
			[Address(RVA = "0x350CB30", Offset = "0x350B730", VA = "0x18350CB30", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600CF73 RID: 53107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A8")]
		public override Transform footTransform
		{
			[Token(Token = "0x600CF73")]
			[Address(RVA = "0x350C8A0", Offset = "0x350B4A0", VA = "0x18350C8A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018A9")]
		public override Transform headTransform
		{
			[Token(Token = "0x600CF74")]
			[Address(RVA = "0x350CA40", Offset = "0x350B640", VA = "0x18350CA40", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600CF75 RID: 53109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018AA")]
		public override Transform shadowTransform
		{
			[Token(Token = "0x600CF75")]
			[Address(RVA = "0x350CE90", Offset = "0x350BA90", VA = "0x18350CE90", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x0004ADD8 File Offset: 0x00048FD8
		[Token(Token = "0x170018AB")]
		public override bool faceToBack
		{
			[Token(Token = "0x600CF76")]
			[Address(RVA = "0x350C830", Offset = "0x350B430", VA = "0x18350C830", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600CF77 RID: 53111 RVA: 0x0004ADF0 File Offset: 0x00048FF0
		[Token(Token = "0x170018AC")]
		public override int faceSign
		{
			[Token(Token = "0x600CF77")]
			[Address(RVA = "0x350C700", Offset = "0x350B300", VA = "0x18350C700", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x0004AE08 File Offset: 0x00049008
		[Token(Token = "0x170018AD")]
		public override SharedConsts.Direction faceLOrR
		{
			[Token(Token = "0x600CF78")]
			[Address(RVA = "0x350C640", Offset = "0x350B240", VA = "0x18350C640", Slot = "10")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600CF79 RID: 53113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018AE")]
		protected CharacterAnimator.FaceConfiguration activeFace
		{
			[Token(Token = "0x600CF79")]
			[Address(RVA = "0x350C420", Offset = "0x350B020", VA = "0x18350C420")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600CF7A RID: 53114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018AF")]
		public override SkeletonAnimation skeleton
		{
			[Token(Token = "0x600CF7A")]
			[Address(RVA = "0x350CF80", Offset = "0x350BB80", VA = "0x18350CF80", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600CF7B RID: 53115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018B0")]
		public override string bakedDataKey
		{
			[Token(Token = "0x600CF7B")]
			[Address(RVA = "0x350C4E0", Offset = "0x350B0E0", VA = "0x18350C4E0", Slot = "50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600CF7C RID: 53116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018B1")]
		public override FaceSwitcher faceSwitcher
		{
			[Token(Token = "0x600CF7C")]
			[Address(RVA = "0x350C7D0", Offset = "0x350B3D0", VA = "0x18350C7D0", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF7D")]
		[Address(RVA = "0x350A8B0", Offset = "0x35094B0", VA = "0x18350A8B0", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF7E")]
		[Address(RVA = "0x350A430", Offset = "0x3509030", VA = "0x18350A430", Slot = "53")]
		public override string GetFaceKey(IFaceConfiguration faceConfig)
		{
			return null;
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF7F")]
		[Address(RVA = "0x350A350", Offset = "0x3508F50", VA = "0x18350A350", Slot = "54")]
		public override IFaceConfiguration GetFaceConfiguration(string faceKey)
		{
			return null;
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF80")]
		[Address(RVA = "0x350A2F0", Offset = "0x3508EF0", VA = "0x18350A2F0", Slot = "55")]
		public override IFaceConfiguration GetActiveFace()
		{
			return null;
		}

		// Token: 0x0600CF81 RID: 53121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF81")]
		[Address(RVA = "0x350A830", Offset = "0x3509430", VA = "0x18350A830")]
		protected void Init_Base_SpineAnimator(Unit host)
		{
		}

		// Token: 0x0600CF82 RID: 53122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF82")]
		[Address(RVA = "0x350A4E0", Offset = "0x35090E0", VA = "0x18350A4E0", Slot = "34")]
		public override Transform GetMountPoint(Entity.MountPointType mountPointType)
		{
			return null;
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF83")]
		[Address(RVA = "0x350ADB0", Offset = "0x35099B0", VA = "0x18350ADB0", Slot = "26")]
		public override void OnReset(UnitAnimator old)
		{
		}

		// Token: 0x0600CF84 RID: 53124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF84")]
		[Address(RVA = "0x350A9D0", Offset = "0x35095D0", VA = "0x18350A9D0", Slot = "32")]
		public override void OnFaceChanged(Vector2 newDir, Vector2 oldDir, bool force, bool isIdle)
		{
		}

		// Token: 0x0600CF85 RID: 53125 RVA: 0x0004AE20 File Offset: 0x00049020
		[Token(Token = "0x600CF85")]
		[Address(RVA = "0x350AF50", Offset = "0x3509B50", VA = "0x18350AF50", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600CF86 RID: 53126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF86")]
		[Address(RVA = "0x350B330", Offset = "0x3509F30", VA = "0x18350B330", Slot = "56")]
		protected override void SetSpineSkinInternal(SpineAnimator.SpineSkinData data)
		{
		}

		// Token: 0x0600CF87 RID: 53127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF87")]
		[Address(RVA = "0x350BC00", Offset = "0x350A800", VA = "0x18350BC00", Slot = "60")]
		protected override void UpdateSpineSkinData()
		{
		}

		// Token: 0x0600CF88 RID: 53128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF88")]
		[Address(RVA = "0x350B190", Offset = "0x3509D90", VA = "0x18350B190", Slot = "62")]
		public override void ReplaceShader()
		{
		}

		// Token: 0x0600CF89 RID: 53129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF89")]
		[Address(RVA = "0x350BAE0", Offset = "0x350A6E0", VA = "0x18350BAE0", Slot = "63")]
		public override void UpdateBaseline()
		{
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF8A")]
		[Address(RVA = "0x350A0C0", Offset = "0x3508CC0", VA = "0x18350A0C0", Slot = "45")]
		protected override void DoUpdateFaceSign(int faceSign)
		{
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF8B")]
		[Address(RVA = "0x350A230", Offset = "0x3508E30", VA = "0x18350A230", Slot = "66")]
		protected override void ForEachSkeleton(Action<SkeletonAnimation> func)
		{
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF8C")]
		[Address(RVA = "0x350A180", Offset = "0x3508D80", VA = "0x18350A180", Slot = "67")]
		public override void ForEachFaceConfiguration(Action<IFaceConfiguration> func)
		{
		}

		// Token: 0x0600CF8D RID: 53133 RVA: 0x0004AE38 File Offset: 0x00049038
		[Token(Token = "0x600CF8D")]
		[Address(RVA = "0x350BEF0", Offset = "0x350AAF0", VA = "0x18350BEF0")]
		private SharedConsts.Direction _CalculateLOrRDirection(Vector2 newDir, SharedConsts.Direction defaultLOrR)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF8E")]
		[Address(RVA = "0x350C050", Offset = "0x350AC50", VA = "0x18350C050", Slot = "69")]
		protected virtual void _SetFourDirection(SharedConsts.Direction lOrR, SharedConsts.Direction uOrD)
		{
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF8F")]
		[Address(RVA = "0x350C130", Offset = "0x350AD30", VA = "0x18350C130")]
		protected void _SwapConfiguration(CharacterAnimator.FaceConfiguration to, CharacterAnimator.FaceConfiguration from, bool needSync = true, bool force = false)
		{
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x0004AE50 File Offset: 0x00049050
		[Token(Token = "0x600CF90")]
		[Address(RVA = "0x350B590", Offset = "0x350A190", VA = "0x18350B590", Slot = "68")]
		protected override bool TryGetSpinePrefix(out string prefix)
		{
			return default(bool);
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF91")]
		[Address(RVA = "0x350C3C0", Offset = "0x350AFC0", VA = "0x18350C3C0")]
		public CharacterAnimator()
		{
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x0004AE68 File Offset: 0x00049068
		[Token(Token = "0x600CF92")]
		[Address(RVA = "0x350BA60", Offset = "0x350A660", VA = "0x18350BA60")]
		private bool <>xLuaBaseProxy_get_useNewSpineFormat()
		{
			return default(bool);
		}

		// Token: 0x0600CF93 RID: 53139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF93")]
		[Address(RVA = "0x350BA50", Offset = "0x350A650", VA = "0x18350BA50")]
		private Renderer <>xLuaBaseProxy_get_meshRenderer()
		{
			return null;
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF94")]
		[Address(RVA = "0x350BA40", Offset = "0x350A640", VA = "0x18350BA40")]
		private MeshFilter <>xLuaBaseProxy_get_meshFilter()
		{
			return null;
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x0004AE80 File Offset: 0x00049080
		[Token(Token = "0x600CF95")]
		[Address(RVA = "0x350B960", Offset = "0x350A560", VA = "0x18350B960")]
		private Color <>xLuaBaseProxy_get_color()
		{
			return default(Color);
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF96")]
		[Address(RVA = "0x350BAC0", Offset = "0x350A6C0", VA = "0x18350BAC0")]
		private void <>xLuaBaseProxy_set_color(Color P0)
		{
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x0004AE98 File Offset: 0x00049098
		[Token(Token = "0x600CF97")]
		[Address(RVA = "0x350BA30", Offset = "0x350A630", VA = "0x18350BA30")]
		private bool <>xLuaBaseProxy_get_faceToBack()
		{
			return default(bool);
		}

		// Token: 0x0600CF98 RID: 53144 RVA: 0x0004AEB0 File Offset: 0x000490B0
		[Token(Token = "0x600CF98")]
		[Address(RVA = "0x350BA20", Offset = "0x350A620", VA = "0x18350BA20")]
		private int <>xLuaBaseProxy_get_faceSign()
		{
			return 0;
		}

		// Token: 0x0600CF99 RID: 53145 RVA: 0x0004AEC8 File Offset: 0x000490C8
		[Token(Token = "0x600CF99")]
		[Address(RVA = "0x350BA10", Offset = "0x350A610", VA = "0x18350BA10")]
		private SharedConsts.Direction <>xLuaBaseProxy_get_faceLOrR()
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600CF9A RID: 53146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF9A")]
		[Address(RVA = "0x350B750", Offset = "0x350A350", VA = "0x18350B750")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600CF9B RID: 53147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CF9B")]
		[Address(RVA = "0x350B740", Offset = "0x350A340", VA = "0x18350B740")]
		private Transform <>xLuaBaseProxy_GetMountPoint(Entity.MountPointType P0)
		{
			return null;
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF9C")]
		[Address(RVA = "0x350B760", Offset = "0x350A360", VA = "0x18350B760")]
		private void <>xLuaBaseProxy_OnReset(UnitAnimator P0)
		{
		}

		// Token: 0x0600CF9D RID: 53149 RVA: 0x0004AEE0 File Offset: 0x000490E0
		[Token(Token = "0x600CF9D")]
		[Address(RVA = "0x350B770", Offset = "0x350A370", VA = "0x18350B770")]
		private float <>xLuaBaseProxy_PlayAnimationInternal(string P0, bool P1, float P2)
		{
			return 0f;
		}

		// Token: 0x0600CF9E RID: 53150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF9E")]
		[Address(RVA = "0x350B7E0", Offset = "0x350A3E0", VA = "0x18350B7E0")]
		private void <>xLuaBaseProxy_SetSpineSkinInternal(SpineAnimator.SpineSkinData P0)
		{
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF9F")]
		[Address(RVA = "0x350B950", Offset = "0x350A550", VA = "0x18350B950")]
		private void <>xLuaBaseProxy_UpdateSpineSkinData()
		{
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFA0")]
		[Address(RVA = "0x350B780", Offset = "0x350A380", VA = "0x18350B780")]
		private void <>xLuaBaseProxy_ReplaceShader()
		{
		}

		// Token: 0x0600CFA1 RID: 53153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFA1")]
		[Address(RVA = "0x350B870", Offset = "0x350A470", VA = "0x18350B870")]
		private void <>xLuaBaseProxy_UpdateBaseline()
		{
		}

		// Token: 0x0600CFA2 RID: 53154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CFA2")]
		[Address(RVA = "0x350B730", Offset = "0x350A330", VA = "0x18350B730")]
		private void <>xLuaBaseProxy_DoUpdateFaceSign(int P0)
		{
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x0004AEF8 File Offset: 0x000490F8
		[Token(Token = "0x600CFA3")]
		[Address(RVA = "0x350B7F0", Offset = "0x350A3F0", VA = "0x18350B7F0")]
		private bool <>xLuaBaseProxy_TryGetSpinePrefix(out string P0)
		{
			return default(bool);
		}

		// Token: 0x0400DD83 RID: 56707
		[Token(Token = "0x400DD83")]
		private const float TOLERANCE_L_OR_R_DIRECTION = 0.2f;

		// Token: 0x0400DD84 RID: 56708
		[Token(Token = "0x400DD84")]
		[NonSerialized]
		public const float ADDON_TO_L_OR_R_DIRECTION = 0.25f;

		// Token: 0x0400DD85 RID: 56709
		[Token(Token = "0x400DD85")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private FaceSwitcher _faceSwitcher;

		// Token: 0x0400DD86 RID: 56710
		[Token(Token = "0x400DD86")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CharacterAnimator.FaceConfiguration _front;

		// Token: 0x0400DD87 RID: 56711
		[Token(Token = "0x400DD87")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CharacterAnimator.FaceConfiguration _back;

		// Token: 0x0400DD88 RID: 56712
		[Token(Token = "0x400DD88")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _useNewSpineFormat;

		// Token: 0x0400DD89 RID: 56713
		[Token(Token = "0x400DD89")]
		[FieldOffset(Offset = "0xF9")]
		private bool m_forceFaceFront;

		// Token: 0x0400DD8A RID: 56714
		[Token(Token = "0x400DD8A")]
		[FieldOffset(Offset = "0x100")]
		private Action<SharedConsts.Direction, SharedConsts.Direction> m_SetForDir;

		// Token: 0x0400DD8B RID: 56715
		[Token(Token = "0x400DD8B")]
		[FieldOffset(Offset = "0x108")]
		protected Color m_color;

		// Token: 0x0400DD8C RID: 56716
		[Token(Token = "0x400DD8C")]
		[FieldOffset(Offset = "0x118")]
		private CharacterAnimator.FaceConfiguration m_activeFace;

		// Token: 0x0400DD8D RID: 56717
		[Token(Token = "0x400DD8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useNewSpineFormat;

		// Token: 0x0400DD8E RID: 56718
		[Token(Token = "0x400DD8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_forceFaceFront;

		// Token: 0x0400DD8F RID: 56719
		[Token(Token = "0x400DD8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_forceFaceFront;

		// Token: 0x0400DD90 RID: 56720
		[Token(Token = "0x400DD90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_front;

		// Token: 0x0400DD91 RID: 56721
		[Token(Token = "0x400DD91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_back;

		// Token: 0x0400DD92 RID: 56722
		[Token(Token = "0x400DD92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_meshRenderer;

		// Token: 0x0400DD93 RID: 56723
		[Token(Token = "0x400DD93")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_meshFilter;

		// Token: 0x0400DD94 RID: 56724
		[Token(Token = "0x400DD94")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0400DD95 RID: 56725
		[Token(Token = "0x400DD95")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x0400DD96 RID: 56726
		[Token(Token = "0x400DD96")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_graphicTransform;

		// Token: 0x0400DD97 RID: 56727
		[Token(Token = "0x400DD97")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_muzzleTransform;

		// Token: 0x0400DD98 RID: 56728
		[Token(Token = "0x400DD98")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hitTransform;

		// Token: 0x0400DD99 RID: 56729
		[Token(Token = "0x400DD99")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_footTransform;

		// Token: 0x0400DD9A RID: 56730
		[Token(Token = "0x400DD9A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_headTransform;

		// Token: 0x0400DD9B RID: 56731
		[Token(Token = "0x400DD9B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_shadowTransform;

		// Token: 0x0400DD9C RID: 56732
		[Token(Token = "0x400DD9C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_faceToBack;

		// Token: 0x0400DD9D RID: 56733
		[Token(Token = "0x400DD9D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x0400DD9E RID: 56734
		[Token(Token = "0x400DD9E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_faceLOrR;

		// Token: 0x0400DD9F RID: 56735
		[Token(Token = "0x400DD9F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_activeFace;

		// Token: 0x0400DDA0 RID: 56736
		[Token(Token = "0x400DDA0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x0400DDA1 RID: 56737
		[Token(Token = "0x400DDA1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_bakedDataKey;

		// Token: 0x0400DDA2 RID: 56738
		[Token(Token = "0x400DDA2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_faceSwitcher;

		// Token: 0x0400DDA3 RID: 56739
		[Token(Token = "0x400DDA3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DDA4 RID: 56740
		[Token(Token = "0x400DDA4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetFaceKey;

		// Token: 0x0400DDA5 RID: 56741
		[Token(Token = "0x400DDA5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetFaceConfiguration;

		// Token: 0x0400DDA6 RID: 56742
		[Token(Token = "0x400DDA6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetActiveFace;

		// Token: 0x0400DDA7 RID: 56743
		[Token(Token = "0x400DDA7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_Init_Base_SpineAnimator;

		// Token: 0x0400DDA8 RID: 56744
		[Token(Token = "0x400DDA8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetMountPoint;

		// Token: 0x0400DDA9 RID: 56745
		[Token(Token = "0x400DDA9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400DDAA RID: 56746
		[Token(Token = "0x400DDAA")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnFaceChanged;

		// Token: 0x0400DDAB RID: 56747
		[Token(Token = "0x400DDAB")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DDAC RID: 56748
		[Token(Token = "0x400DDAC")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SetSpineSkinInternal;

		// Token: 0x0400DDAD RID: 56749
		[Token(Token = "0x400DDAD")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_UpdateSpineSkinData;

		// Token: 0x0400DDAE RID: 56750
		[Token(Token = "0x400DDAE")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ReplaceShader;

		// Token: 0x0400DDAF RID: 56751
		[Token(Token = "0x400DDAF")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_UpdateBaseline;

		// Token: 0x0400DDB0 RID: 56752
		[Token(Token = "0x400DDB0")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_DoUpdateFaceSign;

		// Token: 0x0400DDB1 RID: 56753
		[Token(Token = "0x400DDB1")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ForEachSkeleton;

		// Token: 0x0400DDB2 RID: 56754
		[Token(Token = "0x400DDB2")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ForEachFaceConfiguration;

		// Token: 0x0400DDB3 RID: 56755
		[Token(Token = "0x400DDB3")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CalculateLOrRDirection;

		// Token: 0x0400DDB4 RID: 56756
		[Token(Token = "0x400DDB4")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SetFourDirection;

		// Token: 0x0400DDB5 RID: 56757
		[Token(Token = "0x400DDB5")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SwapConfiguration;

		// Token: 0x0400DDB6 RID: 56758
		[Token(Token = "0x400DDB6")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryGetSpinePrefix;

		// Token: 0x0400DDB7 RID: 56759
		[Token(Token = "0x400DDB7")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002117 RID: 8471
		[Token(Token = "0x2002117")]
		[Serializable]
		public class FaceConfiguration : IFaceConfiguration
		{
			// Token: 0x170018B2 RID: 6322
			// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170018B2")]
			public Renderer renderer
			{
				[Token(Token = "0x600CFA4")]
				[Address(RVA = "0x350F150", Offset = "0x350DD50", VA = "0x18350F150", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x170018B3 RID: 6323
			// (get) Token: 0x0600CFA5 RID: 53157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170018B3")]
			public MeshFilter meshFilter
			{
				[Token(Token = "0x600CFA5")]
				[Address(RVA = "0x350F0A0", Offset = "0x350DCA0", VA = "0x18350F0A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600CFA6 RID: 53158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CFA6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public SkeletonAnimation GetSkeleton()
			{
				return null;
			}

			// Token: 0x0600CFA7 RID: 53159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CFA7")]
			[Address(RVA = "0x350EF30", Offset = "0x350DB30", VA = "0x18350EF30", Slot = "5")]
			public Transform GetFaceMountPointTransform(Entity.MountPointType mountPointType)
			{
				return null;
			}

			// Token: 0x0600CFA8 RID: 53160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CFA8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FaceConfiguration()
			{
			}

			// Token: 0x0400DDB8 RID: 56760
			[Token(Token = "0x400DDB8")]
			[FieldOffset(Offset = "0x10")]
			public SkeletonAnimation skeleton;

			// Token: 0x0400DDB9 RID: 56761
			[Token(Token = "0x400DDB9")]
			[FieldOffset(Offset = "0x18")]
			public Transform muzzlaTransform;

			// Token: 0x0400DDBA RID: 56762
			[Token(Token = "0x400DDBA")]
			[FieldOffset(Offset = "0x20")]
			public Transform hitTransform;

			// Token: 0x0400DDBB RID: 56763
			[Token(Token = "0x400DDBB")]
			[FieldOffset(Offset = "0x28")]
			public Transform headTransform;

			// Token: 0x0400DDBC RID: 56764
			[Token(Token = "0x400DDBC")]
			[FieldOffset(Offset = "0x30")]
			public Transform shadowTransform;

			// Token: 0x0400DDBD RID: 56765
			[Token(Token = "0x400DDBD")]
			[FieldOffset(Offset = "0x38")]
			public Transform specialPoint0;

			// Token: 0x0400DDBE RID: 56766
			[Token(Token = "0x400DDBE")]
			[FieldOffset(Offset = "0x40")]
			public Transform specialPoint1;

			// Token: 0x0400DDBF RID: 56767
			[Token(Token = "0x400DDBF")]
			[FieldOffset(Offset = "0x48")]
			public Transform specialPoint2;

			// Token: 0x0400DDC0 RID: 56768
			[Token(Token = "0x400DDC0")]
			[FieldOffset(Offset = "0x50")]
			public Transform specialPoint3;

			// Token: 0x0400DDC1 RID: 56769
			[Token(Token = "0x400DDC1")]
			[FieldOffset(Offset = "0x58")]
			public Transform specialPoint4;

			// Token: 0x0400DDC2 RID: 56770
			[Token(Token = "0x400DDC2")]
			[FieldOffset(Offset = "0x60")]
			public Transform specialPoint5;

			// Token: 0x0400DDC3 RID: 56771
			[Token(Token = "0x400DDC3")]
			[FieldOffset(Offset = "0x68")]
			public Transform specialPoint6;

			// Token: 0x0400DDC4 RID: 56772
			[Token(Token = "0x400DDC4")]
			[FieldOffset(Offset = "0x70")]
			public Transform specialPoint7;

			// Token: 0x0400DDC5 RID: 56773
			[Token(Token = "0x400DDC5")]
			[FieldOffset(Offset = "0x78")]
			public Transform specialPoint8;

			// Token: 0x0400DDC6 RID: 56774
			[Token(Token = "0x400DDC6")]
			[FieldOffset(Offset = "0x80")]
			public Transform specialPoint9;

			// Token: 0x0400DDC7 RID: 56775
			[Token(Token = "0x400DDC7")]
			[FieldOffset(Offset = "0x88")]
			public Transform specialPoint10;

			// Token: 0x0400DDC8 RID: 56776
			[Token(Token = "0x400DDC8")]
			[FieldOffset(Offset = "0x90")]
			public Transform specialPoint11;

			// Token: 0x0400DDC9 RID: 56777
			[Token(Token = "0x400DDC9")]
			[FieldOffset(Offset = "0x98")]
			public Transform specialPoint12;

			// Token: 0x0400DDCA RID: 56778
			[Token(Token = "0x400DDCA")]
			[FieldOffset(Offset = "0xA0")]
			public Transform specialPoint13;

			// Token: 0x0400DDCB RID: 56779
			[Token(Token = "0x400DDCB")]
			[FieldOffset(Offset = "0xA8")]
			public Transform specialPoint14;

			// Token: 0x0400DDCC RID: 56780
			[Token(Token = "0x400DDCC")]
			[FieldOffset(Offset = "0xB0")]
			public Transform specialPoint15;

			// Token: 0x0400DDCD RID: 56781
			[Token(Token = "0x400DDCD")]
			[FieldOffset(Offset = "0xB8")]
			private Renderer m_renderer;

			// Token: 0x0400DDCE RID: 56782
			[Token(Token = "0x400DDCE")]
			[FieldOffset(Offset = "0xC0")]
			private MeshFilter m_meshFilter;
		}
	}
}
