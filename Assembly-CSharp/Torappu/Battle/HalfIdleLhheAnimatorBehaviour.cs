using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002106 RID: 8454
	[Token(Token = "0x2002106")]
	public class HalfIdleLhheAnimatorBehaviour : UnitAnimator.Behaviour
	{
		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x0600CF32 RID: 53042 RVA: 0x0004AD18 File Offset: 0x00048F18
		[Token(Token = "0x1700189B")]
		public bool isPolluted
		{
			[Token(Token = "0x600CF32")]
			[Address(RVA = "0x3510930", Offset = "0x350F530", VA = "0x183510930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CF33 RID: 53043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF33")]
		[Address(RVA = "0x350FE10", Offset = "0x350EA10", VA = "0x18350FE10", Slot = "4")]
		public override void Init(UnitAnimator unitAnimator)
		{
		}

		// Token: 0x0600CF34 RID: 53044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF34")]
		[Address(RVA = "0x350FFA0", Offset = "0x350EBA0", VA = "0x18350FFA0", Slot = "7")]
		public override void OnEvent(UnitAnimator.Behaviour.Event ev, ValueBundle arg)
		{
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF35")]
		[Address(RVA = "0x350FD10", Offset = "0x350E910", VA = "0x18350FD10")]
		public void AdjustWaterMat(bool isPolluted)
		{
		}

		// Token: 0x0600CF36 RID: 53046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF36")]
		[Address(RVA = "0x3510500", Offset = "0x350F100", VA = "0x183510500")]
		private void _RotateRootTrans(float xAngle, float yAngle, float zAngle)
		{
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF37")]
		[Address(RVA = "0x35103C0", Offset = "0x350EFC0", VA = "0x1835103C0")]
		private void _ResetRootTrans()
		{
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF38")]
		[Address(RVA = "0x3510300", Offset = "0x350EF00", VA = "0x183510300")]
		private void _InactiveAll()
		{
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF39")]
		[Address(RVA = "0x3510600", Offset = "0x350F200", VA = "0x183510600")]
		public HalfIdleLhheAnimatorBehaviour()
		{
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF3A")]
		[Address(RVA = "0x3509390", Offset = "0x3507F90", VA = "0x183509390")]
		private void <>xLuaBaseProxy_Init(UnitAnimator P0)
		{
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF3B")]
		[Address(RVA = "0x350D850", Offset = "0x350C450", VA = "0x18350D850")]
		private void <>xLuaBaseProxy_OnEvent(UnitAnimator.Behaviour.Event P0, ValueBundle P1)
		{
		}

		// Token: 0x0400DCFC RID: 56572
		[Token(Token = "0x400DCFC")]
		private const string SHADER_DEEP_COLOR_PARAM_KEY = "_DeepWaterColor";

		// Token: 0x0400DCFD RID: 56573
		[Token(Token = "0x400DCFD")]
		private const string SHADER_SHALLOW_COLOR_PARAM_KEY = "_ShallowWaterColor";

		// Token: 0x0400DCFE RID: 56574
		[Token(Token = "0x400DCFE")]
		private const string SHADER_FOAM_COLOR_PARAM_KEY = "_FoamCol";

		// Token: 0x0400DCFF RID: 56575
		[Token(Token = "0x400DCFF")]
		private const float TWEEN_TIME = 0.5f;

		// Token: 0x0400DD00 RID: 56576
		[Token(Token = "0x400DD00")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<HalfIdleLhheAnimatorBehaviour.SubmodelType, float> SUBMODEL_TYPE_TO_ANGLE;

		// Token: 0x0400DD01 RID: 56577
		[Token(Token = "0x400DD01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _rootTrans;

		// Token: 0x0400DD02 RID: 56578
		[Token(Token = "0x400DD02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelSingle;

		// Token: 0x0400DD03 RID: 56579
		[Token(Token = "0x400DD03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelEnd;

		// Token: 0x0400DD04 RID: 56580
		[Token(Token = "0x400DD04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelCorner;

		// Token: 0x0400DD05 RID: 56581
		[Token(Token = "0x400DD05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelLine;

		// Token: 0x0400DD06 RID: 56582
		[Token(Token = "0x400DD06")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelEdge;

		// Token: 0x0400DD07 RID: 56583
		[Token(Token = "0x400DD07")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HalfIdleLhheAnimatorBehaviour.HalfIdleLhheSubModels _subModelCenter;

		// Token: 0x0400DD08 RID: 56584
		[Token(Token = "0x400DD08")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _lhheCleanColorDeep;

		// Token: 0x0400DD09 RID: 56585
		[Token(Token = "0x400DD09")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _lhhePolluteColorDeep;

		// Token: 0x0400DD0A RID: 56586
		[Token(Token = "0x400DD0A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _lhheCleanColorFoam;

		// Token: 0x0400DD0B RID: 56587
		[Token(Token = "0x400DD0B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _lhheCleanColorShallow;

		// Token: 0x0400DD0C RID: 56588
		[Token(Token = "0x400DD0C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _lhhePolluteColorShallow;

		// Token: 0x0400DD0D RID: 56589
		[Token(Token = "0x400DD0D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _lhhePolluteColorFoam;

		// Token: 0x0400DD0E RID: 56590
		[Token(Token = "0x400DD0E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<HalfIdleLhheAnimatorBehaviour.HalfIdleLhheWaterMatProperty> _waterMatPropertiesClean;

		// Token: 0x0400DD0F RID: 56591
		[Token(Token = "0x400DD0F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<HalfIdleLhheAnimatorBehaviour.HalfIdleLhheWaterMatProperty> _waterMatPropertiesPollute;

		// Token: 0x0400DD10 RID: 56592
		[Token(Token = "0x400DD10")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isPolluted;

		// Token: 0x0400DD11 RID: 56593
		[Token(Token = "0x400DD11")]
		[FieldOffset(Offset = "0xD4")]
		private HalfIdleLhheAnimatorBehaviour.SubmodelType m_subModelType;

		// Token: 0x0400DD12 RID: 56594
		[Token(Token = "0x400DD12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPolluted;

		// Token: 0x0400DD13 RID: 56595
		[Token(Token = "0x400DD13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DD14 RID: 56596
		[Token(Token = "0x400DD14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0400DD15 RID: 56597
		[Token(Token = "0x400DD15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AdjustWaterMat;

		// Token: 0x0400DD16 RID: 56598
		[Token(Token = "0x400DD16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RotateRootTrans;

		// Token: 0x0400DD17 RID: 56599
		[Token(Token = "0x400DD17")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetRootTrans;

		// Token: 0x0400DD18 RID: 56600
		[Token(Token = "0x400DD18")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InactiveAll;

		// Token: 0x0400DD19 RID: 56601
		[Token(Token = "0x400DD19")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002107 RID: 8455
		[Token(Token = "0x2002107")]
		public enum SubmodelType
		{
			// Token: 0x0400DD1B RID: 56603
			[Token(Token = "0x400DD1B")]
			NONE = 9999999,
			// Token: 0x0400DD1C RID: 56604
			[Token(Token = "0x400DD1C")]
			SINGLE = 0,
			// Token: 0x0400DD1D RID: 56605
			[Token(Token = "0x400DD1D")]
			CENTER = 1111,
			// Token: 0x0400DD1E RID: 56606
			[Token(Token = "0x400DD1E")]
			LEFT_UP_CORNER = 11,
			// Token: 0x0400DD1F RID: 56607
			[Token(Token = "0x400DD1F")]
			LEFT_DOWN_CORNER = 1010,
			// Token: 0x0400DD20 RID: 56608
			[Token(Token = "0x400DD20")]
			RIGHT_UP_CORNER = 101,
			// Token: 0x0400DD21 RID: 56609
			[Token(Token = "0x400DD21")]
			RIGHT_DOWN_CORNER = 1100,
			// Token: 0x0400DD22 RID: 56610
			[Token(Token = "0x400DD22")]
			VERTICAL_LINE = 1001,
			// Token: 0x0400DD23 RID: 56611
			[Token(Token = "0x400DD23")]
			HORIZONTAL_LINE = 110,
			// Token: 0x0400DD24 RID: 56612
			[Token(Token = "0x400DD24")]
			LEFT_EDGE = 1011,
			// Token: 0x0400DD25 RID: 56613
			[Token(Token = "0x400DD25")]
			RIGHT_EDGE = 1101,
			// Token: 0x0400DD26 RID: 56614
			[Token(Token = "0x400DD26")]
			UP_EDGE = 111,
			// Token: 0x0400DD27 RID: 56615
			[Token(Token = "0x400DD27")]
			DOWN_EDGE = 1110,
			// Token: 0x0400DD28 RID: 56616
			[Token(Token = "0x400DD28")]
			LEFT_END = 10,
			// Token: 0x0400DD29 RID: 56617
			[Token(Token = "0x400DD29")]
			RIGHT_END = 100,
			// Token: 0x0400DD2A RID: 56618
			[Token(Token = "0x400DD2A")]
			UP_END = 1,
			// Token: 0x0400DD2B RID: 56619
			[Token(Token = "0x400DD2B")]
			DOWN_END = 1000
		}

		// Token: 0x02002108 RID: 8456
		[Token(Token = "0x2002108")]
		public class HalfIdleLhheAnimatorEventParam
		{
			// Token: 0x0600CF3C RID: 53052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF3C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalfIdleLhheAnimatorEventParam()
			{
			}

			// Token: 0x0400DD2C RID: 56620
			[Token(Token = "0x400DD2C")]
			[FieldOffset(Offset = "0x10")]
			public HalfIdleLhheAnimatorBehaviour.HalfIdleLhheAnimatorEventParam.ArgInfo paramType;

			// Token: 0x0400DD2D RID: 56621
			[Token(Token = "0x400DD2D")]
			[FieldOffset(Offset = "0x14")]
			public HalfIdleLhheAnimatorBehaviour.SubmodelType modelType;

			// Token: 0x0400DD2E RID: 56622
			[Token(Token = "0x400DD2E")]
			[FieldOffset(Offset = "0x18")]
			public bool isPolluted;

			// Token: 0x02002109 RID: 8457
			[Token(Token = "0x2002109")]
			public enum ArgInfo
			{
				// Token: 0x0400DD30 RID: 56624
				[Token(Token = "0x400DD30")]
				NONE,
				// Token: 0x0400DD31 RID: 56625
				[Token(Token = "0x400DD31")]
				MODEL_INFO,
				// Token: 0x0400DD32 RID: 56626
				[Token(Token = "0x400DD32")]
				POLLUTE_INFO
			}
		}

		// Token: 0x0200210A RID: 8458
		[Token(Token = "0x200210A")]
		[Serializable]
		public class HalfIdleLhheWaterMatProperty
		{
			// Token: 0x0600CF3D RID: 53053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF3D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalfIdleLhheWaterMatProperty()
			{
			}

			// Token: 0x0400DD33 RID: 56627
			[Token(Token = "0x400DD33")]
			[FieldOffset(Offset = "0x10")]
			public string propertyName;

			// Token: 0x0400DD34 RID: 56628
			[Token(Token = "0x400DD34")]
			[FieldOffset(Offset = "0x18")]
			public float propertyValue;
		}

		// Token: 0x0200210B RID: 8459
		[Token(Token = "0x200210B")]
		[Serializable]
		public class HalfIdleLhheSubModels
		{
			// Token: 0x0600CF3E RID: 53054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF3E")]
			[Address(RVA = "0x3510990", Offset = "0x350F590", VA = "0x183510990")]
			public void Active(bool isPolluted)
			{
			}

			// Token: 0x0600CF3F RID: 53055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF3F")]
			[Address(RVA = "0x3511460", Offset = "0x3510060", VA = "0x183511460")]
			public void Inactive()
			{
			}

			// Token: 0x0600CF40 RID: 53056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF40")]
			[Address(RVA = "0x3511630", Offset = "0x3510230", VA = "0x183511630")]
			public void Init(HalfIdleLhheAnimatorBehaviour behaviour)
			{
			}

			// Token: 0x0600CF41 RID: 53057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF41")]
			[Address(RVA = "0x3510C90", Offset = "0x350F890", VA = "0x183510C90")]
			public void AdjustWaterMat(bool isPolluted)
			{
			}

			// Token: 0x0600CF42 RID: 53058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF42")]
			[Address(RVA = "0x35116D0", Offset = "0x35102D0", VA = "0x1835116D0")]
			public HalfIdleLhheSubModels()
			{
			}

			// Token: 0x0400DD35 RID: 56629
			[Token(Token = "0x400DD35")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform _fence;

			// Token: 0x0400DD36 RID: 56630
			[Token(Token = "0x400DD36")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform _leaf;

			// Token: 0x0400DD37 RID: 56631
			[Token(Token = "0x400DD37")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform _rock;

			// Token: 0x0400DD38 RID: 56632
			[Token(Token = "0x400DD38")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Transform _water;

			// Token: 0x0400DD39 RID: 56633
			[Token(Token = "0x400DD39")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Renderer _waterRenderer;

			// Token: 0x0400DD3A RID: 56634
			[Token(Token = "0x400DD3A")]
			[FieldOffset(Offset = "0x38")]
			private MaterialPropertyBlock m_matPropBlk;

			// Token: 0x0400DD3B RID: 56635
			[Token(Token = "0x400DD3B")]
			[FieldOffset(Offset = "0x40")]
			private Tween m_colorTween;

			// Token: 0x0400DD3C RID: 56636
			[Token(Token = "0x400DD3C")]
			[FieldOffset(Offset = "0x48")]
			private Tween m_modelTween;

			// Token: 0x0400DD3D RID: 56637
			[Token(Token = "0x400DD3D")]
			[FieldOffset(Offset = "0x50")]
			private Color m_deepColor;

			// Token: 0x0400DD3E RID: 56638
			[Token(Token = "0x400DD3E")]
			[FieldOffset(Offset = "0x60")]
			private Color m_shallowColor;

			// Token: 0x0400DD3F RID: 56639
			[Token(Token = "0x400DD3F")]
			[FieldOffset(Offset = "0x70")]
			private Color m_foamColor;

			// Token: 0x0400DD40 RID: 56640
			[Token(Token = "0x400DD40")]
			[FieldOffset(Offset = "0x80")]
			private HalfIdleLhheAnimatorBehaviour m_behaviour;
		}
	}
}
