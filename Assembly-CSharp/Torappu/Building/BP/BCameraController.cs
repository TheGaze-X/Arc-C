using System;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001A9A RID: 6810
	[Token(Token = "0x2001A9A")]
	public class BCameraController : SingletonMonoBehaviour<BCameraController>, ISingletonNotAutoCreate
	{
		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x0600AB9B RID: 43931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001445")]
		public ScrollWheelHandler handler
		{
			[Token(Token = "0x600AB9B")]
			[Address(RVA = "0x326B5A0", Offset = "0x326A1A0", VA = "0x18326B5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001446")]
		public Camera camera
		{
			[Token(Token = "0x600AB9C")]
			[Address(RVA = "0x326B530", Offset = "0x326A130", VA = "0x18326B530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600AB9D RID: 43933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001447")]
		public MobileTouchCamera touchCamera
		{
			[Token(Token = "0x600AB9D")]
			[Address(RVA = "0x326B600", Offset = "0x326A200", VA = "0x18326B600")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600AB9E RID: 43934 RVA: 0x000425D0 File Offset: 0x000407D0
		// (set) Token: 0x0600AB9F RID: 43935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001448")]
		public float camZoom
		{
			[Token(Token = "0x600AB9E")]
			[Address(RVA = "0x326B4C0", Offset = "0x326A0C0", VA = "0x18326B4C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600AB9F")]
			[Address(RVA = "0x326B940", Offset = "0x326A540", VA = "0x18326B940")]
			set
			{
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x000425E8 File Offset: 0x000407E8
		// (set) Token: 0x0600ABA1 RID: 43937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001449")]
		public float camZoomMin
		{
			[Token(Token = "0x600ABA0")]
			[Address(RVA = "0x326B450", Offset = "0x326A050", VA = "0x18326B450")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600ABA1")]
			[Address(RVA = "0x326B8C0", Offset = "0x326A4C0", VA = "0x18326B8C0")]
			set
			{
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x00042600 File Offset: 0x00040800
		// (set) Token: 0x0600ABA3 RID: 43939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700144A")]
		public float camZoomMax
		{
			[Token(Token = "0x600ABA2")]
			[Address(RVA = "0x326B3E0", Offset = "0x3269FE0", VA = "0x18326B3E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600ABA3")]
			[Address(RVA = "0x326B840", Offset = "0x326A440", VA = "0x18326B840")]
			set
			{
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600ABA4 RID: 43940 RVA: 0x00042618 File Offset: 0x00040818
		// (set) Token: 0x0600ABA5 RID: 43941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700144B")]
		public Vector2 boundaryMin
		{
			[Token(Token = "0x600ABA4")]
			[Address(RVA = "0x326B360", Offset = "0x3269F60", VA = "0x18326B360")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600ABA5")]
			[Address(RVA = "0x326B7A0", Offset = "0x326A3A0", VA = "0x18326B7A0")]
			set
			{
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x00042630 File Offset: 0x00040830
		// (set) Token: 0x0600ABA7 RID: 43943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700144C")]
		public Vector2 boundaryMax
		{
			[Token(Token = "0x600ABA6")]
			[Address(RVA = "0x326B2E0", Offset = "0x3269EE0", VA = "0x18326B2E0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600ABA7")]
			[Address(RVA = "0x326B700", Offset = "0x326A300", VA = "0x18326B700")]
			set
			{
			}
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABA8")]
		[Address(RVA = "0x326A860", Offset = "0x3269460", VA = "0x18326A860")]
		public void ResetPosition()
		{
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABA9")]
		[Address(RVA = "0x326A7F0", Offset = "0x32693F0", VA = "0x18326A7F0")]
		public void ResetCameraBoundaries()
		{
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x00042648 File Offset: 0x00040848
		// (set) Token: 0x0600ABAB RID: 43947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700144D")]
		public bool allowCameraDrag
		{
			[Token(Token = "0x600ABAA")]
			[Address(RVA = "0x326B270", Offset = "0x3269E70", VA = "0x18326B270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABAB")]
			[Address(RVA = "0x326B660", Offset = "0x326A260", VA = "0x18326B660")]
			set
			{
			}
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABAC")]
		[Address(RVA = "0x326AC00", Offset = "0x3269800", VA = "0x18326AC00")]
		public Tween ZoomTo(float toZoom, BRoomSlot roomSlot, float tweenTime, Ease tweenEaseType, bool resetDefault)
		{
			return null;
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x00042660 File Offset: 0x00040860
		[Token(Token = "0x600ABAD")]
		[Address(RVA = "0x326A410", Offset = "0x3269010", VA = "0x18326A410")]
		public float CalcCamZoom(Vector2 viewPortSize, ScaleType scaleType)
		{
			return 0f;
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x00042678 File Offset: 0x00040878
		[Token(Token = "0x600ABAE")]
		[Address(RVA = "0x326B0F0", Offset = "0x3269CF0", VA = "0x18326B0F0")]
		private float _TangentVertFOV()
		{
			return 0f;
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x00042690 File Offset: 0x00040890
		[Token(Token = "0x600ABAF")]
		[Address(RVA = "0x326B030", Offset = "0x3269C30", VA = "0x18326B030")]
		private float _TangentHoriFOV()
		{
			return 0f;
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB0")]
		[Address(RVA = "0x326A990", Offset = "0x3269590", VA = "0x18326A990")]
		private void Start()
		{
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB1")]
		[Address(RVA = "0x326A620", Offset = "0x3269220", VA = "0x18326A620")]
		private void OnWheelTo(Vector2 delta)
		{
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB2")]
		[Address(RVA = "0x326A380", Offset = "0x3268F80", VA = "0x18326A380")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x000426A8 File Offset: 0x000408A8
		[Token(Token = "0x600ABB3")]
		[Address(RVA = "0x326A5C0", Offset = "0x32691C0", VA = "0x18326A5C0")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x000426C0 File Offset: 0x000408C0
		[Token(Token = "0x600ABB4")]
		[Address(RVA = "0x326AB70", Offset = "0x3269770", VA = "0x18326AB70")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABB5")]
		[Address(RVA = "0x326B200", Offset = "0x3269E00", VA = "0x18326B200")]
		public BCameraController()
		{
		}

		// Token: 0x0400A3C9 RID: 41929
		[Token(Token = "0x400A3C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MobileTouchCamera _touchCamera;

		// Token: 0x0400A3CA RID: 41930
		[Token(Token = "0x400A3CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _zoomXRatioFitC;

		// Token: 0x0400A3CB RID: 41931
		[Token(Token = "0x400A3CB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _defaultPositionX;

		// Token: 0x0400A3CC RID: 41932
		[Token(Token = "0x400A3CC")]
		[FieldOffset(Offset = "0x28")]
		private float? m_tanFOV;

		// Token: 0x0400A3CD RID: 41933
		[Token(Token = "0x400A3CD")]
		[FieldOffset(Offset = "0x30")]
		private Vector3? m_defaultPosition;

		// Token: 0x0400A3CE RID: 41934
		[Token(Token = "0x400A3CE")]
		[FieldOffset(Offset = "0x40")]
		private ScrollWheelHandler m_handler;

		// Token: 0x0400A3CF RID: 41935
		[Token(Token = "0x400A3CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x0400A3D0 RID: 41936
		[Token(Token = "0x400A3D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x0400A3D1 RID: 41937
		[Token(Token = "0x400A3D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_touchCamera;

		// Token: 0x0400A3D2 RID: 41938
		[Token(Token = "0x400A3D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_camZoom;

		// Token: 0x0400A3D3 RID: 41939
		[Token(Token = "0x400A3D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_camZoom;

		// Token: 0x0400A3D4 RID: 41940
		[Token(Token = "0x400A3D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_camZoomMin;

		// Token: 0x0400A3D5 RID: 41941
		[Token(Token = "0x400A3D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_camZoomMin;

		// Token: 0x0400A3D6 RID: 41942
		[Token(Token = "0x400A3D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_camZoomMax;

		// Token: 0x0400A3D7 RID: 41943
		[Token(Token = "0x400A3D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_camZoomMax;

		// Token: 0x0400A3D8 RID: 41944
		[Token(Token = "0x400A3D8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_boundaryMin;

		// Token: 0x0400A3D9 RID: 41945
		[Token(Token = "0x400A3D9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_boundaryMin;

		// Token: 0x0400A3DA RID: 41946
		[Token(Token = "0x400A3DA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_boundaryMax;

		// Token: 0x0400A3DB RID: 41947
		[Token(Token = "0x400A3DB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_boundaryMax;

		// Token: 0x0400A3DC RID: 41948
		[Token(Token = "0x400A3DC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ResetPosition;

		// Token: 0x0400A3DD RID: 41949
		[Token(Token = "0x400A3DD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ResetCameraBoundaries;

		// Token: 0x0400A3DE RID: 41950
		[Token(Token = "0x400A3DE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_allowCameraDrag;

		// Token: 0x0400A3DF RID: 41951
		[Token(Token = "0x400A3DF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_allowCameraDrag;

		// Token: 0x0400A3E0 RID: 41952
		[Token(Token = "0x400A3E0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ZoomTo;

		// Token: 0x0400A3E1 RID: 41953
		[Token(Token = "0x400A3E1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CalcCamZoom;

		// Token: 0x0400A3E2 RID: 41954
		[Token(Token = "0x400A3E2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TangentVertFOV;

		// Token: 0x0400A3E3 RID: 41955
		[Token(Token = "0x400A3E3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TangentHoriFOV;

		// Token: 0x0400A3E4 RID: 41956
		[Token(Token = "0x400A3E4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A3E5 RID: 41957
		[Token(Token = "0x400A3E5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnWheelTo;

		// Token: 0x0400A3E6 RID: 41958
		[Token(Token = "0x400A3E6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0400A3E7 RID: 41959
		[Token(Token = "0x400A3E7")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0400A3E8 RID: 41960
		[Token(Token = "0x400A3E8")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0400A3E9 RID: 41961
		[Token(Token = "0x400A3E9")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
