using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x020018E1 RID: 6369
	[Token(Token = "0x20018E1")]
	public class DIYRoomIndicator : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001272")]
		public DIYRoom.ISpaceOccupation currentOccupation
		{
			[Token(Token = "0x600A09D")]
			[Address(RVA = "0x31AA450", Offset = "0x31A9050", VA = "0x1831AA450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
		[Token(Token = "0x17001273")]
		public FurnitureLocationType locationType
		{
			[Token(Token = "0x600A09E")]
			[Address(RVA = "0x31AA590", Offset = "0x31A9190", VA = "0x1831AA590")]
			get
			{
				return FurnitureLocationType.GROUND;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x0003E9D0 File Offset: 0x0003CBD0
		[Token(Token = "0x17001274")]
		private Vector3 centerPosition
		{
			[Token(Token = "0x600A09F")]
			[Address(RVA = "0x31A9D00", Offset = "0x31A8900", VA = "0x1831A9D00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x0003E9E8 File Offset: 0x0003CBE8
		[Token(Token = "0x17001275")]
		private Vector3 opButtonPosition
		{
			[Token(Token = "0x600A0A0")]
			[Address(RVA = "0x31AA660", Offset = "0x31A9260", VA = "0x1831AA660")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x0003EA00 File Offset: 0x0003CC00
		[Token(Token = "0x17001276")]
		private Vector3 dragButtonPosition
		{
			[Token(Token = "0x600A0A1")]
			[Address(RVA = "0x31AA4B0", Offset = "0x31A90B0", VA = "0x1831AA4B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x0003EA18 File Offset: 0x0003CC18
		[Token(Token = "0x17001277")]
		private DIYPage.CameraStateType m_cameraType
		{
			[Token(Token = "0x600A0A2")]
			[Address(RVA = "0x31AA5F0", Offset = "0x31A91F0", VA = "0x1831AA5F0")]
			get
			{
				return DIYPage.CameraStateType.NONE;
			}
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A3")]
		[Address(RVA = "0x31A76F0", Offset = "0x31A62F0", VA = "0x1831A76F0")]
		public void Setup(DIYRoom.ISpaceOccupation occupation, FurnitureLocationType locationType, Camera mainCamera, [Optional] DIYPage.CameraState cameraState, bool enableRotate = false)
		{
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A4")]
		[Address(RVA = "0x31A79E0", Offset = "0x31A65E0", VA = "0x1831A79E0")]
		public void UpdatePosition()
		{
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A5")]
		[Address(RVA = "0x31A8800", Offset = "0x31A7400", VA = "0x1831A8800")]
		private void _UpdatePosition(bool force = false, bool updateTextPos = false)
		{
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A6")]
		[Address(RVA = "0x31A82E0", Offset = "0x31A6EE0", VA = "0x1831A82E0")]
		private void _UpdateButtonTransform()
		{
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A7")]
		[Address(RVA = "0x31A7010", Offset = "0x31A5C10", VA = "0x1831A7010")]
		public void PlayDragedAnim()
		{
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A8")]
		[Address(RVA = "0x31A6DA0", Offset = "0x31A59A0", VA = "0x1831A6DA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0A9")]
		[Address(RVA = "0x31A78B0", Offset = "0x31A64B0", VA = "0x1831A78B0")]
		public void StopDragedAnim()
		{
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AA")]
		[Address(RVA = "0x31A8690", Offset = "0x31A7290", VA = "0x1831A8690")]
		private void _UpdateMaterialColor(Color color)
		{
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AB")]
		[Address(RVA = "0x31A8580", Offset = "0x31A7180", VA = "0x1831A8580")]
		private void _UpdateInnerCubeColor(float density)
		{
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AC")]
		[Address(RVA = "0x31A7EE0", Offset = "0x31A6AE0", VA = "0x1831A7EE0")]
		private void _ParseAllMaterial()
		{
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AD")]
		[Address(RVA = "0x31A7DA0", Offset = "0x31A69A0", VA = "0x1831A7DA0")]
		private void _ClearMaterials()
		{
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AE")]
		[Address(RVA = "0x31A7A50", Offset = "0x31A6650", VA = "0x1831A7A50")]
		private void Update()
		{
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AF")]
		[Address(RVA = "0x31A9BA0", Offset = "0x31A87A0", VA = "0x1831A9BA0")]
		public DIYRoomIndicator()
		{
		}

		// Token: 0x040096AE RID: 38574
		[Token(Token = "0x40096AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _coordinatorText;

		// Token: 0x040096AF RID: 38575
		[Token(Token = "0x40096AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _coordinatorFormat;

		// Token: 0x040096B0 RID: 38576
		[Token(Token = "0x40096B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _opButtonRoot;

		// Token: 0x040096B1 RID: 38577
		[Token(Token = "0x40096B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Renderer[] _opButtonRenderers;

		// Token: 0x040096B2 RID: 38578
		[Token(Token = "0x40096B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Renderer> _rotateButtonRenderers;

		// Token: 0x040096B3 RID: 38579
		[Token(Token = "0x40096B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _dragButtonRoot;

		// Token: 0x040096B4 RID: 38580
		[Token(Token = "0x40096B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Renderer[] _dragButtonRenderers;

		// Token: 0x040096B5 RID: 38581
		[Token(Token = "0x40096B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _positiveOffset;

		// Token: 0x040096B6 RID: 38582
		[Token(Token = "0x40096B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _negativeOffset;

		// Token: 0x040096B7 RID: 38583
		[Token(Token = "0x40096B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _horizontalOffset;

		// Token: 0x040096B8 RID: 38584
		[Token(Token = "0x40096B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] _frameObjects;

		// Token: 0x040096B9 RID: 38585
		[Token(Token = "0x40096B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform[] _frameEdgeObjects;

		// Token: 0x040096BA RID: 38586
		[Token(Token = "0x40096BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _edgeLengthWeight;

		// Token: 0x040096BB RID: 38587
		[Token(Token = "0x40096BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _edgeLengthBias;

		// Token: 0x040096BC RID: 38588
		[Token(Token = "0x40096BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _animInterval;

		// Token: 0x040096BD RID: 38589
		[Token(Token = "0x40096BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color _toneColor;

		// Token: 0x040096BE RID: 38590
		[Token(Token = "0x40096BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Renderer _innerCubeRenderer;

		// Token: 0x040096BF RID: 38591
		[Token(Token = "0x40096BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _innerCubeColor;

		// Token: 0x040096C0 RID: 38592
		[Token(Token = "0x40096C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _opButtonHorizontalThreshold;

		// Token: 0x040096C1 RID: 38593
		[Token(Token = "0x40096C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _opButtonVerticalThreshold;

		// Token: 0x040096C2 RID: 38594
		[Token(Token = "0x40096C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DIYRoom.ISpaceOccupation m_currentOccupation;

		// Token: 0x040096C3 RID: 38595
		[Token(Token = "0x40096C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FurnitureLocationType m_locationType;

		// Token: 0x040096C4 RID: 38596
		[Token(Token = "0x40096C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int m_prePosition0;

		// Token: 0x040096C5 RID: 38597
		[Token(Token = "0x40096C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_prePosition1;

		// Token: 0x040096C6 RID: 38598
		[Token(Token = "0x40096C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Camera m_camera;

		// Token: 0x040096C7 RID: 38599
		[Token(Token = "0x40096C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private DIYPage.CameraState m_cameraState;

		// Token: 0x040096C8 RID: 38600
		[Token(Token = "0x40096C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Material> m_colorMaterials;

		// Token: 0x040096C9 RID: 38601
		[Token(Token = "0x40096C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<Tween> m_DragedTween;

		// Token: 0x040096CA RID: 38602
		[Token(Token = "0x40096CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_enableRotate;

		// Token: 0x040096CB RID: 38603
		[Token(Token = "0x40096CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float m_buttonDisableAlpha;

		// Token: 0x040096CC RID: 38604
		[Token(Token = "0x40096CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentOccupation;

		// Token: 0x040096CD RID: 38605
		[Token(Token = "0x40096CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_locationType;

		// Token: 0x040096CE RID: 38606
		[Token(Token = "0x40096CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_centerPosition;

		// Token: 0x040096CF RID: 38607
		[Token(Token = "0x40096CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_opButtonPosition;

		// Token: 0x040096D0 RID: 38608
		[Token(Token = "0x40096D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dragButtonPosition;

		// Token: 0x040096D1 RID: 38609
		[Token(Token = "0x40096D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_m_cameraType;

		// Token: 0x040096D2 RID: 38610
		[Token(Token = "0x40096D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x040096D3 RID: 38611
		[Token(Token = "0x40096D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdatePosition;

		// Token: 0x040096D4 RID: 38612
		[Token(Token = "0x40096D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdatePosition;

		// Token: 0x040096D5 RID: 38613
		[Token(Token = "0x40096D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateButtonTransform;

		// Token: 0x040096D6 RID: 38614
		[Token(Token = "0x40096D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayDragedAnim;

		// Token: 0x040096D7 RID: 38615
		[Token(Token = "0x40096D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040096D8 RID: 38616
		[Token(Token = "0x40096D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_StopDragedAnim;

		// Token: 0x040096D9 RID: 38617
		[Token(Token = "0x40096D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateMaterialColor;

		// Token: 0x040096DA RID: 38618
		[Token(Token = "0x40096DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateInnerCubeColor;

		// Token: 0x040096DB RID: 38619
		[Token(Token = "0x40096DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ParseAllMaterial;

		// Token: 0x040096DC RID: 38620
		[Token(Token = "0x40096DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearMaterials;

		// Token: 0x040096DD RID: 38621
		[Token(Token = "0x40096DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040096DE RID: 38622
		[Token(Token = "0x40096DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
