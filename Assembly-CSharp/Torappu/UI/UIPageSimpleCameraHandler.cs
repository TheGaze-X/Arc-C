using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003636 RID: 13878
	[Token(Token = "0x2003636")]
	public class UIPageSimpleCameraHandler : ISimpleCameraHandler, IHotfixable
	{
		// Token: 0x06016189 RID: 90505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016189")]
		[Address(RVA = "0xEA52D0", Offset = "0xEA3ED0", VA = "0x180EA52D0")]
		public UIPageSimpleCameraHandler(Camera camera)
		{
		}

		// Token: 0x0601618A RID: 90506 RVA: 0x0008F6A0 File Offset: 0x0008D8A0
		[Token(Token = "0x601618A")]
		[Address(RVA = "0xEA5140", Offset = "0xEA3D40", VA = "0x180EA5140", Slot = "5")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0601618B RID: 90507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601618B")]
		[Address(RVA = "0xEA50E0", Offset = "0xEA3CE0", VA = "0x180EA50E0", Slot = "4")]
		public Camera GetSimpleCamera()
		{
			return null;
		}

		// Token: 0x0601618C RID: 90508 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
		[Token(Token = "0x601618C")]
		[Address(RVA = "0xEA5060", Offset = "0xEA3C60", VA = "0x180EA5060", Slot = "6")]
		public SortingInfo GetInitSortingInfo()
		{
			return default(SortingInfo);
		}

		// Token: 0x0601618D RID: 90509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601618D")]
		[Address(RVA = "0xEA5250", Offset = "0xEA3E50", VA = "0x180EA5250", Slot = "7")]
		public void RequestSimpleCamera()
		{
		}

		// Token: 0x0601618E RID: 90510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601618E")]
		[Address(RVA = "0xEA51D0", Offset = "0xEA3DD0", VA = "0x180EA51D0", Slot = "8")]
		public void ReleaseSimpleCamera()
		{
		}

		// Token: 0x0601618F RID: 90511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601618F")]
		[Address(RVA = "0xEA4FE0", Offset = "0xEA3BE0", VA = "0x180EA4FE0", Slot = "9")]
		public void BindInitCanvasOnSimplePage(Canvas canvas)
		{
		}

		// Token: 0x06016190 RID: 90512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016190")]
		[Address(RVA = "0xEA4BC0", Offset = "0xEA37C0", VA = "0x180EA4BC0", Slot = "10")]
		public void AdjustSimpleCamToHighest()
		{
		}

		// Token: 0x06016191 RID: 90513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016191")]
		[Address(RVA = "0xEA4C80", Offset = "0xEA3880", VA = "0x180EA4C80", Slot = "11")]
		public void AdjustSimpleCamToLowest()
		{
		}

		// Token: 0x06016192 RID: 90514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016192")]
		[Address(RVA = "0xEA4D30", Offset = "0xEA3930", VA = "0x180EA4D30", Slot = "12")]
		public void AdjustSimplePageOrder(UIPage lower, UIPage upper)
		{
		}

		// Token: 0x0401A942 RID: 108866
		[Token(Token = "0x401A942")]
		[FieldOffset(Offset = "0x10")]
		private Camera m_simpleCamera;

		// Token: 0x0401A943 RID: 108867
		[Token(Token = "0x401A943")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A944 RID: 108868
		[Token(Token = "0x401A944")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0401A945 RID: 108869
		[Token(Token = "0x401A945")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSimpleCamera;

		// Token: 0x0401A946 RID: 108870
		[Token(Token = "0x401A946")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetInitSortingInfo;

		// Token: 0x0401A947 RID: 108871
		[Token(Token = "0x401A947")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RequestSimpleCamera;

		// Token: 0x0401A948 RID: 108872
		[Token(Token = "0x401A948")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReleaseSimpleCamera;

		// Token: 0x0401A949 RID: 108873
		[Token(Token = "0x401A949")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindInitCanvasOnSimplePage;

		// Token: 0x0401A94A RID: 108874
		[Token(Token = "0x401A94A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AdjustSimpleCamToHighest;

		// Token: 0x0401A94B RID: 108875
		[Token(Token = "0x401A94B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AdjustSimpleCamToLowest;

		// Token: 0x0401A94C RID: 108876
		[Token(Token = "0x401A94C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AdjustSimplePageOrder;
	}
}
