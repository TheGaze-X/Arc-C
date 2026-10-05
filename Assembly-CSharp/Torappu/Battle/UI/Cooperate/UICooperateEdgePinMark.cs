using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003416 RID: 13334
	[Token(Token = "0x2003416")]
	public class UICooperateEdgePinMark : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x060154F9 RID: 87289 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060154FA RID: 87290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700327D")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public Transform target
		{
			[Token(Token = "0x60154F9")]
			[Address(RVA = "0xDD76D0", Offset = "0xDD62D0", VA = "0x180DD76D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60154FA")]
			[Address(RVA = "0xDD77A0", Offset = "0xDD63A0", VA = "0x180DD77A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x060154FB RID: 87291 RVA: 0x0008B3B0 File Offset: 0x000895B0
		// (set) Token: 0x060154FC RID: 87292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700327E")]
		public Vector2 screenPos
		{
			[Token(Token = "0x60154FB")]
			[Address(RVA = "0xDD7660", Offset = "0xDD6260", VA = "0x180DD7660")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60154FC")]
			[Address(RVA = "0xDD7730", Offset = "0xDD6330", VA = "0x180DD7730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060154FD RID: 87293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154FD")]
		[Address(RVA = "0xDD6FE0", Offset = "0xDD5BE0", VA = "0x180DD6FE0")]
		public void ResetMark()
		{
		}

		// Token: 0x060154FE RID: 87294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154FE")]
		[Address(RVA = "0xDD6970", Offset = "0xDD5570", VA = "0x180DD6970")]
		public void MarkUpdate(Vector3 pos, float angle)
		{
		}

		// Token: 0x060154FF RID: 87295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154FF")]
		[Address(RVA = "0xDD7300", Offset = "0xDD5F00", VA = "0x180DD7300")]
		public void SetTarget(Transform tile, float speed, int type)
		{
		}

		// Token: 0x06015500 RID: 87296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015500")]
		[Address(RVA = "0xDD68F0", Offset = "0xDD54F0", VA = "0x180DD68F0")]
		public void ClearTarget()
		{
		}

		// Token: 0x06015501 RID: 87297 RVA: 0x0008B3C8 File Offset: 0x000895C8
		[Token(Token = "0x6015501")]
		[Address(RVA = "0xDD7050", Offset = "0xDD5C50", VA = "0x180DD7050")]
		public bool SetActiveInternal(bool active)
		{
			return default(bool);
		}

		// Token: 0x06015502 RID: 87298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015502")]
		[Address(RVA = "0xDD6E50", Offset = "0xDD5A50", VA = "0x180DD6E50")]
		public void OnCameraMove()
		{
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x06015503 RID: 87299 RVA: 0x0008B3E0 File Offset: 0x000895E0
		[Token(Token = "0x1700327F")]
		public bool hasTarget
		{
			[Token(Token = "0x6015503")]
			[Address(RVA = "0xDD7510", Offset = "0xDD6110", VA = "0x180DD7510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015504 RID: 87300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015504")]
		[Address(RVA = "0xDD74A0", Offset = "0xDD60A0", VA = "0x180DD74A0")]
		public UICooperateEdgePinMark()
		{
		}

		// Token: 0x0401979A RID: 104346
		[Token(Token = "0x401979A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _mark;

		// Token: 0x0401979B RID: 104347
		[Token(Token = "0x401979B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _markIconPos;

		// Token: 0x0401979C RID: 104348
		[Token(Token = "0x401979C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _followRect;

		// Token: 0x0401979D RID: 104349
		[Token(Token = "0x401979D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RectTransform> _icons;

		// Token: 0x0401979E RID: 104350
		[Token(Token = "0x401979E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _cameraMoveDuration;

		// Token: 0x0401979F RID: 104351
		[Token(Token = "0x401979F")]
		[FieldOffset(Offset = "0x3C")]
		private float m_speed;

		// Token: 0x040197A0 RID: 104352
		[Token(Token = "0x40197A0")]
		[FieldOffset(Offset = "0x40")]
		private int m_curType;

		// Token: 0x040197A3 RID: 104355
		[Token(Token = "0x40197A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040197A4 RID: 104356
		[Token(Token = "0x40197A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_target;

		// Token: 0x040197A5 RID: 104357
		[Token(Token = "0x40197A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_screenPos;

		// Token: 0x040197A6 RID: 104358
		[Token(Token = "0x40197A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_screenPos;

		// Token: 0x040197A7 RID: 104359
		[Token(Token = "0x40197A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetMark;

		// Token: 0x040197A8 RID: 104360
		[Token(Token = "0x40197A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MarkUpdate;

		// Token: 0x040197A9 RID: 104361
		[Token(Token = "0x40197A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetTarget;

		// Token: 0x040197AA RID: 104362
		[Token(Token = "0x40197AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearTarget;

		// Token: 0x040197AB RID: 104363
		[Token(Token = "0x40197AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetActiveInternal;

		// Token: 0x040197AC RID: 104364
		[Token(Token = "0x40197AC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCameraMove;

		// Token: 0x040197AD RID: 104365
		[Token(Token = "0x40197AD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_hasTarget;

		// Token: 0x040197AE RID: 104366
		[Token(Token = "0x40197AE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003417 RID: 13335
		[Token(Token = "0x2003417")]
		public class BoatMarkInfo
		{
			// Token: 0x06015505 RID: 87301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015505")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BoatMarkInfo()
			{
			}

			// Token: 0x040197AF RID: 104367
			[Token(Token = "0x40197AF")]
			[FieldOffset(Offset = "0x10")]
			public int pinType;

			// Token: 0x040197B0 RID: 104368
			[Token(Token = "0x40197B0")]
			[FieldOffset(Offset = "0x18")]
			public Transform pos;

			// Token: 0x040197B1 RID: 104369
			[Token(Token = "0x40197B1")]
			[FieldOffset(Offset = "0x20")]
			public bool attach;
		}
	}
}
