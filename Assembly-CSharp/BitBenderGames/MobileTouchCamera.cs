using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BitBenderGames
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	[RequireComponent(typeof(AbstractTouchInputController))]
	[RequireComponent(typeof(Camera))]
	public class MobileTouchCamera : MonoBehaviourWrapped
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x0002C820 File Offset: 0x0002AA20
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700018B")]
		public CameraPlaneAxes CameraAxes
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return CameraPlaneAxes.XY_2D_SIDESCROLL;
			}
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x0002C838 File Offset: 0x0002AA38
		[Token(Token = "0x1700018C")]
		public bool IsAutoScrolling
		{
			[Token(Token = "0x6004A7F")]
			[Address(RVA = "0x1692640", Offset = "0x1691240", VA = "0x181692640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x0002C850 File Offset: 0x0002AA50
		// (set) Token: 0x06004A81 RID: 19073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700018D")]
		public bool IsPinching
		{
			[Token(Token = "0x6004A80")]
			[Address(RVA = "0x16926B0", Offset = "0x16912B0", VA = "0x1816926B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A81")]
			[Address(RVA = "0x1692B40", Offset = "0x1691740", VA = "0x181692B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x0002C868 File Offset: 0x0002AA68
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700018E")]
		public bool IsDragging
		{
			[Token(Token = "0x6004A82")]
			[Address(RVA = "0x16926A0", Offset = "0x16912A0", VA = "0x1816926A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A83")]
			[Address(RVA = "0x1692B30", Offset = "0x1691730", VA = "0x181692B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x0002C880 File Offset: 0x0002AA80
		[Token(Token = "0x1700018F")]
		public bool IsDraggingOrPinching
		{
			[Token(Token = "0x6004A84")]
			[Address(RVA = "0x1692680", Offset = "0x1691280", VA = "0x181692680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000190")]
		public AbstractTouchInputController touchInputController
		{
			[Token(Token = "0x6004A85")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A86")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A88 RID: 19080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000191")]
		public Camera Cam
		{
			[Token(Token = "0x6004A87")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A88")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x0002C898 File Offset: 0x0002AA98
		[Token(Token = "0x17000192")]
		private bool IsTranslationZoom
		{
			[Token(Token = "0x6004A89")]
			[Address(RVA = "0x16926D0", Offset = "0x16912D0", VA = "0x1816926D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		// (set) Token: 0x06004A8B RID: 19083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000193")]
		public float CamZoom
		{
			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x1692400", Offset = "0x1691000", VA = "0x181692400")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A8B")]
			[Address(RVA = "0x16928E0", Offset = "0x16914E0", VA = "0x1816928E0")]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06004A8C RID: 19084 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		// (set) Token: 0x06004A8D RID: 19085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000194")]
		public float CamZoomMin
		{
			[Token(Token = "0x6004A8C")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A8D")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		// (set) Token: 0x06004A8F RID: 19087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000195")]
		public float CamZoomMax
		{
			[Token(Token = "0x6004A8E")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A8F")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		// (set) Token: 0x06004A91 RID: 19089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000196")]
		public float CamOverzoomMargin
		{
			[Token(Token = "0x6004A90")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A91")]
			[Address(RVA = "0x1692890", Offset = "0x1691490", VA = "0x181692890")]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x0002C910 File Offset: 0x0002AB10
		// (set) Token: 0x06004A93 RID: 19091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000197")]
		public float CamOverdragMargin
		{
			[Token(Token = "0x6004A92")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A93")]
			[Address(RVA = "0x1692880", Offset = "0x1691480", VA = "0x181692880")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x0002C928 File Offset: 0x0002AB28
		// (set) Token: 0x06004A95 RID: 19093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000198")]
		public float CamFollowFactor
		{
			[Token(Token = "0x6004A94")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A95")]
			[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
			set
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x0002C940 File Offset: 0x0002AB40
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000199")]
		public float AutoScrollDamp
		{
			[Token(Token = "0x6004A96")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
			set
			{
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019A")]
		public AnimationCurve AutoScrollDampCurve
		{
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x0002C958 File Offset: 0x0002AB58
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019B")]
		public float GroundLevelOffset
		{
			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0x1692B20", Offset = "0x1691720", VA = "0x181692B20")]
			set
			{
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x0002C970 File Offset: 0x0002AB70
		// (set) Token: 0x06004A9D RID: 19101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019C")]
		public Vector2 BoundaryMin
		{
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x1692390", Offset = "0x1690F90", VA = "0x181692390")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x1692860", Offset = "0x1691460", VA = "0x181692860")]
			set
			{
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x0002C988 File Offset: 0x0002AB88
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019D")]
		public Vector2 BoundaryMax
		{
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0x1692370", Offset = "0x1690F70", VA = "0x181692370")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x1692850", Offset = "0x1691450", VA = "0x181692850")]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019E")]
		public PerspectiveZoomMode PerspectiveZoomMode
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return PerspectiveZoomMode.FIELD_OF_VIEW;
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019F")]
		public bool EnableRotation
		{
			[Token(Token = "0x6004AA2")]
			[Address(RVA = "0x1692600", Offset = "0x1691200", VA = "0x181692600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AA3")]
			[Address(RVA = "0x1692AF0", Offset = "0x16916F0", VA = "0x181692AF0")]
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A0")]
		public bool EnableTilt
		{
			[Token(Token = "0x6004AA4")]
			[Address(RVA = "0x1692610", Offset = "0x1691210", VA = "0x181692610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AA5")]
			[Address(RVA = "0x1692B00", Offset = "0x1691700", VA = "0x181692B00")]
			set
			{
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A1")]
		public float TiltAngleMin
		{
			[Token(Token = "0x6004AA6")]
			[Address(RVA = "0x157CF40", Offset = "0x157BB40", VA = "0x18157CF40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004AA7")]
			[Address(RVA = "0x157D080", Offset = "0x157BC80", VA = "0x18157D080")]
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x0002CA00 File Offset: 0x0002AC00
		// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A2")]
		public float TiltAngleMax
		{
			[Token(Token = "0x6004AA8")]
			[Address(RVA = "0x1692750", Offset = "0x1691350", VA = "0x181692750")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004AA9")]
			[Address(RVA = "0x1692B80", Offset = "0x1691780", VA = "0x181692B80")]
			set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x0002CA18 File Offset: 0x0002AC18
		// (set) Token: 0x06004AAB RID: 19115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A3")]
		public bool EnableZoomTilt
		{
			[Token(Token = "0x6004AAA")]
			[Address(RVA = "0x1692620", Offset = "0x1691220", VA = "0x181692620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AAB")]
			[Address(RVA = "0x1692B10", Offset = "0x1691710", VA = "0x181692B10")]
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x0002CA30 File Offset: 0x0002AC30
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A4")]
		public float ZoomTiltAngleMin
		{
			[Token(Token = "0x6004AAC")]
			[Address(RVA = "0x1692770", Offset = "0x1691370", VA = "0x181692770")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004AAD")]
			[Address(RVA = "0x1692BA0", Offset = "0x16917A0", VA = "0x181692BA0")]
			set
			{
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x0002CA48 File Offset: 0x0002AC48
		// (set) Token: 0x06004AAF RID: 19119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A5")]
		public float ZoomTiltAngleMax
		{
			[Token(Token = "0x6004AAE")]
			[Address(RVA = "0x1692760", Offset = "0x1691360", VA = "0x181692760")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004AAF")]
			[Address(RVA = "0x1692B90", Offset = "0x1691790", VA = "0x181692B90")]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x0002CA60 File Offset: 0x0002AC60
		[Token(Token = "0x170001A6")]
		public Plane RefPlane
		{
			[Token(Token = "0x6004AB0")]
			[Address(RVA = "0x1692710", Offset = "0x1691310", VA = "0x181692710")]
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A7")]
		private List<Vector3> DragCameraMoveVector
		{
			[Token(Token = "0x6004AB1")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB2")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x0002CA78 File Offset: 0x0002AC78
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A8")]
		public bool IsSmoothingEnabled
		{
			[Token(Token = "0x6004AB3")]
			[Address(RVA = "0x16926C0", Offset = "0x16912C0", VA = "0x1816926C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0x1692B50", Offset = "0x1691750", VA = "0x181692B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06004AB5 RID: 19125 RVA: 0x0002CA90 File Offset: 0x0002AC90
		// (set) Token: 0x06004AB6 RID: 19126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A9")]
		private float ScreenRatio
		{
			[Token(Token = "0x6004AB5")]
			[Address(RVA = "0x1692730", Offset = "0x1691330", VA = "0x181692730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004AB6")]
			[Address(RVA = "0x1692B60", Offset = "0x1691760", VA = "0x181692B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AA")]
		public Vector2 CamPosMin
		{
			[Token(Token = "0x6004AB7")]
			[Address(RVA = "0x16923D0", Offset = "0x1690FD0", VA = "0x1816923D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004AB8")]
			[Address(RVA = "0x16928B0", Offset = "0x16914B0", VA = "0x1816928B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06004AB9 RID: 19129 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		// (set) Token: 0x06004ABA RID: 19130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AB")]
		public Vector2 CamPosMax
		{
			[Token(Token = "0x6004AB9")]
			[Address(RVA = "0x16923B0", Offset = "0x1690FB0", VA = "0x1816923B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004ABA")]
			[Address(RVA = "0x16928A0", Offset = "0x16914A0", VA = "0x1816928A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004ABC RID: 19132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AC")]
		public TerrainCollider TerrainCollider
		{
			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0x1692740", Offset = "0x1691340", VA = "0x181692740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ABC")]
			[Address(RVA = "0x1692B70", Offset = "0x1691770", VA = "0x181692B70")]
			set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AD")]
		public bool AllowDragOrPinch
		{
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0x1692340", Offset = "0x1690F40", VA = "0x181692340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004ABE")]
			[Address(RVA = "0x1692820", Offset = "0x1691420", VA = "0x181692820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
		// (set) Token: 0x06004AC0 RID: 19136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001AE")]
		public bool AllowDragStart
		{
			[Token(Token = "0x6004ABF")]
			[Address(RVA = "0x1692350", Offset = "0x1690F50", VA = "0x181692350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AC0")]
			[Address(RVA = "0x1692830", Offset = "0x1691430", VA = "0x181692830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06004AC1 RID: 19137 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004AC2 RID: 19138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000029")]
		public event MobileTouchCamera.ZoomUpdateDelegate OnZoomUpdate
		{
			[Token(Token = "0x6004AC1")]
			[Address(RVA = "0x16922A0", Offset = "0x1690EA0", VA = "0x1816922A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0x1692780", Offset = "0x1691380", VA = "0x181692780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x168B910", Offset = "0x168A510", VA = "0x18168B910")]
		public void Awake()
		{
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x16907F0", Offset = "0x168F3F0", VA = "0x1816907F0")]
		public void Start()
		{
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x168F550", Offset = "0x168E150", VA = "0x18168F550")]
		public void OnDestroy()
		{
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x168FFB0", Offset = "0x168EBB0", VA = "0x18168FFB0")]
		public void ResetCameraBoundaries()
		{
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x168FFE0", Offset = "0x168EBE0", VA = "0x18168FFE0")]
		public void ResetZoomTilt()
		{
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x0002CB08 File Offset: 0x0002AD08
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x168D6A0", Offset = "0x168C2A0", VA = "0x18168D6A0")]
		public Vector3 GetFinger0PosWorld()
		{
			return default(Vector3);
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0002CB20 File Offset: 0x0002AD20
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x168FDF0", Offset = "0x168E9F0", VA = "0x18168FDF0")]
		public bool RaycastGround(Ray ray, out Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0002CB38 File Offset: 0x0002AD38
		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x168DB40", Offset = "0x168C740", VA = "0x18168DB40")]
		public Vector3 GetIntersectionPoint(Ray ray)
		{
			return default(Vector3);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0002CB50 File Offset: 0x0002AD50
		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x168D870", Offset = "0x168C470", VA = "0x18168D870")]
		public Vector3 GetIntersectionPointUnsafe(Ray ray)
		{
			return default(Vector3);
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0002CB68 File Offset: 0x0002AD68
		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x168DCC0", Offset = "0x168C8C0", VA = "0x18168DCC0")]
		public bool GetIsBoundaryPosition(Vector3 testPosition)
		{
			return default(bool);
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x0002CB80 File Offset: 0x0002AD80
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x168D2B0", Offset = "0x168BEB0", VA = "0x18168D2B0")]
		public Vector3 GetClampToBoundaries(Vector3 newPosition, bool includeSpringBackMargin = false)
		{
			return default(Vector3);
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x168FCC0", Offset = "0x168E8C0", VA = "0x18168FCC0")]
		public void OnDragSceneObject()
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x168BEC0", Offset = "0x168AAC0", VA = "0x18168BEC0")]
		public string CheckCameraAxesErrors()
		{
			return null;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x0002CB98 File Offset: 0x0002AD98
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x1690FC0", Offset = "0x168FBC0", VA = "0x181690FC0")]
		public Vector3 UnprojectVector2(Vector2 v2, float offset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x168FDC0", Offset = "0x168E9C0", VA = "0x18168FDC0")]
		public Vector2 ProjectVector3(Vector3 v3)
		{
			return default(Vector2);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x168E490", Offset = "0x168D090", VA = "0x18168E490")]
		private IEnumerator InitCamBoundariesDelayed()
		{
			return null;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x1690010", Offset = "0x168EC10", VA = "0x181690010")]
		private void Reset()
		{
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x1691200", Offset = "0x168FE00", VA = "0x181691200")]
		private void UpdatePinch(float deltaTime)
		{
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x1691D70", Offset = "0x1690970", VA = "0x181691D70")]
		private void UpdateTiltForAutoTilt(float newCameraSize)
		{
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x168CBC0", Offset = "0x168B7C0", VA = "0x18168CBC0")]
		private void DoPositionUpdateForTilt(bool isSpringBack)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x168CA90", Offset = "0x168B690", VA = "0x18168CA90")]
		private float ComputeOvertiltSpringBackFactor(float margin)
		{
			return 0f;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x1691000", Offset = "0x168FC00", VA = "0x181691000")]
		private void UpdateCameraTilt(float angle)
		{
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x168C0A0", Offset = "0x168ACA0", VA = "0x18168C0A0")]
		private void ClampCameraTilt(Vector3 rotationPoint, Vector3 rotationAxis)
		{
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		[Token(Token = "0x6004ADA")]
		[Address(RVA = "0x168D3F0", Offset = "0x168BFF0", VA = "0x18168D3F0")]
		private float GetCurrentTiltAngleDeg(Vector3 rotationAxis)
		{
			return 0f;
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x168DD20", Offset = "0x168C920", VA = "0x18168DD20")]
		private Vector3 GetRotationAxis()
		{
			return default(Vector3);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x168DD70", Offset = "0x168C970", VA = "0x18168DD70")]
		private float GetRotationDeg()
		{
			return 0f;
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0002CC28 File Offset: 0x0002AE28
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x168DF10", Offset = "0x168CB10", VA = "0x18168DF10")]
		private Vector3 GetTiltRotationAxis()
		{
			return default(Vector3);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x1691690", Offset = "0x1690290", VA = "0x181691690")]
		private void UpdatePosition(float deltaTime)
		{
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0002CC40 File Offset: 0x0002AE40
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x168C930", Offset = "0x168B530", VA = "0x18168C930")]
		private Vector3 ComputeOverdragSpringBackVector(Vector3 camPos, float margin, ref Vector3 currentCamScrollVelocity)
		{
			return default(Vector3);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x16907D0", Offset = "0x168F3D0", VA = "0x1816907D0")]
		private void SetTargetPosition(Vector3 newPositionClamped)
		{
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0002CC58 File Offset: 0x0002AE58
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x1690630", Offset = "0x168F230", VA = "0x181690630")]
		private Vector2 RotateVector2(Vector2 v, float degrees)
		{
			return default(Vector2);
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x168C1C0", Offset = "0x168ADC0", VA = "0x18168C1C0")]
		private void ComputeCamBoundaries()
		{
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x1690210", Offset = "0x168EE10", VA = "0x181690210")]
		private void RotateBoundingBox(Vector2 min, Vector2 max, float rotationDegrees, out Vector2 resultMin, out Vector2 resultMax)
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0002CC70 File Offset: 0x0002AE70
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x168D7A0", Offset = "0x168C3A0", VA = "0x18168D7A0")]
		private Vector2 GetIntersection2d(Ray ray)
		{
			return default(Vector2);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x0002CC88 File Offset: 0x0002AE88
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x168E120", Offset = "0x168CD20", VA = "0x18168E120")]
		private Vector2 GetVector2Min(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(Vector2);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x168DF60", Offset = "0x168CB60", VA = "0x18168DF60")]
		private Vector2 GetVector2Max(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(Vector2);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x168F390", Offset = "0x168DF90", VA = "0x18168F390")]
		public void LateUpdate()
		{
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x168CB30", Offset = "0x168B730", VA = "0x18168CB30")]
		private float DoEditorCameraZoom(float amount)
		{
			return 0f;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE9")]
		[Address(RVA = "0x168CF60", Offset = "0x168BB60", VA = "0x18168CF60")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x168CF00", Offset = "0x168BB00", VA = "0x18168CF00")]
		private float EvaluateAutoScrollDampCurve(float t)
		{
			return 0f;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x168EAD0", Offset = "0x168D6D0", VA = "0x18168EAD0")]
		private void InputControllerOnFingerDown(Vector3 pos)
		{
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x168EB20", Offset = "0x168D720", VA = "0x18168EB20")]
		private void InputControllerOnFingerUp()
		{
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x168D560", Offset = "0x168C160", VA = "0x18168D560")]
		private Vector3 GetDragVector(Vector3 dragPosStart, Vector3 dragPosCurrent)
		{
			return default(Vector3);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0002CD00 File Offset: 0x0002AF00
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x168E2E0", Offset = "0x168CEE0", VA = "0x18168E2E0")]
		private Vector3 GetVelocityFromMoveHistory()
		{
			return default(Vector3);
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEF")]
		[Address(RVA = "0x168E510", Offset = "0x168D110", VA = "0x18168E510")]
		private void InputControllerOnDragStart(Vector3 dragPosStart, bool isLongTap)
		{
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x168E8C0", Offset = "0x168D4C0", VA = "0x18168E8C0")]
		private void InputControllerOnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x168E620", Offset = "0x168D220", VA = "0x18168E620")]
		private void InputControllerOnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x168EE30", Offset = "0x168DA30", VA = "0x18168EE30")]
		private void InputControllerOnPinchStart(Vector3 pinchCenter, float pinchDistance)
		{
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x168F010", Offset = "0x168DC10", VA = "0x18168F010")]
		private void InputControllerOnPinchUpdate(PinchUpdateData pinchUpdateData)
		{
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x168FFC0", Offset = "0x168EBC0", VA = "0x18168FFC0")]
		private void ResetPinchRotation(float currentPinchRotation)
		{
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x168EFB0", Offset = "0x168DBB0", VA = "0x18168EFB0")]
		private void InputControllerOnPinchStop()
		{
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x168EB30", Offset = "0x168D730", VA = "0x18168EB30")]
		private void InputControllerOnInputClick(Vector3 clickPosition, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0002CD18 File Offset: 0x0002AF18
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x168DED0", Offset = "0x168CAD0", VA = "0x18168DED0")]
		private float GetScreenRatio()
		{
			return 0f;
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x1691E60", Offset = "0x1690A60", VA = "0x181691E60")]
		private IEnumerator ZoomToTargetValueCoroutine(float target)
		{
			return null;
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x168D200", Offset = "0x168BE00", VA = "0x18168D200")]
		private Ray GetCamCenterRay()
		{
			return default(Ray);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x168FCD0", Offset = "0x168E8D0", VA = "0x18168FCD0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x1691EF0", Offset = "0x1690AF0", VA = "0x181691EF0")]
		public MobileTouchCamera()
		{
		}

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("You need to define whether your camera is a side-view camera (which is the default when using the 2D mode of unity) or if you chose a top-down looking camera. This parameter tells the system whether to scroll in XY direction, or in XZ direction.")]
		private CameraPlaneAxes cameraAxes;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("When using a perspective camera, the zoom can either be performed by changing the field of view, or by moving the camera closer to the scene.")]
		private PerspectiveZoomMode perspectiveZoomMode;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("For perspective cameras this value denotes the min field of view used for zooming (field of view zoom), or the min distance to the ground (translation zoom). For orthographic cameras it denotes the min camera size.")]
		private float camZoomMin;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("For perspective cameras this value denotes the max field of view used for zooming (field of view zoom), or the max distance to the ground (translation zoom). For orthographic cameras it denotes the max camera size.")]
		private float camZoomMax;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("The cam will overzoom the min/max values by this amount and spring back when the user releases the zoom.")]
		private float camOverzoomMargin;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Tooltip("When dragging the camera close to the defined border, it will spring back when the user stops dragging. This value defines the distance from the border where the camera will spring back to.")]
		private float camOverdragMargin;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("These values define the scrolling borders for the camera. The camera will not scroll further than defined here. When a top-down camera is used, these 2 values are applied to the X/Z position.")]
		private Vector2 boundaryMin;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("These values define the scrolling borders for the camera. The camera will not scroll further than defined here. When a top-down camera is used, these 2 values are applied to the X/Z position.")]
		private Vector2 boundaryMax;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("The lower the value, the slower the camera will follow. The higher the value, the more direct the camera will follow movement updates. Necessary for keeping the camera smooth when the framerate is not in sync with the touch input update rate.")]
		[Header("Advanced")]
		private float camFollowFactor;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Tooltip("Set the behaviour of the damping (e.g. the slow-down) at the end of auto-scrolling.")]
		private AutoScrollDampMode autoScrollDampMode;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("When dragging quickly, the camera will keep autoscrolling in the last direction. The autoscrolling will slowly come to a halt. This value defines how fast the camera will come to a halt.")]
		private float autoScrollDamp;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("This curve allows to modulate the auto scroll damp value over time.")]
		private AnimationCurve autoScrollDampCurve;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("The camera assumes that the scrollable content of your scene (e.g. the ground of your game-world) is located at y = 0 for top-down cameras or at z = 0 for side-scrolling cameras. In case this is not valid for your scene, you may adjust this property to the correct offset.")]
		private float groundLevelOffset;

		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Tooltip("When enabled, the camera can be rotated using a 2-finger rotation gesture.")]
		private bool enableRotation;

		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x6D")]
		[SerializeField]
		[Tooltip("When enabled, the camera can be tilted using a synced 2-finger up or down motion.")]
		private bool enableTilt;

		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("The minimum tilt angle for the camera.")]
		private float tiltAngleMin;

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Tooltip("The maximum tilt angle for the camera.")]
		private float tiltAngleMax;

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Tooltip("When enabled, the camera is tilted automatically when zooming.")]
		private bool enableZoomTilt;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Tooltip("The minimum tilt angle for the camera when using zoom tilt.")]
		private float zoomTiltAngleMin;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("The maximum tilt angle for the camera when using zoom tilt.")]
		private float zoomTiltAngleMax;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool allowDragByDefault;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when an item with Collider is tapped on.")]
		[Header("Event Callbacks")]
		private UnityEventWithRaycastHit OnPickItem;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when an item with Collider2D is tapped on.")]
		private UnityEventWithRaycastHit2D OnPickItem2D;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when an item with Collider is double-tapped on.")]
		private UnityEventWithRaycastHit OnPickItemDoubleClick;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when an item with Collider2D is double-tapped on.")]
		private UnityEventWithRaycastHit2D OnPickItem2DDoubleClick;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 dragStartCamPos;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 cameraScrollVelocity;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0xC0")]
		private float pinchStartCamZoomSize;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 pinchStartIntersectionCenter;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 pinchCenterCurrent;

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0xDC")]
		private float pinchDistanceCurrent;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0xE0")]
		private float pinchAngleCurrent;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0xE4")]
		private float pinchDistanceStart;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 pinchCenterCurrentLerp;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0xF4")]
		private float pinchDistanceCurrentLerp;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0xF8")]
		private float pinchAngleCurrentLerp;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0xFC")]
		private bool isRotationLock;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0xFD")]
		private bool isRotationActivated;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x100")]
		private float pinchAngleLastFrame;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x104")]
		private float pinchTiltCurrent;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x108")]
		private float pinchTiltAccumulated;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x10C")]
		private bool isTiltModeEvaluated;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x110")]
		private float pinchTiltLastFrame;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x114")]
		private bool isPinchTiltMode;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x118")]
		private float timeRealDragStop;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x128")]
		[Header("Expert Mode")]
		[SerializeField]
		private bool expertModeEnabled;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Tooltip("Depending on your settings the camera allows to zoom slightly over the defined value. When releasing the zoom the camera will spring back to the defined value. This variable defines the speed of the spring back.")]
		private float zoomBackSpringFactor;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Tooltip("When close to the border the camera will spring back if the margin is bigger than 0. This variable defines the speed of the spring back.")]
		private float dragBackSpringFactor;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		[Tooltip("When swiping over the screen the camera will keep scrolling a while before coming to a halt. This variable limits the maximum velocity of the auto scroll.")]
		private float autoScrollVelocityMax;

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Tooltip("This value defines how quickly the camera comes to a halt when auto scrolling.")]
		private float dampFactorTimeMultiplier;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Tooltip("When setting this flag to true, the camera will behave like a popular tower defense game. It will either go into an exclusive tilt mode, or into a combined zoom/rotate mode. When set to false, the camera will behave like a popular city building game. The camera won't pan with 2 fingers, and instead zoom, rotate and tilt are done in parallel.")]
		private bool isPinchModeExclusive;

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Tooltip("This value should be kept at 1 for pixel perfect zoom. In case you need a non-pixel perfect, slower or faster zoom however, you can change this value. 0.5f for example will make the camera zoom half as fast as in pixel perfect mode. This value is currently tested only in perspective camera mode with translation based zoom.")]
		private float customZoomSensitivity;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Tooltip("Optional. When assigned, the terrain collider will be used to align items on the ground following the terrain.")]
		private TerrainCollider terrainCollider;

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Tooltip("Optional. When assigned, the given transform will be moved and rotated instead of the one where this component is located on.")]
		private Transform cameraTransform;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Tooltip("A gesture may be interpreted as intended rotation in case the relative rotation angle between 2 frames becomes bigger than this value.")]
		private float rotationDetectionDeltaThreshold;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		[Tooltip("Relative pinch distance must be bigger than this value in order to detect a rotation. This is to prevent errors that occur when the fingers are too close together to properly detect a clean rotation.")]
		private float rotationMinPinchDistance;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Tooltip("The rotation mode is enabled as soon as the rotation by the user becomes bigger than this value (in degrees). The value is used to prevent micro rotations from regular jittering of the fingers to be interpreted as rotation and helps keeping the camera more steady and less jittery.")]
		private float rotationLockThreshold;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		[Tooltip("After this amount of finger-movement (relative to screen size), the pinch mode is decided. E.g. whether tilt mode or regular mode is used.")]
		private float pinchModeDetectionMoveTreshold;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Tooltip("A threshold used to detect the up or down tilting motion.")]
		private float pinchTiltModeThreshold;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		[Tooltip("The tilt sensitivity once the tilt mode has started.")]
		private float pinchTiltSpeed;

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x170")]
		private bool isStarted;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x180")]
		private bool isDraggingSceneObject;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x184")]
		private Plane refPlaneXY;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x194")]
		private Plane refPlaneXZ;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		private const int momentumSamplesCount = 5;

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		private const float pinchDistanceForTiltBreakout = 0.05f;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		private const float pinchAccumBreakout = 0.025f;

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x1B0")]
		private Vector3 targetPositionClamped;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x1E0")]
		private bool enableOvertiltSpring;

		// Token: 0x04000EEB RID: 3819
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x1E4")]
		private float camOvertiltMargin;

		// Token: 0x04000EEC RID: 3820
		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x1E8")]
		private float tiltBackSpringFactor;

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x1EC")]
		private float minOvertiltSpringPositionThreshold;

		// Token: 0x02000456 RID: 1110
		// (Invoke) Token: 0x06004AFD RID: 19197
		[Token(Token = "0x2000456")]
		public delegate void ZoomUpdateDelegate(float oldZoomSize, float newZoomSize);
	}
}
